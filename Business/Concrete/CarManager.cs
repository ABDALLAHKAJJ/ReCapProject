using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results.Concrete;
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

        public DataResult<List<Car>> GetCarsByBrandId(int brandId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetCarsByBrandId(brandId), Messages.Success);
        }

        public DataResult<List<Car>> GetCarsByColorId(int colorId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetCarsByColorId(colorId), Messages.Success);
        }
    }
}