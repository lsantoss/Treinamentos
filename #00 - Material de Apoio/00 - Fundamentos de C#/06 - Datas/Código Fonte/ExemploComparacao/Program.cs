using System;

namespace ExemploComparacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            DateTime date1 = DateTime.Now;
            DateTime date2 = DateTime.Now.AddDays(1).AddMonths(2).AddYears(5);

            //date1 = date2;

            Console.WriteLine("====== Datas ======");
            Console.WriteLine(date1);
            Console.WriteLine(date2);
            Console.WriteLine();

            Console.WriteLine("====== Comparações ======");
            if (date1 == date2)
                Console.WriteLine("Datas são iguais");
            else if (date1 > date2)
                Console.WriteLine("Data 1 maior");
            else if (date1 < date2)
                Console.WriteLine("Data 1 menor");

            Console.WriteLine();
            Console.WriteLine("====== Compare ======");
            int retorno = DateTime.Compare(date1, date2);
            Console.WriteLine(retorno);

            Console.ReadKey();
        }
    }
}
