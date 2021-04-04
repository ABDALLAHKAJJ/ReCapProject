using Core.DataAccess;
using Entities.Concrete;
using Entities.Dtos;
using System.Collections.Generic;

namespace DataAccess.Abstract
{
    public interface ICarDal : IEntityRepository<Car>
    {
        List<Car> GetCarsByBrandId(int brandId);

        List<Car> GetCarsByColorId(int colorId);

        List<CarDetailDto> GetCarDetails();
    }
}