using Microsoft.EntityFrameworkCore;

namespace APICore.Model
{
    public class ApiDbContext : DbContext
    {

        public ApiDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Fornecedor> Fornecedores { get; set; }
    }
}