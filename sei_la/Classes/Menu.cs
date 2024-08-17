using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace sei_la.Classes
{
    internal class Menu
    {
        private Agencia agencia;

        public Menu()
        {
            this.agencia = new Agencia();
            mostrarMenu();
        }

        public void mostrarMenu()
        {
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("Menu de opções\n");
                Console.WriteLine("Selecione a opção desejada:");
                Console.WriteLine("1. Adicionar Cliente");
                Console.WriteLine("2. Adicionar Viagem");
                Console.WriteLine("3. Realizar Reserva");
                Console.WriteLine("4. Atualizar Reserva");
                Console.WriteLine("5. Listar Clientes");
                Console.WriteLine("6. Listar Viagens");
                Console.WriteLine("7. Listar Reservas");
                Console.WriteLine("8. Listar Reservas por Cliente");
                Console.WriteLine("9. Cancelar Reserva");
                Console.WriteLine("10. Filtrar Viagens por Preço");
                Console.WriteLine("11. Filtrar Viagens por Destino");
                Console.WriteLine("13. Sair");
                Console.Write("\nDigite o número da opção desejada: ");

                string escolha = Console.ReadLine();

                switch (escolha)
                {
                    case "1":

                        agencia.adicionarCliente(createCliente());
                        break;
                    case "2":
                        Viagem viagem = createViagem();
                        agencia.adicionarViagem(viagem);
                        break;
                    case "3":

                        Console.WriteLine("Criar Reserva: ");
                        Reserva reserva = new Reserva(createViagem(), createCliente());
                        agencia.realizarReserva(reserva);
                        break;
                    case "4":
                        Console.WriteLine("Nome do cliente: ");
                        string nome = Console.ReadLine().ToLower();
                        agencia.atualizarReserva(nome, createPagamento());
                        break;
                    case "5":
                        agencia.listarCliente();
                        break;
                    case "6":
                        agencia.listarViagem();
                        break;
                    case "7":
                        agencia.listarReserva();
                        break;
                    case "8":
                        Console.WriteLine("Nome do cliente: ");
                        string nomeReserva = Console.ReadLine().ToLower();
                        agencia.listarReservaPorCliente(nomeReserva);
                        break;
                    case "9":
                        Console.WriteLine("Nome do cliente: ");
                        string nomeCancelado = Console.ReadLine().ToLower();
                        agencia.removerReserva(nomeCancelado);
                        break;
                    case "10":
                        Console.Write("Digite o Preço: ");
                        string input = Console.ReadLine();
                        decimal precoBusca = decimal.Parse(input);
                        agencia.FiltrarViagensPorPreco(precoBusca);
                        break;
                    case "11":
                        
                        Console.Write("Digite o Destino: ");
                        string destinoBusca = Console.ReadLine();
                        agencia.FiltrarViagensPorDestino(destinoBusca);
                        break;
 
                    case "13":
                        Console.WriteLine("Saindo...");
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }

                if (continuar)
                {
                    Console.WriteLine("\nPressione qualquer tecla para continuar...");
                    Console.ReadKey();
                }
            }
        }
        public Viagem createViagem()
        {
            Viagem viagem = null;
            Console.WriteLine("Viagem nacional(digite 1) ou internacional(digite 2) ?: ");
            string tipo = Console.ReadLine().ToLower();
            if (tipo == "1")
            {
                Console.WriteLine("Digite o estado:");
                string estado = Console.ReadLine();
                Console.WriteLine("\nDigite o Destino:");
                string destino = Console.ReadLine();
                Console.Write("Digite o Preco: ");
                string input = Console.ReadLine();
                decimal valor = decimal.Parse(input);

                viagem = new ViagemNacional(estado, destino, valor);

            }
            else
            {
                Console.WriteLine("Digite o Pais:");
                string pais = Console.ReadLine();
                Console.WriteLine("\n Precisa de visto S/N:");
                string visto = Console.ReadLine().ToLower();
                bool precisa = false;
                if (visto == "s")
                {
                    precisa = true;
                }
                string destino = Console.ReadLine();
                Console.Write("Digite o Preco: ");
                string input = Console.ReadLine();
                decimal valor = decimal.Parse(input);
                viagem = new ViagemInternacional(pais, precisa, destino, valor);
            }
            return viagem;
        }
        public Cliente createCliente()
        {
            Console.WriteLine("Digite nome do cliente:");
            string nome = Console.ReadLine();
            Console.WriteLine("\nDigite email do cliente:");
            string email = Console.ReadLine();
            Cliente cliente = new Cliente(nome, email);
            return cliente;
        }
        public Pagamento createPagamento()
        {
            Pagamento pagamento;
            Console.WriteLine("Cartão(digite 1) ou boleto(digite 2) ?: ");
            string tipo = Console.ReadLine().ToLower();
            if(tipo == "1")
            {
                Console.WriteLine("Numero do cartão: ");
                string numero = Console.ReadLine().ToLower();
                Console.Write("Digite o Valor: ");
                string input = Console.ReadLine();
                decimal valor = decimal.Parse(input);
                pagamento = new PagementoCartao(numero, valor);
            }
            else
            {
                Console.WriteLine("Numero do boleto: ");
                string numero = Console.ReadLine().ToLower();
                Console.Write("Digite o Valor: ");
                string input = Console.ReadLine();
                decimal valor = decimal.Parse(input);
                pagamento = new PagamentoBoleto(numero, valor);

            }
            return pagamento;
        }
    }
}
