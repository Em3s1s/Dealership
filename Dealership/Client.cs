using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dealership
{
    public class Client
    {
    public string Nume { get; set; }
    public string Prenume { get; set; }
    public string Adresa { get; set; }
    public string Telefon { get; set; }
    public string Email { get; set; }

    public Client(string nume, string prenume, string adresa, string telefon, string email)
    {
        Nume = nume;
        Prenume = prenume;
        Adresa = adresa;
        Telefon = telefon;
        Email = email;
    }

    public override string ToString()
    {
        return $"{Nume} {Prenume}, {Adresa}, {Telefon}, {Email}";
    }
}
}
