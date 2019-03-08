using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class P4
    {
        //Find the largest palindrome made from the product of two 3-digit numbers.
        public static void Run()
        {
            Console.WriteLine("Problem 4:");
            int maxPalin = 0;
            int lower = 500;
            for (int i = 999; i >= lower; i--)
            {
                for (int k = i; k >= 100; k--)
                {
                    if(i*k > maxPalin && isPalin(i * k))
                    {
                        maxPalin = i * k;
                        lower = k+1;
                    }
                }
            }


            Console.WriteLine($"Max Palindrome is: {maxPalin}");
            
        }

        private static bool isPalin(int i)
        {
            string str = i.ToString();
            return str.SequenceEqual(str.Reverse());
        }
    }
}
