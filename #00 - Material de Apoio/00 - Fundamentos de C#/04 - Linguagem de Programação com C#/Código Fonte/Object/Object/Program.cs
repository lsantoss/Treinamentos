using System;

namespace Object
{
    class Program
    {
        static void Main(string[] args)
        {
            object varInt = 2;
            object varDouble = 2.75;
            object varString = "Minha string 123";
            object varChar = 'a';

            object varObjeto = new Carro()
            {
                Marca = "Honda",
                Modelo = "Civic"
            };

            Carro carro = (Carro)varObjeto;

            Console.WriteLine($"\nInteiro : {varInt} - {varInt.GetType()}");
            Console.WriteLine($"\nDouble  : {varDouble} - {varDouble.GetType()}");
            Console.WriteLine($"\nString  : {varString} - {varString.GetType()}");
            Console.WriteLine($"\nChar    : {varChar} - {varChar.GetType()}");
            Console.WriteLine($"\nClasse  : {varObjeto.GetType().Name}");
            Console.ReadKey();
        }

        class Carro
        {
            public string Marca { get; set; }
            public string Modelo { get; set; }
        }
    }
}