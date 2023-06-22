using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.EntityFramework
{
    public class IEntityRepositoryBase<TEntity, TContext> : IEntitiyRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
            using (TContext nortwindContext = new TContext())
            {
                var addedEntity = nortwindContext.Entry(entity);
                addedEntity.State = EntityState.Added;
                nortwindContext.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext nortwindContext = new TContext()) // işi bittikten sonra adresi siler.
            {
                var deleteEntity = nortwindContext.Entry(entity);
                deleteEntity.State = EntityState.Deleted;
                nortwindContext.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext nortwindContext = new TContext())
            {
                return nortwindContext.Set<TEntity>().SingleOrDefault(filter);

            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext nortwindContext = new TContext())
            {
                return filter == null ?
                    nortwindContext.Set<TEntity>().ToList() :
                    nortwindContext.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext nortwindContext = new TContext())
            {
                var updatedEntity = nortwindContext.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                nortwindContext.SaveChanges();

            }
        }
    }
}
