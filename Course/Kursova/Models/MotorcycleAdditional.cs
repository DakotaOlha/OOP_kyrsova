using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursova.Models
{
    public partial class Motorcycle
    {
        public Motorcycle() { }

        public Motorcycle(Owner owner, string country, string Model, int Year, double Price, int CapacityEng, int Mas)
        {
            MotoBrand.MotoOwner = owner;
            MotoBrand.Country = country;
            model = Model;
            year = Year;
            price = Price;
            capacityEng = CapacityEng;
            mas = Mas;
        }
        public virtual string GetInfo()
        {
            return MotoBrand.Info() + $", Model: {model}, Year: {year}, Price: {price}, Engine Volume: {capacityEng}, Weight: {mas}";
        }

        public virtual bool IfYearIsNow()
        {
            return year.IsNowYear();
        }
    }
}
