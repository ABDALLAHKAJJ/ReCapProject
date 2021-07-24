using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfColorDal : EfEntityRepositoryBase<Color, ReCapContext>, IColorDal
    {
        private readonly ReCapContext _reCapContext;

        public EfColorDal(ReCapContext reCapContext)
        {
            _reCapContext = reCapContext;
        }

        public void Add(Car car)
        {
            if (car.Name.Length >= 2 || car.DailyPrice > 0)
            {
                var addedEntity = _reCapContext.Entry(car);
                addedEntity.State = EntityState.Added;
                _reCapContext.SaveChanges();
            }
        }
    }
}