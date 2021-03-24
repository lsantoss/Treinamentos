using System;

namespace _13ConversoesImplictas
{
    class Program
    {
        static void Main(string[] args)
        {
            long varLong = 1253;
            int varInt = 458;

            Console.WriteLine(varLong);
            varLong = varInt;

            Console.WriteLine(varInt);
            Console.WriteLine(varLong);
            Console.ReadKey();
        }
    }
}