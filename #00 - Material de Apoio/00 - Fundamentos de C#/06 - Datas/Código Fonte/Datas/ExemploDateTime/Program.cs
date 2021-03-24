
using System;

namespace ExemploDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("===== Invocando construtores ====");
            DateTime date1 = new DateTime(2008, 5, 1, 8, 30, 52);
            Console.WriteLine(date1);
                       
            Console.WriteLine();
            DateTime date2 = new DateTime(); // 01/01/0001 00:00:00.
            Console.WriteLine(date2);

            Console.WriteLine();
            Console.WriteLine("===== Data e Hora atual =====");
            DateTime dateNow = DateTime.Now;
            Console.WriteLine($"Data/Hora: {dateNow}");
            Console.WriteLine($"Dia      : {dateNow.Day}");
            Console.WriteLine($"Mês      : {dateNow.Month}");
            Console.WriteLine($"Ano      : {dateNow.Year}");
            Console.WriteLine($"Horas    : {dateNow.Hour}");
            Console.WriteLine($"Minutos  : {dateNow.Minute}");
            Console.WriteLine($"Segundos : {dateNow.Second}");

            Console.ReadKey();
        }
    }
}