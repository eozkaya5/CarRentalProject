using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    //public delegate void MyDelegate();
    //void olan ve parametre olmayan methodlara delegelik eder (Elçilik gibi)

    public interface ICarService
    {
        void SendMessage();

        IResult Add(Car car);

        IResult Delete(Car car);

        IResult Update(Car car);

        IDataResult<List<Car>> GetDailyPrice(decimal max, decimal min);

        IDataResult<List<Car>> GetCarName(string max, string min);

        IDataResult<List<Car>> GetCarDetailDto();

        IDataResult<List<Car>> Get();

    }
}
