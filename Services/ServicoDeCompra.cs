using sistema_de_cobranca.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_de_cobranca.Services
{
    internal class ServicoDeCompra
    {

        private IServicoDePagamento _servicoDePagamento;

        public ServicoDeCompra(IServicoDePagamento servicoDePagamento)
        {
            _servicoDePagamento = servicoDePagamento;
        }

        public void gerarCompra(Compra compra, int meses)
        {
            double basicQuota = compra.ValorTotal / meses;
            for (int i = 1; i <= meses; i++)
            {
                DateTime data = compra.DataCompra.AddMonths(i);
                double cotaAtualizacao = basicQuota + _servicoDePagamento.jurosParcela(basicQuota, i);
                double cotaCompleta = cotaAtualizacao + _servicoDePagamento.taxaPagamento(cotaAtualizacao);
                compra.AdiconarItens(new Financiamento(data, cotaCompleta));
            }
        }
    }
}
