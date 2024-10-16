namespace Kursova
{
    partial class AddItemsTotable
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            addTableButton = new Button();
            brandLabel = new Label();
            modelLabel = new Label();
            yearLabel = new Label();
            priceLabel = new Label();
            capacityEngLabel = new Label();
            masLibel = new Label();
            addperLabel = new Label();
            sportRadionButton = new RadioButton();
            travelRadioButton = new RadioButton();
            brendTextBox = new TextBox();
            modelTextBox = new TextBox();
            yearPicker = new DateTimePicker();
            priceTextBox = new TextBox();
            capacityEngTextBox = new TextBox();
            masTextBox = new TextBox();
            addperTextBox = new TextBox();
            SuspendLayout();
            // 
            // addTableButton
            // 
            addTableButton.BackColor = Color.LemonChiffon;
            addTableButton.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            addTableButton.Location = new Point(141, 493);
            addTableButton.Name = "addTableButton";
            addTableButton.Size = new Size(285, 34);
            addTableButton.TabIndex = 0;
            addTableButton.Text = "Додати";
            addTableButton.UseVisualStyleBackColor = false;
            addTableButton.Click += addTableButton_Click_1;
            // 
            // brandLabel
            // 
            brandLabel.AutoSize = true;
            brandLabel.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            brandLabel.Location = new Point(46, 53);
            brandLabel.Name = "brandLabel";
            brandLabel.Size = new Size(78, 26);
            brandLabel.TabIndex = 1;
            brandLabel.Text = "Бренд";
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            modelLabel.Location = new Point(46, 102);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new Size(94, 26);
            modelLabel.TabIndex = 2;
            modelLabel.Text = "Модель";
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            yearLabel.Location = new Point(46, 157);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new Size(48, 26);
            yearLabel.TabIndex = 3;
            yearLabel.Text = "Рік";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            priceLabel.Location = new Point(46, 205);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(64, 26);
            priceLabel.TabIndex = 4;
            priceLabel.Text = "Ціна";
            // 
            // capacityEngLabel
            // 
            capacityEngLabel.AutoSize = true;
            capacityEngLabel.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            capacityEngLabel.Location = new Point(46, 257);
            capacityEngLabel.Name = "capacityEngLabel";
            capacityEngLabel.Size = new Size(170, 26);
            capacityEngLabel.TabIndex = 5;
            capacityEngLabel.Text = "Об'єм двигуна";
            // 
            // masLibel
            // 
            masLibel.AutoSize = true;
            masLibel.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            masLibel.Location = new Point(46, 313);
            masLibel.Name = "masLibel";
            masLibel.Size = new Size(70, 26);
            masLibel.TabIndex = 6;
            masLibel.Text = "Маса";
            // 
            // addperLabel
            // 
            addperLabel.AutoSize = true;
            addperLabel.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            addperLabel.Location = new Point(46, 428);
            addperLabel.Name = "addperLabel";
            addperLabel.Size = new Size(198, 26);
            addperLabel.TabIndex = 7;
            addperLabel.Text = "Макс. швидкість";
            addperLabel.Visible = false;
            // 
            // sportRadionButton
            // 
            sportRadionButton.AutoSize = true;
            sportRadionButton.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            sportRadionButton.Location = new Point(46, 369);
            sportRadionButton.Name = "sportRadionButton";
            sportRadionButton.Size = new Size(173, 30);
            sportRadionButton.TabIndex = 8;
            sportRadionButton.TabStop = true;
            sportRadionButton.Text = "Спортивний";
            sportRadionButton.UseVisualStyleBackColor = true;
            sportRadionButton.CheckedChanged += sportRadionButton_CheckedChanged;
            // 
            // travelRadioButton
            // 
            travelRadioButton.AutoSize = true;
            travelRadioButton.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            travelRadioButton.Location = new Point(293, 369);
            travelRadioButton.Name = "travelRadioButton";
            travelRadioButton.Size = new Size(182, 30);
            travelRadioButton.TabIndex = 9;
            travelRadioButton.TabStop = true;
            travelRadioButton.Text = "Туристичний";
            travelRadioButton.UseVisualStyleBackColor = true;
            travelRadioButton.CheckedChanged += travelRadioButton_CheckedChanged;
            // 
            // brendTextBox
            // 
            brendTextBox.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            brendTextBox.Location = new Point(293, 50);
            brendTextBox.Name = "brendTextBox";
            brendTextBox.Size = new Size(229, 35);
            brendTextBox.TabIndex = 10;
            brendTextBox.KeyPress += brendTextBox_KeyPress;
            // 
            // modelTextBox
            // 
            modelTextBox.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            modelTextBox.Location = new Point(293, 99);
            modelTextBox.Name = "modelTextBox";
            modelTextBox.Size = new Size(229, 35);
            modelTextBox.TabIndex = 11;
            modelTextBox.KeyPress += modelTextBox_KeyPress;
            // 
            // yearPicker
            // 
            yearPicker.Location = new Point(293, 152);
            yearPicker.Name = "yearPicker";
            yearPicker.Size = new Size(229, 31);
            yearPicker.TabIndex = 12;
            // 
            // priceTextBox
            // 
            priceTextBox.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            priceTextBox.Location = new Point(293, 202);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(229, 35);
            priceTextBox.TabIndex = 13;
            priceTextBox.KeyPress += priceTextBox_KeyPress;
            // 
            // capacityEngTextBox
            // 
            capacityEngTextBox.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            capacityEngTextBox.Location = new Point(293, 254);
            capacityEngTextBox.Name = "capacityEngTextBox";
            capacityEngTextBox.Size = new Size(229, 35);
            capacityEngTextBox.TabIndex = 14;
            capacityEngTextBox.KeyPress += capacityEngTextBox_KeyPress;
            // 
            // masTextBox
            // 
            masTextBox.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            masTextBox.Location = new Point(293, 310);
            masTextBox.Name = "masTextBox";
            masTextBox.Size = new Size(229, 35);
            masTextBox.TabIndex = 15;
            masTextBox.KeyPress += masTextBox_KeyPress;
            // 
            // addperTextBox
            // 
            addperTextBox.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            addperTextBox.Location = new Point(293, 425);
            addperTextBox.Name = "addperTextBox";
            addperTextBox.Size = new Size(229, 35);
            addperTextBox.TabIndex = 16;
            addperTextBox.Visible = false;
            addperTextBox.KeyPress += addperTextBox_KeyPress;
            // 
            // AddItemsTotable
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 556);
            Controls.Add(addperTextBox);
            Controls.Add(masTextBox);
            Controls.Add(capacityEngTextBox);
            Controls.Add(priceTextBox);
            Controls.Add(yearPicker);
            Controls.Add(modelTextBox);
            Controls.Add(brendTextBox);
            Controls.Add(travelRadioButton);
            Controls.Add(sportRadionButton);
            Controls.Add(addperLabel);
            Controls.Add(masLibel);
            Controls.Add(capacityEngLabel);
            Controls.Add(priceLabel);
            Controls.Add(yearLabel);
            Controls.Add(modelLabel);
            Controls.Add(brandLabel);
            Controls.Add(addTableButton);
            Name = "AddItemsTotable";
            Text = "AddItemsTotable";
            Load += AddItemsTotable_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addTableButton;
        private Label brandLabel;
        private Label modelLabel;
        private Label yearLabel;
        private Label priceLabel;
        private Label capacityEngLabel;
        private Label masLibel;
        private Label addperLabel;
        private RadioButton sportRadionButton;
        private RadioButton travelRadioButton;
        private TextBox brendTextBox;
        private TextBox modelTextBox;
        private DateTimePicker yearPicker;
        private TextBox priceTextBox;
        private TextBox capacityEngTextBox;
        private TextBox masTextBox;
        private TextBox addperTextBox;
    }
}