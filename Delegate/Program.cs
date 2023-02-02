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
        /*
         * Callback là khi 1 hàm sử dụng 1 hàm khác như 1 tham số truyền vào
         * Với C# thì điều này không thể thực hiện được vì 1 hàm không phải là 1 kiểu dữ liệu
         * Để thực hiện được Callback thì ta dùng delegate để tham chiếu tới hàm
         * mà ta muốn thực hiện Callback
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
        // Delegate trả về giá trị
        delegate string KiemTra(int x);

        static string KiemTraSoLe(int x)
        {
            return $"{x} là số {(x % 2 == 0 ? "Chẵn" : "Lẻ")}";
        }

        // Call Back
        delegate void ThanhTra(int x, int y); 
        static void KetHon(int tuoivo, int tuoichong)
        {
            if(tuoivo >= 18 && tuoichong >= 20) {
                Console.WriteLine("Kết hôn hợp pháp");
            }
            else Console.WriteLine("Bất hợp pháp");
        }
        static void MayBay(int tuoivo, int tuoichong)
        {
            if (tuoivo - tuoichong >= 5 && tuoivo - tuoichong < 10)
            {
                Console.WriteLine("Phi công hạng nhẹ");
            }else if(tuoivo - tuoichong >= 10 && tuoivo - tuoichong < 15)
            {
                Console.WriteLine("Phi công hạng trung");
            }
            else Console.WriteLine("Phi công hạng nặng");
        }
        static void DieuTra(ThanhTra thanhTra)
        {
            Console.WriteLine("Nhập tuổi của 2 vợ chồng lúc kết hôn");
            Console.WriteLine("Nhập tuổi vợ:"); int tuoivo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập tuổi chồng:"); int tuoichong = Convert.ToInt32(Console.ReadLine());
            thanhTra(tuoivo, tuoichong); // Lúc này delegate được callback chưa trỏ đến hàm nào cả
        }
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            // Khai báo Delegate
            //XuatThongTin xuatThongTin = null; // Cách 1
            //xuatThongTin = new XuatThongTin(InChucMung);
            //XuatThongTin xuatThongTin = InChucMung; // Cách 2
            //xuatThongTin = LoiDongVien; // Trỏ đến LoiDongVien
            // Khởi chạy
            //xuatThongTin("Phát tài phát lộc");
            // Trỏ đến nhiều hàm cùng 1 lúc (Multicate)
            //xuatThongTin += LoiDongVien;
            //xuatThongTin -= LoiDongVien; // Khi không muốn trỏ nữa thì ta -= để loại bỏ
            //xuatThongTin("Phát tài phát lộc");
            //KiemTra kiemTra = KiemTraSoLe;
            //Console.WriteLine(kiemTra(20));
            ThanhTra thanhTra = KetHon;
            thanhTra += MayBay;
            DieuTra(thanhTra);
            // Dùng trực tiếp hàm ở trong vẫn được và Delegate sẽ được tham chiếu ngầm đến hàm
            // DieuTra(KetHon);
            //DieuTra(MayBay);
            Console.ReadKey();
        }
    }
}
