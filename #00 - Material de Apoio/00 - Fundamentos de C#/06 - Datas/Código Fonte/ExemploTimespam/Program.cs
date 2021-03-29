using System;

namespace ExemploTimespam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====== Valor padrão =======");
            TimeSpan timeSpan1 = new TimeSpan();
            Console.WriteLine(timeSpan1);
            Console.WriteLine(TimeSpan.Zero);

            Console.WriteLine();
            Console.WriteLine("====== Criando com valores =======");
            TimeSpan timeSpan2 = new TimeSpan(2, 14, 18);
            Console.WriteLine(timeSpan2);

            Console.WriteLine();
            Console.WriteLine("====== Diferença de valores (DateTime) =======");
            DateTime DataInicio = new DateTime(2010, 6, 12, 18, 32, 0);
            DateTime DataFim = new DateTime(2010, 6, 13, 22, 47, 0);
            TimeSpan tempoTotal = DataFim - DataInicio;
            Console.WriteLine(DataFim);
            Console.WriteLine(DataInicio);
            Console.WriteLine(tempoTotal);

            Console.WriteLine();
            Console.WriteLine("====== Diferença de valores (TimeSpan) =======");
            TimeSpan horario1 = new TimeSpan(6, 55, 13);
            TimeSpan horario2 = new TimeSpan(4, 12, 35);
            TimeSpan horarioDiferença = horario1 - horario2;
            Console.WriteLine(horario1);
            Console.WriteLine(horario2);
            Console.WriteLine(horarioDiferença);

            Console.WriteLine();
            Console.WriteLine("====== Parse =======");
            TimeSpan timeSpanParse = TimeSpan.Parse("08:10:47");
            Console.WriteLine(timeSpanParse);

            Console.ReadKey();
        }
    }
}