using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace GSCCCA.ImageAPI.Client.ApiObjects
{
    public class ImageUploadResult
    {
        [JsonProperty("batchCode")]
        public string BatchCode { get; set; }

        [JsonProperty("filename")]
        public string Filename { get; set; }

        [JsonProperty("imageId")]
        public long ImageId { get; set; }

        [JsonProperty("isValidated")]
        public bool IsValidated { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }
    }
}
