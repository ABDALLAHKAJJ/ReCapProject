using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityDal<Car>, ICarDal
    {
        private readonly ReCapContext _reCapContext;

        public EfCarDal(ReCapContext reCapContext) : base(reCapContext)
        {
            _reCapContext = reCapContext;
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