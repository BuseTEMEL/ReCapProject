using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(c => c.BrandId == id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(c => c.ColorId == id);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public void Add(Car car)
        {
            if (car.CarName.Length > 2 && car.DailyPrice > 0)
            {
                _carDal.Add(car);
            }
            else if (car.CarName.Length <= 2 && car.DailyPrice >= 0)
            {
                Console.WriteLine("Eklemek istediğiniz ürünün adı minimum 2 karakter olmalıdır!");
            }
            else if (car.CarName.Length >= 2 && car.DailyPrice <= 0)
            {
                Console.WriteLine("Eklemek istediğiniz ürün fiyatı  0 dan büyük olmalıdır!");
            }
            else
            {
                Console.WriteLine("Eklemek istediğiniz ürünün adı minimum 2 karakter ve fiyatı 0 dan büyük olmalıdır!");
            }
        }

        




    }
}
