using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace календар
{
    internal class календар
    {
        static void Main(string[] args)
        {
            Console.Write("Въведи един месец");
            var mesec=(Console.ReadLine());
            var dni=int.Parse(Console.ReadLine());
            switch (mesec)
            {
                case "1":
                case "2":
                case "12": Console.WriteLine("Зима"); break;
                //case "3": if (dni< 29) { Console.WriteLine("Високосна година") } 
                //    else { Console.WriteLine("Невисокосна година"); } ;
                case "4":
                case "5": Console.WriteLine("Пролет"); break;
                case "6":
                case "7":
                case "8": Console.WriteLine("Лято"); break;
                case "9":
                case "10":
                case "11": Console.WriteLine("Есен"); break;
                default: Console.WriteLine("Няма такъв месец"); break;

            }
        }
    }
}
