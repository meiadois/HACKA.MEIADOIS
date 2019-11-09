using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HACKA.MEIADOIS.UI.Models
{
    public class Historico
    {
        public int Id { get; set; }

        public int id_produto { get; set; }

        public string nome_produto { get; set; }

        public string categoria_produto { get; set; }

        public string preço_produto { get; set; }

        public DateTime data_registro { get; set; }
    }
}