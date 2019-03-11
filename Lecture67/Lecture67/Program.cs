using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture67
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new StringBuilder();
            builder.Append('-', 10);
            Console.WriteLine(builder);

            builder.AppendLine();
            builder.Append("Header");
            builder.AppendLine();
            builder.Append('-', 10);
            Console.WriteLine(builder);

            builder.Replace('-', '/');
            Console.WriteLine(builder);

            builder.Remove(0, 10);
            Console.WriteLine(builder);

            builder.Insert(0, new string('-', 10));

            Console.WriteLine(builder);

            Console.WriteLine(builder[0]);


            builder
                .Append('-', 10)
                .AppendLine()
                .Append("Header")
                .AppendLine()
                .Append('-', 10);
        }
    }
}
