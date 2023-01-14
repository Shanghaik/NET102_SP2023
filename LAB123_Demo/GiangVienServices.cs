using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;

namespace LAB123_Demo
{
    internal class GiangVienServices
    {
        private List<GiangVien> giangViens;
        public GiangVienServices()
        {
            GiangViens = new List<GiangVien>();
        }

        public GiangVienServices(List<GiangVien> giangViens)
        {
            this.GiangViens = giangViens;
        }
        internal List<GiangVien> GiangViens { get => giangViens; set => giangViens = value; }

        public void AddToList() // Nhập và thêm vào List
        {
            GiangVien gv = new GiangVien();
            Console.WriteLine("Nhập thông tin của GV:");
            Console.WriteLine("Nhập tên: ");gv.TenGV = Console.ReadLine();
            //Console.WriteLine("Nhập mã: ");gv.MaGV = Console.ReadLine();
            Console.WriteLine("Nhập năm công tác");
            gv.SoNamcongtac = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập điểm đánh giá");
            gv.Diemdanhgia = double.Parse(Console.ReadLine());
            // Thêm đối tượng vào List
            giangViens.Add(gv);
            // Có muốn nhập thêm không?
            Console.WriteLine("Bạn có muốn nhập thêm ko? Nhập Y/y để tiếp, còn lại là không.");
            if (Console.ReadLine().ToLower() == "y")
            {
                AddToList();
            }
        }
        // Cách lằng nhằng
        private List<string> ListObjToListString()
        {
            List<string> list = new List<string>();
            foreach (var item in giangViens)
            {
                list.Add(item.ThongTin());
            }return list;
        }
        public void ShowList()
        {
            Console.WriteLine(String.Join("\n", ListObjToListString()));
        }
        // Cách đơn giản
        public void InDanhSach()
        {
            foreach (var item in giangViens)
            {
                item.InThongTin();
            }
        }
        // Xóa GV cong tac trên 25 năm
        public void XoaTren25()
        {
            giangViens.RemoveAll(p => p.SoNamcongtac > 25);
            InDanhSach();
        }

        public void SuaTenTrongList()
        {
            foreach (var item in giangViens)
            {
                item.TenGV = item.Diemdanhgia >=3.5? "-" + item.TenGV:item.TenGV;
            }
            InDanhSach();
        }

        public void Top3DanhGia()
        {
            //List<GiangVien> giangViens2 = giangViens; // Không tạo như thế này
            //List<GiangVien> giangViens2 = new List<GiangVien>(giangViens);
            //List<GiangVien> giangViens2 = new List<GiangVien>(giangViens.ToList());
            //List<GiangVien> giangViens2 = new List<GiangVien>();
            //foreach(var item in giangViens) giangViens2.Add(item);
            giangViens = giangViens.OrderByDescending(p => p.Diemdanhgia).ToList();// Sắp xếp 
            var temp = giangViens[2];
            foreach (var item in giangViens)
            {
                if (item.Diemdanhgia >= temp.Diemdanhgia)
                {
                    item.InThongTin();
                }
            }

        }
    }
}
