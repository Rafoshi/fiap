using apicsharp.Database;
using apicsharp.Models;
using Microsoft.EntityFrameworkCore;

namespace apicsharp.Repositories
{
    public class TesteRepo : ITesteRepo
    {
        //private readonly MyDbContext _context;

        public TesteRepo()
        {
            //_context = myDbContext;
        }

        public List<Teste> GetAll()
        {
            using var context = new MyDbContext();
            var testes = context.Teste.AsNoTracking().ToList() ?? [];

            return testes;
        }

        public Teste? GetById(int id)
        {
            using var context = new MyDbContext();
            var teste = context.Teste.AsNoTracking().Where(x => x.Id == id).FirstOrDefault();

            return teste;
        }

        public int Create(Teste teste)
        {
            using var context = new MyDbContext();
            context.Teste.Add(teste);
            context.SaveChanges();

            return teste.Id;
        }

        public void Delete(Teste teste)
        {
            using var context = new MyDbContext();
            context.Teste.Remove(teste);
            context.SaveChanges();
        }
        public void Update(Teste teste)
        {
            using var context = new MyDbContext();
            context.Teste.Update(teste);
            context.SaveChanges();
        }
    }
}
