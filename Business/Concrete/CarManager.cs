
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
        public List<Car> GetDailyPrice()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetCarName(string max, string min)
        {
            throw new NotImplementedException();
        }
        public List<Car> GetDailyPrice(decimal max, decimal min = 0)
        {
            return _carDal.GetAll(c => c.DailyPrice <= max && c.DailyPrice >= min);
        }
        public List<Car> GetCarDetailDto()
        {
            return _carDal.GetAll();
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
            Console.WriteLine("Araba silindi.");
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
            Console.WriteLine("Araba güncellendi.");
        }
    }
}
