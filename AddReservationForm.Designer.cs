namespace HotelReservation
{
    partial class AddReservationForm
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
            label1R_Gosc = new Label();
            label2R_Pokoj = new Label();
            label3DataOd = new Label();
            labelData_Do = new Label();
            labelStatus = new Label();
            comboBoxGosc = new ComboBox();
            comboBox2Pokoj = new ComboBox();
            dateTimePickerOd = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            comboBoxStatus = new ComboBox();
            buttonZapiszRez = new Button();
            buttonAnulujRez = new Button();
            SuspendLayout();
            // 
            // label1R_Gosc
            // 
            label1R_Gosc.Location = new Point(20, 30);
            label1R_Gosc.Name = "label1R_Gosc";
            label1R_Gosc.Size = new Size(100, 23);
            label1R_Gosc.TabIndex = 0;
            label1R_Gosc.Text = "Gość";
            // 
            // label2R_Pokoj
            // 
            label2R_Pokoj.Location = new Point(20, 70);
            label2R_Pokoj.Name = "label2R_Pokoj";
            label2R_Pokoj.Size = new Size(100, 23);
            label2R_Pokoj.TabIndex = 1;
            label2R_Pokoj.Text = "Pokój";
            // 
            // label3DataOd
            // 
            label3DataOd.Location = new Point(20, 110);
            label3DataOd.Name = "label3DataOd";
            label3DataOd.Size = new Size(131, 23);
            label3DataOd.TabIndex = 2;
            label3DataOd.Text = "Data ropoczęcia";
            label3DataOd.Click += label3DataOd_Click;
            // 
            // labelData_Do
            // 
            labelData_Do.Location = new Point(20, 150);
            labelData_Do.Name = "labelData_Do";
            labelData_Do.Size = new Size(131, 23);
            labelData_Do.TabIndex = 3;
            labelData_Do.Text = "Data zakończenia";
            // 
            // labelStatus
            // 
            labelStatus.Location = new Point(20, 190);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(100, 23);
            labelStatus.TabIndex = 4;
            labelStatus.Text = "Status";
            labelStatus.Click += label5_Click;
            // 
            // comboBoxGosc
            // 
            comboBoxGosc.FormattingEnabled = true;
            comboBoxGosc.Location = new Point(149, 27);
            comboBoxGosc.Name = "comboBoxGosc";
            comboBoxGosc.Size = new Size(300, 28);
            comboBoxGosc.TabIndex = 5;
            comboBoxGosc.SelectedIndexChanged += comboBoxGosc_SelectedIndexChanged;
            // 
            // comboBox2Pokoj
            // 
            comboBox2Pokoj.FormattingEnabled = true;
            comboBox2Pokoj.Location = new Point(149, 67);
            comboBox2Pokoj.Name = "comboBox2Pokoj";
            comboBox2Pokoj.Size = new Size(300, 28);
            comboBox2Pokoj.TabIndex = 6;
            // 
            // dateTimePickerOd
            // 
            dateTimePickerOd.Format = DateTimePickerFormat.Short;
            dateTimePickerOd.Location = new Point(149, 106);
            dateTimePickerOd.Name = "dateTimePickerOd";
            dateTimePickerOd.Size = new Size(150, 27);
            dateTimePickerOd.TabIndex = 7;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(149, 145);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(151, 27);
            dateTimePicker2.TabIndex = 8;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Items.AddRange(new object[] { "Potwierdzona", "Oczekująca", "Anulowana" });
            comboBoxStatus.Location = new Point(148, 190);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(151, 28);
            comboBoxStatus.TabIndex = 9;
            // 
            // buttonZapiszRez
            // 
            buttonZapiszRez.Location = new Point(130, 240);
            buttonZapiszRez.Name = "buttonZapiszRez";
            buttonZapiszRez.Size = new Size(94, 35);
            buttonZapiszRez.TabIndex = 10;
            buttonZapiszRez.Text = "Zapisz";
            buttonZapiszRez.UseVisualStyleBackColor = true;
            buttonZapiszRez.Click += buttonZapiszRez_Click;
            // 
            // buttonAnulujRez
            // 
            buttonAnulujRez.Location = new Point(240, 240);
            buttonAnulujRez.Name = "buttonAnulujRez";
            buttonAnulujRez.Size = new Size(90, 35);
            buttonAnulujRez.TabIndex = 11;
            buttonAnulujRez.Text = "Anuluj";
            buttonAnulujRez.UseVisualStyleBackColor = true;
            buttonAnulujRez.Click += buttonAnulujRez_Click;
            // 
            // AddReservationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonAnulujRez);
            Controls.Add(buttonZapiszRez);
            Controls.Add(comboBoxStatus);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePickerOd);
            Controls.Add(comboBox2Pokoj);
            Controls.Add(comboBoxGosc);
            Controls.Add(labelStatus);
            Controls.Add(labelData_Do);
            Controls.Add(label3DataOd);
            Controls.Add(label2R_Pokoj);
            Controls.Add(label1R_Gosc);
            Name = "AddReservationForm";
            Text = "AddReservationForm";
            Load += AddReservationForm_Load_1;
            ResumeLayout(false);
        }

        #endregion

        private Label label1R_Gosc;
        private Label label2R_Pokoj;
        private Label label3DataOd;
        private Label labelData_Do;
        private Label labelStatus;
        private Button buttonZapiszRez;
        private Button buttonAnulujRez;
        public ComboBox comboBoxGosc;
        public ComboBox comboBox2Pokoj;
        public DateTimePicker dateTimePickerOd;
        public DateTimePicker dateTimePicker2;
        public ComboBox comboBoxStatus;
    }
}