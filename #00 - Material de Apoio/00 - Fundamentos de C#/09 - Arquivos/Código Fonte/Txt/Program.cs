using System.IO;

namespace Txt
{
    class Program
    {
        static void Main(string[] args)
        {
            string localArquivo = @"D:\meuArquivo.txt";
            string destinoArquivo = @"D:\meuArquivo123.txt";

            //Cria arquivo txt
            StreamWriter streamWriter = new StreamWriter(localArquivo);
            streamWriter.Close();

            //Lê arquivo inteiro 
            string texto = File.ReadAllText(localArquivo);

            //Lê todas as linhas
            string[] textoLinhas = File.ReadAllLines(localArquivo);

            //Salvar conteúdo de uma string no arquivo
            File.WriteAllText(destinoArquivo, texto);

            //Salvar conteúdo de uma string no arquivo
            File.WriteAllLines(destinoArquivo, textoLinhas);
        }
    }
}