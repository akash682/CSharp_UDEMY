using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture43_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the width");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the height");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
                Console.WriteLine("Its landscape");
            else
                Console.WriteLine("Its portrait");
        }
    }
}
