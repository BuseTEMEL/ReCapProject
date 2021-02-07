using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntitiyFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    public class Program
    {

        static void Main(string[] args)
        {


            CarManager carManager = new CarManager(new EfCarDal());


            foreach (var item in carManager.GetCarsByColorId(3))
            {
                Console.WriteLine(item.CarName);
            }

            foreach (var item in carManager.GetCarsByBrandId(1))
            {
                Console.WriteLine(item.CarName);
            }

            Car addCar = new Car()
            {
                CarName = "RENAULT CLIO",
                BrandId = 5,
                ColorId = 2,
                ModelYear = 2018,
                DailyPrice = 0,
                Description = "Klimali, Otomatik Vites,Benzin"
            };

            carManager.Add(addCar);



        }





    }
}
