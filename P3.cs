using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class P3
    {
        //What is the largest prime factor of the number 600851475143 ?
        public static void Run()
        {
            Console.WriteLine("Problem 3:");
            long prime = 600851475143;
            Console.WriteLine($"Answer: {DividePrime(prime)}");
        }

        private static string DividePrime(long toPrime)
        {
            long top = toPrime;
            long prime = toPrime;
            int factor = 2;
            string toWrite = "";
            int[] numStore = new int[0];
            long toTest = MultArray(numStore);
            while ( toTest != top)
            {
                if (prime % factor == 0)
                {
                    numStore = AddToIntArray(numStore, factor);
                    prime = prime / factor;
                }
                factor++;
                toTest = MultArray(numStore);
            }

            for(int i = 0; i < numStore.Length; i++)
            {
                toWrite = toWrite + $"{numStore[i]}, ";
            }
            return toWrite;
        }

        private static int[] AddToIntArray(int[] old, int toAdd)
        {
            int[] notOld = new int[old.Length + 1];

            for(int i = 0; i < old.Length; i++)
            {
                notOld[i] = old[i];
            }
            notOld[notOld.Length - 1] = toAdd;

            return notOld;
        }

        private static long MultArray(int[] toMult)
        {
            long total = 1;
            for (int i = 0; i < toMult.Length; i++)
            {
                total = total * toMult[i];
            }
            return total;
        }
    }
}
