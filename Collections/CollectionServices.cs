using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Collections
{
    internal class CollectionServices
    {
        List<Student> students;
        public CollectionServices()
        {
            Students = new List<Student>();// Tạo luôn 1 list trong constructor không ts
        }
        internal List<Student> Students { get => students; set => students = value; }
        // Các phương thức
        //1. Thêm phần tử vào List
        // Tạo student
        public Student CreateNew()
        {
            Student st = new Student(); // Tạo mới 1 sinh viên
            Console.WriteLine("Nhập thông tin của sinh viên: ");
            Console.WriteLine("Nhập tên: ");
            st.StudentName = Console.ReadLine();
            Console.WriteLine("Nhập mã: ");
            st.StudentCode = Console.ReadLine();
            Console.WriteLine("Nhập điểm: ");
            st.StudentGrade = Double.Parse(Console.ReadLine());
            //Console.WriteLine("Nhập ngày sinh: ");
            st.DoB = DateTime.Now;//DateTime.Parse(Console.ReadLine());
            return st; // Trả về sinh viên vừa nhập
        }
        public void AddNewStudent() // Thêm mới một sinh viên
        {
            Student student = CreateNew(); // yêu cầu nhập 1 SV
            students.Add(student); // Thêm SV vừa được nhập vào trong List
            string continues = "";
            Console.WriteLine("Bạn có mún nhập tiếp ko? Y/N");
            continues = Console.ReadLine();
            if (continues == "Y") AddNewStudent(); // gọi lại để nhập tiếp
        }
        // Sửa một sv
        public void UpdateStudent()
        // Sửa tên của tất cả SV mà tên có chứa chữ a/A sang chữ in Hoa
        {
            foreach (var student in students)
            { // từ khóa var xác định biến có thể nhận mọi kiểu dữ liệu
                if (student.StudentName.ToLower().Contains("a"))
                {// Gán lại giá trị cho tên
                    student.StudentName = student.StudentName.ToUpper();
                }
            }
        }
        public void DeleteStudent()
        {// Xóa tất cả sinh viên mà điểm <= 3
            //foreach (var item in students.ToList())
            //{
            //    if (item.StudentGrade <= 3) students.Remove(item);
            //}
            // Dùng for thuần
            //for (int i = 0; i < students.Count; i++)
            //{
            //    if (students[i].StudentGrade <= 3)
            //    {
            //        students.RemoveAt(i); i--;
            //    }
            //}
            // Dùng Linq - lambda expression
            students.RemoveAll(student => student.StudentGrade <=3);
        }

        public void SearchByCode()
        {
            Console.WriteLine("Nhập mã SV");
            string ma = Console.ReadLine();
            //Tìm kiếm và hiển thị những sinh viên mà Mã có chứa từ mà mình vừa nhập
            foreach (var item in students)
            {
                if (item.StudentCode.Contains(ma)) item.ShowInfor();
            }
        }
    }
}
