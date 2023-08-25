using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PjGabriellyMaroli.Models;

namespace PjGabriellyMaroli.Data
{
    public class AppDbContext:
        IdentityDbContext <Psicologo>
    {
        public AppDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Psicologo> Psicologos { get; set; }
     }
}
