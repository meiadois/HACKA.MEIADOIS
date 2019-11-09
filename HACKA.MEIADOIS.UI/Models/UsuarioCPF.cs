using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HACKA.MEIADOIS.UI.Models
{
    [Table(nameof(UsuarioCPF))]
    public class UsuarioCPF
    {
        [Key]
        public int Id { get; set; }
        [Column("cpf",TypeName = "varchar(11)")]
        public string CPF { get; set; }
        [Column("senha", TypeName = "varchar(50)")]
        public string Senha { get; set; }
    }
}