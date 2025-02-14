using apicsharp.Models;
using apicsharp.Repositories;

namespace apicsharp.Services
{
    public class TesteService : ITesteService
    {
        private readonly ITesteRepo _testeRepo;

        public TesteService(ITesteRepo testeRepo)
        {
            _testeRepo = testeRepo;
        }

        private void Validate(Teste teste)
        {
            if (teste is null)
                throw new Exception("Teste nulo.");

            teste.Validate();
        }

        public List<Teste> GetAll()
        {
            var result = _testeRepo.GetAll();

            return result;
        }

        public Teste? GetById(int id)
        {
            Teste? result = _testeRepo.GetById(id);
            return result;
        }

        public int Create(Teste teste)
        {
            Validate(teste);

            int idCreated =  _testeRepo.Create(teste);
            return idCreated;
        }

        public void Delete(int id)
        {
            if (id <= 0)
                throw new Exception("Id inválido");

            var teste = GetById(id);
            if (teste is null)
                throw new Exception("Teste não existe");

            _testeRepo.Delete(teste);
        }

        public void Update(Teste teste)
        {
            Validate(teste);

            _testeRepo.Update(teste);
        }
    }
}
