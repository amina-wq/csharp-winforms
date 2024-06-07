using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_assignment.Manager_Forms
{
    public partial class FrmCategory : Form
    {
        public FrmCategory()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-UIM3V3L;Initial Catalog=ItemDB;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO ItemProduct(ItemID,ItemName,Price,CategoryID,CategoryName) VALUES (@ItemID,@ItemName,@Price,@CategoryID,@CategoryName)", con);
            cmd.Parameters.AddWithValue("@ItemID", textBox1.Text);
            cmd.Parameters.AddWithValue("@ItemName", textBox3.Text);
            cmd.Parameters.AddWithValue("@Price", textBox4.Text);
            cmd.Parameters.AddWithValue("@CategoryID", textBox2.Text);
            cmd.Parameters.AddWithValue("@CategoryName", textBox5.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            textBox1.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox2.Text = "";
            textBox5.Text = "";

            MessageBox.Show("Succesfully Added!");





        }


        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-UIM3V3L;Initial Catalog=ItemDB;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("UPDATE ItemProduct SET ItemName=@ItemName, Price=@Price, CategoryID=@CategoryID, CategoryName=@CategoryName WHERE ItemID=@ItemID", con);
            cmd.Parameters.AddWithValue("@ItemID", textBox1.Text);
            cmd.Parameters.AddWithValue("@ItemName", textBox3.Text);
            cmd.Parameters.AddWithValue("@Price", textBox4.Text);
            cmd.Parameters.AddWithValue("@CategoryID", textBox2.Text);
            cmd.Parameters.AddWithValue("@CategoryName", textBox5.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            textBox1.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox2.Text = "";
            textBox5.Text = "";

            MessageBox.Show("Succesfully Updated!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-UIM3V3L;Initial Catalog=ItemDB;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("DELETE ItemProduct WHERE ItemID=@ItemID", con);
            cmd.Parameters.AddWithValue("@ItemID", int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();
            con.Close();

            textBox1.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox2.Text = "";
            textBox5.Text = "";

            MessageBox.Show("Succesfully Deleted!");
        }
        private void FrmCategory_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-UIM3V3L;Initial Catalog=ItemDB;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM ItemProduct", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-UIM3V3L;Initial Catalog=ItemDB;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM ItemProduct WHERE ItemID=@ItemID", con);
            cmd.Parameters.AddWithValue("@ItemID", int.Parse(textBox1.Text));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }

}   
