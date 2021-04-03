using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class BrandManager : EntityManager<Brand>, IBrandService
    {
        private readonly IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal) : base(brandDal)
        {
            _brandDal = brandDal;
        }
    }
}