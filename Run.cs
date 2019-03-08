using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Run
    {
        static void Main(string[] args)
        {
            int userIn = 0;
            while(userIn != -1)
            {
                Console.WriteLine("Please choose a problem to run.(e.g. '1', 2'");
                Console.WriteLine("-1 to exit");
                userIn = Convert.ToInt32(Console.ReadLine());
                switch (userIn)
                {
                    case 1:
                        P1.Run();
                        break;
                    case 2:
                        P2.Run();
                        break;
                    case 3:
                        P3.Run();
                        break;
                    case 4:
                        P4.Run();
                        break;
                    case 5:
                        P5.Run();
                        break;
                    case 6:
                        P6.Run();
                        break;
                    case 7:
                        P7.Run();
                        break;
                    // currently in debug:
                    //case 8:
                    //    P8.Run();
                    //    break;
                    default:
                        Console.WriteLine("Problem Not Found.");
                        break;

                }
                Console.WriteLine(" ");
                Console.WriteLine(" ");
            }
        }
    }
}
