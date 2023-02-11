using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    internal partial class ClassA
    {
        public ClassA()
        {
        }
        public ClassA(int tuoi, string ten)
        {
            Tuoi = tuoi;
            Ten = ten;
        }
        public void ABC()
        {
            Console.WriteLine("abc");
        }
    }
}
