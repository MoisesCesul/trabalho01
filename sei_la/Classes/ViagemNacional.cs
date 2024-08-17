using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sei_la.Classes
{
    internal class ViagemNacional : Viagem
    {
        public string Estado;
        public ViagemNacional(string estado, string destino, decimal preco) : base(destino, preco)
        {
            Estado = estado;
        }

        public override void ExibirDetalhes()
        {
            Console.WriteLine($"Estado: {Estado}, Destino: {base.Destino}, Preço: {base.Preco}");
        }
    }
}
