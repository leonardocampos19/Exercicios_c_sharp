using System;
using System.Globalization;

namespace Exercicio2
{
    class Program
    {
        /*Faça um programa para ler o valor do raio de um círculo,
         *e depois mostrar o valor da área deste círculo com quatro
          casas decimais conforme exemplos*/
        static void Main(string[] args)
        {
            Console.Write("Digite o raio: ");
            double raio = float.Parse(Console.ReadLine());

            double area = Math.Pow(raio,2) * 3.14159;

            Console.Write("A área do círculo é: " + area.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
