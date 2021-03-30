using System;

namespace _41Timespan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==== Valor Padrão ====");
            TimeSpan timeSpan1 = new TimeSpan();
            Console.WriteLine(timeSpan1);
            Console.WriteLine(TimeSpan.Zero);

            Console.WriteLine();
            Console.WriteLine("==== Criando com valores ====");
            TimeSpan timeSpan2 = new TimeSpan(2, 14, 18);
            Console.WriteLine(timeSpan2);

            Console.WriteLine();
            Console.WriteLine("====== Diferença Datas ======");
            DateTime dataInicio = new DateTime(2010, 6, 12, 18, 32, 0);
            DateTime dataFim = new DateTime(2010, 6, 13, 22, 47, 0);
            TimeSpan tempoTotal = dataFim - dataInicio;
            Console.WriteLine(dataInicio);
            Console.WriteLine(dataFim);
            Console.WriteLine(tempoTotal);

            Console.WriteLine();
            Console.WriteLine("====== Diferença TimeSpan ======");
            TimeSpan horarioInicio = new TimeSpan(6 , 55, 13);
            TimeSpan horaioFim = new TimeSpan(4, 12, 35);
            TimeSpan horarioDiferenca = horaioFim - horarioInicio;
            Console.WriteLine(horarioInicio);
            Console.WriteLine(horaioFim);
            Console.WriteLine(horarioDiferenca);

            Console.WriteLine();
            Console.WriteLine("====== Parse ======");
            TimeSpan timeSpanParse = TimeSpan.Parse("08:10:47");
            Console.WriteLine(timeSpanParse);

            Console.ReadKey();
        }
    }
}