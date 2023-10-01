namespace TreinandoPilhaFila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pilha e Fila:
            Stack<string> pilha = new Stack<string>();
            pilha.Push("A");
            pilha.Push("B");
            string topoDaPilha = pilha.Pop();  // Remove e retorna o elemento no topo da pilha

            Queue<int> fila = new Queue<int>();
            fila.Enqueue(1);
            fila.Enqueue(2);
            int primeiroDaFila = fila.Dequeue();  // Remove e retorna o primeiro elemento da fila

        }
    }
}