/*
               File: ListadoSocioMonto
        Description: Listado Socio Monto
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 4/12/2019 6:13:30.81
       Program type: HTTP procedure
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
using GeneXus.Printer;
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
   public class listadosociomonto : GXWebProcedure, System.Web.SessionState.IRequiresSessionState
   {
      public override void webExecute( )
      {
         context.SetDefaultTheme("Carmine");
         initialize();
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetCookie( "GX_SESSION_ID"))) )
         {
            gxcookieaux = context.SetCookie( "GX_SESSION_ID", Encrypt64( Crypto.GetEncryptionKey( ), Crypto.GetServerKey( )), "", (DateTime)(DateTime.MinValue), "", 0);
         }
         GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
         if ( nGotPars == 0 )
         {
            entryPointCalled = false;
            gxfirstwebparm = GetNextPar( );
         }
         if ( GxWebError == 0 )
         {
            executePrivate();
         }
         cleanup();
      }

      public listadosociomonto( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public listadosociomonto( IGxContext context )
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
         listadosociomonto objlistadosociomonto;
         objlistadosociomonto = new listadosociomonto();
         objlistadosociomonto.context.SetSubmitInitialConfig(context);
         objlistadosociomonto.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objlistadosociomonto);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((listadosociomonto)stateInfo).executePrivate();
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
         M_top = 0;
         M_bot = 6;
         P_lines = (int)(66-M_bot);
         getPrinter().GxClearAttris() ;
         add_metrics( ) ;
         lineHeight = 15;
         PrtOffset = 0;
         gxXPage = 100;
         gxYPage = 100;
         getPrinter().GxSetDocName("") ;
         try
         {
            Gx_out = "FIL" ;
            if (!initPrinter (Gx_out, gxXPage, gxYPage, "GXPRN.INI", "", "", 2, 1, 256, 16834, 11909, 0, 1, 1, 0, 1, 1) )
            {
               cleanup();
               return;
            }
            getPrinter().setModal(false) ;
            P_lines = (int)(gxYPage-(lineHeight*6));
            Gx_line = (int)(P_lines+1);
            getPrinter().setPageLines(P_lines);
            getPrinter().setLineHeight(lineHeight);
            getPrinter().setM_top(M_top);
            getPrinter().setM_bot(M_bot);
            H0D0( false, 100) ;
            getPrinter().GxDrawLine(233, Gx_line+33, 333, Gx_line+33, 1, 0, 0, 0, 0) ;
            getPrinter().GxDrawLine(67, Gx_line+83, 700, Gx_line+83, 1, 0, 0, 0, 0) ;
            getPrinter().GxAttris("Microsoft Sans Serif", 8, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
            getPrinter().GxDrawText("Socios por Monto", 242, Gx_line+17, 329, Gx_line+31, 0+256, 0, 0, 0) ;
            getPrinter().GxDrawText("Id", 67, Gx_line+67, 77, Gx_line+81, 0+256, 0, 0, 0) ;
            getPrinter().GxDrawText("Monto", 150, Gx_line+67, 182, Gx_line+81, 0+256, 0, 0, 0) ;
            getPrinter().GxDrawText("Edad", 242, Gx_line+67, 269, Gx_line+81, 0+256, 0, 0, 0) ;
            getPrinter().GxDrawText("Sexo", 367, Gx_line+67, 393, Gx_line+81, 0+256, 0, 0, 0) ;
            getPrinter().GxDrawText("Tipo de Cuota", 475, Gx_line+67, 546, Gx_line+81, 0+256, 0, 0, 0) ;
            getPrinter().GxDrawText("Direccion", 633, Gx_line+67, 681, Gx_line+81, 0+256, 0, 0, 0) ;
            Gx_OldLine = Gx_line;
            Gx_line = (int)(Gx_line+100);
            /* Using cursor P000D2 */
            pr_default.execute(0);
            while ( (pr_default.getStatus(0) != 101) )
            {
               A19SocioSexo = P000D2_A19SocioSexo[0];
               A5SocioId = P000D2_A5SocioId[0];
               A18SocioDireccion = P000D2_A18SocioDireccion[0];
               A32SocioMonto = P000D2_A32SocioMonto[0];
               A33SocioTipoCuota = P000D2_A33SocioTipoCuota[0];
               A20SocioEdad = P000D2_A20SocioEdad[0];
               H0D0( false, 100) ;
               getPrinter().GxAttris("Microsoft Sans Serif", 8, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A18SocioDireccion, "")), 633, Gx_line+33, 812, Gx_line+48, 0, 0, 0, 0) ;
               getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( (decimal)(A20SocioEdad), "ZZZ9")), 242, Gx_line+33, 300, Gx_line+48, 2, 0, 0, 0) ;
               getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( (decimal)(A5SocioId), "ZZZ9")), 67, Gx_line+33, 109, Gx_line+48, 2, 0, 0, 0) ;
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A19SocioSexo, "")), 367, Gx_line+33, 425, Gx_line+48, 0, 0, 0, 0) ;
               getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( (decimal)(A32SocioMonto), "ZZZ9")), 142, Gx_line+33, 192, Gx_line+48, 2, 0, 0, 0) ;
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A33SocioTipoCuota, "")), 475, Gx_line+33, 580, Gx_line+48, 0+256, 0, 0, 0) ;
               Gx_OldLine = Gx_line;
               Gx_line = (int)(Gx_line+100);
               pr_default.readNext(0);
            }
            pr_default.close(0);
            /* Print footer for last page */
            ToSkip = (int)(P_lines+1);
            H0D0( true, 0) ;
         }
         catch ( GeneXus.Printer.ProcessInterruptedException e )
         {
         }
         finally
         {
            /* Close printer file */
            try
            {
               getPrinter().GxEndPage() ;
               getPrinter().GxEndDocument() ;
            }
            catch ( GeneXus.Printer.ProcessInterruptedException e )
            {
            }
            endPrinter();
         }
         if ( context.WillRedirect( ) )
         {
            context.Redirect( context.wjLoc );
            context.wjLoc = "";
         }
         this.cleanup();
      }

      protected void H0D0( bool bFoot ,
                           int Inc )
      {
         /* Skip the required number of lines */
         while ( ( ToSkip > 0 ) || ( Gx_line + Inc > P_lines ) )
         {
            if ( Gx_line + Inc >= P_lines )
            {
               if ( Gx_page > 0 )
               {
                  /* Print footers */
                  Gx_line = P_lines;
                  getPrinter().GxEndPage() ;
                  if ( bFoot )
                  {
                     return  ;
                  }
               }
               ToSkip = 0;
               Gx_line = 0;
               Gx_page = (int)(Gx_page+1);
               /* Skip Margin Top Lines */
               Gx_line = (int)(Gx_line+(M_top*lineHeight));
               /* Print headers */
               getPrinter().GxStartPage() ;
               if (true) break;
            }
            else
            {
               PrtOffset = 0;
               Gx_line = (int)(Gx_line+1);
            }
            ToSkip = (int)(ToSkip-1);
         }
         getPrinter().setPage(Gx_page);
      }

      protected void add_metrics( )
      {
         add_metrics0( ) ;
      }

      protected void add_metrics0( )
      {
         getPrinter().setMetrics("Microsoft Sans Serif", false, false, 58, 14, 72, 171,  new int[] {48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 18, 20, 23, 36, 36, 57, 43, 12, 21, 21, 25, 37, 18, 21, 18, 18, 36, 36, 36, 36, 36, 36, 36, 36, 36, 36, 18, 18, 37, 37, 37, 36, 65, 43, 43, 46, 46, 43, 39, 50, 46, 18, 32, 43, 36, 53, 46, 50, 43, 50, 46, 43, 40, 46, 43, 64, 41, 42, 39, 18, 18, 18, 27, 36, 21, 36, 36, 32, 36, 36, 18, 36, 36, 14, 15, 33, 14, 55, 36, 36, 36, 36, 21, 32, 18, 36, 33, 47, 31, 31, 31, 21, 17, 21, 37, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 18, 20, 36, 36, 36, 36, 17, 36, 21, 47, 24, 36, 37, 21, 47, 35, 26, 35, 21, 21, 21, 37, 34, 21, 21, 21, 23, 36, 53, 53, 53, 39, 43, 43, 43, 43, 43, 43, 64, 46, 43, 43, 43, 43, 18, 18, 18, 18, 46, 46, 50, 50, 50, 50, 50, 37, 50, 46, 46, 46, 46, 43, 43, 39, 36, 36, 36, 36, 36, 36, 57, 32, 36, 36, 36, 36, 18, 18, 18, 18, 36, 36, 36, 36, 36, 36, 36, 35, 39, 36, 36, 36, 36, 32, 36, 32}) ;
      }

      public override int getOutputType( )
      {
         return GxReportUtils.OUTPUT_PDF ;
      }

      public override void cleanup( )
      {
         CloseOpenCursors();
         base.cleanup();
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
         GXKey = "";
         gxfirstwebparm = "";
         scmdbuf = "";
         P000D2_A19SocioSexo = new String[] {""} ;
         P000D2_A5SocioId = new short[1] ;
         P000D2_A18SocioDireccion = new String[] {""} ;
         P000D2_A32SocioMonto = new short[1] ;
         P000D2_A33SocioTipoCuota = new String[] {""} ;
         P000D2_A20SocioEdad = new short[1] ;
         A19SocioSexo = "";
         A18SocioDireccion = "";
         A33SocioTipoCuota = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.listadosociomonto__default(),
            new Object[][] {
                new Object[] {
               P000D2_A19SocioSexo, P000D2_A5SocioId, P000D2_A18SocioDireccion, P000D2_A32SocioMonto, P000D2_A33SocioTipoCuota, P000D2_A20SocioEdad
               }
            }
         );
         /* GeneXus formulas. */
         Gx_line = 0;
         context.Gx_err = 0;
      }

      private short gxcookieaux ;
      private short nGotPars ;
      private short GxWebError ;
      private short A5SocioId ;
      private short A32SocioMonto ;
      private short A20SocioEdad ;
      private int M_top ;
      private int M_bot ;
      private int Line ;
      private int ToSkip ;
      private int PrtOffset ;
      private int Gx_OldLine ;
      private String GXKey ;
      private String gxfirstwebparm ;
      private String scmdbuf ;
      private String A19SocioSexo ;
      private String A33SocioTipoCuota ;
      private bool entryPointCalled ;
      private String A18SocioDireccion ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] P000D2_A19SocioSexo ;
      private short[] P000D2_A5SocioId ;
      private String[] P000D2_A18SocioDireccion ;
      private short[] P000D2_A32SocioMonto ;
      private String[] P000D2_A33SocioTipoCuota ;
      private short[] P000D2_A20SocioEdad ;
   }

   public class listadosociomonto__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP000D2 ;
          prmP000D2 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("P000D2", "SELECT [SocioSexo], [SocioId], [SocioDireccion], CASE  WHEN [SocioTipoCuota] = 'P' and [SocioEdad] > 65 THEN 1500 - ( 1500 * CAST(0.3 AS decimal( 14, 10))) WHEN [SocioTipoCuota] = 'V' and [SocioEdad] > 65 THEN 2500 - ( 2500 * CAST(0.3 AS decimal( 14, 10))) WHEN [SocioTipoCuota] = 'P' THEN 1500 ELSE 2500 END AS SocioMonto, [SocioTipoCuota], [SocioEdad] FROM [Socio] WITH (NOLOCK) ORDER BY [SocioMonto] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000D2,100,0,false,false )
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
                ((String[]) buf[0])[0] = rslt.getString(1, 20) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 20) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
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
