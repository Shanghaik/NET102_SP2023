using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    internal class NewList<T> // Class Generic sử dụng kiểu dữ liệu T bất kì
    {
        T[] data; // List không dùng mảng, cái này chỉ là mô phỏng

        public T[] Data { get => data; set => data = value; }
        public NewList() { data = new T[0]; }
        public NewList(T[] data) { this.data = data; }
        public void Add(T item) // Thêm 1 phần tử vào list
        {
            if (data.Length > 0) {  
            // Bước 1: Tạo 1 mảng mới dài hơn mảng cũ 1 vị trí
            T[] newdata = new T[data.Length + 1];
            // Bước 2: Gán giá trị của mảng cũ cho mảng mới
            for (int i = 0; i < data.Length; i++)
            {
                newdata[i] = data[i];
            }
            // Bước 3: Thêm giá trị mới vào cuối của newdata
            newdata[newdata.Length - 1] = item;
            // Bước 4: Gán lại giá trị newdata cho data
            data = newdata;
            } else data = new T[]{ item };
        }
        public void Show()
        {
            Console.WriteLine(string.Join(" ", data));
        }
    }
}
