using System;

namespace Exercicio3
{
    class Program
    {
        /* Fazer um programa para ler quatro valores inteiros
         * A, B, C e D. A seguir, calcule e mostre a diferença do produto
         * de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).*/
        static void Main(string[] args)
        {
            Console.Write("Digite o valor de A: ");
            int A = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de B: ");
            int B = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de C: ");
            int C = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de D: ");
            int D = int.Parse(Console.ReadLine());

            int diferenca = A * B - C * D;

            Console.Write($"DIFERENCA = {diferenca}");
        }
    }
}
