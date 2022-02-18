using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6._2
{
    class CarRepository
    {
        CarsDBEntities2 entities;
        public CarRepository()
        {
            entities = new CarsDBEntities2();
        }

        public void AddCar(Car car)
        {
            entities.Cars.Add(car);
            entities.SaveChanges();
        }

        public void DeleteCar(Car car)
        {
            entities.Cars.Remove(car);
            entities.SaveChanges();
        }

        public Car FindCar(string vin)
        {
            var c = entities.Cars.First(n => n.VIN == vin);
            if(c != null)
            {
                return c;
            }
            else
                return null;
        }

        public ICollection<Car> GetCars()
        {
            return entities.Cars.ToList();
        }

        public void UpdateCar(string vin, Car carchanges)
        {
            var cartoupdate = entities.Cars.Find(vin);
            cartoupdate.VIN = carchanges.VIN;
            cartoupdate.Make = carchanges.Make;
            cartoupdate.Model = carchanges.Model;
            cartoupdate.Year = carchanges.Year;
            cartoupdate.Price = carchanges.Price;
            entities.SaveChanges();
        }
    }
}
