using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedDriveLibrary
{
    public class ValueDefinitions
    {
        public enum RequestType { GetList, UploadFile, DownloadFile, DeleteFile };
        public enum ResponeType { Success, Failure };
        public enum ActionType { Upload, Download, Delete };
        public const int BlockSize = 1024;
        public const string ServerIPAddress = "192.168.1.105";
        public const int ServerPortNumber = 8080;
    }
}
