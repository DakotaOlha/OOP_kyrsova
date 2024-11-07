using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursova.Models
{
    public class Owner
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Motorcycle> Motorcycles { get; set; } = new List<Motorcycle>();

        public Owner() { }

        public Owner(string name, string address) { Name = name; Address = address; }
    }

}
