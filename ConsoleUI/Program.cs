using Business.Abstract;
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
            //CarManager carManager = new CarManager(new EfCarDal(new ReCapContext()));

            //foreach (var car in carManager.GetAll().Data)
            //{
            //    Console.WriteLine(car.Name);
            //}
            //AddUsers(new UserManager(new EfUserDal()));

            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

            for (int i = 1; i <= 5; i++)
            {
                Customer customer = new Customer
                {
                    Id = i,
                    UserId = i,
                    CompanyName = "Customer" + i
                };
                customerManager.Add(customer);
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

        private static void AddUsers(IUserService userService)
        {
            var Users1 = new User
            {
                Id = 1,
                FirstName = "firstname1",
                LastName = "lastname1",
                Email = "email1",
                Password = "password1"
            };
            var Users2 = new User
            {
                Id = 2,

                FirstName = "firstname2",
                LastName = "lastname2",
                Email = "email2",
                Password = "password2"
            };
            var Users3 = new User
            {
                Id = 3,

                FirstName = "firstname3",
                LastName = "lastname3",
                Email = "email3",
                Password = "password3"
            };
            var Users4 = new User
            {
                Id = 4,

                FirstName = "firstname4",
                LastName = "lastname4",
                Email = "email4",
                Password = "password4"
            };
            var Users5 = new User
            {
                Id = 5,

                FirstName = "firstname5",
                LastName = "lastname5",
                Email = "email5",
                Password = "password5"
            };
            var Users6 = new User
            {
                Id = 6,

                FirstName = "firstname6",
                LastName = "lastname6",
                Email = "email6",
                Password = "password6"
            };
            userService.Add(Users1);
            userService.Add(Users2);
            userService.Add(Users3);
            userService.Add(Users4);
            userService.Add(Users5);
            userService.Add(Users6);
        }
    }
}