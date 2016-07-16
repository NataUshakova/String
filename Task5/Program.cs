using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            //результирующая строка
            string strOut = "\n";
            Console.Write("Введите текст:");
            string input = Console.ReadLine();
            //string input = "Иван: ivan@mail.ru, Петр: p_ivanov@mail.rol.ru";

            //регулярное выражение
            string pattern = @"(\d|[a-z])[\w.-_]*(\d|[a-z])@[a-z]{2,6}.((\d|[a-z])[\w-_]*(\d|[a-z]).[a-z]{2,3}|[a-z]{2,3})";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(input);

            StringBuilder outString = new StringBuilder(strOut);
            // добавление всех совпадений к результирующей строке
            while (match.Success)
            {
                outString = outString.AppendLine(match.Value);
                match = match.NextMatch();
            }
            strOut = outString.ToString();
            Console.WriteLine("Найденные адреса электронной почты:{0}", strOut);
            Console.ReadKey();
        }
    }
}
