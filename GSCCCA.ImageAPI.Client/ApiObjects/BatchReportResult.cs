using System;
using System.Collections.Generic;
using System.Text;

namespace GSCCCA.ImageAPI.Client.ApiObjects
{
    public class BatchReportResult :BaseReportResult
    {
        public string BatchName { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Closed { get; set; }
        public IEnumerable<ReportImageSubmission> ImageSubmissions { get; set; }
    }
}
