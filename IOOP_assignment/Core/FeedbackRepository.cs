using IOOP_assignment.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOOP_assignment.Core
{
    internal class FeedbackRepository
    {
        private readonly DBManager _database;

        public FeedbackRepository(DBManager database)
        {
            _database = database;
        }

        public List<Feedback> GetFeedbacks(Customer customer)
        {
            List<Feedback> feedbacks = new List<Feedback>();

            using (SqlConnection conn = _database.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM Feedback WHERE CustomerID = @CustomerID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CustomerID", customer.UserID);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Feedback feedback = new Feedback
                        {
                            FeedbackID = reader.GetGuid(0),
                            Customer = customer,
                            FeedbackMessage = reader.GetString(2),
                            FeedbackDateTime = reader.GetDateTime(3)
                        };
                        feedbacks.Add(feedback);
                    }
                }
            }

            return feedbacks;
        }

        public void AddFeedback(Feedback feedback)
        {
            using (SqlConnection conn = _database.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO Feedback (FeedbackID, CustomerID, FeedbackMessage, FeedbakcDateTime) VALUES (@FeedbackID, @CustomerID, @FeedbackMessage, @FeedbackDateTime)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@FeedbackID", feedback.FeedbackID);
                cmd.Parameters.AddWithValue("@CustomerID", feedback.Customer.UserID);
                cmd.Parameters.AddWithValue("@FeedbackMessage", feedback.FeedbackMessage);
                cmd.Parameters.AddWithValue("@FeedbackDateTime", feedback.FeedbackDateTime);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
