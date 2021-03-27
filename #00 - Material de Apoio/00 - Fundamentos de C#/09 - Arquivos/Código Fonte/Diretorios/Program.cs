using System.IO;

namespace Diretorios
{
    class Program
    {
        static void Main(string[] args)
        {
            string localDiretorio = @"D:\zzz";
            string destinoDiretorio = @"D:\123\zzz";

            //Verifica se diretorio existe
            var diretorioExiste = Directory.Exists(localDiretorio);

            //Cria diretorio
            Directory.CreateDirectory(localDiretorio);

            //Move diretorio
            Directory.Move(localDiretorio, destinoDiretorio);

            //Apaga diretorio vazio
            Directory.Delete(localDiretorio);

            //Apaga diretorio
            Directory.Delete(destinoDiretorio, true);
        }
    }
}