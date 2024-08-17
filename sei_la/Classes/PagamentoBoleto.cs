using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sei_la.Classes
{
    internal class PagamentoBoleto : Pagamento
    {
        public string NumeroBoleto;

        public PagamentoBoleto(string numeroBoleto,decimal valor) : base(valor)
        {
            NumeroBoleto = numeroBoleto;
        }

        public override void ExibirDetalhes()
        {
            Console.WriteLine($"Boleto: {NumeroBoleto}, Valor: {base.Valor}");
        }
    }
}
