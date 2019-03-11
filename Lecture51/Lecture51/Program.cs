using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture51
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array
            //Types
            //Array method
            //Fixed number of variable with particular types
            //single dimentional , multidimentional
            //multidimentional--> Rectangular, Jagged
            //faster in Jagged array
            var matrix = new int[3, 5];

            var matrix2 = new int[3, 5]
            {
                {1,2,3,4,5},
                {6,7,8,9,10},
                {11,12,13,14,15}
            };

            var element = matrix[0, 0];

            var colors = new int[3, 5, 4];

            //Jagged array --> array of array
            var array = new int[3][];

            array[0] = new int[4];
            array[1] = new int[5];
            array[2] = new int[3];
        }
    }
}
