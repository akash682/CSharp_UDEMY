using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture56
{
    class Program
    {
        static void Main(string[] args)
        {

            //.1
            var likename = new List<string>();

            while (true)
            {
                Console.WriteLine("Enter the name. Otherwise enter");
                var input2 = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(input2))
                {
                    break;
                }
                else
                {
                    likename.Add(input2);
                }
            }

            if (likename.Count() == 1)
            {
                Console.WriteLine(likename[0] + "likes your post");
            }
            else if (likename.Count() == 2)
            {
                Console.WriteLine(likename[0] + " and " + likename[1] + "like your post");
            }
            else
            {
                Console.WriteLine(likename[0] + " and " + likename[1] + " and " + (likename.Count - 2) + " others like your post");
            }

            //2.
            Console.WriteLine("Enter the name. I'll reverse it for you.");

            string input = Console.ReadLine();
            var arr = new char[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                arr[i] = input[(input.Length - 1) - i];
            }
            var reversed = new string(arr);
            Console.WriteLine("Reversed: " + reversed);

            //3.
            Console.WriteLine("Enter five number");
            var number = new List<int>();
            while (true)
            {
                Console.WriteLine("Enter a number");
                int input1 = Convert.ToInt32(Console.ReadLine());

                if (number.Contains(input1))
                {
                    Console.WriteLine("Same number.");
                    continue;
                }
                else
                {
                    Console.WriteLine("Added" + input1 + "to an array");
                    number.Add(input1);
                }

                if (number.Count() == 5)
                {
                    Console.WriteLine("Got 5 numbers.");
                    break;
                }
            }

            foreach (int numbers in number)
            {
                Console.WriteLine(numbers);
            }

            //4.
            var number4 = new List<int>();
            while (true)
            {

                Console.WriteLine("Enter numbers one by one");
                var input4 = Console.ReadLine();

                if (input4 == "Quit")
                    break;
                else
                    number4.Add(Convert.ToInt32(input4));
            }

            foreach (int number1 in number4)
                Console.WriteLine(number1);

            //5.
            var number5 = new List<int>();
            string[] elements;

            while (true){
                Console.WriteLine("Supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10)");
                var str = Console.ReadLine();
                elements = str.Split(',');
                if (elements.Length < 5)
                {
                    Console.WriteLine("Invalid number");
                    continue;
                }
                else
                {
                    break;
                }
                
            }
            foreach (string q in elements)
                number5.Add(Convert.ToInt32(q));

            
            int i = 0;
            while (i != 2) {
                int min1 = +9999999;
                foreach (int p in number5)
                {
                    if (p < min1)
                    {
                        min1 = p;
                    }
                    else
                    {
                        continue;
                    }
                }
                Console.WriteLine(min1);
                number5.Remove(min1);
                i++;
            }




        }

    }
}

