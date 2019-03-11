using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture43
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number between 1 to 10.");
            int number = Convert.ToInt32(Console.ReadLine());

            if(number >= 1 &&  number<=10)
                Console.WriteLine("Valid number");
            else
                Console.WriteLine("Invalid");
        }
    }
}
