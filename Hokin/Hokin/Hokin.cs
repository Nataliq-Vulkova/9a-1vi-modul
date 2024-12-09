using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Hokin
{
    internal class Hokin
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            Console.Write("Въведи знак +,-,*,/");
            var c = (Console.ReadLine());
            switch (c)
            {
                case "+": Console.WriteLine("a+b=" + (a + b)); break;
                case "-": Console.WriteLine("a-b=" + (a - b)); break;
                case "*": Console.WriteLine("a*b=" + (a * b)); break;
                case "/": Console.WriteLine("a/b=" + (a / b)); break;
            }
        }
    }
}
