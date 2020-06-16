using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using GSCCCA.ImageAPI.Client.ApiObjects;
using GSCCCA.ImageAPI.Client.ImageSupport;
using GSCCCA.ImageAPI.Client.Infrastructure;
using Newtonsoft.Json;



namespace GSCCCA.ImageAPI.Client
{
    public class ImageApiClient
    {
        private static HttpClient _staticHttpClient = new HttpClient();
        private HttpClient _httpClient;
        private BearerToken _bearerToken = null;
        private readonly ImageApiClientOptions _clientOptions;
        private string _clientId;
        private string _clientSecret;


        public ImageApiClient(string clientId, string secret) 
            : this(clientId, secret, null, null) { }

        public ImageApiClient(string clientId, string secret, HttpClient httpClient) 
            : this(clientId, secret, httpClient, null) { }

        public ImageApiClient(string clientId, string secret, ImageApiClientOptions clientOptions)
            : this(clientId,secret, null, clientOptions) { }

        public ImageApiClient(string clientId, string secret, HttpClient httpClient, ImageApiClientOptions clientOptions)
        {
            if (string.IsNullOrWhiteSpace(clientId))
                throw new ArgumentException("Client ID is Required", nameof(clientId));
            
            if (string.IsNullOrWhiteSpace(secret))
                throw new ArgumentException("Client Secret is Required", nameof(secret));

            _clientId = clientId;
            _clientSecret = secret;
            _httpClient = httpClient ?? _staticHttpClient;
            _clientOptions = clientOptions ?? new ImageApiClientOptions();
        }

        /// <summary>
        /// Gets details of a batch including all images it contains
        /// </summary>
        /// <param name="batchName">The name of the batch to get</param>
        /// <param name="sendEmail">If this parameter is true. An email containing the batch contents will be sent to the vendor email on file.</param>
        /// <returns></returns>
        public Task<BatchReport> GetBatchReportAsync(string batchName, bool sendEmail = false)
        {
            ValidateBatchName(batchName);

            var bnEncoded = HttpUtility.UrlEncode(batchName);
            var url = GetApiUrl($"reports/{bnEncoded}/{sendEmail}");
            return PerformGet<BatchReport>(url);
        }

        /// <summary>
        /// Closes a batch. After the batch is closed, no more images may be added to it.
        /// </summary>
        /// <param name="batchName">the name of the batch to close.</param>
        /// <returns>CloseBatchAsync</returns>
        public async Task<BatchCloseResult> CloseBatchAsync(string batchName)
        {
            ValidateBatchName(batchName);

            var bnEncoded = HttpUtility.UrlEncode(batchName);
            var url = GetApiUrl($"batches/{bnEncoded}");
            using (var request = new HttpRequestMessage(HttpMethod.Put, url))
            {
                var result = await GetHttpResult(request).ConfigureAwait(false);
                return await DeserializeResultAsync<BatchCloseResult>(result).ConfigureAwait(false);
            }

            
        }

        /// <summary>
        /// Returns a list of batch summaries for each batch created on a specific date (EST)
        /// </summary>
        /// <param name="date">the date the batch was created</param>
        /// <returns>A list of batch</returns>
        public async Task<List<Batch>> GetBatchesAsync(DateTime date)
        {
            //making param required until result of paramless method is fixed
            //var url = date.HasValue ? GetApiUrl($"batches/{date:yyyy-MM-dd}"): GetApiUrl("batches");
            var url = GetApiUrl($"batches/{date:yyyy-MM-dd}");
            return await PerformGet<List<Batch>>(url).ConfigureAwait(false);
        }

