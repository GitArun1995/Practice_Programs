using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefletctionClassLibrary
{
    public class Class1
    {
        public int x;
        public int y;
        public int z;
        public string Name { get; set; }
        public int sum(int a, int b)
        {
            this.x = a;
            this.y = b;
            return z = x + y;
        }
        public int Mul(int a, int b) => a * b;
       
    }
}
