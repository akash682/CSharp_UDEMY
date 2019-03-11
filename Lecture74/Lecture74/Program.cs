using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lecture74
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory(@"c:\temp\folder1");

            var files = Directory.GetFiles(@"c:\projects\CSharpFundamentals", "*.sln", SearchOption.AllDirectories);
            foreach (var file in files )
                Console.WriteLine(file);
            var directories = Directory.GetDirectories(@"c:\projects\CSharpFundaments", "*.*", SearchOption.AllDirectories);
            foreach(var directory in directories)
            {
                Console.WriteLine(directory);
            }

            Directory.Exists("...");

            var directoryInfo = new DirectoryInfo("...");
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();
            
        }
    }
}
