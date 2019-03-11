using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lecture42
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = 10;

            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("It is morning.");
            }
            else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("It's afternoon.");
            }
            else
            {
                Console.WriteLine("It's evening.");
            }


            //example
            bool isGoldCustomer = true;
            float price;
            if (isGoldCustomer)
                price = 19.95f;
            else
                price = 29.95f;

            //Shortcut
            float price1 = (isGoldCustomer) ? 19.95f : 29.95f;
            Console.WriteLine(price1);

            var season = Seasun.Autumn;

            switch(season)
            {
                case Seasun.Autumn:
                    Console.WriteLine("It's autumn and a beautiful season.");
                    break;

                case Seasun.Summer:
                    Console.WriteLine("We've got promotion");
                    break;

                default:
                    Console.WriteLine("I don't understand the season");
                    break;
            }

        }
    }
}
