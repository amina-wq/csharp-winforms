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
    public partial class CustomerReservations : BorderlessForm
    {
        private Customer _customer;
        private CustomerNavBar _customerNavBar;
        private ReservationRepository _reservationRepository;

        public CustomerReservations(Customer customer)
        {
            InitializeComponent();
            _customer = customer;
            DBManager database = new DBManager(ConfigurationManager.ConnectionStrings["ioop"].ToString());
            _reservationRepository = new ReservationRepository(database);
        }

        private void CustomerReservations_Load(object sender, EventArgs e)
        {
            _customerNavBar = new CustomerNavBar(_customer);
            _customerNavBar.BackColor = Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(206)))), ((int)(((byte)(170)))));
            _customerNavBar.Location = new Point(12, viewCustomerMenuButton.Location.Y + viewCustomerMenuButton.Size.Height);
            _customerNavBar.Name = "customerNavBar";
            _customerNavBar.Size = new Size(0, 591);

            this.Controls.Add(_customerNavBar);
            LoadReservations();
        }

        private void LoadReservations()
        {
            List<Reservation> reservations = _reservationRepository.GetReservations(_customer);
            flowLayoutReservations.Controls.Clear();

            foreach (Reservation reservation in reservations)
            {
                var panel = CreateReservationPanel(reservation);
                flowLayoutReservations.Controls.Add(panel);
            }
        }

        private FlowLayoutPanel CreateReservationPanel(Reservation reservation)
        {
            int panelWidth = (int)(flowLayoutReservations.Width * 0.9);

            var panel = new FlowLayoutPanel
            {
                Width = panelWidth,
                AutoSize = true,
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.FromArgb(234, 206, 170),
                Margin = new Padding(10)
            };

            var reservationDateLabel = new Label
            {
                Text = $"Reservation Date: {reservation.ReservationDateTime.ToString("dd.MM.yyyy")}",
                Font = new Font("Segoe Print", 12, FontStyle.Bold),
                Width = panelWidth,
                Left = 10
            };

            var reservationTimeLabel = new Label
            {
                Text = $"Reservation Time: {reservation.ReservationDateTime.ToString("HH:mm")}",
                Font = new Font("Segoe Print", 12, FontStyle.Bold),
                Width = panelWidth,
                Left = 10
            };

            var reservationTypeLabel = new Label
            {
                Text = $"Type: {reservation.ReservationType}",
                Font = new Font("Segoe Print", 12, FontStyle.Bold),
                Width = panelWidth,
                Left = 10
            };

            var reservationDetailsLabel = new Label
            {
                Text = $"Details: {reservation.ReservationDetails}",
                Font = new Font("Segoe Print", 12, FontStyle.Bold),
                Width = panelWidth,
                Left = 10
            };

            panel.Controls.Add(reservationDateLabel);
            panel.Controls.Add(reservationTimeLabel);
            panel.Controls.Add(reservationTypeLabel);
            panel.Controls.Add(reservationDetailsLabel);

            return panel;
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
