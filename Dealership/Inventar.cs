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
        public List<Car> SearchCars(string marca, string model, int an, string culoare)
    {
            return cars.Where(c =>
                (string.IsNullOrEmpty(marca) || c.Marca.Contains(marca)) &&
                (string.IsNullOrEmpty(model) || c.Model.Contains(model)) &&
                (an == 0 || c.An == an) &&
                (string.IsNullOrEmpty(culoare) || c.Culoare.Contains(culoare))
            ).ToList();
        }
    }
}
