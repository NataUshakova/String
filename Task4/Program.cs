using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите текст:");
            string input = Console.ReadLine();
            //регулярное выражение
            Regex regex = new Regex(@"<[^>]+>|</[^>]+>\s");
            string replacement = "_";
            //в строке input замена вех совпаденией на replacement
            string result = regex.Replace(input, replacement);
            Console.WriteLine("Replacement String: {0}", result);
            Console.ReadKey();
        }
    }
}
