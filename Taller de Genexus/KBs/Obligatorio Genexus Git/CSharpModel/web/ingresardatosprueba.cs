/*
               File: IngresarDatosPrueba
        Description: Ingresar Datos Prueba
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 4/12/2019 20:38:33.2
       Program type: Callable routine
          Main DBMS: SQL Server
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using GeneXus.Cryptography;
using System.Data;
using System.Data.SqlClient;
using GeneXus.Data;
using com.genexus;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using System.Runtime.Remoting;
using GeneXus.WebControls;
using GeneXus.Http;
using GeneXus.Procedure;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Threading;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class ingresardatosprueba : GXProcedure
   {
      public ingresardatosprueba( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public ingresardatosprueba( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( )
      {
         initialize();
         executePrivate();
      }

      public void executeSubmit( )
      {
         ingresardatosprueba objingresardatosprueba;
         objingresardatosprueba = new ingresardatosprueba();
         objingresardatosprueba.context.SetSubmitInitialConfig(context);
         objingresardatosprueba.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objingresardatosprueba);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((ingresardatosprueba)stateInfo).executePrivate();
         }
         catch ( Exception e )
         {
            GXUtil.SaveToEventLog( "Design", e);
            throw e ;
         }
      }

      void executePrivate( )
      {
         /* GeneXus formulas */
         /* Output device settings */
         AV12Carnet = new SdtCarnet(context);
         AV12Carnet.gxTpr_Carnetid = 1;
         AV12Carnet.gxTpr_Carnetfechaingreso = Gx_date;
         AV12Carnet.Save();
         AV9Socio = new SdtSocio(context);
         AV9Socio.gxTpr_Socioid = 1;
         AV9Socio.gxTpr_Carnetid = 1;
         AV9Socio.gxTpr_Sociodireccion = "Piedras 395 barrio rivera";
         AV9Socio.gxTpr_Sociosexo = "Hombre";
         AV9Socio.gxTpr_Socioedad = 24;
         AV9Socio.gxTpr_Sociotipocuota = "V";
         AV9Socio.gxTpr_Socioreconocido = true;
         AV9Socio.Save();
         AV12Carnet = new SdtCarnet(context);
         AV12Carnet.gxTpr_Carnetid = 2;
         AV12Carnet.gxTpr_Carnetfechaingreso = DateTimeUtil.AddYr( Gx_date, -11);
         AV12Carnet.Save();
         AV9Socio = new SdtSocio(context);
         AV9Socio.gxTpr_Socioid = 2;
         AV9Socio.gxTpr_Carnetid = 2;
         AV9Socio.gxTpr_Sociodireccion = "18 de julio y noseque";
         AV9Socio.gxTpr_Sociosexo = "Mujer";
         AV9Socio.gxTpr_Socioedad = 28;
         AV9Socio.gxTpr_Sociotipocuota = "P";
         AV9Socio.gxTpr_Socioreconocido = false;
         AV9Socio.Save();
         AV12Carnet = new SdtCarnet(context);
         AV12Carnet.gxTpr_Carnetid = 3;
         AV12Carnet.gxTpr_Carnetfechaingreso = DateTimeUtil.AddYr( Gx_date, -12);
         AV12Carnet.Save();
         AV9Socio = new SdtSocio(context);
         AV9Socio.gxTpr_Socioid = 3;
         AV9Socio.gxTpr_Carnetid = 3;
         AV9Socio.gxTpr_Sociodireccion = "Laguna del lagunoso 33";
         AV9Socio.gxTpr_Sociosexo = "Otro";
         AV9Socio.gxTpr_Socioedad = 19;
         AV9Socio.gxTpr_Sociotipocuota = "P";
         AV9Socio.gxTpr_Socioreconocido = false;
         AV9Socio.Save();
         AV12Carnet = new SdtCarnet(context);
         AV12Carnet.gxTpr_Carnetid = 4;
         AV12Carnet.gxTpr_Carnetfechaingreso = Gx_date;
         AV12Carnet.Save();
         AV9Socio = new SdtSocio(context);
         AV9Socio.gxTpr_Socioid = 4;
         AV9Socio.gxTpr_Carnetid = 4;
         AV9Socio.gxTpr_Sociodireccion = "La luna";
         AV9Socio.gxTpr_Sociosexo = "Otro";
         AV9Socio.gxTpr_Socioedad = 78;
         AV9Socio.gxTpr_Sociotipocuota = "V";
         AV9Socio.gxTpr_Socioreconocido = true;
         AV9Socio.Save();
         AV12Carnet = new SdtCarnet(context);
         AV12Carnet.gxTpr_Carnetid = 5;
         AV12Carnet.gxTpr_Carnetfechaingreso = Gx_date;
         AV12Carnet.Save();
         AV9Socio = new SdtSocio(context);
         AV9Socio.gxTpr_Socioid = 5;
         AV9Socio.gxTpr_Carnetid = 5;
         AV9Socio.gxTpr_Sociodireccion = "Marte";
         AV9Socio.gxTpr_Sociosexo = "Otro";
         AV9Socio.gxTpr_Socioedad = 98;
         AV9Socio.gxTpr_Sociotipocuota = "P";
         AV9Socio.gxTpr_Socioreconocido = false;
         AV9Socio.Save();
         AV10Actividad = new SdtActividad(context);
         AV10Actividad.gxTpr_Actividadid = 1;
         AV10Actividad.gxTpr_Actividaddescripcion = "Tenis";
         AV10Actividad.Save();
         AV10Actividad = new SdtActividad(context);
         AV10Actividad.gxTpr_Actividadid = 2;
         AV10Actividad.gxTpr_Actividaddescripcion = "Futbol";
         AV10Actividad.Save();
         AV10Actividad = new SdtActividad(context);
         AV10Actividad.gxTpr_Actividadid = 3;
         AV10Actividad.gxTpr_Actividaddescripcion = "Natacion";
         AV10Actividad.Save();
         AV10Actividad = new SdtActividad(context);
         AV10Actividad.gxTpr_Actividadid = 4;
         AV10Actividad.gxTpr_Actividaddescripcion = "Volley";
         AV10Actividad.Save();
         AV10Actividad = new SdtActividad(context);
         AV10Actividad.gxTpr_Actividadid = 5;
         AV10Actividad.gxTpr_Actividaddescripcion = "Gimnasia";
         AV10Actividad.Save();
         AV11Profesor = new SdtProfesor(context);
         AV11Profesor.gxTpr_Profesorid = 1;
         AV11Profesor.gxTpr_Profesornombre = "Pedro";
         AV11Profesor.gxTpr_Profesordireccion = "un lugar magico";
         AV11Profesor.gxTpr_Actividadid = 1;
         AV11Profesor.Save();
         AV11Profesor = new SdtProfesor(context);
         AV11Profesor.gxTpr_Profesorid = 2;
         AV11Profesor.gxTpr_Profesornombre = "Raul";
         AV11Profesor.gxTpr_Profesordireccion = "un lugar magico";
         AV11Profesor.gxTpr_Actividadid = 1;
         AV11Profesor.Save();
         AV11Profesor = new SdtProfesor(context);
         AV11Profesor.gxTpr_Profesorid = 3;
         AV11Profesor.gxTpr_Profesornombre = "Lautaro";
         AV11Profesor.gxTpr_Profesordireccion = "un lugar magico";
         AV11Profesor.gxTpr_Actividadid = 1;
         AV11Profesor.Save();
         AV11Profesor = new SdtProfesor(context);
         AV11Profesor.gxTpr_Profesorid = 4;
         AV11Profesor.gxTpr_Profesornombre = "Marta";
         AV11Profesor.gxTpr_Profesordireccion = "un lugar magico";
         AV11Profesor.gxTpr_Actividadid = 2;
         AV11Profesor.Save();
         AV11Profesor = new SdtProfesor(context);
         AV11Profesor.gxTpr_Profesorid = 5;
         AV11Profesor.gxTpr_Profesornombre = "Sandra";
         AV11Profesor.gxTpr_Profesordireccion = "un lugar magico";
         AV11Profesor.gxTpr_Actividadid = 2;
         AV11Profesor.Save();
         AV11Profesor = new SdtProfesor(context);
         AV11Profesor.gxTpr_Profesorid = 1;
         AV11Profesor.gxTpr_Profesornombre = "Pedro";
         AV11Profesor.gxTpr_Profesordireccion = "un lugar magico";
         AV11Profesor.gxTpr_Actividadid = 1;
         AV11Profesor.Save();
         AV11Profesor = new SdtProfesor(context);
         AV11Profesor.gxTpr_Profesorid = 6;
         AV11Profesor.gxTpr_Profesornombre = "Maicol";
         AV11Profesor.gxTpr_Profesordireccion = "un lugar magico";
         AV11Profesor.gxTpr_Actividadid = 3;
         AV11Profesor.Save();
         AV11Profesor = new SdtProfesor(context);
         AV11Profesor.gxTpr_Profesorid = 7;
         AV11Profesor.gxTpr_Profesornombre = "Roko";
         AV11Profesor.gxTpr_Profesordireccion = "un lugar magico";
         AV11Profesor.gxTpr_Actividadid = 4;
         AV11Profesor.Save();
         AV11Profesor = new SdtProfesor(context);
         AV11Profesor.gxTpr_Profesorid = 8;
         AV11Profesor.gxTpr_Profesornombre = "Bety";
         AV11Profesor.gxTpr_Profesordireccion = "un lugar magico";
         AV11Profesor.gxTpr_Actividadid = 5;
         AV11Profesor.Save();
         context.CommitDataStores("ingresardatosprueba",pr_default);
         this.cleanup();
      }

      public override void cleanup( )
      {
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
         exitApplication();
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         AV12Carnet = new SdtCarnet(context);
         Gx_date = DateTime.MinValue;
         AV9Socio = new SdtSocio(context);
         AV10Actividad = new SdtActividad(context);
         AV11Profesor = new SdtProfesor(context);
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.ingresardatosprueba__default(),
            new Object[][] {
            }
         );
         Gx_date = DateTimeUtil.Today( context);
         /* GeneXus formulas. */
         Gx_date = DateTimeUtil.Today( context);
         context.Gx_err = 0;
      }

      private DateTime Gx_date ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private SdtSocio AV9Socio ;
      private SdtActividad AV10Actividad ;
      private SdtProfesor AV11Profesor ;
      private SdtCarnet AV12Carnet ;
   }

   public class ingresardatosprueba__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          def= new CursorDef[] {
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
       }
    }

 }

}
