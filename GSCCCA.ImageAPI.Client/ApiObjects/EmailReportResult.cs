using System;
using System.Collections.Generic;
using System.Text;

namespace GSCCCA.ImageAPI.Client.ApiObjects
{
    public class EmailReportResult
    {
        public string ReportName { get; set; }
        public IEnumerable<string> ToEmails { get; set; }
        public long EmailSize { get; set; }
        public string Subject { get; set; }
        public string FromEmail { get; set; }
        public DateTime SentDateTime { get; set; }
        public string ReportFormat { get; set; }
    }
}
