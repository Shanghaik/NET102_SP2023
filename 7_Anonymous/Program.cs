using System;
using System.Text;

namespace _7_Anonymous
{
    /*
     * Anomymous - Kiểu dữ liệu nặc danh cho phép ta khai
     * báo một đối tượng có nhiều thuộc tính mà không đi 
     * kèm với tên Class
     * Anonymous rất linh hoạt và phù hợp cho những bài toán 
     * mà có tính thay đổi cao, sẽ không cần phải sửa các đối
     * tượng. Tuy nhiên Anonymous thuộc dạng Immutable - readonly
     * Về cơ bản, Anonymous kế thừa trực tiếp từ lớp Object
     * var tên_biến = new {param1 =  value1, ..., param_n = value_n};
     */
    /*
     * Lambda expression: Biệt thức lambda
     * (danh_sách_tham_số) => biểu_thức;
     * (danh_sách_tham_số) => {
     *  // các câu lệnh, có thể bao gồm cả return;
     * }
     * Lambda Expression được xây dựng dựa theo delegate hay còn gọi là chuyển đổi
     * thành delegate
     */
    internal class Program
    {
        public delegate int Calculate (int x, int y);
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            //dynamic x = new
            //{
            //    name = "Khánh",
            //    age = 20,
            //    description = "Đẹp trai"
            //};
            //Console.WriteLine(x.name);  // x.age = 30; readonly !!!
            //Console.WriteLine(x.age);
            //TrichXuat(x);
            Calculate sum = (int a, int b) => a + b;
            Func<int, double, double> abc = (int x, double y) => x * y;
            Console.WriteLine(sum(10, 20));
            Console.WriteLine(abc(8, 3.7));
        }
        string NoiChu(string a, string b) => a + b; // Dùng lambda để khai báo
        // phương thức
        // Đoạn trên tương đương với:
        /*
         * string NoiChu(string a, string b){
         *      return a+b;
         * }
         */
        static void TrichXuat(dynamic s)
        {
            Console.WriteLine(s.description);
        }
    }
}
