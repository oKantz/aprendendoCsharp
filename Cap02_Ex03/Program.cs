using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap02_Ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float HT, VH, PD, SB, TD, SL; // Cria variáveis

            Console.Write("Horas trabalhadas .......: ");
            HT = float.Parse(Console.ReadLine());
            Console.Write("Valor da hora .........: ");
            VH = float.Parse(Console.ReadLine());
            Console.Write("Valor dp percentual de desconto.: ");
            PD = float.Parse(Console.ReadLine());

            SB = HT * VH; //multiplcando as horas trabalhadas com o valor da hora
            TD = (PD / 100) * SB; // Descobrindo o percentual de desconto
            SL = SB - TD; // Resultado

            Console.WriteLine();
            Console.Write("Salario liquido ........: ");
            Console.WriteLine(SL.ToString("##,##0.00"));

            Console.WriteLine();
            Console.Write("Tecle <Enter> para encerrar... ");
            Console.ReadLine();
        }
    }
}
