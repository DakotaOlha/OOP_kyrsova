using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kursova.Models;

namespace Kursova
{
    public class TouringMotorcycle : Motorcycle
    {
        public double fuelConsumption { get; set; }

        public TouringMotorcycle(Owner owner, string Country, string Model, int Year, double Price, int CapacityEng, int Mas, double FuelConsumption)
            : base(owner, Country, Model, Year, Price, CapacityEng, Mas)
        {
            fuelConsumption = FuelConsumption;
        }
        public TouringMotorcycle() { }
        public override string GetInfo()
        {
            return base.GetInfo() + $", Fuel Consumption: {fuelConsumption} liters/100 km";
        }
    }
}