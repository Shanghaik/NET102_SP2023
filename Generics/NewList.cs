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
        }
        public void Show()
        {
            Console.WriteLine(string.Join(" ", data));
        }
        // Viết hàm tương tự RemoveAt của List
        public void RemoveAt(int index)
        {
            // Bước 1: Tạo 1 mảng mới ngắn hơn mảng cũ 1 vị trí
            T[] newdata = new T[data.Length - 1];
            // Bước 2: Gán giá trị của mảng cũ cho mảng mới ngoại trừ
            // vị trí cần xóa
            int j = 0;
            for (int i = 0; i < data.Length; i++)
            {
                if (i == index) continue;
                newdata[j] = data[i];
                j++;
            }
            // Bước 3: Gán lại giá trị newdata cho data
            data = newdata;
        }
        // Viết thêm các phương thức AddRange - thêm 1 loạt
        // Remove(T item) - xóa giá trị cụ thể
        // IndexOf(T item) - vị trí đầu tiên mà item xuất hiện
        // LastIndexOf(T item) - vị trí cuối cùng mà item xuất hiện
    }
}
