using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string FirstString = "";
            string SecondString = "";
            string FinalString = "";
            Console.WriteLine("Введи первую строку");
            FirstString = Console.ReadLine();
            Console.WriteLine("Введи вторую строку");
            SecondString = Console.ReadLine();
            //для каждого символа из FirstString
            foreach (char ch in FirstString)
                //если во второй строке нет данного символа
                if (!SecondString.Contains(ch))
                    FinalString += ch;
                else
                {
                    FinalString += ch;
                    FinalString += ch;
                }
            Console.WriteLine("Результат = {0}", FinalString);
            Console.ReadKey();
        }
    }
}
