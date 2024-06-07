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
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-UIM3V3L;Initial Catalog=ItemDB;Integrated Security=True;Encrypt=False");
            con.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO ReservationInfo(ReservationID, ReservationType, ReservationDetails, CustomerID, BookingDate) VALUES (@ReservationID, @ReservationType, @ReservationDetails, @CustomerID, @BookingDate)", con);
            cmd.Parameters.AddWithValue("@ReservationID", txtboxReservID.Text);
            cmd.Parameters.AddWithValue("@ReservationType", cmboxReservType.Text);
            cmd.Parameters.AddWithValue("@ReservationDetails", cmboxReservDetails.Text);
            cmd.Parameters.AddWithValue("@CustomerID", txtboxCusID.Text);
            cmd.Parameters.AddWithValue("@BookingDate", DTPBookingDate.Value.ToString("MM/dd/yyyy"));
            cmd.ExecuteNonQuery();
            con.Close();

            txtboxReservID.Text = "";
            cmboxReservType.Text = "";
            cmboxReservDetails.Text = "";
            txtboxCusID.Text = "";
            DTPBookingDate.Text = "";

            MessageBox.Show("Succesfully Added!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-UIM3V3L;Initial Catalog=ItemDB;Integrated Security=True;Encrypt=False");
            con.Open();

            SqlCommand cmd = new SqlCommand("UPDATE ReservationInfo SET ReservationType=@ReservationType, ReservationDetails=@ReservationDetails, CustomerID=@CustomerID, BookingDate=@BookingDate WHERE ReservationID=@ReservationID", con);
            cmd.Parameters.AddWithValue("@ReservationID", txtboxReservID.Text);
            cmd.Parameters.AddWithValue("@ReservationType", cmboxReservType.Text);
            cmd.Parameters.AddWithValue("@ReservationDetails", cmboxReservDetails.Text);
            cmd.Parameters.AddWithValue("@CustomerID", txtboxCusID.Text);
            cmd.Parameters.AddWithValue("@BookingDate", DTPBookingDate.Value.ToString("MM/dd/yyyy"));
            cmd.ExecuteNonQuery();
            con.Close();

            txtboxReservID.Text = "";
            cmboxReservType.Text = "";
            cmboxReservDetails.Text = "";
            txtboxCusID.Text = "";
            DTPBookingDate.Text = "";

            MessageBox.Show("Succesfully Updated!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-UIM3V3L;Initial Catalog=ItemDB;Integrated Security=True;Encrypt=False");
            con.Open();

            SqlCommand cmd = new SqlCommand("DELETE ReservationInfo WHERE ReservationID=@ReservationID", con);
            cmd.Parameters.AddWithValue("@ReservationID", txtboxReservID.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            txtboxReservID.Text = "";
            cmboxReservType.Text = "";
            cmboxReservDetails.Text = "";
            txtboxCusID.Text = "";
            DTPBookingDate.Text = "";

            MessageBox.Show("Succesfully Deleted!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-UIM3V3L;Initial Catalog=ItemDB;Integrated Security=True;Encrypt=False");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM ReservationInfo WHERE ReservationID=@ReservationID", con);
            cmd.Parameters.AddWithValue("@ReservationID", txtboxReservID.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt  = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void FrmReservation_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-UIM3V3L;Initial Catalog=ItemDB;Integrated Security=True;Encrypt=False");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT* FROM ReservationInfo", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
