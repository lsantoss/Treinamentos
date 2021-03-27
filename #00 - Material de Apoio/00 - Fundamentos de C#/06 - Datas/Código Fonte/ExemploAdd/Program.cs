using System;

namespace ExemploAdd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            DateTime date1 = DateTime.Now;
            TimeSpan timeSpan = new TimeSpan(1, 2 , 3);

            Console.WriteLine("====== Data não modificada ======");
            Console.WriteLine(date1);
            Console.WriteLine();

            Console.WriteLine("====== Data com valores alterados ======");
            Console.WriteLine(date1.Add(timeSpan));
            Console.WriteLine();
            Console.WriteLine(date1.AddDays(1));
            Console.WriteLine();
            Console.WriteLine(date1.AddMonths(1));
            Console.WriteLine();
            Console.WriteLine(date1.AddYears(1));
            Console.WriteLine();
            Console.WriteLine(date1.AddHours(1));
            Console.WriteLine();
            Console.WriteLine(date1.AddMinutes(1));
            Console.WriteLine();
            Console.WriteLine(date1.AddSeconds(1));
            Console.WriteLine();
            Console.WriteLine(date1.AddMilliseconds(1));
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
