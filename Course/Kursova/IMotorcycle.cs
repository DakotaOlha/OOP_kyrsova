using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursova
{
    internal interface IMotorcycle
    {
        string brand { get; set; }
        string model { get; set; }
        int year { get; set; }
        double price { get; set; }
        int capacityEng { get; set; }
        int mas { get; set; }
        string GetInfo();
        void AddToTable(DataGridView d, int rowIndex);
        void ChangeRow(DataGridView d, int rowIndex);
        void AddMotorcycleToDataGrid(DataGridView d);
        void EditMotorcycleToDataGrid(DataGridView d, int rowIndex);
    }
}