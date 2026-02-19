namespace HotelReservation
{
    partial class AddGuestForm
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
            textBoxImie = new TextBox();
            label2 = new Label();
            textBoxNazwisko = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBoxEmail = new TextBox();
            textBoxPhone = new TextBox();
            buttonZapisz = new Button();
            buttonAnuluj = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(20, 30);
            label1.Name = "label1";
            label1.Size = new Size(80, 23);
            label1.TabIndex = 0;
            label1.Text = "Imię\r\n\r\n";
            label1.Click += label1_Click;
            // 
            // textBoxImie
            // 
            textBoxImie.Font = new Font("Segoe UI", 12F);
            textBoxImie.Location = new Point(110, 30);
            textBoxImie.Name = "textBoxImie";
            textBoxImie.Size = new Size(200, 34);
            textBoxImie.TabIndex = 1;
            textBoxImie.TextChanged += textBoxImie_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(20, 80);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 2;
            label2.Text = "Nazwisko";
            label2.Click += label2_Click;
            // 
            // textBoxNazwisko
            // 
            textBoxNazwisko.Font = new Font("Segoe UI", 12F);
            textBoxNazwisko.Location = new Point(110, 80);
            textBoxNazwisko.Name = "textBoxNazwisko";
            textBoxNazwisko.Size = new Size(200, 34);
            textBoxNazwisko.TabIndex = 3;
            textBoxNazwisko.TextChanged += textBoxNazwisko_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.Location = new Point(20, 131);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 4;
            label3.Text = "Email";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F);
            label4.Location = new Point(20, 175);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 5;
            label4.Text = "Telefon";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(110, 131);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(200, 27);
            textBoxEmail.TabIndex = 6;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(110, 179);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(200, 27);
            textBoxPhone.TabIndex = 7;
            // 
            // buttonZapisz
            // 
            buttonZapisz.Location = new Point(50, 250);
            buttonZapisz.Name = "buttonZapisz";
            buttonZapisz.Size = new Size(94, 29);
            buttonZapisz.TabIndex = 8;
            buttonZapisz.Text = "Zapisz";
            buttonZapisz.UseVisualStyleBackColor = true;
            buttonZapisz.Click += buttonZapisz_Click;
            // 
            // buttonAnuluj
            // 
            buttonAnuluj.Location = new Point(150, 250);
            buttonAnuluj.Name = "buttonAnuluj";
            buttonAnuluj.Size = new Size(94, 29);
            buttonAnuluj.TabIndex = 9;
            buttonAnuluj.Text = "Anuluj";
            buttonAnuluj.UseVisualStyleBackColor = true;
            buttonAnuluj.Click += buttonAnuluj_Click;
            // 
            // AddGuestForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonAnuluj);
            Controls.Add(buttonZapisz);
            Controls.Add(textBoxPhone);
            Controls.Add(textBoxEmail);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBoxNazwisko);
            Controls.Add(label2);
            Controls.Add(textBoxImie);
            Controls.Add(label1);
            Name = "AddGuestForm";
            Text = "AddGuestForm";
            Load += AddGuestForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button buttonZapisz;
        private Button buttonAnuluj;
        public TextBox textBoxImie;
        public TextBox textBoxNazwisko;
        public TextBox textBoxEmail;
        public TextBox textBoxPhone;
    }
}