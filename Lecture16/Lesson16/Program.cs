using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16
{
    class Program{
        static void Main(string[] args){
            checked{
                byte number = 255;
                number = (byte)(number + 1); //0
                Console.WriteLine(number);
            }
        }
    }
}
