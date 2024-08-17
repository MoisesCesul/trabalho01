using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sei_la.Classes
{
    internal class Agencia
    {
        private List<Viagem> viagens;

        private List<Cliente> clientes;

        private List<Reserva> reservas;
        public Agencia()
        {
            viagens = new List<Viagem>();
            clientes = new List<Cliente>();
            reservas = new List<Reserva>();
        }

        public void adicionarCliente(Cliente cliente)
        {
            clientes.Add(cliente);
        }

        public void adicionarViagem(Viagem viagem) {
        
            viagens.Add(viagem);
        }
        public void listarCliente()
        {
            foreach (var cliente in clientes)
            {
                if(cliente != null) cliente.ExibirDetalhes();
                else { Console.WriteLine("Não tem cliente"); }
            }
        }
        public void listarViagem()
        {
            foreach (var viagem in viagens)
            {
                if (viagem != null)
                {
                    viagem.ExibirDetalhes();
                }
                else
                {
                    Console.WriteLine("Sem viagens");
                }
            }
        }

        public void realizarReserva(Reserva reserva)
        {
            if (reserva == null) Console.WriteLine("Reserva invalida");
            else
            {
                reservas.Add(reserva);
            }
        }

        public void listarReserva()
        {
            foreach (var reserva in reservas)
            {
                if (reserva != null)
                {
                    reserva.ExibirDetalhes();
                }
                else
                {
                    Console.WriteLine("Sem reserva");
                }
            }
        }

        public void atualizarReserva(string cliente,Pagamento pagamento)
        {
            bool encontrado = false;
            foreach(var reserva in reservas)
            {
                if(reserva.Cliente.Nome == cliente)
                {
                    encontrado = true;
                    reserva.Pagamentos.Add(pagamento);
                }
            }
            if (!encontrado) { Console.WriteLine("Cliente não encontrado"); } else { Console.WriteLine("Atualizado Reserva"); }
        }
        public void listarReservaPorCliente(string cliente)
        {
            foreach(var reserva in reservas)
            {
                if (reserva.Cliente.Nome.Equals(cliente))
                {
                    reserva.ExibirDetalhes();
                }
            }
        }

        public void removerReserva(string cliente)
        {
            int posicao = -1;
            int count = 0;
            foreach (var reserva in reservas)
            {
                if (reserva.Cliente.Nome.ToLower() == cliente.ToLower())
                {
                    posicao = count;
                    break;
                }
                count++;
            }

            if (posicao != -1)
            {
                reservas.RemoveAt(posicao);
            }
            else
            {
                Console.WriteLine("Reserva não encontrada para o cliente especificado.");
            }
        }
        public void FiltrarViagensPorPreco(decimal precoMaximo)
        {
             var viagensEncontradas = viagens.Where(v => v.Preco <= precoMaximo).ToList();
            foreach(var viagem  in viagensEncontradas)
            {
                viagem.ExibirDetalhes();
            }
        }
        public void FiltrarViagensPorDestino(string destino)
        {
            var viagensEncontradas = viagens.Where(v => v.Destino.Equals(destino, StringComparison.OrdinalIgnoreCase)).ToList();
            foreach (var viagem in viagensEncontradas)
            {
                viagem.ExibirDetalhes();
            }
        }

    }
}


