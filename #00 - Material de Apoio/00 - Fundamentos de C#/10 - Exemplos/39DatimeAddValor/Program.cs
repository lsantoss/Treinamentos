using System;

namespace _39DatimeAddValor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            DateTime data = DateTime.Now;
            TimeSpan timeSpan = new TimeSpan(1, 2, 3);

            Console.WriteLine("====== Data original ======");
            Console.WriteLine(data);
            Console.WriteLine();

            Console.WriteLine("====== Adicionando valores ======");
            Console.WriteLine(data.Add(timeSpan));
            Console.WriteLine();
            Console.WriteLine(data.AddDays(1));
            Console.WriteLine();
            Console.WriteLine(data.AddMonths(1));
            Console.WriteLine();
            Console.WriteLine(data.AddYears(1));
            Console.WriteLine();
            Console.WriteLine(data.AddHours(1));
            Console.WriteLine();
            Console.WriteLine(data.AddMinutes(1));
            Console.WriteLine();
            Console.WriteLine(data.AddSeconds(1));
            Console.WriteLine();
            Console.WriteLine(data.AddMilliseconds(1));
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}