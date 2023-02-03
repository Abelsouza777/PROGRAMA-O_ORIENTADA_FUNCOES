using System;

namespace LerArquivo
{
    class LeitorTxt
    {
        public static void LerArquivos(int numeroArquivo)
        {
            string arquivoComCaminho = @"C:\Users\abel alves de souza\Documents\C# aprendendo\PROGRAMAÇÃO_ORIENTADA_FUNCOES\" + numeroArquivo + ".txt";
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

            }
        }
    }
}