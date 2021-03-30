using System;

namespace HerancaMultipla
{
    class Program
    {
        static void Main(string[] args)
        {
            int area;
            Quadrado quadrado = new Quadrado();

            quadrado.SetLado(5);
            area = quadrado.GetArea();
            Console.WriteLine("A area é : {0}", quadrado.GetArea());
            Console.WriteLine("O custo é: {0}", quadrado.GetCusto(area));
            Console.ReadKey();
        }

        public class Forma
        {
            protected int Lado { get; private set; }
            public void SetLado(int s) => Lado = s;
        }

        public interface ICusto
        {
            int GetCusto(int area);
        }

        public class Quadrado : Forma, ICusto
        {
            public int GetArea() => (Lado * Lado);
            public int GetCusto(int area) => area * 10;
        }
    }
}