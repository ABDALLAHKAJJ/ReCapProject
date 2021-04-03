using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal(new ReCapContext()));
            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine(item.Id);
            }
        }
    }
}