using System;
using System.Globalization;

namespace Exercicio4
{
    class Program
    {
        /* Fazer um programa que leia o número de um funcionário,
         * seu número de horas trabalhadas, o valor que recebe por
         * hora e calcula o salário desse funcionário. A seguir, mostre o número
         * e o salário do funcionário, com duas casas decimais.*/
        static void Main(string[] args)
        {
            Console.Write("Digite o número do funcionário: ");
            int numFuncionario = int.Parse(Console.ReadLine());

            Console.Write("Digite o número de horas trabalhadas: ");
            int horasTrabalhadas = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor que recebe por hora: ");
            double valorHora = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double calculo = valorHora * horasTrabalhadas;

            Console.WriteLine($"NUMBER = {numFuncionario}");
            Console.Write("SALARY = U$ " + calculo.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
