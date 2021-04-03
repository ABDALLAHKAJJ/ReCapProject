using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ColorManager : EntityManager<Color>, IColorService
    {
        private readonly IColorDal _colorDal;

        public ColorManager(IColorDal colorDal) : base(colorDal)
        {
            _colorDal = colorDal;
        }
    }
}