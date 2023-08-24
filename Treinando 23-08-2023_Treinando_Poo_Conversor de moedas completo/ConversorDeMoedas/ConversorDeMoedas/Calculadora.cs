public class Calculadora
{
    private Dictionary<string, double> taxas;

    public Calculadora()
    {
        taxas = new Dictionary<string, double>
        {
            { "real", 1.0 },
            { "dolar", 5.23 },
            { "euro", 6.17 },
            { "libra", 7.12 }
        };
    }

    public double Converter(double valor, string moedaOrigem, string moedaDestino)
    {
        if (taxas.ContainsKey(moedaOrigem) && taxas.ContainsKey(moedaDestino))
        {
            double taxaOrigem = taxas[moedaOrigem];
            double taxaDestino = taxas[moedaDestino];

            double valorEmReal = valor / taxaOrigem;
            double valorConvertido = valorEmReal * taxaDestino;

            return valorConvertido;
        }
        else
        {
            throw new ArgumentException("Moedas não suportadas.");
        }
    }
}
