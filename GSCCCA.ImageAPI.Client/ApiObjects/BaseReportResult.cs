using System;
using System.Collections.Generic;
using System.Text;

namespace GSCCCA.ImageAPI.Client.ApiObjects
{
    public class BaseReportResult
    {
        public string ReportName { get; set; }
        public DateTime DateExecuted { get; set; }
        public string VendorName { get; set; }
    }
}
