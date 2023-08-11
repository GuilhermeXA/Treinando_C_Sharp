using System;
using System.Collections.Generic;

namespace LojaNoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Loja loja = new Loja();

            Console.WriteLine("=============================");
            Console.WriteLine("=== Loja No Console do C# ===");
            Console.WriteLine("=============================");

            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();

            while (true)
            {
                Console.WriteLine("============");
                Console.WriteLine("=== Menu ===");
                Console.WriteLine("============");
                Console.WriteLine("Deseja continuar na loja? ");
                Console.WriteLine("[1] Sim");
                Console.WriteLine("[2] Não");
                Console.WriteLine("[3] Sair da loja");
                int opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    loja.MostrarProdutos();
                    int opcaoProduto = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite a quantidade desejada do item: ");
                    int qtdItem = int.Parse(Console.ReadLine());

                    loja.AdicionarItem(opcaoProduto, qtdItem);
                }
                else if (opcao == 2)
                {
                    loja.MostrarCarrinho();
                    loja.FecharCompra();
                }
                else if (opcao == 3)
                {
                    Console.WriteLine("Saindo da loja");
                    break;
                }
                else
                {
                    Console.WriteLine("Atenção! Por favor digite uma opção válida!");
                }
            }
        }
    }

    class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
    }

    class Loja
    {
        private List<Produto> produtos = new List<Produto>();
        private List<ItemCarrinho> carrinho = new List<ItemCarrinho>();

        public Loja()
        {
            produtos.Add(new Produto { Nome = "Smartphone", Preco = 1200 });
            produtos.Add(new Produto { Nome = "Smart TV", Preco = 1500 });
            produtos.Add(new Produto { Nome = "Notebook", Preco = 2000 });
            produtos.Add(new Produto { Nome = "Tablet", Preco = 800 });
        }

        public void MostrarProdutos()
        {
            Console.WriteLine("Lista de produtos");
            for (int i = 0; i < produtos.Count; i++)
            {
                Console.WriteLine($"[{i + 1}] {produtos[i].Nome} R${produtos[i].Preco}");
            }
            Console.WriteLine("Digite o produto desejado: ");
        }

        public void AdicionarItem(int opcaoProduto, int qtdItem)
        {
            Produto produtoSelecionado = produtos[opcaoProduto - 1];
            carrinho.Add(new ItemCarrinho { Produto = produtoSelecionado, Quantidade = qtdItem });
        }

        public void MostrarCarrinho()
        {
            Console.WriteLine("Lista de itens comprados");
            double somaCarrinhoDeCompras = 0;
            int qtdItensCarrinho = 0;
            foreach (var item in carrinho)
            {
                Console.WriteLine($"{item.Quantidade} {item.Produto.Nome}(s) adicionado no carrinho");
                qtdItensCarrinho += item.Quantidade;
                somaCarrinhoDeCompras += item.Produto.Preco * item.Quantidade;
            }
            Console.WriteLine($"Preço total dos produtos no carrinho de compra é R${somaCarrinhoDeCompras.ToString("F2")}");
            Console.WriteLine($"Quantidade de itens no carrinho é {qtdItensCarrinho}");
        }

        public void FecharCompra()
        {
            Console.WriteLine("===============================");
            Console.WriteLine("Tem certeza que deseja fechar a compra? ");
            Console.WriteLine("[1] Finalizar a compra");
            Console.WriteLine("[2] Continuar comprando");
            int opcaoFinalizar = int.Parse(Console.ReadLine());

            if (opcaoFinalizar == 1)
            {
                double somaTotalFinal = 0;
                foreach (var item in carrinho)
                {
                    somaTotalFinal += item.Produto.Preco * item.Quantidade;
                }

                Console.WriteLine("Lista de opções de pagamento:");
                Console.WriteLine("[1] À vista");
                Console.WriteLine("[2] Cartão de crédito");
                int opcaoPagamento = int.Parse(Console.ReadLine());

                if (opcaoPagamento == 1)
                {
                    double descontoAVista = somaTotalFinal * 0.9;
                    Console.WriteLine($"A sua compra saiu por R${descontoAVista.ToString("F2")}");
                }
                else if (opcaoPagamento == 2)
                {
                    Console.WriteLine("Digite em quantas vezes você deseja fazer a compra: ");
                    Console.WriteLine("[1] 2x no cartão");
                    Console.WriteLine("[2] 3x no cartão");
                    Console.WriteLine("[3] 4x no cartão");
                    int opcaoNumParcelas = int.Parse(Console.ReadLine());
                    double valorParcelas = somaTotalFinal / opcaoNumParcelas;
                    Console.WriteLine($"Sua compra saiu por R${somaTotalFinal.ToString("F2")} em {opcaoNumParcelas} parcelas de R${valorParcelas.ToString("F2")}");
                }
                else
                {
                    Console.WriteLine("Atenção! Digite uma opção de pagamento válida!");
                }
            }
        }
    }

    class ItemCarrinho
    {
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
    }
}
