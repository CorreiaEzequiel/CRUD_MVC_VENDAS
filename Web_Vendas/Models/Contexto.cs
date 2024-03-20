using Microsoft.EntityFrameworkCore;
namespace Web_Vendas.Models
{
    public class Contexto : DbContext

    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {


        }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Vendedor>Vendedores { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>()
                .Property(p => p.Preco)
                .HasColumnType("decimal(18, 2)");
        }
    }
}
