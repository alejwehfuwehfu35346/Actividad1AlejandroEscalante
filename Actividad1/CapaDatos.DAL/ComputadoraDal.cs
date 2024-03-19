using System;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class ComputadoraDal
    {
        private string connectionString;

        public ComputadoraDal(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Insertar(Computadora computadora)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Computadora (Nombre, Descripcion, Precio, FechaFabricacion) VALUES (@Nombre, @Descripcion, @Precio, @FechaFabricacion)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nombre", computadora.Nombre);
                command.Parameters.AddWithValue("@Descripcion", computadora.Descripcion);
                command.Parameters.AddWithValue("@Precio", computadora.Precio);
                command.Parameters.AddWithValue("@FechaFabricacion", computadora.FechaFabricacion);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public Computadora ObtenerPorId(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Computadora WHERE ID = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    Computadora computadora = new Computadora
                    {
                        ID = Convert.ToInt32(reader["ID"]),
                        Nombre = reader["Nombre"].ToString(),
                        Descripcion = reader["Descripcion"].ToString(),
                        Precio = Convert.ToDecimal(reader["Precio"]),
                        FechaFabricacion = Convert.ToDateTime(reader["FechaFabricacion"])
                    };
                    return computadora;
                }
                return null;
            }
        }

        public void Actualizar(Computadora computadora)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Computadora SET Nombre = @Nombre, Descripcion = @Descripcion, Precio = @Precio, FechaFabricacion = @FechaFabricacion WHERE ID = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nombre", computadora.Nombre);
                command.Parameters.AddWithValue("@Descripcion", computadora.Descripcion);
                command.Parameters.AddWithValue("@Precio", computadora.Precio);
                command.Parameters.AddWithValue("@FechaFabricacion", computadora.FechaFabricacion);
                command.Parameters.AddWithValue("@Id", computadora.ID);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void Eliminar(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Computadora WHERE ID = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}