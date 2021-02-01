using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                 new Car { CarId = 1, BrandId= 1, ColorId = 1, ModelYear= 2020, DailyPrice= 682.35, Description = "Vites= Otomatik, Yakıt = Dizel/Benzin, Klimalı"},
                 new Car { CarId = 2, BrandId = 1, ColorId = 1, ModelYear = 2019, DailyPrice = 497.45, Description = "Vites= Otomatik, Yakıt = Dizel/Benzin, Klimalı"},
                 new Car { CarId = 3, BrandId = 2, ColorId = 2, ModelYear = 2018, DailyPrice = 326.23, Description = "Vites= Manuel, Yakıt = Dizel/Benzin, Klimalı"},
                 new Car { CarId = 4, BrandId = 2, ColorId = 3, ModelYear = 2018, DailyPrice = 396.45, Description = "Vites= Manuel, Yakıt = Dizel/Benzin, Klimalı"},
                 new Car { CarId = 5, BrandId = 3, ColorId = 4, ModelYear = 2020, DailyPrice = 458.65, Description = "Vites= Otomatik, Yakıt = Dizel/Benzin, Klimalı"},

            };
            
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
         
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);

        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int CarId)
        {
            return _cars.Where(c => c.CarId == CarId).ToList();
        }

       
    }
}
