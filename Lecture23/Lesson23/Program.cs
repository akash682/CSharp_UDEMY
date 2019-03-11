using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson23
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = 3;
            Console.WriteLine((float)a/b);

            var a1 = 1;
            var b1 = 2;
            var c1 = 3;
            Console.WriteLine((a1+b1)*c1);

            Console.WriteLine(a == b);
            Console.WriteLine(a>b);
            Console.WriteLine(a!=b);
            Console.WriteLine(c1 > b1 && c1== a1);
     
        }
    }
}
