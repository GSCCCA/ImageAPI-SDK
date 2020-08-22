using System;
using System.Collections.Generic;
using System.Text;

namespace GSCCCA.ImageAPI.Client.Infrastructure
{
    public class ImageDownloadRequest
    {
        public long? ImageId { get; set; }
        public string BatchName { get; set; }
        public string FileName { get; set; }
        public string TargetPath { get; set; }
    }
}
