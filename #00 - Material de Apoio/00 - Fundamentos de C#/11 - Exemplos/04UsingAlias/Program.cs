using AliasNamespace = _04UsingAlias.Pasta1.Pasta2.Pasta3;
using System;

namespace _04UsingAlias
{
    class Program
    {
        static void Main(string[] args)
        {
            AliasNamespace.Class1 class1 = new AliasNamespace.Class1();

            Console.WriteLine("Using Alias");
            Console.ReadKey();
        }
    }
}