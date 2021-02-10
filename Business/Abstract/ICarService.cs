using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {

        void Add(Car car);

        void Delete(Car car);

        void Update(Car car);

        List<Car> GetDailyPrice(decimal max, decimal min);

        List<Car> GetCarName(string max, string min);

        List<Car> GetCarDetailDto();
    }
}
