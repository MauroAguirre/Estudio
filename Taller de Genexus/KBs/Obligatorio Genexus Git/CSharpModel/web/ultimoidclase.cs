/*
               File: UltimoIdClase
        Description: Ultimo Id Clase
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 4/12/2019 8:54:37.10
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
   public class ultimoidclase : GXProcedure
   {
      public ultimoidclase( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public ultimoidclase( IGxContext context )
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
         ultimoidclase objultimoidclase;
         objultimoidclase = new ultimoidclase();
         objultimoidclase.AV8Id = 0 ;
         objultimoidclase.context.SetSubmitInitialConfig(context);
         objultimoidclase.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objultimoidclase);
         aP0_Id=this.AV8Id;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((ultimoidclase)stateInfo).executePrivate();
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
         /* Using cursor P000K2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A3ClaseId = P000K2_A3ClaseId[0];
            AV8Id = (short)(A3ClaseId+1);
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
         P000K2_A3ClaseId = new short[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.ultimoidclase__default(),
            new Object[][] {
                new Object[] {
               P000K2_A3ClaseId
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV8Id ;
      private short A3ClaseId ;
      private String scmdbuf ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] P000K2_A3ClaseId ;
      private short aP0_Id ;
   }

   public class ultimoidclase__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP000K2 ;
          prmP000K2 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("P000K2", "SELECT TOP 1 [ClaseId] FROM [Clase] WITH (NOLOCK) ORDER BY [ClaseId] DESC ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000K2,1,0,false,true )
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
