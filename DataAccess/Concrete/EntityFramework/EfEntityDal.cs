using DataAccess.Abstract;
using Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfEntityDal<TEntity> : IEntityRepository<TEntity> where TEntity : class, IEntity, new()
    {
        private readonly ReCapContext _reCapContext;

        public EfEntityDal(ReCapContext reCapContext)
        {
            _reCapContext = reCapContext;
        }

        public void Add(TEntity entity)
        {
            var addedEntity = _reCapContext.Entry(entity);
            addedEntity.State = EntityState.Added;
            _reCapContext.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            var deletedEntity = _reCapContext.Entry(entity);
            deletedEntity.State = EntityState.Deleted;
            _reCapContext.SaveChanges();
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            return _reCapContext.Set<TEntity>().SingleOrDefault(filter);
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            return filter == null
                ? _reCapContext.Set<TEntity>().ToList()
                : _reCapContext.Set<TEntity>().Where(filter).ToList();
        }

        public void Update(TEntity entity)
        {
            var updatedEntity = _reCapContext.Entry(entity);
            updatedEntity.State = EntityState.Modified;
            _reCapContext.SaveChanges();
        }
    }
}