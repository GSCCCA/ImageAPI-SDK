using System.ComponentModel;

namespace GSCCCA.ImageAPI.Client.ImageSupport
{
    public class TiffValidationOptions
    {
        /// <summary>
        /// A comma delimited list of all bit depths that should be allowed
        /// </summary>
        [Description("A comma delimited list of all color depths that should be allowed")]
        public string AllowedColorDepths { get; set; } = "1,8";

        /// <summary>
        /// A comma delimited list of all resolutions that should be allowed
        /// </summary>
        [Description("A comma delimited list of all resolutions that should be allowed")]
        public string AllowedResolutions { get; set; } = "200,300";


        /// <summary>
        /// A comma delimited list of all resolutions that should be allowed
        /// </summary>
        [Description("A comma delimited list of all allowed compression methods")]
        public string AllowedCompression { get; set; } = "CCITTFAX4,CCITT_T6,LZW";

    }
}
