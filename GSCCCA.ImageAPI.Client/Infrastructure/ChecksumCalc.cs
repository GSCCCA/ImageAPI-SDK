using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace GSCCCA.ImageAPI.Client.Infrastructure
{
    public static class ChecksumCalc
    {
        public static string Calculate(byte[] bytes)
        {
            using (var hasher = SHA1.Create())
            {
                var hashBytes = hasher.ComputeHash(bytes);
                return new string(hashBytes.SelectMany(b => b.ToString("X2")).ToArray());

                //return hashBytes.Aggregate(String.Empty, (s, b) => s + b.ToString("X2"));
            }
        }
    }
}
