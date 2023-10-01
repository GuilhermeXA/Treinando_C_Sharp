namespace TreinandoArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaração e Inicialização:
            int[] numerosArray = new int[5];  // Array de inteiros com tamanho 5

            string[] diasDaSemana = { "Segunda", "Terça", "Quarta", "Quinta", "Sexta", "Sábado", "Domingo" };  // Inicialização com valores


            //Acesso e Modificação de Elementos:
            numerosArray[0] = 1;  // Atribui o valor 1 ao primeiro elemento do array

            string terceiroDia = diasDaSemana[2];  // Acessa o terceiro elemento do array


            //Métodos Úteis:
            int tamanho = numerosArray.Length;  // Obtém o comprimento do array

            int[] copiaArray = (int[])numerosArray.Clone();  // Copia o array

        }
    }
}