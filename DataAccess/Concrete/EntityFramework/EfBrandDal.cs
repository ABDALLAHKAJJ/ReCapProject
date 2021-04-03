using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBrandDal : EfEntityDal<Brand>, IBrandDal
    {
        private readonly ReCapContext _reCapContext;

        public EfBrandDal(ReCapContext reCapContext) : base(reCapContext)
        {
            _reCapContext = reCapContext;
        }
    }
}