using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_de_cobranca.Services
{
    interface IServicoDePagamento
    {
        double taxaPagamento(double valor);
        double jurosParcela(double valor, int meses);
    }

}
