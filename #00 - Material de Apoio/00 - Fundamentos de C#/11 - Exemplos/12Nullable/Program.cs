using System;

namespace _12Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            int inteiro1 = 123;
            //int inteiro2 = null;
            int? inteiro3 = 75482;
            int? inteiro4 = null;

            //inteiro1 = (int)inteiro4; 
            //inteiro1 = (int)inteiro3;
            //inteiro1 = inteiro3;
            //inteiro3 = inteiro1;

            Console.WriteLine(inteiro1);
            Console.WriteLine(inteiro3);
            Console.WriteLine(inteiro4);
            Console.WriteLine(inteiro4.HasValue);
            Console.WriteLine(inteiro3.Value);
            Console.ReadKey();
        }
    }
}