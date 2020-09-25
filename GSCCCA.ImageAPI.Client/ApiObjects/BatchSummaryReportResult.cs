using System;
using System.Collections.Generic;
using System.Text;

namespace GSCCCA.ImageAPI.Client.ApiObjects
{
    public class RejectedImageSummaryLine
    {
        public DateTime Created { get; set; }
        public string FileName { get; set; }
        public string ErrorDescription { get; set; }
        public string Checksum { get; set; }
    }

    public class BatchSummaryReportLine
    {
        public int CountyCode { get; set; }
        public string CountyName { get; set; }
        public string Book { get; set; }
        public string PageFrom { get; set; }
        public string PageTo { get; set; }
        public int PageCount { get; set; }
        public int DocumentTypeId { get; set; }
        public string DocumentTypeName { get; set; }
        public DateTime FirstSubmitted { get; set; }
        public DateTime LastSubmitted { get; set; }
    }

    public class BatchSummaryReportResult : BaseReportResult
    {
        public string BatchName { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Closed { get; set; }
        public List<BatchSummaryReportLine> AcceptedRanges { get; set; }
        public List<RejectedImageSummaryLine> RejectedImages { get; set; }
    }
}
