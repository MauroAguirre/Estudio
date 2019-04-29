/*
               File: UltimoIdProfesor
        Description: Ultimo Id Profesor
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 4/12/2019 7:32:58.81
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
   public class ultimoidprofesor : GXProcedure
   {
      public ultimoidprofesor( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public ultimoidprofesor( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( out short aP0_Id )
      {
         this.AV8Id = 0 ;
         initialize();
         executePrivate();
         aP0_Id=this.AV8Id;
      }

      public short executeUdp( )
      {
         this.AV8Id = 0 ;
         initialize();
         executePrivate();
         aP0_Id=this.AV8Id;
         return AV8Id ;
      }

      public void executeSubmit( out short aP0_Id )
      {
         ultimoidprofesor objultimoidprofesor;
         objultimoidprofesor = new ultimoidprofesor();
         objultimoidprofesor.AV8Id = 0 ;
         objultimoidprofesor.context.SetSubmitInitialConfig(context);
         objultimoidprofesor.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objultimoidprofesor);
         aP0_Id=this.AV8Id;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((ultimoidprofesor)stateInfo).executePrivate();
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
         AV8Id = 1;
         /* Using cursor P000H2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A2ProfesorId = P000H2_A2ProfesorId[0];
            AV8Id = (short)(A2ProfesorId+1);
            /* Exit For each command. Update data (if necessary), close cursors & exit. */
            if (true) break;
            pr_default.readNext(0);
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
         P000H2_A2ProfesorId = new short[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.ultimoidprofesor__default(),
            new Object[][] {
                new Object[] {
               P000H2_A2ProfesorId
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV8Id ;
      private short A2ProfesorId ;
      private String scmdbuf ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] P000H2_A2ProfesorId ;
      private short aP0_Id ;
   }

   public class ultimoidprofesor__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP000H2 ;
          prmP000H2 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("P000H2", "SELECT TOP 1 [ProfesorId] FROM [Profesor] WITH (NOLOCK) ORDER BY [ProfesorId] DESC ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000H2,1,0,false,true )
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
       }
    }

 }

}
