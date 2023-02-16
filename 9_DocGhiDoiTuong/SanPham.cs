using System;
using System.Collections.Generic;
using System.Text;

namespace _9_DocGhiDoiTuong
{
    [Serializable] 
    public class SanPham // Lớp để đọc ghi được phải là public
    {
        public Guid Id { get; set; } // Mã tự sinh random
        public string TenSP { get; set; }
        public double GiaSp { get; set; }
        public string NhaCungCap { get; set; }
        public SanPham()
        {

        }
        public SanPham(Guid id, string tenSP, double giaSp, string nhaCungCap)
        {
            Id = id;
            TenSP = tenSP;
            GiaSp = giaSp;
            NhaCungCap = nhaCungCap;
        }
        public void InThongTin()
        {
            Console.WriteLine($"ID: {Id}, Tên: {TenSP} có giá {GiaSp}, sản" +
                $"xuất tại: {NhaCungCap}");
        }
        public string ObjToString() // Chỉ cần dùng khi ta đọc ghi file text thủ công
        {
            return $"\nID:{Id},Tên:{TenSP},Giá:{GiaSp},NCC:{NhaCungCap}";
        }
    }
}
