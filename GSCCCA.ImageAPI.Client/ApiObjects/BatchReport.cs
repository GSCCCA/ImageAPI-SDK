using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace GSCCCA.ImageAPI.Client.ApiObjects
{
    public class BatchReport
    {
        [JsonProperty("batch")]
        public string BatchName { get; set; }

        [JsonProperty("createdDate")]
        public DateTime CreatedDate { get; set; }

        [JsonProperty("closedDate")]
        public DateTime ClosedDate { get; set; }

        [JsonProperty("vendor")]
        public Vendor Vendor { get; set; }

        [JsonProperty("imageSubmissions")]
        public List<ImageSubmission> ImageSubmissions { get; set; }
    }
}
