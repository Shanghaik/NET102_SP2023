using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace _9_DocGhiDoiTuong
{
    internal class DocGhiFileTxt
    {
        public void GhiVaoFileText(string path, List<SanPham> sps)
        {
            if(File.Exists(path)) // Kiểm tra sự tồn tại của File
            {
                foreach (var item in sps)
                {
                    string line = item.ObjToString();
                    // Tạo ra thông tin cho 1 dòng mới để ghi vào file
                    File.AppendAllText(path, line); // Thêm dòng mới vào trong file
                }
            }
            else Console.WriteLine("File không tồn tại"); // CŨng có thể tự tạo ra           
        }
        public List<SanPham> DocTuFileText(string path)
        {
            List<SanPham> sanphams = new List<SanPham>();
            string[] lines = File.ReadAllLines(path);  // Đọc tất cả các dòng từ file txt vào 1 mảng
            foreach (var line in lines)
            {
                if(line.Trim().Length == 0) continue;
                else
                {
                    string[] properties = line.Split(',');// Mỗi dòng thu được ta cắt theo dấu ','
                    SanPham sp = new SanPham();
                    sp.Id = Guid.Parse(properties[0].Split(':')[1]);
                    sp.TenSP = properties[1].Split(':')[1];
                    sp.GiaSp = Convert.ToDouble(properties[2].Split(':')[1]);
                    sp.NhaCungCap = properties[3].Split(':')[1];
                    sanphams.Add(sp); // Thêm vào List
                }
            }
            return sanphams;    
        }
    }
}
