namespace HotelReservation
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
            tabControlMain = new TabControl();
            tabPageGoście = new TabPage();
            panelButtons = new Panel();
            Odswiez = new Button();
            Dodaj_goscia = new Button();
            Usun_goscia = new Button();
            Edytuj_goscia = new Button();
            dataGridView1 = new DataGridView();
            tabPageHotele = new TabPage();
            panel1 = new Panel();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            DodajHotel = new Button();
            dataGridView2 = new DataGridView();
            tabPagePokoje = new TabPage();
            panel4 = new Panel();
            button11Odswiez_Pokoj = new Button();
            button10Usun_Pokoj = new Button();
            button9Edytuj_Pokoj = new Button();
            button5Dodaj_Pokoj = new Button();
            dataGridView3 = new DataGridView();
            tabPageRezerwacje = new TabPage();
            panel3 = new Panel();
            button4Odswiez_Rezerwacje = new Button();
            button3Usun_Rezerwacje = new Button();
            button2Edytuj_Rezerwacje = new Button();
            button1Dodaj_Rezerwacje = new Button();
            dataGridView4 = new DataGridView();
            tabPagePłatności = new TabPage();
            panel2 = new Panel();
            button15Odswiez_Platnosc = new Button();
            button14Usun_Platnosc = new Button();
            button13Edytuj_Platnosc = new Button();
            button12Dodaj_Platnosc = new Button();
            dataGridView5 = new DataGridView();
            tabControlMain.SuspendLayout();
            tabPageGoście.SuspendLayout();
            panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPageHotele.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tabPagePokoje.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            tabPageRezerwacje.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            tabPagePłatności.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).BeginInit();
            SuspendLayout();
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tabPageGoście);
            tabControlMain.Controls.Add(tabPageHotele);
            tabControlMain.Controls.Add(tabPagePokoje);
            tabControlMain.Controls.Add(tabPageRezerwacje);
            tabControlMain.Controls.Add(tabPagePłatności);
            tabControlMain.Dock = DockStyle.Fill;
            tabControlMain.Location = new Point(0, 0);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(800, 450);
            tabControlMain.TabIndex = 0;
            // 
            // tabPageGoście
            // 
            tabPageGoście.Controls.Add(panelButtons);
            tabPageGoście.Controls.Add(dataGridView1);
            tabPageGoście.Location = new Point(4, 29);
            tabPageGoście.Name = "tabPageGoście";
            tabPageGoście.Padding = new Padding(3);
            tabPageGoście.Size = new Size(792, 417);
            tabPageGoście.TabIndex = 0;
            tabPageGoście.Text = "Goście";
            tabPageGoście.UseVisualStyleBackColor = true;
            tabPageGoście.Click += tabPageGoście_Click;
            // 
            // panelButtons
            // 
            panelButtons.BackColor = Color.LightGray;
            panelButtons.Controls.Add(Odswiez);
            panelButtons.Controls.Add(Dodaj_goscia);
            panelButtons.Controls.Add(Usun_goscia);
            panelButtons.Controls.Add(Edytuj_goscia);
            panelButtons.Dock = DockStyle.Top;
            panelButtons.Location = new Point(3, 3);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(786, 50);
            panelButtons.TabIndex = 1;
            // 
            // Odswiez
            // 
            Odswiez.Location = new Point(626, 18);
            Odswiez.Name = "Odswiez";
            Odswiez.Size = new Size(94, 29);
            Odswiez.TabIndex = 5;
            Odswiez.Text = "Odśwież";
            Odswiez.UseVisualStyleBackColor = true;
            Odswiez.Click += Odswiez_Click;
            // 
            // Dodaj_goscia
            // 
            Dodaj_goscia.Location = new Point(55, 18);
            Dodaj_goscia.Name = "Dodaj_goscia";
            Dodaj_goscia.Size = new Size(111, 29);
            Dodaj_goscia.TabIndex = 2;
            Dodaj_goscia.Text = "Dodaj gościa";
            Dodaj_goscia.UseVisualStyleBackColor = true;
            Dodaj_goscia.Click += Dodaj_goscia_Click;
            // 
            // Usun_goscia
            // 
            Usun_goscia.Location = new Point(440, 18);
            Usun_goscia.Name = "Usun_goscia";
            Usun_goscia.Size = new Size(94, 29);
            Usun_goscia.TabIndex = 4;
            Usun_goscia.Text = "Usuń";
            Usun_goscia.UseVisualStyleBackColor = true;
            Usun_goscia.Click += Usun_goscia_Click;
            // 
            // Edytuj_goscia
            // 
            Edytuj_goscia.Location = new Point(252, 18);
            Edytuj_goscia.Name = "Edytuj_goscia";
            Edytuj_goscia.Size = new Size(94, 29);
            Edytuj_goscia.TabIndex = 3;
            Edytuj_goscia.Text = "Edytuj";
            Edytuj_goscia.UseVisualStyleBackColor = true;
            Edytuj_goscia.Click += Edytuj_goscia_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.DataMember = "(none)";
            dataGridView1.Location = new Point(6, 60);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(778, 357);
            dataGridView1.TabIndex = 0;
            // 
            // tabPageHotele
            // 
            tabPageHotele.Controls.Add(panel1);
            tabPageHotele.Controls.Add(dataGridView2);
            tabPageHotele.Location = new Point(4, 29);
            tabPageHotele.Name = "tabPageHotele";
            tabPageHotele.Padding = new Padding(3);
            tabPageHotele.Size = new Size(792, 417);
            tabPageHotele.TabIndex = 1;
            tabPageHotele.Text = "Hotele";
            tabPageHotele.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(button8);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(DodajHotel);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(786, 50);
            panel1.TabIndex = 1;
            // 
            // button8
            // 
            button8.Location = new Point(626, 18);
            button8.Name = "button8";
            button8.Size = new Size(94, 29);
            button8.TabIndex = 3;
            button8.Text = "Odśwież";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.Location = new Point(440, 18);
            button7.Name = "button7";
            button7.Size = new Size(94, 29);
            button7.TabIndex = 2;
            button7.Text = "Usuń";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.Location = new Point(248, 18);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 1;
            button6.Text = "Edytuj";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // DodajHotel
            // 
            DodajHotel.Location = new Point(55, 18);
            DodajHotel.Name = "DodajHotel";
            DodajHotel.Size = new Size(99, 29);
            DodajHotel.TabIndex = 0;
            DodajHotel.Text = "Dodaj hotel";
            DodajHotel.UseVisualStyleBackColor = true;
            DodajHotel.Click += DodajGoscia_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(6, 59);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(778, 355);
            dataGridView2.TabIndex = 0;
            // 
            // tabPagePokoje
            // 
            tabPagePokoje.Controls.Add(panel4);
            tabPagePokoje.Controls.Add(dataGridView3);
            tabPagePokoje.Location = new Point(4, 29);
            tabPagePokoje.Name = "tabPagePokoje";
            tabPagePokoje.Padding = new Padding(3);
            tabPagePokoje.Size = new Size(792, 417);
            tabPagePokoje.TabIndex = 2;
            tabPagePokoje.Text = "Pokoje";
            tabPagePokoje.UseVisualStyleBackColor = true;
            tabPagePokoje.Click += tabPagePokoje_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.LightGray;
            panel4.Controls.Add(button11Odswiez_Pokoj);
            panel4.Controls.Add(button10Usun_Pokoj);
            panel4.Controls.Add(button9Edytuj_Pokoj);
            panel4.Controls.Add(button5Dodaj_Pokoj);
            panel4.Location = new Point(8, 8);
            panel4.Name = "panel4";
            panel4.Size = new Size(776, 53);
            panel4.TabIndex = 1;
            // 
            // button11Odswiez_Pokoj
            // 
            button11Odswiez_Pokoj.Location = new Point(647, 21);
            button11Odswiez_Pokoj.Name = "button11Odswiez_Pokoj";
            button11Odswiez_Pokoj.Size = new Size(94, 29);
            button11Odswiez_Pokoj.TabIndex = 3;
            button11Odswiez_Pokoj.Text = "Odśwież";
            button11Odswiez_Pokoj.UseVisualStyleBackColor = true;
            button11Odswiez_Pokoj.Click += button11Odswiez_Pokoj_Click;
            // 
            // button10Usun_Pokoj
            // 
            button10Usun_Pokoj.Location = new Point(443, 21);
            button10Usun_Pokoj.Name = "button10Usun_Pokoj";
            button10Usun_Pokoj.Size = new Size(94, 29);
            button10Usun_Pokoj.TabIndex = 2;
            button10Usun_Pokoj.Text = "Usuń";
            button10Usun_Pokoj.UseVisualStyleBackColor = true;
            button10Usun_Pokoj.Click += button10Usun_Pokoj_Click;
            // 
            // button9Edytuj_Pokoj
            // 
            button9Edytuj_Pokoj.Location = new Point(255, 21);
            button9Edytuj_Pokoj.Name = "button9Edytuj_Pokoj";
            button9Edytuj_Pokoj.Size = new Size(94, 29);
            button9Edytuj_Pokoj.TabIndex = 1;
            button9Edytuj_Pokoj.Text = "Edytuj";
            button9Edytuj_Pokoj.UseVisualStyleBackColor = true;
            button9Edytuj_Pokoj.Click += button9Edytuj_Pokoj_Click;
            // 
            // button5Dodaj_Pokoj
            // 
            button5Dodaj_Pokoj.Location = new Point(56, 21);
            button5Dodaj_Pokoj.Name = "button5Dodaj_Pokoj";
            button5Dodaj_Pokoj.Size = new Size(113, 29);
            button5Dodaj_Pokoj.TabIndex = 0;
            button5Dodaj_Pokoj.Text = "Dodaj pokój";
            button5Dodaj_Pokoj.UseVisualStyleBackColor = true;
            button5Dodaj_Pokoj.Click += button5Dodaj_Pokoj_Click;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(8, 67);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.Size = new Size(776, 342);
            dataGridView3.TabIndex = 0;
            dataGridView3.CellContentClick += dataGridView3_CellContentClick;
            // 
            // tabPageRezerwacje
            // 
            tabPageRezerwacje.Controls.Add(panel3);
            tabPageRezerwacje.Controls.Add(dataGridView4);
            tabPageRezerwacje.Location = new Point(4, 29);
            tabPageRezerwacje.Name = "tabPageRezerwacje";
            tabPageRezerwacje.Padding = new Padding(3);
            tabPageRezerwacje.Size = new Size(792, 417);
            tabPageRezerwacje.TabIndex = 3;
            tabPageRezerwacje.Text = "Rezerwacje";
            tabPageRezerwacje.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightGray;
            panel3.Controls.Add(button4Odswiez_Rezerwacje);
            panel3.Controls.Add(button3Usun_Rezerwacje);
            panel3.Controls.Add(button2Edytuj_Rezerwacje);
            panel3.Controls.Add(button1Dodaj_Rezerwacje);
            panel3.Location = new Point(8, 6);
            panel3.Name = "panel3";
            panel3.Size = new Size(776, 55);
            panel3.TabIndex = 1;
            // 
            // button4Odswiez_Rezerwacje
            // 
            button4Odswiez_Rezerwacje.Location = new Point(627, 24);
            button4Odswiez_Rezerwacje.Name = "button4Odswiez_Rezerwacje";
            button4Odswiez_Rezerwacje.Size = new Size(94, 29);
            button4Odswiez_Rezerwacje.TabIndex = 3;
            button4Odswiez_Rezerwacje.Text = "Odśwież";
            button4Odswiez_Rezerwacje.UseVisualStyleBackColor = true;
            button4Odswiez_Rezerwacje.Click += button4Odswiez_Rezerwacje_Click;
            // 
            // button3Usun_Rezerwacje
            // 
            button3Usun_Rezerwacje.Location = new Point(438, 23);
            button3Usun_Rezerwacje.Name = "button3Usun_Rezerwacje";
            button3Usun_Rezerwacje.Size = new Size(94, 29);
            button3Usun_Rezerwacje.TabIndex = 2;
            button3Usun_Rezerwacje.Text = "Usuń";
            button3Usun_Rezerwacje.UseVisualStyleBackColor = true;
            button3Usun_Rezerwacje.Click += button3Usun_Rezerwacje_Click;
            // 
            // button2Edytuj_Rezerwacje
            // 
            button2Edytuj_Rezerwacje.Location = new Point(242, 23);
            button2Edytuj_Rezerwacje.Name = "button2Edytuj_Rezerwacje";
            button2Edytuj_Rezerwacje.Size = new Size(94, 29);
            button2Edytuj_Rezerwacje.TabIndex = 1;
            button2Edytuj_Rezerwacje.Text = "Edytuj";
            button2Edytuj_Rezerwacje.UseVisualStyleBackColor = true;
            button2Edytuj_Rezerwacje.Click += button2Edytuj_Rezerwacje_Click;
            // 
            // button1Dodaj_Rezerwacje
            // 
            button1Dodaj_Rezerwacje.Location = new Point(43, 23);
            button1Dodaj_Rezerwacje.Name = "button1Dodaj_Rezerwacje";
            button1Dodaj_Rezerwacje.Size = new Size(136, 29);
            button1Dodaj_Rezerwacje.TabIndex = 0;
            button1Dodaj_Rezerwacje.Text = "Dodaj rezerwacje";
            button1Dodaj_Rezerwacje.UseVisualStyleBackColor = true;
            button1Dodaj_Rezerwacje.Click += button1Dodaj_Rezerwacje_Click;
            // 
            // dataGridView4
            // 
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Location = new Point(8, 67);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.RowHeadersWidth = 51;
            dataGridView4.Size = new Size(778, 344);
            dataGridView4.TabIndex = 0;
            // 
            // tabPagePłatności
            // 
            tabPagePłatności.Controls.Add(panel2);
            tabPagePłatności.Controls.Add(dataGridView5);
            tabPagePłatności.Location = new Point(4, 29);
            tabPagePłatności.Name = "tabPagePłatności";
            tabPagePłatności.Padding = new Padding(3);
            tabPagePłatności.Size = new Size(792, 417);
            tabPagePłatności.TabIndex = 4;
            tabPagePłatności.Text = "Płatności";
            tabPagePłatności.UseVisualStyleBackColor = true;
            tabPagePłatności.Click += tabPagePłatności_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGray;
            panel2.Controls.Add(button15Odswiez_Platnosc);
            panel2.Controls.Add(button14Usun_Platnosc);
            panel2.Controls.Add(button13Edytuj_Platnosc);
            panel2.Controls.Add(button12Dodaj_Platnosc);
            panel2.Location = new Point(8, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(776, 51);
            panel2.TabIndex = 1;
            // 
            // button15Odswiez_Platnosc
            // 
            button15Odswiez_Platnosc.Location = new Point(636, 19);
            button15Odswiez_Platnosc.Name = "button15Odswiez_Platnosc";
            button15Odswiez_Platnosc.Size = new Size(94, 29);
            button15Odswiez_Platnosc.TabIndex = 3;
            button15Odswiez_Platnosc.Text = "Odśwież";
            button15Odswiez_Platnosc.UseVisualStyleBackColor = true;
            button15Odswiez_Platnosc.Click += button15Odswiez_Platnosc_Click;
            // 
            // button14Usun_Platnosc
            // 
            button14Usun_Platnosc.Location = new Point(447, 19);
            button14Usun_Platnosc.Name = "button14Usun_Platnosc";
            button14Usun_Platnosc.Size = new Size(94, 29);
            button14Usun_Platnosc.TabIndex = 2;
            button14Usun_Platnosc.Text = "Usuń";
            button14Usun_Platnosc.UseVisualStyleBackColor = true;
            button14Usun_Platnosc.Click += button14Usun_Platnosc_Click;
            // 
            // button13Edytuj_Platnosc
            // 
            button13Edytuj_Platnosc.Location = new Point(247, 19);
            button13Edytuj_Platnosc.Name = "button13Edytuj_Platnosc";
            button13Edytuj_Platnosc.Size = new Size(94, 29);
            button13Edytuj_Platnosc.TabIndex = 1;
            button13Edytuj_Platnosc.Text = "Edytuj";
            button13Edytuj_Platnosc.UseVisualStyleBackColor = true;
            button13Edytuj_Platnosc.Click += button13Edytuj_Platnosc_Click;
            // 
            // button12Dodaj_Platnosc
            // 
            button12Dodaj_Platnosc.Location = new Point(60, 19);
            button12Dodaj_Platnosc.Name = "button12Dodaj_Platnosc";
            button12Dodaj_Platnosc.Size = new Size(118, 29);
            button12Dodaj_Platnosc.TabIndex = 0;
            button12Dodaj_Platnosc.Text = "Dodaj płatność";
            button12Dodaj_Platnosc.UseVisualStyleBackColor = true;
            button12Dodaj_Platnosc.Click += button12Dodaj_Platnosc_Click;
            // 
            // dataGridView5
            // 
            dataGridView5.ColumnHeadersHeight = 29;
            dataGridView5.Location = new Point(8, 63);
            dataGridView5.Name = "dataGridView5";
            dataGridView5.RowHeadersWidth = 51;
            dataGridView5.Size = new Size(778, 346);
            dataGridView5.TabIndex = 0;
            dataGridView5.CellContentClick += dataGridView5_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControlMain);
            Name = "Form1";
            Text = "System Zarządzania Hotelem";
            Load += Form1_Load;
            tabControlMain.ResumeLayout(false);
            tabPageGoście.ResumeLayout(false);
            panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPageHotele.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tabPagePokoje.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            tabPageRezerwacje.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            tabPagePłatności.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlMain;
        private TabPage tabPageGoście;
        private TabPage tabPageHotele;
        private TabPage tabPagePokoje;
        private TabPage tabPageRezerwacje;
        private TabPage tabPagePłatności;
        private Panel panelButtons;
        private DataGridView dataGridView1;
        private Button Odswiez;
        private Button Dodaj_goscia;
        private Button Usun_goscia;
        private Button Edytuj_goscia;
        private Panel panel1;
        private Button button7;
        private Button button6;
        private Button DodajHotel;
        private DataGridView dataGridView2;
        private DataGridView dataGridView3;
        private DataGridView dataGridView4;
        private DataGridView dataGridView5;
        private Panel panel3;
        private Panel panel2;
        private Panel panel4;
        private Button button11Odswiez_Pokoj;
        private Button button10Usun_Pokoj;
        private Button button9Edytuj_Pokoj;
        private Button button5Dodaj_Pokoj;
        private Button button4Odswiez_Rezerwacje;
        private Button button3Usun_Rezerwacje;
        private Button button2Edytuj_Rezerwacje;
        private Button button1Dodaj_Rezerwacje;
        private Button button15Odswiez_Platnosc;
        private Button button14Usun_Platnosc;
        private Button button13Edytuj_Platnosc;
        private Button button12Dodaj_Platnosc;
        public Button button8;
    }
}