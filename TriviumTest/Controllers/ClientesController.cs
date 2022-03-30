using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using TriviumTest.Models;

namespace TriviumTest.Controllers
{
    public class ClientesController : ApiController
    {
        private static List<Cliente> clientes = new List<Cliente>();

        [HttpGet]
        public List<Cliente> BuscarClientes()
        {
            return clientes;
        }

        [HttpPost]
        public IHttpActionResult CargaCliente(int id ,string nome, string telefone, string endereco)
        {
            //VERIFICANDO SE VEM NULO SOMENTE NO NOME 
            if (!string.IsNullOrEmpty(nome))
            {
                clientes.Add(new Cliente(id, nome, telefone, endereco));
            }

            return Ok();
        }
        
        [HttpDelete]
        public void DeletarCliente(string nome)
        {
            clientes.RemoveAt(clientes.IndexOf(clientes.First(x => x.Nome.Equals(nome))));
        }

    }
}
