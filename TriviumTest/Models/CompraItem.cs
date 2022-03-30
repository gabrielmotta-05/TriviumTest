using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TriviumTest.Models
{
    public class CompraItem
    {
        public int ID { get; set; }
        public int IDCompra { get; set; }
        public int IDProduto { get; set; }
        public int Quantidade { get; set; }


        public CompraItem(int id, int idCompra, int idProduto, int quantidade)
        {
            this.ID = id;
            this.IDCompra = idCompra;
            this.IDProduto = idProduto;
            this.Quantidade = quantidade;
        }
    }
}