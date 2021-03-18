using Alias = Pasta1.Pasta2.Pasta3;
using System;

namespace UsingAlias
{
    class Program
    {
        static void Main(string[] args)
        {
            Alias.Circle circle = new Alias.Circle(5);

            Console.WriteLine(circle.Area);
            Console.ReadKey();
        }
    }
}