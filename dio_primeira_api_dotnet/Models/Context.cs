using Microsoft.EntityFrameworkCore;

namespace dio_primeira_api_dotnet.Models
{
    public class Context : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=CursoMvc;Trusted_Connection=True;");
        }
    }
}