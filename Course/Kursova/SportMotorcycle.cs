using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kursova.Models;

namespace Kursova
{
    public class SportMotorcycle : Motorcycle
    {
        public int topSpeed { get; set; }

        public SportMotorcycle() { }

        public SportMotorcycle(Owner owner, string Country, string Model, int Year, double Price, int CapacityEng, int Mas, int TopSpeed)
            : base(owner, Country, Model, Year, Price, CapacityEng, Mas)
        {
            topSpeed = TopSpeed;
        }

        public override string GetInfo()
        {
            return base.GetInfo() + $", Top Speed: {topSpeed} km/h";
        }

    }
}