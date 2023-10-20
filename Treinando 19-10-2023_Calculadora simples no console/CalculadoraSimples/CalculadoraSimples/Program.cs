namespace CalculadoraSimples
{
    internal class Program
    {
        static void Main(string[] args)
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

            double adicao = num1 + num2;
            double subtracao = num1 - num2;
            double multiplicacao = num1 * num2;
            double divisao = num1 / num2;

            if (opcao == 1) 
            {
                Console.WriteLine($"A adição de {num1} + {num2} = {adicao.ToString("F2")}");
            }
            else if (opcao == 2)
            {
                Console.WriteLine($"A subtração de {num1} - {num2} = {subtracao.ToString("F2")}");
            }
            else if (opcao == 3)
            {
                Console.WriteLine($"A multiplição de {num1} * {num2} = {multiplicacao.ToString("F2")}");
            }
            else if (opcao == 4)
            {
                Console.WriteLine($"A divisão de {num1} / {num2} = {divisao.ToString("F2")}");
            }
            else
            {
                Console.WriteLine("Opção inválida!");
            }
        }
    }
}