using System;
using System.Collections.Generic;

namespace ProjetoBase.Repository.Base
{
    public interface ICrudRepository<TEntity, Tkey>
        where TEntity : class
    {
        List<TEntity> Select(Func<TEntity, bool> where = null);

        TEntity SelectById(Tkey id);

        bool Insert(TEntity entity);
        bool Update(TEntity entity);
        bool Delete(TEntity entity);
        bool DeleteById(Tkey id);
        void Detach(TEntity entity);
    }
}
