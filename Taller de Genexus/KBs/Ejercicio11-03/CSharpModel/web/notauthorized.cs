/*
               File: NotAuthorized
        Description: Not Authorized web panel
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 3/14/2019 20:7:4.73
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
   public class notauthorized : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public notauthorized( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public notauthorized( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( String aP0_GxObject )
      {
         this.GxObject = aP0_GxObject;
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
         if ( nGotPars == 0 )
         {
            entryPointCalled = false;
            gxfirstwebparm = GetNextPar( );
            gxfirstwebparm_bkp = gxfirstwebparm;
            gxfirstwebparm = DecryptAjaxCall( gxfirstwebparm);
            if ( context.isSpaRequest( ) )
            {
               disableJsOutput();
            }
            if ( StringUtil.StrCmp(gxfirstwebparm, "dyncall") == 0 )
            {
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               dyncall( GetNextPar( )) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxEvt") == 0 )
            {
               setAjaxEventMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxfirstwebparm = GetNextPar( );
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxfullajaxEvt") == 0 )
            {
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxfirstwebparm = GetNextPar( );
            }
            else
            {
               if ( ! IsValidAjaxCall( false) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxfirstwebparm = gxfirstwebparm_bkp;
            }
            if ( ! entryPointCalled && ! ( isAjaxCallMode( ) || isFullAjaxMode( ) ) )
            {
               GxObject = gxfirstwebparm;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GxObject", GxObject);
            }
            if ( context.isSpaRequest( ) )
            {
               enableJsOutput();
            }
         }
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
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
            MasterPageObj = (GXMasterPage) ClassLoader.GetInstance("rwdmasterpage", "GeneXus.Programs.rwdmasterpage", new Object[] {new GxContext( context.handle, context.DataStores, context.HttpContext)});
            MasterPageObj.setDataArea(this,false);
            ValidateSpaRequest();
            MasterPageObj.webExecute();
            if ( ( GxWebError == 0 ) && context.isAjaxRequest( ) )
            {
               enableOutput();
               if ( ! context.isAjaxRequest( ) )
               {
                  context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
               }
               if ( ! context.WillRedirect( ) )
               {
                  context.GX_webresponse.AddString((String)(context.getJSONResponse( )));
               }
               else
               {
                  if ( context.isAjaxRequest( ) )
                  {
                     disableOutput();
                  }
                  RenderHtmlHeaders( ) ;
                  context.Redirect( context.wjLoc );
                  context.DispatchAjaxCommands();
               }
            }
         }
         this.cleanup();
      }

      public override short ExecuteStartEvent( )
      {
         PA0D2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START0D2( ) ;
         }
         return gxajaxcallmode ;
      }

      public override void RenderHtmlHeaders( )
      {
         GxWebStd.gx_html_headers( context, 0, "", "", Form.Meta, Form.Metaequiv, false);
      }

      public override void RenderHtmlOpenForm( )
      {
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.WriteHtmlText( "<title>") ;
         context.SendWebValue( Form.Caption) ;
         context.WriteHtmlTextNl( "</title>") ;
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         if ( StringUtil.Len( sDynURL) > 0 )
         {
            context.WriteHtmlText( "<BASE href=\""+sDynURL+"\" />") ;
         }
         define_styles( ) ;
         if ( nGXWrapped != 1 )
         {
            MasterPageObj.master_styles();
         }
         if ( ( ( context.GetBrowserType( ) == 1 ) || ( context.GetBrowserType( ) == 5 ) ) && ( StringUtil.StrCmp(context.GetBrowserVersion( ), "7.0") == 0 ) )
         {
            context.AddJavascriptSource("json2.js", "?"+context.GetBuildNumber( 126726), false);
         }
         context.AddJavascriptSource("jquery.js", "?"+context.GetBuildNumber( 126726), false);
         context.AddJavascriptSource("gxtimezone.js", "?"+context.GetBuildNumber( 126726), false);
         context.AddJavascriptSource("gxgral.js", "?"+context.GetBuildNumber( 126726), false);
         context.AddJavascriptSource("gxcfg.js", "?2019314207475", false);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.WriteHtmlText( Form.Headerrawhtml) ;
         context.CloseHtmlHeader();
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         FormProcess = " data-HasEnter=\"false\" data-Skiponenter=\"false\"";
         context.WriteHtmlText( "<body ") ;
         bodyStyle = "" + "background-color:" + context.BuildHTMLColor( Form.Backcolor) + ";color:" + context.BuildHTMLColor( Form.Textcolor) + ";";
         if ( nGXWrapped == 0 )
         {
            bodyStyle = bodyStyle + "-moz-opacity:0;opacity:0;";
         }
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( Form.Background)) ) )
         {
            bodyStyle = bodyStyle + " background-image:url(" + context.convertURL( Form.Background) + ")";
         }
         context.WriteHtmlText( " "+"class=\"Form\""+" "+ "style='"+bodyStyle+"'") ;
         context.WriteHtmlText( FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"Form\" data-gx-class=\"Form\" novalidate action=\""+formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(GxObject))+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
         context.WriteHtmlText( "<input type=\"submit\" style=\"display:none\">") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Class", "Form", true);
         toggleJsOutput = isJsOutputEnabled( );
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
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
         GxWebStd.gx_hidden_field( context, "vGXOBJECT", GxObject);
      }

      public override void RenderHtmlCloseForm( )
      {
         SendCloseFormHiddens( ) ;
         GxWebStd.gx_hidden_field( context, "GX_FocusControl", GX_FocusControl);
         SendAjaxEncryptionKey();
         SendSecurityToken((String)(sPrefix));
         SendComponentObjects();
         SendServerCommands();
         SendState();
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         context.WriteHtmlTextNl( "</form>") ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         include_jscripts( ) ;
         if ( ! ( WebComp_Headerbc == null ) )
         {
            WebComp_Headerbc.componentjscripts();
         }
         if ( ! ( WebComp_Recentlinks == null ) )
         {
            WebComp_Recentlinks.componentjscripts();
         }
      }

      public override void RenderHtmlContent( )
      {
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            context.WriteHtmlText( "<div") ;
            GxWebStd.ClassAttribute( context, "gx-ct-body"+" "+(String.IsNullOrEmpty(StringUtil.RTrim( Form.Class)) ? "Form" : Form.Class)+"-fx");
            context.WriteHtmlText( ">") ;
            WE0D2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT0D2( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return false ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(GxObject)) ;
      }

      public override String GetPgmname( )
      {
         return "NotAuthorized" ;
      }

      public override String GetPgmdesc( )
      {
         return "Not Authorized web panel" ;
      }

      protected void WB0D0( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! wbLoad )
         {
            if ( nGXWrapped == 1 )
            {
               RenderHtmlHeaders( ) ;
               RenderHtmlOpenForm( ) ;
            }
            if ( ! isFullAjaxMode( ) )
            {
               /* WebComponent */
               GxWebStd.gx_hidden_field( context, "W0002"+"", StringUtil.RTrim( WebComp_Headerbc_Component));
               context.WriteHtmlText( "<div") ;
               GxWebStd.ClassAttribute( context, "gxwebcomponent");
               context.WriteHtmlText( " id=\""+"gxHTMLWrpW0002"+""+"\""+"") ;
               context.WriteHtmlText( ">") ;
               if ( StringUtil.StrCmp(StringUtil.Lower( OldHeaderbc), StringUtil.Lower( WebComp_Headerbc_Component)) != 0 )
               {
                  context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0002"+"");
               }
               WebComp_Headerbc.componentdraw();
               if ( StringUtil.StrCmp(StringUtil.Lower( OldHeaderbc), StringUtil.Lower( WebComp_Headerbc_Component)) != 0 )
               {
                  context.httpAjaxContext.ajax_rspEndCmp();
               }
               context.WriteHtmlText( "</div>") ;
            }
            if ( ! isFullAjaxMode( ) )
            {
               /* WebComponent */
               GxWebStd.gx_hidden_field( context, "W0003"+"", StringUtil.RTrim( WebComp_Recentlinks_Component));
               context.WriteHtmlText( "<div") ;
               GxWebStd.ClassAttribute( context, "gxwebcomponent");
               context.WriteHtmlText( " id=\""+"gxHTMLWrpW0003"+""+"\""+"") ;
               context.WriteHtmlText( ">") ;
               if ( StringUtil.Len( WebComp_Recentlinks_Component) != 0 )
               {
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldRecentlinks), StringUtil.Lower( WebComp_Recentlinks_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0003"+"");
                  }
                  WebComp_Recentlinks.componentdraw();
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldRecentlinks), StringUtil.Lower( WebComp_Recentlinks_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspEndCmp();
                  }
               }
               context.WriteHtmlText( "</div>") ;
            }
            wb_table1_4_0D2( true) ;
         }
         else
         {
            wb_table1_4_0D2( false) ;
         }
         return  ;
      }

      protected void wb_table1_4_0D2e( bool wbgen )
      {
         if ( wbgen )
         {
            wb_table2_13_0D2( true) ;
         }
         else
         {
            wb_table2_13_0D2( false) ;
         }
         return  ;
      }

      protected void wb_table2_13_0D2e( bool wbgen )
      {
         if ( wbgen )
         {
            wb_table3_16_0D2( true) ;
         }
         else
         {
            wb_table3_16_0D2( false) ;
         }
         return  ;
      }

      protected void wb_table3_16_0D2e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         wbLoad = true;
      }

      protected void START0D2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 15_0_12-126726", 0) ;
            Form.Meta.addItem("description", "Not Authorized web panel", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP0D0( ) ;
      }

      protected void WS0D2( )
      {
         START0D2( ) ;
         EVT0D2( ) ;
      }

      protected void EVT0D2( )
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
                  if ( StringUtil.StrCmp(sEvtType, "M") != 0 )
                  {
                     if ( StringUtil.StrCmp(sEvtType, "E") == 0 )
                     {
                        sEvtType = StringUtil.Right( sEvt, 1);
                        if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                        {
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                           if ( StringUtil.StrCmp(sEvt, "RFR") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                           }
                           else if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: Start */
                              E110D2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: Load */
                              E120D2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
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
                     else if ( StringUtil.StrCmp(sEvtType, "W") == 0 )
                     {
                        sEvtType = StringUtil.Left( sEvt, 4);
                        sEvt = StringUtil.Right( sEvt, (short)(StringUtil.Len( sEvt)-4));
                        nCmpId = (short)(NumberUtil.Val( sEvtType, "."));
                        if ( nCmpId == 2 )
                        {
                           OldHeaderbc = cgiGet( "W0002");
                           if ( ( StringUtil.Len( OldHeaderbc) == 0 ) || ( StringUtil.StrCmp(OldHeaderbc, WebComp_Headerbc_Component) != 0 ) )
                           {
                              WebComp_Headerbc = getWebComponent(GetType(), "GeneXus.Programs", OldHeaderbc, new Object[] {context} );
                              WebComp_Headerbc.ComponentInit();
                              WebComp_Headerbc.Name = "OldHeaderbc";
                              WebComp_Headerbc_Component = OldHeaderbc;
                           }
                           WebComp_Headerbc.componentprocess("W0002", "", sEvt);
                           WebComp_Headerbc_Component = OldHeaderbc;
                        }
                        else if ( nCmpId == 3 )
                        {
                           OldRecentlinks = cgiGet( "W0003");
                           if ( ( StringUtil.Len( OldRecentlinks) == 0 ) || ( StringUtil.StrCmp(OldRecentlinks, WebComp_Recentlinks_Component) != 0 ) )
                           {
                              WebComp_Recentlinks = getWebComponent(GetType(), "GeneXus.Programs", OldRecentlinks, new Object[] {context} );
                              WebComp_Recentlinks.ComponentInit();
                              WebComp_Recentlinks.Name = "OldRecentlinks";
                              WebComp_Recentlinks_Component = OldRecentlinks;
                           }
                           if ( StringUtil.Len( WebComp_Recentlinks_Component) != 0 )
                           {
                              WebComp_Recentlinks.componentprocess("W0003", "", sEvt);
                           }
                           WebComp_Recentlinks_Component = OldRecentlinks;
                        }
                     }
                     context.wbHandled = 1;
                  }
               }
            }
         }
      }

      protected void WE0D2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               if ( nGXWrapped == 1 )
               {
                  RenderHtmlCloseForm( ) ;
               }
            }
         }
      }

      protected void PA0D2( )
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
         RF0D2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV8Pgmname = "NotAuthorized";
         context.Gx_err = 0;
      }

      protected void RF0D2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            if ( 1 != 0 )
            {
               WebComp_Headerbc.componentstart();
            }
         }
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            if ( 1 != 0 )
            {
               if ( StringUtil.Len( WebComp_Recentlinks_Component) != 0 )
               {
                  WebComp_Recentlinks.componentstart();
               }
            }
         }
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            /* Execute user event: Load */
            E120D2 ();
            WB0D0( ) ;
         }
      }

      protected void send_integrity_lvl_hashes0D2( )
      {
      }

      protected void STRUP0D0( )
      {
         /* Before Start, stand alone formulas. */
         AV8Pgmname = "NotAuthorized";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E110D2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            /* Read saved values. */
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
         E110D2 ();
         if (returnInSub) return;
      }

      protected void E110D2( )
      {
         /* Start Routine */
         /* Object Property */
         if ( StringUtil.StrCmp(StringUtil.Lower( WebComp_Recentlinks_Component), StringUtil.Lower( "RecentLinks")) != 0 )
         {
            WebComp_Recentlinks = getWebComponent(GetType(), "GeneXus.Programs", "recentlinks", new Object[] {context} );
            WebComp_Recentlinks.ComponentInit();
            WebComp_Recentlinks.Name = "RecentLinks";
            WebComp_Recentlinks_Component = "RecentLinks";
         }
         if ( StringUtil.Len( WebComp_Recentlinks_Component) != 0 )
         {
            WebComp_Recentlinks.setjustcreated();
            WebComp_Recentlinks.componentprepare(new Object[] {(String)"W0003",(String)"",(String)"Not Authorized",(String)AV8Pgmname});
            WebComp_Recentlinks.componentbind(new Object[] {(String)"",(String)""});
         }
         GX_msglist.addItem("You are not authorized to do this action");
      }

      protected void nextLoad( )
      {
      }

      protected void E120D2( )
      {
         /* Load Routine */
      }

      protected void wb_table3_16_0D2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTable3_Internalname, tblTable3_Internalname, "", "TableHorizontalLine", 0, "", "", 1, 2, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_16_0D2e( true) ;
         }
         else
         {
            wb_table3_16_0D2e( false) ;
         }
      }

      protected void wb_table2_13_0D2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTable2_Internalname, tblTable2_Internalname, "", "HorizontalSpace", 0, "", "", 1, 2, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_13_0D2e( true) ;
         }
         else
         {
            wb_table2_13_0D2e( false) ;
         }
      }

      protected void wb_table1_4_0D2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTable1_Internalname, tblTable1_Internalname, "", "ViewTable", 0, "", "", 1, 2, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td colspan=\"2\" >") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTitletext_Internalname, "Not Authorized", "", "", lblTitletext_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "SubTitle", 0, "", 1, 1, 0, "HLP_NotAuthorized.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td colspan=\"2\" >") ;
            ClassString = "ErrorViewer";
            StyleString = "";
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, "", "false");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td colspan=\"2\" >") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_4_0D2e( true) ;
         }
         else
         {
            wb_table1_4_0D2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         GxObject = (String)getParm(obj,0);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GxObject", GxObject);
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
         PA0D2( ) ;
         WS0D2( ) ;
         WE0D2( ) ;
         this.cleanup();
         context.SetWrapped(false);
         context.GX_msglist = BackMsgLst;
         return "";
      }

      public void responsestatic( String sGXDynURL )
      {
      }

      protected void define_styles( )
      {
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?"+GetCacheInvalidationToken( ), false);
         if ( ! ( WebComp_Headerbc == null ) )
         {
            WebComp_Headerbc.componentthemes();
         }
         if ( ! ( WebComp_Recentlinks == null ) )
         {
            if ( StringUtil.Len( WebComp_Recentlinks_Component) != 0 )
            {
               WebComp_Recentlinks.componentthemes();
            }
         }
         bool outputEnabled = isOutputEnabled( ) ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2019314207486", true);
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
         context.AddJavascriptSource("messages.eng.js", "?"+GetCacheInvalidationToken( ), false);
         context.AddJavascriptSource("notauthorized.js", "?2019314207486", false);
         /* End function include_jscripts */
      }

      protected void init_web_controls( )
      {
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         lblTitletext_Internalname = "TITLETEXT";
         tblTable1_Internalname = "TABLE1";
         tblTable2_Internalname = "TABLE2";
         tblTable3_Internalname = "TABLE3";
         Form.Internalname = "FORM";
      }

      public override void initialize_properties( )
      {
         context.SetDefaultTheme("Carmine");
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_default_properties( ) ;
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Not Authorized web panel";
         context.GX_msglist.DisplayMode = 1;
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[]");
         setEventMetadata("REFRESH",",oparms:[]}");
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
         wcpOGxObject = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GXKey = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         WebComp_Headerbc_Component = "";
         OldHeaderbc = "";
         WebComp_Recentlinks_Component = "";
         OldRecentlinks = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV8Pgmname = "";
         sStyleString = "";
         lblTitletext_Jsonclick = "";
         ClassString = "";
         StyleString = "";
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         WebComp_Headerbc = new GeneXus.Http.GXNullWebComponent();
         WebComp_Recentlinks = new GeneXus.Http.GXNullWebComponent();
         AV8Pgmname = "NotAuthorized";
         /* GeneXus formulas. */
         AV8Pgmname = "NotAuthorized";
         context.Gx_err = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short nCmpId ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short nGXWrapped ;
      private int idxLst ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GXKey ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String WebComp_Headerbc_Component ;
      private String OldHeaderbc ;
      private String WebComp_Recentlinks_Component ;
      private String OldRecentlinks ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String AV8Pgmname ;
      private String sStyleString ;
      private String tblTable3_Internalname ;
      private String tblTable2_Internalname ;
      private String tblTable1_Internalname ;
      private String lblTitletext_Internalname ;
      private String lblTitletext_Jsonclick ;
      private String ClassString ;
      private String StyleString ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private String GxObject ;
      private String wcpOGxObject ;
      private GXWebComponent WebComp_Headerbc ;
      private GXWebComponent WebComp_Recentlinks ;
      private IGxDataStore dsDefault ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXWebForm Form ;
   }

}
