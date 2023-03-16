using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dealership
{
    public class Inventar
    {
        private List<Car> cars;
        public Inventar()
        {
            cars = new List<Car>();
        }
        public void AddCar(Car car)
        {
            cars.Add(car);
        }
        public void RemoveCar(Car car)
        {
            cars.Remove(car);
        }
        public List<Car> GetCars()
        {
            return cars;
        }
    }
}
