using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture64
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Akash Lohani";
            Console.WriteLine("Trim: '{0}'", fullName.Trim());
            Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper());

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine("FirstName; " + firstName);
            Console.WriteLine("LastName: " + lastName);

            var names = fullName.Split(' ');
            Console.WriteLine("FirstName: " + names[0]);
            Console.WriteLine("LastNmae: " + names[1]);

            Console.WriteLine(fullName.Replace("Mosh", "Moshfegh"));
            
            if(String.IsNullOrEmpty(null))
                Console.WriteLine("Invalid");

            if (String.IsNullOrEmpty(" ".Trim()))
                Console.WriteLine("Invalid");

            if(String.IsNullOrWhiteSpace(" "))
                Console.WriteLine("Invalid");

            var str = "25";
            int i = Convert.ToByte(str);
            Console.WriteLine(i);

            float price = 29.95f;
            string currency = price.ToString("C");
            Console.WriteLine(currency);
        }
    }
}
