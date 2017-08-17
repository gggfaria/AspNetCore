using ProjetoBase.Domain.Entities;
using ProjetoBase.Repository.Base;

namespace ProjetoBase.Repository.Repositories.Interfaces
{
    public interface IPessoaRepository : ICrudRepository<Pessoa, int>
    {
    }
}
