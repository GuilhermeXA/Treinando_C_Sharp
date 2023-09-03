namespace TreinandoPooCalcTraba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculadoraTrabalhista conta = new CalculadoraTrabalhista();
            Console.Write("Digite seu nome: ");
            conta.Nome = Convert.ToString(Console.ReadLine());
            Console.Write("Digite seu salário: ");
            conta.Salario = Convert.ToDouble(Console.ReadLine());

            double valorCalculo = conta.CalcINSS(conta.Salario);
            Console.WriteLine($"{conta.Nome} o valor do imposto a ser descontado no seu salário é R${valorCalculo.ToString("F2")}");
        }
    }
}