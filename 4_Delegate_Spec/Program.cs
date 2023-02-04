using System;
using System.Text;

namespace _4_Delegate_Event
{
    /*
     * Một số loại Delegate đặc biệt (Dựng sẵn)
     * Có 3 loại cơ bản
     * 1. Action: Tương đương với một delegate mà kiểu trả về là void
     * Action<T p1, T p2, ...> trong đó T là kiểu dữ liệu bất kì
     * p1, p2 là các tham số. 
     * 2. Predicate: Tuong đương với 1 delegate mà trả về bool, Pre
     * thường được sử dụng làm Callback khi cần kiểm tra
     * Predicate<T p>: Predicate chỉ có thể truyền vào bởi 1 tham số
     * Func: Tương đương với 1 delegate có kiểu trả về bất kì
     * Func<T p1, T p2,... T return> với p1, p2 là các tham số, T return
     * là kiểu trả về
     * Các delegate có thể được dùng trực tiếp mà không cần khai báo mới
     */
    delegate void InThongTin(string s); // Action 
    delegate bool CheckAmDuong(int x); // Predicate
    delegate int TinhTong(int a, int b);// Func
    internal class Program
    {
        static void InLoiChao(string chao)
        {
            Console.WriteLine(chao);
        }
        static bool KiemTraSo(int x)
        {
            if(x>=0) { return true; }
            else return false;
        }
        static void NhapSo(Predicate<int> predicate)
        {
            Console.WriteLine("Nhập vào 1 số tự nhiên");
            int num = Convert.ToInt32(Console.ReadLine());
            if (predicate(num)) Console.WriteLine("Bạn đã nhập đúng");
            else {
                Console.WriteLine("Bạn nhập sai, mời nhập lại"); 
                NhapSo(predicate);
            }
        }
        static int TinhTich(int a, int b) { return a*b; }
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            InThongTin inThongTin = InLoiChao;
            inThongTin.Invoke("Chào buổi sáng");
            Action<string> chao = InLoiChao; // Tạo 1 action tham chiếu tới hàm
            chao("Chào buổi tối");
            Predicate<int> tuNhien = KiemTraSo;
            //if (tuNhien(10)) Console.WriteLine("Đây là số tự nhiên");
            //else Console.WriteLine("Đây là số nguyên âm");
            NhapSo(tuNhien);
            Func<int, int, int> func = TinhTich;
            Console.WriteLine(func(13, 4));
        }
    }
}
