using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lecture75
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Projects\CSharpFundamentals\HelloWorld\HelloWorld.sln";

            var dotIndex = path.IndexOf('.');
            var extention = path.Substring(dotIndex);

            Console.WriteLine("Extention: " + Path.GetExtension(path));
            Console.WriteLine("File name: " + Path.GetFileName(path));
            Console.WriteLine("File Name without Extension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("Directory Name: " + Path.GetDirectoryName(path));
        }
    }
}
