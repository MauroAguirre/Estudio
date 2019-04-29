/*
               File: SocioConversion
        Description: Conversion for table Socio
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 4/12/2019 17:30:18.11
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
   public class socioconversion : GXProcedure
   {
      public socioconversion( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public socioconversion( IGxContext context )
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
         socioconversion objsocioconversion;
         objsocioconversion = new socioconversion();
         objsocioconversion.context.SetSubmitInitialConfig(context);
         objsocioconversion.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objsocioconversion);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((socioconversion)stateInfo).executePrivate();
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
         /* Using cursor SOCIOCONVE2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A36CarnetId = SOCIOCONVE2_A36CarnetId[0];
            A33SocioTipoCuota = SOCIOCONVE2_A33SocioTipoCuota[0];
            A20SocioEdad = SOCIOCONVE2_A20SocioEdad[0];
            A19SocioSexo = SOCIOCONVE2_A19SocioSexo[0];
            A18SocioDireccion = SOCIOCONVE2_A18SocioDireccion[0];
            A5SocioId = SOCIOCONVE2_A5SocioId[0];
            A40000SocioFoto_GXI = SOCIOCONVE2_A40000SocioFoto_GXI[0];
            A24SocioReconocido = SOCIOCONVE2_A24SocioReconocido[0];
            A21SocioFoto = SOCIOCONVE2_A21SocioFoto[0];
            /*
               INSERT RECORD ON TABLE GXA0004

            */
            AV2SocioId = A5SocioId;
            AV3SocioDireccion = A18SocioDireccion;
            AV4SocioSexo = A19SocioSexo;
            AV5SocioEdad = A20SocioEdad;
            AV6SocioReconocido = false;
            AV7SocioFoto = A21SocioFoto;
            AV8SocioFoto_GXI = A40000SocioFoto_GXI;
            AV8SocioFoto_GXI = A40000SocioFoto_GXI;
            AV9SocioTipoCuota = A33SocioTipoCuota;
            AV10CarnetId = A36CarnetId;
            /* Using cursor SOCIOCONVE3 */
            pr_default.execute(1, new Object[] {AV2SocioId, AV3SocioDireccion, AV4SocioSexo, AV5SocioEdad, AV6SocioReconocido, AV7SocioFoto, AV8SocioFoto_GXI, AV9SocioTipoCuota, AV10CarnetId});
            pr_default.close(1);
            dsDefault.SmartCacheProvider.SetUpdated("GXA0004") ;
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
         SOCIOCONVE2_A36CarnetId = new short[1] ;
         SOCIOCONVE2_A33SocioTipoCuota = new String[] {""} ;
         SOCIOCONVE2_A20SocioEdad = new short[1] ;
         SOCIOCONVE2_A19SocioSexo = new String[] {""} ;
         SOCIOCONVE2_A18SocioDireccion = new String[] {""} ;
         SOCIOCONVE2_A5SocioId = new short[1] ;
         SOCIOCONVE2_A40000SocioFoto_GXI = new String[] {""} ;
         SOCIOCONVE2_A24SocioReconocido = new String[] {""} ;
         SOCIOCONVE2_A21SocioFoto = new String[] {""} ;
         A33SocioTipoCuota = "";
         A19SocioSexo = "";
         A18SocioDireccion = "";
         A40000SocioFoto_GXI = "";
         A24SocioReconocido = "";
         A21SocioFoto = "";
         AV3SocioDireccion = "";
         AV4SocioSexo = "";
         AV7SocioFoto = "";
         AV8SocioFoto_GXI = "";
         AV9SocioTipoCuota = "";
         Gx_emsg = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.socioconversion__default(),
            new Object[][] {
                new Object[] {
               SOCIOCONVE2_A36CarnetId, SOCIOCONVE2_A33SocioTipoCuota, SOCIOCONVE2_A20SocioEdad, SOCIOCONVE2_A19SocioSexo, SOCIOCONVE2_A18SocioDireccion, SOCIOCONVE2_A5SocioId, SOCIOCONVE2_A40000SocioFoto_GXI, SOCIOCONVE2_A24SocioReconocido, SOCIOCONVE2_A21SocioFoto
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short A36CarnetId ;
      private short A20SocioEdad ;
      private short A5SocioId ;
      private short AV2SocioId ;
      private short AV5SocioEdad ;
      private short AV10CarnetId ;
      private int GIGXA0004 ;
      private String scmdbuf ;
      private String A33SocioTipoCuota ;
      private String A19SocioSexo ;
      private String A24SocioReconocido ;
      private String AV4SocioSexo ;
      private String AV9SocioTipoCuota ;
      private String Gx_emsg ;
      private bool AV6SocioReconocido ;
      private String A18SocioDireccion ;
      private String A40000SocioFoto_GXI ;
      private String AV3SocioDireccion ;
      private String AV8SocioFoto_GXI ;
      private String A21SocioFoto ;
      private String AV7SocioFoto ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] SOCIOCONVE2_A36CarnetId ;
      private String[] SOCIOCONVE2_A33SocioTipoCuota ;
      private short[] SOCIOCONVE2_A20SocioEdad ;
      private String[] SOCIOCONVE2_A19SocioSexo ;
      private String[] SOCIOCONVE2_A18SocioDireccion ;
      private short[] SOCIOCONVE2_A5SocioId ;
      private String[] SOCIOCONVE2_A40000SocioFoto_GXI ;
      private String[] SOCIOCONVE2_A24SocioReconocido ;
      private String[] SOCIOCONVE2_A21SocioFoto ;
   }

   public class socioconversion__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmSOCIOCONVE2 ;
          prmSOCIOCONVE2 = new Object[] {
          } ;
          Object[] prmSOCIOCONVE3 ;
          prmSOCIOCONVE3 = new Object[] {
          new Object[] {"@AV2SocioId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV3SocioDireccion",SqlDbType.VarChar,1024,0} ,
          new Object[] {"@AV4SocioSexo",SqlDbType.Char,20,0} ,
          new Object[] {"@AV5SocioEdad",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV6SocioReconocido",SqlDbType.Bit,4,0} ,
          new Object[] {"@AV7SocioFoto",SqlDbType.VarBinary,1024,0} ,
          new Object[] {"@AV8SocioFoto_GXI",SqlDbType.VarChar,2048,0} ,
          new Object[] {"@AV9SocioTipoCuota",SqlDbType.Char,20,0} ,
          new Object[] {"@AV10CarnetId",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("SOCIOCONVE2", "SELECT [CarnetId], [SocioTipoCuota], [SocioEdad], [SocioSexo], [SocioDireccion], [SocioId], [SocioFoto_GXI], [SocioReconocido], [SocioFoto] FROM [Socio] ORDER BY [SocioId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmSOCIOCONVE2,100,0,true,false )
             ,new CursorDef("SOCIOCONVE3", "INSERT INTO [GXA0004]([SocioId], [SocioDireccion], [SocioSexo], [SocioEdad], [SocioReconocido], [SocioFoto], [SocioFoto_GXI], [SocioTipoCuota], [CarnetId]) VALUES(@AV2SocioId, @AV3SocioDireccion, @AV4SocioSexo, @AV5SocioEdad, @AV6SocioReconocido, @AV7SocioFoto, @AV8SocioFoto_GXI, @AV9SocioTipoCuota, @AV10CarnetId)", GxErrorMask.GX_NOMASK,prmSOCIOCONVE3)
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
                ((String[]) buf[1])[0] = rslt.getString(2, 20) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 20) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((String[]) buf[6])[0] = rslt.getMultimediaUri(7) ;
                ((String[]) buf[7])[0] = rslt.getString(8, 20) ;
                ((String[]) buf[8])[0] = rslt.getMultimediaFile(9, rslt.getVarchar(7)) ;
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
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (bool)parms[4]);
                stmt.SetParameterBlob(6, (String)parms[5], false);
                stmt.SetParameterMultimedia(7, (String)parms[6], (String)parms[5], "GXA0004", "SocioFoto");
                stmt.SetParameter(8, (String)parms[7]);
                stmt.SetParameter(9, (short)parms[8]);
                return;
       }
    }

 }

}
