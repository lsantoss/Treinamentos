using System;

namespace _40DateTimeCompare
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            DateTime data1 = DateTime.Now;
            DateTime data2 = DateTime.Now.AddDays(1).AddMonths(2).AddYears(5);

            //data1 = data2;

            Console.WriteLine("====== Datas originais ======");
            Console.WriteLine(data1);
            Console.WriteLine(data2);
            Console.WriteLine();

            Console.WriteLine("====== Comparações ======");
            if (data1 == data2)
                Console.WriteLine("Data iguais");
            else if (data1 > data2)
                Console.WriteLine("Data 1 maior");
            else if (data1 < data2)
                Console.WriteLine("Data 2 maior");

            Console.WriteLine();
            Console.WriteLine("====== Compare ======");
            int retorno = DateTime.Compare(data1, data2);
            Console.WriteLine(retorno);

            Console.ReadKey();
        }
    }
}