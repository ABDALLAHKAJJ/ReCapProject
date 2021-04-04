using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapContext>, ICarDal
    {
        private readonly ReCapContext _reCapContext;

        public EfCarDal(ReCapContext reCapContext)
        {
            _reCapContext = reCapContext;
        }

        public List<CarDetailDto> GetCarDetails()
        {
            var result = _reCapContext.Cars.Join(_reCapContext.Brands, c => c.BrandId, b => b.Id,
                (c, b) => new
                {
                    carName = c.Name,
                    carId = c.Id,
                    dailyPrice = c.DailyPrice,
                    brandName = b.Name
                }).Join(_reCapContext.Colors, c => c.carId, co => co.Id,
                (c, co) => new CarDetailDto
                {
                    CarId = c.carId,
                    CarName = c.carName,
                    BrandName = c.brandName,
                    ColorName = co.Name
                }).ToList();
            return result;
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            return _reCapContext.Set<Car>().Where(x => x.BrandId == brandId).ToList();
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            return _reCapContext.Set<Car>().Where(x => x.BrandId == colorId).ToList();
        }
    }
}