using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture33
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            var firstName = "Mosh";
            var lastName = "Lohani";

            //String, Int32 difference. .Net framework

            var fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);

            var myFullName = string.Format("My name is {0} {1}", firstName, lastName);
            Console.WriteLine(myFullName);

            var names = new string[3] { "John", "Jack", "Mary" };
            var formattedNames = string.Join(",", names);
            Console.WriteLine(formattedNames);

            var text = "Hi John\nLook into the following paths\nc:\\folder1\\folder2\n\nc:\\folder3\\folder4\n";
            var text1 = @"Hi John 
                Look into the following paths
                c:\folder1\folder2
                c:\folder3\folder4";

            Console.WriteLine(text);
            Console.WriteLine(text1);

        }
    }
}
