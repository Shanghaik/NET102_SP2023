using System;
using System.Collections.Generic;
using System.Text;

namespace LAB123_Demo
{
    internal class Services
    {
        public static void Bai1()
        {
            Console.WriteLine("Nhập số lượng Phần tử");
            int size = int.Parse(Console.ReadLine());
            //int size2 = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size]; int i = 1;
            while(size-- >= 1)// Check xong tự trừ size
            {
                Console.WriteLine("Nhập phần tử thứ "+ i++);
                arr[size] = int.Parse(Console.ReadLine());
            }
            // Sắp xếp
            Console.WriteLine("Mảng sau khi đã sắp xếp là: ");
            //Array.Sort(arr); // Dùng method có sẵn
            // Dùng sắp xếp nổi bọt
            int temp = 0;
            for (int j = 0; j < arr.Length-1; j++)
            {
                for (int k = j+1; k < arr.Length; k++)
                {
                    if (arr[j] < arr[k])// Swap giá trị khi sau > trước
                    {
                        temp = arr[j];
                        arr[j] = arr[k];
                        arr[k] = temp;
                    }
                }
            }
            //In ra mảng đã sắp xếp
            Console.WriteLine(String.Join(", ", arr)); // In trên 1 dòng
        }
    }
}
