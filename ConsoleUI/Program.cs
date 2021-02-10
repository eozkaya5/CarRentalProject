using Business.Concrete;
using DataAccess.Concrete.EntitiyFramwork;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // CarManager carManager = CarTest();

            BrandManager carManager = new BrandManager(new EfBrandDal());
            carManager.Add(new Brand { BrandName = "Elif", Id = 1 });
        
                //Console.WriteLine(car.BrandName+"/"+car.Id);
            
            Console.ReadLine();



        }

        private static CarManager CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car { Id = 1, CarName = "Megane", DailyPrice = 15 });
            return carManager;
            foreach (var car in carManager.GetDailyPrice())
            {
                Console.WriteLine("Araba Açıklamsı:" + " " + car.Description);
                Console.WriteLine("GÜnlük Ücreti:" + " " + car.DailyPrice);
                Console.WriteLine("Model Yılı:" + car.Modelyear);
                Console.WriteLine("Marka" + car.ColorId);
                Console.WriteLine("--------------------------------------");
            }

        }
    }
}
