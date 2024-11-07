using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kursova.Models;

namespace Kursova
{
    public partial class AddItemsTotable : Form
    {
        public Motorcycle Data { get; set; }
        public AddItemsTotable()
        {
            InitializeComponent();

        }
        private void ConfigureForm()
        {
            this.ShowIcon = false;
            yearPicker.Format = DateTimePickerFormat.Custom;
            yearPicker.CustomFormat = "yyyy";
            yearPicker.ShowUpDown = true;
        }

        private void PopulateFields()
        {
            if (Data == null) return;

            brendTextBox.Text = Data.MotoBrand.MotoOwner.Name;
            AddressTextBox.Text = Data.MotoBrand.MotoOwner.Address;
            countryTextBox.Text = Data.MotoBrand.Country;
            modelTextBox.Text = Data.model;
            yearPicker.Value = new DateTime(Data.year, 1, 1);
            priceTextBox.Text = Data.price.ToString();
            capacityEngTextBox.Text = Data.capacityEng.ToString();
            masTextBox.Text = Data.mas.ToString();
            if (Data is SportMotorcycle sportMotorcycle)
            {
                addperTextBox.Text = sportMotorcycle.topSpeed.ToString();
                sportRadionButton.Checked = true;
            }
            else if (Data is TouringMotorcycle touringMotorcycle)
            {
                addperTextBox.Text = touringMotorcycle.fuelConsumption.ToString();
                travelRadioButton.Checked = true;
            }
            addTableButton.Text = "Змінити";
        }
        private bool ValidateInput()
        {
            return sportRadionButton.Checked || travelRadioButton.Checked;
        }
        private SportMotorcycle CreateSportMotorcycle()
        {
            Owner own = new Owner
            {
                Name = brendTextBox.Text,
                Address = AddressTextBox.Text
            };
            return new SportMotorcycle(
                own,
                countryTextBox.Text,
                modelTextBox.Text,
                Convert.ToInt16(yearPicker.Value.Year),
                Convert.ToDouble(priceTextBox.Text),
                Convert.ToInt32(capacityEngTextBox.Text),
                Convert.ToInt32(masTextBox.Text),
                Convert.ToInt32(addperTextBox.Text)
            );
        }
        private TouringMotorcycle CreateTouringMotorcycle()
        {
            Owner own = new Owner
            {
                Name = brendTextBox.Text,
                Address = AddressTextBox.Text
            };
            return new TouringMotorcycle(
                own,
                countryTextBox.Text,
                modelTextBox.Text,
                Convert.ToInt16(yearPicker.Value.Year),
                Convert.ToDouble(priceTextBox.Text),
                Convert.ToInt32(capacityEngTextBox.Text),
                Convert.ToInt32(masTextBox.Text),
                Convert.ToDouble(addperTextBox.Text)
            );
        }
        private void AllowOnlyLetters(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void AllowOnlyDigits(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void addTableButton_Click_1(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                if (ValidateInput())
                {
                    if (sportRadionButton.Checked)
                        Data = CreateSportMotorcycle();
                    else
                        Data = CreateTouringMotorcycle();
                    this.Close();
                }
                else Console.WriteLine("Виберіть тип мотоцикла!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void sportRadionButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sportRadionButton.Checked)
                travelRadioButton.Checked = false;
            addperTextBox.Visible = true;
            addperLabel.Visible = true;
            addperLabel.Text = "Макс. швидкість";
        }

        private void travelRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (travelRadioButton.Checked)
                sportRadionButton.Checked = false;
            addperTextBox.Visible = true;
            addperLabel.Visible = true;
            addperLabel.Text = "Витрати палива";
        }

        private void brendTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowOnlyLetters(e);
        }
        private void modelTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowOnlyLetters(e);
        }
        private void priceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowOnlyDigits(e);
        }
        private void capacityEngTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowOnlyDigits(e);
        }
        private void masTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowOnlyDigits(e);
        }

        private void AddItemsTotable_Load_1(object sender, EventArgs e)
        {
            addTableButton.Text = "Додати";
            ConfigureForm();
            PopulateFields();
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(brendTextBox.Text) ||
                string.IsNullOrWhiteSpace(modelTextBox.Text) ||
                string.IsNullOrWhiteSpace(priceTextBox.Text) ||
                string.IsNullOrWhiteSpace(capacityEngTextBox.Text) ||
                string.IsNullOrWhiteSpace(masTextBox.Text) ||
                string.IsNullOrWhiteSpace(addperTextBox.Text) ||
                string.IsNullOrWhiteSpace(countryTextBox.Text))
            {
                MessageBox.Show("Будь ласка, заповніть всі поля.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!double.TryParse(priceTextBox.Text, out double price) || price <= 0)
            {
                MessageBox.Show("Невірний формат ціни. Введіть коректне число.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!int.TryParse(capacityEngTextBox.Text, out int capacityEng) || capacityEng <= 0)
            {
                MessageBox.Show("Невірний формат об'єму двигуна. Введіть коректне ціле число.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!int.TryParse(masTextBox.Text, out int mas) || mas <= 0)
            {
                MessageBox.Show("Невірний формат маси. Введіть коректне ціле число.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!double.TryParse(addperTextBox.Text, out double addperValue))
            {
                MessageBox.Show("Невірний формат специфічного параметра. Введіть коректне ціле число.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void AddItemsTotable_Enter(object sender, EventArgs e)
        {
            addTableButton_Click_1(sender, e);
        }

        private void addperTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                addTableButton_Click_1(sender, e);
            }
        }
    }
}
