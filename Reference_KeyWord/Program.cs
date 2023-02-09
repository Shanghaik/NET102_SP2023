using System;
using System.IO.Pipes;
using System.Text;

namespace _5_Reference_KeyWord
{
    internal class Program
    {
        /*
         * static: keyword đánh dấu 1 thành phần là tĩnh
         * vd hàm Main.
         * Đối với các thành phần tĩnh, ta có thể gọi trực tiếp
         * thông qua tên class mà không cần tạo đối tượng
         * var là key word đánh dấu 1 biến có thể nhận được mọi
         * kiểu dữ liệu trước khi nó được sử dụng. Sau khi nó được
         * sử dụng, biến đó sẽ có 1 kiểu dữ liệu duy nhất
         * const đánh dấu 1 biến là hằng số, hằng số không thể bị
         * thay đổi.
         * kiểu dynamic: là kiểu dữ liệu linh hoạt, cho phép biến
         * nhận mọi kiểu dữ liệu và có thể thay đổi trong quá trình
         * biến đó được sử dụng.
         * tên biến không được đặt trùng với keywords
         * ref - out đánh dấu các biến có thể được tham chiếu
         * try - catch: khối lệnh được sử dụng để bắt lỗi (exception)
         */
        static void NhapSoNguyen()
        {
            int x = 0; bool check = false;
            try // try tab tab
            { // Try được sử dụng để thực hiện các lệnh mà bạn muốn
                Console.WriteLine("Hãy nhập số");
                x = Convert.ToInt32(Console.ReadLine()); check = true;
                Console.WriteLine("Bạn vừa nhập số nguyên là "+ x);
            }
            catch (Exception e) // Bắt lỗi và thực hiện lệnh nếu lỗi
            {
                Console.WriteLine("Bạn vừa nhập lỗi, hãy nhập lại");
                Console.WriteLine("Đây là lỗi của bạn: "+e.ToString());
                NhapSoNguyen(); // Gọi lại để nhập lại
            }// finally luôn chạy kể cả khi có hay không có lỗi
            finally { if(check) Console.WriteLine("Cảm ơn bạn đã dùng Ứng dụng"); }
        }
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            NhapSoNguyen(); 
            //const double Pi = 3.141592654;
            //var x = 100; // x = "abc"; x đã được ngầm hiểu là int
            //dynamic a = 10;
            //a = "abc"; a = 1.7;
            //Console.WriteLine("Hello World!");
        }
    }
}
