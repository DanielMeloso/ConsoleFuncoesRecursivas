using System;
using System.IO;

namespace ConsoleFuncoesRecursivas
{
    class Program
    {
        static void Main(string[] args)
        {
            LerArquivo(1);
        }

        private static void LerArquivo(int numeroArquivo)
        {
            string arquivoComCaminho = (@"C:\TesteArquivos\arq" + numeroArquivo + ".txt");
            if (File.Exists(arquivoComCaminho))
            {
                using (StreamReader arquivo = File.OpenText(arquivoComCaminho))
                {
                    string linha;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        Console.WriteLine(linha);
                    }
                }
            } else
            {
                Console.Write("Arquivo inexistente no diretório especificado");
            }
            numeroArquivo++;
            string proxArquivoComCaminho = (@"C:\TesteArquivos\arq" + ( numeroArquivo ) + ".txt");
            if (File.Exists(proxArquivoComCaminho))
            {
                LerArquivo(numeroArquivo);
            } else
            {
                Console.Write("Fim da leitura dos arquivos...");
            }
        }
    }

    
}
