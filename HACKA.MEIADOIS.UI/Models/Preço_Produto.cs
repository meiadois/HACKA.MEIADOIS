using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HACKA.MEIADOIS.UI.Models
{
    public class Preço_produto
    {
        public int Id { get; set; }

        public string nome_Produto { get; set; }

        public string categoria_Produto { get; set; }

        public double preço_em_Compra { get; set; }

    }
}