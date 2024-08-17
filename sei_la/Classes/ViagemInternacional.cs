using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace sei_la.Classes
{
    internal class ViagemInternacional : Viagem
    {
        public ViagemInternacional(string pais, bool precisaVisto,string destino,decimal preco) : base( destino,  preco)
        {
            Pais = pais;
            PrecisaVisto = precisaVisto;
        }

        public override void ExibirDetalhes()
        {
            string precisa = (PrecisaVisto) ? "Sim" : "não";
            Console.WriteLine($"Pais: {Pais}, Precisa de visto: {precisa}, Destino: {base.Destino}, Preço: {base.Preco}");
        }
        public string Pais { get; set; }
        public bool PrecisaVisto { get; set; }
    }
}
