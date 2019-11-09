using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace HACKA.MEIADOIS.UI.Data
{
    public class HackaMeiaDoisDataContext : DbContext
    {

        public HackaMeiaDoisDataContext() : base("devConn")
        {

        }

        public System.Data.Entity.DbSet<HACKA.MEIADOIS.UI.Models.UsuarioCPF> UsuarioCPF { get; set; }

        public System.Data.Entity.DbSet<HACKA.MEIADOIS.UI.Models.UsuarioCNPJ> UsuarioCNPJ { get; set; }

        public System.Data.Entity.DbSet<HACKA.MEIADOIS.UI.Models.Compra> Compras { get; set; }

        public System.Data.Entity.DbSet<HACKA.MEIADOIS.UI.Models.Historico> Historicoes { get; set; }

        public System.Data.Entity.DbSet<HACKA.MEIADOIS.UI.Models.Fornecedor> Fornecedors { get; set; }

        public System.Data.Entity.DbSet<HACKA.MEIADOIS.UI.Models.Produto> Produtoes { get; set; }

        public System.Data.Entity.DbSet<HACKA.MEIADOIS.UI.Models.PrecoProduto> PrecoProdutoes { get; set; }
    }
}