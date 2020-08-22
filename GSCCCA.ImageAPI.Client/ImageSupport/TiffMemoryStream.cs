using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using BitMiracle.LibTiff.Classic;

namespace GSCCCA.ImageAPI.Client.ImageSupport
{
    public class TiffMemoryStream : TiffStream, IDisposable 
    {
        private readonly MemoryStream _ms;

        public TiffMemoryStream()
        {
            _ms = new MemoryStream();
        }

        public TiffMemoryStream(MemoryStream memoryStream)
        {
            _ms = memoryStream;
        }

        public TiffMemoryStream(byte[] bytes)
        {
            _ms = new MemoryStream(bytes);
        }

        public TiffMemoryStream(Stream stream)
        {
            _ms = new MemoryStream();
            stream.CopyTo(_ms);
        }

        public static async Task<TiffMemoryStream> CreateFromFileAsync(string filePath)
        {
            using (var f = File.OpenRead(filePath))
            {
                var ms = new MemoryStream();
                await f.CopyToAsync(ms);
                ms.Position = 0;
                return new TiffMemoryStream(ms);
            }
        }


        public TiffMemoryStream(string filePath)
        {
            using (var f = File.OpenRead(filePath))
            {
                _ms = new MemoryStream();
                f.CopyTo(_ms);
                _ms.Position = 0;
            }
        }

        public MemoryStream GetUnderlyingStream()
        {
            _ms.Position = 0;
            return _ms;
        }

        public void WriteToFile(string path)
        {
            _ms.Position = 0;
            using (var f = File.OpenWrite(path))
            {
                _ms.CopyTo(f);
            }
        }

        public async Task WriteToFileAsync(string path)
        {
            _ms.Position = 0;
            using (var f = File.OpenWrite(path))
            {
                await _ms.CopyToAsync(f).ConfigureAwait(false);
            }
        }


        public override int Read(object clientData, byte[] buffer, int offset, int count)
        {
            return _ms.Read(buffer, offset, count);
        }

        public override void Write(object clientData, byte[] buffer, int offset, int count)
        {
            _ms.Write(buffer,offset,count);
        }

        public override long Seek(object clientData, long offset, System.IO.SeekOrigin whence)
        {
            return _ms.Seek(offset, whence);
        }

        public override void Close(object clientData)
        {
            _ms.Close();
        }

        public override long Size(object clientData)
        {
            return _ms.Length;
        }

        public void Dispose()
        {
            _ms?.Dispose();
        }
    }
}
