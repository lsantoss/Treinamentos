using System;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Pedido pedido = new Pedido();
            pedido.Numero = 1;
            pedido.DataHora = DateTime.Now;
            pedido.Situacao = ESituacao.Aberto;

            Console.WriteLine($"Situação atual: {pedido.Situacao.GetHashCode()}");
            Console.WriteLine($"Situação atual: {pedido.Situacao}");
            Console.WriteLine();

            pedido.Situacao = ESituacao.Faturado;

            Console.WriteLine($"Situação atual: {pedido.Situacao.GetHashCode()}");
            Console.WriteLine($"Situação atual: {pedido.Situacao}");
            Console.WriteLine();

            pedido.Situacao = ESituacao.Cancelado;

            Console.WriteLine($"Situação atual: {pedido.Situacao.GetHashCode()}");
            Console.WriteLine($"Situação atual: {pedido.Situacao}");
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}