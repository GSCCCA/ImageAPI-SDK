using System;
using System.Collections.Generic;
using System.Text;

namespace GSCCCA.ImageAPI.Client.ApiObjects
{
    public class ImageHeaderInformation
    {
        public int? FileSize { get; set; }
        public string Checksum { get; set; }
        public DateTimeOffset? LastModified { get; set; }
    }
}
