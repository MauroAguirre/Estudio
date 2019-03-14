/*
               File: ClienteConversion
        Description: Conversion for table Cliente
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 3/11/2019 19:40:27.92
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
   public class clienteconversion : GXProcedure
   {
      public clienteconversion( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public clienteconversion( IGxContext context )
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
         clienteconversion objclienteconversion;
         objclienteconversion = new clienteconversion();
         objclienteconversion.context.SetSubmitInitialConfig(context);
         objclienteconversion.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objclienteconversion);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((clienteconversion)stateInfo).executePrivate();
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
         cmdBuffer=" SET IDENTITY_INSERT [GXA0001] ON "
         ;
         RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
         RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
         RGZ.ExecuteStmt() ;
         RGZ.Drop();
         /* Using cursor CLIENTECON2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A4ClienteFechaNacimiento = CLIENTECON2_A4ClienteFechaNacimiento[0];
            A3ClienteApellido = CLIENTECON2_A3ClienteApellido[0];
            A2ClienteNombre = CLIENTECON2_A2ClienteNombre[0];
            A1ClienteId = CLIENTECON2_A1ClienteId[0];
            AV8GXV6 = 0;
            AV9GXV7 = DateTime.MinValue;
            /* Using cursor CLIENTECON3 */
            pr_default.execute(1, new Object[] {A1ClienteId});
            while ( (pr_default.getStatus(1) != 101) )
            {
               A6FacturaNumero = CLIENTECON3_A6FacturaNumero[0];
               A7FacturaFecha = CLIENTECON3_A7FacturaFecha[0];
               AV8GXV6 = A6FacturaNumero;
               AV9GXV7 = A7FacturaFecha;
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
               pr_default.readNext(1);
            }
            pr_default.close(1);
            /*
               INSERT RECORD ON TABLE GXA0001

            */
            AV2ClienteId = A1ClienteId;
            if ( (0==AV8GXV6) )
            {
               AV3FacturaNumero = 0;
            }
            else
            {
               AV3FacturaNumero = AV8GXV6;
            }
            AV4ClienteNombre = A2ClienteNombre;
            AV5ClienteApellido = A3ClienteApellido;
            AV6ClienteFechaNacimiento = A4ClienteFechaNacimiento;
            if ( (DateTime.MinValue==AV9GXV7) )
            {
               AV7FacturaFecha = context.localUtil.YMDToD( 1753, 1, 1);
            }
            else
            {
               AV7FacturaFecha = AV9GXV7;
            }
            /* Using cursor CLIENTECON4 */
            pr_default.execute(2, new Object[] {AV2ClienteId, AV3FacturaNumero, AV4ClienteNombre, AV5ClienteApellido, AV6ClienteFechaNacimiento, AV7FacturaFecha});
            pr_default.close(2);
            dsDefault.SmartCacheProvider.SetUpdated("GXA0001") ;
            if ( (pr_default.getStatus(2) == 1) )
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
         cmdBuffer=" SET IDENTITY_INSERT [GXA0001] OFF "
         ;
         RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
         RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
         RGZ.ExecuteStmt() ;
         RGZ.Drop();
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
         cmdBuffer = "";
         scmdbuf = "";
         CLIENTECON2_A4ClienteFechaNacimiento = new DateTime[] {DateTime.MinValue} ;
         CLIENTECON2_A3ClienteApellido = new String[] {""} ;
         CLIENTECON2_A2ClienteNombre = new String[] {""} ;
         CLIENTECON2_A1ClienteId = new short[1] ;
         A4ClienteFechaNacimiento = DateTime.MinValue;
         A3ClienteApellido = "";
         A2ClienteNombre = "";
         AV9GXV7 = DateTime.MinValue;
         CLIENTECON3_A1ClienteId = new short[1] ;
         CLIENTECON3_A6FacturaNumero = new short[1] ;
         CLIENTECON3_A7FacturaFecha = new DateTime[] {DateTime.MinValue} ;
         A7FacturaFecha = DateTime.MinValue;
         AV4ClienteNombre = "";
         AV5ClienteApellido = "";
         AV6ClienteFechaNacimiento = DateTime.MinValue;
         AV7FacturaFecha = DateTime.MinValue;
         Gx_emsg = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.clienteconversion__default(),
            new Object[][] {
                new Object[] {
               CLIENTECON2_A4ClienteFechaNacimiento, CLIENTECON2_A3ClienteApellido, CLIENTECON2_A2ClienteNombre, CLIENTECON2_A1ClienteId
               }
               , new Object[] {
               CLIENTECON3_A1ClienteId, CLIENTECON3_A6FacturaNumero, CLIENTECON3_A7FacturaFecha
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short A1ClienteId ;
      private short AV8GXV6 ;
      private short A6FacturaNumero ;
      private short AV2ClienteId ;
      private short AV3FacturaNumero ;
      private int GIGXA0001 ;
      private String cmdBuffer ;
      private String scmdbuf ;
      private String A3ClienteApellido ;
      private String A2ClienteNombre ;
      private String AV4ClienteNombre ;
      private String AV5ClienteApellido ;
      private String Gx_emsg ;
      private DateTime A4ClienteFechaNacimiento ;
      private DateTime AV9GXV7 ;
      private DateTime A7FacturaFecha ;
      private DateTime AV6ClienteFechaNacimiento ;
      private DateTime AV7FacturaFecha ;
      private IGxDataStore dsDefault ;
      private GxCommand RGZ ;
      private IDataStoreProvider pr_default ;
      private DateTime[] CLIENTECON2_A4ClienteFechaNacimiento ;
      private String[] CLIENTECON2_A3ClienteApellido ;
      private String[] CLIENTECON2_A2ClienteNombre ;
      private short[] CLIENTECON2_A1ClienteId ;
      private short[] CLIENTECON3_A1ClienteId ;
      private short[] CLIENTECON3_A6FacturaNumero ;
      private DateTime[] CLIENTECON3_A7FacturaFecha ;
   }

   public class clienteconversion__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new UpdateCursor(def[2])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmCLIENTECON2 ;
          prmCLIENTECON2 = new Object[] {
          } ;
          Object[] prmCLIENTECON3 ;
          prmCLIENTECON3 = new Object[] {
          new Object[] {"@ClienteId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmCLIENTECON4 ;
          prmCLIENTECON4 = new Object[] {
          new Object[] {"@AV2ClienteId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV3FacturaNumero",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV4ClienteNombre",SqlDbType.Char,20,0} ,
          new Object[] {"@AV5ClienteApellido",SqlDbType.Char,20,0} ,
          new Object[] {"@AV6ClienteFechaNacimiento",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV7FacturaFecha",SqlDbType.DateTime,8,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("CLIENTECON2", "SELECT [ClienteFechaNacimiento], [ClienteApellido], [ClienteNombre], [ClienteId] FROM [Cliente] ORDER BY [ClienteId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmCLIENTECON2,100,0,true,false )
             ,new CursorDef("CLIENTECON3", "SELECT TOP 1 [ClienteId], [FacturaNumero], [FacturaFecha] FROM [Factura] WHERE [ClienteId] = @ClienteId ORDER BY [ClienteId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmCLIENTECON3,1,0,false,true )
             ,new CursorDef("CLIENTECON4", "INSERT INTO [GXA0001]([ClienteId], [FacturaNumero], [ClienteNombre], [ClienteApellido], [ClienteFechaNacimiento], [FacturaFecha]) VALUES(@AV2ClienteId, @AV3FacturaNumero, @AV4ClienteNombre, @AV5ClienteApellido, @AV6ClienteFechaNacimiento, @AV7FacturaFecha)", GxErrorMask.GX_NOMASK,prmCLIENTECON4)
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
                ((DateTime[]) buf[0])[0] = rslt.getGXDate(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 20) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 20) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((DateTime[]) buf[2])[0] = rslt.getGXDate(3) ;
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
                return;
             case 2 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (DateTime)parms[4]);
                stmt.SetParameter(6, (DateTime)parms[5]);
                return;
       }
    }

 }

}
