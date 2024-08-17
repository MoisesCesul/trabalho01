using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sei_la.Classes
{
    internal class PagementoCartao : Pagamento
    {
        public PagementoCartao(string numeroCartao,decimal valor) : base(valor)
        {
            NumeroCartao = numeroCartao;
        }

        public string NumeroCartao { get; set; }



        
        public override void ExibirDetalhes()
        {
            Console.WriteLine($"Numero do cartão: {NumeroCartao}, Valor: {base.Valor}");
        }
    }
}
