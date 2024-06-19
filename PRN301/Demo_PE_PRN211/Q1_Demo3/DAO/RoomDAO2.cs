using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Q1_Demo3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1_Demo3_ADO.DAO
{
    internal class RoomDAO2
    {
        private string connectionString;

        static String getConnection()
        {
            var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

            IConfiguration configuration = builder.Build();
            return configuration.GetConnectionString("DBContext");
        }
        public RoomDAO2(string connectionString)
        {
            this.connectionString = getConnection();
        }

        public void AddRoom(Room room)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT [dbo].[Rooms] VALUES (@Title, @Square, @Floor, @Description, @Comment)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Title", room.Title);
                command.Parameters.AddWithValue("@Square", room.Square);
                command.Parameters.AddWithValue("@Floor", room.Floor);
                command.Parameters.AddWithValue("@Description", room.Description);
                command.Parameters.AddWithValue("@Comment", room.Comment);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void EditRoom(Room room)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Rooms " +
                               "SET Square = @Square, Floor = @Floor, Description = @Description, Comment = @Comment " +
                               "WHERE Title = @Title";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Square", room.Square);
                command.Parameters.AddWithValue("@Floor", room.Floor);
                command.Parameters.AddWithValue("@Description", room.Description ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@Comment", room.Comment ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@Title", room.Title);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void DeleteRoom(int title)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Rooms WHERE Title = @Title";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Title", title);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public List<Room> FilterBySquare(int minSquare, int maxSquare)
        {
            List<Room> rooms = new List<Room>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Rooms WHERE Square >= @MinSquare AND Square <= @MaxSquare";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MinSquare", minSquare);
                command.Parameters.AddWithValue("@MaxSquare", maxSquare);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Room room = new Room();
                        room.Title = (string)reader["Title"];
                        room.Square = (int)reader["Square"];
                        room.Floor = (int)reader["Floor"];
                        room.Description = reader["Description"] != DBNull.Value ? (string)reader["Description"] : null;
                        room.Comment = reader["Comment"] != DBNull.Value ? (string)reader["Comment"] : null;

                        rooms.Add(room);
                    }
                }
            }

            return rooms;
        }

        public List<Room> FilterByFloor(int floor)
        {
            List<Room> rooms = new List<Room>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Rooms WHERE Floor = @Floor";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Floor", floor);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Room room = new Room();
                    room.Title = (string)reader["Title"];
                    room.Square = (int)reader["Square"];
                    room.Floor = (int)reader["Floor"];
                    room.Description = reader["Description"] != DBNull.Value ? (string)reader["Description"] : null;
                    room.Comment = reader["Comment"] != DBNull.Value ? (string)reader["Comment"] : null;

                    rooms.Add(room);
                }
            }

            return rooms;
        }
    }
}
