using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TriviumTest.Models
{
    public class Compra
    {
        public int ID { get; set; }
        public int IDClient { get; set; }

        public Compra(int id, int idCliente)
        {
            this.ID = id;
            this.IDClient = idCliente;
        }
    }
}