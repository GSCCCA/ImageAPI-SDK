using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace GSCCCA.ImageAPI.Client.ApiObjects
{
    public class ImageSubmission
    {
        [JsonProperty("imageSubmissionId")]
        public int ImageSubmissionId { get; set; }

        [JsonProperty("countyCode")]
        public int CountyCode { get; set; }

        [JsonProperty("book")]
        public string Book { get; set; }

        [JsonProperty("page")]
        public string Page { get; set; }

        [JsonProperty("fileName")]
        public string FileName { get; set; }

        [JsonProperty("submissionTime")]
        public DateTime? SubmissionTime { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

    }
}
