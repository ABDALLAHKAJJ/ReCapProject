using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CustomerManager : EntityManager<Customer>, ICustomerService
    {
        public CustomerManager(ICustomerDal customerDal) : base(customerDal)
        {
        }
    }
}