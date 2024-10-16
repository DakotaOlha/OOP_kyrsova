using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursova
{
    public partial class AddItemsTotable : Form
    {
        public Motorcycle Data { get; set; }
        public AddItemsTotable()
        {
            InitializeComponent();
            ConfigureForm();

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

            brendTextBox.Text = Data.brand;
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

        private void addTableButton_Click(object sender, EventArgs e)
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
        private bool ValidateInput()
        {
            return sportRadionButton.Checked || travelRadioButton.Checked;
        }
        private SportMotorcycle CreateSportMotorcycle()
        {
            return new SportMotorcycle(
                brendTextBox.Text,
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
            return new TouringMotorcycle(
                brendTextBox.Text,
                modelTextBox.Text,
                Convert.ToInt16(yearPicker.Value.Year),
                Convert.ToDouble(priceTextBox.Text),
                Convert.ToInt32(capacityEngTextBox.Text),
                Convert.ToInt32(masTextBox.Text),
                Convert.ToInt32(addperTextBox.Text)
            );
        }
        private void sportRadioButton_CheckedChanged(object sender, EventArgs e)
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

        private void yearTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowOnlyDigits(e);
        }

        private void priceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowOnlyDigits(e);
        }

        private void capacityEngTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowOnlyDigits(e);
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
        private void AddItemsTotable_Load(object sender, EventArgs e)
        {
            addTableButton.Text = "Додати";
            PopulateFields();
        }
    }
}
