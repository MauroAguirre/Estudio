/*
               File: IngresarCarneAuto
        Description: Ingresar Carne Auto
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 4/12/2019 17:31:2.5
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
   public class ingresarcarneauto : GXProcedure
   {
      public ingresarcarneauto( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public ingresarcarneauto( IGxContext context )
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
         ingresarcarneauto objingresarcarneauto;
         objingresarcarneauto = new ingresarcarneauto();
         objingresarcarneauto.context.SetSubmitInitialConfig(context);
         objingresarcarneauto.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objingresarcarneauto);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((ingresarcarneauto)stateInfo).executePrivate();
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
         /* Using cursor P000C2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A5SocioId = P000C2_A5SocioId[0];
            AV13CarnetId = A5SocioId;
            AV9SocioId = A5SocioId;
            AV15Socio.gxTpr_Carnetid = A5SocioId;
            context.CommitDataStores("ingresarcarneauto",pr_default);
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
         P000C2_A5SocioId = new short[1] ;
         AV15Socio = new SdtSocio(context);
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.ingresarcarneauto__default(),
            new Object[][] {
                new Object[] {
               P000C2_A5SocioId
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short A5SocioId ;
      private short AV13CarnetId ;
      private short AV9SocioId ;
      private String scmdbuf ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] P000C2_A5SocioId ;
      private SdtSocio AV15Socio ;
   }

   public class ingresarcarneauto__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP000C2 ;
          prmP000C2 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("P000C2", "SELECT TOP 1 [SocioId] FROM [Socio] WITH (NOLOCK) ORDER BY [SocioId] DESC ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000C2,1,0,false,true )
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
