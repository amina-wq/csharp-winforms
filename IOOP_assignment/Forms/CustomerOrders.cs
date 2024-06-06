using IOOP_assignment.Components;
using IOOP_assignment.Core;
using IOOP_assignment.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_assignment.Forms
{
    public partial class CustomerOrders : BorderlessForm
    {
        private Customer _customer;
        private OrderRepository _orderRepository;
        private CustomerNavBar _customerNavBar;

        public CustomerOrders(Customer customer)
        {
            InitializeComponent();
            _customer = customer;
            DBManager database = new DBManager(ConfigurationManager.ConnectionStrings["ioop"].ToString());
            _orderRepository = new OrderRepository(database);
        }

        private void CustomerOrders_Load(object sender, EventArgs e)
        {
            _customerNavBar = new CustomerNavBar(_customer);
            _customerNavBar.BackColor = Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(206)))), ((int)(((byte)(170)))));
            _customerNavBar.Location = new Point(12, 85);
            _customerNavBar.TabIndex = 0;
            _customerNavBar.Click += this.viewCustomerMenuButton_Click;

            this.Controls.Add(_customerNavBar);
            LoadOrders();
        }

        private void LoadOrders()
        {
            List<Order> orders = _orderRepository.GetOrders(_customer);
            flowLayoutOrdersPanels.Controls.Clear();

            foreach (Order item in orders)
            {
                var panel = CreateOrderPanel(item);
                flowLayoutOrdersPanels.Controls.Add(panel);
            }
        }

        private FlowLayoutPanel CreateOrderPanel(Order order)
        {
            int panelWidth = (int)(flowLayoutOrdersPanels.Width * 0.9);

            var orderDateTimeLabel = new Label
            {
                Text = $"Date&Time: {order.DateTime.ToString("dd.MM.yyyy, HH:mm")}",
                Font = new Font("Open Sans", 10, FontStyle.Bold),
                Width = panelWidth,
            };

            var orderStatusLabel = new Label
            {
                Text = $"Status: {order.OrderStatus}",
                Font = new Font("Open Sans", 10, FontStyle.Bold),
                Width = panelWidth,
            };

            var orderDetailsLabel = new Label
            {
                Text = "Order Details:",
                Font = new Font("Open Sans", 10, FontStyle.Bold),
                Width = panelWidth,
            };

            MenuItemsContainer orderItems = new MenuItemsContainer();
            foreach (Models.MenuItem orderItem in order.MenuItems)
            {
                orderItems.AddItem(orderItem);
            }

            Dictionary<Models.MenuItem, int> items = orderItems.GetItems();


            var orderItemsPanel = new FlowLayoutPanel
            {
                Width = panelWidth - 20,
                Height = items.Count * 25,
                AutoScroll = true,
                FlowDirection = FlowDirection.TopDown,
                BackColor = Color.FromArgb(234, 206, 170),
            };

            foreach (var kvp in orderItems.GetItems())
            {
                var item = kvp.Key;
                var quantity = kvp.Value;

                var label = new Label
                {
                    Text = $"{item.ItemName} x {quantity} : RM {item.Price * quantity}",
                    Font = new Font("Open Sans", 12, FontStyle.Bold),
                    AutoSize = true,
                };

                orderItemsPanel.Controls.Add(label);

            }

            var orderTotalSum = new Label
            {
                Text = $"Total: {orderItems.GetTotal()}",
                Font = new Font("Open Sans", 14, FontStyle.Bold),
                Width = panelWidth,
            };

            FlowLayoutPanel panel = new FlowLayoutPanel
            {
                Width = panelWidth,
                Height = orderDateTimeLabel.Height + orderItemsPanel.Height + orderStatusLabel.Height + orderDetailsLabel.Height + orderTotalSum.Height + 20,
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.FromArgb(234, 206, 170),
                Margin = new Padding(10),
            };

            panel.Controls.Add(orderDateTimeLabel);
            panel.Controls.Add(orderStatusLabel);
            panel.Controls.Add(orderDetailsLabel);
            panel.Controls.Add(orderItemsPanel);
            panel.Controls.Add(orderTotalSum);

            return panel;
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

