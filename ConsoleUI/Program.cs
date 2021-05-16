using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal(new ReCapContext()));

            foreach (var car in carManager.GetAll().Data)
            {
                Console.WriteLine(car.Name);
            }
        }

        private static void AddCars(CarManager carManager)
        {
            var car1 = new Car()
            {
                Id = 1,
                Name = "car1",
                BrandId = 1,
                ColorId = 1,
                DailyPrice = 1000,
                Description = "desctiption1",
                ModelYear = 2021
            };
            var car2 = new Car()
            {
                Id = 2,
                Name = "car2",
                BrandId = 2,
                ColorId = 2,
                DailyPrice = 2000,
                Description = "desctiption2",
                ModelYear = 2022
            };
            var car3 = new Car()
            {
                Id = 3,
                Name = "car3",
                BrandId = 3,
                ColorId = 3,
                DailyPrice = 3000,
                Description = "desctiption3",
                ModelYear = 3033
            };
            var car4 = new Car()
            {
                Id = 4,
                Name = "car4",
                BrandId = 4,
                ColorId = 4,
                DailyPrice = 4000,
                Description = "desctiption4",
                ModelYear = 4044
            }; var car5 = new Car()
            {
                Id = 5,
                Name = "car5",
                BrandId = 5,
                ColorId = 5,
                DailyPrice = 5000,
                Description = "desctiption5",
                ModelYear = 5055
            };
            carManager.Add(car1);
            carManager.Add(car2);
            carManager.Add(car3);
            carManager.Add(car4);
            carManager.Add(car5);
        }
    }
}