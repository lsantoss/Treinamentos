using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta1 = new Conta();
            conta1.Numero = 123;
            conta1.Saldo = 250.00;

            Conta conta2 = new Conta(321, 1000);

            Conta conta3 = new Conta()
            {
                Numero = 896,
                Saldo = 145.12
            };

            Console.WriteLine("Conta 1");
            Console.WriteLine($"Número: {conta1.Numero}");
            Console.WriteLine($"Saldo : {conta1.Saldo}");

            Console.WriteLine();
            Console.WriteLine("Conta 2");
            Console.WriteLine($"Número: {conta2.Numero}");
            Console.WriteLine($"Saldo : {conta2.Saldo}");

            Console.WriteLine();
            Console.WriteLine("Conta 3");
            Console.WriteLine($"Número: {conta3.Numero}");
            Console.WriteLine($"Saldo : {conta3.Saldo}");

            Console.ReadKey();
        }
    }
}