using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class P8
    {
        private static string toTest = "5073167176531330624919225119674426574742355349194934969835203127745063262395783" +
                    "18016984801869478851843858615607891129494954595017379583319528532088055111254069874715852386305071" +
                    "569329096329522744304355766896648950445244523161731856403098711121722383113622298934233803081353362" +
                    "766142828064444866452387493035890729629049156044077239071381051585930796086670172427121883998797908" +
                    "792274921901699720888093776657273330010533678812202354218097512545405947522435258490771167055601360";
                    //"483958644670632441572215539753697817977846174064955149290862569321978468622482839722413756570560574"+
                    //"902614079729686524145351004748216637048440319989000889524345065854122758866688116427171479924442928"+
                    //"2308634656748139191231628245861786645835912456652947654568284891288314260769004224219022671055626321"+
                    //"1111093705442175069416589604080719840385096245544436298123098787992724428490918884580156166097919133" + 
                    //"87549920052406368991256071760605886116467109405077541002256983155200055935729725716362695618826704282524836008232575304207529634";
        private static int max = 0;

        public static void Run()
        {
            Queue<char> myQ = new Queue<char>(4);
            foreach(char c in toTest)
            {
                if(!(myQ.Count == 4))
                {
                    myQ.Enqueue(c);
                }
                else
                {
                    testForMax(myQ);
                    myQ.Dequeue();
                    myQ.Enqueue(c);

                }
            }
            Console.WriteLine("Max of Four Adjacent Digits is: " + max);
        }

        private static void testForMax(IEnumerable<char> myCol)
        {
            
            int temp = 1;

            foreach(int i in myCol)
            {
                temp = temp * int.Parse(i.ToString());
            }
            if(temp > max)
            {
                Console.WriteLine("found better:");
                foreach(var i in myCol)
                {
                    Console.WriteLine(i.ToString());
                }
                max = temp;
            }
        }
    }
}
