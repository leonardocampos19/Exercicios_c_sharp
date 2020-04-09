using System;
using System.Globalization;

namespace Exercicio5
{
    class Program
    {
        /*Fazer um programa para ler o código de uma peça 1,
         * o número de peças 1, o valor unitário de cada peça 1,
         * o código de uma peça 2, o número de peças 2 e o valor 
         * unitário de cada peça 2. Calcule e mostre o valor a ser pago*/
         // OBS: AINDA NÃO FOI PASSADO ESTRUTURRA DE REPETIÇÃO
        static void Main(string[] args)
        {
            int[] codigo = new int[2];
            int[] quantidade = new int[2];
            double[] valor = new double[2];

            Console.Write("Digite o código do produto 1: ");
            codigo[0] = int.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade do produto 1: ");
            quantidade[0] = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor do produto 1: ");
            valor[0] = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);


            Console.Write("Digite o código do produto 2: ");
            codigo[1] = int.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade do produto 2: ");
            quantidade[1] = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor do produto 2: ");
            valor[1] = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);


            double total = (quantidade[0] * valor[0]) + (quantidade[1] * valor[1]);

            Console.Write("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
