using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class P1
    {
        //Find the sum of all the multiples of 3 or 5 below 1000.
        public static void Run()
        {
            Console.WriteLine("Problem 1:");
            int userIn = 0;
            Console.WriteLine("Enter a number:");
            userIn = Convert.ToInt32(Console.ReadLine());
            int finalSum = MultNum(userIn);
            Console.WriteLine($"Sum: {finalSum}");
        }

        private static int MultNum(int userIn)
        {
            int sum = 0;
            int three = userIn / 3;
            int five = userIn / 5;
            if (three * 3 == userIn)
            {
                three--;
            }
            if (five * 5 == userIn)
            {
                five--;
            }
            int temp = 0;

            //Console.WriteLine($"Three {three}");
            //Console.WriteLine($"Five {five}");

            for ( int i = 0; i <= three; i++ )
            {
                temp = i * 3;
                //Console.WriteLine($"temp {temp}");
                if (temp % 5 != 0)
                {
                    sum = sum + temp;
                    //Console.WriteLine($"+3 {sum}");
                }
            }
            for (int i = 1; i <= five; i++)
            {
                temp = i * 5;
                //Console.WriteLine($"temp {temp}");
                sum = sum + temp;
                //Console.WriteLine($"+5 {sum}");
            }

            return sum;
        }
    }
}
