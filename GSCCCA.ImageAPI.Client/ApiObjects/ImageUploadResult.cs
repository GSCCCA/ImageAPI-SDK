using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace GSCCCA.ImageAPI.Client.ApiObjects
{
    public class ImageUploadResult
    {
        [JsonProperty("batchName")]
        public string BatchName { get; set; }

        [JsonProperty("fileName")]
        public string FileName { get; set; }

        [JsonProperty("imageId")]
        public long ImageId { get; set; }

        [JsonProperty("isValidated")]
        public bool IsValidated { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }

        [JsonProperty("previousImageIds")]
        public List<int> PreviousImageIds { get; set; }
    }
}
