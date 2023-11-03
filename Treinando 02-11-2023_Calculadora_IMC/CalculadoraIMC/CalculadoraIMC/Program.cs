using System.Globalization;

namespace CalculadoraIMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de IMC:");
            Console.WriteLine("Digite seu peso: ");
            double peso = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite sua altura: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            double imc = peso / (altura * altura);
            Console.WriteLine("O seu imc é " + imc.ToString("F2"));

            if (imc <= 18.5)
            {
                Console.WriteLine("De acordo com seu IMC que é " + imc.ToString("F2") + " você está abaixo do peso");
            }
            else if (imc <= 24.9)
            {
                Console.WriteLine("De acordo com seu IMC que é " + imc.ToString("F2") + " você está com peso ideal");
            }
            else if (imc <= 29.9)
            {
                Console.WriteLine("De acordo com seu IMC que é " + imc.ToString("F2") + " você está levemente acima do peso");
            }
            else if (imc <= 34.9)
            {
                Console.WriteLine("De acordo com seu IMC que é " + imc.ToString("F2") + " você está com obesidade grau 1");
            }
            else if (imc <= 39.9)
            {
                Console.WriteLine("De acordo com seu IMC que é " + imc.ToString("F2") + " você está com obesidade grau 2");
            }
            else if (imc >= 40.0)
            {
                Console.WriteLine("De acordo com seu IMC que é " + imc.ToString("F2") + " você está com obesidade grau 3");
            }
            else
            {
                Console.WriteLine("Peso ou Altura inválidos!");
            }
        }
    }
}