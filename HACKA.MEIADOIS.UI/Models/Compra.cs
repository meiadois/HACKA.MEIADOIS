using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HACKA.MEIADOIS.UI.Models
{
    public class Compra
    {
        public int CompraId { get; set; }

        public DateTime Data { get; set; }

        virtual public int ForncedorId { get; set; }

        public ICollection<Fornecedor> Fornecedor { get; set; }

    }
}