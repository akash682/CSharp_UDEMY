using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson20
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            //byte b = i ; Cannot convert
            byte b = (byte)i;
            Console.WriteLine(b);

            int i2 = 1000;
            //byte b = i ; Cannot convert
            byte b1 = (byte)i2;
            Console.WriteLine(b1);//Overflow lost some byte

            var number = "1234";
            //int i = (int)number; Cannot cast string to int
            int ii = Convert.ToInt32(number);
            Console.WriteLine(ii);


            try
            {
                var number1 = "1234";
                //int i = (int)number; Cannot cast string to int
                int iii = Convert.ToByte(number);
                Console.WriteLine(ii);
            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be converted to a byte");
                
            }

            try
            {
                string str = "true";
                bool b11 = Convert.ToBoolean(str);
                Console.WriteLine(b11);
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }


        }
    }
}
