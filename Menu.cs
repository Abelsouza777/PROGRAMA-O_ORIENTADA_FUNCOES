using Calculo;
using LerArquivo;
using System;
using Tabuada;

namespace Menu
{
    class menus
    {
        public const int SAIDA_PROGRAMA = 0;
        public const int LER_ARQUIVOS = 1;
        public const int TABUADA = 2;
        public const int CALCULO_MEDIA = 3;
        public static void menuzando()
        {

            while (true)
            {
                string mensagem = "======================================================================" +
                    "\nOlá usuário, bem vindo ao program, utilizando programação funcional" +
                    "\n\n\n\n   Digite uma das opções abaixo:" +
                    "\n    0 - Sair do programa;" +
                    "\n    1 - Ler arquivos;" +
                    "\n    2 - Executar a tabuada;" +
                    "\n    3 - Calcular a média dos alunos." +
                    "\n\n\n\n======================================================================";
                Console.WriteLine(mensagem);

                Console.WriteLine("Digite " + SAIDA_PROGRAMA + " para sair do prograna");
                int valor = int.Parse(Console.ReadLine());

                if (SAIDA_PROGRAMA == valor)
                {
                    break;
                }
                if (LER_ARQUIVOS == valor)
                {
                    Console.WriteLine("======= Opção Ler arquivos =======");
                    LeitorTxt.LerArquivos(1);
                }
                if (TABUADA == valor)
                {
                    Console.WriteLine("======= Opção Tabuada =======");
                    Console.WriteLine("Informe o numero a ser calculado a tabuada");
                    int numero = int.Parse(Console.ReadLine());
                    AplicandoTabuada.Tabuada(numero);
                }
                if (CALCULO_MEDIA == valor)
                {
                    media.CalcularMediaAluno();
                }
            }
        }
    }
}