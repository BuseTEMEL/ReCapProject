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
            //CarTest();

            //ColourTest();

            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var carDetails in carManager.GetCarDetails())
            {
                Console.WriteLine(carDetails.CarName + "/" + carDetails.ColourName);
            }

        }

        private static void ColourTest()
        {
            ColourManager colourManager = new ColourManager(new EfColourDal());
            foreach (var colour in colourManager.GetAll())
            {
                Console.WriteLine(colour.ColourName + "/" + colour.ColourId);
            }

            foreach (var colour in colourManager.GetById(3))
            {
                Console.WriteLine(colour.ColourId + "/" + colour.ColourName);
            }

            Colour colourAdd = new Colour()
            {
                ColourName = "Dark Blue"
            };
            colourManager.Add(colourAdd);

            foreach (var colour in colourManager.GetAll())
            {
                Console.WriteLine(colour.ColourName + "/" + colour.ColourId);
            }

            colourManager.Delete(2002);
            foreach (var colours in colourManager.GetAll())
            {
                Console.WriteLine(colours.ColourName);
            }

            colourManager.Update(1);
        }

        private static void CarTest()
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
                ColourId = 2,
                ModelYear = 2018,
                DailyPrice = 0,
                Description = "Klimali, Otomatik Vites,Benzin"
            };

            carManager.Add(addCar);

            carManager.Delete(2004);

            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine(item.CarName);
            }



            Car updatedCar = new Car()
            {
                ModelYear = 2018
            };

            carManager.Update(4);
        }
    } 
}
