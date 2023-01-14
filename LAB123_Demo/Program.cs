using System;

namespace LAB123_Demo
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            //Services.Bai1();
            GiangVienServices giangVienServices = new GiangVienServices();
            giangVienServices.AddToList();
            //giangVienServices.ShowList(); // Cách này lằng nhằng
            giangVienServices.InDanhSach();
            //giangVienServices.XoaTren25();
            //giangVienServices.SuaTenTrongList();
            giangVienServices.Top3DanhGia();

        }
    }
}
