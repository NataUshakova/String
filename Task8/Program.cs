using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "";
            StringBuilder sb = new StringBuilder();
            int N = 100;

            //Измерение времени выполнения сложения строк классом String
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            for (int i = 0; i < N; i++)
            {
                str += "*";
            }
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            long ticks = ts.Ticks;
            Console.WriteLine("Время выполнения string = {0} миллисекунд", ts.TotalMilliseconds);

            //Измерение времени выполнения сложения строк классом StringBuilder
            Stopwatch stopWatch2 = new Stopwatch();
            stopWatch2.Start();
            for (int i = 0; i < N; i++)
            {
                sb.Append("*");
            }
            stopWatch2.Stop();
            TimeSpan ts2 = stopWatch2.Elapsed;
            Console.WriteLine("Время выполнения StringBuilder = {0} миллисекунд", ts2.TotalMilliseconds);
            
            Console.WriteLine("Класс StringBuilder выполнил {0} итераций сложения строк на {1} миллисекунд "
                + "быстрее класса String", N, ts.TotalMilliseconds - ts2.TotalMilliseconds);
            Console.ReadKey();
        }
    }
}
