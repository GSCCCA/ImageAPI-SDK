using System;
using System.Collections.Generic;
using System.Text;

namespace GSCCCA.ImageAPI.Client.ApiObjects
{
    public enum SortDirection
    {
        Ascending = 1,
        Descending = -1
    }

    public enum BatchOrderingOptions
    {
        Created = 1,
        BatchName = 2,
        Closed = 3
    }

    public enum ImageOrderingOptions
    {
        Created = 1,
        Book = 2,
        Page = 3,
        FileName = 4
    }

    
    public class PageAndDateOptions<TSortEnum> where TSortEnum : struct
    {
        public int? PageSize { get; set; }

        public int? PageNumber { get; set; }

        public DateTime? Start { get; set; }

        public DateTime? End { get; set; }

        public TSortEnum? SortBy { get; set; }

        public SortDirection? SortDirection { get; set; }


        
    }


    public static class PageAndDateOptionsUtil
    {
        internal static string ApplyQueryParamsToUrl<TSortEnum>(this PageAndDateOptions<TSortEnum> options, string url) where TSortEnum : struct
        {
            if (options == null)
                return url;

            var uri = new Uri(url);
            var newQuery = uri.Query;
            if (newQuery != null && newQuery.StartsWith("?"))
            {
                newQuery = newQuery.Substring(1);
            }
            newQuery = ApplyQueryParam(newQuery, nameof(options.PageSize), options.PageSize);
            newQuery = ApplyQueryParam(newQuery, nameof(options.PageNumber), options.PageNumber);
            newQuery = ApplyQueryParam(newQuery, nameof(options.Start), options.Start);
            newQuery = ApplyQueryParam(newQuery, nameof(options.End), options.End);
            newQuery = ApplyQueryParam(newQuery, nameof(options.SortBy), options.SortBy);
            newQuery = ApplyQueryParam(newQuery, nameof(options.SortDirection), options.SortDirection);
            var builder = new UriBuilder(uri);
            builder.Query = newQuery;
            return builder.Uri.ToString();
        }

        private static string ApplyQueryParam<T>(string existingQuery, string propertyName, T? value) where T : struct
        {
            if (!value.HasValue)
                return existingQuery;
            var paramName = propertyName.Substring(0, 1).ToLower() + propertyName.Substring(1);
            var result = string.IsNullOrWhiteSpace(existingQuery) ? "" : existingQuery + "&";
            result += $"{paramName}={Uri.EscapeDataString(value.ToString())}";
            return result;
        }
    }


}
