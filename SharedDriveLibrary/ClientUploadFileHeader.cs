using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedDriveLibrary
{
    // CLIENT PROTOCOL: Header: <Filename> <File size> <Num blocks> <Last block size>
    [Serializable]
    public class ClientUploadFileHeader
    {
        public string Filename { get; set; }
        public int FileSize { get; set; }
        public int NumBlocks { get; set; }
        public int LastBlockSize { get; set; }
    }
}
