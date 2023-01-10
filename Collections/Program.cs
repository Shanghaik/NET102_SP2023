using System;
using System.Collections; // non-Generic 
using System.Collections.Generic; // Generic 
using System.Text;

namespace Collections
{
    internal class Program
    {
        /*
         * Collections Là các class được tạo ra giúp chúng ta trong việc lưu trữ
         * và quản lý dữ liệu. Collection có thể chứa được mọi kiểu dữ liệu
         * Collection được chia ra 2 loại 
         * + non-Generic Collection (ArrayList, Hashmap,...)
         * + Generic Collection (List, Dictionary)
         * Các collection thông dụng List, Dictionary, ...
         * Một số collection đặc biệt như stack, queue,...
         * 2 đại diện của non-G và Generic collection là ArrayList và List
         * Với Generic thì chúng ta cần xác định kiểu dữ liệu của đối tượng mà 
         * collection đó chứa trước khi thực hiện các thao tác
         * Với non-Generic thì chúng ta không cần xác định kiểu dữ liệu của đối tượng 
         * mà collection đó chứa trước khi thực hiện các thao tác, vì chúng chấp
         * nhận mọi kiểu dữ liệu trong cùng collection
         */
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            // Khởi tạo
            //ArrayList arl1 = new ArrayList();
            //List<string> l1 = new List<string>();
            // Có thể khởi tạo 1 collection từ 1 collection có sẵn
            // Các phương thức cơ bản đối với Collection
            // 1. Thêm mới 
            //arl1.Add(1); // thêm 1 số int
            //arl1.Add("abc"); // thêm 1 chuối
            //arl1.Add(new int[] {1,2,3}); // thêm 1 mảng
            //------------
            //l1.Add("abc"); l1.Add("xyz"); l1.Add("a");
            // Không thể thêm được một giá trị không phải string
            // List chỉ chấp nhận kiểu dữ liệu theo khai báo
            // 2. Sửa phần tử
            // Truy cập được đến phần tử đó thông qua index []
            // Thực hiện chỉnh sửa thuộc tính hoặc cả phần tử
            // 3. Xóa phần tử
            // Bước 1. xác định đặc điểm của phần tử cần xóa
            // Bước 2 thực hiện việc xóa thông qua các hàm hỗ trợ
            // a. Remove(obj) xóa 1 đối tượng cụ thể nào đó
            //l1.Remove("abc");
            // b. RemoveAt(index): Xóa tại 1 vị trí cụ thể nào đó
            //l1.RemoveAt(5);
            // c. RemoveRange(collections) xóa 1 collection trong
            // 1 collection (Xóa 1 nhóm sv pass môn khỏi lớp)
            // d. RemoveAll(đặc điểm) xóa nhiều phần tử mang
            // đặc điểm nào đó
            // Hiển thị
            // In từng đối tượng
            CollectionServices services = new CollectionServices();
            //services.CreateNew().ShowInfor();
            services.AddNewStudent();
            Console.WriteLine("--------------");
            foreach (var s in services.Students) s.ShowInfor();
            //services.DeleteStudent();
            Console.WriteLine("--------------");
            services.SearchByCode();
        }
    }
}
