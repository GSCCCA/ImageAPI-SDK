using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace GSCCCA.ImageAPI.Client.Infrastructure
{
    public class BearerToken
    {
        private class BearerTokenJsonResult
        {
            public string access_token { get; set; }
            public string scope { get; set; }
            public int expires_in { get; set; }
        }


        public string AccessToken { get; }

        public DateTimeOffset ExpiresAt { get; }

        public string Scope { get; }

        public bool IsExpired()
        {
            return ExpiresAt <= DateTimeOffset.Now;
        }

        public BearerToken(string jsonResult, DateTimeOffset? responseDate = null)
        {
            var obj = JsonConvert.DeserializeObject<BearerTokenJsonResult>(jsonResult);
            AccessToken = obj.access_token;
            Scope = obj.scope;
            ExpiresAt = (responseDate ?? DateTimeOffset.Now).AddSeconds(obj.expires_in);
        }


    }
}
