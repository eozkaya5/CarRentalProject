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
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car { Id = 1, CarName = "Megane", DailyPrice = 0, });
            Console.ReadLine();



            // foreach (var car in carManager.GetAll())
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
