using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parola
{
    internal class parola
    {
        static void Main(string[] args)
        {
            Console.Write("Въведи едно цяло число=");
            var a = (Console.ReadLine());
            if (a=="qwerty")
            {
                Console.WriteLine("Правилно");
            }
            else
            {
                Console.WriteLine("Грешно");
            }
        }
    }
}
