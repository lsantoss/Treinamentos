
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
            Console.WriteLine("===== Data e Hora DateTime.Now =====");
            DateTime dateNow = DateTime.Now;
            Console.WriteLine($"Data/Hora: {dateNow}");
            Console.WriteLine($"Dia      : {dateNow.Day}");
            Console.WriteLine($"Mês      : {dateNow.Month}");
            Console.WriteLine($"Ano      : {dateNow.Year}");
            Console.WriteLine($"Horas    : {dateNow.Hour}");
            Console.WriteLine($"Minutos  : {dateNow.Minute}");
            Console.WriteLine($"Segundos : {dateNow.Second}");

            Console.WriteLine();
            Console.WriteLine("===== Data e Hora DateTime.UtcNow =====");
            DateTime dateUtcNow = DateTime.UtcNow;
            Console.WriteLine($"Data/Hora: {dateUtcNow}");
            Console.WriteLine($"Dia      : {dateUtcNow.Day}");
            Console.WriteLine($"Mês      : {dateUtcNow.Month}");
            Console.WriteLine($"Ano      : {dateUtcNow.Year}");
            Console.WriteLine($"Horas    : {dateUtcNow.Hour}");
            Console.WriteLine($"Minutos  : {dateUtcNow.Minute}");
            Console.WriteLine($"Segundos : {dateUtcNow.Second}");

            Console.WriteLine();
            Console.WriteLine("===== Data e Hora DateTime.UtcNow =====");
            DateTime dateToday = DateTime.Today;
            Console.WriteLine($"Data/Hora: {dateToday}");
            Console.WriteLine($"Dia      : {dateToday.Day}");
            Console.WriteLine($"Mês      : {dateToday.Month}");
            Console.WriteLine($"Ano      : {dateToday.Year}");
            Console.WriteLine($"Horas    : {dateToday.Hour}");
            Console.WriteLine($"Minutos  : {dateToday.Minute}");
            Console.WriteLine($"Segundos : {dateToday.Second}");

            Console.WriteLine();
            Console.WriteLine("===== String para data ====");
            string dateString = "20/04/2020";
            DateTime dateConvert = Convert.ToDateTime(dateString);
            Console.WriteLine(dateString);
            Console.WriteLine(dateConvert);

            Console.ReadKey();
        }
    }
}