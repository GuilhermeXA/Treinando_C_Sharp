namespace SistemaCalcIMCnoTXT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de IMC");
            Console.WriteLine("Digite seu nome:");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite sua idade:");
            int idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite sua altura (em metros):");
            double altura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite seu peso (em quilogramas):");
            double peso = Convert.ToDouble(Console.ReadLine());

            double imc = CalcularIMC(peso, altura);
            string dataRegistro = DateTime.Now.ToString("dd/MM/yyyy");

            Console.WriteLine("Seu IMC é: " + imc.ToString("F2"));

            string situacao = ObterSituacaoIMC(imc);
            Console.WriteLine("Sua situação é: " + situacao);

            GravarRegistro(nome, idade, altura, peso, imc, situacao, dataRegistro);

            Console.WriteLine("Registro salvo em 'registro_imc.txt'");
        }
        static double CalcularIMC(double peso, double altura)
        {
            return peso / (altura * altura);
        }

        static string ObterSituacaoIMC(double imc)
        {
            if (imc < 18.5)
            {
                return "Abaixo do peso";
            }
            else if (imc >= 18.5 && imc < 24.9)
            {
                return "Peso normal";
            }
            else if (imc >= 25 && imc < 29.9)
            {
                return "Sobrepeso";
            }
            else if (imc >= 30 && imc < 34.9)
            {
                return "Obesidade Grau I";
            }
            else if (imc >= 35 && imc < 39.9)
            {
                return "Obesidade Grau II";
            }
            else
            {
                return "Obesidade Grau III";
            }
        }

        static void GravarRegistro(string nome, int idade, double altura, double peso, double imc, string situacao, string dataRegistro)
        {
            string registro = $"{nome}, {idade} anos, altura: {altura}m, peso: {peso}kg, IMC: {imc.ToString("F2")}, Situação: {situacao}, Data: {dataRegistro}";

            using (StreamWriter file = new StreamWriter("registro_imc.txt", true))
            {
                file.WriteLine(registro);
            }
        }
    }
}