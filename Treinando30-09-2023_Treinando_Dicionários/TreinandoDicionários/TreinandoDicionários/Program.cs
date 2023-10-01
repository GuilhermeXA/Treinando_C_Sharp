namespace TreinandoDicionários
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dicionário:
            Dictionary<string, int> idadePorNome = new Dictionary<string, int>();

            idadePorNome["Alice"] = 25;  // Adiciona uma entrada ao dicionário
            int idadeDoBob = idadePorNome["Bob"];  // Obtém o valor associado à chave "Bob"

        }
    }
}