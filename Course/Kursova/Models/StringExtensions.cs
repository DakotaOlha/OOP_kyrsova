using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursova.Models
{
    public static class StringExtensions
    {
        public static bool IsNowYear(this int str)
        {
            return str == DateTime.Now.Year;
        }
    }
}
