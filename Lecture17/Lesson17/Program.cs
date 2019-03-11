using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson17
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                //Cannot be accessed
                byte a = 1;
                {
                    byte b = 2;
                    {
                        byte c = 3;
                    }
                }
            }
        }
    }
}
