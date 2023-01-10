using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    internal class Student
    {
        public string StudentCode { get; set; } // mã
        public string StudentName { get; set; } // tên
        public double StudentGrade { get; set; } // Điểm
        public DateTime DoB { get; set; } // Ngày sinh
        public Student()
        {

        }
        public Student(string studentCode, string studentName, double studentGrade, DateTime doB)
        {
            StudentCode = studentCode;
            StudentName = studentName;
            StudentGrade = studentGrade;
            DoB = doB;
        }
        public void ShowInfor()
        {
            Console.WriteLine($"Name: {StudentName}, Code: {StudentCode}, Grade: {StudentGrade}, Birth: {DoB}");
        }
    }
}
