using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HACKA.MEIADOIS.UI.Models
{
    public class Compra
    {
        public int Id { get; set; }

        public DateTime Data { get; set; }

        virtual public int FornecedorId { get; set; }

        public ICollection<Fornecedor> Fornecedores { get; set; }

    }
}