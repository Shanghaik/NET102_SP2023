using System;
using System.Collections.Generic;
using System.Text;

namespace LAB123_Demo
{
    internal class GiangVien
    {
        string maGV;
        string tenGV;
        int soNamcongtac;
        double diemdanhgia;
        public string MaGV { get { return VietTat(); } set { maGV = value; } } // Dạng full của Property
        public string TenGV { get; set; }
        public int SoNamcongtac { get; set; }
        public double Diemdanhgia { get; set; }
        public GiangVien()
        {

        }
        public GiangVien(string maGV, string tenGV, int soNamcongtac, double diemdanhgia)
        {
            MaGV = maGV;
            TenGV = tenGV;
            SoNamcongtac = soNamcongtac;
            Diemdanhgia = diemdanhgia;
        }
        public void InThongTin()
        {
            Console.WriteLine($"Tên: {TenGV}, Mã: {MaGV}," +
                $" Số năm CT: {SoNamcongtac}, Điểm đánh giá: {Diemdanhgia}");
        }
        public string ThongTin()
        {
            return $"Tên: {TenGV}, Mã: {MaGV}," +
                $" Số năm CT: {SoNamcongtac}, Điểm đánh giá: {Diemdanhgia}";
        }
        public string VietTat()
        {
            string[] amtiet = TenGV.Split(' ');
            string result = amtiet[amtiet.Length - 1];
            for (int i = 0; i < amtiet.Length - 1; i++)
            {
                result += amtiet[i][0];
            }
            return result;
        }
    }
}
