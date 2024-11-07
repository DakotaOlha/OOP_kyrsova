using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using models = Kursova.Models;

namespace Kursova
{
    public static class DataGridViewExtensions
    {
        public static void AddMoto(this DataGridView date, models.Motorcycle moto, int id)
        {
            date.Rows.Add(
               id,
               moto.MotoBrand.MotoOwner.Name,
               moto.MotoBrand.MotoOwner.Address,
               moto.MotoBrand.Country,
               moto.model,
               moto.year,
               moto.price,
               moto.capacityEng,
               moto.mas,
               (moto is SportMotorcycle sport) ? sport.topSpeed : (moto is TouringMotorcycle touring) ? touring.fuelConsumption : 0
           );
        }
        public static void EditMoto(this DataGridView date, models.Motorcycle moto, int rowIndex)
        {
            DataGridViewRow row = date.Rows[rowIndex];

            row.Cells[1].Value = moto.MotoBrand.MotoOwner.Name;
            row.Cells[2].Value = moto.MotoBrand.MotoOwner.Address;
            row.Cells[3].Value = moto.MotoBrand.Country;
            row.Cells[4].Value = moto.model;
            row.Cells[5].Value = moto.year;
            row.Cells[6].Value = moto.price;
            row.Cells[7].Value = moto.capacityEng;
            row.Cells[8].Value = moto.mas;
            row.Cells[9].Value = (moto is SportMotorcycle sport) ? sport.topSpeed : (moto is TouringMotorcycle touring) ? touring.fuelConsumption : 0;
        }
    }
}
