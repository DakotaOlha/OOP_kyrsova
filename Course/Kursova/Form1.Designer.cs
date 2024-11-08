﻿namespace Kursova
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            motoDataGrid = new DataGridView();
            IdMoto = new DataGridViewTextBoxColumn();
            Owner_name = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            Country = new DataGridViewTextBoxColumn();
            Model = new DataGridViewTextBoxColumn();
            Year = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Eng_Capacity = new DataGridViewTextBoxColumn();
            Mas = new DataGridViewTextBoxColumn();
            addper = new DataGridViewTextBoxColumn();
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            зберегтиЯкToolStripMenuItem = new ToolStripMenuItem();
            відкритиЯкToolStripMenuItem = new ToolStripMenuItem();
            додатиToolStripMenuItem = new ToolStripMenuItem();
            видалитиToolStripMenuItem = new ToolStripMenuItem();
            очиститиToolStripMenuItem = new ToolStripMenuItem();
            вихідToolStripMenuItem = new ToolStripMenuItem();
            чиРікЄТеперішнімToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)motoDataGrid).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // motoDataGrid
            // 
            motoDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            motoDataGrid.Columns.AddRange(new DataGridViewColumn[] { IdMoto, Owner_name, Address, Country, Model, Year, Price, Eng_Capacity, Mas, addper });
            motoDataGrid.EditMode = DataGridViewEditMode.EditProgrammatically;
            motoDataGrid.Location = new Point(48, 66);
            motoDataGrid.Name = "motoDataGrid";
            motoDataGrid.RowHeadersWidth = 62;
            motoDataGrid.Size = new Size(1122, 455);
            motoDataGrid.TabIndex = 0;
            motoDataGrid.CellDoubleClick += motoDataGrid_CellDoubleClick_1;
            motoDataGrid.ColumnHeaderMouseClick += motoDataGrid_ColumnHeaderMouseClick_1;
            // 
            // IdMoto
            // 
            IdMoto.HeaderText = "Номер";
            IdMoto.MinimumWidth = 8;
            IdMoto.Name = "IdMoto";
            IdMoto.Width = 150;
            // 
            // Owner_name
            // 
            Owner_name.HeaderText = "Власник бренду";
            Owner_name.MinimumWidth = 8;
            Owner_name.Name = "Owner_name";
            Owner_name.Width = 150;
            // 
            // Address
            // 
            Address.HeaderText = "Адрес";
            Address.MinimumWidth = 8;
            Address.Name = "Address";
            Address.Width = 150;
            // 
            // Country
            // 
            Country.HeaderText = "Країна";
            Country.MinimumWidth = 8;
            Country.Name = "Country";
            Country.Width = 150;
            // 
            // Model
            // 
            Model.HeaderText = "Модель";
            Model.MinimumWidth = 8;
            Model.Name = "Model";
            Model.Width = 150;
            // 
            // Year
            // 
            Year.HeaderText = "Рік";
            Year.MinimumWidth = 8;
            Year.Name = "Year";
            Year.Width = 150;
            // 
            // Price
            // 
            Price.HeaderText = "Ціна";
            Price.MinimumWidth = 8;
            Price.Name = "Price";
            Price.Width = 150;
            // 
            // Eng_Capacity
            // 
            Eng_Capacity.HeaderText = "Об'єм двигуна";
            Eng_Capacity.MinimumWidth = 8;
            Eng_Capacity.Name = "Eng_Capacity";
            Eng_Capacity.Width = 150;
            // 
            // Mas
            // 
            Mas.HeaderText = "Маса";
            Mas.MinimumWidth = 8;
            Mas.Name = "Mas";
            Mas.Width = 150;
            // 
            // addper
            // 
            addper.HeaderText = "Макс. швидкість/витрати палива";
            addper.MinimumWidth = 8;
            addper.Name = "addper";
            addper.Width = 150;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, додатиToolStripMenuItem, видалитиToolStripMenuItem, очиститиToolStripMenuItem, вихідToolStripMenuItem, чиРікЄТеперішнімToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1301, 33);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { зберегтиЯкToolStripMenuItem, відкритиЯкToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(69, 29);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // зберегтиЯкToolStripMenuItem
            // 
            зберегтиЯкToolStripMenuItem.Name = "зберегтиЯкToolStripMenuItem";
            зберегтиЯкToolStripMenuItem.Size = new Size(210, 34);
            зберегтиЯкToolStripMenuItem.Text = "Зберегти як";
            зберегтиЯкToolStripMenuItem.Click += зберегтиЯкToolStripMenuItem_Click_1;
            // 
            // відкритиЯкToolStripMenuItem
            // 
            відкритиЯкToolStripMenuItem.Name = "відкритиЯкToolStripMenuItem";
            відкритиЯкToolStripMenuItem.Size = new Size(210, 34);
            відкритиЯкToolStripMenuItem.Text = "Відкрити як";
            відкритиЯкToolStripMenuItem.Click += відкритиЯкToolStripMenuItem_Click_1;
            // 
            // додатиToolStripMenuItem
            // 
            додатиToolStripMenuItem.Name = "додатиToolStripMenuItem";
            додатиToolStripMenuItem.Size = new Size(87, 29);
            додатиToolStripMenuItem.Text = "Додати";
            додатиToolStripMenuItem.Click += додатиToolStripMenuItem_Click_1;
            // 
            // видалитиToolStripMenuItem
            // 
            видалитиToolStripMenuItem.Name = "видалитиToolStripMenuItem";
            видалитиToolStripMenuItem.Size = new Size(103, 29);
            видалитиToolStripMenuItem.Text = "Видалити";
            видалитиToolStripMenuItem.Click += видалитиToolStripMenuItem_Click;
            // 
            // очиститиToolStripMenuItem
            // 
            очиститиToolStripMenuItem.Name = "очиститиToolStripMenuItem";
            очиститиToolStripMenuItem.Size = new Size(104, 29);
            очиститиToolStripMenuItem.Text = "Очистити";
            очиститиToolStripMenuItem.Click += очиститиToolStripMenuItem_Click_1;
            // 
            // вихідToolStripMenuItem
            // 
            вихідToolStripMenuItem.Name = "вихідToolStripMenuItem";
            вихідToolStripMenuItem.Size = new Size(70, 29);
            вихідToolStripMenuItem.Text = "Вихід";
            вихідToolStripMenuItem.Click += вихідToolStripMenuItem_Click_1;
            // 
            // чиРікЄТеперішнімToolStripMenuItem
            // 
            чиРікЄТеперішнімToolStripMenuItem.Name = "чиРікЄТеперішнімToolStripMenuItem";
            чиРікЄТеперішнімToolStripMenuItem.Size = new Size(188, 29);
            чиРікЄТеперішнімToolStripMenuItem.Text = "Чи рік є теперішнім";
            чиРікЄТеперішнімToolStripMenuItem.Click += чиРікЄТеперішнімToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1301, 589);
            Controls.Add(motoDataGrid);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)motoDataGrid).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView motoDataGrid;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem вихідToolStripMenuItem;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem зберегтиЯкToolStripMenuItem;
        private ToolStripMenuItem відкритиЯкToolStripMenuItem;
        private ToolStripMenuItem додатиToolStripMenuItem;
        private ToolStripMenuItem очиститиToolStripMenuItem;
        private ToolStripMenuItem видалитиToolStripMenuItem;
        private DataGridViewTextBoxColumn IdMoto;
        private DataGridViewTextBoxColumn Owner_name;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn Country;
        private DataGridViewTextBoxColumn Model;
        private DataGridViewTextBoxColumn Year;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Eng_Capacity;
        private DataGridViewTextBoxColumn Mas;
        private DataGridViewTextBoxColumn addper;
        private ToolStripMenuItem чиРікЄТеперішнімToolStripMenuItem;
    }
}
