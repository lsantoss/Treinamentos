using System;

namespace _36DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("===== Construtores =====");
            DateTime data0 = new DateTime();
            DateTime data1 = new DateTime(2008, 5, 1, 8, 30, 52);
            Console.WriteLine(data0);
            Console.WriteLine(data1);

            Console.WriteLine();
            Console.WriteLine("===== DateTime.Now =====");
            DateTime dateAgora = DateTime.Now;
            Console.WriteLine($"Data/Hora: {dateAgora}");
            Console.WriteLine($"Dia      : {dateAgora.Day}");
            Console.WriteLine($"Mês      : {dateAgora.Month}");
            Console.WriteLine($"Ano      : {dateAgora.Year}");
            Console.WriteLine($"Horas    : {dateAgora.Hour}");
            Console.WriteLine($"Minutos  : {dateAgora.Minute}");
            Console.WriteLine($"Segundos : {dateAgora.Second}");

            Console.WriteLine();
            Console.WriteLine("===== DateTime.UtcNow =====");
            DateTime dateUtcAgora = DateTime.UtcNow;
            Console.WriteLine($"Data/Hora: {dateUtcAgora}");
            Console.WriteLine($"Dia      : {dateUtcAgora.Day}");
            Console.WriteLine($"Mês      : {dateUtcAgora.Month}");
            Console.WriteLine($"Ano      : {dateUtcAgora.Year}");
            Console.WriteLine($"Horas    : {dateUtcAgora.Hour}");
            Console.WriteLine($"Minutos  : {dateUtcAgora.Minute}");
            Console.WriteLine($"Segundos : {dateUtcAgora.Second}");

            Console.WriteLine();
            Console.WriteLine("===== DateTime.Today =====");
            DateTime dateToday = DateTime.Today;
            Console.WriteLine($"Data/Hora: {dateToday}");
            Console.WriteLine($"Dia      : {dateToday.Day}");
            Console.WriteLine($"Mês      : {dateToday.Month}");
            Console.WriteLine($"Ano      : {dateToday.Year}");
            Console.WriteLine($"Horas    : {dateToday.Hour}");
            Console.WriteLine($"Minutos  : {dateToday.Minute}");
            Console.WriteLine($"Segundos : {dateToday.Second}");

            Console.WriteLine();
            Console.WriteLine("===== String para data =====");
            string dateString = "20/04/2020";
            DateTime dateConvert = Convert.ToDateTime(dateString);
            Console.WriteLine(dateString);
            Console.WriteLine(dateConvert);

            Console.ReadKey();
        }
    }
}