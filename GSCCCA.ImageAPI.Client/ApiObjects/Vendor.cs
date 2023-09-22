using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace GSCCCA.ImageAPI.Client.ApiObjects
{

    public class CountyModel
    {
        [JsonProperty("countyCode")]
        public int CountyCode { get; set; }
        
        [JsonProperty("countyName")]
        public string CountyName { get; set; }
    }

    public class Vendor
    {
        [JsonProperty("vendorId")]
        public int VendorId { get; set; }
        
        [JsonProperty("clientId")]
        public string ClientId { get; set; }
        
        [JsonProperty("vendorName")]
        public string VendorName { get; set; }
        
        [JsonProperty("vendorEmails")]
        public string VendorEmails { get; set; }
        
        [JsonProperty("counties")]
        public List<CountyModel> Counties { get; set; }
    }
}
