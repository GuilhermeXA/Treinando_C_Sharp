namespace LojaNoConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=============================");
            Console.WriteLine("=== Loja No Console do C# ===");
            Console.WriteLine("=============================");

            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();

            double smartphone = 1200;
            double smarttv = 1500;
            double notebook = 2000;
            double tablet = 800;

            int qtdItem = 0;
            double somaCarrinhoDeCompras = 0;
            int qtdItensCarrinho = 0;
            double somaTotalFinal = 0;
            int qtdSmartphone, qtdSmarttv, qtdNotebook, qtdTablet;
            double somaSmartphone = 0;
            double somaSmarttv = 0;
            double somaNotebook = 0; 
            double somaTablet = 0;

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
                    Console.WriteLine("Lista de produtos");
                    Console.WriteLine($"[1] Smartphone R${smartphone}");
                    Console.WriteLine($"[2] Smart Tv R${smarttv}");
                    Console.WriteLine($"[3] Notebook R${notebook}");
                    Console.WriteLine($"[4] Tablet R${tablet}");
                    Console.WriteLine("Digite o produto desejado: ");
                    int opcaoProduto = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite a quantidade desejada do item: ");
                    qtdItem = int.Parse(Console.ReadLine());

                    if (opcaoProduto == 1)
                    {
                        Console.WriteLine($"{qtdItem} Smartphone(s) adicionado no carrinho");
                        qtdSmartphone = qtdItem;
                        somaSmartphone = smartphone * qtdSmartphone;
                        qtdItensCarrinho += qtdItem;
                        somaCarrinhoDeCompras += smartphone;
                    }
                    else if (opcaoProduto == 2)
                    {
                        Console.WriteLine($"{qtdItem} Smart Tv(s) adicionada no carrinho");
                        qtdSmarttv = qtdItem;
                        somaSmarttv = smarttv * qtdSmarttv;
                        qtdItensCarrinho += qtdItem;
                        somaCarrinhoDeCompras += smarttv;
                    }
                    else if (opcaoProduto == 3)
                    {
                        Console.WriteLine($"{qtdItem} Notebook(s) adicionado no carrinho");
                        qtdNotebook = qtdItem;
                        somaNotebook = notebook * qtdNotebook;
                        qtdItensCarrinho += qtdItem;
                        somaCarrinhoDeCompras += notebook;
                    }
                    else if (opcaoProduto == 4)
                    {
                        Console.WriteLine($"{qtdItem} Tablet(s) adicionado no carrinho");
                        qtdTablet = qtdItem;
                        somaTablet = tablet * qtdTablet;
                        qtdItensCarrinho += qtdItem;
                        somaCarrinhoDeCompras += tablet;
                    }
                }
                else if (opcao == 2)
                {
                    Console.WriteLine("Lista de itens comprados");
                    Console.WriteLine($"Preço total dos produtos no carrinho de compra é R${somaCarrinhoDeCompras.ToString("F2")}");
                    Console.WriteLine($"Quantidade de itens no carrinho é {qtdItensCarrinho}");
                    Console.WriteLine("===============================");
                    Console.WriteLine("Tem certeza que deseja fechar a compra? ");
                    Console.WriteLine("[1] Finalizar a compra");
                    Console.WriteLine("[2] Continuar comprando");
                    int opcaoFinalizar = int.Parse(Console.ReadLine());

                    if (opcaoFinalizar == 1)
                    {
                        Console.WriteLine("Lista de opções de pagamento:");
                        Console.WriteLine("[1] À vista");
                        Console.WriteLine("[2] Cartão de crédito");
                        int opcaoPagamento = int.Parse(Console.ReadLine());

                        if (opcaoPagamento == 1)
                        {
                            somaTotalFinal = somaSmartphone + somaNotebook + somaSmarttv + somaTablet;
                            double descontoAVista = somaTotalFinal * 0.9;
                            Console.WriteLine($"A sua compra saiu por R${descontoAVista.ToString("F2")}");
                            break;
                        }
                        else if (opcaoPagamento == 2)
                        {
                            Console.WriteLine("Digite em quantas vezes você deseja fazer a compra: ");
                            Console.WriteLine("[1] 2x no cartão");
                            Console.WriteLine("[2] 3x no cartão");
                            Console.WriteLine("[3] 4x no cartão");
                            int opcaoNumParcelas = int.Parse(Console.ReadLine());
                            double valorParcelas = 0;

                            if (opcao == 1)
                            {
                                valorParcelas = somaTotalFinal / 2;
                                Console.WriteLine($"Sua compra saiu por R${somaTotalFinal.ToString("F2")} em 2 parcelas de R${valorParcelas.ToString("F2")}");
                                break;
                            }
                            else if (opcao == 2)
                            {
                                valorParcelas = somaTotalFinal / 3;
                                Console.WriteLine($"Sua compra saiu por R${somaTotalFinal.ToString("F2")} em 3 parcelas de R${valorParcelas.ToString("F2")}");
                                break;
                            }
                            else if (opcao == 3)
                            {
                                valorParcelas = somaTotalFinal / 4;
                                Console.WriteLine($"Sua compra saiu por R${somaTotalFinal.ToString("F2")} em 4 parcelas de R${valorParcelas.ToString("F2")}");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Atenção! Por favor digite uma opção de parcelamento válida!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Atenção! Digite uma opção de pagamento válida!");
                        }
                    }
                    
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
}