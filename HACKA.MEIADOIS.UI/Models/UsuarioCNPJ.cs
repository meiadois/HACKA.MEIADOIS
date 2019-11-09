using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HACKA.MEIADOIS.UI.Models
{
    [Table(nameof(UsuarioCNPJ))]
    public class UsuarioCNPJ
    {
        [Key]
        public int Id { get; set; }
        [Column("cnpj", TypeName = "varchar(15)")]
        public string CNPJ { get; set; }
        [Column("senha", TypeName = "varchar(50)")]
        public string Senha { get; set; }
    }
}