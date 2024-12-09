using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace клюкарка
{
    internal class клюкарка
    {
        static void Main(string[] args)
        {
            Console.Write("Въведи едно име");
            var name = (Console.ReadLine());
            switch (name)
            {
                case "Р": Console.WriteLine("Вечно блее в час"); break;
                case "Х": Console.WriteLine("Клюкарка"); break;
                case "М":
                case "С":
                case "Н":
                case "К":
                case "Ю":
                case "х": Console.WriteLine("Само те слушат");break;
                default: Console.WriteLine("Няма други"); break;
            }
            
        }
    }
}
