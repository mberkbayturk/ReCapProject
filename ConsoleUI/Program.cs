using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            RentalTest();
            //CustomerTest();
            //UserTest();
            //CarTest();
        }

        private static void RentalTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var result = rentalManager.Add(new Rental { CarId = 1, CustomerId = 1, RentDate = new DateTime(2022, 08, 19, 11, 15, 00) });
            Console.WriteLine(result.Success);
            Console.WriteLine(result.Message);
        }
        private static void CustomerTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            //customerManager.Add(new Customer { UserId = 1, CompanyName = "Eternal" });

            //var result = customerManager.GetAll();
            //foreach (var customer in result.Data)
            //{
            //    Console.WriteLine(customer.CustomerId + " / " + customer.UserId + " / " + customer.CompanyName);
            //}
        }

        private static void UserTest()
        {

            UserManager userManager = new UserManager(new EfUserDal());
            //userManager.Add(new User { FirstName = "Berk", LastName = "Baytürk", Email = "merkbayturk@gmail.com", Password = "1234567" });

            //var result = userManager.GetAll();
            //foreach (var user in result.Data)
            //{
            //    Console.WriteLine(user.UserId + " / " + user.FirstName + " / " + user.LastName + " / " + user.Email + " / " + user.Password);
            //}
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarDetails();

            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarName + " / " + car.BrandName + " / " + car.ColorName + " / " + car.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
    }
}