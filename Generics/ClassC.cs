using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    internal class ClassC
    {
        readonly int x; // chỉ đọc
        string y;
        public int X { get => x; } // thuộc tính x, y sẽ chỉ có thể được đọc
        public string Y { get => y; }
        // Khi khỏi tạo đối tượng, giá trị của đối tượng sẽ không thể bị thay đổi
        // immutable là 1 đặc tính mà ở đó đối tượng không thể bị thay đổi
        // string
        // multable là khi đối tượng có thể thay đổi bình thường
        // 
    }
}
