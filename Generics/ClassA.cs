using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    // partial class là một phương pháp lập trình cho phép tách class
    // ra trên nhiều file vật lý (file .cs), cần phân biệt file vật lý
    // và class để tránh nhầm lần
    // Partial class là cách thức hữu hiệu để có thể làm việc nhóm
    // khi mà có thể chia tách công việc ra rõ ràng
    internal partial class ClassA
    {
        int tuoi;
        string ten;
        public int Tuoi { get => tuoi; set => tuoi = value; }
        public string Ten { get => ten; set => ten = value; }
    }

}
