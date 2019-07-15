using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedDriveLibrary
{
    [Serializable]
    public class ClientDownloadFileHeader
    {
        public string Filename { get; set; }
    }
}
