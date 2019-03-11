using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture38
{
    public class Person
    {
        public int Age;
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Value type
            var number = 1;
            Increment(number);
            Console.WriteLine(number);

            //Reference Type
            var Person = new Person() { Age = 20 };
            MakeOld(Person);
            Console.WriteLine(Person.Age);
           
        }

        public static void Increment(int number)
        {
            number += 10;
            //何もせずに終了
        }

        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }
    }
}
