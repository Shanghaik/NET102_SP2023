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
                Console.WriteLine("Bạn vừa nhập số nguyên là " + x);
            }
            catch (Exception e) // Bắt lỗi và thực hiện lệnh nếu lỗi
            {
                Console.WriteLine("Bạn vừa nhập lỗi, hãy nhập lại");
                Console.WriteLine("Đây là lỗi của bạn: " + e.ToString());
                NhapSoNguyen(); // Gọi lại để nhập lại
            }// finally luôn chạy kể cả khi có hay không có lỗi
            finally
            {
                if (check)
                    Console.WriteLine("Cảm ơn bạn đã dùng Ứng dụng");
            }
        }
        // Từ khóa ref
        static void Tang10(ref int a)
        {
            Console.WriteLine("Giá trị của a trước khi tăng là " + a);
            a += 10;
            Console.WriteLine("Giá trị của a sau khi tăng là: " + a);
            // Khi ta ta dùng từ khóa ref thì nếu ta truyền vào a, giá trị
            // của a nếu thay đổi sẽ là thay đổi thực sự
        }
        // Từ khóa out
        static void PhepCong(int a, int b, out int c)
        {
            c = a + b; // biến được đánh giá là out bắt buộc phải được gán lại
            // ở trong thân hàm
        }
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            // NhapSoNguyen();
            // int b = 100;
            // Tang10(ref b);
            // Console.WriteLine("Giá trị của b sau khi gọi hàm là: " + b);
            int m; int x = 10;
            PhepCong(x, 20, out m); // m không nhất thiết phải được khỏi tạo
            // Khi truyền vào 1 thành phần mà không có ref-out thì thành phần đó 
            // chỉ là giá trị của biến được gán, trong trường hợp trên, ta chỉ lấy
            // giá trị của x chứ không phải truyền vào biến x
            Console.WriteLine("Giá trị của m là: " + m);
            //const double Pi = 3.141592654;
            //var x = 100; // x = "abc"; x đã được ngầm hiểu là int
            //dynamic a = 10;
            //a = "abc"; a = 1.7;
            //Console.WriteLine("Hello World!");
            int k;
            // phương thức int.TryParse cho phép chúng ta nhập số
            // Nếu số đó là int thì out ra giá trị trả về true, nếu không thì out ra
            // 0 và trả về false
            //bool kiemtra = int.TryParse(Console.ReadLine(), out k);
            //Console.WriteLine(k);
            // VIết lại TryParse với mô tả như sau
            // Có 2 tham số là string và out int z
            // Trả về 1 bool
            // Out ra 0 nếu string truyền vào không phải dạng int, out ra giá
            // trị nếu string truyền vào có dạng int
            // Sử dụng try-catch
            // các câu lệnh trong khối try dùng lại ngay lập tức và chuyển qua
            // catch nêu gặp exception
            int z; TryParse(Console.ReadLine(), out z); Console.WriteLine(z);
        }
        static bool TryParse(string s, out int x)
        {
            try
            {
                x = Convert.ToInt32(s); return true;
            }
            catch (Exception)
            {
                x = 0; return false;
            }
        }
    }
}
