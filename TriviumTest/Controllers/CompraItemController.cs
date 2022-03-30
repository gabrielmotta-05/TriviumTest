using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using TriviumTest.Models;

namespace TriviumTest.Controllers
{
    public class CompraItemController : ApiController
    {
        private static List<CompraItem> compraItem = new List<CompraItem>();

        [HttpGet]
        public List<CompraItem> BuscarCompraItem()
        {
            return compraItem;
        }

        [HttpPost]
        public IHttpActionResult CargaCompraItem(int id, int idCompra, int idProduto, int quantidade)
        {
            compraItem.Add(new CompraItem(id, idCompra, idProduto, quantidade));

            return Ok();
        }

        [HttpDelete]
        public void DeletarCompraItem(int idCompra)
        {
            compraItem.RemoveAt(compraItem.IndexOf(compraItem.First(x => x.IDCompra.Equals(idCompra))));
        }
    }
}
