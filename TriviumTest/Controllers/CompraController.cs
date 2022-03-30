using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using TriviumTest.Models;

namespace TriviumTest.Controllers
{
    public class CompraController : ApiController
    {
        private static List<Compra> compras = new List<Compra>();

        [HttpGet]
        public List<Compra> BuscarCompra()
        {
            return compras;
        }

        [HttpPost]
        public IHttpActionResult CargaCompra(int id, int idCliente)
        {

            compras.Add(new Compra(id, idCliente));

            return Ok();
        }

        [HttpDelete]
        public void DeletarCompra(int idCliente)
        {
            compras.RemoveAt(compras.IndexOf(compras.First(x => x.IDClient.Equals(idCliente))));
        }
    }
}
