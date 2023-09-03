using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinandoPooCalcTraba
{
    class CalculadoraTrabalhista
    {
        public string Nome { get; set; }
        public double Salario { get; set; }
    
        public double CalcINSS(double salario)
        {
            double valImposto = 0;
            salario = Salario;
            if (salario <= 1320)
            {
                valImposto = salario * 0.075;
            }
            else if (salario <= 2571)
            {
                valImposto = salario * 0.09;
            }
            else if (salario <= 3856)
            {
                valImposto = salario * 0.12;
            }
            else if (salario <= 7507)
            {
                valImposto = salario * 0.14;
            }
            else
            {
                valImposto = 0;
            }
            return valImposto;
        }
    }
}
