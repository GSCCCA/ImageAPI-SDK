using System;
using System.Collections.Generic;
using System.Text;

namespace GSCCCA.ImageAPI.Client.Infrastructure
{
    public class ImageValidationException : Exception
    {
        public string ImageId { get; }

        public ImageValidationException(string imageId, string message) : base(message)
        {
            ImageId = imageId;
        }

        public ImageValidationException(string imageId, string message, Exception innerException) : base(message,
            innerException)
        {
            ImageId = imageId;
        }
    }
}
