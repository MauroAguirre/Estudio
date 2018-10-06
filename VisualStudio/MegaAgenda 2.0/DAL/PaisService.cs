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
    public class PaisService
    {
        public static readonly String cadenaConexion = @"Data Source=localhost; Initial Catalog=MegaAgenda; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public void Mostrar()
        {
            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                connection.Open();
                const String query = "SELECT nombre from Pais";
                SqlCommand comando = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                DataSet dataset = new DataSet();
                adapter.SelectCommand = comando;
                adapter.Fill(dataset, "paises");
                int posicion = 1;
                foreach (DataRow row in dataset.Tables["paises"].Rows)
                {
                    Console.WriteLine(posicion + " - " + row["nombre"] +"\n");
                    posicion++;
                }
            }
        }
        public String Elegir_pais(int cual)
        {
            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                connection.Open();
                const String query = "SELECT nombre from Pais";
                SqlCommand comando = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                DataSet dataset = new DataSet();
                adapter.SelectCommand = comando;
                adapter.Fill(dataset, "paises");
                return dataset.Tables["paises"].Rows[cual -1]["nombre"].ToString();
            }
        }
    }
}
