using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture47
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = 0;
            while (i <= 10)
            {
                if(i%2 == 0)
                    Console.WriteLine(i);

                i++;
            }

            //when we don't know how many times we want to perform

            while (true)
            {
                Console.Write("Type your name:");
                var input = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(input))
                    continue;

                Console.WriteLine("@Echo:" + input);
                break;
            }


        }
    }
}
