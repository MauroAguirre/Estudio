/*
               File: CantidadDeProfesEnActividad
        Description: Cantidad De Profes En Actividad
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 4/12/2019 7:32:55.93
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
   public class cantidaddeprofesenactividad : GXProcedure
   {
      public cantidaddeprofesenactividad( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public cantidaddeprofesenactividad( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( short aP0_id ,
                           out short aP1_Cantidad )
      {
         this.AV10id = aP0_id;
         this.AV11Cantidad = 0 ;
         initialize();
         executePrivate();
         aP1_Cantidad=this.AV11Cantidad;
      }

      public short executeUdp( short aP0_id )
      {
         this.AV10id = aP0_id;
         this.AV11Cantidad = 0 ;
         initialize();
         executePrivate();
         aP1_Cantidad=this.AV11Cantidad;
         return AV11Cantidad ;
      }

      public void executeSubmit( short aP0_id ,
                                 out short aP1_Cantidad )
      {
         cantidaddeprofesenactividad objcantidaddeprofesenactividad;
         objcantidaddeprofesenactividad = new cantidaddeprofesenactividad();
         objcantidaddeprofesenactividad.AV10id = aP0_id;
         objcantidaddeprofesenactividad.AV11Cantidad = 0 ;
         objcantidaddeprofesenactividad.context.SetSubmitInitialConfig(context);
         objcantidaddeprofesenactividad.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objcantidaddeprofesenactividad);
         aP1_Cantidad=this.AV11Cantidad;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((cantidaddeprofesenactividad)stateInfo).executePrivate();
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
         AV11Cantidad = 0;
         /* Optimized group. */
         /* Using cursor P000J2 */
         pr_default.execute(0, new Object[] {AV10id});
         cV11Cantidad = P000J2_AV11Cantidad[0];
         pr_default.close(0);
         AV11Cantidad = (short)(AV11Cantidad+cV11Cantidad*1);
         /* End optimized group. */
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
         scmdbuf = "";
         P000J2_AV11Cantidad = new short[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.cantidaddeprofesenactividad__default(),
            new Object[][] {
                new Object[] {
               P000J2_AV11Cantidad
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV10id ;
      private short AV11Cantidad ;
      private short cV11Cantidad ;
      private String scmdbuf ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] P000J2_AV11Cantidad ;
      private short aP1_Cantidad ;
   }

   public class cantidaddeprofesenactividad__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP000J2 ;
          prmP000J2 = new Object[] {
          new Object[] {"@AV10id",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P000J2", "SELECT COUNT(*) FROM [Profesor] WITH (NOLOCK) WHERE [ActividadId] = @AV10id ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000J2,1,0,true,false )
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
             case 0 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 0 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
       }
    }

 }

}
