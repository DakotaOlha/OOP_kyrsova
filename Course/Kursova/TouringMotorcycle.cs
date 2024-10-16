using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursova
{
    internal class TouringMotorcycle : Motorcycle
    {
        public double fuelConsumption { get; set; }

        public TouringMotorcycle(string Brand, string Model, int Year, double Price, int CapacityEng, int Mas, int FuelConsumption)
            : base(Brand, Model, Year, Price, CapacityEng, Mas)
        {
            fuelConsumption = FuelConsumption;
        }

        public override string GetInfo()
        {
            return base.GetInfo() + $", Fuel Consumption: {fuelConsumption} liters/100 km";
        }

        public override void AddMotorcycleToDataGrid(DataGridView d)
        {
            d.Rows.Add(
                brand,
                model,
                year,
                price,
                capacityEng,
                mas,
                fuelConsumption
            );
        }

        public override void EditMotorcycleToDataGrid(DataGridView d, int rowIndex)
        {
            DataGridViewRow row = d.Rows[rowIndex];

            row.Cells[0].Value = brand;
            row.Cells[1].Value = model;
            row.Cells[2].Value = year;
            row.Cells[3].Value = price;
            row.Cells[4].Value = capacityEng;
            row.Cells[5].Value = mas;
            row.Cells[6].Value = fuelConsumption;
        }
    }
}