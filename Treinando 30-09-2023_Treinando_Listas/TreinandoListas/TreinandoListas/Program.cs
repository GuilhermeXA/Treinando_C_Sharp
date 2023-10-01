namespace TreinandoListas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaração e Inicialização:
            List<int> numeros = new List<int>(); // Lista vazia de inteiros

            List<string> nomes = new List<string>
            {
                "Alice",
                "Bob",
                "Charlie"
            };  // Inicialização com valores

            //Adição e Remoção de Elementos:
            numeros.Add(10);  // Adiciona o número 10 à lista
            numeros.AddRange(new List<int> { 20, 30, 40 });  // Adiciona uma coleção à lista

            nomes.Remove("Bob");  // Remove o elemento "Bob" da lista

            //Acesso aos Elementos:
            int primeiroNumero = numeros[0];  // Acessa o primeiro elemento da lista

            foreach (string nome in nomes)
            {
                Console.WriteLine(nome);  // Iteração sobre os elementos da lista
            }
        }
    }
}