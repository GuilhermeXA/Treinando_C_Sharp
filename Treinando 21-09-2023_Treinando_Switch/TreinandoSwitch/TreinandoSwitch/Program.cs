namespace TreinandoSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Digite um número: ");
            numero = int.Parse(Console.ReadLine());

            switch (numero)
            {
                case 1:
                    {
                        Console.WriteLine("A variável tem o valor 1");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("A variável tem o valor 2");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("A variável tem o valor 3");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("A variável tem o valor 4");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("A variável tem o valor 5");
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("A variável tem o valor 6");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("A variável tem o valor default");
                        break;
                    }
            }
            Console.WriteLine(numero);
        }
    }
}
