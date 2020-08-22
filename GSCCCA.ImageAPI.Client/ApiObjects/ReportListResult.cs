using System;
using System.Collections.Generic;
using System.Text;

namespace GSCCCA.ImageAPI.Client.ApiObjects
{
    public class ReportQueryParameter 
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Required { get; set; }
    }
    public class ReportListResult
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<ReportQueryParameter> QueryParameters { get; set; }
    }
}
