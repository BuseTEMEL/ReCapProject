using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    public class Program
    {

        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine(item.CarId +" -> " + item.DailyPrice);
            }

            Car addCar = new Car
            {
                CarId = 6,
                BrandId = 2,
                ColorId = 4,
                ModelYear = 2019,
                DailyPrice = 285.65,
                Description = "Vites = Manuel, Yakıt = Dizel/Benzin, Klimalı"
            };
            
            carManager.Add(addCar);

            addCar = new Car
            {
                CarId = 7,
                BrandId = 1,
                ColorId = 1,
                ModelYear = 2016,
                DailyPrice = 346.55,
                Description = "Vites = Otomatik, Yakıt = Dizel/Benzin, Klimalı"

            };
            carManager.Add(addCar);

            Car updateCar = new Car
            {
                CarId = 3,
                BrandId = 2,
                ColorId = 4,
                ModelYear = 2018,
                DailyPrice = 355.65,
                Description = "Vites= Manuel, Yakıt = Dizel/Benzin, Klimalı"
            };

            carManager.Update(updateCar);
           

            Car deleteCar = new Car
            {
                CarId = 7,
                BrandId = 1,
                ColorId = 1,
                ModelYear = 2016,
                DailyPrice = 346.55,
                Description = "Vites = Otomatik, Yakıt = Dizel/Benzin, Klimalı"
            };

            carManager.Delete(deleteCar);

            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine(item.CarId);
            }




        }
    }
}
