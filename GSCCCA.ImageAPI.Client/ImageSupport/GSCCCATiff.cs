using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using BitMiracle.LibTiff.Classic;
using GSCCCA.ImageAPI.Client.Infrastructure;

namespace GSCCCA.ImageAPI.Client.ImageSupport
{
    public class GSCCCATiff : IDisposable
    {
        //If this RegEx is modified, it must continue to return the doc type (an enum value) as group 1,
        //the County ID as group 2, the book as group 3, and the page as group 4
        public const string DocumentNameRegex = @"\A(deed|plat|lien|ucc)\\(\d{1,3})\\(\w{1,5})\\(\w{1,6})";
        
        public const string PageRegex = @"\A\w{1,6}\z";
        public const string BookRegex = @"\A\w{1,5}\z";


        private const TiffTag TIFFTAG_PreviousPage = (TiffTag)37572;
        private const TiffTag TIFFTAG_NextPage= (TiffTag)37574;

        private static Tiff.TiffExtendProc m_parentExtender;

        private static void TagExtender(Tiff tif)
        {
            TiffFieldInfo[] tiffFieldInfo =
            {
                new TiffFieldInfo(TIFFTAG_PreviousPage, -1, -1, TiffType.ASCII,
                    FieldBit.Custom, true, false, "PreviousPage"),
                new TiffFieldInfo(TIFFTAG_NextPage, -1, -1, TiffType.ASCII,
                    FieldBit.Custom, true, false, "NextPage")
            };

            tif.MergeFieldInfo(tiffFieldInfo, tiffFieldInfo.Length);

            if (m_parentExtender != null)
                m_parentExtender(tif);
        }

        static GSCCCATiff()
        {
            m_parentExtender = Tiff.SetTagExtender(TagExtender);
        }


        public enum DocumentTypeEnum
        {
            NotSet = 0,
            Deed = 1,
            Plat = 2,
            Lien = 3,
            UCC = 4
        }

        private enum DocumentNameField
        {
            DocumentType = 0,
            CountyId = 1,
            Book = 2,
            Page = 3
        }

        public DocumentTypeEnum DocumentType
        {
            get => (DocumentTypeEnum) Enum.Parse(typeof(DocumentTypeEnum), GetDocumentNameField(DocumentNameField.DocumentType), true);
            set => SetDocumentNameField(DocumentNameField.DocumentType, value.ToString());
        }

        public string Checksum => _checksum ?? (_checksum = ChecksumCalc.Calculate(_tms.GetUnderlyingStream().ToArray()));

        public decimal XRes => GetTagField<decimal>(TiffTag.XRESOLUTION);
        public decimal YRes => GetTagField<decimal>(TiffTag.YRESOLUTION);
        public int? BitPerPixel => GetTagField<int?>(TiffTag.BITSPERSAMPLE) * GetTagField<int?>(TiffTag.SAMPLESPERPIXEL);
       // public int ColorDepth => GetTagField<int>(TiffTag.PHOTOMETRIC);

        public Compression Compression => GetTagField<Compression>(TiffTag.COMPRESSION);

        public string FileName => _tiff.FileName();


        private T GetTagField<T>(TiffTag field)
        {
            var val = _tiff.GetField(field);
            if (val == null || val.Length < 1)
                return default(T);

            var cType = typeof(T);
            if (cType.IsConstructedGenericType) //is it nullable
            {
                cType = cType.GenericTypeArguments[0];
            }

            return (T) Convert.ChangeType(val[0].Value, cType);
        }


        public string DocumentName => GetTiffStringField(TiffTag.DOCUMENTNAME);

        public string Book
        {
            get => GetDocumentNameField(DocumentNameField.Book);
            set => SetDocumentNameField(DocumentNameField.Book, value);
        }

        public string Page
        {
            get => GetDocumentNameField(DocumentNameField.Page);
            set => SetDocumentNameField(DocumentNameField.Page, value);
        }

        public string CountyId
        {
            get => GetDocumentNameField(DocumentNameField.CountyId);
            set => SetDocumentNameField(DocumentNameField.CountyId, value);
        }

        public string Artist
        {
            get => GetTiffStringField(TiffTag.ARTIST);
            set => SetTiffStringField(TiffTag.ARTIST, value);
        }


        public string PreviousPage
        {
            get => GetTiffStringField(TIFFTAG_PreviousPage);
            set => SetTiffStringField(TIFFTAG_PreviousPage, value);
        }

        public string NextPage
        {
            get => GetTiffStringField(TIFFTAG_NextPage);
            set => SetTiffStringField(TIFFTAG_NextPage, value);
        }


        private string GetTiffStringField(TiffTag field)
        {
            var val = _tiff.GetField(field);
            if (val == null) return null;
            if (val.Length > 0)
            {
                return val[0].ToString();
            }

            return null;
        }

        private void SetTiffStringField(TiffTag field, string value)
        {
            _tiff.SetMode(258);
            _tiff.SetField(field, value);
            _tiff.CheckpointDirectory();
            _tiff.SetMode(0);
        }


        private GSCCCATiff(TiffMemoryStream tms, Tiff tiff)
        {
            _tiff = tiff;
            _tms = tms;
            ParseDocumentName();


            var f3 = _tiff.GetField(TiffTag.COMPRESSION);

            

        }

        private readonly Tiff _tiff;

        private readonly TiffMemoryStream _tms;


