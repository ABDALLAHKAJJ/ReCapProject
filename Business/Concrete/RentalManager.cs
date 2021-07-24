using Business.Abstract;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System;

namespace Business.Concrete
{
    public class RentalManager : EntityManager<Rental>, IRentalService
    {
        private readonly IRentalDal rentalDal;

        public RentalManager(IRentalDal rentalDal) : base(rentalDal)
        {
            this.rentalDal = rentalDal;
        }

        public IResult RentCar(Rental rentalCar)
        {
            if (rentalCar.CarId > 0 && rentalCar.CustomerId > 0 && !rentalCar.Isrented)
            {
                rentalCar.Isrented = true;
                rentalDal.Add(rentalCar);
                return new SuccessResult();
            }
            else
            {
                return new ErrorResult();
            }
        }
    }
}