using System;
using System.ComponentModel;
using System.Text;

namespace Generics
{
    /*
     * Generics là một phương pháp trong lập trình, sử dụng các kiểu dữ liệu
     * giả để đại diện cho nhiều kiểu dữ liệu khác
     * Generic có ưu điểm là có thể sử dụng 1 kiểu dữ liệu chung cho nhiều lớp,
     * phương thức khác mà có cấu trúc code tương tự nhau trong khi chỉ cần
     * viết 1 lần
     * Nhược điểm của Generic là khi các kiểu dữ liệu khác nhau có các tương 
     * tác hay cách sử dụng khác nhau thì áp dụng Generic sẽ có thể gây ra lỗi
     * chương trình
     * Generic được đánh dấu bởi <> vd <T> thì T được xem là 1 kiểu dữ liệu
     * Chúng ta thường sử dụng đó là phương thức Generic và Class Generic 
     * Mỗi kí hiệu Generic mặc dù có thể áp dụng cho nhiều kiểu dữ liệu
     * tuy nhiên nếu chúng đại diện cho các kiểu dữ liệu khác nhau thì cần
     * phải tạo thêm
     */
    internal class Program
    {
        // Phương thức Generic 
        static void HienThi<T>(T a, T b) // Generic T
        {
            Console.WriteLine($"Gia tri truyền vào là: {a}, {b}");
        }
        static void HienThi<T, K>(T a, K b)
        {
            Console.WriteLine($"Gia tri truyền vào là: {a}, {b}");
        }
        static void HienThi<T>(T a) where T: struct
        { // Từ khóa where giới hạn loại dữ liệu mà ta có thể dùng
            Console.WriteLine($"Gia tri truyền vào là: {a}");
        }
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            //HienThi<int>(1, 2); // Cú pháp đầy đủ
            ////HienThi("abc", "xyz"); // Cú pháp không đầy đủ - Có thể gây lỗi
            //// HienThi<dynamic>(1, "abc"); // Cách này có thể dùng
            //HienThi<int, string>(10, "1234");
            ////HienThi<string>("abcd"); // Báo lỗi vì string là class, không phải struct
            //HienThi<double>(1.5);
            // Generic Class
            //NewList<string> list = new NewList<string>();
            //list.Add("a"); list.Add("b"); list.Add("c"); list.Add("d");
            //list.Show();
            //list.Add("Mới");
            //list.Show();
            //list.RemoveAt(2);
            //list.Show();
           
        }
        
    }
}
