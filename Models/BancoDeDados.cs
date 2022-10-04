using Microsoft.EntityFrameworkCore;

namespace CrudProdutosv4.Models
{
    public class BancoDeDados : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server=DESKTOP-CM8F2OC\SQLEXPRESS;Database=; Integrated Security=True");
        }
    }
    
}
