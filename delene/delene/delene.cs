using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delene
{
    internal class delene
    {
        static void Main(string[] args)
        {
            Console.Write("Въведи едно цяло число=");
            int a=int.Parse(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("Числото е четно");
            }
            else
            {
                Console.WriteLine("Числото е нечетно");
            }

        }
    }
}
