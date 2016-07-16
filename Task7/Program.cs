using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите текст:");
            string input = Console.ReadLine();
            //регулярное выражение
            string pattern = @" (([0,1]?[0-9])|(2[0-3])):[0-5][0-9]";
            int count = new Regex(pattern).Matches(input).Count;
            Console.WriteLine("Время в тексте присутствует {0} раз(а).", count);
            Console.ReadKey();
        }
    }
}
