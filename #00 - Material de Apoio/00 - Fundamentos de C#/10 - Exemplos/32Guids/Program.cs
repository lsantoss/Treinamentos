using System;

namespace _32Guids
{
    class Program
    {
        static void Main(string[] args)
        {
            Guid varGuid1 = Guid.NewGuid();
            Guid varGuid2 = Guid.Parse("bc719918-d7e9-49af-ac27-7a4f9525cb2b");
            Guid varGuid3 = Guid.Empty;

            Console.WriteLine(varGuid1);
            Console.WriteLine(varGuid2);
            Console.WriteLine(varGuid3);
            Console.ReadKey();
        }
    }
}