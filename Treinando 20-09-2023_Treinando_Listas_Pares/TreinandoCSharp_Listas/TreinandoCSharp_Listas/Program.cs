using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> valores = new List<int>();
        List<int> pares = new List<int>();

        Console.WriteLine("Digite uma série de números inteiros (digite um número negativo para encerrar):");

        while (true)
        {
            string entrada = Console.ReadLine();
            int valor;

            if (int.TryParse(entrada, out valor))
            {
                if (valor < 0)
                {
                    break; // Encerra o loop quando um número negativo é digitado
                }

                valores.Add(valor);

                if (valor % 2 == 0)
                {
                    pares.Add(valor);
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Digite um número inteiro.");
            }
        }

        Console.WriteLine("Valores digitados:");
        foreach (int numero in valores)
        {
            Console.Write(numero + " ");
        }

        Console.WriteLine("\nNúmeros pares:");
        foreach (int numero in pares)
        {
            Console.Write(numero + " ");
        }
    }
}
