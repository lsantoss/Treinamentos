using System.IO;

namespace Arquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            string localArquivo = @"D:\teste123.pptx";
            string destinoArquivo = @"D:\zzz\teste123.pptx";

            //Verifica se arquivo existe
            bool arquivoExiste = File.Exists(localArquivo);

            //Lê arquivo
            byte[] arquivoEmBytes = File.ReadAllBytes(localArquivo);

            //Salva arquivo
            File.WriteAllBytes(destinoArquivo, arquivoEmBytes);

            //Copia arquivo - sobreescrita não habilitada
            File.Copy(localArquivo, destinoArquivo);

            //Copia arquivo - sobreescrita habilitada
            File.Copy(localArquivo, destinoArquivo, true);

            //Move arquivo - sobreescrita não habilitada
            File.Move(localArquivo, destinoArquivo);

            //Apaga arquivo
            File.Delete(localArquivo);
        }
    }
}