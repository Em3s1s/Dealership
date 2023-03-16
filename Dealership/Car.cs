using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dealership
{
    public class Car
    {
        public string Marca { get; set; }
        public string Model { get; set; }
        public int An { get; set; }
        public string Culoare { get; set; }
        public string Numar { get; set; }
        public double Pret { get; set; }

        public Car(string marca, string model, int an, string culoare, string numar, double pret)
        {
            Marca = marca;
            Model = model;
            An = an;
            Culoare = culoare;
            Numar = numar;
            Pret = pret;
        }

        public override string ToString()
        {
            return $"{An} {Marca} {Model}, {Culoare}, {Numar}, {Pret:C}/day";
        }
    }
}
