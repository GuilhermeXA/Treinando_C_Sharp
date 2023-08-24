using System;
class Program
{
    static void Main(string[] args)
    {
        Calculadora calculadora = new Calculadora();

        Console.WriteLine("Conversor de Moeda");
        Console.Write("Digite o nome da moeda (dolar/euro/libra): ");
        string nomeMoeda = Console.ReadLine().ToLower();

        Console.Write("Digite a quantidade da moeda: ");
        double quantidadeMoeda = double.Parse(Console.ReadLine());

        double resultado = 0;

        switch (nomeMoeda)
        {
            case "dolar":
                resultado = calculadora.ConverterDolarParaReal(quantidadeMoeda);
                break;
            case "euro":
                resultado = calculadora.ConverterEuroParaReal(quantidadeMoeda);
                break;
            case "libra":
                resultado = calculadora.ConverterLibraParaReal(quantidadeMoeda);
                break;
            default:
                Console.WriteLine("Moeda não suportada");
                return;
        }

        Console.WriteLine($"O valor em reais é R$: {resultado:N2}");
    }
}