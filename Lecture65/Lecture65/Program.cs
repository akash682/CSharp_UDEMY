using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture65
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentence = "This is going to be really really really really long text";
            var summery = Stringmethod.SummerizeText(sentence, 25);
            Console.WriteLine(summery);
        }

        
    }
}
