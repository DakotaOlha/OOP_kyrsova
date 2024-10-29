using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursova
{
    internal class SportMotorcycle : Motorcycle
    {
        public int topSpeed { get; set; }

        public SportMotorcycle() { }

        public SportMotorcycle(string Brand, string Model, int Year, double Price, int CapacityEng, int Mas, int TopSpeed)
            : base(Brand, Model, Year, Price, CapacityEng, Mas)
        {
            topSpeed = TopSpeed;
        }

        public override string GetInfo()
        {
            return base.GetInfo() + $", Top Speed: {topSpeed} km/h";
        }

        public override void AddMotorcycleToDataGrid(int id, DataGridView d)
        {
            d.Rows.Add(
                id,
                brand,
                model,
                year,
                price,
                capacityEng,
                mas,
                topSpeed
            );

        }

        public override void EditMotorcycleToDataGrid(DataGridView d, int rowIndex)
        {
            DataGridViewRow row = d.Rows[rowIndex];

            row.Cells[1].Value = brand;
            row.Cells[2].Value = model;
            row.Cells[3].Value = year;
            row.Cells[4].Value = price;
            row.Cells[5].Value = capacityEng;
            row.Cells[6].Value = mas;
            row.Cells[7].Value = topSpeed;
        }

    }
}