        /// <summary>
        /// Uploads a list of local TIF images to GSCCCA. Multiple uploads are performed in parallel.
        /// </summary>
        /// <param name="filePaths">A list of local paths that point to files to be uploaded</param>
        /// <param name="batchName">The name of the batch that the images should be attached to. If the batch does not exist, it will be created.</param>
        /// <param name="statusIndicator">An optional utility class to keep track of upload progress</param>
        /// <returns>A list of results that indicates success or failure for each file</returns>
        public async Task<List<ParallelTransferResult>> UploadImagesAsync(string[] filePaths, string batchName,
            TransferStatusIndicator statusIndicator = null)
        {
            ValidateBatchName(batchName);
            ValidateFilePaths(filePaths);

            if (statusIndicator != null)
                statusIndicator.TotalFiles = filePaths.Length;
            var results = new List<ParallelTransferResult>();

            await ParallelFileOperation(filePaths,
                path =>
                {
                    if (statusIndicator != null)
                    {
                        var t = Task.Run(() =>
                        {
                            statusIndicator.UpdateMessage(path, CurrentEventType.FileStarting, null);
                        });
                    }
                    var task = UploadImageAsync(path, batchName);
                    if (statusIndicator != null)
                    {
                        var c = task.ContinueWith(t =>
                        {
                            statusIndicator.UpdateMessage(path,
                                t.IsFaulted ? CurrentEventType.FileError : CurrentEventType.FileCompleted, t.Exception?.InnerException?.Message);
                        });
                    }
                    return task;
                }
                ,
                tasks =>
                {
                    foreach (var kvp in tasks)
                    {
                        if (kvp.Key.IsFaulted)
                        {
                            results.Add(new ParallelTransferResult(kvp.Value, false, null, kvp.Key.Exception?.InnerException));
                        }
                        else
                        {
                            results.Add(new ParallelTransferResult(kvp.Value, true, kvp.Key.Result, kvp.Key.Exception?.InnerException));
                        }
                    }
                }).ConfigureAwait(false);
            statusIndicator?.SetComplete();
            return results;
        }






        /// <summary>
        /// Downloads all images in a batch to a specified folder. Multiple downloads are performed in parallel.
        /// </summary>
        /// <param name="batchName">The batch to download</param>
        /// <param name="targetFolder">The local destination folder</param>
        /// <param name="statusIndicator">An optional utility class to keep track of download progress</param>
        /// <returns>A list of results that indicates success or failure for each file</returns>
        public async Task<List<ParallelTransferResult>> DownloadBatchAsync(string batchName, string targetFolder,
            TransferStatusIndicator statusIndicator)
        {
            ValidateBatchName(batchName);
            ValidateTargetPaths(targetFolder);

            var batch = await GetBatchReportAsync(batchName).ConfigureAwait(false);
            var images = batch.ImageSubmissions.Where(i => i.Success)
                .Select(i => new ImageDownloadRequest
                {
                    ImageId = i.ImageSubmissionId,
                    TargetPath = Path.Combine(targetFolder, i.FileName)
                });
            
            return await DownloadImagesAsync(images.ToArray(), statusIndicator).ConfigureAwait(false);

        }




        /// <summary>
        /// Download a list of images
        /// </summary>
        /// <param name="imageDownloads">A list of image IDs and target locations they should be downloaded to. Multiple downloads are performed in parallel.</param>
        /// <param name="statusIndicator">An optional utility class to keep track of download progress</param>
        /// <returns>A list of results that indicates success or failure for each file</returns>
        public async Task<List<ParallelTransferResult>> DownloadImagesAsync(ImageDownloadRequest[] imageDownloads,
            TransferStatusIndicator statusIndicator = null)
        {
            var paths = imageDownloads.Select(d => d.TargetPath).ToArray();
            ValidateTargetPaths(paths);

            if (statusIndicator != null)
                statusIndicator.TotalFiles = imageDownloads.Length;

            var results = new List<ParallelTransferResult>();

            await ParallelFileOperation(imageDownloads,
                id =>
                {
                    if (statusIndicator != null)
                    {
                        var t = Task.Run(() =>
                        {
                            statusIndicator.UpdateMessage(id.TargetPath, CurrentEventType.FileStarting, null);
                        });
                    }

                    var task = DownloadImageAsync(id.ImageId, id.TargetPath);

                    if (statusIndicator != null)
                    {
                        var c = task.ContinueWith(t =>
                        {
                            var path = id.TargetPath;
                            statusIndicator.UpdateMessage(path,
                                t.IsFaulted ? CurrentEventType.FileError : CurrentEventType.FileCompleted, t.Exception?.InnerException?.Message);
                        });
                    }

                    return task;
                }
                ,
                tasks =>
                {
                    results.AddRange(tasks.Select(kvp => new ParallelTransferResult(kvp.Value.TargetPath,
                        !kvp.Key.IsFaulted, null, kvp.Key.Exception?.InnerException)));
                }).ConfigureAwait(false);

            statusIndicator?.SetComplete();
            return results;
        }



       /// <summary>
       /// Downloads a single image
       /// </summary>
       /// <param name="imageId">the GSCCCA id of the image</param>
       /// <param name="targetPath">the path, including filename, where the image should be stored</param>
       /// <returns></returns>
        public async Task DownloadImageAsync(long imageId, string targetPath)
        {

            ValidateTargetPaths(targetPath);
            var bytes = await DownloadImageBytesAsync(imageId).ConfigureAwait(false);

            using (var ms = new MemoryStream(bytes))
            using (var f = File.OpenWrite(targetPath))
            {
                await ms.CopyToAsync(f).ConfigureAwait(false);
            }

        }

       

