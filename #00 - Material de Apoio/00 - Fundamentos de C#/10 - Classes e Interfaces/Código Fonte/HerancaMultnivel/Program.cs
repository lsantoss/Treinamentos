using System;

namespace HerancaMultnivel
{
    class Program
    {
        static void Main(string[] args)
        {
            C classeC = new C();
            classeC.MetodoClasseA();
            classeC.MetodoClasseB();
            classeC.MetodoClasseC();
            Console.ReadKey();
        }

        public class A
        {
            public void MetodoClasseA() => Console.WriteLine("Método da classe A");
        }

        public class B : A
        {
            public void MetodoClasseB() => Console.WriteLine("Método da classe B");
        }

        public class C : B
        {
            public void MetodoClasseC() => Console.WriteLine("Método da Classe C");
        }
    }
}