using Core.Entities;
using Core.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface IEntityService<TEntity>
        where TEntity : class, IEntity, new()
    {
        IResult Add(TEntity entity);

        IResult Delete(TEntity entity);

        IDataResult<TEntity> Get(Expression<Func<TEntity, bool>> filter);

        IDataResult<List<TEntity>> GetAll(Expression<Func<TEntity, bool>> filter = null);

        IResult Update(TEntity entity);
    }
}