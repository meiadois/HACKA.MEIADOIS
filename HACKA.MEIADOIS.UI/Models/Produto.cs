using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HACKA.MEIADOIS.UI.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; }

        public string nome { get; set; }

        public string categoria { get; set; }

        public double preço_medio { get; set; }
    }
}