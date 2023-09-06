namespace SistemaCalculadoraPreço
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculadoraPreco calculo = new CalculadoraPreco();

            Console.WriteLine("Digite o nome do produto: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite o custo fixo do produto: ");
            double custoFixo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o custo variável do produto: ");
            double custoVariavel = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a margem de lucro desejada: ");
            double margemLucro = Convert.ToDouble(Console.ReadLine());

            calculo.Nome = nome;
            calculo.CustoFixo = custoFixo;
            calculo.CustoVariavel = custoVariavel;
            calculo.MargemLucro = margemLucro;

            double precoFinal = calculo.CalcPreco(custoFixo, custoVariavel);

            Console.WriteLine("O produto "
                +calculo.Nome+" com o custo fixo de R$"
                +calculo.CustoFixo.ToString("F2")+" e com o custo variável R$"
                +calculo.CustoVariavel.ToString("F2")+" e com o seu objetivo de margem de lucro de "
                +calculo.MargemLucro.ToString("F2")+"% fica com seu preço final de R$"
                +precoFinal.ToString("F2"));
        }
    }
}