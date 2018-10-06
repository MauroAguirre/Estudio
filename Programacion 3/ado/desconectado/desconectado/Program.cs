using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desconectado
{
    class Program
    {
        private static SqlConnection cn;
        static void Main(string[] args)
        {
            conectar();
            insert();
            delete();
            update();            
            lectura();
            cierro();
            Console.ReadKey();


        }

        private static void lectura()
        {
           
            string cadena = "select id,nombre,saldo from clientes";
            SqlCommand cmd = new SqlCommand(cadena, cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);          
            DataSet ds = new DataSet();


            da.Fill(ds, "clientes");
            SqlCommand cmd2 = new SqlCommand
                ("Select id,nombre,saldo  from clientes", cn);
            da.SelectCommand = cmd2;
            da.Fill(ds, "otraTabla");

            foreach (DataRow dr in ds.Tables["clientes"].Rows)
            {
                if (dr.RowState.ToString() != "Deleted")
                {
                    Console.WriteLine(dr["id"] + " " + dr["nombre"] + " " + dr["saldo"] + " " + dr.RowState);
                }
            }

            
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("todos");
            Console.WriteLine("-------------------------------------");
            
            foreach (DataRow dr in ds.Tables["otraTabla"].Rows)
            {
                Console.WriteLine(dr["id"] + " " + dr["nombre"] + " " + dr["saldo"] + " " + dr.RowState);
            }

        }



        private static void insert()
        {
            string cadena = "select id,nombre,saldo from clientes";
            SqlCommand cmd = new SqlCommand(cadena, cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds, "clientes");
            

            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            da.InsertCommand = cb.GetInsertCommand();

                          
            DataRow nuevo = ds.Tables["clientes"].NewRow();
            nuevo["id"] = 1212;
            nuevo["nombre"] = "el profe";
            nuevo["saldo"] = 500;
            ds.Tables["clientes"].Rows.Add(nuevo);
            
            
            int n = da.Update(ds, "clientes");

        }


        private static void update()
        {
            string cadena = "select id,nombre,saldo from clientes";
            SqlCommand cmd = new SqlCommand(cadena, cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.SelectCommand = new SqlCommand(cadena, cn);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);

            DataSet ds = new DataSet();
            da.Fill(ds, "clientes");

            DataRow modificar = ds.Tables["clientes"].Rows[1];
            modificar["nombre"] = "otro profe";

            cb.GetUpdateCommand();
            
            int n = da.Update(ds, "clientes");

        }

        
        private static void delete()
        {
            string cadena = "select id,nombre,saldo from clientes";
            SqlCommand cmd = new SqlCommand(cadena, cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.SelectCommand = new SqlCommand(cadena, cn);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);

            DataSet ds = new DataSet();
            da.Fill(ds, "clientes");

            ds.Tables["clientes"].Rows[0].Delete();
            cb.GetDeleteCommand();
            
            int n =  da.Update(ds, "clientes");

        }


    

        public static void conectar()
        {
            string cadenaConexion = @"Data Source=E01; Initial Catalog=popo; Integrated Security = true";
            cn = new SqlConnection(cadenaConexion);
            cn.Open();
            Console.WriteLine(cn.State);
        }


        public static void cierro()
        {
            cn.Close();
            
        }


    }
}
