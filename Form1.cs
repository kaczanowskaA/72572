using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
namespace HotelReservation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void Edytuj_goscia_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                AddGuestForm okno = new AddGuestForm();

                // wyci¹gamy dane z zaznaczonego wiersza i wrzucamy do okienka
                okno.ID_Guest = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID_Guest"].Value);
                okno.textBoxImie.Text = dataGridView1.CurrentRow.Cells["Name"].Value.ToString();
                okno.textBoxNazwisko.Text = dataGridView1.CurrentRow.Cells["Surname"].Value.ToString();
                okno.textBoxEmail.Text = dataGridView1.CurrentRow.Cells["Email"].Value.ToString();
                okno.textBoxPhone.Text = dataGridView1.CurrentRow.Cells["Phone_Number"].Value.ToString();

                // pokazujemy okno i odœwie¿amy tabelê po zamkniêciu
                okno.ShowDialog();
                Odswiez_Click(null, null);
            }
            else
            {
                MessageBox.Show("Zaznacz goœcia do edycji!");
            }
        }


        private void Usun_goscia_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                DialogResult wynik = MessageBox.Show("Czy na pewno chcesz usun¹æ tego goœcia?", "Potwierdzenie", MessageBoxButtons.YesNo);

                if (wynik == DialogResult.Yes)
                {
                    // pobieramy ID z zaznaczonego wiersza
                    int idDoUsuniecia = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID_Guest"].Value);

                    string connectionString = "Server=(local)\\SQLEXPRESS;Database=SiecHoteli;Trusted_Connection=true;TrustServerCertificate=true;";
                    string query = "DELETE FROM Guests WHERE ID_Guest = @id";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@id", idDoUsuniecia);

                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                    Odswiez_Click(null, null);

                    MessageBox.Show("Goœæ usuniêty!");
                }
            }
        }
        // ³adowanie danych z bazy, pobranie danych z tabeli guests, wype³nienie datagridview danymi z bazy
        private void Odswiez_Click(object sender, EventArgs e)
        {


            
            string connectionString = "Server=(local)\\SQLEXPRESS;Database=SiecHoteli;Trusted_Connection=true;TrustServerCertificate=true;";

            
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT ID_Guest, Name, Surname, Email, Phone_Number FROM Guests", connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            
            dataGridView1.DataSource = dataTable;

            connection.Close();
        }

       
        public void LoadRoomsData()
        {
            string connectionString = "Server=(local)\\SQLEXPRESS;Database=SiecHoteli;Trusted_Connection=true;Encrypt=false;";

            string query = @"SELECT 
                            r.ID_Room,
                            r.ID_Hotel,
                            h.Name as Hotel_Name,
                            r.Room_Number,
                            r.Type,
                            r.Price_Per_Day
                     FROM Rooms r
                     INNER JOIN Hotels h ON r.ID_Hotel = h.ID_Hotel
                     ORDER BY h.Name, r.Room_Number";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView3.DataSource = dataTable; 
            }
        }


        
        private void LoadHotelsData()
        {
            string connectionString = "Server=(local)\\SQLEXPRESS;Database=SiecHoteli;Trusted_Connection=true;Encrypt=false;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT ID_Hotel, Name, City, Address, Stars FROM Hotels ORDER BY Name";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView2.DataSource = dataTable;
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            LoadHotelsData();
        }




        private void Dodaj_goscia_Click(object sender, EventArgs e)
        {
            AddGuestForm oknoDodawania = new AddGuestForm();


            oknoDodawania.ShowDialog();
        }



        private void button6_Click(object sender, EventArgs e)
        {


            if (dataGridView2.CurrentRow != null)
            {
                AddHotelForm okno = new AddHotelForm();

                // wyci¹gamy dane z zaznaczonego wiersza
                okno.ID_Hotel = Convert.ToInt32(dataGridView2.CurrentRow.Cells["ID_Hotel"].Value);
                okno.textBoxNazwaHotel.Text = dataGridView2.CurrentRow.Cells["Name"].Value.ToString();
                okno.textBoxMiasto.Text = dataGridView2.CurrentRow.Cells["City"].Value.ToString();
                okno.textBoxAdres.Text = dataGridView2.CurrentRow.Cells["Address"].Value.ToString();
                okno.numericGwiazdki.Value = Convert.ToInt32(dataGridView2.CurrentRow.Cells["Stars"].Value);

                
                okno.ShowDialog();
                LoadHotelsData(); // metoda odœwie¿ania hoteli
            }
            else
            {
                MessageBox.Show("Zaznacz hotel do edycji!");
            }
        }




        private void button7_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Czy na pewno usun¹æ ten hotel?", "Potwierdzenie", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int hotelId = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[0].Value);

                    string connectionString = "Server=(local)\\SQLEXPRESS;Database=SiecHoteli;Trusted_Connection=true;Encrypt=false;";
                    string query = "DELETE FROM Hotels WHERE ID_Hotel = @ID";

                    try
                    {
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            SqlCommand command = new SqlCommand(query, connection);
                            command.Parameters.AddWithValue("@ID", hotelId);
                            connection.Open();
                            command.ExecuteNonQuery();
                            connection.Close();
                        }

                        MessageBox.Show("Hotel usuniêty!");
                        LoadHotelsData();
                    }
                    catch (SqlException ex)
                    {
                        if (ex.Message.Contains("REFERENCE constraint"))
                        {
                            MessageBox.Show("Nie mo¿na usun¹æ hotelu - ma przypisane pokoje!");
                        }
                        else
                        {
                            MessageBox.Show("B³¹d usuwania: " + ex.Message);
                        }
                    }
                }
            }
            else
                MessageBox.Show("Wybierz hotel do usuniêcia.");
        }







        private void DodajGoscia_Click(object sender, EventArgs e) // dodawanie hotelu, nie goœcia
        {
            AddHotelForm oknoDodawaniaHotelu = new AddHotelForm();
            oknoDodawaniaHotelu.ShowDialog();

            LoadHotelsData();
        }

       

        private void button9Edytuj_Pokoj_Click(object sender, EventArgs e)
        {
            if (dataGridView3.CurrentRow != null)
            {
                AddRoomForm okno = new AddRoomForm();

                 
                okno.ID_Room = Convert.ToInt32(dataGridView3.CurrentRow.Cells[0].Value);

                
                okno.comboBoxHotel.SelectedValue = dataGridView3.CurrentRow.Cells["ID_Hotel"].Value;
                okno.textBoxNumer.Text = dataGridView3.CurrentRow.Cells["Room_Number"].Value.ToString();
                okno.textBoxTyp.Text = dataGridView3.CurrentRow.Cells["Type"].Value.ToString();
                okno.numericUpDown1.Value = Convert.ToDecimal(dataGridView3.CurrentRow.Cells["Price_Per_Day"].Value);

                okno.ShowDialog();
                LoadRoomsData();
            }
            else
                MessageBox.Show("Wybierz pokój do edycji!");
        }

       

        private void button13Edytuj_Platnosc_Click(object sender, EventArgs e)
        {
            if (dataGridView5.CurrentRow != null)
            {
                AddAmountFormcs okno = new AddAmountFormcs();

                // wyci¹ganie danych
                okno.ID_Payment = Convert.ToInt32(dataGridView5.CurrentRow.Cells[0].Value);
                okno.comboBoxRezerwacja.SelectedValue = dataGridView5.CurrentRow.Cells["ID_Reservation"].Value;
                okno.numericKwota.Value = Convert.ToDecimal(dataGridView5.CurrentRow.Cells["Amount"].Value);
                okno.dateTimePickerPlatnosc.Value = Convert.ToDateTime(dataGridView5.CurrentRow.Cells["Payment_Date"].Value);
                okno.comboBoxMetoda.Text = dataGridView5.CurrentRow.Cells["Payment_Method"].Value.ToString();

                okno.ShowDialog();
                LoadPaymentsData(); // odœwie¿anie
            }
            else
            {
                MessageBox.Show("Zaznacz p³atnoœæ do edycji.");
            }
        }



        private void LoadReservationsData()
        {
            {
                string connectionString = "Server=(local)\\SQLEXPRESS;Database=SiecHoteli;Trusted_Connection=true;Encrypt=false;";

                string query = @"SELECT r.ID_Reservation,
                            g.Name + ' ' + g.Surname as Guest_Name,
                            h.Name + ' - Pokój ' + CAST(ro.Room_Number as varchar) as Room_Info,
                            r.Start_Date,
                            r.End_Date,
                            r.Reservation_Status
                     FROM Reservations r
                     INNER JOIN Guests g ON r.ID_Guest = g.ID_Guest
                     INNER JOIN Rooms ro ON r.ID_Room = ro.ID_Room
                     INNER JOIN Hotels h ON ro.ID_Hotel = h.ID_Hotel
                     ORDER BY r.End_Date";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView4.DataSource = dataTable;
                }
            }
        }
        private void button4Odswiez_Rezerwacje_Click(object sender, EventArgs e)
        {
            LoadReservationsData();
        }



        private void LoadPaymentsData()
        {
            //³¹czenie z baz¹ 
            string connectionString = "Server=(local)\\SQLEXPRESS;Database=SiecHoteli;Trusted_Connection=true;TrustServerCertificate=true;";


            string query = "SELECT ID_Payment, ID_Reservation, Amount, Payment_Date, Payment_Method FROM Payments";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // pobór danych i wype³nianie tabeli
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // wyœwietlenie wyników w w widoku p³atnoœci
                dataGridView5.DataSource = dataTable;
            }
        }
        private void button12Dodaj_Platnosc_Click(object sender, EventArgs e)
        {
            AddAmountFormcs okno = new AddAmountFormcs();
            okno.ShowDialog();

            LoadPaymentsData();
        }

        private void button15Odswiez_Platnosc_Click(object sender, EventArgs e)
        {
            LoadPaymentsData();  
        }

        private void button14Usun_Platnosc_Click(object sender, EventArgs e)
        {
            {
                if (dataGridView5.CurrentRow != null)
                {
                    DialogResult wynik = MessageBox.Show("Czy na pewno chcesz usun¹æ t¹ p³atnoœæ?", "Potwierdzenie", MessageBoxButtons.YesNo);

                    if (wynik == DialogResult.Yes)
                    {
                        // 2. Pobieramy ID z zaznaczonego wiersza
                        int idDoUsuniecia = Convert.ToInt32(dataGridView5.CurrentRow.Cells[0].Value);

                        string connectionString = "Server=(local)\\SQLEXPRESS;Database=SiecHoteli;Trusted_Connection=true;TrustServerCertificate=true;";
                        string query = "DELETE FROM Payments WHERE ID_Payment = @id";

                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            SqlCommand command = new SqlCommand(query, connection);
                            command.Parameters.AddWithValue("@id", idDoUsuniecia);

                            connection.Open();
                            command.ExecuteNonQuery();
                            connection.Close();
                        }
                        LoadPaymentsData(); //wywo³anie metody ³adowania danych o p³atnoœciach

                        MessageBox.Show("P³atnoœæ usuniêta");
                    }
                }
            }
        }

        private void button1Dodaj_Rezerwacje_Click(object sender, EventArgs e)
        {
            AddReservationForm okno = new AddReservationForm();
            okno.ShowDialog();
            LoadReservationsData();
        }

        private void button2Edytuj_Rezerwacje_Click(object sender, EventArgs e)
        {
            if (dataGridView4.CurrentRow != null)
            {
                AddReservationForm okno = new AddReservationForm();

                // Wyci¹gnij ID i dane z wiersza
                okno.ID_Reservation = Convert.ToInt32(dataGridView4.CurrentRow.Cells[0].Value);

                okno.ShowDialog();
                LoadReservationsData();
            }
            else
                MessageBox.Show("Wybierz rezerwacjê do edycji!");

        }

        private void button3Usun_Rezerwacje_Click(object sender, EventArgs e)
        {
            if (dataGridView4.CurrentRow != null)
            {
                if (MessageBox.Show("Czy na pewno usun¹æ rezerwacjê?", "Potwierdzenie", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int reservationId = Convert.ToInt32(dataGridView4.CurrentRow.Cells[0].Value);

                    string connectionString = "Server=(local)\\SQLEXPRESS;Database=SiecHoteli;Trusted_Connection=true;Encrypt=false;";
                    string query = "DELETE FROM Reservations WHERE ID_Reservation = @ID";

                    try
                    {
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            SqlCommand command = new SqlCommand(query, connection);
                            command.Parameters.AddWithValue("@ID", reservationId);
                            connection.Open();
                            command.ExecuteNonQuery();
                            connection.Close();
                        }

                        MessageBox.Show("Rezerwacja usuniêta!");
                        LoadReservationsData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("B³¹d: " + ex.Message);
                    }
                }
            }
            else
                MessageBox.Show("Wybierz rezerwacjê do usuniêcia.");
        }



        private void button5Dodaj_Pokoj_Click(object sender, EventArgs e)
        {
            AddRoomForm okno = new AddRoomForm();
            okno.ShowDialog();
            LoadRoomsData();
        }

        private void button10Usun_Pokoj_Click(object sender, EventArgs e)
        {
            if (dataGridView3.CurrentRow != null)
            {
                if (MessageBox.Show("Czy na pewno usun¹æ pokój?", "Potwierdzenie", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int roomId = Convert.ToInt32(dataGridView3.CurrentRow.Cells[0].Value);

                    string connectionString = "Server=(local)\\SQLEXPRESS;Database=SiecHoteli;Trusted_Connection=true;Encrypt=false;";
                    string query = "DELETE FROM Rooms WHERE ID_Room = @ID";

                    try
                    {
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            SqlCommand command = new SqlCommand(query, connection);
                            command.Parameters.AddWithValue("@ID", roomId);
                            connection.Open();
                            command.ExecuteNonQuery();
                            connection.Close();
                        }

                        MessageBox.Show("Pokój usuniêty!");
                        LoadRoomsData();
                    }
                    catch (Exception ex)
                    {
                        if (ex.Message.Contains("REFERENCE constraint"))
                        {
                            MessageBox.Show("Nie mo¿na usun¹æ pokoju - ma przypisane rezerwacje!");
                        }
                        else
                        {
                            MessageBox.Show("B³¹d: " + ex.Message);
                        }
                    }
                }
            }
            else
                MessageBox.Show("Wybierz pokój do usuniêcia.");
        }

        private void button11Odswiez_Pokoj_Click(object sender, EventArgs e)
        {
            LoadRoomsData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Goœcie_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPageGoœcie_Click(object sender, EventArgs e)
        {

        }

        private void tabPagePokoje_Click(object sender, EventArgs e)
        {

        }

        private void tabPageP³atnoœci_Click(object sender, EventArgs e)
        {

        }
        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}



