using Business.Abstract;
using Core.DataAccess;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class EntityManager<TEntity> : IEntityService<TEntity> where TEntity : class, IEntity, new()
    {
        private readonly IEntityRepository<TEntity> _entityRepository;

        public EntityManager(IEntityRepository<TEntity> entityRepository)
        {
            _entityRepository = entityRepository;
        }

        public void Add(TEntity entity)
        {
            _entityRepository.Add(entity);
        }

        public void Delete(TEntity entity)
        {
            _entityRepository.Delete(entity);
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            return _entityRepository.Get(filter);
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            return _entityRepository.GetAll(filter);
        }

        public void Update(TEntity entity)
        {
            _entityRepository.Update(entity);
        }
    }
}