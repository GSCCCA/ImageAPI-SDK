using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using GSCCCA.ImageAPI.Client;
using GSCCCA.ImageAPI.Client.ApiObjects;
using GSCCCA.ImageAPI.Client.ImageSupport;
using GSCCCA.ImageAPI.Client.Infrastructure;
using Newtonsoft.Json;

namespace GSCCCA.ImageAPI.TestProgram.Core
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            PropGridBatchOptions.SelectedObject = _batchesGetOptions;
            PropGridGetBatchOptions.SelectedObject = _batchGetOptions;
        }

        private ImageApiClient GetClient()
        {
            return new ImageApiClient(TxtClientId.Text, TxtClientSecret.Text, ClientOptions);
        }

        private PageAndDateOptions<BatchOrderingOptions> _batchesGetOptions = new PageAndDateOptions<BatchOrderingOptions>();
        private PageAndDateOptions<ImageOrderingOptions> _batchGetOptions = new PageAndDateOptions<ImageOrderingOptions>();


        public ImageApiClientOptions ClientOptions = new ImageApiClientOptions();

        private async void BtnTest_Click(object sender, EventArgs e)
        {
            var client = GetClient();
            var result = await client.GetVendorInfo();
            var i = 0;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            ClientOptionsGrid.SelectedObject = ClientOptions;
            PropertyGridTiffValidation.SelectedObject = ClientOptions.TiffValidationOptions;
        }

        private void BtnSelectFiles_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                UploadFilesTable.Clear();
                foreach (var path in openFileDialog.FileNames)
                {
                    AddOrSetUploadedFileStatus(path, "Pending", "Pending");
                }

                ResetUpload();


            }
        }

        private void TxtBatchName_Validating(object sender, CancelEventArgs e)
        {
            var txt = sender as TextBox;
            if (txt == null)
                throw new Exception("Validation coding problem");
            var batchName = txt.Text;
            if (string.IsNullOrWhiteSpace(batchName))
            {
                errorProvider.SetError(txt, "Batch name is required");
                e.Cancel = true;
            }
            else if (batchName.Contains(" "))
            {
                errorProvider.SetError(txt, "Batch name can't have spaces");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txt, String.Empty);
            }
        }

        private void ResetUpload()
        {
            BtnPerformUpload.Enabled = true;
            LblUploadStatus.Text = "";
            PrgUploadProgress.Value = 0;
        }

        private void SetUploadControlsEnabled(bool enabled)
        {

            BtnSelectFiles.Enabled = enabled;
            TxtUploadBatchName.Enabled = enabled;
        }


        private void AddOrSetUploadedFileStatus(string path, string image, string result)
        {
            var l = new object[3];
            l[0] = ImageList.Images[image];
            l[1] = path;
            l[2] = result;
            UploadFilesTable.LoadDataRow(l, true);
        }

        private void AddOrSetDownloadFileStatus(long id, string filename, string image, string result)
        {
            var l = new object[4];
            l[0] = ImageList.Images[image];
            l[1] = id;
            l[2] = filename;
            l[3] = result;
            DownloadFilesTable.LoadDataRow(l, true);
        }


        private async void BtnPerformUpload_Click(object sender, EventArgs e)
        {
            if (UploadFilesTable.Rows.Count < 1)
            {
                MessageBox.Show("You must select files to upload");
                return;
            }

            var valid = ValidateChildren(ValidationConstraints.Visible);

            if (valid)
            {
                BtnPerformUpload.Enabled = false;
                SetUploadControlsEnabled(false);
                LblUploadStatus.Text = "Upload Started";
                var batchName = TxtUploadBatchName.Text;


                var files = new List<string>();
                foreach (DataRow row in UploadFilesTable.Rows)
                {
                    var path = row["FilePath"] as string;
                    if (!string.IsNullOrWhiteSpace(path))
                        files.Add(path);
                }

                PrgUploadProgress.Maximum = files.Count;
                var statusIndicator = new TransferStatusIndicator(SynchronizationContext.Current);

                statusIndicator.StatusUpdate += (o, args) =>
                {
                    if (args.CompletedFiles > PrgUploadProgress.Value)
                        PrgUploadProgress.Value = args.CompletedFiles;
                    var image = "Pending";
                    var resultText = "Pending";

                    if (args.CurrentEvent == CurrentEventType.FileStarting)
                    {
                        image = "Uploading";
                        resultText = "Uploading";
                    }
                    else if (args.CurrentEvent == CurrentEventType.FileError)
                    {
                        image = "Error";
                        resultText = args.Error ?? "Error";
                    }
                    else if (args.CurrentEvent == CurrentEventType.FileCompleted)
                    {
                        image = "Success";
                        resultText = "Success";
                    }

                    AddOrSetUploadedFileStatus(args.FilePath, image, resultText);

                };

                try
                {
                    var client = GetClient();
                    var result = await client.UploadImagesAsync(files.ToArray(), batchName, statusIndicator);
                    LblUploadStatus.Text = "Upload Complete";
                }
                catch (Exception ex)
                {
                    LblUploadStatus.Text = $"Error: {ex}";
                }
                SetUploadControlsEnabled(true);
            }
        }


        private void SetGetBatchesControlDisabled()
        {
            BtnGetBatches.Enabled = false;
            BtnGetBatch.Enabled = false;
            BtnCloseBatch.Enabled = false;
            BtnBatchReport.Enabled = false;
            BtnDownload.Enabled = false;
        }



        private async void BtnGetBatches_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren(ValidationConstraints.Visible))
            {
                return;
            }
            LblGetBatchStatus.Text = $"Getting Batches ...";
            SetGetBatchesControlDisabled();
            PropGridBatch.SelectedObject = null;

            var client = GetClient();
            try
            {
                var batches = await client.GetBatchesAsync(ChkShowClosed.Checked, _batchesGetOptions);

                LstBatches.Items.Clear();
                var bArray = batches.BatchResults.ToArray();
                LstBatches.Items.AddRange(bArray);
                LblGetBatchStatus.Text = $"Get Batches Complete";
            }
            catch (Exception exception)
            {
                LblGetBatchStatus.Text = $"Error: {exception}";
            }

            BtnGetBatches.Enabled = true;

        }

        private void LstBatches_SelectedValueChanged(object sender, EventArgs e)
        {
            PropGridBatch.SelectedObject = LstBatches.SelectedItem;
            if (LstBatches.SelectedItem is BatchSummary batch)
            {
                BtnCloseBatch.Enabled = !batch.Closed.HasValue;
                BtnBatchReport.Enabled = batch.Closed.HasValue;
                BtnDownload.Enabled = true;
                BtnGetBatch.Enabled = true;
            }
        }

        private void BtnBrowseFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                TxtTargetPath.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void RequiredTextBox_Validating(object sender, CancelEventArgs e)
        {
            var txt = sender as TextBox;
            if (txt == null)
                throw new Exception("Validation coding problem");
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                var fn = txt.Tag as string;
                e.Cancel = true;
                errorProvider.SetError(txt, $"{fn} is required");
            }
            else
            {
                errorProvider.SetError(txt, String.Empty);
            }
        }

        private void SetDownloadControlsEnabled(bool enabled)
        {
            BtnListFiles.Enabled = enabled;
            BtnDownloadAll.Enabled = enabled;
            BtnBrowseFolder.Enabled = enabled;
            TxtTargetPath.Enabled = enabled;
            TxtDownloadBatchName.Enabled = enabled;
            ColumnDownloadButton.ReadOnly = !enabled;
        }

        private async void BtnListFiles_Click(object sender, EventArgs e)
        {
            TxtTargetPath.CausesValidation = false;
            try
            {
                if (!ValidateChildren(ValidationConstraints.Visible))
                    return;
            }
            finally
            {
                TxtTargetPath.CausesValidation = true;
            }






            LblDownloadStatus.Text = "Getting File List";

            SetDownloadControlsEnabled(false);

            try
            {
                var pageSize = 50;
                var client = GetClient();

                var options = new PageAndDateOptions<ImageOrderingOptions>();
                options.PageNumber = 1;
                options.PageSize = pageSize;
                options.SortBy = ImageOrderingOptions.Created;
                options.SortDirection = SortDirection.Ascending;

                Batch batch;


                var images = new List<ImageSubmission>();

                do
                {
                    batch = await client.GetBatchAsync(TxtDownloadBatchName.Text, options);
                    images.AddRange(batch.ImageSubmissions);
                    options.PageNumber++;
                } while (!string.IsNullOrEmpty(batch.Paging.Next));

                DownloadFilesTable.Clear();


                images.Where(i => i.Success)
                .ToList().ForEach(f =>
                {
                    AddOrSetDownloadFileStatus(f.ImageSubmissionId, f.FileName, "Pending", "Pending");
                });
                LblDownloadStatus.Text = "List Files Completed";
            }
            catch (Exception exception)
            {
                LblDownloadStatus.Text = $"Error: {exception}";
            }

            SetDownloadControlsEnabled(true);

        }

        private async void BtnCloseBatch_Click(object sender, EventArgs e)
        {

            PropGridBatch.SelectedObject = LstBatches.SelectedItem;
            if (LstBatches.SelectedItem is BatchSummary batch)
            {
                if (batch.Closed.HasValue)
                {
                    LblGetBatchStatus.Text = "Error: Batch is already closed";
                    return;
                }

                var cIdx = LstBatches.SelectedIndex;
                SetGetBatchesControlDisabled();
                LblGetBatchStatus.Text = "Close Batch Started";
                try
                {
                    var client = GetClient();
                    var result = await client.CloseBatchAsync(batch.BatchName);
                    LblGetBatchStatus.Text = $"{result.BatchName} closed on {result.Closed}";
                }
                catch (Exception exception)
                {
                    LblGetBatchStatus.Text = $"Error: {exception}";
                }

                BtnGetBatches.Enabled = true;
                BtnGetBatches_Click(BtnGetBatches, EventArgs.Empty);

                if (LstBatches.Items.Count > cIdx)
                    LstBatches.SelectedIndex = cIdx;

            }



        }

        private void BtnDownload_Click(object sender, EventArgs e)
        {
            PropGridBatch.SelectedObject = LstBatches.SelectedItem;
            if (LstBatches.SelectedItem is BatchSummary batch)
            {

                TxtDownloadBatchName.Text = batch.BatchName;
                MainTabControl.SelectTab(TabDownloadBatch);
                BtnListFiles_Click(BtnListFiles, EventArgs.Empty);

            }
        }

        private async void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                var item = dataGridView2.Rows[e.RowIndex].DataBoundItem as DataRowView;
                if (item != null)
                {
                    var id = (long)item.Row["FileId"];
                    var filename = item.Row["FileName"] as string ?? $"{id}.tif";
                    if (!ValidateChildren(ValidationConstraints.Visible))
                        return;

                    LblDownloadStatus.Text = "Downloading";
                    SetDownloadControlsEnabled(false);
                    try
                    {
                        var client = GetClient();
                        var path = Path.Combine(TxtTargetPath.Text, filename);
                        await client.DownloadImageAsync(id, path);
                        LblDownloadStatus.Text = "Download Success";
                        AddOrSetDownloadFileStatus(id, filename, "Success", "Success");
                    }
                    catch (Exception exception)
                    {
                        LblDownloadStatus.Text = $"Error: {exception}";
                        AddOrSetDownloadFileStatus(id, filename, "Error", exception.Message);
                    }
                    SetDownloadControlsEnabled(true);

                }
            }
        }

        private async void BtnDownloadAll_Click(object sender, EventArgs e)
        {
            if (DownloadFilesTable.Rows.Count < 1)
            {
                MessageBox.Show("No files to download");
                return;
            }

            if (!ValidateChildren(ValidationConstraints.Visible))
                return;


            SetDownloadControlsEnabled(false);
            LblDownloadStatus.Text = "Download Started";


            var files = new List<ImageDownloadRequest>();
            foreach (DataRow row in DownloadFilesTable.Rows)
            {
                var id = (long)row["FileId"];
                var filename = row["FileName"] as string ?? $"{id}.tif";
                var path = Path.Combine(TxtTargetPath.Text, filename);
                if (!string.IsNullOrWhiteSpace(path))
                    files.Add(new ImageDownloadRequest { ImageId = id, TargetPath = path });
            }
            PrgDownloadProgress.Value = 0;
            PrgDownloadProgress.Maximum = files.Count;
            var statusIndicator = new TransferStatusIndicator(SynchronizationContext.Current);

            statusIndicator.StatusUpdate += (o, args) =>
            {
                if (args.CompletedFiles > PrgDownloadProgress.Value)
                    PrgDownloadProgress.Value = args.CompletedFiles;
                var image = "Pending";
                var resultText = "Pending";

                if (args.CurrentEvent == CurrentEventType.FileStarting)
                {
                    image = "Downloading";
                    resultText = "Downloading";
                }
                else if (args.CurrentEvent == CurrentEventType.FileError)
                {
                    image = "Error";
                    resultText = args.Error ?? "Error";
                }
                else if (args.CurrentEvent == CurrentEventType.FileCompleted)
                {
                    image = "Success";
                    resultText = "Success";
                }

                var file = files.FirstOrDefault(f => f.TargetPath == args.FilePath);
                if (file != null)
                    AddOrSetDownloadFileStatus(file.ImageId.GetValueOrDefault(), Path.GetFileName(file.TargetPath), image, resultText);

            };

            try
            {
                var client = GetClient();
                var result = await client.DownloadImagesAsync(files.ToArray(), statusIndicator);
                LblDownloadStatus.Text = "Download Complete";
            }
            catch (Exception ex)
            {
                LblDownloadStatus.Text = $"Error: {ex}";
            }
            SetDownloadControlsEnabled(true);

        }

        private void BtnTestImage_Click(object sender, EventArgs e)
        {
            var tiff = GSCCCATiff.OpenFile(@"C:\tmp\TIF2\testdownload\batchDownload2\DEED0442492000451.TIF");
            PropertyGridImageInfo.SelectedObject = tiff;
        }

        private class TiffFileInfo
        {
            public string FileName { get; set; }
            public string Path { get; set; }
        }

        private void BtnBrowseImageFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialogImageInfo.ShowDialog() == DialogResult.OK)
            {
                LoadDirectory(folderBrowserDialogImageInfo.SelectedPath);
            }
        }


        private void LoadDirectory(string directory)
        {
            var files = Directory.EnumerateFiles(directory, "*.tif").ToList();
            files.AddRange(Directory.EnumerateFiles(directory, "*.tiff"));

            var data = files.Select(f => new TiffFileInfo { FileName = Path.GetFileName(f), Path = f }).ToList();

            PropertyGridImageInfo.SelectedObject = null;
            LstImageBrowser.DataSource = data;
            LstImageBrowser_SelectedValueChanged(LstImageBrowser, EventArgs.Empty);
        }


        private GSCCCATiff _lastImage = null;
        private void LstImageBrowser_SelectedValueChanged(object sender, EventArgs e)
        {
            if (LstImageBrowser.SelectedItem is TiffFileInfo item)
            {
                if (_lastImage != null)
                    _lastImage.Dispose();

                var tiff = GSCCCATiff.OpenFile(item.Path);
                _lastImage = tiff;

                PropertyGridImageInfo.SelectedObject = tiff;

            }
        }

        private async void BtnSaveImage_Click(object sender, EventArgs e)
        {
            if (LstImageBrowser.SelectedItem is TiffFileInfo item)
            {
                if (_lastImage == null) return;
                saveFileDialog1.FileName = item.FileName;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    await _lastImage.SaveToFileAsync(saveFileDialog1.FileName);

                    if (Path.GetDirectoryName(saveFileDialog1.FileName).Equals(Path.GetDirectoryName(item.Path),
                        StringComparison.OrdinalIgnoreCase))
                    {
                        LoadDirectory(Path.GetDirectoryName(saveFileDialog1.FileName));
                        foreach (TiffFileInfo i in LstImageBrowser.Items)
                        {
                            if (i.FileName.Equals(Path.GetFileName(saveFileDialog1.FileName)))
                            {
                                LstImageBrowser.SelectedItem = i;
                                LstImageBrowser_SelectedValueChanged(LstImageBrowser, EventArgs.Empty);
                                break;
                            }
                        }
                    }


                }

            }
        }

        private async void BtnUploadImageFromInfo_Click(object sender, EventArgs e)
        {
            if (LstImageBrowser.SelectedItem is TiffFileInfo item)
            {
                if (_lastImage == null) return;
                if (!ValidateChildren(ValidationConstraints.Visible))
                    return;

                var bn = TxtBatchNameImageInfo.Text;

                BtnUploadImageFromInfo.Enabled = false;
                TxtBatchNameImageInfo.Enabled = false;
                LblUploadImageInfoStatus.Text = "Uploading Image ...";
                try
                {
                    var client = GetClient();
                    await client.UploadImageAsync(_lastImage, bn);
                    LblUploadImageInfoStatus.Text = "Uploading Success";
                }
                catch (Exception exception)
                {
                    LblUploadImageInfoStatus.Text = "Error";
                    MessageBox.Show(exception.ToString());
                }
                BtnUploadImageFromInfo.Enabled = true;
                TxtBatchNameImageInfo.Enabled = true;


            }




        }

        private void SetReportPageControlsEnabled(bool enabled)
        {
            TxtBatchNameGetReport.Enabled = enabled;
            BtnGetReport.Enabled = enabled;
            BtnGetBatchSummaryReport.Enabled = enabled;
            BtnEmailBatchReport.Enabled = enabled;
            BtnEmailBatchSummaryReport.Enabled = enabled;
        }


        private async void BtnGetReport_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren(ValidationConstraints.Visible))
                return;

            var bn = TxtBatchNameGetReport.Text;
            SetReportPageControlsEnabled(false);
            LblGetReportStatus.Text = "Getting Batch Report";
            try
            {
                var client = GetClient();
                var result = await client.GetBatchReportAsync(bn);

                var json = JsonConvert.SerializeObject(result, Formatting.Indented);
                TxtJsonReport.Text = json;
                LblGetReportStatus.Text = "Batch Report Success";
            }
            catch (Exception exception)
            {
                LblGetReportStatus.Text = exception.ToString();
            }

            SetReportPageControlsEnabled(true);



        }

        private void BtnBatchReport_Click(object sender, EventArgs e)
        {

            PropGridBatch.SelectedObject = LstBatches.SelectedItem;
            if (LstBatches.SelectedItem is BatchSummary batch)
            {
                if (batch.Closed.HasValue)
                {
                    TxtBatchNameGetReport.Text = batch.BatchName;
                    MainTabControl.SelectTab(TabReports);
                    BtnGetReport_Click(BtnGetReport, EventArgs.Empty);
                }
                else
                {
                    LblDownloadStatus.Text = "Error: Batch not closed";
                }
            }


        }

        private async void BtnGetBatchGetBatch_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren(ValidationConstraints.Visible))
            {
                return;
            }
            LblGetBatchStatusGetBatch.Text = $"Getting Batch ...";
            BtnGetBatchGetBatch.Enabled = false;
            PropGridImageInfo.SelectedObject = null;

            var client = GetClient();
            try
            {
                var batch = await client.GetBatchAsync(TxtBatchNameGetBatch.Text, _batchGetOptions);

                LstImages.Items.Clear();
                var bArray = batch.ImageSubmissions.ToArray();
                LstImages.Items.AddRange(bArray);
                LblGetBatchStatusGetBatch.Text = $"Get Batches Complete";
            }
            catch (Exception exception)
            {
                LblGetBatchStatusGetBatch.Text = $"Error: {exception}";
            }

            BtnGetBatchGetBatch.Enabled = true;
        }

        private void LstImages_SelectedValueChanged(object sender, EventArgs e)
        {
            PropGridImageInfo.SelectedObject = LstImages.SelectedItem;
        }

        private void BtnGetBatch_Click(object sender, EventArgs e)
        {

            PropGridBatch.SelectedObject = LstBatches.SelectedItem;
            if (LstBatches.SelectedItem is BatchSummary batch)
            {

                TxtBatchNameGetBatch.Text = batch.BatchName;
                MainTabControl.SelectTab(TabGetBatch);
                BtnGetBatchGetBatch_Click(BtnGetBatchGetBatch, EventArgs.Empty);
            }
        }

        private async void BtnGetBatchSummaryReport_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren(ValidationConstraints.Visible))
                return;

            var bn = TxtBatchNameGetReport.Text;
            SetReportPageControlsEnabled(false);
            LblGetReportStatus.Text = "Getting Batch Summary Report";
            try
            {
                var client = GetClient();
                var result = await client.GetBatchSummaryReportAsync(bn);

                var json = JsonConvert.SerializeObject(result, Formatting.Indented);
                TxtJsonReport.Text = json;
                LblGetReportStatus.Text = "Batch Summary Report Success";
            }
            catch (Exception exception)
            {
                LblGetReportStatus.Text = exception.ToString();
            }

            SetReportPageControlsEnabled(true);
        }

        private async void BtnEmailBatchSummaryReport_Click(object sender, EventArgs e)
        {

            if (!ValidateChildren(ValidationConstraints.Visible))
                return;

            if (string.IsNullOrWhiteSpace(TxtEmailTo.Text))
            {
                MessageBox.Show("Email to is required");
                return;
            }

            var bn = TxtBatchNameGetReport.Text;
            SetReportPageControlsEnabled(false);
            LblGetReportStatus.Text = "Emailing Batch Summary Report";
            try
            {
                var client = GetClient();
                var result = await client.EmailBatchSummaryReport(TxtEmailTo.Text, bn);

                var json = JsonConvert.SerializeObject(result, Formatting.Indented);
                TxtJsonReport.Text = json;
                LblGetReportStatus.Text = "Email Batch Summary Report Success";
            }
            catch (Exception exception)
            {
                LblGetReportStatus.Text = exception.ToString();
            }

            SetReportPageControlsEnabled(true);

        }

        private async void BtnEmailBatchReport_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren(ValidationConstraints.Visible))
                return;

            if (string.IsNullOrWhiteSpace(TxtEmailTo.Text))
            {
                MessageBox.Show("Email to is required");
                return;
            }

            var bn = TxtBatchNameGetReport.Text;
            SetReportPageControlsEnabled(false);
            LblGetReportStatus.Text = "Emailing Batch Report";
            try
            {
                var client = GetClient();
                var result = await client.EmailBatchReport(TxtEmailTo.Text, bn);

                var json = JsonConvert.SerializeObject(result, Formatting.Indented);
                TxtJsonReport.Text = json;
                LblGetReportStatus.Text = "Email Batch Report Success";
            }
            catch (Exception exception)
            {
                LblGetReportStatus.Text = exception.ToString();
            }

            SetReportPageControlsEnabled(true);
        }
    }
}
