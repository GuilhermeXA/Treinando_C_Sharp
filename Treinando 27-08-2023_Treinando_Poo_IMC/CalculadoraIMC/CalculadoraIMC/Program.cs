namespace CalculadoraIMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculadoraIMC calculadora = new CalculadoraIMC();

            Console.Write("Digite seu nome: ");
            calculadora.nome = Console.ReadLine();
            Console.Write("Digite sua altura: ");
            calculadora.altura = double.Parse(Console.ReadLine());
            Console.Write("Digite seu peso: ");
            calculadora.peso = double.Parse(Console.ReadLine());

            string mensagemIMC = calculadora.Mensagem();

            Console.WriteLine(mensagemIMC);

        }
    }
}