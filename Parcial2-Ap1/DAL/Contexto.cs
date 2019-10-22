using Parcial2_Ap1.Entitdades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_Ap1.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Categorias> Categoria { get; set; }
        public DbSet<Factura> Factura { get; set; }
        public Contexto() : base("ConStr") { }
    }
}
