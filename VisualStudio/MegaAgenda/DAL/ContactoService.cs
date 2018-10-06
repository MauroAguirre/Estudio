using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class ContactoService
    {
        public static readonly String cadenaConexion = @"Data Source=localhost; Initial Catalog=MegaAgenda; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public void Guardar(Contacto contacto,string nombre_agenda)
        {
            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                const string format = "yyyy-MM-dd HH:mm:ss";
                const String query = "INSERT INTO Contacto (nombre, fecha_nacimiento, mail, agenda_nombre) VALUES (@nombre, @fecha_nacimiento, @mail, @agenda_nombre)";
                connection.Open();
                SqlCommand comando = new SqlCommand(query, connection);
                comando.Parameters.AddWithValue("@nombre", contacto.Nombre);
                comando.Parameters.AddWithValue("@fecha_nacimiento", contacto.FechaNacimiento.ToString(format));
                comando.Parameters.AddWithValue("@mail", contacto.Mail);
                comando.Parameters.AddWithValue("@agenda_nombre", nombre_agenda);
                int filasAfectas = comando.ExecuteNonQuery();
                Console.WriteLine("Filas afectas" + filasAfectas + " en el insert");
            }
        }
        public void Mostrar(string nombre_agenda)
        {
            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                connection.Open();
                const String query = "SELECT nombre, fecha_nacimiento, mail, agenda_nombre from Contacto";
                SqlCommand comando = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                DataSet dataset = new DataSet();
                adapter.SelectCommand = comando;
                adapter.Fill(dataset, "contactos");
                foreach (DataRow row in dataset.Tables["contactos"].Rows)
                {
                    if (row["agenda_nombre"].ToString() == nombre_agenda)
                    {
                        Console.WriteLine(row["nombre"] + " - " + row["fecha_nacimiento"] + " - " + row["mail"]+"\n");
                    }
                }
            }
        }
    }
}
