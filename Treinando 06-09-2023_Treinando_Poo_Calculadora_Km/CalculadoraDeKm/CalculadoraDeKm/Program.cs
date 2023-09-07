namespace CalculadoraDeKm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculadoraDeKm calculo = new CalculadoraDeKm();

            Console.Write("Digite o nome do veículo: ");
            string nome = Console.ReadLine();
            Console.Write("Digite a distância percorrida em km: ");
            double distancia = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o tempo gasto em horas: ");
            double tempo  = Convert.ToDouble(Console.ReadLine());

            calculo.Nome = nome;
            calculo.Distancia = distancia;
            calculo.Tempo = tempo;

            calculo.Velocidade(distancia, tempo);

            Console.WriteLine(calculo.ToString());

            //------------------------------------------------------------
            //Metros por segundo agora

            CalculadoraMetrosPorSegundo calculo2 = new CalculadoraMetrosPorSegundo();

            Console.Write("Digite o nome do veículo: ");
            string nome2 = Console.ReadLine();
            Console.Write("Digite a distância percorrida em km: ");
            double distancia2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o tempo gasto em horas: ");
            double tempo2 = Convert.ToDouble(Console.ReadLine());

            calculo2.Nome = nome2;
            calculo2.Distancia = distancia2;
            calculo2.Tempo = tempo2;

            calculo2.VelocidadeMetrosPorSegundo(distancia2, tempo2);

            Console.WriteLine(calculo2.ToString());
        }
    }
}