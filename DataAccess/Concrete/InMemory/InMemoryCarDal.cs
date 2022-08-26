using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars=new List<Car> { 
                new Car{CarId=1,BrandId=2,ColorId=1,ModelYear=2022,DailyPrice=800000,Description="1.6, Sedan, Otomatik, Benzin"},
                new Car{CarId=2,BrandId=1,ColorId=6,ModelYear=2019,DailyPrice=570000,Description="1.3, Hatchback, Otomatik, Benzin"},
                new Car{CarId=3,BrandId=1,ColorId=5,ModelYear=2020,DailyPrice=450000,Description="1.3, SUV, Manuel, Diesel"},
                new Car{CarId=4,BrandId=3,ColorId=2,ModelYear=2018,DailyPrice=620000,Description="1.6, Sedan, Otomatik, LPG"},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            //LINQ - Language Integrated Query
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c=>c.CarId == id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
