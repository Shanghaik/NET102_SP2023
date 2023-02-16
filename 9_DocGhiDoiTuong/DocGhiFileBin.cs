using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace _9_DocGhiDoiTuong
{
    internal class DocGhiFileBin
    {
        static BinaryFormatter bm = new BinaryFormatter();
        static FileStream fs;
        public static void GhiVaoFileBin<T>(string path, List<T> list)
        {
            if(File.Exists(path)) {
                fs = new FileStream(path, FileMode.Open);
                bm.Serialize(fs, list); // Ghi vào trong File từ dữ liệu stream
                fs.Close();
            }
            else
            {
                Console.WriteLine("File mất tiu");
            }
        }
        public static List<T> DocTuFileBin<T>(string path)
        {
            if (File.Exists(path))
            {
                fs = new FileStream(path, FileMode.Open);
                List<T> list = (List<T>)bm.Deserialize(fs);
                return list;
            }
            else
            {
                Console.WriteLine("File mất tiu"); return null;
            }
        }
    }
}
