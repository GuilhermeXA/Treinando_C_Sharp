using System;
using System.IO;

namespace SistemaCadtxt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Digite o nome (ou digite 'sair' para sair): ");
                string nome = Console.ReadLine();

                if (nome.ToLower() == "sair")
                    break;

                Console.WriteLine("Digite o endereço: ");
                string endereco = Console.ReadLine();

                Console.WriteLine("Digite o telefone: ");
                string telefone = Console.ReadLine();

                Console.WriteLine("Digite o email: ");
                string email = Console.ReadLine();

                string registro = $"{nome}, {endereco}, {telefone}, {email}";

                // Escreve o registro no arquivo de texto
                using (StreamWriter file = new StreamWriter("registros.txt", true))
                {
                    file.WriteLine(registro);
                }

                Console.WriteLine("Registro adicionado!");
            }
        }
    }
}