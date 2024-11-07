using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using Newtonsoft.Json;
using Kursova.Models;

namespace Kursova
{
    public partial class Form1 : Form
    {
        SortedList<int, Motorcycle> motorcycles_list = new SortedList<int, Motorcycle>();
        bool isSortedAscending = true;

        private int ID = 1;

        public delegate void MotorcycleDeleteDelegate(Motorcycle motorcycle, bool rem);

        public event MotorcycleDeleteDelegate MotorcycleDelete;

        public delegate void MotorcycleChangedDelegate(Motorcycle motorcycle);

        public event MotorcycleChangedDelegate MotorcycleChanged;

        public delegate void MotorcycleDelegate(Motorcycle motorcycle);

        public delegate void EventHandlerDelegate(object sender, EventArgs e);

        public void Form_LoadHandler(object sender, EventArgs e)
        {
            MessageBox.Show("Форма завантажена");
        }

        public void DynamicMethodSelector(Motorcycle motorcycle)
        {
            MotorcycleDelegate motorcycleAction;

            if (motorcycle is SportMotorcycle)
            {
                motorcycleAction = ProcessChangingSportMotorcycle;
            }
            else
            {
                motorcycleAction = ProcessChangingTouringMotorcycle;
            }

            motorcycleAction?.Invoke(motorcycle);
        }

        public void ProcessChangingSportMotorcycle(Motorcycle motorcycle)
        {
            MessageBox.Show("Спортивний мотоцикл змінено!");
        }

        public void ProcessChangingTouringMotorcycle(Motorcycle motorcycle)
        {
            MessageBox.Show("Туристичний мотоцикл змінено!");
        }

        public void AddMotorcycle(Motorcycle motorcycle)
        {
            motorcycles_list.Add(ID, motorcycle);
            motoDataGrid.AddMoto(motorcycle, ID);
            ID++;
        }

        private void OnMotorcycleDelete(Motorcycle motorcycle, bool rem)
        {
            if (rem)
            {
                MessageBox.Show($"{motorcycle.MotoBrand} {motorcycle.model} успішно видалено!");
            }
        }

        private void OnMotorcycleChanged(Motorcycle motorcycle)
        {
            MessageBox.Show($"{motorcycle.MotoBrand} {motorcycle.model} успішно змінено!");
        }

        MotorcycleDelegate ChangeAs;
        public Form1()
        {
            InitializeComponent();
            MotorcycleDelete += OnMotorcycleDelete;
            MotorcycleChanged += OnMotorcycleChanged;
            ChangeAs = DynamicMethodSelector;
            this.Load += new EventHandler(Form_LoadHandler);
        }

        public void AddMotorcycleToList(Motorcycle moto)
        {
            AddMotorcycle(moto);
        }
        /*private void FileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "(*.csv, *.txt)|*.csv;*.txt|Всі файли (*.*)|*.*",
                Title = "Оберіть файл для завантаження"
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
                MessageBox.Show("Помилка при читанні файлу: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

    }*/
        //private void сортуватиToolStripMenuItem_Click(object sender, EventArgs e)
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
        private void EditMotorcycleInList(int rowIndex)
        {
            int motorcycleId = (int)motoDataGrid.Rows[rowIndex].Cells[0].Value;

            if (motorcycles_list.ContainsKey(motorcycleId))
            {
                AddItemsTotable editForm = new AddItemsTotable
                {
                    Data = motorcycles_list[motorcycleId]
                };

                editForm.ShowDialog();

                if (editForm.Data != null)
                {
                    motoDataGrid.EditMoto(editForm.Data, rowIndex);

                    if (editForm.Data != motorcycles_list[motorcycleId])
                    {
                        motorcycles_list[motorcycleId] = editForm.Data;
                        MotorcycleChanged?.Invoke(editForm.Data);
                        ChangeAs?.Invoke(editForm.Data);
                    }
                    editForm.Data = new Motorcycle();
                }
            }
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
                        AddMotorcycleToList(motorcycle);
                    }
                }
                MessageBox.Show("Дані з файлу успішно додано!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadMotorcyclesFromJsonFile(string filePath)
        {
            var json = File.ReadAllText(filePath);
            var settings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Auto
            };

            var motorcycles = JsonConvert.DeserializeObject<List<Motorcycle>>(json, settings);

            foreach (var motorcycle in motorcycles)
            {
                if (motorcycle is SportMotorcycle sportMotorcycle)
                {
                    motoDataGrid.AddMoto(sportMotorcycle, ID);
                }
                else if (motorcycle is TouringMotorcycle touringMotorcycle)
                {
                    motoDataGrid.AddMoto(touringMotorcycle, ID);
                }
                else
                {
                    motoDataGrid.AddMoto(motorcycle, ID);
                }

                motorcycles_list.Add(ID, motorcycle);
                ID++;
            }
        }



