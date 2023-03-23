using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dealership
{
    static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Inventar myInventar = new Inventar();

            Console.WriteLine("Introduceti datele masinii:");
            Console.Write("Marca: ");
            string marca = Console.ReadLine();

            Console.Write("Model: ");
            string model = Console.ReadLine();

            Console.Write("An: ");
            int an = int.Parse(Console.ReadLine());

            Console.Write("Culoare: ");
            string culoare = Console.ReadLine();

            Console.Write("Numar: ");
            string numar = Console.ReadLine();

            Console.Write("Pret: ");
            double pret = double.Parse(Console.ReadLine());

            Car newCar = new Car(marca, model, an, culoare, numar, pret);

            // Adauga masina in inventar
            myInventar.AddCar(newCar);

            Console.WriteLine("Masina a fost adaugata in inventar.");

        }
    }
}
