using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите текст:");
            string input = Console.ReadLine();
            //результирующая строка
            string strOut = "";
            Regex regex = new Regex(@"(0[1-9]|1[0-9]|2[0-9]|3[01])-(0[1-9]|1[012])-[0-9]{4}");
            Match match = regex.Match(input);

            //добавление совпадений в строку strOut
            while (match.Success)
            {
                strOut += '\n' + match.Value;
                match = match.NextMatch();
            }
            Console.WriteLine("В исходной строке присутсвуют даты: {0}", strOut);
            Console.ReadKey();
        }
    }
}
