using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Form.DatabaseServices
{
    internal class DatabaseSerivces
    {
        private readonly string _codatabasennectionString;
        public DatabaseServices() {
            this._connectionString = "Server=localhost; port=5432; User Id = postgres; Password=dipesh#123; Database=dipesh_table";
        }
        public string load_register(Register register)
        {
            try
            {
                using (var connection = new NpgsqlConnection(_con+nectionString))
                {
                    connection.Open();
                    using (var cmd = new NpgsqlCommand(
                        @"INSERT INTO register (name, age, gender, province, district)
                    VALUES (@name, @age, @gender, @province, @district)", connection))
                    {
                        cmd.Parameters.AddWithValue("@name", register.Name ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@age", register.Age ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@gender", register.Gender ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@province", register.Province ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@district", register.District ?? (object)DBNull.Value);
                        cmd.ExecuteNonQuery();
                    }
                }
                return "Registration Successful.";
            }
            catch (NpgsqlException ex)
            {
                return $"Database error: {ex.Message}";
            }
            catch (Exception ex)
            {
                return $"An error occurred-: {ex.Message}";
            }
        }
    }
}
