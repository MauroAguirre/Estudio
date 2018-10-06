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
    public class AgendaService
    {
        
        public static readonly String cadenaConexion = @"Data Source=localhost; Initial Catalog=MegaAgenda; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public void Guardar(Agenda agenda)
        {
            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                const string format = "yyyy-MM-dd HH:mm:ss";
                const String query = "INSERT INTO Agenda (nombre, fecha_creacion) VALUES (@nombre, @fecha_creacion)";
                connection.Open();
                SqlCommand comando = new SqlCommand(query, connection);
                comando.Parameters.AddWithValue("@nombre", agenda.Nombre);
                //comando.Parameters.AddWithValue("@fecha_creacion", agenda.FechaCreacion.ToString(format));
                comando.Parameters.AddWithValue("@fecha_creacion", agenda.FechaCreacion);
                int filasAfectas = comando.ExecuteNonQuery();
                Console.WriteLine("Filas afectas"+ filasAfectas+ " en el insert");
            }
        }
        public void Mostrar()
        {
            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                connection.Open();
                const String query = "SELECT nombre, fecha_creacion FROM Agenda";
                SqlCommand comando = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                DataSet dataset = new DataSet();
                adapter.SelectCommand = comando;
                adapter.Fill(dataset, "agendas");
                foreach (DataRow row in dataset.Tables["agendas"].Rows)
                {
                    Console.WriteLine(row["nombre"] + " - " + row["fecha_creacion"]+"\n");
                }
            }
        }
        public void Borrar(string nombre)
        {
            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                /*
                connection.Open();
                const String query = "DELETE agenda WHERE nombre = @wopa";
                SqlCommand comando = new SqlCommand(query, connection);
                comando.Parameters.AddWithValue("@nombre", "wopa");
                */
                //SqlDataAdapter adapter = new SqlDataAdapter(comando);
                //adapter.DeleteCommand = comando;

                connection.Open();
                const String query = "SELECT nombre, fecha_creacion FROM Agenda";
                DataSet dataSet = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand(query, connection);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                adapter.Fill(dataSet,"agendas");
                foreach (DataRow row in dataSet.Tables["agendas"].Rows)
                {
                    if (row["nombre"].ToString() == nombre)
                    {
                        row.Delete();
                    }          
                }
                adapter.UpdateCommand = builder.GetUpdateCommand();
                adapter.Update(dataSet,"agendas");

                //SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adapter);
                //adapter.DeleteCommand = sqlCommandBuilder.GetDeleteCommand();
            }
        }
        public void Modificar(string lugar,string nuevo)
        {
            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                connection.Open();
                const String query = "SELECT nombre, fecha_creacion FROM Agenda";
                DataSet dataSet = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand(query, connection);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                adapter.Fill(dataSet, "agendas");
                foreach (DataRow row in dataSet.Tables["agendas"].Rows)
                {
                    if (row["nombre"].ToString() == lugar)
                    {
                        row["nombre"] = nuevo; 
                    }
                }
                adapter.UpdateCommand = builder.GetUpdateCommand();
                adapter.Update(dataSet, "agendas");
            }
        }
    }
}
