using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class UserManager : EntityManager<User>, IUserService
    {
        public UserManager(IUserDal userDal) : base(userDal)
        {
        }
    }
}