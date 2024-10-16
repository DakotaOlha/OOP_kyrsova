using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursova
{
    public class Motorcycle : IMotorcycle
    {
        public string brand { get; set; }
        public string model { get; set; }
        public int year { get; set; }
        public double price { get; set; }
        public int capacityEng { get; set; }
        public int mas { get; set; }
        public Motorcycle() { }

        public Motorcycle(string Brand, string Model, int Year, double Price, int CapacityEng, int Mas)
        {
            brand = Brand;
            model = Model;
            year = Year;
            price = Price;
            capacityEng = CapacityEng;
            mas = Mas;
        }
        public virtual string GetInfo()
        {
            return $"Brand: {brand}, Model: {model}, Year: {year}, Price: {price}, Engine Volume: {capacityEng}, Weight: {mas}";
        }

        public virtual void AddToTable(DataGridView d, int rowIndex)
        {
            d.Rows.Add();
            ChangeRow(d, rowIndex);
        }
        public virtual void ChangeRow(DataGridView D, int rowIndex)
        {
            D.Rows[rowIndex].Cells[0].Value = brand;
            D.Rows[rowIndex].Cells[1].Value = model;
            D.Rows[rowIndex].Cells[2].Value = year;
            D.Rows[rowIndex].Cells[3].Value = price;
            D.Rows[rowIndex].Cells[4].Value = capacityEng;
            D.Rows[rowIndex].Cells[5].Value = mas;
        }

        public virtual void AddMotorcycleToDataGrid(DataGridView d)
        {
            d.Rows.Add(
                brand,
                model,
                year,
                price,
                capacityEng,
                mas,
                0
            );
        }

        public virtual void EditMotorcycleToDataGrid(DataGridView d, int rowIndex)
        {
            DataGridViewRow row = d.Rows[rowIndex];

            row.Cells[0].Value = brand;
            row.Cells[1].Value = model;
            row.Cells[2].Value = year;
            row.Cells[3].Value = price;
            row.Cells[4].Value = capacityEng;
            row.Cells[5].Value = mas;
        }
    }
}