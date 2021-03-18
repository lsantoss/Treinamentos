using System;

namespace OperadoresLogicos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("======= Operador de negação lógica ! ========");
            Console.WriteLine(!false); //True
            Console.WriteLine(!true);  //False

            Console.WriteLine();
            Console.WriteLine("======= Operador AND lógico & ========");
            Console.WriteLine(false & true); //False
            Console.WriteLine(false & false);//False
            Console.WriteLine(true & false); //False
            Console.WriteLine(true & true);  //True

            Console.WriteLine();
            Console.WriteLine("======= Operador AND lógico && ========");
            Console.WriteLine(false && true); //False
            Console.WriteLine(false && false);//False
            Console.WriteLine(true && false); //False
            Console.WriteLine(true && true);  //True

            Console.WriteLine();
            Console.WriteLine("======= Operador OR lógico | ========");
            Console.WriteLine(false | true); //True
            Console.WriteLine(false | false);//False
            Console.WriteLine(true | false); //True
            Console.WriteLine(true | true);  //True

            Console.WriteLine();
            Console.WriteLine("======= Operador OR lógico || ========");
            Console.WriteLine(false || true); //True
            Console.WriteLine(false || false);//False
            Console.WriteLine(true || false); //True
            Console.WriteLine(true || true);  //True

            Console.WriteLine();
            Console.WriteLine("======= Operador OR exclusivo lógico ^ ========");
            Console.WriteLine(true ^ true);   //False
            Console.WriteLine(true ^ false);  //True
            Console.WriteLine(false ^ true);  //True
            Console.WriteLine(false ^ false); //False

            Console.ReadKey();
        }
    }
}