using System;
using System.Collections.Generic;
using System.Text;

namespace GSCCCA.ImageAPI.Client.ApiObjects
{
    public class BatchListResult : IPagingInfo
    {
        public List<BatchSummary> BatchResults { get; set; }
        public PagingInfo Paging { get; set; }
    }
}
