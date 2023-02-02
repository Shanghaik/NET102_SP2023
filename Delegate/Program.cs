using System;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using static Delegate.Program;

namespace Delegate
{
    internal class Program
    {
        /*
         * Delegate là gì? Delegate được định nghĩa là 1 kiểu dữ liệu mà
         * có thể chứa tham chiếu đến hàm
         * Một Delegate có thể trỏ tới 1 hoặc nhiều hàm cùng 1 lúc
         * Để trỏ tới 1 hàm thì Delegate cần có cấu trúc (chữ kí hàm) giống
         * hệt với hàm đó (Bao gồm kiểu trả về và tham số truyền vào)
         * Khi khai báo Delegate chúng ta khai báo giống như 1 phương thức
         * abstract (Không có phần thân)
         */
        public delegate void XuatThongTin(string s);
        // Delegate này có thể trỏ tới mọi hàm void mà truyền vào 1 string,
        // Tức là khi trỏ tới, delegate được sử dụng thay thế hàm
        static void InChucMung(string loichuc)
        {
            Console.WriteLine("Chúc bạn " + loichuc);
        }
        static void LoiDongVien(string dongvien)
        {
            Console.WriteLine("Hãy " + dongvien);
        }
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            // Khai báo Delegate
            //XuatThongTin xuatThongTin = null; // Cách 1
            //xuatThongTin = new XuatThongTin(InChucMung);
            XuatThongTin xuatThongTin = InChucMung; // Cách 2
            //xuatThongTin = LoiDongVien; // Trỏ đến LoiDongVien
            // Khởi chạy
            //xuatThongTin("Phát tài phát lộc");
            // Trỏ đến nhiều hàm cùng 1 lúc (Multicate)
            xuatThongTin += LoiDongVien;
            xuatThongTin -= LoiDongVien;
            xuatThongTin("Phát tài phát lộc");

            Console.ReadKey();
        }
    }
}
