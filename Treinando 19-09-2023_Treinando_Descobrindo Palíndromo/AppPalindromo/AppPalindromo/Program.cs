namespace AppPalindromo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a palavra: ");
            string original = Console.ReadLine();
            string invertida = InverterString(original);

            if (original == invertida)
            {
                Console.WriteLine("A palavra " + original + " é um palíndromo!");
            }
            else
            {
                Console.WriteLine("A palavra "+original+" não é um palíndromo!");
            }
        }
        static string InverterString(string input)
        {
            char[] caracteres = input.ToCharArray();
            Array.Reverse(caracteres);
            return new string(caracteres);
        }
    }
}