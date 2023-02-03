using System;

namespace Tabuada
{
    class AplicandoTabuada
    {
        public static void Tabuada(int numero)
        {
            Console.WriteLine("============Calculo da tabuada do " + numero + "============");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(numero + " x " + i + " = " + (numero * i));
            }
        }
    }
}