using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        private List<Car> _Cars;

        public InMemoryCarDal()
        {
            _Cars = new List<Car>
            {
                new Car{Id =1,BrandId=1, ColorId=1 ,DailyPrice=200,ModelYear=1990,Description="car1"},
                new Car{Id =2,BrandId=1, ColorId=3 ,DailyPrice=100,ModelYear=1992,Description="car2"},
                new Car{Id =3,BrandId=2, ColorId=5 ,DailyPrice=500,ModelYear=1996,Description="car3"},
                new Car{Id =4,BrandId=3, ColorId=6 ,DailyPrice=700,ModelYear=1997,Description="car4"},
                new Car{Id =5,BrandId=3, ColorId=2 ,DailyPrice=300,ModelYear=1994,Description="car5"},
            };
        }

        public void Add(Car car)
        {
            _Cars.Add(car);
        }

        public void Delete(Car car)
        {
            var itemToDelete = _Cars.SingleOrDefault(c => c.Id == car.Id);
            _Cars.Remove(itemToDelete);
        }

        public List<Car> GetAll()
        {
            return _Cars;
        }

        public Car GetById(int id)
        {
            return _Cars.SingleOrDefault(c => c.Id == id);
        }

        public void Update(Car car)
        {
            var itemToUpdate = _Cars.SingleOrDefault(c => c.Id == car.Id);
            itemToUpdate.BrandId = car.BrandId;
            itemToUpdate.ColorId = car.ColorId;
            itemToUpdate.DailyPrice = car.DailyPrice;
            itemToUpdate.Description = car.Description;
        }
    }
}