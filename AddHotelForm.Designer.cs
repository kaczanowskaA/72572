namespace HotelReservation
{
    partial class AddHotelForm
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
            textBoxMiasto = new TextBox();
            textBoxAdres = new TextBox();
            textBoxNazwaHotel = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            buttonZapiszHotel = new Button();
            buttonAnulujHotel = new Button();
            numericGwiazdki = new NumericUpDown();
            colorDialog1 = new ColorDialog();
            ((System.ComponentModel.ISupportInitialize)numericGwiazdki).BeginInit();
            SuspendLayout();
            // 
            // textBoxMiasto
            // 
            textBoxMiasto.Location = new Point(120, 70);
            textBoxMiasto.Name = "textBoxMiasto";
            textBoxMiasto.Size = new Size(125, 27);
            textBoxMiasto.TabIndex = 0;
            // 
            // textBoxAdres
            // 
            textBoxAdres.Location = new Point(120, 110);
            textBoxAdres.Multiline = true;
            textBoxAdres.Name = "textBoxAdres";
            textBoxAdres.Size = new Size(200, 70);
            textBoxAdres.TabIndex = 1;
            // 
            // textBoxNazwaHotel
            // 
            textBoxNazwaHotel.Location = new Point(120, 30);
            textBoxNazwaHotel.Name = "textBoxNazwaHotel";
            textBoxNazwaHotel.Size = new Size(125, 27);
            textBoxNazwaHotel.TabIndex = 3;
            textBoxNazwaHotel.TextChanged += textBoxNazwaHotel_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 30);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 4;
            label1.Text = "Nazwa hotelu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 70);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 5;
            label2.Text = "Miasto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 110);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 6;
            label3.Text = "Adres";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 195);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 7;
            label4.Text = "Gwiazdki";
            label4.Click += label4_Click;
            // 
            // buttonZapiszHotel
            // 
            buttonZapiszHotel.Location = new Point(43, 264);
            buttonZapiszHotel.Name = "buttonZapiszHotel";
            buttonZapiszHotel.Size = new Size(94, 29);
            buttonZapiszHotel.TabIndex = 8;
            buttonZapiszHotel.Text = "Zapisz";
            buttonZapiszHotel.UseVisualStyleBackColor = true;
            buttonZapiszHotel.Click += buttonZapiszHotel_Click;
            // 
            // buttonAnulujHotel
            // 
            buttonAnulujHotel.Location = new Point(167, 264);
            buttonAnulujHotel.Name = "buttonAnulujHotel";
            buttonAnulujHotel.Size = new Size(94, 29);
            buttonAnulujHotel.TabIndex = 9;
            buttonAnulujHotel.Text = "Anuluj";
            buttonAnulujHotel.UseVisualStyleBackColor = true;
            buttonAnulujHotel.Click += buttonAnulujHotel_Click;
            // 
            // numericGwiazdki
            // 
            numericGwiazdki.Location = new Point(120, 195);
            numericGwiazdki.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numericGwiazdki.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericGwiazdki.Name = "numericGwiazdki";
            numericGwiazdki.Size = new Size(150, 27);
            numericGwiazdki.TabIndex = 10;
            numericGwiazdki.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // AddHotelForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(numericGwiazdki);
            Controls.Add(buttonAnulujHotel);
            Controls.Add(buttonZapiszHotel);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxNazwaHotel);
            Controls.Add(textBoxAdres);
            Controls.Add(textBoxMiasto);
            Name = "AddHotelForm";
            Text = "AddHotelForm";
            Load += AddHotelForm_Load;
            ((System.ComponentModel.ISupportInitialize)numericGwiazdki).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button buttonZapiszHotel;
        private Button buttonAnulujHotel;
        public TextBox textBoxMiasto;
        public TextBox textBoxAdres;
        public TextBox textBoxNazwaHotel;
        public NumericUpDown numericGwiazdki;
        private ColorDialog colorDialog1;
    }
}