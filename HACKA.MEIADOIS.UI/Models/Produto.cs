using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HACKA.MEIADOIS.UI.Models
{
    [Table(nameof(Produto))]
    public class Produto
    {
        [Key]
        public int Id { get; set; }
        [Column("nome", TypeName = "varchar(50)")]
        public string Nome { get; set; }
        [Column("categoria", TypeName = "varchar(50)")]
        public string Categoria { get; set; }
        [Column("preco_medio", TypeName = "decimal")]
        public double PrecoMedio { get; set; }
    }
}