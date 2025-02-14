using apicsharp.Models;

namespace apicsharp.Repositories
{
    public interface ITesteRepo
    {
        List<Teste> GetAll();
        Teste? GetById(int id);
        int Create(Teste teste);
        void Update(Teste teste);
        void Delete(Teste teste);
    }
}