        public Stream GetUnderlyingStream()
        {
            return _tms.GetUnderlyingStream();
        }

        public void SaveToFile(string path)
        {
            _tms.WriteToFile(path);
        }

        public async Task SaveToFileAsync(string path)
        {
            await _tms.WriteToFileAsync(path);
        }

        public static GSCCCATiff CreateFromStream(Stream tiffStream, string name)
        {
            var tms = new TiffMemoryStream(tiffStream);
            var tiff = Tiff.ClientOpen(name, "r", null, tms);
            var gtiff = new GSCCCATiff(tms, tiff);
            return gtiff;
        }


        public static GSCCCATiff CreateFromBytes(byte[] tiffBytes, string name)
        {
            var tms = new TiffMemoryStream(tiffBytes);
            var tiff = Tiff.ClientOpen(name, "r", null, tms);
            var gtiff = new GSCCCATiff(tms, tiff);
            return gtiff;
        }


        public static async Task<GSCCCATiff> OpenFileAsync(string path)
        {

            var tms = await TiffMemoryStream.CreateFromFileAsync(path).ConfigureAwait(false);
            var tiff = Tiff.ClientOpen(path, "r", null, tms);
            var gtiff = new GSCCCATiff(tms, tiff);
            return gtiff;

        }

        public static GSCCCATiff OpenFile(string path)
        {

            var tms = new TiffMemoryStream(path);
            var tiff = Tiff.ClientOpen(path, "r", null, tms);
            var gtiff = new GSCCCATiff(tms, tiff);
            return gtiff;

        }


        private Dictionary<DocumentNameField, string> _documentNameValues = new Dictionary<DocumentNameField, string>();
        private  string _checksum;


        private bool AreAllDocumentNameFieldsSet()
        {
            return _documentNameValues.ContainsKey(DocumentNameField.Book)
                   && _documentNameValues.ContainsKey(DocumentNameField.CountyId)
                   && _documentNameValues.ContainsKey(DocumentNameField.Page)
                   && _documentNameValues.ContainsKey(DocumentNameField.DocumentType);
        }


        private void SetDocumentNameField(DocumentNameField field, string value)
        {
            _documentNameValues[field] = value;
            if (AreAllDocumentNameFieldsSet())
            {
                var dn = AssembleDocumentName();
                SetTiffStringField(TiffTag.DOCUMENTNAME, dn);
            }
        }


        private string GetDocumentNameField(DocumentNameField field)
        {
            if (_documentNameValues.ContainsKey(field))
                return ZeroPadDocumentNameField(field,_documentNameValues[field]);

            if (field == DocumentNameField.DocumentType)
                return "NotSet";

            return null;
        }



        private string ZeroPad(string value, int length)
        {
            if (value == null)
                return null;

            if (value.Length < length)
            {
                return value.PadLeft(length, '0');
            }

            return value;
        }


        private void ParseDocumentName()
        {
            var dn = GetTiffStringField(TiffTag.DOCUMENTNAME);

            if (string.IsNullOrWhiteSpace(dn)) return;
            dn = dn.Trim();
            var match = Regex.Match(dn, DocumentNameRegex,
                RegexOptions.IgnoreCase | RegexOptions.Singleline);
            if (!match.Success) return;

            _documentNameValues[DocumentNameField.Book] = match.Groups[3].Value;
            _documentNameValues[DocumentNameField.Page] = match.Groups[4].Value;
            _documentNameValues[DocumentNameField.DocumentType] = match.Groups[1].Value;
            _documentNameValues[DocumentNameField.CountyId] = match.Groups[2].Value;
        }


        private string AssembleDocumentName()
        {
            return $@"{DocumentType.ToString().ToLower()}\{CountyId}\{Book}\{Page}";
        }

        private string ZeroPadDocumentNameField(DocumentNameField field, string value)
        {
            if (field == DocumentNameField.CountyId)
                return ZeroPad(value, 3);
            if (field == DocumentNameField.Book)
                return ZeroPad(value, 5);
            if (field == DocumentNameField.Page)
                return ZeroPad(value, 5);
            return value;
        }


        private void ValidateDocumentNameField(DocumentNameField field, string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Cannot set a document name field to null or empty");

            if (field == DocumentNameField.DocumentType)
            {
                if (!value.Equals("deed", StringComparison.OrdinalIgnoreCase) &&
                    !value.Equals("plat", StringComparison.OrdinalIgnoreCase) &&
                    !value.Equals("lien", StringComparison.OrdinalIgnoreCase) &&
                    !value.Equals("ucc", StringComparison.OrdinalIgnoreCase))
                {
                    throw new ArgumentException("Invalid document type");
                }
            }
            else if (field == DocumentNameField.CountyId)
            {
                if (!int.TryParse(value, out int cId))
                {
                    throw new ArgumentException("Invalid County ID");
                }

                if (cId < 1 || cId > 159)
                {
                    throw new ArgumentException("Invalid County ID");
                }
            }
            else if (field == DocumentNameField.Book)
            {
                if (!Regex.IsMatch(value, BookRegex))
                {
                    throw new ArgumentException("Invalid Book");
                }
            }
            else if (field == DocumentNameField.Page)
            {
                if (!Regex.IsMatch(value, PageRegex))
                {
                    throw new ArgumentException("Invalid Page");
                }
            }
        }


        public void Dispose()
        {
            _tiff?.Dispose();
            _tms?.Dispose();
        }
    }
}
