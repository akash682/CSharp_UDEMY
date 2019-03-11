using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture53
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 3, 7, 9, 2, 14, 6 };

            //Length
            Console.WriteLine("Length" + numbers.Length);

            //IndexOf()
            var index = Array.IndexOf(numbers, 9);
            Console.WriteLine(index);

            //Clear()
            Console.WriteLine("Effect of Clear().");
            Array.Clear(numbers, 0, 2);
            foreach (var n in numbers)
                Console.WriteLine(n);

            //Copy()
            int[] another = new int[3];
            Array.Copy(numbers, another, 3);

            Console.WriteLine("Effect of Copy");
            foreach (var n in numbers)
                Console.WriteLine(n);

            //Reverse()
            Array.Reverse(numbers);
            Console.WriteLine("Effect of Reverse");
            foreach (var n in numbers)
                Console.WriteLine(n);



        }
    }
}