        /// <summary>
        /// Downloads an image and returns a byte array
        /// </summary>
        /// <param name="imageId"></param>
        /// <returns>an array of bytes that compose the tiff image</returns>
        public async Task<byte[]> DownloadImageBytesAsync(long imageId)
        {
            var url = GetApiUrl($"images/{imageId}");
            var result = await PerformGet<string>(url).ConfigureAwait(false);
            return Convert.FromBase64String(result);
        }

        /// <summary>
        /// Uploads an image from a local path to GSCCCA
        /// </summary>
        /// <param name="path">The path of the TIF image to upload</param>
        /// <param name="batchName">The name of the batch that the image should be attached to. If the batch does not exist, it will be created.</param>
        /// <returns></returns>
        public async Task<ImageUploadResult> UploadImageAsync(string path, string batchName)
        {
            ValidateBatchName(batchName);
            ValidateFilePaths(path);

            using (var f = File.OpenRead(path))
            {
                var fileName = Path.GetFileName(path);
                return await UploadImageAsync(f, fileName, batchName).ConfigureAwait(false);
            }
        }

        /// <summary>
        /// Uploads an image to GSCCCA using the GSCCCATiff utility class
        /// </summary>
        /// <param name="gscccaTiff">The GSCCCATiff object to upload</param>
        /// <param name="batchName">The name of the batch that the image should be attached to. If the batch does not exist, it will be created.</param>
        /// <returns></returns>
        public async Task<ImageUploadResult> UploadImageAsync(GSCCCATiff gscccaTiff, string batchName)
        {
            var fn = Path.GetFileName(gscccaTiff.FileName);
            var str = gscccaTiff.GetUnderlyingStream();
            return await UploadImageAsync(str, fn, batchName);
        }

        /// <summary>
        /// Uploads the contents of a stream containing a TIFF image to GSCCCA.
        /// </summary>
        /// <param name="imageContent">A stream containing the TIFF image</param>
        /// <param name="fileName">A filename that represents the image. It must have the .TIF extension.</param>
        /// <param name="batchName">The name of the batch that the image should be attached to. If the batch does not exist, it will be created.</param>
        /// <returns></returns>
        public async Task<ImageUploadResult> UploadImageAsync(Stream imageContent, string fileName, string batchName)
        {
            
            ValidateBatchName(batchName);
            ValidateFileName(fileName);

            using (var ms = new MemoryStream())
            {
                await imageContent.CopyToAsync(ms).ConfigureAwait(false);
                return await UploadImageAsync(ms.ToArray(), fileName, batchName).ConfigureAwait(false);
            }
        }

        /// <summary>
        /// Uploads a byte array containing a TIFF image to GSCCCA.
        /// </summary>
        /// <param name="imageContent">The byte array content containing the TIFF image.</param>
        /// <param name="fileName">A filename that represents the image. It must have the .TIF extension.</param>
        /// <param name="batchName">The name of the batch that the image should be attached to. If the batch does not exist, it will be created.</param>
        /// <returns></returns>
        public async Task<ImageUploadResult> UploadImageAsync(byte[] imageContent, string fileName, string batchName)
        {
            ValidateBatchName(batchName);
            ValidateFileName(fileName);

            if (_clientOptions.PerformTiffValidation)
            {
                var validator = new TiffValidator(_clientOptions.TiffValidationOptions);
                using (var tif = GSCCCATiff.CreateFromBytes(imageContent, fileName))
                {
                    validator.Validate(tif);
                }
            }

            var bnEncoded = HttpUtility.UrlEncode(batchName);
            var url = GetApiUrl($"images/{bnEncoded}");

            var content = new MultipartFormDataContent();

           var checksum = ChecksumCalc.Calculate(imageContent);

           content.Add(new ByteArrayContent(imageContent),"Plat",fileName);

           using (var request = new HttpRequestMessage(HttpMethod.Post, url))
           {
               request.Content = content;
               request.Headers.Add("Checksum", checksum);

               var result = await GetHttpResult(request).ConfigureAwait(false);
               result.EnsureSuccessStatusCode();
               return await DeserializeResultAsync<ImageUploadResult>(result);
           }
        }


