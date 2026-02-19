using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservation
{
    public partial class AddRoomForm : Form
    {
        public int ID_Room = 0;
        public AddRoomForm()
        {
            InitializeComponent();
            LoadHotelsData();
        }
        private void LoadHotelsData()
        {
            string connectionString = "Server=(local)\\SQLEXPRESS;Database=SiecHoteli;Trusted_Connection=true;Encrypt=false;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT ID_Hotel, Name FROM Hotels ORDER BY Name";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                comboBoxHotel.DataSource = dataTable; 
                comboBoxHotel.DisplayMember = "Name";
                comboBoxHotel.ValueMember = "ID_Hotel";
            }
        }
        private void button2Anuluj_Pokoj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

        private void buttonZapisz_Pokoj_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=(local)\\SQLEXPRESS;Database=SiecHoteli;Trusted_Connection=true;Encrypt=false;";
            if (ID_Room > 0)
            {
                //  czy pokój ma aktywne rezerwacje
                string checkQuery = "SELECT COUNT(*) FROM Reservations WHERE ID_Room = @RoomID AND Reservation_Status != 'Anulowana'";
                using (SqlConnection checkConn = new SqlConnection(connectionString))
                {
                    checkConn.Open();
                    SqlCommand checkCmd = new SqlCommand(checkQuery, checkConn);
                    checkCmd.Parameters.AddWithValue("@RoomID", ID_Room);
                    int reservationCount = (int)checkCmd.ExecuteScalar();

                    if (reservationCount > 0)
                    {
                        MessageBox.Show("Nie można edytować pokoju - ma aktywne rezerwacje!");
                        return; 
                    }
                }
            }

            string query;

            if (ID_Room > 0)
                query = "UPDATE Rooms SET ID_Hotel=@Hotel, Room_Number=@Number, Type=@Type, Price_Per_Day=@Price WHERE ID_Room=@ID";
            else
                query = "INSERT INTO Rooms (ID_Hotel, Room_Number, Type, Price_Per_Day) VALUES (@Hotel, @Number, @Type, @Price)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Hotel", comboBoxHotel.SelectedValue);
                command.Parameters.AddWithValue("@Number", textBoxNumer.Text);
                command.Parameters.AddWithValue("@Type", textBoxTyp.Text);
                command.Parameters.AddWithValue("@Price", numericUpDown1.Value);

                if (ID_Room > 0) command.Parameters.AddWithValue("@ID", ID_Room);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }

            MessageBox.Show(ID_Room > 0 ? "Pokój zaktualizowany!" : "Pokój dodany!");
            this.Close();
            }







        private void AddRoomForm_Load(object sender, EventArgs e)
        {
           
        }

    }

    }


