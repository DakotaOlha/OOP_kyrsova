using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MotoLibrary;

namespace Kursova.Models
{
    public partial class Motorcycle : IMotorcycle
    {
        public Brand MotoBrand { get; set; } = new Brand();
        public string model { get; set; }
        public int year { get; set; }
        public double price { get; set; }
        public int capacityEng { get; set; }
        public int mas { get; set; }
       
    }
}
