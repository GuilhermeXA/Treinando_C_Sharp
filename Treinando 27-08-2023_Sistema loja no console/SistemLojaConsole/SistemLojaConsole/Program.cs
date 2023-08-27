using System;

namespace LojaConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Digite seu nome: ");
                string nomeCliente = Console.ReadLine();

                Console.WriteLine("Bem-vindo à Loja Virtual!");
                Console.WriteLine("Produtos Disponíveis:");
                Console.WriteLine("1. Produto A - R$10.00");
                Console.WriteLine("2. Produto B - R$20.00");
                Console.WriteLine("3. Produto C - R$30.00");
                Console.WriteLine("4. Produto D - R$40.00");
                Console.WriteLine("5. Produto E - R$50.00");

                int[] precos = { 10, 20, 30, 40, 50 };
                int totalCompra = 0;

                while (true)
                {
                    Console.Write("Escolha um produto (1-5) ou 0 para finalizar a compra: ");
                    int escolha = Convert.ToInt32(Console.ReadLine());

                    if (escolha == 0)
                        break;

                    if (escolha >= 1 && escolha <= 5)
                    {
                        totalCompra += precos[escolha - 1];
                        Console.WriteLine("Produto adicionado ao carrinho!");
                    }
                    else
                    {
                        Console.WriteLine("Opção inválida!");
                    }
                }

                Console.Write("Forma de pagamento (1 para à vista, 2 para cartão de crédito): ");
                int formaPagamento = Convert.ToInt32(Console.ReadLine());

                if (formaPagamento == 2)
                {
                    Console.Write("Quantas vezes deseja parcelar? ");
                    int parcelas = Convert.ToInt32(Console.ReadLine());
                    double valorParcela = totalCompra / parcelas;
                    Console.WriteLine($"Compra parcelada em {parcelas} vezes de R${valorParcela:F2} cada.");
                }

                Console.WriteLine($"Total da compra: R${totalCompra:F2}");
                Console.WriteLine($"Obrigado pela compra, {nomeCliente}! Volte sempre.");

                Console.Write("Deseja fazer outra compra? (s/n): ");
                string continuar = Console.ReadLine().ToLower();
                if (continuar != "s")
                    break;
            }
        }
    }
}
