using IOOP_assignment.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace IOOP_assignment.Core
{
    internal class MenuRepository
    {
        private readonly DBManager _database;

        public MenuRepository(DBManager database)
        {
            _database = database;
        }

        public List<MenuItem> GetMenuItems()
        {
            List<MenuItem> menuItems = new List<MenuItem>();

            using (SqlConnection conn = _database.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM MenuItem";
                SqlCommand cmd = new SqlCommand(query, conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        MenuItem item = new MenuItem
                        {
                            ItemID = reader.GetGuid(0),
                            ItemName = reader.GetString(1),
                            ItemCategory = GetCategory(reader.GetGuid(2)),
                            Price = reader.GetDecimal(3),
                            Ingredients = GetIngredients(reader.GetGuid(0)),
                        };
                        menuItems.Add(item);
                    }
                }
            }

            return menuItems;
        }

        public MenuItem GetItem(Guid itemId)
        {
            MenuItem item = null;

            using (SqlConnection conn = _database.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM MenuItem WHERE ItemID = @ItemID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ItemID", itemId);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        item = new MenuItem
                        {
                            ItemID = reader.GetGuid(0),
                            ItemName = reader.GetString(1),
                            ItemCategory = GetCategory(reader.GetGuid(2)),
                            Price = reader.GetDecimal(3),
                            Ingredients = GetIngredients(reader.GetGuid(0)),
                        };
                    }
                }
            }

            return item;
        }

        private Category GetCategory(Guid categoryId)
        {
            Category category = null;

            using (SqlConnection conn = _database.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM MenuCategory WHERE CategoryID = @CategoryID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CategoryID", categoryId);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        category = new Category
                        {
                            CategoryID = reader.GetGuid(0),
                            CategoryName = reader.GetString(1)
                        };
                    }
                }
            }

            return category;
        }

        private List<Ingredient> GetIngredients(Guid itemId)
        {
            List<Ingredient> ingredients = new List<Ingredient>();

            using (SqlConnection conn = _database.GetConnection())
            {
                conn.Open();
                string query = @"SELECT i.IngredientID, i.IngredientName, i.Quantity, i.IngredientDetails 
                             FROM Ingredient i
                             JOIN ItemIngredient ii ON i.IngredientID = ii.IngredientID
                             WHERE ii.ItemID = @ItemID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ItemID", itemId);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Ingredient ingredient = new Ingredient
                        {
                            IngredientID = reader.GetGuid(0),
                            IngredientName = reader.GetString(1),
                            Quantity = reader.GetDecimal(2),
                            IngredientDetails = reader.GetString(3)
                        };
                        ingredients.Add(ingredient);
                    }
                }
            }

            return ingredients;
        }

    }
}
