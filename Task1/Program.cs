using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //количество символов в строке 
            int countChar = 0;
            Console.Write("Введите текст:");
            string input = Console.ReadLine();
            //массив подстрок, получившихся из исходной с помощью заданных разделетилей
            string[] splitted = input.Split(new[] { ' ', '-', '.', '?', '!', ')', '(', ',', ':' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string spl in splitted)
            {
                spl.Replace(" ", string.Empty);
                countChar += spl.Length;
            }
            Console.Write("Средняя длина слова во введенной строке = {0}", countChar / splitted.Length);
            Console.ReadLine();
        }
    }
}
