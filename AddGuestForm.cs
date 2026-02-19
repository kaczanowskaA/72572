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

namespace HotelReservation
{
    public partial class AddGuestForm : Form

    {
        public int ID_Guest = 0;
        public AddGuestForm()
        {
            InitializeComponent();
        }

        private void buttonAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonZapisz_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=(local)\\SQLEXPRESS;Database=SiecHoteli;Trusted_Connection=true;TrustServerCertificate=true;";
            string query;

            if (ID_Guest > 0)
                query = "UPDATE Guests SET Name=@Name, Surname=@Surname, Email=@Email, Phone_Number=@Phone WHERE ID_Guest=@ID";
            else
                query = "INSERT INTO Guests (Name, Surname, Email, Phone_Number) VALUES (@Name, @Surname, @Email, @Phone)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", textBoxImie.Text);
                command.Parameters.AddWithValue("@Surname", textBoxNazwisko.Text);
                command.Parameters.AddWithValue("@Email", textBoxEmail.Text);
                command.Parameters.AddWithValue("@Phone", textBoxPhone.Text);

                if (ID_Guest > 0) command.Parameters.AddWithValue("@ID", ID_Guest);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }

            MessageBox.Show(ID_Guest > 0 ? "Dane zaktualizowane!" : "Gość dodany!");
            this.Close();
        }
        








        private void AddGuestForm_Load(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxImie_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNazwisko_TextChanged(object sender, EventArgs e)
        {
        }


    }
}
