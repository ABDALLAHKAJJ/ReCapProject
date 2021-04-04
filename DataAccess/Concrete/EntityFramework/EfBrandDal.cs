using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBrandDal : EfEntityRepositoryBase<Brand, ReCapContext>, IBrandDal
    {
        private readonly ReCapContext _reCapContext;

        public EfBrandDal(ReCapContext reCapContext)
        {
            _reCapContext = reCapContext;
        }
    }
}