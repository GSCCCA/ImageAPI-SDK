using System;
using System.Collections.Generic;
using System.Text;
using GSCCCA.ImageAPI.Client.Infrastructure;
using Newtonsoft.Json;

namespace GSCCCA.ImageAPI.Client.ApiObjects
{



    public class BatchSummary
    {

        [JsonProperty("batchId")]
        public int BatchId { get; set; }

        [JsonProperty("batchName")]
        public string BatchName { get; set; }

        [JsonProperty("created")]
        public DateTime Created { get; set; }

        [JsonProperty("closed")]
        public DateTime? Closed { get; set; }

        [JsonProperty("submittedImagesCount")]
        public int SubmittedImagesCount { get; set; }
        [JsonProperty("acceptedImagesCount")]
        public int AcceptedImagesCount { get; set; }
        [JsonProperty("rejectedImagesCount")]
        public int RejectedImagesCount { get; set; }

    }

    public class Batch : BatchSummary,  IPagingInfo
    {
        [JsonProperty("imageSubmissions")]
        public List<ImageSubmission> ImageSubmissions { get; set; }
        public PagingInfo Paging { get; set; }
}



}
