using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture49
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.
            int j= 0;
            for(int i=1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    j++;
                }
            }

            Console.WriteLine(j);

            //2.
            int number = 0;

            while (true)
            {
                Console.WriteLine("Enter any number or enter OK to exit.");
                String input1 = Console.ReadLine();

                if (input1 == "ok")
                    break;

                number += Convert.ToInt32(input1);
            }

            Console.WriteLine(number);

            //3.
            Console.WriteLine("Enter any number. I'll calculate the factorial.");
            int num = Convert.ToInt32(Console.ReadLine());
            int factorial = 1;

            for (int i = num; i>=1; i--)
            {
                factorial = factorial * i;
            }

            Console.WriteLine(factorial);

            //4.
            var random = new Random();
            number = random.Next(1, 10);
            Console.WriteLine("Guess the number");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(number);
            if(input == number)
                Console.WriteLine("You won!");
            else
                Console.WriteLine("You lose!");

            //5.
            Console.WriteLine("Enter number array separated by comma. Example 5,3,8,4");
            String str = Console.ReadLine();
            int max = -9999999;

            foreach(var nac in str)
            {
                if (nac == ',')
                {
                    continue;
                }
                else
                {
                    if (max < Convert.ToInt32(nac))
                        max = Convert.ToInt32(nac);
                    else
                        continue;
                }
                    
            }

            Console.WriteLine(max);








        }

    }
}
