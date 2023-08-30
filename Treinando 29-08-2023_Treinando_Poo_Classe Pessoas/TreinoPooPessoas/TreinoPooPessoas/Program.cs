using System;

class Program
{
    static void Main(string[] args)
    {
        Pessoa pessoa = new Pessoa();

        Console.Write("Digite o nome da pessoa: ");
        pessoa.Nome = Console.ReadLine();

        Console.Write("Digite a data de nascimento (yyyy-MM-dd): ");
        if (DateTime.TryParse(Console.ReadLine(), out DateTime dataNascimento))
        {
            pessoa.DataNascimento = dataNascimento;

            int idade = pessoa.CalcularIdade();
            Console.WriteLine($"{pessoa.Nome} tem {idade} anos.");
        }
        else
        {
            Console.WriteLine("Data de nascimento inválida.");
        }
    }
}