using System;

namespace HerancaHierarquica
{
    class Program
    {
        static void Main(string[] args)
        {
            B classeB = new B();
            C classeC = new C();

            classeB.MetodoClasseA();
            classeB.MetodoClasseB();

            classeC.MetodoClasseA();
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

        public class C : A
        {
            public void MetodoClasseC() => Console.WriteLine("Método da Classe C");
        }
    }
}