        /// <summary>
        /// Create a new batch that will contain uploaded images
        /// </summary>
        /// <param name="batchName">The name of the batch to create</param>
        /// <returns>BatchCreationResult</returns>
        public async Task<BatchCreationResult> CreateBatchAsync(string batchName)
        {
            ValidateBatchName(batchName);
            var bnEncoded = HttpUtility.UrlEncode(batchName);
            var url = GetApiUrl($"batches/{bnEncoded}");
            using (var request = new HttpRequestMessage(HttpMethod.Post, url))
            {
                var result = await GetHttpResult(request).ConfigureAwait(false);

                return await DeserializeResultAsync<BatchCreationResult>(result).ConfigureAwait(false);
            }

        }

        private void ValidateFileName(string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
                throw new ArgumentException("Filename cannot be null or empty", nameof(fileName));

            if (fileName.IndexOfAny(Path.GetInvalidFileNameChars()) > 0)
            {
                var invalidChars = new string(Path.GetInvalidFileNameChars());
                throw new ArgumentException($"{fileName} is invalid. the characters {invalidChars} are not allowed in file names");
            }

            var ext = (Path.GetExtension(fileName) ?? "").ToLower();
            if (ext != ".tif" && ext != ".tiff")
                throw new ArgumentException($"{fileName} is invalid. Only files with the extension tif and tiff are accepted.");

        }


        private void ValidateTargetPaths(params string[] targetPaths)
        {
            foreach (var path in targetPaths)
            {
                var dir = Path.GetDirectoryName(path);
                if (!Directory.Exists(dir))
                    throw new ArgumentException($"Path {path} does not exist");
            }
        }


        private void ValidateFilePaths(params string[] filePaths)
        {
            foreach (var filePath in filePaths)
            {
                if (!File.Exists(filePath))
                    throw new ArgumentException($"{filePath} does not exist");

                var ext = (Path.GetExtension(filePath) ?? "").ToLower();
                if (ext != ".tif" && ext != ".tiff")
                    throw new ArgumentException($"{filePath} is invalid. Only files with the extension tif and tiff are accepted.");
            }
        }


        private void ValidateBatchName(string batchName)
        {
            if (string.IsNullOrWhiteSpace(batchName))
                throw new ArgumentException("Batch name cannot be null or empty", nameof(batchName));

            if (batchName.Contains(" "))
                throw new ArgumentException("Batch name cannot contain spaces", nameof(batchName));
        }


        private async Task ParallelFileOperation<T,TTask>(T[] items, Func<T, TTask> forEachItem, Action<Dictionary<TTask, T>> forEachGroup) where TTask : Task
        {
            var maxP = GetMaxParallelFiles();
            for (int i0 = 0; i0 < items.Length; i0 += maxP)
            {
                var tasks = new Dictionary<TTask, T>();
                for (int i1 = 0; i1 < maxP; i1++)
                {
                    var idx = i0 + i1;
                    if (idx < items.Length)
                    {
                        var item = items[idx];
                        var task = forEachItem(item);
                        tasks.Add(task, item);
                    }
                }

                try
                {
                    await Task.WhenAll(tasks.Keys).ConfigureAwait(false);
                }
                catch
                {
                    //ignored because the result of each task is expected to be examined individually
                }
                forEachGroup(tasks);
            }
        }


        private async Task<ServerValidationException> CreateServerValidationExceptionAsync(HttpResponseMessage result)
        {
            var exObj = await DeserializeResultAsync<ApiError>(result).ConfigureAwait(false);
            return new ServerValidationException(exObj.Status, exObj.Title, exObj.Detail);
        }


        private string GetTokenUrl()
        {
            return _clientOptions.AuthenticationUrl;
        }

        private string GetApiUrl(string apiPath)
        {
            var url = _clientOptions.ApiUrl;
            if (!url.EndsWith("/"))
                url += "/";
            return url + apiPath;
        }

        private int GetMaxParallelFiles()
        {
            return _clientOptions.MaximumParallelFiles;
        }

        private int GetMaximum500Retries()
        {
            return _clientOptions.MaximumRetriesOn500;
        }

        private int GetMaxRetryWait()
        {
            return _clientOptions.MaximumRetryWaitSeconds;
        }

        private int GetMaximumWaitRetries()
        {
            return _clientOptions.MaximumWaitRetries;
        }

        private async Task Login()
        {
            _httpClient.DefaultRequestHeaders.Authorization = null;


            var content = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("grant_type","client_credentials"),
                new KeyValuePair<string, string>("scope","client.image.api"),
                new KeyValuePair<string, string>("client_id",_clientId),
                new KeyValuePair<string, string>("client_secret",_clientSecret),
            });

            var result = await _httpClient.PostAsync(GetTokenUrl(), content).ConfigureAwait(false);
            var jsResult = await result.Content.ReadAsStringAsync().ConfigureAwait(false);

