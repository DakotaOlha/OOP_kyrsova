using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursova
{
    public partial class Form1 : Form
    {
        List<Motorcycle> motorcycles_list = new List<Motorcycle>();
        bool isSortedAscending = true;

        public delegate void MotorcycleAddedDelegate(Motorcycle motorcycle, bool dod);

        public event MotorcycleAddedDelegate MotorcycleAdded;

        public delegate void MotorcycleChangedDelegate(Motorcycle motorcycle);

        public event MotorcycleChangedDelegate MotorcycleChanged;

        public void AddMotorcycle(Motorcycle motorcycle, bool dod)
        {
            motorcycles_list.Add(motorcycle);
            motorcycle.AddMotorcycleToDataGrid(motoDataGrid);
            MotorcycleAdded?.Invoke(motorcycle, dod);
        }

        private void OnMotorcycleAdded(Motorcycle motorcycle, bool dod)
        {
            if (!dod)
            {
                MessageBox.Show($"{motorcycle.brand} {motorcycle.model} óñï³øíî äîäàíî!");
            }
        }

        private void OnMotorcycleChanged(Motorcycle motorcycle)
        {
            MessageBox.Show($"{motorcycle.brand} {motorcycle.model} óñï³øíî çì³íåíî!");
        }

        public Form1()
        {
            InitializeComponent();
            MotorcycleAdded += OnMotorcycleAdded;
            MotorcycleChanged += OnMotorcycleChanged;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "";
            this.ShowIcon = false;
        }

        public void AddMotorcycleToList(Motorcycle moto, bool dod)
        {
            AddMotorcycle(moto, dod);
        }
        private void FileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "(*.csv, *.txt)|*.csv;*.txt|Âñ³ ôàéëè (*.*)|*.*",
                Title = "Îáåð³òü ôàéë äëÿ çàâàíòàæåííÿ"
            };

            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            string filePath = openFileDialog.FileName;

            try
            {
                var lines = System.IO.File.ReadAllLines(filePath);

                foreach (var line in lines)
                {
                    var data = line.Split(',').Select(d => d.Trim()).ToArray();

                    if (data.Length == 7)
                    {
                        string brand = data[0];
                        string model = data[1];

                        if (int.TryParse(data[2], out int year) &&
                            double.TryParse(data[3], out double price) &&
                            int.TryParse(data[4], out int capacityEng) &&
                            int.TryParse(data[5], out int mas) &&
                            int.TryParse(data[6], out int speedorfuel))
                        {

                            if (speedorfuel < 10)
                            {
                                TouringMotorcycle tm = new TouringMotorcycle(brand, model, year, price, capacityEng, mas, speedorfuel);
                                motorcycles_list.Add(tm);
                                tm.AddMotorcycleToDataGrid(motoDataGrid);
                            }
                            else
                            {
                                SportMotorcycle sm = new SportMotorcycle(brand, model, year, price, capacityEng, mas, speedorfuel);
                                motorcycles_list.Add(sm);
                                sm.AddMotorcycleToDataGrid(motoDataGrid);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ïîìèëêà ïðè ÷èòàíí³ ôàéëó: " + ex.Message, "Ïîìèëêà", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/

        }
        private void î÷èñòèòèToolStripMenuItem_Click(object sender, EventArgs e)
        {
            motoDataGrid.Rows.Clear();
            motorcycles_list.Clear();
        }
        //private void ñîðòóâàòèToolStripMenuItem_Click(object sender, EventArgs e)
        //{

        //}

        //private void brandToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    motoDataGrid.Sort(motoDataGrid.Columns[0], ListSortDirection.Ascending);
        //}

        //private void modelToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    motoDataGrid.Sort(motoDataGrid.Columns[1], ListSortDirection.Ascending);
        //}

        //private void yearToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    motoDataGrid.Sort(motoDataGrid.Columns[2], ListSortDirection.Ascending);
        //}

        //private void priceToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    motoDataGrid.Sort(motoDataGrid.Columns[3], ListSortDirection.Ascending);
        //}

        //private void capacityToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    motoDataGrid.Sort(motoDataGrid.Columns[4], ListSortDirection.Ascending);
        //}

        //private void masToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    motoDataGrid.Sort(motoDataGrid.Columns[5], ListSortDirection.Ascending);
        //}

        //private void toolStripMenuItem2_Click(object sender, EventArgs e)
        //{

        //}
        private void motoDataGrid_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn column = motoDataGrid.Columns[e.ColumnIndex];

            ListSortDirection direction = isSortedAscending ? ListSortDirection.Ascending : ListSortDirection.Descending;

            motoDataGrid.Sort(column, direction);

            isSortedAscending = !isSortedAscending;

            column.HeaderCell.SortGlyphDirection = isSortedAscending
                ? SortOrder.Ascending
                : SortOrder.Descending;
        }

        private void motoDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                EditMotorcycleInList(e.RowIndex);
            }
            else
            {
                MessageBox.Show("Âèáðàíèé ðÿäîê íå ìàº â³äïîâ³äíîãî ìîòîöèêëà ó ñïèñêó.", "Ïîìèëêà", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            /*void UpdateDataGridRow(int rowIndex, Motorcycle updatedMotorcycle)
            //{
            //    DataGridViewRow row = motoDataGrid.Rows[rowIndex];

            //    motoDataGrid.Rows[rowIndex].Cells[0].Value = updatedMotorcycle.brand;
            //    row.Cells[1].Value = updatedMotorcycle.model;
            //    row.Cells[2].Value = updatedMotorcycle.year;
            //    row.Cells[3].Value = updatedMotorcycle.price;
            //    row.Cells[4].Value = updatedMotorcycle.capacityEng;
            //    row.Cells[5].Value = updatedMotorcycle.mas;

            //    if (updatedMotorcycle is SportMotorcycle sportMotorcycle)
            //    {
            //        row.Cells[6].Value = sportMotorcycle.topSpeed;
            //    }
            //    else if (updatedMotorcycle is TouringMotorcycle touringMotorcycle)
                {
                    row.Cells[6].Value = touringMotorcycle.fuelConsumption;
                }
            }*/
        }
        private void EditMotorcycleInList(int rowIndex)
        {
            AddItemsTotable editForm = new AddItemsTotable
            {
                Data = motorcycles_list[rowIndex]
            };

            editForm.ShowDialog();
            if (editForm.Data != null)
            {
                motorcycles_list[rowIndex] = editForm.Data;
                editForm.Data.EditMotorcycleToDataGrid(motoDataGrid, rowIndex);
                if (editForm.Data != motorcycles_list[rowIndex])
                {
                    MotorcycleChanged?.Invoke(editForm.Data);
                }
                editForm.Data = null;
            }

        }

        private void ïîøóêToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void LoadMotorcyclesFromFile(string filePath)
        {
            try
            {
                var lines = System.IO.File.ReadAllLines(filePath);

                foreach (var line in lines)
                {
                    var data = ParseLine(line);

                    Motorcycle motorcycle = CreateMotorcycle(data);
                    if (motorcycle != null)
                    {
                        AddMotorcycleToList(motorcycle, true);
                    }
                }
                MessageBox.Show("Äàí³ ç ôàéëó óñï³øíî äîäàíî!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string[] ParseLine(string line)
        {
            return line.Split(',').Select(d => d.Trim()).ToArray();
        }

        private Motorcycle CreateMotorcycle(string[] data)
        {
            if (data.Length == 7 && int.TryParse(data[2], out int year) &&
                double.TryParse(data[3], out double price) &&
                int.TryParse(data[4], out int capacityEng) &&
                int.TryParse(data[5], out int mass) &&
                int.TryParse(data[6], out int specificValue))
            {
                if (specificValue < 10)
                {
                    return new TouringMotorcycle(data[0], data[1], year, price, capacityEng, mass, specificValue);
                }
                else
                {
                    return new SportMotorcycle(data[0], data[1], year, price, capacityEng, mass, specificValue);
                }
            }
            return null;
        }

        private void SaveMotorcyclesToDotFile(string filePath)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (Motorcycle moto in motorcycles_list)
                    {
                        string motorcycleData = $"{moto.brand},{moto.model},{moto.year},{moto.price},{moto.capacityEng},{moto.mas}";
                        if (moto is SportMotorcycle sportMotorcycle)
                        {
                            motorcycleData += $",{sportMotorcycle.topSpeed}";
                        }
                        else if (moto is TouringMotorcycle touringMotorcycle)
                        {
                            motorcycleData += $",{touringMotorcycle.fuelConsumption}";
                        }
                        writer.WriteLine(motorcycleData);
                    }
                }
                MessageBox.Show("Äàí³ óñï³øíî çáåðåæåíî!", "Çáåðåæåííÿ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ïîìèëêà ïðè çáåðåæåíí³: {ex.Message}", "Ïîìèëêà", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void âèõ³äToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void çáåðåãòèßêToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "DOT files (*.dot)|*.dot|All files (*.*)|*.*",
                Title = "Çáåðåãòè ôàéë"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                SaveMotorcyclesToDotFile(filePath);
            }
        }

        private void â³äêðèòèßêToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "(*.csv, *.txt, *.dot)|*.csv;*.txt;*.dot|Âñ³ ôàéëè (*.*)|*.*",
                Title = "Îáåð³òü ôàéë äëÿ çàâàíòàæåííÿ"
            };

            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            string filePath = openFileDialog.FileName;
            LoadMotorcyclesFromFile(filePath);
        }

        private void äîäàòèToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AddItemsTotable form = new AddItemsTotable();
            form.ShowDialog();
            if (form.Data != null)
            {
                AddMotorcycleToList(form.Data, false);
                form.Data = null;
            }
        }


        //private void ïîøóêToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    FindItems findform = new FindItems();
        //    findform.ShowDialog();
        //}
    }
}