        private string[] ParseLine(string line)
        {
            return line.Split(',').Select(d => d.Trim()).ToArray();
        }

        private Motorcycle CreateMotorcycle(string[] data)
        {
            if (data.Length == 8 && int.TryParse(data[4], out int year) &&
                double.TryParse(data[5], out double price) &&
                int.TryParse(data[6], out int capacityEng) &&
                int.TryParse(data[7], out int mass) &&
                int.TryParse(data[8], out int specificValue))
            {
                Owner owner = new Owner
                {
                    Name = data[0],
                    Address = data[1],
                };
                if (specificValue < 20)
                {
                    return new TouringMotorcycle(owner, data[2], data[3], year, price, capacityEng, mass, specificValue);
                }
                else
                {
                    return new SportMotorcycle(owner, data[1], data[2], year, price, capacityEng, mass, specificValue);
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
                    foreach (KeyValuePair<int, Motorcycle> entry in motorcycles_list)
                    {
                        Motorcycle moto = entry.Value;
                        string motorcycleData = $"{moto.MotoBrand.MotoOwner.Name},{moto.MotoBrand.MotoOwner.Address}.{moto.model},{moto.year},{moto.price},{moto.capacityEng},{moto.mas}";

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
                MessageBox.Show("Дані успішно збережено!", "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при збереженні: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveMotorcyclesToJson(string filePath)
        {
            List<Motorcycle> motorcycles = new List<Motorcycle>();

            foreach (DataGridViewRow row in motoDataGrid.Rows)
            {
                if (row.IsNewRow) continue;

                var cellValue = row.Cells["addper"].Value;
                double numericValue = 0;
                bool isNumeric = cellValue != null && double.TryParse(cellValue.ToString(), out numericValue);

                if (isNumeric)
                {
                    if (numericValue < 50)
                    {
                        var motorcycle = new TouringMotorcycle
                        {
                            MotoBrand = new Brand
                            {
                                MotoOwner = new Owner
                                {
                                    Name = row.Cells["Owner_name"].Value.ToString(),
                                    Address = row.Cells["Address"].Value.ToString(),
                                },
                                Country = row.Cells["Country"].Value.ToString()
                            },
                            model = row.Cells["Model"].Value.ToString(),
                            year = Convert.ToInt32(row.Cells["Year"].Value),
                            price = Convert.ToDouble(row.Cells["Price"].Value),
                            capacityEng = Convert.ToInt32(row.Cells["Eng_Capacity"].Value),
                            mas = Convert.ToInt32(row.Cells["Mas"].Value),
                            fuelConsumption = numericValue
                        };
                        motorcycles.Add(motorcycle);
                    }
                    else
                    {
                        var motorcycle = new SportMotorcycle
                        {
                            MotoBrand = new Brand
                            {
                                MotoOwner = new Owner
                                {
                                    Name = row.Cells["Owner_name"].Value.ToString(),
                                    Address = row.Cells["Address"].Value.ToString(),
                                },
                                Country = row.Cells["Country"].Value.ToString()
                            },
                            model = row.Cells["Model"].Value.ToString(),
                            year = Convert.ToInt32(row.Cells["Year"].Value),
                            price = Convert.ToDouble(row.Cells["Price"].Value),
                            capacityEng = Convert.ToInt32(row.Cells["Eng_Capacity"].Value),
                            mas = Convert.ToInt32(row.Cells["Mas"].Value),
                            topSpeed = (int)numericValue
                        };
                        motorcycles.Add(motorcycle);
                    }

                    var settings = new JsonSerializerSettings
                    {
                        TypeNameHandling = TypeNameHandling.Auto
                    };

                    var json = JsonConvert.SerializeObject(motorcycles_list.Values.ToList(), Formatting.Indented, settings);
                    File.WriteAllText(filePath, json);
                }
            }
        }

        private void вихідToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void зберегтиЯкToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "JSON files (*.json)|*.json|DOT files (*.dot)|*.dot|All files (*.*)|*.*",
                Title = "Зберегти файл"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                if (filePath.EndsWith(".json", StringComparison.OrdinalIgnoreCase))
                {
                    SaveMotorcyclesToJson(filePath);
                }
                else
                {
                    SaveMotorcyclesToDotFile(filePath);
                }
            }
        }

        private void відкритиЯкToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "JSON files (*.json)|*.json|DOT files (*.dot)|*.dot|All files (*.*)|*.*",
                Title = "Оберіть файл для завантаження"
            };

            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            string filePath = openFileDialog.FileName;
            if (filePath.EndsWith(".json", StringComparison.OrdinalIgnoreCase))
            {
                LoadMotorcyclesFromJsonFile(filePath);
            }
            else
            {
                LoadMotorcyclesFromFile(filePath);
            }
        }

        private void додатиToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AddItemsTotable form = new AddItemsTotable();
            form.ShowDialog();
            if (form.Data != null)
            {
                AddMotorcycleToList(form.Data);
                form.Data = null;
            }
        }

