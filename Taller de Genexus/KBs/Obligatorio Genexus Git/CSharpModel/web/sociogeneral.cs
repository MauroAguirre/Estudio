/*
               File: SocioGeneral
        Description: Socio General
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 4/12/2019 17:31:0.35
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
using GeneXus.Http.Server;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class sociogeneral : GXWebComponent, System.Web.SessionState.IRequiresSessionState
   {
      public sociogeneral( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         if ( StringUtil.Len( (String)(sPrefix)) == 0 )
         {
            context.SetDefaultTheme("Carmine");
         }
      }

      public sociogeneral( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( short aP0_SocioId )
      {
         this.A5SocioId = aP0_SocioId;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      public override void SetPrefix( String sPPrefix )
      {
         sPrefix = sPPrefix;
      }

      protected override void createObjects( )
      {
         cmbSocioSexo = new GXCombobox();
         chkSocioReconocido = new GXCheckbox();
         cmbSocioTipoCuota = new GXCombobox();
      }

      protected void INITWEB( )
      {
         initialize_properties( ) ;
         if ( StringUtil.Len( (String)(sPrefix)) == 0 )
         {
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
               else if ( StringUtil.StrCmp(gxfirstwebparm, "dyncomponent") == 0 )
               {
                  setAjaxEventMode();
                  if ( ! IsValidAjaxCall( true) )
                  {
                     GxWebError = 1;
                     return  ;
                  }
                  nDynComponent = 1;
                  sCompPrefix = GetNextPar( );
                  sSFPrefix = GetNextPar( );
                  A5SocioId = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A5SocioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A5SocioId), 4, 0)));
                  setjustcreated();
                  componentprepare(new Object[] {(String)sCompPrefix,(String)sSFPrefix,(short)A5SocioId});
                  componentstart();
                  context.httpAjaxContext.ajax_rspStartCmp(sPrefix);
                  componentdraw();
                  context.httpAjaxContext.ajax_rspEndCmp();
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
         }
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( ! context.IsLocalStorageSupported( ) )
            {
               context.PushCurrentUrl();
            }
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
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               ValidateSpaRequest();
            }
            PA0Q2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV13Pgmname = "SocioGeneral";
               context.Gx_err = 0;
               WS0Q2( ) ;
               if ( ! isAjaxCallMode( ) )
               {
                  if ( nDynComponent == 0 )
                  {
                     throw new System.Net.WebException("WebComponent is not allowed to run") ;
                  }
               }
            }
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

      protected void RenderHtmlHeaders( )
      {
         GxWebStd.gx_html_headers( context, 0, "", "", Form.Meta, Form.Metaequiv, true);
      }

      protected void RenderHtmlOpenForm( )
      {
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( context.isSpaRequest( ) )
            {
               enableOutput();
            }
            context.WriteHtmlText( "<title>") ;
            context.SendWebValue( "Socio General") ;
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
         }
         if ( ( ( context.GetBrowserType( ) == 1 ) || ( context.GetBrowserType( ) == 5 ) ) && ( StringUtil.StrCmp(context.GetBrowserVersion( ), "7.0") == 0 ) )
         {
            context.AddJavascriptSource("json2.js", "?"+context.GetBuildNumber( 126726), false);
         }
         context.AddJavascriptSource("jquery.js", "?"+context.GetBuildNumber( 126726), false);
         context.AddJavascriptSource("gxtimezone.js", "?"+context.GetBuildNumber( 126726), false);
         context.AddJavascriptSource("gxgral.js", "?"+context.GetBuildNumber( 126726), false);
         context.AddJavascriptSource("bootstrap/js/bootstrap.min.js", "?"+context.GetBuildNumber( 126726), false);
         context.AddJavascriptSource("gxcfg.js", "?20194121731038", false);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            context.CloseHtmlHeader();
            if ( context.isSpaRequest( ) )
            {
               disableOutput();
            }
            FormProcess = " data-HasEnter=\"false\" data-Skiponenter=\"false\"";
            context.WriteHtmlText( "<body ") ;
            bodyStyle = "";
            if ( nGXWrapped == 0 )
            {
               bodyStyle = bodyStyle + "-moz-opacity:0;opacity:0;";
            }
            context.WriteHtmlText( " "+"class=\"form-horizontal Form\""+" "+ "style='"+bodyStyle+"'") ;
            context.WriteHtmlText( FormProcess+">") ;
            context.skipLines(1);
            context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("sociogeneral.aspx") + "?" + UrlEncode("" +A5SocioId)+"\">") ;
            GxWebStd.gx_hidden_field( context, "_EventName", "");
            GxWebStd.gx_hidden_field( context, "_EventGridId", "");
            GxWebStd.gx_hidden_field( context, "_EventRowId", "");
            context.WriteHtmlText( "<input type=\"submit\" style=\"display:none\">") ;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, "FORM", "Class", "form-horizontal Form", true);
         }
         else
         {
            bool toggleHtmlOutput = isOutputEnabled( ) ;
            if ( StringUtil.StringSearch( sPrefix, "MP", 1) == 1 )
            {
               if ( context.isSpaRequest( ) )
               {
                  disableOutput();
               }
            }
            context.WriteHtmlText( "<div") ;
            GxWebStd.ClassAttribute( context, "gxwebcomponent-body"+" "+(String.IsNullOrEmpty(StringUtil.RTrim( Form.Class)) ? "form-horizontal Form" : Form.Class)+"-fx");
            context.WriteHtmlText( ">") ;
            if ( toggleHtmlOutput )
            {
               if ( StringUtil.StringSearch( sPrefix, "MP", 1) == 1 )
               {
                  if ( context.isSpaRequest( ) )
                  {
                     enableOutput();
                  }
               }
            }
            toggleJsOutput = isJsOutputEnabled( );
            if ( context.isSpaRequest( ) )
            {
               disableJsOutput();
            }
         }
         if ( StringUtil.StringSearch( sPrefix, "MP", 1) == 1 )
         {
            if ( context.isSpaRequest( ) )
            {
               disableOutput();
            }
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
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOA5SocioId", StringUtil.LTrim( StringUtil.NToC( (decimal)(wcpOA5SocioId), 4, 0, ".", "")));
      }

      protected void RenderHtmlCloseForm0Q2( )
      {
         SendCloseFormHiddens( ) ;
         if ( ( StringUtil.Len( sPrefix) != 0 ) && ( context.isAjaxRequest( ) || context.isSpaRequest( ) ) )
         {
            context.AddJavascriptSource("sociogeneral.js", "?20194121731040", false);
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"GX_FocusControl", GX_FocusControl);
         define_styles( ) ;
         SendSecurityToken(sPrefix);
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            SendAjaxEncryptionKey();
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
            context.AddJavascriptSource("bootstrap/js/bootstrap.min.js", "?"+context.GetBuildNumber( 126726), false);
            context.WriteHtmlTextNl( "</body>") ;
            context.WriteHtmlTextNl( "</html>") ;
            if ( context.isSpaRequest( ) )
            {
               enableOutput();
            }
         }
         else
         {
            SendWebComponentState();
            context.WriteHtmlText( "</div>") ;
            if ( toggleJsOutput )
            {
               if ( context.isSpaRequest( ) )
               {
                  enableJsOutput();
               }
            }
         }
      }

      public override String GetPgmname( )
      {
         return "SocioGeneral" ;
      }

      public override String GetPgmdesc( )
      {
         return "Socio General" ;
      }

      protected void WB0Q0( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! wbLoad )
         {
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               RenderHtmlHeaders( ) ;
            }
            RenderHtmlOpenForm( ) ;
            if ( StringUtil.Len( sPrefix) != 0 )
            {
               GxWebStd.gx_hidden_field( context, sPrefix+"_CMPPGM", "sociogeneral.aspx");
            }
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, "", "", sPrefix, "false");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divMaintable_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 ViewActionsCell", "Center", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group WWViewActions", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 8,'" + sPrefix + "',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnupdate_Internalname, "", "Update", bttBtnupdate_Jsonclick, 7, "Update", "", StyleString, ClassString, 1, 1, "standard", "'"+sPrefix+"'"+",false,"+"'"+"e110q1_client"+"'", TempTags, "", 2, "HLP_SocioGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 10,'" + sPrefix + "',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtndelete_Internalname, "", "Delete", bttBtndelete_Jsonclick, 7, "Delete", "", StyleString, ClassString, 1, 1, "standard", "'"+sPrefix+"'"+",false,"+"'"+"e120q1_client"+"'", TempTags, "", 2, "HLP_SocioGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divAttributestable_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtSocioId_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtSocioId_Internalname, "Id", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtSocioId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A5SocioId), 4, 0, ".", "")), ((edtSocioId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A5SocioId), "ZZZ9")) : context.localUtil.Format( (decimal)(A5SocioId), "ZZZ9")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtSocioId_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtSocioId_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_SocioGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtSocioDireccion_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtSocioDireccion_Internalname, "Direccion", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Multiple line edit */
            ClassString = "ReadonlyAttribute";
            StyleString = "";
            ClassString = "ReadonlyAttribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtSocioDireccion_Internalname, A18SocioDireccion, "http://maps.google.com/maps?q="+GXUtil.UrlEncode( A18SocioDireccion), "", 0, 1, edtSocioDireccion_Enabled, 0, 80, "chr", 10, "row", StyleString, ClassString, "", "", "1024", -1, 0, "_blank", "", 0, true, "GeneXus\\Address", "'"+sPrefix+"'"+",false,"+"'"+""+"'", 0, "HLP_SocioGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbSocioSexo_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbSocioSexo_Internalname, "Sexo", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbSocioSexo, cmbSocioSexo_Internalname, StringUtil.RTrim( A19SocioSexo), 1, cmbSocioSexo_Jsonclick, 0, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "char", "", 1, cmbSocioSexo.Enabled, 0, 0, 0, "em", 0, "", "", "ReadonlyAttribute", "", "", "", "", true, "HLP_SocioGeneral.htm");
            cmbSocioSexo.CurrentValue = StringUtil.RTrim( A19SocioSexo);
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, cmbSocioSexo_Internalname, "Values", (String)(cmbSocioSexo.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtSocioEdad_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtSocioEdad_Internalname, "Edad", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtSocioEdad_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A20SocioEdad), 4, 0, ".", "")), ((edtSocioEdad_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A20SocioEdad), "ZZZ9")) : context.localUtil.Format( (decimal)(A20SocioEdad), "ZZZ9")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtSocioEdad_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtSocioEdad_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_SocioGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+chkSocioReconocido_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkSocioReconocido_Internalname, "Reconocido", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Check box */
            ClassString = "ReadonlyAttribute";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkSocioReconocido_Internalname, StringUtil.BoolToStr( A24SocioReconocido), "", "Reconocido", 1, chkSocioReconocido.Enabled, "true", "", StyleString, ClassString, "", "", "");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtSocioMonto_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtSocioMonto_Internalname, "Monto", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtSocioMonto_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A32SocioMonto), 4, 0, ".", "")), ((edtSocioMonto_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A32SocioMonto), "ZZZ9")) : context.localUtil.Format( (decimal)(A32SocioMonto), "ZZZ9")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtSocioMonto_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtSocioMonto_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_SocioGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbSocioTipoCuota_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbSocioTipoCuota_Internalname, "Tipo Cuota", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbSocioTipoCuota, cmbSocioTipoCuota_Internalname, StringUtil.RTrim( A33SocioTipoCuota), 1, cmbSocioTipoCuota_Jsonclick, 0, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "char", "", 1, cmbSocioTipoCuota.Enabled, 0, 0, 0, "em", 0, "", "", "ReadonlyAttribute", "", "", "", "", true, "HLP_SocioGeneral.htm");
            cmbSocioTipoCuota.CurrentValue = StringUtil.RTrim( A33SocioTipoCuota);
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, cmbSocioTipoCuota_Internalname, "Values", (String)(cmbSocioTipoCuota.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divImagestable_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, imgSocioFoto_Internalname, "Foto", "col-sm-3 ReadonlyAttributeLabel ReadonlyResponsiveImageAttributeLabel", 0, true);
            /* Static Bitmap Variable */
            ClassString = "ReadonlyAttribute ReadonlyResponsiveImageAttribute";
            StyleString = "";
            A21SocioFoto_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( A21SocioFoto))&&String.IsNullOrEmpty(StringUtil.RTrim( A40000SocioFoto_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( A21SocioFoto)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( A21SocioFoto)) ? A40000SocioFoto_GXI : context.PathToRelativeUrl( A21SocioFoto));
            GxWebStd.gx_bitmap( context, imgSocioFoto_Internalname, sImgUrl, "", "", "", context.GetTheme( ), 1, 0, "", "", 1, -1, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, A21SocioFoto_IsBlob, true, context.GetImageSrcSet( sImgUrl), "HLP_SocioGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
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

      protected void START0Q2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( ! context.isSpaRequest( ) )
            {
               Form.Meta.addItem("generator", "GeneXus C# 15_0_12-126726", 0) ;
               Form.Meta.addItem("description", "Socio General", 0) ;
            }
            context.wjLoc = "";
            context.nUserReturn = 0;
            context.wbHandled = 0;
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               sXEvt = cgiGet( "_EventName");
               if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
               {
               }
            }
         }
         wbErr = false;
         if ( ( StringUtil.Len( sPrefix) == 0 ) || ( nDraw == 1 ) )
         {
            if ( nDoneStart == 0 )
            {
               STRUP0Q0( ) ;
            }
         }
      }

      protected void WS0Q2( )
      {
         START0Q2( ) ;
         EVT0Q2( ) ;
      }

      protected void EVT0Q2( )
      {
         sXEvt = cgiGet( "_EventName");
         if ( ( ( ( StringUtil.Len( sPrefix) == 0 ) ) || ( StringUtil.StringSearch( sXEvt, sPrefix, 1) > 0 ) ) && ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
         {
            if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) && ! wbErr )
            {
               /* Read Web Panel buttons. */
               if ( context.wbHandled == 0 )
               {
                  if ( StringUtil.Len( sPrefix) == 0 )
                  {
                     sEvt = cgiGet( "_EventName");
                     EvtGridId = cgiGet( "_EventGridId");
                     EvtRowId = cgiGet( "_EventRowId");
                  }
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
                           if ( StringUtil.StrCmp(sEvt, "RFR") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP0Q0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP0Q0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E130Q2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP0Q0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: Load */
                                    E140Q2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP0Q0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false;
                                       if ( ! Rfr0gs )
                                       {
                                       }
                                       dynload_actions( ) ;
                                    }
                                 }
                              }
                              /* No code required for Cancel button. It is implemented as the Reset button. */
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP0Q0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                 }
                              }
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

      protected void WE0Q2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm0Q2( ) ;
            }
         }
      }

      protected void PA0Q2( )
      {
         if ( nDonePA == 0 )
         {
            if ( StringUtil.Len( sPrefix) != 0 )
            {
               initialize_properties( ) ;
            }
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetCookie( "GX_SESSION_ID"))) )
               {
                  gxcookieaux = context.SetCookie( "GX_SESSION_ID", Encrypt64( Crypto.GetEncryptionKey( ), Crypto.GetServerKey( )), "", (DateTime)(DateTime.MinValue), "", 0);
               }
            }
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            toggleJsOutput = isJsOutputEnabled( );
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               if ( context.isSpaRequest( ) )
               {
                  disableJsOutput();
               }
            }
            init_web_controls( ) ;
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               if ( toggleJsOutput )
               {
                  if ( context.isSpaRequest( ) )
                  {
                     enableJsOutput();
                  }
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
         if ( cmbSocioSexo.ItemCount > 0 )
         {
            A19SocioSexo = cmbSocioSexo.getValidValue(A19SocioSexo);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A19SocioSexo", A19SocioSexo);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbSocioSexo.CurrentValue = StringUtil.RTrim( A19SocioSexo);
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, cmbSocioSexo_Internalname, "Values", cmbSocioSexo.ToJavascriptSource(), true);
         }
         if ( cmbSocioTipoCuota.ItemCount > 0 )
         {
            A33SocioTipoCuota = cmbSocioTipoCuota.getValidValue(A33SocioTipoCuota);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A33SocioTipoCuota", A33SocioTipoCuota);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbSocioTipoCuota.CurrentValue = StringUtil.RTrim( A33SocioTipoCuota);
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, cmbSocioTipoCuota_Internalname, "Values", cmbSocioTipoCuota.ToJavascriptSource(), true);
         }
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF0Q2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV13Pgmname = "SocioGeneral";
         context.Gx_err = 0;
      }

      protected void RF0Q2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            /* Using cursor H000Q2 */
            pr_default.execute(0, new Object[] {A5SocioId});
            while ( (pr_default.getStatus(0) != 101) )
            {
               A40000SocioFoto_GXI = H000Q2_A40000SocioFoto_GXI[0];
               context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, imgSocioFoto_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A21SocioFoto)) ? A40000SocioFoto_GXI : context.convertURL( context.PathToRelativeUrl( A21SocioFoto))), true);
               context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, imgSocioFoto_Internalname, "SrcSet", context.GetImageSrcSet( A21SocioFoto), true);
               A24SocioReconocido = H000Q2_A24SocioReconocido[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A24SocioReconocido", A24SocioReconocido);
               A19SocioSexo = H000Q2_A19SocioSexo[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A19SocioSexo", A19SocioSexo);
               A18SocioDireccion = H000Q2_A18SocioDireccion[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A18SocioDireccion", A18SocioDireccion);
               A20SocioEdad = H000Q2_A20SocioEdad[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A20SocioEdad", StringUtil.LTrim( StringUtil.Str( (decimal)(A20SocioEdad), 4, 0)));
               A33SocioTipoCuota = H000Q2_A33SocioTipoCuota[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A33SocioTipoCuota", A33SocioTipoCuota);
               A21SocioFoto = H000Q2_A21SocioFoto[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A21SocioFoto", A21SocioFoto);
               context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, imgSocioFoto_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A21SocioFoto)) ? A40000SocioFoto_GXI : context.convertURL( context.PathToRelativeUrl( A21SocioFoto))), true);
               context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, imgSocioFoto_Internalname, "SrcSet", context.GetImageSrcSet( A21SocioFoto), true);
               if ( ( StringUtil.StrCmp(A33SocioTipoCuota, "P") == 0 ) && ( A20SocioEdad > 65 ) )
               {
                  A32SocioMonto = (short)(1500-(1500*0.3m));
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A32SocioMonto", StringUtil.LTrim( StringUtil.Str( (decimal)(A32SocioMonto), 4, 0)));
               }
               else
               {
                  if ( ( StringUtil.StrCmp(A33SocioTipoCuota, "V") == 0 ) && ( A20SocioEdad > 65 ) )
                  {
                     A32SocioMonto = (short)(2500-(2500*0.3m));
                     context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A32SocioMonto", StringUtil.LTrim( StringUtil.Str( (decimal)(A32SocioMonto), 4, 0)));
                  }
                  else
                  {
                     if ( StringUtil.StrCmp(A33SocioTipoCuota, "P") == 0 )
                     {
                        A32SocioMonto = 1500;
                        context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A32SocioMonto", StringUtil.LTrim( StringUtil.Str( (decimal)(A32SocioMonto), 4, 0)));
                     }
                     else
                     {
                        if ( true )
                        {
                           A32SocioMonto = 2500;
                           context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A32SocioMonto", StringUtil.LTrim( StringUtil.Str( (decimal)(A32SocioMonto), 4, 0)));
                        }
                        else
                        {
                           A32SocioMonto = 0;
                           context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A32SocioMonto", StringUtil.LTrim( StringUtil.Str( (decimal)(A32SocioMonto), 4, 0)));
                        }
                     }
                  }
               }
               /* Execute user event: Load */
               E140Q2 ();
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(0);
            WB0Q0( ) ;
         }
      }

      protected void send_integrity_lvl_hashes0Q2( )
      {
      }

      protected void STRUP0Q0( )
      {
         /* Before Start, stand alone formulas. */
         AV13Pgmname = "SocioGeneral";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E130Q2 ();
         context.wbGlbDoneStart = 1;
         nDoneStart = 1;
         /* After Start, stand alone formulas. */
         sXEvt = cgiGet( "_EventName");
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            A18SocioDireccion = cgiGet( edtSocioDireccion_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A18SocioDireccion", A18SocioDireccion);
            cmbSocioSexo.CurrentValue = cgiGet( cmbSocioSexo_Internalname);
            A19SocioSexo = cgiGet( cmbSocioSexo_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A19SocioSexo", A19SocioSexo);
            A20SocioEdad = (short)(context.localUtil.CToN( cgiGet( edtSocioEdad_Internalname), ".", ","));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A20SocioEdad", StringUtil.LTrim( StringUtil.Str( (decimal)(A20SocioEdad), 4, 0)));
            A24SocioReconocido = StringUtil.StrToBool( cgiGet( chkSocioReconocido_Internalname));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A24SocioReconocido", A24SocioReconocido);
            A32SocioMonto = (short)(context.localUtil.CToN( cgiGet( edtSocioMonto_Internalname), ".", ","));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A32SocioMonto", StringUtil.LTrim( StringUtil.Str( (decimal)(A32SocioMonto), 4, 0)));
            cmbSocioTipoCuota.CurrentValue = cgiGet( cmbSocioTipoCuota_Internalname);
            A33SocioTipoCuota = cgiGet( cmbSocioTipoCuota_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A33SocioTipoCuota", A33SocioTipoCuota);
            A21SocioFoto = cgiGet( imgSocioFoto_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A21SocioFoto", A21SocioFoto);
            /* Read saved values. */
            wcpOA5SocioId = (short)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOA5SocioId"), ".", ","));
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
         E130Q2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E130Q2( )
      {
         /* Start Routine */
         if ( ! new isauthorized(context).executeUdp(  AV13Pgmname) )
         {
            CallWebObject(formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV13Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         /* Execute user subroutine: 'PREPARETRANSACTION' */
         S112 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void nextLoad( )
      {
      }

      protected void E140Q2( )
      {
         /* Load Routine */
      }

      protected void S112( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV7TrnContext = new SdtTransactionContext(context);
         AV7TrnContext.gxTpr_Callerobject = AV13Pgmname;
         AV7TrnContext.gxTpr_Callerondelete = false;
         AV7TrnContext.gxTpr_Callerurl = AV10HTTPRequest.ScriptName+"?"+AV10HTTPRequest.QueryString;
         AV7TrnContext.gxTpr_Transactionname = "Socio";
         AV8TrnContextAtt = new SdtTransactionContext_Attribute(context);
         AV8TrnContextAtt.gxTpr_Attributename = "SocioId";
         AV8TrnContextAtt.gxTpr_Attributevalue = StringUtil.Str( (decimal)(AV6SocioId), 4, 0);
         AV7TrnContext.gxTpr_Attributes.Add(AV8TrnContextAtt, 0);
         AV9Session.Set("TrnContext", AV7TrnContext.ToXml(false, true, "TransactionContext", "ObligatorioGenexusGit"));
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         A5SocioId = Convert.ToInt16(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A5SocioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A5SocioId), 4, 0)));
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
         PA0Q2( ) ;
         WS0Q2( ) ;
         WE0Q2( ) ;
         this.cleanup();
         context.SetWrapped(false);
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
         return "";
      }

      public void responsestatic( String sGXDynURL )
      {
      }

      public override void componentbind( Object[] obj )
      {
         if ( IsUrlCreated( ) )
         {
            return  ;
         }
         sCtrlA5SocioId = (String)((String)getParm(obj,0));
      }

      public override void componentrestorestate( String sPPrefix ,
                                                  String sPSFPrefix )
      {
         sPrefix = sPPrefix + sPSFPrefix;
         PA0Q2( ) ;
         WCParametersGet( ) ;
      }

      public override void componentprepare( Object[] obj )
      {
         wbLoad = false;
         sCompPrefix = (String)getParm(obj,0);
         sSFPrefix = (String)getParm(obj,1);
         sPrefix = sCompPrefix + sSFPrefix;
         AddComponentObject(sPrefix, "sociogeneral", GetJustCreated( ));
         if ( ( nDoneStart == 0 ) && ( nDynComponent == 0 ) )
         {
            INITWEB( ) ;
         }
         else
         {
            init_default_properties( ) ;
            init_web_controls( ) ;
         }
         PA0Q2( ) ;
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) && ( context.wbGlbDoneStart == 0 ) )
         {
            WCParametersGet( ) ;
         }
         else
         {
            A5SocioId = Convert.ToInt16(getParm(obj,2));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A5SocioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A5SocioId), 4, 0)));
         }
         wcpOA5SocioId = (short)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOA5SocioId"), ".", ","));
         if ( ! GetJustCreated( ) && ( ( A5SocioId != wcpOA5SocioId ) ) )
         {
            setjustcreated();
         }
         wcpOA5SocioId = A5SocioId;
      }

      protected void WCParametersGet( )
      {
         /* Read Component Parameters. */
         sCtrlA5SocioId = cgiGet( sPrefix+"A5SocioId_CTRL");
         if ( StringUtil.Len( sCtrlA5SocioId) > 0 )
         {
            A5SocioId = (short)(context.localUtil.CToN( cgiGet( sCtrlA5SocioId), ".", ","));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A5SocioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A5SocioId), 4, 0)));
         }
         else
         {
            A5SocioId = (short)(context.localUtil.CToN( cgiGet( sPrefix+"A5SocioId_PARM"), ".", ","));
         }
      }

      public override void componentprocess( String sPPrefix ,
                                             String sPSFPrefix ,
                                             String sCompEvt )
      {
         sCompPrefix = sPPrefix;
         sSFPrefix = sPSFPrefix;
         sPrefix = sCompPrefix + sSFPrefix;
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         INITWEB( ) ;
         nDraw = 0;
         PA0Q2( ) ;
         sEvt = sCompEvt;
         WCParametersGet( ) ;
         WS0Q2( ) ;
         if ( isFullAjaxMode( ) )
         {
            componentdraw();
         }
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
      }

      public override void componentstart( )
      {
         if ( nDoneStart == 0 )
         {
            WCStart( ) ;
         }
      }

      protected void WCStart( )
      {
         nDraw = 1;
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         WS0Q2( ) ;
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
      }

      protected void WCParametersSet( )
      {
         GxWebStd.gx_hidden_field( context, sPrefix+"A5SocioId_PARM", StringUtil.LTrim( StringUtil.NToC( (decimal)(A5SocioId), 4, 0, ".", "")));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlA5SocioId)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"A5SocioId_CTRL", StringUtil.RTrim( sCtrlA5SocioId));
         }
      }

      public override void componentdraw( )
      {
         if ( nDoneStart == 0 )
         {
            WCStart( ) ;
         }
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         WCParametersSet( ) ;
         WE0Q2( ) ;
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
      }

      public override String getstring( String sGXControl )
      {
         String sCtrlName ;
         if ( StringUtil.StrCmp(StringUtil.Substring( sGXControl, 1, 1), "&") == 0 )
         {
            sCtrlName = StringUtil.Substring( sGXControl, 2, StringUtil.Len( sGXControl)-1);
         }
         else
         {
            sCtrlName = sGXControl;
         }
         return cgiGet( sPrefix+"v"+StringUtil.Upper( sCtrlName)) ;
      }

      public override void componentjscripts( )
      {
         include_jscripts( ) ;
      }

      public override void componentthemes( )
      {
         define_styles( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20194121731090", true);
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
         context.AddJavascriptSource("sociogeneral.js", "?20194121731090", false);
         /* End function include_jscripts */
      }

      protected void init_web_controls( )
      {
         cmbSocioSexo.Name = "SOCIOSEXO";
         cmbSocioSexo.WebTags = "";
         cmbSocioSexo.addItem("Hombre", "H", 0);
         cmbSocioSexo.addItem("Mujer", "M", 0);
         cmbSocioSexo.addItem("Otro", "O", 0);
         if ( cmbSocioSexo.ItemCount > 0 )
         {
         }
         chkSocioReconocido.Name = "SOCIORECONOCIDO";
         chkSocioReconocido.WebTags = "";
         chkSocioReconocido.Caption = "";
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, chkSocioReconocido_Internalname, "TitleCaption", chkSocioReconocido.Caption, true);
         chkSocioReconocido.CheckedValue = "false";
         cmbSocioTipoCuota.Name = "SOCIOTIPOCUOTA";
         cmbSocioTipoCuota.WebTags = "";
         cmbSocioTipoCuota.addItem("V", "Verano", 0);
         cmbSocioTipoCuota.addItem("P", "Permanente", 0);
         if ( cmbSocioTipoCuota.ItemCount > 0 )
         {
         }
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         bttBtnupdate_Internalname = sPrefix+"BTNUPDATE";
         bttBtndelete_Internalname = sPrefix+"BTNDELETE";
         edtSocioId_Internalname = sPrefix+"SOCIOID";
         edtSocioDireccion_Internalname = sPrefix+"SOCIODIRECCION";
         cmbSocioSexo_Internalname = sPrefix+"SOCIOSEXO";
         edtSocioEdad_Internalname = sPrefix+"SOCIOEDAD";
         chkSocioReconocido_Internalname = sPrefix+"SOCIORECONOCIDO";
         edtSocioMonto_Internalname = sPrefix+"SOCIOMONTO";
         cmbSocioTipoCuota_Internalname = sPrefix+"SOCIOTIPOCUOTA";
         divAttributestable_Internalname = sPrefix+"ATTRIBUTESTABLE";
         imgSocioFoto_Internalname = sPrefix+"SOCIOFOTO";
         divImagestable_Internalname = sPrefix+"IMAGESTABLE";
         divMaintable_Internalname = sPrefix+"MAINTABLE";
         Form.Internalname = sPrefix+"FORM";
      }

      public override void initialize_properties( )
      {
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            context.SetDefaultTheme("Carmine");
         }
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( context.isSpaRequest( ) )
            {
               disableJsOutput();
            }
         }
         init_default_properties( ) ;
         chkSocioReconocido.Caption = "Reconocido";
         cmbSocioTipoCuota_Jsonclick = "";
         cmbSocioTipoCuota.Enabled = 0;
         edtSocioMonto_Jsonclick = "";
         edtSocioMonto_Enabled = 0;
         chkSocioReconocido.Enabled = 0;
         edtSocioEdad_Jsonclick = "";
         edtSocioEdad_Enabled = 0;
         cmbSocioSexo_Jsonclick = "";
         cmbSocioSexo.Enabled = 0;
         edtSocioDireccion_Enabled = 0;
         edtSocioId_Jsonclick = "";
         edtSocioId_Enabled = 0;
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( context.isSpaRequest( ) )
            {
               enableJsOutput();
            }
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
         setEventMetadata("'DOUPDATE'","{handler:'E110Q1',iparms:[{av:'A5SocioId',fld:'SOCIOID',pic:'ZZZ9'}]");
         setEventMetadata("'DOUPDATE'",",oparms:[]}");
         setEventMetadata("'DODELETE'","{handler:'E120Q1',iparms:[{av:'A5SocioId',fld:'SOCIOID',pic:'ZZZ9'}]");
         setEventMetadata("'DODELETE'",",oparms:[]}");
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
         sPrefix = "";
         AV13Pgmname = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GXKey = "";
         GX_FocusControl = "";
         TempTags = "";
         ClassString = "";
         StyleString = "";
         bttBtnupdate_Jsonclick = "";
         bttBtndelete_Jsonclick = "";
         A18SocioDireccion = "";
         A19SocioSexo = "";
         A33SocioTipoCuota = "";
         A21SocioFoto = "";
         A40000SocioFoto_GXI = "";
         sImgUrl = "";
         Form = new GXWebForm();
         sXEvt = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         scmdbuf = "";
         H000Q2_A5SocioId = new short[1] ;
         H000Q2_A40000SocioFoto_GXI = new String[] {""} ;
         H000Q2_A24SocioReconocido = new bool[] {false} ;
         H000Q2_A19SocioSexo = new String[] {""} ;
         H000Q2_A18SocioDireccion = new String[] {""} ;
         H000Q2_A20SocioEdad = new short[1] ;
         H000Q2_A33SocioTipoCuota = new String[] {""} ;
         H000Q2_A21SocioFoto = new String[] {""} ;
         AV7TrnContext = new SdtTransactionContext(context);
         AV10HTTPRequest = new GxHttpRequest( context);
         AV8TrnContextAtt = new SdtTransactionContext_Attribute(context);
         AV9Session = context.GetSession();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sCtrlA5SocioId = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.sociogeneral__default(),
            new Object[][] {
                new Object[] {
               H000Q2_A5SocioId, H000Q2_A40000SocioFoto_GXI, H000Q2_A24SocioReconocido, H000Q2_A19SocioSexo, H000Q2_A18SocioDireccion, H000Q2_A20SocioEdad, H000Q2_A33SocioTipoCuota, H000Q2_A21SocioFoto
               }
            }
         );
         AV13Pgmname = "SocioGeneral";
         /* GeneXus formulas. */
         AV13Pgmname = "SocioGeneral";
         context.Gx_err = 0;
      }

      private short A5SocioId ;
      private short wcpOA5SocioId ;
      private short nGotPars ;
      private short GxWebError ;
      private short nDynComponent ;
      private short initialized ;
      private short wbEnd ;
      private short wbStart ;
      private short A20SocioEdad ;
      private short A32SocioMonto ;
      private short nDraw ;
      private short nDoneStart ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short AV6SocioId ;
      private short nGXWrapped ;
      private int edtSocioId_Enabled ;
      private int edtSocioDireccion_Enabled ;
      private int edtSocioEdad_Enabled ;
      private int edtSocioMonto_Enabled ;
      private int idxLst ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sPrefix ;
      private String sCompPrefix ;
      private String sSFPrefix ;
      private String AV13Pgmname ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GXKey ;
      private String GX_FocusControl ;
      private String divMaintable_Internalname ;
      private String TempTags ;
      private String ClassString ;
      private String StyleString ;
      private String bttBtnupdate_Internalname ;
      private String bttBtnupdate_Jsonclick ;
      private String bttBtndelete_Internalname ;
      private String bttBtndelete_Jsonclick ;
      private String divAttributestable_Internalname ;
      private String edtSocioId_Internalname ;
      private String edtSocioId_Jsonclick ;
      private String edtSocioDireccion_Internalname ;
      private String cmbSocioSexo_Internalname ;
      private String A19SocioSexo ;
      private String cmbSocioSexo_Jsonclick ;
      private String edtSocioEdad_Internalname ;
      private String edtSocioEdad_Jsonclick ;
      private String chkSocioReconocido_Internalname ;
      private String edtSocioMonto_Internalname ;
      private String edtSocioMonto_Jsonclick ;
      private String cmbSocioTipoCuota_Internalname ;
      private String A33SocioTipoCuota ;
      private String cmbSocioTipoCuota_Jsonclick ;
      private String divImagestable_Internalname ;
      private String imgSocioFoto_Internalname ;
      private String sImgUrl ;
      private String sXEvt ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String scmdbuf ;
      private String sCtrlA5SocioId ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool A24SocioReconocido ;
      private bool A21SocioFoto_IsBlob ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private String A18SocioDireccion ;
      private String A40000SocioFoto_GXI ;
      private String A21SocioFoto ;
      private GXWebForm Form ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbSocioSexo ;
      private GXCheckbox chkSocioReconocido ;
      private GXCombobox cmbSocioTipoCuota ;
      private IDataStoreProvider pr_default ;
      private short[] H000Q2_A5SocioId ;
      private String[] H000Q2_A40000SocioFoto_GXI ;
      private bool[] H000Q2_A24SocioReconocido ;
      private String[] H000Q2_A19SocioSexo ;
      private String[] H000Q2_A18SocioDireccion ;
      private short[] H000Q2_A20SocioEdad ;
      private String[] H000Q2_A33SocioTipoCuota ;
      private String[] H000Q2_A21SocioFoto ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV10HTTPRequest ;
      private IGxSession AV9Session ;
      private SdtTransactionContext AV7TrnContext ;
      private SdtTransactionContext_Attribute AV8TrnContextAtt ;
   }

   public class sociogeneral__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH000Q2 ;
          prmH000Q2 = new Object[] {
          new Object[] {"@SocioId",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H000Q2", "SELECT [SocioId], [SocioFoto_GXI], [SocioReconocido], [SocioSexo], [SocioDireccion], [SocioEdad], [SocioTipoCuota], [SocioFoto] FROM [Socio] WITH (NOLOCK) WHERE [SocioId] = @SocioId ORDER BY [SocioId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000Q2,1,0,true,true )
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
                ((String[]) buf[1])[0] = rslt.getMultimediaUri(2) ;
                ((bool[]) buf[2])[0] = rslt.getBool(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 20) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((String[]) buf[6])[0] = rslt.getString(7, 20) ;
                ((String[]) buf[7])[0] = rslt.getMultimediaFile(8, rslt.getVarchar(2)) ;
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
       }
    }

 }

}
