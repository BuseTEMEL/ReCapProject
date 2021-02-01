using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
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

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public void Add(Car car)
        {
            _carDal.Add(car);
            Console.WriteLine(car.CarId + "  Ürünü eklendi.");
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
            Console.WriteLine(car.CarId + "  Ürünü silindi.");
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
            Console.WriteLine(car.CarId + "  Ürünü güncellendi.");
        }

        public List<Car> GetById(int CarId)
        {
            return _carDal.GetById(CarId);
        }
        

    }
}
