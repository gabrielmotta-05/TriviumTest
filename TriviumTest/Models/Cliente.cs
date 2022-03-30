using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace TriviumTest.Models
{
    public class Cliente
    {
        public int ID { get; set; }
        public string Nome { get; set; }

        public string Telefone { get; set; }

        public string Endereco { get; set; }

        public Cliente(int id, string nome,string telefone, string endereco)
        {
            this.ID = id;
            this.Nome = nome;
            this.Telefone = telefone;
            this.Endereco = endereco;
        }
    }
}