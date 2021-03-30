using System;

namespace _51HerancaSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaPoupanca conta1 = new ContaPoupanca();
            conta1.Numero = 123;
            conta1.Saldo = 250.00;
            conta1.JurosMensais = 3;

            Console.WriteLine("Conta");
            Console.WriteLine($"Número      : {conta1.Numero}");
            Console.WriteLine($"Saldo       : {conta1.Saldo}");
            Console.WriteLine($"JurosMensais: {conta1.JurosMensais}");
            Console.ReadKey();
        }

        public class Conta
        {
            public int Numero { get; set; }
            public double Saldo { get; set; }
        }

        public class ContaPoupanca : Conta
        {
            public int JurosMensais { get; set; }
        }
    }
}