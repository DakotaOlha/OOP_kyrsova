using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursova.Models
{
    public class Brand
    {
        public Owner MotoOwner { get; set; }
        public string Country { get; set; }
        public Brand() { }
        public Brand(string owner_name, string addres, string country)
        {
            MotoOwner = new Owner(owner_name, addres);
            Country = country;
        }
        ~Brand() { }

        public string Info()
        {
            return $"Owner`s name: {MotoOwner.Name}, address: {MotoOwner.Address}, country: {Country}";
        }
    }
}
