class Calculadora
{
    private double Dolar = 5.23; // Taxa de conversão do Dólar para Real
    private double Euro = 6.17; // Taxa de conversão do Euro para Real
    private double Libra = 7.12; // Taxa de conversão da Libra para Real

    public double ConverterDolarParaReal(double valorDolar)
    {
        return valorDolar * Dolar;
    }

    public double ConverterEuroParaReal(double valorEuro)
    {
        return valorEuro * Euro;
    }

    public double ConverterLibraParaReal(double valorLibra)
    {
        return valorLibra * Libra;
    }
}