        private void очиститиToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            motoDataGrid.Rows.Clear();
            motorcycles_list.Clear();
            ID = 1;
        }

        private void motoDataGrid_ColumnHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn column = motoDataGrid.Columns[e.ColumnIndex];

            ListSortDirection direction = isSortedAscending ? ListSortDirection.Ascending : ListSortDirection.Descending;

            motoDataGrid.Sort(column, direction);

            isSortedAscending = !isSortedAscending;

            column.HeaderCell.SortGlyphDirection = isSortedAscending
                ? SortOrder.Ascending
                : SortOrder.Descending;
        }

        private void motoDataGrid_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (motorcycles_list.Any() && e.RowIndex < motorcycles_list.Count() && e.RowIndex >= 0)
            {
                EditMotorcycleInList(e.RowIndex);
            }
            else
            {
                MessageBox.Show("Вибраний рядок не має відповідного мотоцикла у списку.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void видалитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (motoDataGrid.SelectedRows.Count > 0)
            {
                int rowIndex = motoDataGrid.SelectedRows[0].Index;
                int motorcycleId = (int)motoDataGrid.Rows[rowIndex].Cells[0].Value;
                motorcycles_list.Remove(motorcycleId);
                motoDataGrid.Rows.RemoveAt(rowIndex);
                MotorcycleDelete?.Invoke(motorcycles_list[rowIndex], true);
            }
            else
            {
                MessageBox.Show("Виберіть рядок для видалення.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            this.Text = "";
            this.ShowIcon = false;
        }

        private void чиРікЄТеперішнімToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(motoDataGrid.SelectedRows.Count > 0) 
            {
                int selectedYear = Convert.ToInt32(motoDataGrid.SelectedRows[0].Cells["Year"].Value);

                if (selectedYear == DateTime.Now.Year)
                {
                    MessageBox.Show("Це поточний рік");
                }
                else
                {
                    MessageBox.Show("Це не поточний рік");
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть рядок.");
            }
        }

        //private void пошукToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    FindItems findform = new FindItems();
        //    findform.ShowDialog();
        //}
    }
}