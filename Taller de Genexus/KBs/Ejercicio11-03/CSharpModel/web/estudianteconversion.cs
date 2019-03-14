/*
               File: EstudianteConversion
        Description: Conversion for table Estudiante
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 3/11/2019 21:0:40.54
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
   public class estudianteconversion : GXProcedure
   {
      public estudianteconversion( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public estudianteconversion( IGxContext context )
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
         estudianteconversion objestudianteconversion;
         objestudianteconversion = new estudianteconversion();
         objestudianteconversion.context.SetSubmitInitialConfig(context);
         objestudianteconversion.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objestudianteconversion);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((estudianteconversion)stateInfo).executePrivate();
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
         /* Using cursor ESTUDIANTE2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A11EstudianteNumero = ESTUDIANTE2_A11EstudianteNumero[0];
            /*
               INSERT RECORD ON TABLE GXA0003

            */
            AV2EstudianteNumero = A11EstudianteNumero;
            if ( (0==A9PersonaId) )
            {
               AV3EstudiantePersonaId = 0;
            }
            else
            {
               AV3EstudiantePersonaId = A9PersonaId;
            }
            /* Using cursor ESTUDIANTE3 */
            pr_default.execute(1, new Object[] {AV2EstudianteNumero, AV3EstudiantePersonaId});
            pr_default.close(1);
            dsDefault.SmartCacheProvider.SetUpdated("GXA0003") ;
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
         ESTUDIANTE2_A11EstudianteNumero = new short[1] ;
         Gx_emsg = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.estudianteconversion__default(),
            new Object[][] {
                new Object[] {
               ESTUDIANTE2_A11EstudianteNumero
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short A11EstudianteNumero ;
      private short AV2EstudianteNumero ;
      private short A9PersonaId ;
      private short AV3EstudiantePersonaId ;
      private int GIGXA0003 ;
      private String scmdbuf ;
      private String Gx_emsg ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] ESTUDIANTE2_A11EstudianteNumero ;
   }

   public class estudianteconversion__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmESTUDIANTE2 ;
          prmESTUDIANTE2 = new Object[] {
          } ;
          Object[] prmESTUDIANTE3 ;
          prmESTUDIANTE3 = new Object[] {
          new Object[] {"@AV2EstudianteNumero",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV3EstudiantePersonaId",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("ESTUDIANTE2", "SELECT [EstudianteNumero] FROM [Estudiante] ORDER BY [EstudianteNumero] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmESTUDIANTE2,100,0,true,false )
             ,new CursorDef("ESTUDIANTE3", "INSERT INTO [GXA0003]([EstudianteNumero], [EstudiantePersonaId]) VALUES(@AV2EstudianteNumero, @AV3EstudiantePersonaId)", GxErrorMask.GX_NOMASK,prmESTUDIANTE3)
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
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
       }
    }

 }

}
