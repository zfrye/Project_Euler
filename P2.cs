using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class P2
    {
        //By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.
        public static void Run()
        {
            Console.WriteLine("Problem 2:");
            long num1, num2, temp, sum;
            num1 = 1;
            num2 = 2;
            sum = 2;
            long trac = 0;
            while(num1<=4000000 && num2 <= 4000000)
            {
                trac = trac+1;
                temp = num1 + num2;
                if(temp % 2 == 0)
                {
                    sum = sum + temp;
                }
                if (num1 < num2)
                {
                    num1 = temp;
                }
                else
                {
                    num2 = temp;
                }
            }
            Console.WriteLine($"Sum: {sum}");
            
        }

    }
}
