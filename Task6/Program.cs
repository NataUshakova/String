using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число:");
            string input = Console.ReadLine();

            //регулярное выражение для научной нотации
            string pattern = @"^\-?\d.\d+e\-?\d+$";
            Regex regex = new Regex(pattern);

            //регулярное выражение для обычной нотации
            string pattern2 = @"^\-?\d+$";
            Regex regexNumber = new Regex(pattern2);

            if (regex.IsMatch(input))
            {
                Console.WriteLine("Это число в научной нотации");
            }
            else if (regexNumber.IsMatch(input))
            {
                Console.WriteLine("Это число в обычной нотации");
            }
            else
            {
                Console.WriteLine("Это не число");
            }
            Console.ReadKey();
        }
    }
}
