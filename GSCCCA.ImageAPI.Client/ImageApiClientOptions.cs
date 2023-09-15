using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using GSCCCA.ImageAPI.Client.ImageSupport;

namespace GSCCCA.ImageAPI.Client
{
    public class ImageApiClientOptions
    {
        private string _authenticationUrl = "https://identitystg.gsccca.org/connect/token";
        private string _apiUrl = "https://apisstg.gsccca.org/imaging/v1/";

        /// <summary>
        /// The url used to retrieve bearer tokens from GSCCCA
        /// </summary>
        [Description("The url used to retrieve bearer tokens from GSCCCA")]
        public string AuthenticationUrl
        {
            get => _authenticationUrl;
            set
            {
                _authenticationUrl = value;
                if (!Uri.TryCreate(value,UriKind.Absolute, out Uri test))
                    throw new ArgumentException("Invalid Authentication Url", nameof(AuthenticationUrl));
            }
        }

        /// <summary>
        /// The main API address of the GSCCCA Image Api
        /// </summary>
        [Description("The main API address of the GSCCCA Image Api")]
        public string ApiUrl
        {
            get => _apiUrl;
            set
            {
                _apiUrl = value;
                if (!Uri.TryCreate(value, UriKind.Absolute, out Uri test))
                    throw new ArgumentException("Invalid Api Url", nameof(ApiUrl));
            }
        }

        /// <summary>
        /// The maximum number of files to upload or download simultaneously
        /// </summary>
        [Description("The maximum number of files to upload or download simultaneously")]
        public int MaximumParallelFiles { get; set; } = 3;

        /// <summary>
        /// When an API rate limit is exceeded this is the maximum number of retry
        /// seconds a client will wait before throwing an exception
        /// </summary>
        [Description("When an API rate limit is exceeded this is the maximum number of retry seconds a client will wait before throwing an exception")]
        public int MaximumRetryWaitSeconds { get; set; } = 15;

        /// <summary>
        /// This is the maximum number of times the client will automatically retry
        /// after receiving an API rate limit error.
        /// </summary>
        [Description("This is the maximum number of times the client will automatically retry after receiving an API rate limit error.")]
        public int MaximumWaitRetries { get; set; } = 2;

        /// <summary>
        /// The maximum number of times to retry after receiving an internal server error.
        /// </summary>
        [Description("The maximum number of times to retry after receiving an internal server error.")]
        public int MaximumRetriesOn500 { get; set; } = 1;

        /// <summary>
        /// If true, images will be validated locally before uploading
        /// </summary>
        [Description("If true, images will be validated locally before uploading.")]
        public bool PerformTiffValidation { get; set; } = true;


        [Browsable(false)]
        public TiffValidationOptions TiffValidationOptions { get; set; } = new TiffValidationOptions();


        public ImageApiClientOptions()
        {
         
        }

    }
}
