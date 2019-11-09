using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HACKA.MEIADOIS.UI.Models
{
    [Table(nameof(Compra))]
    public class Compra
    {
        [Key]
        public int Id { get; set; }

        [Column("data_compra", TypeName = "date")]
        public DateTime Data { get; set; }

        [Column("fornecedor_id")]
        public virtual int FornecedorId { get; set; }

        public virtual ICollection<Fornecedor> Fornecedores { get; set; }

    }
}