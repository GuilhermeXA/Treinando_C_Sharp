using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraIMC
{
    class CalculadoraIMC
    {
        public string nome { get; set; }
        public double altura { get; set; }
        public double peso { get; set; }

        public double CalcularIMC(double altura, double peso)
        {
            double resultadoCalculo = peso / (altura * altura);
            return resultadoCalculo;
            
        }

        public string SituacaoIMC(double resultadoCalculo)
        {
            if (resultadoCalculo <= 18.5)
            {
                return "abaixo do peso";
            }
            else if (resultadoCalculo >= 18.6 && resultadoCalculo <= 24.9)
            {
                return " no peso ideal";
            }
            else if (resultadoCalculo >= 25.0 && resultadoCalculo <= 29.9)
            {
                return "acima do peso";
            }
            else if (resultadoCalculo >= 30.0 && resultadoCalculo <= 34.9)
            {
                return " com obesidade grau 1";
            }
            else if (resultadoCalculo >= 35.0 && resultadoCalculo <= 39.9)
            {
                return " com obesidade grau 2";
            }
            else if (resultadoCalculo >= 40.0)
            {
                return " com obesidade grau 3";
            }
            else
            {
                return "valor de imc inválido";
            }
        }

        public string Mensagem()
        {
            double resultadoCalculo = CalcularIMC(altura, peso);
            string situacao = SituacaoIMC(resultadoCalculo);
            return $"Seu IMC é {resultadoCalculo.ToString("F2")} e você está {situacao}.";
        }
    }
}
