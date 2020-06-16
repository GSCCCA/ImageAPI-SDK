using System;
using System.Collections.Generic;
using System.Text;
using GSCCCA.ImageAPI.Client.ApiObjects;

namespace GSCCCA.ImageAPI.Client.Infrastructure
{
    public class ParallelTransferResult
    {
        internal ParallelTransferResult(string filePath, bool success, ImageUploadResult uploadResult, Exception error)
        {
            FilePath = filePath;
            Success = success;
            Error = error;
            UploadResult = uploadResult;
        }

        public string FilePath { get; }
        public bool Success { get; }
        public Exception Error { get; }
        public ImageUploadResult UploadResult { get; }
    }
}
