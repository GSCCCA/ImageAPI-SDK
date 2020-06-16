using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using Newtonsoft.Json;

namespace GSCCCA.ImageAPI.Client.ApiObjects
{
    public class ApiError
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("status")]
        public HttpStatusCode Status { get; set; }

        [JsonProperty("detail")]
        public string Detail { get; set; }
    }
}
