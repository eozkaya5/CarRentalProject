
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

        public void Add(Car car)
        {
            if (car.DailyPrice > 0 && car.CarName.Length > 2)
            {
                Console.WriteLine("Araba Kayıt edildi.");
            }
            else
            {
                Console.WriteLine("Araba ismi minimum 2 karakterli olmalıdır. " + "\n" + "ve");
                Console.WriteLine("Araba günlük fiyatı O'dan büyük olmalıdır olmalıdır. Kontrol ederek, tekrar deneyiniz.");
            }
        }
        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public void GetByColorsId()
        {
            throw new NotImplementedException();
        }

        public List<Car> GetCarName(string max, string min)
        {
            throw new NotImplementedException();
        }

        public void GetCarsByBrandId()
        {
            throw new NotImplementedException();
        }

        public List<Car> GetDailyPrice(decimal max, decimal min = 0)
        {
            return _carDal.GetAll(c => c.DailyPrice <= max && c.DailyPrice >= min);

        }
    }
}
