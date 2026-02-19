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
    public partial class AddAmountFormcs : Form
    {
        public int ID_Payment = 0;
        public AddAmountFormcs()
        {
            InitializeComponent();
        }

        private void buttonAnulujPlatnosc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonZapiszPlatnosc_Click(object sender, EventArgs e)
        {
            {
                string connectionString = "Server=(local)\\SQLEXPRESS;Database=SiecHoteli;Trusted_Connection=true;Encrypt=false;";

                string query;

                if (ID_Payment > 0)
                {
                    query = "UPDATE Payments SET ID_Reservation=@Reservation, Amount=@Amount, Payment_Date=@Date, Payment_Method=@Method WHERE ID_Payment=@ID";
                }
                else
                {
                    query = "INSERT INTO Payments (ID_Reservation, Amount, Payment_Date, Payment_Method) VALUES (@Reservation, @Amount, @Date, @Method)";
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Reservation", comboBoxRezerwacja.Text);
                    command.Parameters.AddWithValue("@Amount", numericKwota.Value);
                    command.Parameters.AddWithValue("@Date", dateTimePickerPlatnosc.Value);
                    command.Parameters.AddWithValue("@Method", comboBoxMetoda.Text);

                    if (ID_Payment > 0) command.Parameters.AddWithValue("@ID", ID_Payment);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }

                MessageBox.Show("Płatność dodana!");
                this.Close();
            }
        }

        private void AddAmountFormcs_Load(object sender, EventArgs e)
        {
            {

                string connectionString = "Server=(local)\\SQLEXPRESS;Database=SiecHoteli;Trusted_Connection=true;TrustServerCertificate=true;";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT ID_Reservation FROM Reservations", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    comboBoxRezerwacja.DataSource = dt;
                    comboBoxRezerwacja.DisplayMember = "ID_Reservation";
                    comboBoxRezerwacja.ValueMember = "ID_Reservation";
                }
            }
        }

        private void comboBoxRezerwacja_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
