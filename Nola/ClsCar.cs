using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nola
{
    public class ClsCar
    {

        NolaDBEntities entity;

        public ClsCar()
        {
            entity = new NolaDBEntities();
        }

        public void deleteCar(Car c)
        {
            Car carFound = new Car();
            carFound = entity.Car.Where(p => p.IdCar.Equals(c.IdCar)).FirstOrDefault();
            entity.Car.Remove(carFound);
            entity.SaveChanges();
        }

        public void updateCar(Car oldCar, Car newCar)
        {
            Car carFound = new Car();
            carFound = entity.Car.Where(p => p.IdCar.Equals(oldCar.IdCar)).FirstOrDefault();
            carFound.model = newCar.model;
            carFound.color = newCar.color;
            carFound.vin = newCar.vin;
            entity.SaveChanges();
        }

        public void addCar(Car c)
        {
            try
            {
                entity.Car.Add(c);
                entity.SaveChanges();
            }
            catch (Exception Ex)
            {

                throw;
            }
            
        }

        public List<Car> listCars()
        {
            return entity.Car.ToList();
        }
    }
}
