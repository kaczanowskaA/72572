namespace HotelReservation
{
    partial class AddRoomForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            labelCena = new Label();
            comboBoxHotel = new ComboBox();
            textBoxNumer = new TextBox();
            textBoxTyp = new TextBox();
            numericUpDown1 = new NumericUpDown();
            buttonZapisz_Pokoj = new Button();
            button2Anuluj_Pokoj = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(20, 30);
            label1.Name = "label1";
            label1.Size = new Size(80, 23);
            label1.TabIndex = 0;
            label1.Text = "Hotel";
            // 
            // label2
            // 
            label2.Location = new Point(20, 70);
            label2.Name = "label2";
            label2.Size = new Size(80, 23);
            label2.TabIndex = 1;
            label2.Text = "Numer pokoju";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 110);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 2;
            label3.Text = "Typ pokoju";
            // 
            // labelCena
            // 
            labelCena.Location = new Point(20, 153);
            labelCena.Name = "labelCena";
            labelCena.Size = new Size(111, 23);
            labelCena.TabIndex = 3;
            labelCena.Text = "Cena za dzień";
            // 
            // comboBoxHotel
            // 
            comboBoxHotel.FormattingEnabled = true;
            comboBoxHotel.Location = new Point(120, 30);
            comboBoxHotel.Name = "comboBoxHotel";
            comboBoxHotel.Size = new Size(250, 28);
            comboBoxHotel.TabIndex = 4;
            // 
            // textBoxNumer
            // 
            textBoxNumer.Location = new Point(120, 67);
            textBoxNumer.Name = "textBoxNumer";
            textBoxNumer.Size = new Size(100, 27);
            textBoxNumer.TabIndex = 5;
            // 
            // textBoxTyp
            // 
            textBoxTyp.Location = new Point(120, 107);
            textBoxTyp.Name = "textBoxTyp";
            textBoxTyp.Size = new Size(150, 27);
            textBoxTyp.TabIndex = 6;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(120, 149);
            numericUpDown1.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 7;
            // 
            // buttonZapisz_Pokoj
            // 
            buttonZapisz_Pokoj.Location = new Point(120, 200);
            buttonZapisz_Pokoj.Name = "buttonZapisz_Pokoj";
            buttonZapisz_Pokoj.Size = new Size(90, 35);
            buttonZapisz_Pokoj.TabIndex = 8;
            buttonZapisz_Pokoj.Text = "Zapisz";
            buttonZapisz_Pokoj.UseVisualStyleBackColor = true;
            buttonZapisz_Pokoj.Click += buttonZapisz_Pokoj_Click;
            // 
            // button2Anuluj_Pokoj
            // 
            button2Anuluj_Pokoj.Location = new Point(230, 200);
            button2Anuluj_Pokoj.Name = "button2Anuluj_Pokoj";
            button2Anuluj_Pokoj.Size = new Size(90, 35);
            button2Anuluj_Pokoj.TabIndex = 9;
            button2Anuluj_Pokoj.Text = "Anuluj";
            button2Anuluj_Pokoj.UseVisualStyleBackColor = true;
            button2Anuluj_Pokoj.Click += button2Anuluj_Pokoj_Click;
            // 
            // AddRoomForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2Anuluj_Pokoj);
            Controls.Add(buttonZapisz_Pokoj);
            Controls.Add(numericUpDown1);
            Controls.Add(textBoxTyp);
            Controls.Add(textBoxNumer);
            Controls.Add(comboBoxHotel);
            Controls.Add(labelCena);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddRoomForm";
            Text = "AddRoomForm";
            Load += AddRoomForm_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label labelCena;
        private Button buttonZapisz_Pokoj;
        private Button button2Anuluj_Pokoj;
        public ComboBox comboBoxHotel;
        public TextBox textBoxNumer;
        public TextBox textBoxTyp;
        public NumericUpDown numericUpDown1;
    }
}