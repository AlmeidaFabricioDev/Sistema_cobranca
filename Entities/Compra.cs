using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_de_cobranca.Entities
{
    internal class Compra
    {
        public int NumeroCompra { get; set; }
        public DateTime DataCompra { get; set; }
        public double ValorTotal { get; set; }
        public List<Financiamento> Financiamentos { get; set; }

        public Compra()
        {
        }

        public Compra(int numeroCompra, DateTime dataCompra, double valorTotal)
        {
            NumeroCompra = numeroCompra;
            DataCompra = dataCompra;
            ValorTotal = valorTotal;
            Financiamentos = new List<Financiamento>();
        }

        public void AdiconarItens(Financiamento financiamento)
        {
            Financiamentos.Add(financiamento);
        }
    }
}
