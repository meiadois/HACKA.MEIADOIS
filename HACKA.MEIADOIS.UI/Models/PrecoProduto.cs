using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HACKA.MEIADOIS.UI.Models
{
    public class PrecoProduto
    {
        public int Id { get; set; }

        public string NomeProduto { get; set; }

        public string CategoriaProduto { get; set; }

        public double PrecoCompra { get; set; }

    }
}