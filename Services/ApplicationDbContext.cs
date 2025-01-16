using EstagioProject.Models;
using Microsoft.EntityFrameworkCore;

namespace EstagioProject.Services
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) 
        { 
        
        }
        public DbSet<Vaga> Vagas { get; set; }
    }
}
