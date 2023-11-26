using GerencimanetoMercadorias.Models;
using Microsoft.EntityFrameworkCore;

namespace GerencimanetoMercadorias.Context
{
    public class MercadoriaContext : DbContext
    {
        public MercadoriaContext(DbContextOptions<MercadoriaContext> options) : base(options) { }

        public DbSet<Categorias> Categorias { get; set; }
        public DbSet<Produtos> Produtos { get; set; }
    }
}
