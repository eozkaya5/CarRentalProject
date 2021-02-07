using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetDailyPrice();

        void GetByColorsId();

        void GetCarsByBrandId();

        void Add(Car car);

        List<Car> GetDailyPrice(decimal max, decimal min);

        List<Car> GetCarName(string max, string min);
    }
}
