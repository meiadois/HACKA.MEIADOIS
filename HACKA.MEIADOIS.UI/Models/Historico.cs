using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HACKA.MEIADOIS.UI.Models
{
    [Table(nameof(Historico))]
    public class Historico
    {
        [Key]
        public int Id { get; set; }

        [Column("produto_id")]
        public int ProdutoId { get; set; }

        [Column("preco_produto", TypeName = "decimal")]
        public float PrecoProduto { get; set; }

        [Column("data_registro", TypeName = "date")]
        public DateTime DataRegistro { get; set; }
    }
}