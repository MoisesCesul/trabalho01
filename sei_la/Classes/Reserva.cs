using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sei_la.Classes
{
    internal class Reserva
    {
        public Reserva(Viagem viagem, Cliente cliente)
        {
            Viagem = viagem;
            Cliente = cliente;
            Pagamentos = new List<Pagamento>();
        }

        public Viagem Viagem { get; set; }

        public Cliente Cliente { get; set; }

        public List<Pagamento> Pagamentos { get; set; }

        public void AdicionarPagamento(Pagamento pagamento)
        {
            Pagamentos.Add(pagamento);
        }
        public void ExibirDetalhes()
        {
            Viagem.ExibirDetalhes();
            Cliente.ExibirDetalhes();
            foreach (Pagamento p in Pagamentos)
            {
                p.ExibirDetalhes();
            }
        }
    }
}
