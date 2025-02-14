using apicsharp.Models;
using Microsoft.EntityFrameworkCore;

namespace apicsharp.Database
{
    public class MyDbContext : DbContext
    {
        public DbSet<Teste> Teste { get; set; } = null!;
        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseNpgsql("Server=localhost;Port=5432;Database=fiap;User Id=postgres;Password=rafael04;");
    }
}
