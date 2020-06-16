using System;
using System.Collections.Generic;
using System.Text;
using GSCCCA.ImageAPI.Client.Infrastructure;
using Newtonsoft.Json;

namespace GSCCCA.ImageAPI.Client.ApiObjects
{
    public class Batch
    {
        [JsonProperty("batch")]
        public string BatchName { get; set; }

        [JsonProperty("vendor")]
        public int Vendor { get; set; }

        [JsonProperty("createDate")]
        public DateTime CreatedDate { get; set; }

        [JsonProperty("closedDate")]
        public DateTime? ClosedDate { get; set; }

        [JsonProperty("submittedImages")]
        public int SubmittedImages { get; set; }

    }

    public class BatchCloseResult
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("detail")]
        public string Detail { get; set; }
    }


    public class BatchCreationResult
    {
        [JsonProperty("batch")]
        public string BatchName { get; set; }

        [JsonProperty("vendor")]
        public string Vendor { get; set; }

        [JsonProperty("createdDate")]
        public DateTime CreatedDate { get; set; }
    }
}
