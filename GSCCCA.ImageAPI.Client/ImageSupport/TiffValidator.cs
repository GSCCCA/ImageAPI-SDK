using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using BitMiracle.LibTiff.Classic;
using GSCCCA.ImageAPI.Client.Infrastructure;

namespace GSCCCA.ImageAPI.Client.ImageSupport
{
    public class TiffValidator
    {
        private readonly TiffValidationOptions _validationOptions;

        public IReadOnlyList<int> ResolutionOptions { get; }
        public IReadOnlyList<int> ColorDepthOptions { get; }
        public IReadOnlyList<Compression> CompressionOptions { get; }

        public TiffValidator() : this (new TiffValidationOptions())
        { }

        public TiffValidator(TiffValidationOptions validationOptions)
        {
            _validationOptions = validationOptions;
            ResolutionOptions = GetAllowedResolutionsOptions();
            ColorDepthOptions = GetAllowedColorDepthsOptions();
            CompressionOptions = GetAllowedCompressionOptions();
        }

        public void Validate(GSCCCATiff tiff)
        {
            ValidateDocumentNames(tiff);
            ValidateArtist(tiff);
            ValidateColorDepth(tiff);
            ValidateCompression(tiff);
            ValidateResolution(tiff);
        }

        private void ValidateColorDepth(GSCCCATiff tiff)
        {
            if (!ColorDepthOptions.Contains(tiff.ColorDepth))
            {
                throw new ImageValidationException(tiff.FileName, $"Invalid Color Depth: {tiff.ColorDepth}");
            }
        }

        private void ValidateResolution(GSCCCATiff tiff)
        {
            if (!ResolutionOptions.Contains((int)tiff.XRes))
            {
                throw new ImageValidationException(tiff.FileName, $"Invalid X Resolution: {tiff.XRes}");
            }

            if (!ResolutionOptions.Contains((int)tiff.YRes))
            {
                throw new ImageValidationException(tiff.FileName, $"Invalid Y Resolution: {tiff.YRes}");
            }
        }

        private void ValidateCompression(GSCCCATiff tiff)
        {
            if (!CompressionOptions.Contains(tiff.Compression))
            {
                throw new ImageValidationException(tiff.FileName, $"Invalid Compression Method: {tiff.Compression}");
            }
        }

        private void ValidateArtist(GSCCCATiff tiff)
        {
            if (string.IsNullOrWhiteSpace(tiff.Artist))
            {
                throw new ImageValidationException(tiff.FileName, "Artist tag is required");
            }
        }

        private void ValidateDocumentNames(GSCCCATiff tiff)
        {
            var rgxValidate = new Regex(GSCCCATiff.DocumentNameRegex, RegexOptions.IgnoreCase);

            if (string.IsNullOrWhiteSpace(tiff.DocumentName))
                throw new ImageValidationException(tiff.FileName, $"Document Name is Required");

            if (!rgxValidate.IsMatch(tiff.DocumentName))
                throw new ImageValidationException(tiff.FileName,$"Invalid Document Name: {tiff.DocumentName}");

            if (!string.IsNullOrWhiteSpace(tiff.NextPage) && !rgxValidate.IsMatch(tiff.NextPage))
                throw new ImageValidationException(tiff.FileName, $"Invalid NextPage: {tiff.NextPage}");

            if (!string.IsNullOrWhiteSpace(tiff.PreviousPage) && !rgxValidate.IsMatch(tiff.PreviousPage))
                throw new ImageValidationException(tiff.FileName, $"Invalid PreviousPage: {tiff.PreviousPage}");

        }

        


        private IReadOnlyList<int> GetAllowedColorDepthsOptions()
        {
            if (string.IsNullOrWhiteSpace(_validationOptions.AllowedColorDepths))
                throw new ArgumentException("AllowedColorDepths is required", nameof(TiffValidationOptions.AllowedColorDepths));

            var list = new List<int>();
            var options = SplitOption(_validationOptions.AllowedColorDepths);
            options.ForEach(o =>
            {
                if (!int.TryParse(o, out int ri))
                    throw new ArgumentException($"{o} is not a valid color depth", nameof(TiffValidationOptions.AllowedColorDepths));

                if (ri < 00 || ri > 32)
                    throw new ArgumentException($"{o} is not a valid color depth", nameof(TiffValidationOptions.AllowedColorDepths));

                list.Add(ri);
            });
            return list;
        }

        private IReadOnlyList<Compression> GetAllowedCompressionOptions()
        {
            if (string.IsNullOrWhiteSpace(_validationOptions.AllowedCompression))
                throw new ArgumentException("AllowedCompression is required", nameof(TiffValidationOptions.AllowedCompression));

            var list = new List<Compression>();
            var options = SplitOption(_validationOptions.AllowedCompression);
            options.ForEach(o =>
            {
                if (!Enum.TryParse(o, out Compression co))
                    throw new ArgumentException($"{co} is not a valid compression", nameof(TiffValidationOptions.AllowedCompression));
                list.Add(co);
            });
            return list;
        }

        private IReadOnlyList<int> GetAllowedResolutionsOptions()
        {
            if (string.IsNullOrWhiteSpace(_validationOptions.AllowedResolutions))
                throw new ArgumentException("AllowedResolutions is required", nameof(TiffValidationOptions.AllowedResolutions));

            var list = new List<int>();
            var options = SplitOption(_validationOptions.AllowedResolutions);
            options.ForEach(o =>
            {
                if (!int.TryParse(o, out int ri))
                    throw new ArgumentException($"{o} is not a valid resolution", nameof(TiffValidationOptions.AllowedResolutions));

                if (ri < 10 || ri > 2400)
                    throw new ArgumentException($"{o} is not a valid resolution", nameof(TiffValidationOptions.AllowedResolutions));

                list.Add(ri);
            });
            return list;
        }


        private List<string> SplitOption(string optionValue)
        {
            return optionValue.Split(new []{','}, StringSplitOptions.RemoveEmptyEntries)
                .Select(s => s.Trim()).ToList();
        }



    }
}
