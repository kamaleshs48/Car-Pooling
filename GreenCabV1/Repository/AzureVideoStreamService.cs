using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace GreenCabV1.Repository
{
    public class AzureVideoStreamService : IAzureVideoStreamService
    {
        private HttpClient _client;

        public AzureVideoStreamService()
        {
            _client = new HttpClient();
        }

        public async Task<Stream> GetVideoByName(string name)
        {
            var urlBlob = string.Empty;
            switch (name)
            {
                case "earth":
                    urlBlob = "https://anthonygiretti.blob.core.windows.net/videos/earth.mp4";
                    break;
                case "nature1":
                    urlBlob = "https://anthonygiretti.blob.core.windows.net/videos/nature1.mp4";
                    break;
                case "nature2":
                default:
                    urlBlob = "https://anthonygiretti.blob.core.windows.net/videos/nature2.mp4";
                    break;
            }

            //FileStream fs = new FileStream(@"D:\Videos\\Test2.mp4", FileMode.Open);
            //byte[] bdata = Encoding.Default.GetBytes("Hello File Handling!");
            //fs.Write(bdata, 0, bdata.Length);
            // fs.Close();
            //  Console.WriteLine(data);
          //  return fs;//_client.GetStreamAsync(data);

            return await _client.GetStreamAsync(urlBlob);
        }

        public async Task<Stream> GetVideoUrl(string Url)
        {
           
            //FileStream fs = new FileStream(@"D:\Videos\\Test2.mp4", FileMode.Open);
            //byte[] bdata = Encoding.Default.GetBytes("Hello File Handling!");
            //fs.Write(bdata, 0, bdata.Length);
            // fs.Close();
            //  Console.WriteLine(data);
            //  return fs;//_client.GetStreamAsync(data);

            return await _client.GetStreamAsync(Url);
        }

        ~AzureVideoStreamService()
        {
            if (_client != null)
                _client.Dispose();
        }
    }
}
