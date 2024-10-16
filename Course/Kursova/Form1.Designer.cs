namespace Kursova
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
            menuStrip1 = new MenuStrip();
            вихідToolStripMenuItem = new ToolStripMenuItem();
            файлToolStripMenuItem = new ToolStripMenuItem();
            зберегтиЯкToolStripMenuItem = new ToolStripMenuItem();
            відкритиЯкToolStripMenuItem = new ToolStripMenuItem();
            додатиToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)motoDataGrid).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // motoDataGrid
            // 
            motoDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            motoDataGrid.Location = new Point(510, 141);
            motoDataGrid.Name = "motoDataGrid";
            motoDataGrid.RowHeadersWidth = 62;
            motoDataGrid.Size = new Size(360, 225);
            motoDataGrid.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { вихідToolStripMenuItem, файлToolStripMenuItem, додатиToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1091, 33);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // вихідToolStripMenuItem
            // 
            вихідToolStripMenuItem.Name = "вихідToolStripMenuItem";
            вихідToolStripMenuItem.Size = new Size(70, 29);
            вихідToolStripMenuItem.Text = "Вихід";
            вихідToolStripMenuItem.Click += вихідToolStripMenuItem_Click_1;
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
            зберегтиЯкToolStripMenuItem.Size = new Size(270, 34);
            зберегтиЯкToolStripMenuItem.Text = "Зберегти як";
            зберегтиЯкToolStripMenuItem.Click += зберегтиЯкToolStripMenuItem_Click_1;
            // 
            // відкритиЯкToolStripMenuItem
            // 
            відкритиЯкToolStripMenuItem.Name = "відкритиЯкToolStripMenuItem";
            відкритиЯкToolStripMenuItem.Size = new Size(270, 34);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1091, 589);
            Controls.Add(motoDataGrid);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
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
    }
}
