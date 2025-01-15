using Microsoft.EntityFrameworkCore;
using PeojetoEstagio.Models;

namespace PeojetoEstagio.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Vaga> Vagas { get; set; }



    }
}
