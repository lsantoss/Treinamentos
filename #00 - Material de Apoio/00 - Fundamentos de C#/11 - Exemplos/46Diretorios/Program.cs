using System;
using System.IO;

namespace _46Diretorios
{
    class Program
    {
        static void Main(string[] args)
        {
            string localDiretorio = @"D:\zzz";
            string destinoDiretorio = @"D:\123\zzz";

            //Cria diretorio
            Directory.CreateDirectory(localDiretorio);

            //Verifica se diretorio existe
            bool diretorioExiste = Directory.Exists(localDiretorio);
            Console.WriteLine(diretorioExiste);

            //Move diretorio
            Directory.Move(localDiretorio, destinoDiretorio);

            //Apaga diretorio vazio
            Directory.Delete(localDiretorio);

            //Apaga diretorio
            Directory.Delete(localDiretorio, true);

            Console.ReadKey();
        }
    }
}