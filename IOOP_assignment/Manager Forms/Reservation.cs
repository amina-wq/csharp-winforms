using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IOOP_assignment.Manager_Forms
{
    public partial class FrmReservation : Form
    {
        public FrmReservation()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-UIM3V3L;Initial Catalog=ReservationDB;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO ReservationInfo(ReservationID, ReservationType, ReservationDetails, CustomerID, JoiningDate) VALUES (@ReservationID, @ReservationType, @ReservationDetails, @CustomerID, @JoiningDate)", con);
            cmd.Parameters.AddWithValue("@ReservationID", textBox1.Text);
            cmd.Parameters.AddWithValue("@ReservationType", comboBox1.Text);
            cmd.Parameters.AddWithValue("@ReservationDetails", comboBox2.Text);
            cmd.Parameters.AddWithValue("@CustomerID", textBox2.Text);
            cmd.Parameters.AddWithValue("@JoiningDate", dateTimePicker1.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            textBox1.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            textBox2.Text = "";
            dateTimePicker1.Text = "";

            MessageBox.Show("Succesfully Added!");
        }
    }
}
