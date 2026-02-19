namespace HotelReservation
{
    partial class AddAmountFormcs
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
            labelRezerwacja = new Label();
            labelKwota = new Label();
            labelDataPlatnosci = new Label();
            label4 = new Label();
            comboBoxRezerwacja = new ComboBox();
            numericKwota = new NumericUpDown();
            dateTimePickerPlatnosc = new DateTimePicker();
            comboBoxMetoda = new ComboBox();
            buttonZapiszPlatnosc = new Button();
            buttonAnulujPlatnosc = new Button();
            ((System.ComponentModel.ISupportInitialize)numericKwota).BeginInit();
            SuspendLayout();
            // 
            // labelRezerwacja
            // 
            labelRezerwacja.Location = new Point(20, 30);
            labelRezerwacja.Name = "labelRezerwacja";
            labelRezerwacja.Size = new Size(100, 23);
            labelRezerwacja.TabIndex = 0;
            labelRezerwacja.Text = "Rezerwacja";
            // 
            // labelKwota
            // 
            labelKwota.Location = new Point(20, 70);
            labelKwota.Name = "labelKwota";
            labelKwota.Size = new Size(100, 23);
            labelKwota.TabIndex = 1;
            labelKwota.Text = "Kwota";
            // 
            // labelDataPlatnosci
            // 
            labelDataPlatnosci.Location = new Point(20, 110);
            labelDataPlatnosci.Name = "labelDataPlatnosci";
            labelDataPlatnosci.Size = new Size(109, 23);
            labelDataPlatnosci.TabIndex = 2;
            labelDataPlatnosci.Text = "Data płatności";
            // 
            // label4
            // 
            label4.Location = new Point(20, 150);
            label4.Name = "label4";
            label4.Size = new Size(125, 23);
            label4.TabIndex = 3;
            label4.Text = "Metoda płatności";
            // 
            // comboBoxRezerwacja
            // 
            comboBoxRezerwacja.FormattingEnabled = true;
            comboBoxRezerwacja.Location = new Point(151, 30);
            comboBoxRezerwacja.Name = "comboBoxRezerwacja";
            comboBoxRezerwacja.Size = new Size(100, 28);
            comboBoxRezerwacja.TabIndex = 4;
            comboBoxRezerwacja.SelectedIndexChanged += comboBoxRezerwacja_SelectedIndexChanged;
            // 
            // numericKwota
            // 
            numericKwota.DecimalPlaces = 2;
            numericKwota.Location = new Point(151, 70);
            numericKwota.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numericKwota.Name = "numericKwota";
            numericKwota.Size = new Size(120, 27);
            numericKwota.TabIndex = 5;
            // 
            // dateTimePickerPlatnosc
            // 
            dateTimePickerPlatnosc.Format = DateTimePickerFormat.Short;
            dateTimePickerPlatnosc.Location = new Point(151, 110);
            dateTimePickerPlatnosc.Name = "dateTimePickerPlatnosc";
            dateTimePickerPlatnosc.Size = new Size(150, 27);
            dateTimePickerPlatnosc.TabIndex = 6;
            // 
            // comboBoxMetoda
            // 
            comboBoxMetoda.FormattingEnabled = true;
            comboBoxMetoda.Items.AddRange(new object[] { "Gotówka", "Karta", "Przelew", "BLIK" });
            comboBoxMetoda.Location = new Point(151, 147);
            comboBoxMetoda.Name = "comboBoxMetoda";
            comboBoxMetoda.Size = new Size(150, 28);
            comboBoxMetoda.TabIndex = 7;
            // 
            // buttonZapiszPlatnosc
            // 
            buttonZapiszPlatnosc.Location = new Point(130, 200);
            buttonZapiszPlatnosc.Name = "buttonZapiszPlatnosc";
            buttonZapiszPlatnosc.Size = new Size(90, 35);
            buttonZapiszPlatnosc.TabIndex = 8;
            buttonZapiszPlatnosc.Text = "Zapisz";
            buttonZapiszPlatnosc.UseVisualStyleBackColor = true;
            buttonZapiszPlatnosc.Click += buttonZapiszPlatnosc_Click;
            // 
            // buttonAnulujPlatnosc
            // 
            buttonAnulujPlatnosc.Location = new Point(240, 200);
            buttonAnulujPlatnosc.Name = "buttonAnulujPlatnosc";
            buttonAnulujPlatnosc.Size = new Size(90, 35);
            buttonAnulujPlatnosc.TabIndex = 9;
            buttonAnulujPlatnosc.Text = "Anuluj";
            buttonAnulujPlatnosc.UseVisualStyleBackColor = true;
            buttonAnulujPlatnosc.Click += buttonAnulujPlatnosc_Click;
            // 
            // AddAmountFormcs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonAnulujPlatnosc);
            Controls.Add(buttonZapiszPlatnosc);
            Controls.Add(comboBoxMetoda);
            Controls.Add(dateTimePickerPlatnosc);
            Controls.Add(numericKwota);
            Controls.Add(comboBoxRezerwacja);
            Controls.Add(label4);
            Controls.Add(labelDataPlatnosci);
            Controls.Add(labelKwota);
            Controls.Add(labelRezerwacja);
            Name = "AddAmountFormcs";
            Text = "AddAmountFormcs";
            Load += AddAmountFormcs_Load;
            ((System.ComponentModel.ISupportInitialize)numericKwota).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label labelRezerwacja;
        private Label labelKwota;
        private Label labelDataPlatnosci;
        private Label label4;
        private Button buttonZapiszPlatnosc;
        private Button buttonAnulujPlatnosc;
        public ComboBox comboBoxRezerwacja;
        public NumericUpDown numericKwota;
        public DateTimePicker dateTimePickerPlatnosc;
        public ComboBox comboBoxMetoda;
    }
}