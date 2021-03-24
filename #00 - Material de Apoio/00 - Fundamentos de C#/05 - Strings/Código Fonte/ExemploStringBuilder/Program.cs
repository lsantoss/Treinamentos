using System;
using System.Text;

namespace ExemploStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder myStringBuilder = new StringBuilder();
            myStringBuilder.Append("Olá!!!!!");
            myStringBuilder.Append(" Tudo bem?");

            myStringBuilder.AppendLine();
            myStringBuilder.AppendLine("Estamos testando como usar um StringBuilder.");

            myStringBuilder.AppendFormat("Faz um pix aí de {0:C}. ", 25.94);

            myStringBuilder.Insert(3, " pessoal");

            myStringBuilder.Remove(11, 4);

            myStringBuilder.Replace("Olá", "Oi");

            string minhaString = myStringBuilder.ToString();

            Console.WriteLine(myStringBuilder);

            Console.WriteLine();
            Console.WriteLine(minhaString);

            Console.ReadKey();
        }
    }
}