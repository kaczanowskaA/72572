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
    public partial class AddHotelForm : Form

    {
        private int hotelId;
        private string? nazwa;
        private string? miasto;
        private string? adres;
        private int gwiazdki;


        public int ID_Hotel = 0;

        public AddHotelForm()
        {
            InitializeComponent();
        }

        public AddHotelForm(int hotelId, string? nazwa, string? miasto, string? adres, int gwiazdki)
        {
            this.hotelId = hotelId;
            this.nazwa = nazwa;
            this.miasto = miasto;
            this.adres = adres;
            this.gwiazdki = gwiazdki;
        }

        private void buttonAnulujHotel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonZapiszHotel_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=(local)\\SQLEXPRESS;Database=SiecHoteli;Trusted_Connection=true;Encrypt=false;";
            string query;

            if (ID_Hotel > 0)
                query = "UPDATE Hotels SET Name=@Name, City=@City, Address=@Address, Stars=@Stars WHERE ID_Hotel=@ID";
            else
                query = "INSERT INTO Hotels (Name, City, Address, Stars) VALUES (@Name, @City, @Address, @Stars)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", textBoxNazwaHotel.Text);
                command.Parameters.AddWithValue("@City", textBoxMiasto.Text);
                command.Parameters.AddWithValue("@Address", textBoxAdres.Text);
                command.Parameters.AddWithValue("@Stars", numericGwiazdki.Value);

                if (ID_Hotel > 0) command.Parameters.AddWithValue("@ID", ID_Hotel);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }

            MessageBox.Show(ID_Hotel > 0 ? "Hotel zaktualizowany!" : "Hotel dodany!");
            this.Close();
        }


















        private void AddHotelForm_Load(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void textBoxNazwaHotel_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
