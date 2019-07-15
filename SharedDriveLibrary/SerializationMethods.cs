using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SharedDriveLibrary
{
    public class SerializationMethods
    {
        public static byte[] Serialize(object serializable_obj)
        {
            using (var mem_stream = new MemoryStream())
            {
                (new BinaryFormatter()).Serialize(mem_stream, serializable_obj);
                return mem_stream.ToArray();
            }
        }

        public static object Deserialize(byte[] data)
        {
            using (var mem_stream = new MemoryStream(data))
            {
                return (new BinaryFormatter()).Deserialize(mem_stream);
            }
        }
    }
}
