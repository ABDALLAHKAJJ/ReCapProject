using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class CarManager : EntityManager<Car>, ICarService
    {
        private readonly ICarDal _carDal;

        public CarManager(ICarDal carDal) : base(carDal)
        {
            _carDal = carDal;
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            return _carDal.GetCarsByBrandId(brandId);
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            return _carDal.GetCarsByColorId(colorId);
        }
    }
}