using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture31
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3];

            //short
            var number = new int[3];

            numbers[0] = 1;

            Console.WriteLine(number[0]);
            Console.WriteLine(number[1]);
            Console.WriteLine(number[3]);

            //initialized to something corresponding to data type
            //int --> 0

            var flags = new bool[3];
            flags[0] = true;

            //initialized to false
            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);

            var names = new string[3] { "Jack", "John", "Mary" };
        }
    }
}
