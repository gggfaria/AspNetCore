using ProjetoBase.Repository.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoBase.Service.Base
{
    public abstract class CrudService<TEntity, TKey> : ICrudService<TEntity, TKey> where TEntity : class
    {
        private readonly ICrudRepository<TEntity, TKey> _repository;

        public CrudService(ICrudRepository<TEntity, TKey> repository)
        {
            _repository = repository;
        }

        public bool Delete(TEntity entity)
        {
            return _repository.Delete(entity);

        }

        public bool DeleteById(TKey id)
        {
            return _repository.DeleteById(id);
        }

        public bool Insert(TEntity entity)
        {
            return _repository.Insert(entity);
        }

        public List<TEntity> Select(Func<TEntity, bool> where = null)
        {
            return _repository.Select(where);
        }

        public TEntity SelectById(TKey id)
        {
            return _repository.SelectById(id);
        }

        public virtual bool Update(TEntity entity)
        {
            return _repository.Update(entity);
        }
    }
}
