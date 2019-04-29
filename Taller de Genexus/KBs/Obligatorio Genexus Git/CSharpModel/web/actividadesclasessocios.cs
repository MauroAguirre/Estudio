/*
               File: ActividadesClasesSocios
        Description: Actividades Clases Socios
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 4/12/2019 18:46:41.60
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
   public class actividadesclasessocios : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public actividadesclasessocios( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public actividadesclasessocios( IGxContext context )
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
         dynavSeleccionactividad = new GXCombobox();
         cmbavSeleccionclases = new GXCombobox();
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
         PA1F2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START1F2( ) ;
         }
         return gxajaxcallmode ;
      }

      public override void RenderHtmlHeaders( )
      {
         GxWebStd.gx_html_headers( context, 0, "", "", Form.Meta, Form.Metaequiv, true);
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
         context.AddJavascriptSource("bootstrap/js/bootstrap.min.js", "?"+context.GetBuildNumber( 126726), false);
         context.AddJavascriptSource("gxcfg.js", "?201941218464162", false);
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
         context.WriteHtmlText( " "+"class=\"form-horizontal Form\""+" "+ "style='"+bodyStyle+"'") ;
         context.WriteHtmlText( FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("actividadesclasessocios.aspx") +"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
         context.WriteHtmlText( "<input type=\"submit\" style=\"display:none\">") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Class", "form-horizontal Form", true);
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
         GxWebStd.gx_hidden_field( context, "ACTIVIDADID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A1ActividadId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "CLASEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A3ClaseId), 4, 0, ".", "")));
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
      }

      public override void RenderHtmlContent( )
      {
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            context.WriteHtmlText( "<div") ;
            GxWebStd.ClassAttribute( context, "gx-ct-body"+" "+(String.IsNullOrEmpty(StringUtil.RTrim( Form.Class)) ? "form-horizontal Form" : Form.Class)+"-fx");
            context.WriteHtmlText( ">") ;
            WE1F2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT1F2( ) ;
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
         return formatLink("actividadesclasessocios.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "ActividadesClasesSocios" ;
      }

      public override String GetPgmdesc( )
      {
         return "Actividades Clases Socios" ;
      }

      protected void WB1F0( )
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
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, "", "", "", "false");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divMaintable_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 6,'',false,'',0)\"";
            ClassString = "Button";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttMostrar_Internalname, "", "Mostrar", bttMostrar_Jsonclick, 5, "Mostrar", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'MOSTRAR\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_ActividadesClasesSocios.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+dynavSeleccionactividad_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynavSeleccionactividad_Internalname, "Actividad Id", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 11,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynavSeleccionactividad, dynavSeleccionactividad_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(AV5SeleccionActividad), 4, 0)), 1, dynavSeleccionactividad_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", 1, dynavSeleccionactividad.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,11);\"", "", true, "HLP_ActividadesClasesSocios.htm");
            dynavSeleccionactividad.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV5SeleccionActividad), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavSeleccionactividad_Internalname, "Values", (String)(dynavSeleccionactividad.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbavSeleccionclases_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavSeleccionclases_Internalname, "Clase Id", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavSeleccionclases, cmbavSeleccionclases_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(AV6SeleccionClases), 4, 0)), 1, cmbavSeleccionclases_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", 1, cmbavSeleccionclases.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,16);\"", "", true, "HLP_ActividadesClasesSocios.htm");
            cmbavSeleccionclases.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV6SeleccionClases), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavSeleccionclases_Internalname, "Values", (String)(cmbavSeleccionclases.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         wbLoad = true;
      }

      protected void START1F2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 15_0_12-126726", 0) ;
            Form.Meta.addItem("description", "Actividades Clases Socios", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP1F0( ) ;
      }

      protected void WS1F2( )
      {
         START1F2( ) ;
         EVT1F2( ) ;
      }

      protected void EVT1F2( )
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
                           else if ( StringUtil.StrCmp(sEvt, "VSELECCIONACTIVIDAD.CONTROLVALUECHANGED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E111F2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'MOSTRAR'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'Mostrar' */
                              E121F2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: Start */
                              E131F2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: Load */
                              E141F2 ();
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
                     context.wbHandled = 1;
                  }
               }
            }
         }
      }

      protected void WE1F2( )
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

      protected void PA1F2( )
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
               GX_FocusControl = dynavSeleccionactividad_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            nDonePA = 1;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void GXDLVvSELECCIONACTIVIDAD1F1( )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLVvSELECCIONACTIVIDAD_data1F1( ) ;
         gxdynajaxindex = 1;
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            context.GX_webresponse.AddString(gxwrpcisep+"{\"c\":\""+GXUtil.EncodeJSConstant( ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex)))+"\",\"d\":\""+GXUtil.EncodeJSConstant( ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)))+"\"}");
            gxdynajaxindex = (int)(gxdynajaxindex+1);
            gxwrpcisep = ",";
         }
         context.GX_webresponse.AddString("]");
         if ( gxdynajaxctrlcodr.Count == 0 )
         {
            context.GX_webresponse.AddString(",101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GXVvSELECCIONACTIVIDAD_html1F1( )
      {
         short gxdynajaxvalue ;
         GXDLVvSELECCIONACTIVIDAD_data1F1( ) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynavSeleccionactividad.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = (short)(NumberUtil.Val( ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex)), "."));
            dynavSeleccionactividad.addItem(StringUtil.Trim( StringUtil.Str( (decimal)(gxdynajaxvalue), 4, 0)), ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLVvSELECCIONACTIVIDAD_data1F1( )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         /* Using cursor H001F2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(H001F2_A1ActividadId[0]), 4, 0, ".", "")));
            gxdynajaxctrldescr.Add(StringUtil.RTrim( H001F2_A13ActividadDescripcion[0]));
            pr_default.readNext(0);
         }
         pr_default.close(0);
      }

      protected void send_integrity_hashes( )
      {
      }

      protected void clear_multi_value_controls( )
      {
         if ( context.isAjaxRequest( ) )
         {
            dynavSeleccionactividad.Name = "vSELECCIONACTIVIDAD";
            dynavSeleccionactividad.WebTags = "";
            dynavSeleccionactividad.removeAllItems();
            /* Using cursor H001F3 */
            pr_default.execute(1);
            while ( (pr_default.getStatus(1) != 101) )
            {
               dynavSeleccionactividad.addItem(StringUtil.Trim( StringUtil.Str( (decimal)(H001F3_A1ActividadId[0]), 4, 0)), H001F3_A13ActividadDescripcion[0], 0);
               pr_default.readNext(1);
            }
            pr_default.close(1);
            if ( dynavSeleccionactividad.ItemCount > 0 )
            {
               AV5SeleccionActividad = (short)(NumberUtil.Val( dynavSeleccionactividad.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV5SeleccionActividad), 4, 0))), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5SeleccionActividad", StringUtil.LTrim( StringUtil.Str( (decimal)(AV5SeleccionActividad), 4, 0)));
            }
            dynload_actions( ) ;
         }
      }

      protected void fix_multi_value_controls( )
      {
         if ( dynavSeleccionactividad.ItemCount > 0 )
         {
            AV5SeleccionActividad = (short)(NumberUtil.Val( dynavSeleccionactividad.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV5SeleccionActividad), 4, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5SeleccionActividad", StringUtil.LTrim( StringUtil.Str( (decimal)(AV5SeleccionActividad), 4, 0)));
         }
         if ( context.isAjaxRequest( ) )
         {
            dynavSeleccionactividad.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV5SeleccionActividad), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavSeleccionactividad_Internalname, "Values", dynavSeleccionactividad.ToJavascriptSource(), true);
         }
         if ( cmbavSeleccionclases.ItemCount > 0 )
         {
            AV6SeleccionClases = (short)(NumberUtil.Val( cmbavSeleccionclases.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV6SeleccionClases), 4, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6SeleccionClases", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6SeleccionClases), 4, 0)));
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavSeleccionclases.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV6SeleccionClases), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavSeleccionclases_Internalname, "Values", cmbavSeleccionclases.ToJavascriptSource(), true);
         }
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF1F2( ) ;
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

      protected void RF1F2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            /* Execute user event: Load */
            E141F2 ();
            WB1F0( ) ;
         }
      }

      protected void send_integrity_lvl_hashes1F2( )
      {
      }

      protected void STRUP1F0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E131F2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            dynavSeleccionactividad.CurrentValue = cgiGet( dynavSeleccionactividad_Internalname);
            AV5SeleccionActividad = (short)(NumberUtil.Val( cgiGet( dynavSeleccionactividad_Internalname), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5SeleccionActividad", StringUtil.LTrim( StringUtil.Str( (decimal)(AV5SeleccionActividad), 4, 0)));
            cmbavSeleccionclases.CurrentValue = cgiGet( cmbavSeleccionclases_Internalname);
            AV6SeleccionClases = (short)(NumberUtil.Val( cgiGet( cmbavSeleccionclases_Internalname), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6SeleccionClases", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6SeleccionClases), 4, 0)));
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

      protected void E111F2( )
      {
         /* Seleccionactividad_Controlvaluechanged Routine */
         cmbavSeleccionclases.removeAllItems();
         /* Using cursor H001F4 */
         pr_default.execute(2, new Object[] {AV5SeleccionActividad});
         while ( (pr_default.getStatus(2) != 101) )
         {
            A2ProfesorId = H001F4_A2ProfesorId[0];
            A1ActividadId = H001F4_A1ActividadId[0];
            A3ClaseId = H001F4_A3ClaseId[0];
            A1ActividadId = H001F4_A1ActividadId[0];
            cmbavSeleccionclases.addItem(StringUtil.Trim( StringUtil.Str( (decimal)(A3ClaseId), 4, 0)), StringUtil.Str( (decimal)(A3ClaseId), 4, 0), 0);
            pr_default.readNext(2);
         }
         pr_default.close(2);
         /*  Sending Event outputs  */
         cmbavSeleccionclases.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV6SeleccionClases), 4, 0));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavSeleccionclases_Internalname, "Values", cmbavSeleccionclases.ToJavascriptSource(), true);
      }

      protected void E121F2( )
      {
         /* 'Mostrar' Routine */
         CallWebObject(formatLink("listadosociodeclase.aspx") + "?" + UrlEncode("" +AV6SeleccionClases));
         context.wjLocDisableFrm = 0;
      }

      protected void GXStart( )
      {
         /* Execute user event: Start */
         E131F2 ();
         if (returnInSub) return;
      }

      protected void E131F2( )
      {
         /* Start Routine */
         cmbavSeleccionclases.removeAllItems();
         /* Using cursor H001F5 */
         pr_default.execute(3, new Object[] {AV5SeleccionActividad});
         while ( (pr_default.getStatus(3) != 101) )
         {
            A2ProfesorId = H001F5_A2ProfesorId[0];
            A1ActividadId = H001F5_A1ActividadId[0];
            A3ClaseId = H001F5_A3ClaseId[0];
            A1ActividadId = H001F5_A1ActividadId[0];
            cmbavSeleccionclases.addItem(StringUtil.Trim( StringUtil.Str( (decimal)(A3ClaseId), 4, 0)), StringUtil.Str( (decimal)(A3ClaseId), 4, 0), 0);
            pr_default.readNext(3);
         }
         pr_default.close(3);
      }

      protected void nextLoad( )
      {
      }

      protected void E141F2( )
      {
         /* Load Routine */
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
         PA1F2( ) ;
         WS1F2( ) ;
         WE1F2( ) ;
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
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?"+GetCacheInvalidationToken( ), true);
         bool outputEnabled = isOutputEnabled( ) ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?201941218464177", true);
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
         context.AddJavascriptSource("actividadesclasessocios.js", "?201941218464177", false);
         /* End function include_jscripts */
      }

      protected void init_web_controls( )
      {
         dynavSeleccionactividad.Name = "vSELECCIONACTIVIDAD";
         dynavSeleccionactividad.WebTags = "";
         dynavSeleccionactividad.removeAllItems();
         /* Using cursor H001F6 */
         pr_default.execute(4);
         while ( (pr_default.getStatus(4) != 101) )
         {
            dynavSeleccionactividad.addItem(StringUtil.Trim( StringUtil.Str( (decimal)(H001F6_A1ActividadId[0]), 4, 0)), H001F6_A13ActividadDescripcion[0], 0);
            pr_default.readNext(4);
         }
         pr_default.close(4);
         if ( dynavSeleccionactividad.ItemCount > 0 )
         {
            AV5SeleccionActividad = (short)(NumberUtil.Val( dynavSeleccionactividad.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV5SeleccionActividad), 4, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5SeleccionActividad", StringUtil.LTrim( StringUtil.Str( (decimal)(AV5SeleccionActividad), 4, 0)));
         }
         cmbavSeleccionclases.Name = "vSELECCIONCLASES";
         cmbavSeleccionclases.WebTags = "";
         if ( cmbavSeleccionclases.ItemCount > 0 )
         {
            AV6SeleccionClases = (short)(NumberUtil.Val( cmbavSeleccionclases.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV6SeleccionClases), 4, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6SeleccionClases", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6SeleccionClases), 4, 0)));
         }
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         bttMostrar_Internalname = "MOSTRAR";
         dynavSeleccionactividad_Internalname = "vSELECCIONACTIVIDAD";
         cmbavSeleccionclases_Internalname = "vSELECCIONCLASES";
         divMaintable_Internalname = "MAINTABLE";
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
         cmbavSeleccionclases_Jsonclick = "";
         cmbavSeleccionclases.Enabled = 1;
         dynavSeleccionactividad_Jsonclick = "";
         dynavSeleccionactividad.Enabled = 1;
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Actividades Clases Socios";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'dynavSeleccionactividad'},{av:'AV5SeleccionActividad',fld:'vSELECCIONACTIVIDAD',pic:'ZZZ9'}]");
         setEventMetadata("REFRESH",",oparms:[{av:'dynavSeleccionactividad'},{av:'AV5SeleccionActividad',fld:'vSELECCIONACTIVIDAD',pic:'ZZZ9'}]}");
         setEventMetadata("VSELECCIONACTIVIDAD.CONTROLVALUECHANGED","{handler:'E111F2',iparms:[{av:'A1ActividadId',fld:'ACTIVIDADID',pic:'ZZZ9'},{av:'A3ClaseId',fld:'CLASEID',pic:'ZZZ9'},{av:'dynavSeleccionactividad'},{av:'AV5SeleccionActividad',fld:'vSELECCIONACTIVIDAD',pic:'ZZZ9'}]");
         setEventMetadata("VSELECCIONACTIVIDAD.CONTROLVALUECHANGED",",oparms:[{av:'cmbavSeleccionclases'},{av:'AV6SeleccionClases',fld:'vSELECCIONCLASES',pic:'ZZZ9'},{av:'dynavSeleccionactividad'},{av:'AV5SeleccionActividad',fld:'vSELECCIONACTIVIDAD',pic:'ZZZ9'}]}");
         setEventMetadata("'MOSTRAR'","{handler:'E121F2',iparms:[{av:'cmbavSeleccionclases'},{av:'AV6SeleccionClases',fld:'vSELECCIONCLASES',pic:'ZZZ9'},{av:'dynavSeleccionactividad'},{av:'AV5SeleccionActividad',fld:'vSELECCIONACTIVIDAD',pic:'ZZZ9'}]");
         setEventMetadata("'MOSTRAR'",",oparms:[{av:'dynavSeleccionactividad'},{av:'AV5SeleccionActividad',fld:'vSELECCIONACTIVIDAD',pic:'ZZZ9'}]}");
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
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GXKey = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         TempTags = "";
         ClassString = "";
         StyleString = "";
         bttMostrar_Jsonclick = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         gxdynajaxctrlcodr = new GeneXus.Utils.GxStringCollection();
         gxdynajaxctrldescr = new GeneXus.Utils.GxStringCollection();
         gxwrpcisep = "";
         scmdbuf = "";
         H001F2_A1ActividadId = new short[1] ;
         H001F2_A13ActividadDescripcion = new String[] {""} ;
         H001F3_A1ActividadId = new short[1] ;
         H001F3_A13ActividadDescripcion = new String[] {""} ;
         H001F4_A2ProfesorId = new short[1] ;
         H001F4_A1ActividadId = new short[1] ;
         H001F4_A3ClaseId = new short[1] ;
         H001F5_A2ProfesorId = new short[1] ;
         H001F5_A1ActividadId = new short[1] ;
         H001F5_A3ClaseId = new short[1] ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         H001F6_A1ActividadId = new short[1] ;
         H001F6_A13ActividadDescripcion = new String[] {""} ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.actividadesclasessocios__default(),
            new Object[][] {
                new Object[] {
               H001F2_A1ActividadId, H001F2_A13ActividadDescripcion
               }
               , new Object[] {
               H001F3_A1ActividadId, H001F3_A13ActividadDescripcion
               }
               , new Object[] {
               H001F4_A2ProfesorId, H001F4_A1ActividadId, H001F4_A3ClaseId
               }
               , new Object[] {
               H001F5_A2ProfesorId, H001F5_A1ActividadId, H001F5_A3ClaseId
               }
               , new Object[] {
               H001F6_A1ActividadId, H001F6_A13ActividadDescripcion
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short A1ActividadId ;
      private short A3ClaseId ;
      private short wbEnd ;
      private short wbStart ;
      private short AV5SeleccionActividad ;
      private short AV6SeleccionClases ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short A2ProfesorId ;
      private short nGXWrapped ;
      private int gxdynajaxindex ;
      private int idxLst ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GXKey ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divMaintable_Internalname ;
      private String TempTags ;
      private String ClassString ;
      private String StyleString ;
      private String bttMostrar_Internalname ;
      private String bttMostrar_Jsonclick ;
      private String dynavSeleccionactividad_Internalname ;
      private String dynavSeleccionactividad_Jsonclick ;
      private String cmbavSeleccionclases_Internalname ;
      private String cmbavSeleccionclases_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String gxwrpcisep ;
      private String scmdbuf ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrlcodr ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrldescr ;
      private IGxDataStore dsDefault ;
      private GXCombobox dynavSeleccionactividad ;
      private GXCombobox cmbavSeleccionclases ;
      private IDataStoreProvider pr_default ;
      private short[] H001F2_A1ActividadId ;
      private String[] H001F2_A13ActividadDescripcion ;
      private short[] H001F3_A1ActividadId ;
      private String[] H001F3_A13ActividadDescripcion ;
      private short[] H001F4_A2ProfesorId ;
      private short[] H001F4_A1ActividadId ;
      private short[] H001F4_A3ClaseId ;
      private short[] H001F5_A2ProfesorId ;
      private short[] H001F5_A1ActividadId ;
      private short[] H001F5_A3ClaseId ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private short[] H001F6_A1ActividadId ;
      private String[] H001F6_A13ActividadDescripcion ;
      private GXWebForm Form ;
   }

   public class actividadesclasessocios__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new ForEachCursor(def[2])
         ,new ForEachCursor(def[3])
         ,new ForEachCursor(def[4])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmH001F2 ;
          prmH001F2 = new Object[] {
          } ;
          Object[] prmH001F3 ;
          prmH001F3 = new Object[] {
          } ;
          Object[] prmH001F4 ;
          prmH001F4 = new Object[] {
          new Object[] {"@AV5SeleccionActividad",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmH001F5 ;
          prmH001F5 = new Object[] {
          new Object[] {"@AV5SeleccionActividad",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmH001F6 ;
          prmH001F6 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("H001F2", "SELECT [ActividadId], [ActividadDescripcion] FROM [Actividad1] WITH (NOLOCK) ORDER BY [ActividadDescripcion] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001F2,0,0,true,false )
             ,new CursorDef("H001F3", "SELECT [ActividadId], [ActividadDescripcion] FROM [Actividad1] WITH (NOLOCK) ORDER BY [ActividadDescripcion] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001F3,0,0,true,false )
             ,new CursorDef("H001F4", "SELECT T1.[ProfesorId], T2.[ActividadId], T1.[ClaseId] FROM ([Clase] T1 WITH (NOLOCK) INNER JOIN [Profesor] T2 WITH (NOLOCK) ON T2.[ProfesorId] = T1.[ProfesorId]) WHERE T2.[ActividadId] = @AV5SeleccionActividad ORDER BY T1.[ClaseId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001F4,100,0,false,false )
             ,new CursorDef("H001F5", "SELECT T1.[ProfesorId], T2.[ActividadId], T1.[ClaseId] FROM ([Clase] T1 WITH (NOLOCK) INNER JOIN [Profesor] T2 WITH (NOLOCK) ON T2.[ProfesorId] = T1.[ProfesorId]) WHERE T2.[ActividadId] = @AV5SeleccionActividad ORDER BY T1.[ClaseId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001F5,100,0,false,false )
             ,new CursorDef("H001F6", "SELECT [ActividadId], [ActividadDescripcion] FROM [Actividad1] WITH (NOLOCK) ORDER BY [ActividadDescripcion] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001F6,0,0,true,false )
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
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 20) ;
                return;
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                return;
             case 3 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                return;
             case 4 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 20) ;
                return;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 2 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 3 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
       }
    }

 }

}
