using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraSimplesComClasse
{
    internal class Calculadora
    {
        public static void ExecutarCalculadora()
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("Calculadora simples");
            Console.WriteLine("-------------------");
            Console.Write("Digite um número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite outro número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Opções de operações:");
            Console.WriteLine("[1] Adição ---------");
            Console.WriteLine("[2] Subtração ------");
            Console.WriteLine("[3] Multiplicação --");
            Console.WriteLine("[4] Divisão --------");
            Console.WriteLine("--------------------");
            int opcao = Convert.ToInt32(Console.ReadLine());

            double resultado = 0;

            switch (opcao)
            {
                case 1:
                    resultado = num1 + num2;
                    break;
                case 2:
                    resultado = num1 - num2;
                    break;
                case 3:
                    resultado = num1 * num2;
                    break;
                case 4:
                    if (num2 != 0)
                        resultado = num1 / num2;
                    else
                        Console.WriteLine("Erro: Divisão por zero!");
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    return;
            }

            Console.WriteLine($"O resultado da operação é: {resultado.ToString("F2")}");
        }
    }
}
