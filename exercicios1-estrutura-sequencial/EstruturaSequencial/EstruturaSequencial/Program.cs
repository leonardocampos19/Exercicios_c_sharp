using System;

namespace EstruturaSequencial
{
    class Program
    {
        /*Faça um programa para ler dois valores inteiros,
        e depois mostrar na tela a soma desses números com uma
        mensagem explicativa, conforme exemplos.*/

        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro número: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            int n2 = int.Parse(Console.ReadLine());
            int soma = n1 + n2;

            Console.WriteLine($"SOMA = {soma}");
        }
    }
}
