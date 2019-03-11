using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture43_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your speed");
            int speed = Convert.ToInt32(Console.ReadLine());
            int speed_limit = 60;
            float demerit = 0;

            if (speed < 60)
                Console.WriteLine("OK");
            else
                demerit = (speed-speed_limit) / 5;
                Console.WriteLine(demerit);


        }
    }
}
