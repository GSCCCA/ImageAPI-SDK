using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace GSCCCA.ImageAPI.Client.Infrastructure
{
    public class ServerValidationException : Exception
    {
        public HttpStatusCode StatusCode { get; }
        public string Title { get; }

        public ServerValidationException(HttpStatusCode statusCode, string title, string detail) : base(detail)
        {
            StatusCode = statusCode;
            Title = title;
        }

        public ServerValidationException(HttpStatusCode statusCode, string title, string detail, Exception ex) : base(detail, ex)
        {
            StatusCode = statusCode;
            Title = title;
        }
    }
}
