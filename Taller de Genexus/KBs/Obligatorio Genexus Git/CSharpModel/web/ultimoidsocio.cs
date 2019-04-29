/*
               File: UltimoIdSocio
        Description: Ultimo Id Socio
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 4/12/2019 6:13:32.49
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
   public class ultimoidsocio : GXProcedure
   {
      public ultimoidsocio( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public ultimoidsocio( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( out short aP0_id )
      {
         this.AV8id = 0 ;
         initialize();
         executePrivate();
         aP0_id=this.AV8id;
      }

      public short executeUdp( )
      {
         this.AV8id = 0 ;
         initialize();
         executePrivate();
         aP0_id=this.AV8id;
         return AV8id ;
      }

      public void executeSubmit( out short aP0_id )
      {
         ultimoidsocio objultimoidsocio;
         objultimoidsocio = new ultimoidsocio();
         objultimoidsocio.AV8id = 0 ;
         objultimoidsocio.context.SetSubmitInitialConfig(context);
         objultimoidsocio.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objultimoidsocio);
         aP0_id=this.AV8id;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((ultimoidsocio)stateInfo).executePrivate();
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
         AV8id = 1;
         /* Using cursor P000E2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A5SocioId = P000E2_A5SocioId[0];
            AV8id = (short)(A5SocioId+1);
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
         P000E2_A5SocioId = new short[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.ultimoidsocio__default(),
            new Object[][] {
                new Object[] {
               P000E2_A5SocioId
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV8id ;
      private short A5SocioId ;
      private String scmdbuf ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] P000E2_A5SocioId ;
      private short aP0_id ;
   }

   public class ultimoidsocio__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP000E2 ;
          prmP000E2 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("P000E2", "SELECT TOP 1 [SocioId] FROM [Socio] WITH (NOLOCK) ORDER BY [SocioId] DESC ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000E2,1,0,false,true )
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
