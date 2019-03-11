using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson18
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 2; //Int32
            var count = 10; //Int32
            var totalPrice = 20.95f;//Single
            var character = 'A'; //Char
            var firstName = "Mosh";//String
            var isWorking = false; //Boolean

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);

            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);

            const float Pi = 3.14f;
            //Pi = 1; Cannot perform because it is constant


        }
    }
}
