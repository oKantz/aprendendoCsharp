using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap02_Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B, R; // Cria três variáveis de valor inteiro.

            Console.Write("Entre o 1o. Valor: "); // Escreve uma mensagem para você insirir um valor para a primeira variável.
            A = int.Parse(Console.ReadLine()); // Registra o valor digitado acima na variável.

            Console.Write("Entre o 2o. Valor: ");
            B = int.Parse(Console.ReadLine()); // mesma coisa.

            R = A + B; // Faz a soma de A e B e registra na variável R.

            Console.WriteLine();
            Console.WriteLine("Resultado = " + R); // Escreve o resultado e pula uma linha

            Console.WriteLine();
            Console.WriteLine("Tecla <Enter> para continuar...");
            Console.ReadLine(); 

            //
        }
    }
}
