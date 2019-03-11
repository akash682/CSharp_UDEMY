using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson21
{
    class Program
    {
        static void Main(string[] args)
        {
            //Operater
            //Postfix a1 = 2, b1 =1
            int a1 = 1;
            int b1 = a1++;
            Console.WriteLine(a1);
            Console.WriteLine(b1);


            //Prefix a2 =2 , b2=2
            int a2 = 1;
            int b2 = ++a2;
            Console.WriteLine(a2);
            Console.WriteLine(b2);

            //Assignment Operators
            int s = 1;
            s += 2;
            Console.WriteLine(s);

            //Logical Operators
            //&& and || or  ! not

            //Bitwise operator
            //& and | or


        }
    }
}
