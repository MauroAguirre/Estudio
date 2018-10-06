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
        public void Guardar(Contacto contacto,String nombre_agenda)
        {
            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                const string format = "yyyy-MM-dd HH:mm:ss";
                const String query = "INSERT INTO Contacto (nombre, fecha_nacimiento, mail, pais, nombre_Agenda) VALUES (@nombre, @fecha_nacimiento, @mail, @pais, @nombre_agenda)";
                connection.Open();
                SqlCommand comando = new SqlCommand(query, connection);
                comando.Parameters.AddWithValue("@nombre", contacto.Nombre);
                comando.Parameters.AddWithValue("@fecha_nacimiento", contacto.FechaNacimiento);
                comando.Parameters.AddWithValue("@mail", contacto.Mail);
                comando.Parameters.AddWithValue("@pais", contacto.Pais);
                comando.Parameters.AddWithValue("@nombre_agenda", nombre_agenda);
                int filasAfectas = comando.ExecuteNonQuery();
                Console.WriteLine("Filas afectas" + filasAfectas + " en el insert");
            }
        }
        public void Mostrar()
        {
            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                connection.Open();
                const String query = "SELECT nombre, fecha_nacimiento, mail, pais,id,nombre_agenda from Contacto";
                SqlCommand comando = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(comando);

                DataSet dataset = new DataSet();
                adapter.SelectCommand = comando;
                adapter.Fill(dataset, "contactos");
                foreach (DataRow row in dataset.Tables["contactos"].Rows)
                {
                    Console.WriteLine(row["id"]+" - "+row["nombre"] + " - " + row["fecha_nacimiento"] + " - " + row["mail"] +" "+row["pais"]+" - "+ row["nombre_agenda"] +"\n");
                }
            }
        }
        public void Borrar(int cual)
        {
            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                connection.Open();
                const String query = "SELECT nombre, fecha_nacimiento, mail, pais FROM Contacto";
                DataSet dataSet = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand(query, connection);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                adapter.Fill(dataSet, "contactos");
                int posicion = 1; 
                foreach (DataRow row in dataSet.Tables["contactos"].Rows)
                {
                    if (posicion == cual)
                    {
                        row.Delete();
                        break;
                    }
                    posicion++;
                }
                adapter.UpdateCommand = builder.GetUpdateCommand();
                adapter.Update(dataSet, "contactos");
            }
        }
        public void Modificar_mail(int cual,String mail)
        {
            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                connection.Open();
                const String query = "SELECT nombre, fecha_nacimiento, mail, pais, nombre_agenda, id FROM Contacto";
                DataSet dataSet = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand(query, connection);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                adapter.Fill(dataSet, "contactos");
                dataSet.Tables["contactos"].Rows[cual - 1]["mail"] = mail;
                adapter.UpdateCommand = builder.GetUpdateCommand();
                adapter.Update(dataSet, "contactos");
            }
        }
        public void Buscar_contacto_por_mail(String mail)
        {
            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                /*connection.Open();
                const String query = "SELECT nombre, fecha_nacimiento, mail, pais FROM Contacto";
                DataSet dataSet = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand(query, connection);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                adapter.Fill(dataSet, "contactos");
                foreach (DataRow row in dataSet.Tables["contactos"].Rows)
                {
                    if (row["mail"].ToString() == mail)
                    {
                        Console.WriteLine(row["nombre"] + " - " + row["fecha_nacimiento"] + " - " + row["mail"] + " " + row["pais"] + "\n");
                        break;
                    }
                }
                */
                connection.Open();
                String query = "SELECT nombre, fecha_nacimiento, mail, pais FROM Contacto Where mail ="+mail;
                DataSet dataSet = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand(query, connection);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                adapter.Fill(dataSet, "contacto");
                DataRow row = dataSet.Tables["contacto"].Rows[0];
                Console.WriteLine(row["nombre"] + " - " + row["fecha_nacimiento"] + " - " + row["mail"] + " " + row["pais"] + "\n");
            }
        }
    }
}
