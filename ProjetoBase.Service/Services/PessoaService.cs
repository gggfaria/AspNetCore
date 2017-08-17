using ProjetoBase.Domain.Entities;
using ProjetoBase.Repository.Base;
using ProjetoBase.Repository.Repositories.Interfaces;
using ProjetoBase.Service.Base;
using ProjetoBase.Service.Services.Interfaces;

namespace ProjetoBase.Service.Services
{
    public class PessoaService : CrudService<Pessoa, int>, IPessoaService
    {
        private IPessoaRepository _pessoaRepository;
        public PessoaService(IPessoaRepository repository) : base(repository)
        {
            _pessoaRepository = repository;
        }
    }
}
