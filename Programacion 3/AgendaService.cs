using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MegaAgenda.common;

namespace MegaAgenda.dal
{
    public class AgendaService
    {
        public static readonly String cadenaConexion = @"Data Source=localhost; Initial Catalog=MegaAgenda; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public void guardar(Agenda agenda)
        {
            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                const string format = "yyyy-MM-dd HH:mm:ss";
                const String query = "INSERT INTO Agendas (nombre, fecha_creacion) VALUES (@nombre, @fecha_creacion)";
                connection.Open();
                SqlCommand comando = new SqlCommand(query, connection);
                comando.Parameters.AddWithValue("@nombre", agenda.Nombre);
                comando.Parameters.AddWithValue("@fecha_creacion", agenda.FechaCreacion.ToString(format));
                int filasAfectas = comando.ExecuteNonQuery();
                Console.WriteLine($"Filas afectas {filasAfectas} en el insert");
            }
        }
    }
}
