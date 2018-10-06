using System;
using System.Data;
using System.Data.SqlClient ;

// creacion de tabla
//USE [primera]
//GO

///****** Object:  Table [dbo].[Clientes]    Script Date: 04/04/2016 18:27:57 ******/
//SET ANSI_NULLS ON
//GO

//SET QUOTED_IDENTIFIER ON
//GO

//CREATE TABLE [dbo].[Clientes](
//    [id] [int] NULL,
//    [nombre] [nchar](50) NULL,
//    [ultimaOperacion] [date] NULL,
//    [estado] [numeric](18, 0) NULL
//) ON [PRIMARY]

//GO




//Creacion del proceso 
//USE [primera]
//GO

///****** Object:  StoredProcedure [dbo].[clientesInsert]    Script Date: 04/04/2016 18:28:56 ******/
//SET ANSI_NULLS ON
//GO

//SET QUOTED_IDENTIFIER ON
//GO

//-- Batch submitted through debugger: SQLQuery2.sql|15|0|C:\Users\Usuario\AppData\Local\Temp\~vsAEB0.sql
//-- =============================================
//-- Author:		<Author,,Name>
//-- Create date: <Create Date,,>
//-- Description:	<Description,,>
//-- =============================================
//CREATE PROCEDURE [dbo].[clientesInsert] 
//    @id int,
//    @nombre varchar(50),
//    @ultimaOperacion date,
//    @estado int
//AS
//BEGIN
//     INSERT INTO clientes (Id, nombre, ultimaOperacion, estado) 
//            VALUES (@id, @nombre, @ultimaOperacion, @estado)

//END

//GO




namespace PrimeraPruebaADO
{
    class Program
    {
        private static SqlConnection cn;
        static void Main(string[] args)
        {
            Conectar();
            Insertar();
            Insertar1();
            Lectura();
            Consulta();
            Cierro();
            PararPantalla();
        }
        private static void Conectar()
        {
            string cadenaConexion = @"Data Source=EQUIPO\SQLEXPRESS; Initial Catalog=primera; User ID=sa; Password=root";
            cn = new SqlConnection(cadenaConexion);
            cn.Open();
            Console.WriteLine(cn.State);           
        }
        private static void Cierro()
        {        
            //cierra la conexión y limpia sus recursos asociados
            cn.Close();
            cn.Dispose();
            Console.WriteLine(cn.State);            
        }
        private static void PararPantalla()
        {
            Console.Write("Presione tecla para salir");
            Console.ReadKey();
        }




        private static void Lectura()
        {

            SqlCommand miComando;
            SqlDataReader miReader;
            miComando = cn.CreateCommand();
            miComando.CommandText = "SELECT * FROM clientes ";
            miReader = miComando.ExecuteReader();

            if (miReader.HasRows)
            { 
                
                    while (miReader.Read())
                    {
                            
             //           if (miReader.GetSqlInt32(0) == 2)
             //          {
                            Console.WriteLine("{0},{1},{2}", miReader.GetValue(0), miReader.GetValue(1), miReader.GetValue(2));
                          
              //          }
                    }
                
            }
            miReader.Close();
            
        }

        





        private static void Insertar()
        {
            //preparar el comando
            string cadenaCmd = "INSERT INTO clientes (Id, nombre, ultimaOperacion, estado) VALUES (@id, @nombre, @ultimaOperacion, @estado);";
            SqlCommand cmdComando = new SqlCommand(cadenaCmd, cn);
            cmdComando.Parameters.AddWithValue("@id", 1);
            cmdComando.Parameters.AddWithValue("@nombre", "Tito");
            cmdComando.Parameters.AddWithValue("@estado", 1);
            cmdComando.Parameters.AddWithValue("@ultimaOperacion", DateTime.Now);
            
            //ejecutar el comando
            int afectadas = cmdComando.ExecuteNonQuery();
            
        }



        private static void Insertar1()
        {
            //preparar el comando
            SqlCommand cmdComando = new SqlCommand();
            cmdComando.Connection = cn;//asignar conexion al commando a ejecutar              
         
            cmdComando.CommandText = "clientesInsert";//Sentencia a ejecutar              
            cmdComando.CommandType = CommandType.StoredProcedure;//Tipo de query 


            cmdComando.Parameters.AddWithValue("@id", 1);
            cmdComando.Parameters.AddWithValue("@nombre", "Tito");
            cmdComando.Parameters.AddWithValue("@estado", 1);
            cmdComando.Parameters.AddWithValue("@ultimaOperacion", DateTime.Now);

            //ejecutar el comando
            cmdComando.ExecuteNonQuery();

        }


        private static void Consulta()
        {
            //preparar el comando
            string estado;
            Console.WriteLine("INGRESE SU ESTADO: ");
            estado = Console.ReadLine();
            string cadenaCmd = "select count(*) from clientes where estado < @estado";
            SqlCommand cmdComando = new SqlCommand(cadenaCmd, cn);
            cmdComando.Parameters.AddWithValue("@estado", estado);

            //ejecutar el comando                   
             int n;
             n = Convert.ToInt32(cmdComando.ExecuteScalar());
             Console.Write("cantidad: " + n);


        }



        
        
    }
}