            _bearerToken = new BearerToken(jsResult, result.Headers.Date);
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _bearerToken.AccessToken);

        }

        private SemaphoreSlim _loginLock = new SemaphoreSlim(1, 1);
        private async Task<HttpResponseMessage> GetHttpResult(HttpRequestMessage request, int retryNumber = 0)
        {
            await _loginLock.WaitAsync().ConfigureAwait(false);
            try
            {
                if (_bearerToken == null || _bearerToken.IsExpired())
                {
                    await Login().ConfigureAwait(false);
                }
            }
            finally
            {
                _loginLock.Release();
            }

            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", _bearerToken.AccessToken);

            //It is wasteful to create this clone before we even know if the request will fail and need to be resent.
            //Unfortunately, the HttpClient calls dispose on the request and it can't be copied afterward. I think 
            //this is fixed in .NET Core (ref: https://github.com/dotnet/corefx/pull/19082/files) but we can't 
            //assume library won't be consumed from classic .NET framework
            var requestClone = await CloneHttpRequestMessageAsync(request);
            try
            {
                var result = await _httpClient.SendAsync(request).ConfigureAwait(false);

                if (result.IsSuccessStatusCode)
                {
                    return result;
                }

                if (result.StatusCode == HttpStatusCode.Unauthorized)
                {
                    if (retryNumber > 0)
                    {
                        result.EnsureSuccessStatusCode();
                    }
                    else
                    {
                        _bearerToken = null;
                        return await GetHttpResult(requestClone, retryNumber + 1).ConfigureAwait(false);
                    }
                }

                if ((int)result.StatusCode == 429)
                {
                    var waitTime = result.Headers.RetryAfter?.Delta ?? TimeSpan.FromSeconds(5);
                    if (waitTime > TimeSpan.FromSeconds(GetMaxRetryWait()))
                    {
                        result.EnsureSuccessStatusCode();
                    }

                    if (retryNumber >= GetMaximumWaitRetries())
                    {
                        result.EnsureSuccessStatusCode();
                    }

                    await Task.Delay(waitTime).ConfigureAwait(false);
                    return await GetHttpResult(requestClone, retryNumber + 1).ConfigureAwait(false);
                }

                if (result.StatusCode == HttpStatusCode.Conflict)
                {
                    throw await CreateServerValidationExceptionAsync(result).ConfigureAwait(false);
                }

                if (result.StatusCode == HttpStatusCode.InternalServerError)
                {
                    if (retryNumber >= GetMaximum500Retries())
                    {
                        result.EnsureSuccessStatusCode();
                    }
                    await Task.Delay(TimeSpan.FromSeconds(2)).ConfigureAwait(false);
                    return await GetHttpResult(requestClone, retryNumber + 1).ConfigureAwait(false);
                }
                result.EnsureSuccessStatusCode();
            }
            finally
            {
                requestClone.Dispose();
            }
            throw new Exception("This should never happen");
        }

        private async Task<T> DeserializeResultAsync<T>(HttpResponseMessage result)
        {
            var jsResult = await result.Content.ReadAsStringAsync().ConfigureAwait(false);

            return JsonConvert.DeserializeObject<T>(jsResult);
        }

        private async Task<T> PerformGet<T>(string url)
        {
            using (var request = new HttpRequestMessage(HttpMethod.Get, url))
            {
                var result = await GetHttpResult(request).ConfigureAwait(false);
                return await DeserializeResultAsync<T>(result).ConfigureAwait(false);
            }
        }

        private static async Task<HttpRequestMessage> CloneHttpRequestMessageAsync(HttpRequestMessage req)
        {
            HttpRequestMessage clone = new HttpRequestMessage(req.Method, req.RequestUri);

            // Copy the request's content (via a MemoryStream) into the cloned object
            var ms = new MemoryStream();
            if (req.Content != null)
            {
                await req.Content.CopyToAsync(ms).ConfigureAwait(false);
                ms.Position = 0;
                clone.Content = new StreamContent(ms);

                // Copy the content headers
                if (req.Content.Headers != null)
                    foreach (var h in req.Content.Headers)
                        clone.Content.Headers.Add(h.Key, h.Value);
            }


            clone.Version = req.Version;

            foreach (KeyValuePair<string, object> prop in req.Properties)
                clone.Properties.Add(prop);

            foreach (KeyValuePair<string, IEnumerable<string>> header in req.Headers)
                clone.Headers.TryAddWithoutValidation(header.Key, header.Value);

            return clone;
        }


    }
}
