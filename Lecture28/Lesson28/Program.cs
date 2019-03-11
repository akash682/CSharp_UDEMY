using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson28.Math;
using Lesson28;

namespace Lesson28
{
    class Program
    {
        static void Main(string[] args)
        {
            Person john = new Person();
            john.FirstName = "John";
            john.LastName = "Lohani";

            john.Introduce();

            Calculator calculator = new Calculator();
            var result = calculator.Add(1, 2);
            Console.WriteLine(result);
        }
    }
}
