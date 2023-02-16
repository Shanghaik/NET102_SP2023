using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace _9_DocGhiDoiTuong
{
    internal class DocGhiFileXml
    {
        
        public void GhiVaoFileXml<T>(string path, List<T> list)
        {
            if(File.Exists(path)) {
                XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
                // Tạo 1 đối tượng serializer với kiểu List<T>
                TextWriter tw = new StreamWriter(path);
                serializer.Serialize(tw, list); // Ghi thông tin Từ List vào file
                tw.Close(); // Ghi xong thì đóng luồng lại
            }
            else
            {
                Console.WriteLine("File không tồn tại");
            }
        }
        public List<T> DocTuFileXml<T>(string path)
        {
            if (File.Exists(path))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
                FileStream fs = new FileStream(path, FileMode.Open);
                // Taoj 1 File stream để lấy dữ liệu từ đường dẫn file
                var result = serializer.Deserialize(fs);
                // Đọc dữ liệu đã được đưa vào stream từ file
                List<T> list = (List<T>)result; // Ép kiểu để thu được kết quả
                return list;
            }
            else
            {
                Console.WriteLine("File không tồn tại"); return null;  
            }
        }
    }
}
