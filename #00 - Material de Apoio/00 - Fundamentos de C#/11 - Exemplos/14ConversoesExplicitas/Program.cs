using System;

namespace _14ConversoesExplicitas
{
    class Program
    {
        static void Main(string[] args)
        {
            long varLong = 1253;
            int varInt = 458;

            Console.WriteLine(varInt);
            varInt = (int)varLong;

            Console.WriteLine(varLong);
            Console.WriteLine(varInt);
            Console.ReadKey();
        }
    }
}