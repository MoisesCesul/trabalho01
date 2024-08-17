using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sei_la
{
    internal abstract class Viagem : IDetalhavel
    {
        protected Viagem(string destino, decimal preco)
        {
            Destino = destino;
            Preco = preco;
        }

    

        public  string Destino { get; set; }
        public  decimal Preco { get; set; }

        public abstract void ExibirDetalhes();
    }
}
