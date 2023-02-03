using System;

namespace Calculo
{
    class media
    {
        public static void CalcularMediaAluno()
        {
            Console.WriteLine("informe o nome do aluno");
            string nome = Console.ReadLine();
            int qtdNotas = 3;
            Console.WriteLine("digite as " + qtdNotas + " notas do aluno " + nome);
            List<int> notas = new List<int>();
            int totalNotas = 0;
            for (int i = 1; i <= qtdNotas; i++)
            {
                Console.WriteLine("informe a nota" + i);
                int nota = int.Parse(Console.ReadLine());
                notas.Add(nota);
                totalNotas += nota;
            }
            int media = totalNotas / notas.Count;
            Console.WriteLine("===============================================");
            Console.WriteLine("O aluno " + nome + " tem a média " + media);
            Console.WriteLine("teve notas:");
            foreach (int nota in notas)
            {

                Console.WriteLine("nota " + nota);
            }
            Console.WriteLine("===============================================");

        }
    }

}
    