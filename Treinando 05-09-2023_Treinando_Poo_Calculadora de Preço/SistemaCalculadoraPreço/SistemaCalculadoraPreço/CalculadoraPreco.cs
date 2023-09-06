using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCalculadoraPreço
{
    class CalculadoraPreco
    {
        public string Nome { get; set; }
        public double CustoFixo { get; set; }

        public double CustoVariavel { get; set; }
        public double MargemLucro { get; set; }

        public double CalculoDecimalMargemDeLucro(double margemLucro)
        {
            this.MargemLucro = margemLucro;
            double margemDeLucro = margemLucro / 100;
            return margemDeLucro;
        }

        public double CalcPreco(double custoFixo, double custoVariavel)
        {
            double objetivoMargem = CalculoDecimalMargemDeLucro(MargemLucro);
            double resultadoObjetivoMargem = (custoFixo + custoVariavel) * objetivoMargem;
            double preco = custoFixo + custoVariavel + resultadoObjetivoMargem;
            return preco;
        }
    }
}
