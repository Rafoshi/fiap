using apicsharp.Models;
using Microsoft.EntityFrameworkCore;

namespace apicsharp.Database
{
    public class MyDbContext : DbContext
    {
        public DbSet<Teste> Teste { get; set; } = null!;
        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseNpgsql("Host=postgres_db;Port=5432;Username=postgres;Password=123;Database=fiap");
    }
}
