/*
               File: CantidadSexo
        Description: Cantidad Sexo
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 4/12/2019 17:17:3.40
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
   public class cantidadsexo : GXProcedure
   {
      public cantidadsexo( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public cantidadsexo( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( short aP0_id ,
                           ref String aP1_sexo ,
                           out short aP2_Cantidad )
      {
         this.AV8id = aP0_id;
         this.AV9sexo = aP1_sexo;
         this.AV10Cantidad = 0 ;
         initialize();
         executePrivate();
         aP1_sexo=this.AV9sexo;
         aP2_Cantidad=this.AV10Cantidad;
      }

      public short executeUdp( short aP0_id ,
                               ref String aP1_sexo )
      {
         this.AV8id = aP0_id;
         this.AV9sexo = aP1_sexo;
         this.AV10Cantidad = 0 ;
         initialize();
         executePrivate();
         aP1_sexo=this.AV9sexo;
         aP2_Cantidad=this.AV10Cantidad;
         return AV10Cantidad ;
      }

      public void executeSubmit( short aP0_id ,
                                 ref String aP1_sexo ,
                                 out short aP2_Cantidad )
      {
         cantidadsexo objcantidadsexo;
         objcantidadsexo = new cantidadsexo();
         objcantidadsexo.AV8id = aP0_id;
         objcantidadsexo.AV9sexo = aP1_sexo;
         objcantidadsexo.AV10Cantidad = 0 ;
         objcantidadsexo.context.SetSubmitInitialConfig(context);
         objcantidadsexo.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objcantidadsexo);
         aP1_sexo=this.AV9sexo;
         aP2_Cantidad=this.AV10Cantidad;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((cantidadsexo)stateInfo).executePrivate();
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
         AV10Cantidad = 0;
         /* Using cursor P000S2 */
         pr_default.execute(0, new Object[] {AV8id});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A3ClaseId = P000S2_A3ClaseId[0];
            /* Optimized group. */
            /* Using cursor P000S3 */
            pr_default.execute(1, new Object[] {A3ClaseId, AV9sexo});
            cV10Cantidad = P000S3_AV10Cantidad[0];
            pr_default.close(1);
            AV10Cantidad = (short)(AV10Cantidad+cV10Cantidad*1);
            /* End optimized group. */
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(0);
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
         P000S2_A3ClaseId = new short[1] ;
         P000S3_AV10Cantidad = new short[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.cantidadsexo__default(),
            new Object[][] {
                new Object[] {
               P000S2_A3ClaseId
               }
               , new Object[] {
               P000S3_AV10Cantidad
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV8id ;
      private short AV10Cantidad ;
      private short A3ClaseId ;
      private short cV10Cantidad ;
      private String AV9sexo ;
      private String scmdbuf ;
      private IGxDataStore dsDefault ;
      private String aP1_sexo ;
      private IDataStoreProvider pr_default ;
      private short[] P000S2_A3ClaseId ;
      private short[] P000S3_AV10Cantidad ;
      private short aP2_Cantidad ;
   }

   public class cantidadsexo__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP000S2 ;
          prmP000S2 = new Object[] {
          new Object[] {"@AV8id",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmP000S3 ;
          prmP000S3 = new Object[] {
          new Object[] {"@ClaseId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV9sexo",SqlDbType.Char,20,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P000S2", "SELECT [ClaseId] FROM [Clase] WITH (NOLOCK) WHERE [ClaseId] = @AV8id ORDER BY [ClaseId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000S2,1,0,true,true )
             ,new CursorDef("P000S3", "SELECT COUNT(*) FROM ([ClaseSocios] T1 WITH (NOLOCK) INNER JOIN [Socio] T2 WITH (NOLOCK) ON T2.[SocioId] = T1.[SocioId]) WHERE (T1.[ClaseId] = @ClaseId) AND (T2.[SocioSexo] = @AV9sexo) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000S3,1,0,true,false )
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
             case 1 :
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
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                return;
       }
    }

 }

}
