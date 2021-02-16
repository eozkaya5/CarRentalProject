using Business.Abstract;
using Business.Concrete;
using Core.Utilities.Result.Abstract;
using DataAccess.Concrete.EntitiyFramwork;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // CarManager carManager = CarTest();

            //carManager();

            //Customer();

            // Rental(result);

            //User();

            //CustomerManager();

            //Delegeler();


            Console.ReadLine();
        }

        #region Delegeler kullanımı

        //private static void Delegeler()
        //{
        //    CarManager carManager = new CarManager(new EfCarDal());
        //    MyDelegate myDelegate = carManager.SendMessage;
        //    myDelegate += carManager.SendMessage;
        //    myDelegate();
        //}
        #endregion

        #region Müşteri ekle ve Özellikleri listelettir.

        //private static void User()
        //{
        //    UserManager userManager = new UserManager(new EfUserDal());
        //    var result = userManager.GetAll();
        //    userManager.Add(new User { Id = 1, FirstName = "Elif", Lastname = "Özkaya", Email = "eozkaya@gmail.com", Password = "123", });
        //    if (result.Success == true)
        //    {
        //        foreach (var user in result.Data)
        //        {
        //            Console.WriteLine(user.Id);
        //            Console.WriteLine(user.FirstName);
        //            Console.WriteLine(user.Lastname);
        //            Console.WriteLine(user.Email);
        //            Console.WriteLine(user.Password);

        //            Console.WriteLine("--------------------------------------");
        //        }
        //    }
        //    Console.WriteLine(result.Message);
        //}
        #endregion

        #region Eklenen kiralma özelliklerinden "RentDate" yi listelettir.

        //private static void Rental(IDataResult<List<Customer>> result)
        //{
        //    RentalManager rentalManager = new RentalManager(new EfRentalDal());
        //    var result = rentalManager.GitAll();
        //    rentalManager.Add(new Rental { CustomerId = 1, CarId = 1, RentDate = new DateTime(2020, 12, 12), ReturnDate = new DateTime(2020, 12, 12) });
        //    if (result.Success == true)
        //    {
        //        foreach (var rental in result.Data)
        //        {
        //            Console.WriteLine(rental.RentDate);
        //            Console.WriteLine("--------------------------------------");
        //        }
        //    }
        //    Console.WriteLine(result.Message);
        //}
        #endregion

        #region Müşteri özellikleri ekle
        //private static void CustomerManager()
        //{
        //    CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
        //    var result = customerManager.GitAll();
        //    customerManager.Add(new Customer { UserId = 1, CompanyName = "Yazılım Şirketi" });
        //    if (result.Success == true)
        //    {
        //        foreach (var custemer in result.Data)
        //        {
        //            Console.WriteLine(custemer.CompanyName);
        //            Console.WriteLine("--------------------------------------");
        //        }
        //    }
        //    Console.WriteLine(result.Message);
        //}
        #endregion

        #region Eklenen marka tablosunndaki Marka adını ve Id'sini listelettir.

        //private static void carManager()
        //{
        //    BrandManager carManager = new BrandManager(new EfBrandDal());
        //    carManager.Add(new Brand { BrandName = "Megane", Id = 1 });

        //    Console.WriteLine(car.BrandName + "/" + car.Id);
        //}

        #endregion

        #region Eklenen araba özelliklerini ekle ve listelettir.

        //private static CarManager CarTest()
        //{
        //    CarManager carManager = new CarManager(new EfCarDal());
        //    carManager.Add(new Car { Id = 1, CarName = "Megane", DailyPrice = 15 });
        //    return carManager;
        //    foreach (var car in carManager.GetDailyPrice())
        //    {
        //        Console.WriteLine("Araba Açıklamsı:" + " " + car.Description);
        //        Console.WriteLine("GÜnlük Ücreti:" + " " + car.DailyPrice);
        //        Console.WriteLine("Model Yılı:" + car.Modelyear);
        //        Console.WriteLine("Marka" + car.ColorId);
        //        Console.WriteLine("--------------------------------------");
        //    }

        //}
        #endregion

    }
}
