using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Data.Entity.Core.Objects;

namespace PracticoCF_2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new PersonaContext())
            {
                //Al usar CodeFirst necesitamos asegurarnos de que el modelo
                //fue construido antes de abrir la conexion
                db.Database.Initialize(force: false);
                //Creamos un comando para ejecutar el store procedure
                var cmd = db.Database.Connection.CreateCommand();
                cmd.CommandText = "[dbo].[GetAllPersonas]";
                try
                {
                    db.Database.Connection.Open();//abrimos la conexion
     
                    //ejecutamos el sp
                    var reader = cmd.ExecuteReader();
                    //leemos las personas
                    var personas = ((IObjectContextAdapter)db).ObjectContext.Translate<Persona>(reader, "Personas", MergeOption.AppendOnly);
                    Console.WriteLine("Las personas ingresadas son:");
                    foreach (var item in personas)
                    {
                        Console.WriteLine(item.Nombre + " Documento " + item.Documento);
                    }
                    reader.Close();

                    //Agregamos una personaaaaaaaaaaaaaaaaaaaaaaaaaaaa!
                    Console.WriteLine("Ingresame un nombre");
                    var nom = Console.ReadLine();
                    Console.WriteLine("Ingresame un documento");
                    var doc = Console.ReadLine();
                    var n = new SqlParameter("@nom", nom);
                    var d = new SqlParameter("@doc", doc);
                    SqlParameter[] parame = { d, n };
                    db.Database.ExecuteSqlCommand("AddPersona @doc,@nom", parame);
                    Console.WriteLine("\n");

                    //Actualizamos una personaaaaaaaaaaaaaaaaaaaaaaaaaaaa!
                    Console.WriteLine("Ingresame un nombre para actualizar");
                    nom = Console.ReadLine();
                    Console.WriteLine("Ingresame un documento al cual vamos a actualizar");
                    doc = Console.ReadLine();
                    n = new SqlParameter("@nom", nom);
                    d = new SqlParameter("@doc", doc);
                    SqlParameter[] parame2 = { d, n };
                    db.Database.ExecuteSqlCommand("ActuPersona @doc,@nom", parame2);
                    Console.WriteLine("\n");

                    //Ahora vamos a usar un store procedure para borrar
                    Console.WriteLine("Ingrese el documento a borrar");
                    string documento = Console.ReadLine();

                    var p = new SqlParameter("@doc", documento);
                    db.Database.ExecuteSqlCommand("DeletePersona @doc", p);
                    //si hubiese mas parametros:
                    //db.Database.ExecuteSqlCommand("exec procedimiento @Nom1,@Nom2,Varp1,Varp2);
                    //si queremos asegurarnos de que el motor ejecture el sp puede incluir el comando exec:
                    //db.Database.ExecuteSqlCommand("exec DeletePersona @doc", p);

                }finally{
                    db.Database.Connection.Close();//cerramos la conexion
                }
                Console.ReadKey();
            }
        }
    }
}
