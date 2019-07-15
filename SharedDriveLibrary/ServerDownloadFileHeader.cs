using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedDriveLibrary
{
    [Serializable]
    // HEADER PROTOCOL: <File size> <Num blocks> <Last block size>
    public class ServerDownloadFileHeader
    {
        public int FileSize { get; set; }
        public int NumBlocks { get; set; }
        public int LastBlockSize { get; set; }
    }
}
