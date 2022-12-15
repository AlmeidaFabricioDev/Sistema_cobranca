using sistema_de_cobranca.Entities;
using sistema_de_cobranca.Services;
using System.Globalization;
namespace sistema_de_cobranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Compra Número: ");
            int numCompra = int.Parse(Console.ReadLine());
            Console.Write("Data (dd/MM/yyyy): ");
            DateTime dataCompra = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Valor: ");
            double valorTotal = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Parcelas: ");
            int parcelas = int.Parse(Console.ReadLine());
            Compra compra = new Compra(numCompra, dataCompra, valorTotal);


            ServicoDeCompra servicoCompra = new ServicoDeCompra(new ServicoPayPal());
            servicoCompra.gerarCompra(compra, parcelas);

            Console.WriteLine("Financiamento:");

            int i = 0;
            foreach (Financiamento financiamento in compra.Financiamentos)
            {
               
                Console.WriteLine((i+1)+"º Parcela "+financiamento);
                i = i + 1;
                
            }
        }
    }
}