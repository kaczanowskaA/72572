using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HotelReservation
{
    public partial class AddReservationForm : Form
    {
        public int ID_Reservation = 0;
        public AddReservationForm()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            LoadGuests();
            LoadRooms();
            LoadStatuses();
        }
        private void LoadGuests()
        {
            string connectionString = "Server=(local)\\SQLEXPRESS;Database=SiecHoteli;Trusted_Connection=true;Encrypt=false;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT ID_Guest, Name + ' ' + Surname as FullName FROM Guests ORDER BY Name";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                comboBoxGosc.DataSource = dataTable;
                comboBoxGosc.DisplayMember = "FullName";
                comboBoxGosc.ValueMember = "ID_Guest";
            }
        }
        private void LoadRooms()
        {
            string connectionString = "Server=(local)\\SQLEXPRESS;Database=SiecHoteli;Trusted_Connection=true;Encrypt=false;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"SELECT r.ID_Room, 
                               h.Name + ' - Pokój ' + CAST(r.Room_Number as varchar) + ' (' + ISNULL(r.Type, '') + ')' as RoomDisplay
                        FROM Rooms r 
                        INNER JOIN Hotels h ON r.ID_Hotel = h.ID_Hotel 
                        ORDER BY h.Name, r.Room_Number";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                comboBox2Pokoj.DataSource = dataTable;
                comboBox2Pokoj.DisplayMember = "RoomDisplay";
                comboBox2Pokoj.ValueMember = "ID_Room";
            }
        }
        private void LoadStatuses()
        {
            comboBoxStatus.Items.Clear();
            comboBoxStatus.Items.Add("Potwierdzona");
            comboBoxStatus.Items.Add("Oczekująca");
            comboBoxStatus.Items.Add("Anulowana");

            if (comboBoxStatus.Items.Count > 0)
                comboBoxStatus.SelectedIndex = 0; // Domyślnie "Potwierdzona"
        }
    

        private void buttonAnulujRez_Click(object sender, EventArgs e)
        {
            this.Close();
        }
   

        private void buttonZapiszRez_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=(local)\\SQLEXPRESS;Database=SiecHoteli;Trusted_Connection=true;Encrypt=false;";
            string query;

            if (ID_Reservation > 0)
            {
                
                query = "UPDATE Reservations SET ID_Guest=@Guest, ID_Room=@Room, Start_Date=@CheckIn, End_Date=@CheckOut, Reservation_Status=@Status WHERE ID_Reservation=@ID";
            }
            else
            {
                
                query = "INSERT INTO Reservations (ID_Guest, ID_Room, Start_Date, End_Date, Reservation_Status) VALUES (@Guest, @Room, @CheckIn, @CheckOut, @Status)";
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Guest", comboBoxGosc.SelectedValue);
                command.Parameters.AddWithValue("@Room", comboBox2Pokoj.SelectedValue);
                command.Parameters.AddWithValue("@CheckIn", dateTimePickerOd.Value);
                command.Parameters.AddWithValue("@CheckOut", dateTimePicker2.Value);
                command.Parameters.AddWithValue("@Status", comboBoxStatus.Text);

                if (ID_Reservation > 0) command.Parameters.AddWithValue("@ID", ID_Reservation);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }

            MessageBox.Show(ID_Reservation > 0 ? "Rezerwacja zaktualizowana!" : "Rezerwacja dodana!");
            this.Close();
        }







        private void AddReservationForm_Load_1(object sender, EventArgs e)
        {
            
        }

        private void comboBoxGosc_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label3DataOd_Click(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }
    }
}
