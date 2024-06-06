using IOOP_assignment.Core;
using IOOP_assignment.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace IOOP_assignment.Forms
{
    public partial class CartForm : BorderlessForm
    {
        private Customer _customer;
        private MenuItemsContainer _shoppingCart;
        private OrderRepository _orderRepository;

        public CartForm(MenuItemsContainer shoppingCart, Customer customer)
        {
            InitializeComponent();
            DBManager database = new DBManager(ConfigurationManager.ConnectionStrings["ioop"].ToString());
            _orderRepository = new OrderRepository(database);
            _shoppingCart = shoppingCart;
            _customer = customer;
        }

        private void CartForm_Load(object sender, EventArgs e)
        {
            LoadCartItems();
        }

        private void LoadCartItems()
        {
            flowLayoutPanelCartItems.Controls.Clear();
            var cartItems = _shoppingCart.GetItems();

            foreach (var kvp in cartItems)
            {
                var item = kvp.Key;
                var quantity = kvp.Value;
                var panel = CreateCartItemPanel(item, quantity);
                flowLayoutPanelCartItems.Controls.Add(panel);
            }

            UpdateTotal();
        }

        private Panel CreateCartItemPanel(Models.MenuItem menuItem, int quantity)
        {
            int panelWidth = flowLayoutPanelCartItems.Width - 25;

            var panel = new Panel
            {
                Width = panelWidth,
                Height = 50,
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.FromArgb(234, 206, 170),
                Padding = new Padding(5),
                Margin = new Padding(5),
            };

            var lblName = new Label
            {
                Text = $"{menuItem.ItemName} x {quantity}",
                Font = new Font("Open Sans", 12, FontStyle.Bold),
                Width = (int)(panelWidth * 0.5),
                Top = 10,
            };

            var lblPrice = new Label
            {
                Text = $"RM {menuItem.Price * quantity}",
                Font = new Font("Open Sans", 12, FontStyle.Bold),
                Width = (int)(panelWidth * 0.2),
                Top = 10,
                Left = (int)(panelWidth * 0.5),
            };

            var btnRemove = new Button
            {
                Text = "Remove",
                Width = 80,
                Top = 10,
                Left = panelWidth - 90,
                BackColor = Color.FromArgb(0, 0, 0),
                ForeColor = Color.FromArgb(255, 255, 255),
                FlatStyle = FlatStyle.Flat,
                FlatAppearance = { BorderSize = 0 },
                Tag = menuItem
            };
            btnRemove.Click += BtnRemove_Click;

            panel.Controls.Add(lblName);
            panel.Controls.Add(lblPrice);
            panel.Controls.Add(btnRemove);

            return panel;
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            var menuItem = button.Tag as Models.MenuItem;
            _shoppingCart.RemoveItem(menuItem);

            LoadCartItems();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            List<Models.MenuItem> cartItems = _shoppingCart.ToList();
            if (cartItems.Count > 0)
            {
                _orderRepository.CreateOrder(_customer.UserID, cartItems);
                MessageBox.Show("Order placed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _shoppingCart.Clear();
                LoadCartItems();
            }
            else
            {
                MessageBox.Show("Your shopping cart is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateTotal()
        {
            var total = _shoppingCart.GetItems().Sum(i => i.Key.Price * i.Value);
            lblTotal.Text = $"Total: RM {total:0.00}";
        }
    }
}
