/*
               File: ListadoSocioDeClase
        Description: Listado Socio De Clase
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 4/12/2019 18:43:7.11
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
   public class listadosociodeclase : GXWebProcedure, System.Web.SessionState.IRequiresSessionState
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
            if ( ! entryPointCalled )
            {
               AV10id = (short)(NumberUtil.Val( gxfirstwebparm, "."));
            }
         }
         if ( GxWebError == 0 )
         {
            executePrivate();
         }
         cleanup();
      }

      public listadosociodeclase( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public listadosociodeclase( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( short aP0_id )
      {
         this.AV10id = aP0_id;
         initialize();
         executePrivate();
      }

      public void executeSubmit( short aP0_id )
      {
         listadosociodeclase objlistadosociodeclase;
         objlistadosociodeclase = new listadosociodeclase();
         objlistadosociodeclase.AV10id = aP0_id;
         objlistadosociodeclase.context.SetSubmitInitialConfig(context);
         objlistadosociodeclase.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objlistadosociodeclase);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((listadosociodeclase)stateInfo).executePrivate();
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
            /* Using cursor P000T2 */
            pr_default.execute(0, new Object[] {AV10id});
            while ( (pr_default.getStatus(0) != 101) )
            {
               A3ClaseId = P000T2_A3ClaseId[0];
               H0T0( false, 100) ;
               getPrinter().GxDrawLine(342, Gx_line+33, 442, Gx_line+33, 1, 0, 0, 0, 0) ;
               getPrinter().GxDrawLine(225, Gx_line+67, 617, Gx_line+67, 1, 0, 0, 0, 0) ;
               getPrinter().GxAttris("Microsoft Sans Serif", 8, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
               getPrinter().GxDrawText("Socios de la clase", 350, Gx_line+17, 441, Gx_line+31, 0+256, 0, 0, 0) ;
               getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( (decimal)(A3ClaseId), "ZZZ9")), 442, Gx_line+50, 492, Gx_line+65, 2, 0, 0, 0) ;
               getPrinter().GxDrawText("Id de clase", 258, Gx_line+50, 313, Gx_line+64, 0+256, 0, 0, 0) ;
               Gx_OldLine = Gx_line;
               Gx_line = (int)(Gx_line+100);
               /* Using cursor P000T3 */
               pr_default.execute(1, new Object[] {A3ClaseId});
               while ( (pr_default.getStatus(1) != 101) )
               {
                  A18SocioDireccion = P000T3_A18SocioDireccion[0];
                  A33SocioTipoCuota = P000T3_A33SocioTipoCuota[0];
                  A19SocioSexo = P000T3_A19SocioSexo[0];
                  A20SocioEdad = P000T3_A20SocioEdad[0];
                  A5SocioId = P000T3_A5SocioId[0];
                  A18SocioDireccion = P000T3_A18SocioDireccion[0];
                  A33SocioTipoCuota = P000T3_A33SocioTipoCuota[0];
                  A19SocioSexo = P000T3_A19SocioSexo[0];
                  A20SocioEdad = P000T3_A20SocioEdad[0];
                  H0T0( false, 100) ;
                  getPrinter().GxAttris("Microsoft Sans Serif", 8, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
                  getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( (decimal)(A5SocioId), "ZZZ9")), 83, Gx_line+33, 125, Gx_line+48, 2, 0, 0, 0) ;
                  getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( (decimal)(A20SocioEdad), "ZZZ9")), 192, Gx_line+33, 225, Gx_line+48, 2, 0, 0, 0) ;
                  getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A19SocioSexo, "")), 300, Gx_line+33, 375, Gx_line+48, 0, 0, 0, 0) ;
                  getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A33SocioTipoCuota, "")), 450, Gx_line+33, 555, Gx_line+48, 0+256, 0, 0, 0) ;
                  getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A18SocioDireccion, "")), 608, Gx_line+33, 812, Gx_line+48, 0, 0, 0, 0) ;
                  Gx_OldLine = Gx_line;
                  Gx_line = (int)(Gx_line+100);
                  pr_default.readNext(1);
               }
               pr_default.close(1);
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(0);
            /* Print footer for last page */
            ToSkip = (int)(P_lines+1);
            H0T0( true, 0) ;
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

      protected void H0T0( bool bFoot ,
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
         P000T2_A3ClaseId = new short[1] ;
         P000T3_A3ClaseId = new short[1] ;
         P000T3_A18SocioDireccion = new String[] {""} ;
         P000T3_A33SocioTipoCuota = new String[] {""} ;
         P000T3_A19SocioSexo = new String[] {""} ;
         P000T3_A20SocioEdad = new short[1] ;
         P000T3_A5SocioId = new short[1] ;
         A18SocioDireccion = "";
         A33SocioTipoCuota = "";
         A19SocioSexo = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.listadosociodeclase__default(),
            new Object[][] {
                new Object[] {
               P000T2_A3ClaseId
               }
               , new Object[] {
               P000T3_A3ClaseId, P000T3_A18SocioDireccion, P000T3_A33SocioTipoCuota, P000T3_A19SocioSexo, P000T3_A20SocioEdad, P000T3_A5SocioId
               }
            }
         );
         /* GeneXus formulas. */
         Gx_line = 0;
         context.Gx_err = 0;
      }

      private short gxcookieaux ;
      private short nGotPars ;
      private short AV10id ;
      private short GxWebError ;
      private short A3ClaseId ;
      private short A20SocioEdad ;
      private short A5SocioId ;
      private int M_top ;
      private int M_bot ;
      private int Line ;
      private int ToSkip ;
      private int PrtOffset ;
      private int Gx_OldLine ;
      private String GXKey ;
      private String gxfirstwebparm ;
      private String scmdbuf ;
      private String A33SocioTipoCuota ;
      private String A19SocioSexo ;
      private bool entryPointCalled ;
      private String A18SocioDireccion ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] P000T2_A3ClaseId ;
      private short[] P000T3_A3ClaseId ;
      private String[] P000T3_A18SocioDireccion ;
      private String[] P000T3_A33SocioTipoCuota ;
      private String[] P000T3_A19SocioSexo ;
      private short[] P000T3_A20SocioEdad ;
      private short[] P000T3_A5SocioId ;
   }

   public class listadosociodeclase__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP000T2 ;
          prmP000T2 = new Object[] {
          new Object[] {"@AV10id",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmP000T3 ;
          prmP000T3 = new Object[] {
          new Object[] {"@ClaseId",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P000T2", "SELECT [ClaseId] FROM [Clase] WITH (NOLOCK) WHERE [ClaseId] = @AV10id ORDER BY [ClaseId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000T2,1,0,true,true )
             ,new CursorDef("P000T3", "SELECT T1.[ClaseId], T2.[SocioDireccion], T2.[SocioTipoCuota], T2.[SocioSexo], T2.[SocioEdad], T1.[SocioId] FROM ([ClaseSocios] T1 WITH (NOLOCK) INNER JOIN [Socio] T2 WITH (NOLOCK) ON T2.[SocioId] = T1.[SocioId]) WHERE T1.[ClaseId] = @ClaseId ORDER BY T1.[ClaseId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000T3,100,0,false,false )
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
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 20) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 20) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
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
             case 0 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
       }
    }

 }

}
