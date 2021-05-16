using Core.Utilities.Results.Concrete;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ICarService : IEntityService<Car>
    {
        DataResult<List<Car>> GetCarsByBrandId(int brandId);

        DataResult<List<Car>> GetCarsByColorId(int colorId);
    }
}