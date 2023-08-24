using System;
class Program
{
    static void Main(string[] args)
    {
        Calculadora calculadora = new Calculadora();

        Console.WriteLine("Conversor de Moedas");

        Console.Write("Informe o valor: ");
        double valor = double.Parse(Console.ReadLine());

        Console.Write("Informe a moeda de origem (real, dolar, euro, libra): ");
        string moedaOrigem = Console.ReadLine().ToLower();

        Console.Write("Informe a moeda de destino (real, dolar, euro, libra): ");
        string moedaDestino = Console.ReadLine().ToLower();

        try
        {
            double valorConvertido = calculadora.Converter(valor, moedaOrigem, moedaDestino);
            Console.WriteLine($"Valor convertido: {valorConvertido:F2} {moedaDestino}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
