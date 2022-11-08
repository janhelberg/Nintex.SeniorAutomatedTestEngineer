using System;
using Microsoft.Data.SqlClient;
using System.Text;
using System.Configuration;

namespace sqltest
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "jantest123.database.windows.net";
                builder.UserID = "useraccess";
                builder.Password = "P@ssw0rd123";
                builder.InitialCatalog = "Jantest";

                //Query 1
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    Console.WriteLine("Write a query to return a list of each invoice that contains flowers, sorted by invoice number");
                    Console.WriteLine("=========================================");

                    String sql = @"";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Console.WriteLine("{0}", reader.GetString(0));
                            }
                        }
                    }
                }

                //Query 2
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    Console.WriteLine("Write a query to return a list of product names and the amount of each product sold");
                    Console.WriteLine("=========================================");

                    String sql = @"";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Console.WriteLine("{0}, {1}", reader.GetString(0), reader.GetInt32(1));
                            }
                        }
                    }
                }

                //Query 3
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    Console.WriteLine("Write a query to return each product name and the total amount invoiced for each product where the invoice has a salesperson");
                    Console.WriteLine("=========================================");

                    String sql = @"";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Console.WriteLine("{0}, {1}", reader.GetString(0), reader.GetDecimal(1));
                            }
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.ReadLine();
        }
    }
}