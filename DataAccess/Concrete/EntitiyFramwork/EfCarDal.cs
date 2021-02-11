using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntitiyFramwork
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarRentalContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var resault = from c in context.Cars 
                              
                              join r in context.Colors on
                               c.ColorId equals r.Id 
                              join b in context.Brands on
                              c.BrandId equals b.Id
                              select new CarDetailDto
                              {
                                  Id = c.Id,
                                  ColorName = r.ColorName,
                                  BrandName= b.BrandName,
                                  DailyPrice = c.DailyPrice
                              };
                return resault.ToList();
            }
           
        }
    }



}
