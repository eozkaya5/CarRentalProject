﻿
using Business.Abstract;
using Business.Contants;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
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

        public IResult Add(Car car)
        {
            if (car.DailyPrice > 0 && car.CarName.Length > 2)
            {
                return new SuccessResult(Messages.Added);
            }
            else
            {
                return new ErrorResult(Messages.MaintenanceTime);

            }

        }
        public IDataResult<List<Car>> GetDailyPrice()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.Listed);
        }

        public IDataResult<List<Car>> GetCarName(string max, string min)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.Listed);
        }
        public IDataResult<List<Car>> GetDailyPrice(decimal max, decimal min = 0)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.DailyPrice <= max && c.DailyPrice >= min), Messages.Listed);
        }
        public IDataResult<List<Car>> GetCarDetailDto()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.Listed);
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.Deleted);
        }

        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult(Messages.Updated);
        }

        public IDataResult<List<Car>> Get()
        {
            throw new NotImplementedException();
        }
    }
}
