using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace GreenCabV1.Repository
{
    public interface IAzureVideoStreamService
    {
        Task<Stream> GetVideoByName(string name);
    }
}
