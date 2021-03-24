using System;

namespace ExemploGuid
{
    class Program
    {
        static void Main(string[] args)
        {
            var varGuid1 = Guid.NewGuid();
            var varGuid2 = Guid.Parse("55d65a67-5403-4ae3-ae82-0ca9297d501b");
            var varGuid3 = Guid.Empty;

            Console.WriteLine(varGuid1);
            Console.WriteLine(varGuid2);
            Console.WriteLine(varGuid3);
            Console.ReadKey();
        }
    }
}