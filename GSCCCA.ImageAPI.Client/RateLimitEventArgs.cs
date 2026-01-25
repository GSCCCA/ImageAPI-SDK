using System;

namespace GSCCCA.ImageAPI.Client
{
    /// <summary>
    /// Event arguments for rate limit (HTTP 429) events
    /// </summary>
    public class RateLimitEventArgs : EventArgs
    {
        public RateLimitEventArgs(TimeSpan retryAfter, int retryAttempt, string endpoint)
        {
            RetryAfter = retryAfter;
            RetryAttempt = retryAttempt;
            Endpoint = endpoint;
            OccurredAt = DateTime.UtcNow;
        }

        /// <summary>
        /// The duration the server requested we wait before retrying
        /// </summary>
        public TimeSpan RetryAfter { get; }

        /// <summary>
        /// Which retry attempt this is (0 = first 429 encountered)
        /// </summary>
        public int RetryAttempt { get; }

        /// <summary>
        /// The API endpoint that was rate limited
        /// </summary>
        public string Endpoint { get; }

        /// <summary>
        /// When the rate limit was encountered
        /// </summary>
        public DateTime OccurredAt { get; }
    }
}
