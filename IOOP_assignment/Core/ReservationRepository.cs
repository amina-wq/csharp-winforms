using IOOP_assignment.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOOP_assignment.Core
{
    internal class ReservationRepository
    {
        private readonly DBManager _database;

        public ReservationRepository(DBManager database)
        {
            _database = database;
        }

        public List<Reservation> GetReservations(Customer customer)
        {
            List<Reservation> reservations = new List<Reservation>();

            using (SqlConnection conn = _database.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM Reservation WHERE CustomerID = @CustomerID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CustomerID", customer.UserID);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Reservation reservation = new Reservation
                        {
                            ReservationID = reader.GetGuid(0),
                            Customer = customer,
                            ReservationDateTime = reader.GetDateTime(2),
                            ReservationType = reader.GetString(3),
                            ReservationDetails = reader.IsDBNull(4) ? null : reader.GetString(4)
                        };
                        reservations.Add(reservation);
                    }
                }
            }

            return reservations;
        }
    }
}
