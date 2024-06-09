using IOOP_assignment.Components;
using IOOP_assignment.Core;
using IOOP_assignment.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace IOOP_assignment.Forms
{
    public partial class CustomerMenu : BorderlessForm
    {
        private Customer _customer;
        private MenuRepository _menuRepository;
        private MenuItemsContainer _shoppingCart;
        private CustomerNavBar _customerNavBar;

        public CustomerMenu(Customer customer)
        {
            _customer = customer;
            InitializeComponent();
            DBManager database = new DBManager(ConfigurationManager.ConnectionStrings["ioop"].ToString());
            _menuRepository = new MenuRepository(database);
            _shoppingCart = new MenuItemsContainer();
        }

        private void CustomerMenu_Load(object sender, EventArgs e)
        {
            _customerNavBar = new CustomerNavBar(_customer);
            _customerNavBar.BackColor = Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(206)))), ((int)(((byte)(170)))));
            _customerNavBar.Location = new Point(12, 85);
            _customerNavBar.Name = "customerNavBar";
            _customerNavBar.Size = new Size(0, 591);

            this.Controls.Add(_customerNavBar);
            LoadMenuItems();
        }

        private void LoadMenuItems()
        {
            var menuItems = _menuRepository.GetMenuItems();
            var groupedItems = menuItems.GroupBy(item => item.ItemCategory.CategoryName).ToList();
            flowLayoutPanelMenuItems.Controls.Clear();

            foreach (var group in groupedItems)
            {
                var categoryLabel = new Label
                {
                    Text = group.Key.ToUpper(),
                    Font = new Font("Segoe Print", 12, FontStyle.Bold),
                    Width = (int)(this.Width * 0.7),
                    Margin = new Padding(0, 10, 0, 10),
                    BackColor = Color.Transparent,
                    ForeColor = Color.FromArgb(234, 206, 170),
                };
                flowLayoutPanelMenuItems.Controls.Add(categoryLabel);

                foreach (var item in group)
                {
                    var panel = CreateMenuItemPanel(item);
                    flowLayoutPanelMenuItems.Controls.Add(panel);
                }
            }
        }

        private Panel CreateMenuItemPanel(Models.MenuItem item)
        {
            int panelWidth = (int)(this.Width * 0.7);

            var panel = new Panel
            {
                Width = panelWidth,
                Height = 50,
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.FromArgb(234, 206, 170),
            };

            int lblNameWidth = (int)(panelWidth * 0.3);

            var lblName = new Label
            {
                Text = item.ItemName,
                Font = new Font("Segoe Print", 12, FontStyle.Bold),
                Width = lblNameWidth,
                Top = 10,
            };

            int lblPriceWidth = (int)(panelWidth * 0.25);
            int lblPriceLeft = lblNameWidth + (int)(panelWidth * 0.1);
            int quantity = _shoppingCart.GetQuantity(item);

            var lblPrice = new Label
            {
                Text = $"RM {item.Price} x {quantity}",
                Font = new Font("Segoe Print", 12, FontStyle.Bold),
                Width = lblPriceWidth,
                Top = 10,
                Left = lblPriceLeft,
                Name = "lblPrice"
            };

            int btnAddToCartWidth = 100;
            int btnAddToCartLeft = panelWidth - btnAddToCartWidth - (int)(panelWidth * 0.05);

            var btnAddToCart = new Button
            {
                Text = "Add to Cart",
                Font = new Font("Segoe Print", 8, FontStyle.Bold),
                Width = btnAddToCartWidth,
                Top = 10,
                Left = btnAddToCartLeft,
                BackColor = Color.FromArgb(0, 0, 0),
                ForeColor = Color.FromArgb(255, 255, 255),
                FlatStyle = FlatStyle.Flat,
                FlatAppearance = { BorderSize = 0 },
                Tag = item
            };
            btnAddToCart.Click += BtnAddToCart_Click;

            panel.Controls.Add(lblName);
            panel.Controls.Add(lblPrice);
            panel.Controls.Add(btnAddToCart);

            return panel;
        }

        private void BtnAddToCart_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            var selectedItem = button.Tag as Models.MenuItem;
            _shoppingCart.AddItem(selectedItem);

            var panel = button.Parent as Panel;
            var lblPrice = panel.Controls.Find("lblPrice", true).FirstOrDefault() as Label;
            int quantity = _shoppingCart.GetQuantity(selectedItem);
            lblPrice.Text = $"RM {selectedItem.Price} x {quantity}";
        }

        private void btnShowCart_Click(object sender, EventArgs e)
        {
            using (var cartForm = new CartForm(_shoppingCart, _customer))
            {
                cartForm.ShowDialog();
                LoadMenuItems();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void viewCustomerMenuButton_Click(object sender, EventArgs e)
        {
            if (_customerNavBar.Width == 0)
            {
                _customerNavBar.BringToFront();
                _customerNavBar.Width = 150;
            }
            else
            {
                _customerNavBar.Width = 0;
            }
        }
    }
}
