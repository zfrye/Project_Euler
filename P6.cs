using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class P6
    {
        //Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
        public static void Run()
        {
            Console.WriteLine("Problem 6:");
            int numbers = 100;
            double sumOS = 0;
            double squareOS = 0;

            for (int i =1; i <=numbers; i++)
            {
                sumOS = sumOS + (i * i);
                squareOS = squareOS + i;
            }
            squareOS = Math.Pow(squareOS, 2);
            Console.WriteLine("sumOS: " + (sumOS));
            Console.WriteLine("squareOS: " + (squareOS));
            Console.WriteLine("difference: " + (squareOS - sumOS));

            
            
        }
    }
}


//Store of base class
/*
 * public static void Run()
        {
            Console.WriteLine("Problem 6:");



            Console.WriteLine($"-1 to exit");
            int userIn = 0;
            while (userIn != -1)
            {

            }


        }
*/
