using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class P7
    {

        public static void Run()
        {
            int prime = 2;
            for(int i =1; i <= 10001;)
            {
                if (isPrime(prime))
                {
                    if(i == 10001)
                    {
                        Console.WriteLine("Prime " + i + ": " + prime);
                    }
                    i++;
                }
                prime++;
            }
        }

        private static bool isPrime(int input)
        {
            int n = input;

            for (int i =2; i <= n / 2; i++)
            {
                if(n%i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
