using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_de_cobranca.Entities
{
    internal class Financiamento
    {
        public DateTime dataDeVencimento { get; set; }
        public double Valor { get; set; }

        public Financiamento(DateTime dataDeVencimento, double valor)
        {
            this.dataDeVencimento = dataDeVencimento;
            Valor = valor;
        }

        public override string ToString()
        {
            return dataDeVencimento.ToString("dd/MM/yyyy")
                + " - "
                + Valor.ToString("f2", CultureInfo.InvariantCulture);
        }
    }
}
