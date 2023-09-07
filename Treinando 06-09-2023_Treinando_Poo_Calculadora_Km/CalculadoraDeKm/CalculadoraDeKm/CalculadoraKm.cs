using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDeKm
{
    class CalculadoraDeKm
    {
        public string Nome { get; set; }
        
        public double Distancia { get; set; }

        public double Tempo { get; set; }

        public double Velocidade(double distancia, double tempo)
        {
            Distancia = distancia;
            Tempo = tempo;
            double km = Distancia / Tempo;
            return km;
        }

        public override string ToString()
        {
            return "O veículo "
                +Nome+" percorreu a distância de "
                +Distancia.ToString("F2") + "km gastando "
                +Tempo.ToString("F2") + " horas com isso a velocidade média foi de "
                +Velocidade(Distancia, Tempo).ToString("F2") + "km/h";
        }
    }
}
