using System;
using System.Collections.Generic;
using System.Text;

namespace GSCCCA.ImageAPI.Client.ApiObjects
{
    public interface IPagingInfo
    {
        PagingInfo Paging { get; set; }
    }
    public class PagingInfo
    {
        public int TotalResults { get; set; }
        public int TotalPages { get; set; }
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
        public string Next { get; set; }
        public string Previous { get; set; }
    }
}
