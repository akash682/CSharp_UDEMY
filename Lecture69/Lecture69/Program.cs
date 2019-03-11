using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture69
{
    class Program
    {
        static void Main(string[] args)
        {
            //Procedure programming
            //divide into class and method 
            //Object-oriented Programming to つい

            //separate the function by block
            //

            Console.WriteLine("What's your name?!");
            var name = Console.ReadLine();
            var reversed = ReverseName(name);
            Console.WriteLine(reversed);
        }

        public static string ReverseName(string name)
        {
            var array = new char[name.Length];
            for (var i = name.Length; i > 0; i--)
                array[name.Length - i] = name[i - 1];

            var reversed = new string(array);
            return reversed;
        }
    }
}
