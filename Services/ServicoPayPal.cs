using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_de_cobranca.Services
{
    class ServicoPayPal : IServicoDePagamento
    {
        private const double taxaDePagamento = 0.02;
        private const double jurosDeParcela = 0.01;

        public double jurosParcela(double total, int meses)
        {
            return total * jurosDeParcela * meses;
        }

        public double taxaPagamento(double valor)
        {
            return valor * taxaDePagamento;
        }

      

    }
}
