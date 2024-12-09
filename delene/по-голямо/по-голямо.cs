using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace по_голямо
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведи едно цяло число");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Въведи едно цяло число");
            int b = int.Parse(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("Max e" + a);
                Console.WriteLine("Min e" + b);
            } 
            else {
                Console.WriteLine("Min e" + a);
                Console.WriteLine("Max e" + b);
            }

        }
    }
}
