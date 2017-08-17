using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoBase.Repository.Base
{
    public abstract class CrudRepository<TEntity, TKey> : ICrudRepository<TEntity, TKey>
        where TEntity : class
    {
        protected DbContext _context;

        public CrudRepository(DbContext context)
        {
            _context = context;
        }

        public virtual List<TEntity> Select(Func<TEntity, bool> where = null)
        {
            IEnumerable<TEntity> resultado = _context.Set<TEntity>().AsNoTracking();
            if (where != null)
                resultado = resultado.Where(where);
            return resultado.ToList();
        }

        public virtual TEntity SelectById(TKey id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public virtual bool Insert(TEntity entity)
        {
            try
            {
                _context.Set<TEntity>().Add(entity);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public virtual bool Update(TEntity entity)
        {
            try
            {
                _context.Set<TEntity>().Attach(entity);
                _context.Entry(entity).State = EntityState.Modified;
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public virtual bool Delete(TEntity entity)
        {
            try
            {
                _context.Set<TEntity>().Attach(entity);
                _context.Entry(entity).State = EntityState.Deleted;
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public virtual bool DeleteById(TKey id)
        {
            TEntity entity = SelectById(id);
            return Delete(entity);
        }

        public void Detach(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Detached;
            _context.SaveChanges();
        }
    }
}
