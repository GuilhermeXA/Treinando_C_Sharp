using System;

namespace OrdenacaoOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a quantidade de números: ");
            int quantidade = int.Parse(Console.ReadLine());

            Numero[] numeros = new Numero[quantidade];

            for (int i = 0; i < quantidade; i++)
            {
                Console.Write($"Digite o {i + 1}º número: ");
                double valor = double.Parse(Console.ReadLine());
                numeros[i] = new Numero(valor);
            }

            Ordenador.BubbleSort(numeros);

            Console.WriteLine("Valores ordenados:");
            foreach (Numero numero in numeros)
            {
                Console.WriteLine(numero.Valor);
            }
        }
    }
}