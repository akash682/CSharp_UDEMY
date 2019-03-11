using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture43_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
                Console.WriteLine(string.Format("{0} is bigger.", a));
            else
                Console.WriteLine(string.Format("{0} is bigger.", b));
        }
    }
}
