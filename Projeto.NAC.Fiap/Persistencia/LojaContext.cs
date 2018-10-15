using Projeto.NAC.Fiap.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Projeto.NAC.Fiap.Persistencia
{
    public class LojaContext: DbContext
    {
        public DbSet<Venda> Vendas { get; set; }
    }
}