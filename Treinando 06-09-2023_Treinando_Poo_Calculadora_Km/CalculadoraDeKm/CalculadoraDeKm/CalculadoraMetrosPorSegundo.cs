using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDeKm
{
    class CalculadoraMetrosPorSegundo
    {
        public string Nome { get; set; }
        public double Distancia { get; set; }
        public double Tempo { get; set; }

        public double VelocidadeMetrosPorSegundo(double distancia, double tempo)
        {
            Distancia = distancia * 1000; // Converta a distância para metros
            Tempo = tempo * 3600; // Converta o tempo para segundos
            double metrosPorSegundo = Distancia / Tempo;
            return metrosPorSegundo;
        }

        public override string ToString()
        {
            return "O veículo "
                + Nome + " percorreu a distância de "
                + Distancia.ToString("F2") + " metros gastando "
                + Tempo.ToString("F2") + " segundos. A velocidade média foi de "
                + VelocidadeMetrosPorSegundo(Distancia, Tempo).ToString("F2") + " m/s";
        }
    }
}
