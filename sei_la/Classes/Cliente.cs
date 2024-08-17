using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sei_la.Classes
{
    internal class Cliente : IReservavel
    {
        public string Nome;
        public string Email;

        public Cliente(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine($"Nome: {Nome}, Email: {Email}");
        }
    }
}
