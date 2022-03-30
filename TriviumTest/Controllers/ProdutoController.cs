using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using TriviumTest.Models;

namespace TriviumTest.Controllers
{
    public class ProdutoController : ApiController
    {
        private static List<Produto> produto = new List<Produto>();

        [HttpGet]
        public List<Produto> BuscarProduto()
        {
            return produto;
        }

        [HttpPost]
        public IHttpActionResult CargaProduto(int id, string nome, double preco)
        {

            produto.Add(new Produto(id, nome, preco));

            return Ok();
        }

        [HttpDelete]
        public void DeletarProduto(string nome)
        {
            produto.RemoveAt(produto.IndexOf(produto.First(x => x.Nome.Equals(nome))));
        }
    }
}
