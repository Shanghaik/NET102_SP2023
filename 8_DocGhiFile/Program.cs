using System;
using System.IO;

namespace _8_DocGhiFile
{
    internal class Program
    {
        /*
         * File là một tổ chức dữ liệu được đóng gói lại thành các tệp tin
         * để phục vụ cho quá trình quản lý và truy xuất 
         * Find Five Fine File. 
         * Các dạng file phổ biến là: txt, docx, png, jpeg, jpg, mp4, mov,
         * xml, html, css, js, cs, php, java, py,... 
         * File thường được sử dụng cho các ứng dụng dạng game, ứng dụng
         * offline, nếu các ứng dụng online thì các file dữ liệu này giúp
         * giảm tải cho server...
         * Có 2 hoạt động với file phổ biến nhất là đọc và ghi (IO)
         */
        static void Main(string[] args)
        {
            // Đọc dữ liệu từ file text - phải có đường dẫn
            //string result = File.ReadAllText(@"C:\Users\Acer\source\repos\NET101_SP2023\8_DocGhiFile\KhanhPG.txt");
            //Console.WriteLine(result);
            // string result2 = File.ReadAllText(@"KhanhPG.txt");
            // Ghi dữ liệu vào file text
            //string content = "Mac du toi co don nhưng toi van dep trai";
            //File.WriteAllText("Codon.txt", content);
            // Nếu file đó chưa tồn tại thì nó sẽ được tạo ra tự động
            // Đọc lại file vừa ghi
            //string doc = File.ReadAllText("Codon.txt");
            //Console.WriteLine(doc);
            //// Đọc từng dòng trong file text
            //string[] tungdong = File.ReadAllLines("Codon.txt");
            //Console.WriteLine(string.Join("\n+++", tungdong));
            //// Đọc từng byte
            //byte[] tungbyte = File.ReadAllBytes("Codon.txt");
            //Console.WriteLine(string.Join("\n---", tungbyte));
            // Ghi tương tự 
            string[] contents = { "Em đẹp", "Như một", "Bông hoa", "Nhài" };
            // File.WriteAllLines("Codon.txt", contents);
            // Khi sử dụng các phương thức Write thì dữ liệu sẽ bị ghi đè
            // Cách để dữ liệu không bị ghi đè
            // Cách 1: Đọc cũ + mới -> Ghi đè
            // Cách thứ 2: Dùng phương thức Append
            File.AppendAllLines("Codon.txt",
                new string[] { "Cắm", "Bãi", "Đất", "Hoang" });
            // Tương tự với AppendAllText
            
        }
    }
}
