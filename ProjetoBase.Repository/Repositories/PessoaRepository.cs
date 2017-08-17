using ProjetoBase.Domain.Entities;
using ProjetoBase.Persistence.Entity.Context;
using ProjetoBase.Repository.Base;
using ProjetoBase.Repository.Repositories.Interfaces;

namespace ProjetoBase.Repository.Repositories
{
    public class PessoaRepository : CrudRepository<Pessoa, int>, IPessoaRepository
    {
        public PessoaRepository(ProjetoBaseCoreDbContext context)
            :base(context)
        {
            _context = context;
        }
    }
}
