using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace ProjectTracer.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly ProjectTracerEntities Context; 

        public Repository(ProjectTracerEntities _context)
        {
            Context = _context;
        }
        public void Add(TEntity entity)
        {
            Context.Set<TEntity>().Add(entity);  
        }

        public void AddRange(List<TEntity> entities)
        {
            Context.Set<TEntity>().AddRange(entities);
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return Context.Set<TEntity>().Where(predicate); 
        }

        public TEntity Get(string id)
        {
            return Context.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Context.Set<TEntity>().ToList();
        }

        public void Remove(TEntity entity)
        {
            
            Context.Set<TEntity>().Remove(entity);
        }

        public void RemoveRange(List<TEntity> entities)
        {
            Context.Set<TEntity>().RemoveRange(entities);
        }

        public bool CheckExistance(TEntity entity)
        {
            if (Context.Set<TEntity>().Find(entity) == null)
                return false;
            else
                return true; 
        }
    }
}
