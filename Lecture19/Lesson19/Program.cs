using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson19
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b1 = 1;
            int i1 = b1;
            Console.WriteLine(b1);
            Console.WriteLine(i1);

            //Casting
            int i2 = 1;
            byte b2 = (byte)i2;
            Console.WriteLine(i2);
            Console.WriteLine(b2);

            float f = 1.0f;
            int i = (int)f;
            Console.WriteLine(i);

            string s = "1";
            int i3 = Convert.ToInt32(s);
            int j = int.Parse(s);
            Console.WriteLine(i3);
            Console.WriteLine(j);


        }
    }
}
