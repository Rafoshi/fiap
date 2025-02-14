using apicsharp.Models;

namespace apicsharp.Services
{
    public interface ITesteService
    {
        List<Teste> GetAll();
        Teste? GetById(int id);
        int Create(Teste teste);
        void Update(Teste teste);
        void Delete(int id);
    }
}
