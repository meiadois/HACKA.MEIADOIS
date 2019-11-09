using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HACKA.MEIADOIS.UI.Models
{
    [Table(nameof(Fornecedor))]
    public class Fornecedor
    {
        [Key]
        public int Id { get; set; }
        [Column("nome_fantasia", TypeName = "decimal")]
        public string NomeFantasia { get; set; }
        [Column("municipio", TypeName = "varchar(50)")]
        public string Municipio { get; set; }
        [Column("bairro", TypeName = "varchar(50)")]
        public string Bairro { get; set; }
    }
}