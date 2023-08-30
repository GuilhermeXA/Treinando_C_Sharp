using System;

class Pessoa
{
    public string Nome { get; set; }
    public DateTime DataNascimento { get; set; }

    public int CalcularIdade()
    {
        DateTime dataAtual = DateTime.Now;
        int idade = dataAtual.Year - DataNascimento.Year;

        if (dataAtual.Month < DataNascimento.Month ||
            (dataAtual.Month == DataNascimento.Month && dataAtual.Day < DataNascimento.Day))
        {
            idade--;
        }

        return idade;
    }
}