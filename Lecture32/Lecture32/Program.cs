using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture32
{
    class Program
    {
        static void Main(string[] args)
        {
            String firstName = "Akash";
            String lastName = "Lohani";

            //String is collection of character
            string name = firstName + " "  + lastName;

            //directly accesible
            string name1 = string.Format("{0} {1}", firstName, lastName);

            //creating Strings
            var numbers = new int[3] { 1, 2, 3, };
            string list = string.Join(",", numbers);

            Console.WriteLine(list[0]);

            string name2 = "Mosh";
            char firstChar = name2[0];
            //name2[0]  = "m"; // immutable 

            //\n: new line \t:tab \\:backslash \':single quotation \":double quotation
            string path = "c:\\projects\\project1\\folder1";
            string path1 = @"c:\projects\project1\folder1";
        }
    }
}
