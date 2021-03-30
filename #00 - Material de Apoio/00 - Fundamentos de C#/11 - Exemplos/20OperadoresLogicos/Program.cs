using System;

namespace _20OperadoresLogicos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("======== Operador AND lógivo & ======");
            Console.WriteLine(false & true); //False
            Console.WriteLine(false & false); //False
            Console.WriteLine(true & false); //False
            Console.WriteLine(true & true); //True

            Console.WriteLine();
            Console.WriteLine("======== Operador AND lógivo && ======");
            Console.WriteLine(false && true); //False
            Console.WriteLine(false && false); //False
            Console.WriteLine(true && false); //False
            Console.WriteLine(true && true); //True

            Console.WriteLine();
            Console.WriteLine("======== Operador OR lógivo | ======");
            Console.WriteLine(false | true); //True
            Console.WriteLine(false | false); //False
            Console.WriteLine(true | false); //True
            Console.WriteLine(true | true); //True

            Console.WriteLine();
            Console.WriteLine("======== Operador OR lógivo || ======");
            Console.WriteLine(false || true); //True
            Console.WriteLine(false || false); //False
            Console.WriteLine(true || false); //True
            Console.WriteLine(true || true); //True

            Console.WriteLine();
            Console.WriteLine("======== Operador OR exclusico ^ ======");
            Console.WriteLine(false ^ true); //True
            Console.WriteLine(false ^ false); //False
            Console.WriteLine(true ^ false); //True
            Console.WriteLine(true ^ true); //False

            Console.ReadKey();
        }
    }
}