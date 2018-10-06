using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo
{

    public class cliente
    {
        private static SqlConnection cn;
   
        public int id { get; set; }
	    public string nombre { get; set; }
        public DateTime ultimaOperacion { get; set; }
        public int estado { get; set; }


        public static void insertarCliente(cliente c)
        {
            //preparar el comando

           
            if (c.nombre != "")
            //&& c.estado == 1)
            {
                Conectar();     
                SqlCommand cmdComando = new SqlCommand();
                cmdComando.Connection = cn;//asignar conexion al commando a ejecutar              

                cmdComando.CommandText = "clientesInsert";//Sentencia a ejecutar              
                cmdComando.CommandType = CommandType.StoredProcedure;//Tipo de query 

            
                cmdComando.Parameters.AddWithValue("@id", c.id);
                cmdComando.Parameters.AddWithValue("@nombre", c.nombre);
                cmdComando.Parameters.AddWithValue("@estado", c.estado);
                cmdComando.Parameters.AddWithValue("@ultimaOperacion", c.ultimaOperacion);

                //ejecutar el comando
                cmdComando.ExecuteNonQuery();
                Cierro();

            }
            
        }

        private static void Conectar()
        {
            string cadenaConexion = @"Data Source=EQUIPO\SQLEXPRESS; Initial Catalog=primera; User ID=sa; Password=root";
            cn = new SqlConnection(cadenaConexion);
            cn.Open();
                       
        }

        private static void Cierro()
        {
            //cierra la conexión y limpia sus recursos asociados
            cn.Close();
            cn.Dispose();
        
        }




    }
}
