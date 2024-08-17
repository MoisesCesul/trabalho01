using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sei_la
{
    internal abstract class Pagamento : IDetalhavel
    {
        protected Pagamento(decimal valor)
        {
            Valor = valor;
        }

        public decimal Valor { get; set; }

        public abstract void ExibirDetalhes();
       
    }

   
    
}
