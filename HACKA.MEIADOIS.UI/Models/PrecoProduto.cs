using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HACKA.MEIADOIS.UI.Models
{
    [Table(nameof(PrecoProduto))]
    public class PrecoProduto
    {
        [Key]
        public int Id { get; set; }

        public int IdProduto { get; set; }

        [Column("preco_compra", TypeName = "decimal")]
        public double PrecoCompra { get; set; }

        [Column("data_compra", TypeName = "date")]
        public DateTime DataCompra { get; set; }

    }
}