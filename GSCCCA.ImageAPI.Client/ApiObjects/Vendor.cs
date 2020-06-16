using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace GSCCCA.ImageAPI.Client.ApiObjects
{
    public class VendorEmail
    {
        [JsonProperty("emailAddress")]
        public string EmailAddress { get; set; }
    }

    public class Vendor
    {
        [JsonProperty("vendorId")]
        public string VendorName { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("vendorEmail")]
        public List<VendorEmail> VendorEmails { get; set; }
    }
}
