/*
               File: RwdMasterPage
        Description: Responsive Master Page
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 4/12/2019 21:6:45.22
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
using GeneXus.WebControls;
using GeneXus.Http;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class rwdmasterpage : GXMasterPage, System.Web.SessionState.IRequiresSessionState
   {
      public rwdmasterpage( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
      }

      public rwdmasterpage( IGxContext context )
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
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
      }

      protected void INITWEB( )
      {
         initialize_properties( ) ;
      }

      public override void webExecute( )
      {
         if ( initialized == 0 )
         {
            createObjects();
            initialize();
         }
         INITWEB( ) ;
         if ( ! isAjaxCallMode( ) )
         {
            PA042( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               context.Gx_err = 0;
               WS042( ) ;
               if ( ! isAjaxCallMode( ) )
               {
                  WE042( ) ;
               }
            }
         }
         this.cleanup();
      }

      protected void RenderHtmlHeaders( )
      {
         if ( ! isFullAjaxMode( ) )
         {
            GXWebForm.AddResponsiveMetaHeaders((getDataAreaObject() == null ? Form : getDataAreaObject().GetForm()).Meta);
            getDataAreaObject().RenderHtmlHeaders();
         }
      }

      protected void RenderHtmlOpenForm( )
      {
         if ( ! isFullAjaxMode( ) )
         {
            getDataAreaObject().RenderHtmlOpenForm();
         }
      }

      protected void send_integrity_footer_hashes( )
      {
         GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "FORM_MPAGE_Caption", StringUtil.RTrim( (getDataAreaObject() == null ? Form : getDataAreaObject().GetForm()).Caption));
         GxWebStd.gx_hidden_field( context, "FORM_MPAGE_Caption", StringUtil.RTrim( (getDataAreaObject() == null ? Form : getDataAreaObject().GetForm()).Caption));
      }

      protected void RenderHtmlCloseForm042( )
      {
         SendCloseFormHiddens( ) ;
         SendSecurityToken((String)(sPrefix));
         if ( ! isFullAjaxMode( ) )
         {
            getDataAreaObject().RenderHtmlCloseForm();
         }
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         if ( ! ( WebComp_Wcrecentlinks == null ) )
         {
            WebComp_Wcrecentlinks.componentjscripts();
         }
         context.AddJavascriptSource("rwdmasterpage.js", "?20194122164524", false);
         context.AddJavascriptSource("bootstrap/js/bootstrap.min.js", "?"+context.GetBuildNumber( 126726), false);
         context.WriteHtmlTextNl( "</body>") ;
         context.WriteHtmlTextNl( "</html>") ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
      }

      public override String GetPgmname( )
      {
         return "RwdMasterPage" ;
      }

      public override String GetPgmdesc( )
      {
         return "Responsive Master Page" ;
      }

      protected void WB040( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! wbLoad )
         {
            RenderHtmlHeaders( ) ;
            RenderHtmlOpenForm( ) ;
            if ( ! ShowMPWhenPopUp( ) && context.isPopUpObject( ) )
            {
               if ( context.isSpaRequest( ) )
               {
                  enableOutput();
               }
               if ( context.isSpaRequest( ) )
               {
                  disableJsOutput();
               }
               /* Content placeholder */
               context.WriteHtmlText( "<div") ;
               GxWebStd.ClassAttribute( context, "gx-content-placeholder");
               context.WriteHtmlText( ">") ;
               if ( ! isFullAjaxMode( ) )
               {
                  getDataAreaObject().RenderHtmlContent();
               }
               context.WriteHtmlText( "</div>") ;
               if ( context.isSpaRequest( ) )
               {
                  disableOutput();
               }
               if ( context.isSpaRequest( ) )
               {
                  enableJsOutput();
               }
               wbLoad = true;
               return  ;
            }
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divMaintable_Internalname, 1, 0, "px", 0, "px", "MainContainer", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divHeader_Internalname, 1, 0, "px", 0, "px", "ContainerFluid HeaderContainer", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-10", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblApplicationheader_Internalname, "Club Deportivo", "", "", lblApplicationheader_Jsonclick, "'"+""+"'"+",true,"+"'"+"E_MPAGE."+"'", "", "TextBlockHeader", 0, "", 1, 1, 0, "HLP_RwdMasterPage.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            wb_table1_12_042( true) ;
         }
         else
         {
            wb_table1_12_042( false) ;
         }
         return  ;
      }

      protected void wb_table1_12_042e( bool wbgen )
      {
         if ( wbgen )
         {
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divRecent_Internalname, 1, 0, "px", 0, "px", "ContainerFluid RecentLinksContainer", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            if ( ! isFullAjaxMode( ) )
            {
               /* WebComponent */
               GxWebStd.gx_hidden_field( context, "MPW0054"+"", StringUtil.RTrim( WebComp_Wcrecentlinks_Component));
               context.WriteHtmlText( "<div") ;
               GxWebStd.ClassAttribute( context, "gxwebcomponent");
               context.WriteHtmlText( " id=\""+"gxHTMLWrpMPW0054"+""+"\""+"") ;
               context.WriteHtmlText( ">") ;
               if ( StringUtil.Len( WebComp_Wcrecentlinks_Component) != 0 )
               {
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldWcrecentlinks), StringUtil.Lower( WebComp_Wcrecentlinks_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpMPW0054"+"");
                  }
                  WebComp_Wcrecentlinks.componentdraw();
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldWcrecentlinks), StringUtil.Lower( WebComp_Wcrecentlinks_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspEndCmp();
                  }
               }
               context.WriteHtmlText( "</div>") ;
            }
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divContent_Internalname, 1, 0, "px", 0, "px", "BodyContainer", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            if ( context.isSpaRequest( ) )
            {
               enableOutput();
            }
            if ( context.isSpaRequest( ) )
            {
               disableJsOutput();
            }
            /* Content placeholder */
            context.WriteHtmlText( "<div") ;
            GxWebStd.ClassAttribute( context, "gx-content-placeholder");
            context.WriteHtmlText( ">") ;
            if ( ! isFullAjaxMode( ) )
            {
               getDataAreaObject().RenderHtmlContent();
            }
            context.WriteHtmlText( "</div>") ;
            if ( context.isSpaRequest( ) )
            {
               disableOutput();
            }
            if ( context.isSpaRequest( ) )
            {
               enableJsOutput();
            }
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         wbLoad = true;
      }

      protected void START042( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP040( ) ;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            if ( context.isSpaRequest( ) )
            {
               disableJsOutput();
            }
            if ( getDataAreaObject().ExecuteStartEvent() != 0 )
            {
               setAjaxCallMode();
            }
            if ( context.isSpaRequest( ) )
            {
               enableJsOutput();
            }
         }
      }

      protected void WS042( )
      {
         START042( ) ;
         EVT042( ) ;
      }

      protected void EVT042( )
      {
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) && ! wbErr )
            {
               /* Read Web Panel buttons. */
               sEvt = cgiGet( "_EventName");
               EvtGridId = cgiGet( "_EventGridId");
               EvtRowId = cgiGet( "_EventRowId");
               if ( StringUtil.Len( sEvt) > 0 )
               {
                  sEvtType = StringUtil.Left( sEvt, 1);
                  sEvt = StringUtil.Right( sEvt, (short)(StringUtil.Len( sEvt)-1));
                  if ( StringUtil.StrCmp(sEvtType, "E") == 0 )
                  {
                     sEvtType = StringUtil.Right( sEvt, 1);
                     if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                     {
                        sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                        if ( StringUtil.StrCmp(sEvt, "RFR_MPAGE") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "START_MPAGE") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: Start */
                           E11042 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "REFRESH_MPAGE") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: Refresh */
                           E12042 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "SOCIOSPORMONTO_MPAGE") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: 'SociosPorMonto' */
                           E13042 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "PROFESORACTIVIDAD_MPAGE") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: 'ProfesorActividad' */
                           E14042 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "SOCIOSDEUNACLASE_MPAGE") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: 'SociosDeUnaClase' */
                           E15042 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "SOCIOSPREMIADOS_MPAGE") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: 'SociosPremiados' */
                           E16042 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "SOCIOSPARASERPREMIADOS_MPAGE") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: 'SociosparaserPremiados' */
                           E17042 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "LOAD_MPAGE") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: Load */
                           E18042 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "ENTER_MPAGE") == 0 )
                        {
                           context.wbHandled = 1;
                           if ( ! wbErr )
                           {
                              Rfr0gs = false;
                              if ( ! Rfr0gs )
                              {
                              }
                              dynload_actions( ) ;
                           }
                           /* No code required for Cancel button. It is implemented as the Reset button. */
                        }
                        else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           dynload_actions( ) ;
                        }
                     }
                     else
                     {
                     }
                  }
                  else if ( StringUtil.StrCmp(sEvtType, "M") == 0 )
                  {
                     sEvtType = StringUtil.Right( sEvt, (short)(StringUtil.Len( sEvt)-2));
                     sEvt = StringUtil.Right( sEvt, (short)(StringUtil.Len( sEvt)-6));
                     nCmpId = (short)(NumberUtil.Val( sEvtType, "."));
                     if ( nCmpId == 54 )
                     {
                        OldWcrecentlinks = cgiGet( "MPW0054");
                        if ( ( StringUtil.Len( OldWcrecentlinks) == 0 ) || ( StringUtil.StrCmp(OldWcrecentlinks, WebComp_Wcrecentlinks_Component) != 0 ) )
                        {
                           WebComp_Wcrecentlinks = getWebComponent(GetType(), "GeneXus.Programs", OldWcrecentlinks, new Object[] {context} );
                           WebComp_Wcrecentlinks.ComponentInit();
                           WebComp_Wcrecentlinks.Name = "OldWcrecentlinks";
                           WebComp_Wcrecentlinks_Component = OldWcrecentlinks;
                        }
                        if ( StringUtil.Len( WebComp_Wcrecentlinks_Component) != 0 )
                        {
                           WebComp_Wcrecentlinks.componentprocess("MPW0054", "", sEvt);
                        }
                        WebComp_Wcrecentlinks_Component = OldWcrecentlinks;
                     }
                  }
                  if ( context.wbHandled == 0 )
                  {
                     getDataAreaObject().DispatchEvents();
                  }
                  context.wbHandled = 1;
               }
            }
         }
      }

      protected void WE042( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm042( ) ;
            }
         }
      }

      protected void PA042( )
      {
         if ( nDonePA == 0 )
         {
            if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetCookie( "GX_SESSION_ID"))) )
            {
               gxcookieaux = context.SetCookie( "GX_SESSION_ID", Encrypt64( Crypto.GetEncryptionKey( ), Crypto.GetServerKey( )), "", (DateTime)(DateTime.MinValue), "", 0);
            }
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            toggleJsOutput = isJsOutputEnabled( );
            if ( context.isSpaRequest( ) )
            {
               disableJsOutput();
            }
            init_web_controls( ) ;
            if ( toggleJsOutput )
            {
               if ( context.isSpaRequest( ) )
               {
                  enableJsOutput();
               }
            }
            if ( ! context.isAjaxRequest( ) )
            {
            }
            nDonePA = 1;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void send_integrity_hashes( )
      {
      }

      protected void clear_multi_value_controls( )
      {
         if ( context.isAjaxRequest( ) )
         {
            dynload_actions( ) ;
         }
      }

      protected void fix_multi_value_controls( )
      {
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF042( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      protected void RF042( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( ShowMPWhenPopUp( ) || ! context.isPopUpObject( ) )
         {
            /* Execute user event: Refresh */
            E12042 ();
            if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
            {
               if ( 1 != 0 )
               {
                  if ( StringUtil.Len( WebComp_Wcrecentlinks_Component) != 0 )
                  {
                     WebComp_Wcrecentlinks.componentstart();
                  }
               }
            }
            gxdyncontrolsrefreshing = true;
            fix_multi_value_controls( ) ;
            gxdyncontrolsrefreshing = false;
         }
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            /* Execute user event: Load */
            E18042 ();
            WB040( ) ;
            if ( context.isSpaRequest( ) )
            {
               enableOutput();
            }
         }
      }

      protected void send_integrity_lvl_hashes042( )
      {
      }

      protected void STRUP040( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E11042 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            /* Read saved values. */
            (getDataAreaObject() == null ? Form : getDataAreaObject().GetForm()).Caption = cgiGet( "FORM_MPAGE_Caption");
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      protected void GXStart( )
      {
         /* Execute user event: Start */
         E11042 ();
         if (returnInSub) return;
      }

      protected void E11042( )
      {
         /* Start Routine */
         (getDataAreaObject() == null ? Form : getDataAreaObject().GetForm()).Meta.addItem("viewport", "width=device-width; initial-scale=1.0; maximum-scale=1.0; user-scalable=0;", 0) ;
         (getDataAreaObject() == null ? Form : getDataAreaObject().GetForm()).Meta.addItem("apple-mobile-web-app-capable", "yes", 0) ;
      }

      protected void E12042( )
      {
         /* Refresh Routine */
         /* Object Property */
         if ( StringUtil.StrCmp(StringUtil.Lower( WebComp_Wcrecentlinks_Component), StringUtil.Lower( "RwdRecentLinks")) != 0 )
         {
            WebComp_Wcrecentlinks = getWebComponent(GetType(), "GeneXus.Programs", "rwdrecentlinks", new Object[] {context} );
            WebComp_Wcrecentlinks.ComponentInit();
            WebComp_Wcrecentlinks.Name = "RwdRecentLinks";
            WebComp_Wcrecentlinks_Component = "RwdRecentLinks";
         }
         if ( StringUtil.Len( WebComp_Wcrecentlinks_Component) != 0 )
         {
            WebComp_Wcrecentlinks.setjustcreated();
            WebComp_Wcrecentlinks.componentprepare(new Object[] {(String)"MPW0054",(String)"",(getDataAreaObject() == null ? Form : getDataAreaObject().GetForm()).Caption,Contentholder.Pgmname});
            WebComp_Wcrecentlinks.componentbind(new Object[] {(String)"",(String)""});
         }
         if ( isFullAjaxMode( ) )
         {
            context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpMPW0054"+"");
            WebComp_Wcrecentlinks.componentdraw();
            context.httpAjaxContext.ajax_rspEndCmp();
         }
         /*  Sending Event outputs  */
      }

      protected void E13042( )
      {
         /* 'SociosPorMonto' Routine */
         CallWebObject(formatLink("listadosociomonto.aspx") );
         context.wjLocDisableFrm = 0;
      }

      protected void E14042( )
      {
         /* 'ProfesorActividad' Routine */
         CallWebObject(formatLink("listadoprofesoractividad.aspx") );
         context.wjLocDisableFrm = 0;
      }

      protected void E15042( )
      {
         /* 'SociosDeUnaClase' Routine */
         CallWebObject(formatLink("listadoclasesocioysexo.aspx") );
         context.wjLocDisableFrm = 0;
      }

      protected void E16042( )
      {
         /* 'SociosPremiados' Routine */
         CallWebObject(formatLink("listadosociospremiados.aspx") );
         context.wjLocDisableFrm = 0;
      }

      protected void E17042( )
      {
         /* 'SociosparaserPremiados' Routine */
         CallWebObject(formatLink("listadossocioparapremiar.aspx") );
         context.wjLocDisableFrm = 0;
      }

      protected void nextLoad( )
      {
      }

      protected void E18042( )
      {
         /* Load Routine */
      }

      protected void wb_table1_12_042( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTable1_Internalname, tblTable1_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',true,'',0)\"";
            ClassString = "Button";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttSociospormonto_Internalname, "", "Socios por monto", bttSociospormonto_Jsonclick, 5, "Socios por monto", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",true,"+"'"+"ESOCIOSPORMONTO_MPAGE."+"'", TempTags, "", context.GetButtonType( ), "HLP_RwdMasterPage.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 17,'',true,'',0)\"";
            ClassString = "Button";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttProfesoractividad_Internalname, "", "Profesor por actividad y cantidad", bttProfesoractividad_Jsonclick, 5, "Profesor por actividad y cantidad", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",true,"+"'"+"EPROFESORACTIVIDAD_MPAGE."+"'", TempTags, "", context.GetButtonType( ), "HLP_RwdMasterPage.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',true,'',0)\"";
            ClassString = "Button";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttSociosdeunaclase_Internalname, "", "Socios de una clase", bttSociosdeunaclase_Jsonclick, 5, "Socios de una clase", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",true,"+"'"+"ESOCIOSDEUNACLASE_MPAGE."+"'", TempTags, "", context.GetButtonType( ), "HLP_RwdMasterPage.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',true,'',0)\"";
            ClassString = "Button";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttActividadesdeportivas_Internalname, "", "Actividades deportivas", bttActividadesdeportivas_Jsonclick, 7, "Actividades deportivas", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",true,"+"'"+"e19041_client"+"'", TempTags, "", 2, "HLP_RwdMasterPage.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',true,'',0)\"";
            ClassString = "Button";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttActividadprofesores_Internalname, "", "Actividadprofesores", bttActividadprofesores_Jsonclick, 7, "Actividadprofesores", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",true,"+"'"+"e20041_client"+"'", TempTags, "", 2, "HLP_RwdMasterPage.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',true,'',0)\"";
            ClassString = "Button";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttGraficaprofesoractividad_Internalname, "", "Grafica Profesor Actividad", bttGraficaprofesoractividad_Jsonclick, 7, "Grafica Profesor Actividad", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",true,"+"'"+"e21041_client"+"'", TempTags, "", 2, "HLP_RwdMasterPage.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'',true,'',0)\"";
            ClassString = "Button";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttSociosparaserpremiados_Internalname, "", "Socios para ser Premiados", bttSociosparaserpremiados_Jsonclick, 5, "Socios para ser Premiados", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",true,"+"'"+"ESOCIOSPARASERPREMIADOS_MPAGE."+"'", TempTags, "", context.GetButtonType( ), "HLP_RwdMasterPage.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 35,'',true,'',0)\"";
            ClassString = "Button";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttSocios_Internalname, "", "Socios", bttSocios_Jsonclick, 7, "Socios", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",true,"+"'"+"e22041_client"+"'", TempTags, "", 2, "HLP_RwdMasterPage.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 37,'',true,'',0)\"";
            ClassString = "Button";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttClases_Internalname, "", "Clases", bttClases_Jsonclick, 7, "Clases", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",true,"+"'"+"e23041_client"+"'", TempTags, "", 2, "HLP_RwdMasterPage.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',true,'',0)\"";
            ClassString = "Button";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttProfesores_Internalname, "", "Profesores", bttProfesores_Jsonclick, 7, "Profesores", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",true,"+"'"+"e24041_client"+"'", TempTags, "", 2, "HLP_RwdMasterPage.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 41,'',true,'',0)\"";
            ClassString = "Button";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttActividades_Internalname, "", "Actividades", bttActividades_Jsonclick, 7, "Actividades", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",true,"+"'"+"e25041_client"+"'", TempTags, "", 2, "HLP_RwdMasterPage.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',true,'',0)\"";
            ClassString = "Button";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttCarnets_Internalname, "", "Carnets", bttCarnets_Jsonclick, 7, "Carnets", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",true,"+"'"+"e26041_client"+"'", TempTags, "", 2, "HLP_RwdMasterPage.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 45,'',true,'',0)\"";
            ClassString = "Button";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttMenudebug_Internalname, "", "Menu Debug", bttMenudebug_Jsonclick, 7, "Menu Debug", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",true,"+"'"+"e27041_client"+"'", TempTags, "", 2, "HLP_RwdMasterPage.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 47,'',true,'',0)\"";
            ClassString = "Button";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttSociospremiados_Internalname, "", "SociosPremiados", bttSociospremiados_Jsonclick, 5, "SociosPremiados", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",true,"+"'"+"ESOCIOSPREMIADOS_MPAGE."+"'", TempTags, "", context.GetButtonType( ), "HLP_RwdMasterPage.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_12_042e( true) ;
         }
         else
         {
            wb_table1_12_042e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
      }

      public override String getresponse( String sGXDynURL )
      {
         initialize_properties( ) ;
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         sDynURL = sGXDynURL;
         nGotPars = (short)(1);
         nGXWrapped = (short)(1);
         context.SetWrapped(true);
         PA042( ) ;
         WS042( ) ;
         WE042( ) ;
         this.cleanup();
         context.SetWrapped(false);
         context.GX_msglist = BackMsgLst;
         return "";
      }

      public void responsestatic( String sGXDynURL )
      {
      }

      public override void master_styles( )
      {
         define_styles( ) ;
      }

      protected void define_styles( )
      {
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?"+GetCacheInvalidationToken( ), true);
         if ( ! ( WebComp_Wcrecentlinks == null ) )
         {
            if ( StringUtil.Len( WebComp_Wcrecentlinks_Component) != 0 )
            {
               WebComp_Wcrecentlinks.componentthemes();
            }
         }
         bool outputEnabled = isOutputEnabled( ) ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         idxLst = 1;
         while ( idxLst <= (getDataAreaObject() == null ? Form : getDataAreaObject().GetForm()).Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)(getDataAreaObject() == null ? Form : getDataAreaObject().GetForm()).Jscriptsrc.Item(idxLst))), "?20194122164546", true);
            idxLst = (int)(idxLst+1);
         }
         if ( ! outputEnabled )
         {
            if ( context.isSpaRequest( ) )
            {
               disableOutput();
            }
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("rwdmasterpage.js", "?20194122164548", false);
         /* End function include_jscripts */
      }

      protected void init_web_controls( )
      {
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         lblApplicationheader_Internalname = "APPLICATIONHEADER_MPAGE";
         divHeader_Internalname = "HEADER_MPAGE";
         bttSociospormonto_Internalname = "SOCIOSPORMONTO_MPAGE";
         bttProfesoractividad_Internalname = "PROFESORACTIVIDAD_MPAGE";
         bttSociosdeunaclase_Internalname = "SOCIOSDEUNACLASE_MPAGE";
         bttActividadesdeportivas_Internalname = "ACTIVIDADESDEPORTIVAS_MPAGE";
         bttActividadprofesores_Internalname = "ACTIVIDADPROFESORES_MPAGE";
         bttGraficaprofesoractividad_Internalname = "GRAFICAPROFESORACTIVIDAD_MPAGE";
         bttSociosparaserpremiados_Internalname = "SOCIOSPARASERPREMIADOS_MPAGE";
         bttSocios_Internalname = "SOCIOS_MPAGE";
         bttClases_Internalname = "CLASES_MPAGE";
         bttProfesores_Internalname = "PROFESORES_MPAGE";
         bttActividades_Internalname = "ACTIVIDADES_MPAGE";
         bttCarnets_Internalname = "CARNETS_MPAGE";
         bttMenudebug_Internalname = "MENUDEBUG_MPAGE";
         bttSociospremiados_Internalname = "SOCIOSPREMIADOS_MPAGE";
         tblTable1_Internalname = "TABLE1_MPAGE";
         divRecent_Internalname = "RECENT_MPAGE";
         divContent_Internalname = "CONTENT_MPAGE";
         divMaintable_Internalname = "MAINTABLE_MPAGE";
         (getDataAreaObject() == null ? Form : getDataAreaObject().GetForm()).Internalname = "FORM_MPAGE";
      }

      public override void initialize_properties( )
      {
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_default_properties( ) ;
         Contentholder.setDataArea(getDataAreaObject());
         if ( context.isSpaRequest( ) )
         {
            enableJsOutput();
         }
      }

      public override bool SupportAjaxEvent( )
      {
         return true ;
      }

      public override void InitializeDynEvents( )
      {
         setEventMetadata("REFRESH_MPAGE","{handler:'Refresh',iparms:[{ctrl:'FORM_MPAGE',prop:'Caption'}]");
         setEventMetadata("REFRESH_MPAGE",",oparms:[{ctrl:'WCRECENTLINKS_MPAGE'}]}");
         setEventMetadata("SOCIOS_MPAGE","{handler:'E22041',iparms:[]");
         setEventMetadata("SOCIOS_MPAGE",",oparms:[]}");
         setEventMetadata("PROFESORES_MPAGE","{handler:'E24041',iparms:[]");
         setEventMetadata("PROFESORES_MPAGE",",oparms:[]}");
         setEventMetadata("CLASES_MPAGE","{handler:'E23041',iparms:[]");
         setEventMetadata("CLASES_MPAGE",",oparms:[]}");
         setEventMetadata("ACTIVIDADES_MPAGE","{handler:'E25041',iparms:[]");
         setEventMetadata("ACTIVIDADES_MPAGE",",oparms:[]}");
         setEventMetadata("CARNETS_MPAGE","{handler:'E26041',iparms:[]");
         setEventMetadata("CARNETS_MPAGE",",oparms:[]}");
         setEventMetadata("SOCIOSPORMONTO_MPAGE","{handler:'E13042',iparms:[]");
         setEventMetadata("SOCIOSPORMONTO_MPAGE",",oparms:[]}");
         setEventMetadata("PROFESORACTIVIDAD_MPAGE","{handler:'E14042',iparms:[]");
         setEventMetadata("PROFESORACTIVIDAD_MPAGE",",oparms:[]}");
         setEventMetadata("MENUDEBUG_MPAGE","{handler:'E27041',iparms:[]");
         setEventMetadata("MENUDEBUG_MPAGE",",oparms:[]}");
         setEventMetadata("SOCIOSDEUNACLASE_MPAGE","{handler:'E15042',iparms:[]");
         setEventMetadata("SOCIOSDEUNACLASE_MPAGE",",oparms:[]}");
         setEventMetadata("ACTIVIDADESDEPORTIVAS_MPAGE","{handler:'E19041',iparms:[]");
         setEventMetadata("ACTIVIDADESDEPORTIVAS_MPAGE",",oparms:[]}");
         setEventMetadata("ACTIVIDADPROFESORES_MPAGE","{handler:'E20041',iparms:[]");
         setEventMetadata("ACTIVIDADPROFESORES_MPAGE",",oparms:[]}");
         setEventMetadata("GRAFICAPROFESORACTIVIDAD_MPAGE","{handler:'E21041',iparms:[]");
         setEventMetadata("GRAFICAPROFESORACTIVIDAD_MPAGE",",oparms:[]}");
         setEventMetadata("SOCIOSPREMIADOS_MPAGE","{handler:'E16042',iparms:[]");
         setEventMetadata("SOCIOSPREMIADOS_MPAGE",",oparms:[]}");
         setEventMetadata("SOCIOSPARASERPREMIADOS_MPAGE","{handler:'E17042',iparms:[]");
         setEventMetadata("SOCIOSPARASERPREMIADOS_MPAGE",",oparms:[]}");
         return  ;
      }

      public override void cleanup( )
      {
         flushBuffer();
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         Contentholder = new GXDataAreaControl();
         GXKey = "";
         sPrefix = "";
         lblApplicationheader_Jsonclick = "";
         WebComp_Wcrecentlinks_Component = "";
         OldWcrecentlinks = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         sStyleString = "";
         TempTags = "";
         ClassString = "";
         StyleString = "";
         bttSociospormonto_Jsonclick = "";
         bttProfesoractividad_Jsonclick = "";
         bttSociosdeunaclase_Jsonclick = "";
         bttActividadesdeportivas_Jsonclick = "";
         bttActividadprofesores_Jsonclick = "";
         bttGraficaprofesoractividad_Jsonclick = "";
         bttSociosparaserpremiados_Jsonclick = "";
         bttSocios_Jsonclick = "";
         bttClases_Jsonclick = "";
         bttProfesores_Jsonclick = "";
         bttActividades_Jsonclick = "";
         bttCarnets_Jsonclick = "";
         bttMenudebug_Jsonclick = "";
         bttSociospremiados_Jsonclick = "";
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sDynURL = "";
         Form = new GXWebForm();
         WebComp_Wcrecentlinks = new GeneXus.Http.GXNullWebComponent();
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short initialized ;
      private short GxWebError ;
      private short wbEnd ;
      private short wbStart ;
      private short nCmpId ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short nGotPars ;
      private short nGXWrapped ;
      private int idxLst ;
      private String GXKey ;
      private String sPrefix ;
      private String divMaintable_Internalname ;
      private String divHeader_Internalname ;
      private String lblApplicationheader_Internalname ;
      private String lblApplicationheader_Jsonclick ;
      private String divRecent_Internalname ;
      private String WebComp_Wcrecentlinks_Component ;
      private String OldWcrecentlinks ;
      private String divContent_Internalname ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String sStyleString ;
      private String tblTable1_Internalname ;
      private String TempTags ;
      private String ClassString ;
      private String StyleString ;
      private String bttSociospormonto_Internalname ;
      private String bttSociospormonto_Jsonclick ;
      private String bttProfesoractividad_Internalname ;
      private String bttProfesoractividad_Jsonclick ;
      private String bttSociosdeunaclase_Internalname ;
      private String bttSociosdeunaclase_Jsonclick ;
      private String bttActividadesdeportivas_Internalname ;
      private String bttActividadesdeportivas_Jsonclick ;
      private String bttActividadprofesores_Internalname ;
      private String bttActividadprofesores_Jsonclick ;
      private String bttGraficaprofesoractividad_Internalname ;
      private String bttGraficaprofesoractividad_Jsonclick ;
      private String bttSociosparaserpremiados_Internalname ;
      private String bttSociosparaserpremiados_Jsonclick ;
      private String bttSocios_Internalname ;
      private String bttSocios_Jsonclick ;
      private String bttClases_Internalname ;
      private String bttClases_Jsonclick ;
      private String bttProfesores_Internalname ;
      private String bttProfesores_Jsonclick ;
      private String bttActividades_Internalname ;
      private String bttActividades_Jsonclick ;
      private String bttCarnets_Internalname ;
      private String bttCarnets_Jsonclick ;
      private String bttMenudebug_Internalname ;
      private String bttMenudebug_Jsonclick ;
      private String bttSociospremiados_Internalname ;
      private String bttSociospremiados_Jsonclick ;
      private String sDynURL ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool toggleJsOutput ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private GXWebComponent WebComp_Wcrecentlinks ;
      private IGxDataStore dsDefault ;
      private GXDataAreaControl Contentholder ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXWebForm Form ;
   }

}
