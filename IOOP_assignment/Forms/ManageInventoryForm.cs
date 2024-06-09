using IOOP_assignment.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_assignment.Forms
{
    public partial class ManageInventoryForm : Form
    {
        private DropdownAnimator _dropdownAnimator;
        private SQLConnect _sqlConnect;
        public ManageInventoryForm()
        {
            InitializeComponent();
            _dropdownAnimator = new DropdownAnimator(DropdownPanel, 300, 10);

            _sqlConnect = new SQLConnect();
        }
       
        private void ManageInventoryForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            using (SqlConnection connection = _sqlConnect.GetConnection())
            {
                connection.Open();
                string query = "SELECT [IngredientID], [IngredientName], [Quantity] FROM [ioop].[dbo].[Ingredient]";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView.DataSource = table;
            }
        }

        private void DropDown_Click(object sender, EventArgs e)
        {
            _dropdownAnimator.Toggle();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ChefDashboard chefDashboard = new ChefDashboard();
            chefDashboard.Show();
            this.Close();
        }

        private void btnViewOrder_Click(object sender, EventArgs e)
        {
            ViewOrdersForm viewOrdersForm = new ViewOrdersForm();
            viewOrdersForm.Show();
            this.Close();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You're already in this page.");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ViewOrdersForm viewOrdersForm = new ViewOrdersForm();
            viewOrdersForm.Show();
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIngredient.Text) || string.IsNullOrWhiteSpace(txtQuantity.Text))
            {
                MessageBox.Show("Please enter both Ingredient and Quantity.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(txtQuantity.Text, out decimal quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter a valid positive number for Quantity.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection connection = _sqlConnect.GetConnection())
            {
                connection.Open();

                string checkQuery = "SELECT COUNT(*) FROM [ioop].[dbo].[Ingredient] WHERE [IngredientName] = @IngredientName";
                using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@IngredientName", txtIngredient.Text);
                    int existingCount = (int)checkCommand.ExecuteScalar();

                    if (existingCount > 0)
                    {
                        MessageBox.Show("Ingredient '" + txtIngredient.Text + "' already exists.", "Duplicate Ingredient", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                string query = "INSERT INTO [ioop].[dbo].[Ingredient] ([IngredientID], [IngredientName], [Quantity], [IngredientDetails]) VALUES (@IngredientID, @IngredientName, @Quantity, @IngredientDetails)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IngredientID", Guid.NewGuid());
                    command.Parameters.AddWithValue("@IngredientName", txtIngredient.Text);
                    command.Parameters.AddWithValue("@Quantity", Convert.ToDecimal(txtQuantity.Text));
                    command.Parameters.AddWithValue("@IngredientDetails", "");
                    command.ExecuteNonQuery();
                }
            }

            LoadData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIngredient.Text) || string.IsNullOrWhiteSpace(txtQuantity.Text))
            {
                MessageBox.Show("Please enter both Ingredient and Quantity.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(txtQuantity.Text, out decimal quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter a valid positive number for Quantity.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (SqlConnection connection = _sqlConnect.GetConnection())
            {
                connection.Open();
                string query = "UPDATE [ioop].[dbo].[Ingredient] SET [Quantity] = @Quantity WHERE [IngredientName] = @IngredientName";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IngredientName", txtIngredient.Text);
                    command.Parameters.AddWithValue("@Quantity", Convert.ToDecimal(txtQuantity.Text));
                    command.ExecuteNonQuery();
                }
            }
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIngredient.Text))
            {
                MessageBox.Show("Please enter the Ingredient.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult dialogResult = MessageBox.Show(
                $"Are you sure you want to delete {txtIngredient.Text}?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                using (SqlConnection connection = _sqlConnect.GetConnection())
                {
                    connection.Open();
                    string query = "DELETE FROM [ioop].[dbo].[Ingredient] WHERE [IngredientName] = @IngredientName";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IngredientName", txtIngredient.Text);
                        command.ExecuteNonQuery();
                    }
                }
                LoadData();
            }
        }

        private void txtIngredient_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            string filterExpression = $"IngredientName LIKE '%{tbSearch.Text}%'";
            (dataGridView.DataSource as DataTable).DefaultView.RowFilter = filterExpression;
        }
    }
}
