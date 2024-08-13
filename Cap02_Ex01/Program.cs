using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap02_Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string NOME; // Declara uma variável do tipo string chamada NOME

            Console.Write("Escreva seu nome: "); // Exibe uma mensagem parecida com um escreva
            NOME = Console.ReadLine(); // Vai ler a entrada do usuário e armazenar o valor na variavel nome
            Console.WriteLine("Ola, " + NOME); // Exibe a mensagem "olá" e o valor da variável NOME, pulando para a proxima linha

            Console.WriteLine(); //Separa a mensagem anterior da proxima
            Console.Write("Aperte <Enter> para sair..."); // Escreve
            Console.ReadLine(); // Lê o registro

        }
    }
}
 