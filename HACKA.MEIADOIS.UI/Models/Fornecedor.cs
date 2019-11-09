using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HACKA.MEIADOIS.UI.Models
{
    public class Fornecedor
    {
        public int FornecedorId { get; set; }
        public string NomeFantasia { get; set; }
        public string Municipio { get; set; }
        public string Bairro { get; set; }
    }
}