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
        

        private void button1_Click(object sender, EventArgs e) // button1_Click = btnCategoryAdd // 
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-UIM3V3L;Initial Catalog=ItemDB;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO ItemProduct(ItemID,ItemName,Price,CategoryID,CategoryName) VALUES (@ItemID,@ItemName,@Price,@CategoryID,@CategoryName)", con);
            cmd.Parameters.AddWithValue("@ItemID", txtboxItemID.Text);
            cmd.Parameters.AddWithValue("@ItemName", txtboxItemName.Text);
            cmd.Parameters.AddWithValue("@Price", txtboxPrice.Text);
            cmd.Parameters.AddWithValue("@CategoryID", txtboxCategoryID.Text);
            cmd.Parameters.AddWithValue("@CategoryName", txtboxCategoryName.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            txtboxItemID.Text = "";
            txtboxItemName.Text = "";
            txtboxPrice.Text = "";
            txtboxCategoryID.Text = "";
            txtboxCategoryName.Text = "";

            MessageBox.Show("Succesfully Added!");





        }


        private void button2_Click(object sender, EventArgs e)  // button2_Click = btnCategoryEdit // 
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-UIM3V3L;Initial Catalog=ItemDB;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("UPDATE ItemProduct SET ItemName=@ItemName, Price=@Price, CategoryID=@CategoryID, CategoryName=@CategoryName WHERE ItemID=@ItemID", con);
            cmd.Parameters.AddWithValue("@ItemID", txtboxItemID.Text);
            cmd.Parameters.AddWithValue("@ItemName", txtboxItemName.Text);
            cmd.Parameters.AddWithValue("@Price", txtboxPrice.Text);
            cmd.Parameters.AddWithValue("@CategoryID", txtboxCategoryID.Text);
            cmd.Parameters.AddWithValue("@CategoryName", txtboxCategoryName.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            txtboxItemID.Text = "";
            txtboxItemName.Text = "";
            txtboxPrice.Text = "";
            txtboxCategoryID.Text = "";
            txtboxCategoryName.Text = "";

            MessageBox.Show("Succesfully Updated!");
        }

        private void button3_Click(object sender, EventArgs e) // button3_Click = btnCategoryDelete // 
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-UIM3V3L;Initial Catalog=ItemDB;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("DELETE ItemProduct WHERE ItemID=@ItemID", con);
            cmd.Parameters.AddWithValue("@ItemID", txtboxItemID.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            txtboxItemID.Text = "";
            txtboxItemName.Text = "";
            txtboxPrice.Text = "";
            txtboxCategoryID.Text = "";
            txtboxCategoryName.Text = "";

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

        private void button4_Click(object sender, EventArgs e) // button4_Click = btnCategorySearch //
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-UIM3V3L;Initial Catalog=ItemDB;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM ItemProduct WHERE ItemID=@ItemID", con);
            cmd.Parameters.AddWithValue("@ItemID", txtboxItemID.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        

        
    }

}   
