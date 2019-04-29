/*
               File: ClaseConversion
        Description: Conversion for table Clase
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 4/12/2019 8:53:49.77
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
using GeneXus.Reorg;
using System.Threading;
using GeneXus.Programs;
using System.Web.Services;
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
using System.Xml.Serialization;
namespace GeneXus.Programs {
   public class claseconversion : GXProcedure
   {
      public claseconversion( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public claseconversion( IGxContext context )
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
         claseconversion objclaseconversion;
         objclaseconversion = new claseconversion();
         objclaseconversion.context.SetSubmitInitialConfig(context);
         objclaseconversion.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objclaseconversion);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((claseconversion)stateInfo).executePrivate();
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
         /* Using cursor CLASECONVE2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A2ProfesorId = CLASECONVE2_A2ProfesorId[0];
            A3ClaseId = CLASECONVE2_A3ClaseId[0];
            A1ActividadId = CLASECONVE2_A1ActividadId[0];
            /*
               INSERT RECORD ON TABLE GXA0012

            */
            AV2ClaseId = A3ClaseId;
            AV3ProfesorId = A2ProfesorId;
            /* Using cursor CLASECONVE3 */
            pr_default.execute(1, new Object[] {AV2ClaseId, AV3ProfesorId});
            pr_default.close(1);
            dsDefault.SmartCacheProvider.SetUpdated("GXA0012") ;
            if ( (pr_default.getStatus(1) == 1) )
            {
               context.Gx_err = 1;
               Gx_emsg = (String)(GXResourceManager.GetMessage("GXM_noupdate"));
            }
            else
            {
               context.Gx_err = 0;
               Gx_emsg = "";
            }
            /* End Insert */
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
         CLASECONVE2_A2ProfesorId = new short[1] ;
         CLASECONVE2_A3ClaseId = new short[1] ;
         CLASECONVE2_A1ActividadId = new short[1] ;
         Gx_emsg = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.claseconversion__default(),
            new Object[][] {
                new Object[] {
               CLASECONVE2_A2ProfesorId, CLASECONVE2_A3ClaseId, CLASECONVE2_A1ActividadId
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short A2ProfesorId ;
      private short A3ClaseId ;
      private short A1ActividadId ;
      private short AV2ClaseId ;
      private short AV3ProfesorId ;
      private int GIGXA0012 ;
      private String scmdbuf ;
      private String Gx_emsg ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] CLASECONVE2_A2ProfesorId ;
      private short[] CLASECONVE2_A3ClaseId ;
      private short[] CLASECONVE2_A1ActividadId ;
   }

   public class claseconversion__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new UpdateCursor(def[1])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmCLASECONVE2 ;
          prmCLASECONVE2 = new Object[] {
          } ;
          Object[] prmCLASECONVE3 ;
          prmCLASECONVE3 = new Object[] {
          new Object[] {"@AV2ClaseId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV3ProfesorId",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("CLASECONVE2", "SELECT [ProfesorId], [ClaseId], [ActividadId] FROM [Clase] ORDER BY [ClaseId], [ActividadId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmCLASECONVE2,100,0,true,false )
             ,new CursorDef("CLASECONVE3", "INSERT INTO [GXA0012]([ClaseId], [ProfesorId]) VALUES(@AV2ClaseId, @AV3ProfesorId)", GxErrorMask.GX_NOMASK,prmCLASECONVE3)
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
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                return;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
       }
    }

 }

}
