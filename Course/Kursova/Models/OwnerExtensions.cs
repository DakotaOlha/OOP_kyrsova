using MotoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursova.Models
{
    public static class OwnerExtensions
    {
        public static void AddMotorcycle(this Owner own, Motorcycle motorcycle)
        {
            own.Motorcycles.Add(motorcycle);
        }
    }
}
