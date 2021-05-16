using Business.Abstract;
using Business.Constants;
using Core.DataAccess;
using Core.Entities;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
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

        public IResult Add(TEntity entity)
        {
            _entityRepository.Add(entity);
            return new SuccessResult(Messages.ItemAdded);
        }

        public IResult Delete(TEntity entity)
        {
            _entityRepository.Delete(entity);
            return new SuccessResult(Messages.ItemDeleted);
        }

        public IDataResult<TEntity> Get(Expression<Func<TEntity, bool>> filter)
        {
            return new SuccessDataResult<TEntity>(_entityRepository.Get(filter), Messages.Success);
        }

        public IDataResult<List<TEntity>> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            return new SuccessDataResult<List<TEntity>>(_entityRepository.GetAll(filter), Messages.Success);
        }

        public IResult Update(TEntity entity)
        {
            _entityRepository.Update(entity);
            return new SuccessResult(Messages.ItemUpdated);
        }
    }
}