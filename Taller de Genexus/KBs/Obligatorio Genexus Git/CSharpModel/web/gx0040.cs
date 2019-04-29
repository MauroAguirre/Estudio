/*
               File: Gx0040
        Description: Selection List Socio
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 4/12/2019 17:31:5.9
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
   public class gx0040 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gx0040( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public gx0040( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( out short aP0_pSocioId )
      {
         this.AV11pSocioId = 0 ;
         executePrivate();
         aP0_pSocioId=this.AV11pSocioId;
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         cmbavCsociosexo = new GXCombobox();
         chkavCsocioreconocido = new GXCheckbox();
         cmbavCsociotipocuota = new GXCombobox();
         cmbSocioSexo = new GXCombobox();
         chkSocioReconocido = new GXCheckbox();
         cmbSocioTipoCuota = new GXCombobox();
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
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Grid1") == 0 )
            {
               nRC_GXsfl_74 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               nGXsfl_74_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
               sGXsfl_74_idx = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxnrGrid1_newrow( ) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Grid1") == 0 )
            {
               subGrid1_Rows = (int)(NumberUtil.Val( GetNextPar( ), "."));
               AV6cSocioId = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV7cSocioSexo = GetNextPar( );
               AV8cSocioEdad = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV10cSocioReconocido = StringUtil.StrToBool( GetNextPar( ));
               AV14cSocioTipoCuota = GetNextPar( );
               AV15cCarnetId = (short)(NumberUtil.Val( GetNextPar( ), "."));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid1_refresh( subGrid1_Rows, AV6cSocioId, AV7cSocioSexo, AV8cSocioEdad, AV10cSocioReconocido, AV14cSocioTipoCuota, AV15cCarnetId) ;
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               context.GX_webresponse.AddString((String)(context.getJSONResponse( )));
               return  ;
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
               AV11pSocioId = (short)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11pSocioId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11pSocioId), 4, 0)));
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
            MasterPageObj = (GXMasterPage) ClassLoader.GetInstance("rwdpromptmasterpage", "GeneXus.Programs.rwdpromptmasterpage", new Object[] {new GxContext( context.handle, context.DataStores, context.HttpContext)});
            MasterPageObj.setDataArea(this,true);
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
         PA0Y2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START0Y2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?20194121731516", false);
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
         FormProcess = " data-HasEnter=\"true\" data-Skiponenter=\"false\"";
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("gx0040.aspx") + "?" + UrlEncode("" +AV11pSocioId)+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "GXH_vCSOCIOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cSocioId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCSOCIOSEXO", StringUtil.RTrim( AV7cSocioSexo));
         GxWebStd.gx_hidden_field( context, "GXH_vCSOCIOEDAD", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8cSocioEdad), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCSOCIORECONOCIDO", StringUtil.BoolToStr( AV10cSocioReconocido));
         GxWebStd.gx_hidden_field( context, "GXH_vCSOCIOTIPOCUOTA", StringUtil.RTrim( AV14cSocioTipoCuota));
         GxWebStd.gx_hidden_field( context, "GXH_vCCARNETID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV15cCarnetId), 4, 0, ".", "")));
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_74", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_74), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vPSOCIOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11pSocioId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "ADVANCEDCONTAINER_Class", StringUtil.RTrim( divAdvancedcontainer_Class));
         GxWebStd.gx_hidden_field( context, "BTNTOGGLE_Class", StringUtil.RTrim( bttBtntoggle_Class));
         GxWebStd.gx_hidden_field( context, "SOCIOIDFILTERCONTAINER_Class", StringUtil.RTrim( divSocioidfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "SOCIOSEXOFILTERCONTAINER_Class", StringUtil.RTrim( divSociosexofiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "SOCIOEDADFILTERCONTAINER_Class", StringUtil.RTrim( divSocioedadfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "SOCIORECONOCIDOFILTERCONTAINER_Class", StringUtil.RTrim( divSocioreconocidofiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "SOCIOTIPOCUOTAFILTERCONTAINER_Class", StringUtil.RTrim( divSociotipocuotafiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "CARNETIDFILTERCONTAINER_Class", StringUtil.RTrim( divCarnetidfiltercontainer_Class));
      }

      public override void RenderHtmlCloseForm( )
      {
         SendCloseFormHiddens( ) ;
         GxWebStd.gx_hidden_field( context, "GX_FocusControl", "notset");
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
            WE0Y2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT0Y2( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return true ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("gx0040.aspx") + "?" + UrlEncode("" +AV11pSocioId) ;
      }

      public override String GetPgmname( )
      {
         return "Gx0040" ;
      }

      public override String GetPgmdesc( )
      {
         return "Selection List Socio" ;
      }

      protected void WB0Y0( )
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
            GxWebStd.gx_div_start( context, divMain_Internalname, 1, 0, "px", 0, "px", "ContainerFluid PromptContainer", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-3 PromptAdvancedBarCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divAdvancedcontainer_Internalname, 1, 0, "px", 0, "px", divAdvancedcontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divSocioidfiltercontainer_Internalname, 1, 0, "px", 0, "px", divSocioidfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblsocioidfilter_Internalname, "Socio Id", "", "", lblLblsocioidfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e110y1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0040.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCsocioid_Internalname, "Socio Id", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'" + sGXsfl_74_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCsocioid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cSocioId), 4, 0, ".", "")), ((edtavCsocioid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV6cSocioId), "ZZZ9")) : context.localUtil.Format( (decimal)(AV6cSocioId), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,16);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCsocioid_Jsonclick, 0, "Attribute", "", "", "", "", edtavCsocioid_Visible, edtavCsocioid_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx0040.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
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
            GxWebStd.gx_div_start( context, divSociosexofiltercontainer_Internalname, 1, 0, "px", 0, "px", divSociosexofiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblsociosexofilter_Internalname, "Socio Sexo", "", "", lblLblsociosexofilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e120y1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0040.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavCsociosexo_Internalname, "Socio Sexo", "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 26,'',false,'" + sGXsfl_74_idx + "',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavCsociosexo, cmbavCsociosexo_Internalname, StringUtil.RTrim( AV7cSocioSexo), 1, cmbavCsociosexo_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "char", "", cmbavCsociosexo.Visible, cmbavCsociosexo.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,26);\"", "", true, "HLP_Gx0040.htm");
            cmbavCsociosexo.CurrentValue = StringUtil.RTrim( AV7cSocioSexo);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavCsociosexo_Internalname, "Values", (String)(cmbavCsociosexo.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
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
            GxWebStd.gx_div_start( context, divSocioedadfiltercontainer_Internalname, 1, 0, "px", 0, "px", divSocioedadfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblsocioedadfilter_Internalname, "Socio Edad", "", "", lblLblsocioedadfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e130y1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0040.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCsocioedad_Internalname, "Socio Edad", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 36,'',false,'" + sGXsfl_74_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCsocioedad_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8cSocioEdad), 4, 0, ".", "")), ((edtavCsocioedad_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV8cSocioEdad), "ZZZ9")) : context.localUtil.Format( (decimal)(AV8cSocioEdad), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,36);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCsocioedad_Jsonclick, 0, "Attribute", "", "", "", "", edtavCsocioedad_Visible, edtavCsocioedad_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx0040.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
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
            GxWebStd.gx_div_start( context, divSocioreconocidofiltercontainer_Internalname, 1, 0, "px", 0, "px", divSocioreconocidofiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblsocioreconocidofilter_Internalname, "Socio Reconocido", "", "", lblLblsocioreconocidofilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e140y1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0040.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkavCsocioreconocido_Internalname, "Socio Reconocido", "col-sm-3 AttributeLabel", 0, true);
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'',false,'" + sGXsfl_74_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavCsocioreconocido_Internalname, StringUtil.BoolToStr( AV10cSocioReconocido), "", "Socio Reconocido", chkavCsocioreconocido.Visible, chkavCsocioreconocido.Enabled, "true", "", StyleString, ClassString, "", "", TempTags+" onclick=\"gx.fn.checkboxClick(46, this, 'true', 'false');gx.evt.onchange(this, event);\" ");
            GxWebStd.gx_div_end( context, "left", "top", "div");
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
            GxWebStd.gx_div_start( context, divSociotipocuotafiltercontainer_Internalname, 1, 0, "px", 0, "px", divSociotipocuotafiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblsociotipocuotafilter_Internalname, "Socio Tipo Cuota", "", "", lblLblsociotipocuotafilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e150y1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0040.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavCsociotipocuota_Internalname, "Socio Tipo Cuota", "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 56,'',false,'" + sGXsfl_74_idx + "',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavCsociotipocuota, cmbavCsociotipocuota_Internalname, StringUtil.RTrim( AV14cSocioTipoCuota), 1, cmbavCsociotipocuota_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "char", "", cmbavCsociotipocuota.Visible, cmbavCsociotipocuota.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,56);\"", "", true, "HLP_Gx0040.htm");
            cmbavCsociotipocuota.CurrentValue = StringUtil.RTrim( AV14cSocioTipoCuota);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavCsociotipocuota_Internalname, "Values", (String)(cmbavCsociotipocuota.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
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
            GxWebStd.gx_div_start( context, divCarnetidfiltercontainer_Internalname, 1, 0, "px", 0, "px", divCarnetidfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblcarnetidfilter_Internalname, "Carnet Id", "", "", lblLblcarnetidfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e160y1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0040.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCcarnetid_Internalname, "Carnet Id", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 66,'',false,'" + sGXsfl_74_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCcarnetid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV15cCarnetId), 4, 0, ".", "")), ((edtavCcarnetid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV15cCarnetId), "ZZZ9")) : context.localUtil.Format( (decimal)(AV15cCarnetId), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,66);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCcarnetid_Jsonclick, 0, "Attribute", "", "", "", "", edtavCcarnetid_Visible, edtavCcarnetid_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Gx0040.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-9 WWGridCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divGridtable_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 hidden-sm hidden-md hidden-lg ToggleCell", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 71,'',false,'',0)\"";
            ClassString = bttBtntoggle_Class;
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntoggle_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(74), 2, 0)+","+"null"+");", "|||", bttBtntoggle_Jsonclick, 7, "|||", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"e170y1_client"+"'", TempTags, "", 2, "HLP_Gx0040.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /*  Grid Control  */
            Grid1Container.SetWrapped(nGXWrapped);
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<div id=\""+"Grid1Container"+"DivS\" data-gxgridid=\"74\">") ;
               sStyleString = "";
               GxWebStd.gx_table_start( context, subGrid1_Internalname, subGrid1_Internalname, "", "PromptGrid", 0, "", "", 1, 2, sStyleString, "", "", 0);
               /* Subfile titles */
               context.WriteHtmlText( "<tr") ;
               context.WriteHtmlTextNl( ">") ;
               if ( subGrid1_Backcolorstyle == 0 )
               {
                  subGrid1_Titlebackstyle = 0;
                  if ( StringUtil.Len( subGrid1_Class) > 0 )
                  {
                     subGrid1_Linesclass = subGrid1_Class+"Title";
                  }
               }
               else
               {
                  subGrid1_Titlebackstyle = 1;
                  if ( subGrid1_Backcolorstyle == 1 )
                  {
                     subGrid1_Titlebackcolor = subGrid1_Allbackcolor;
                     if ( StringUtil.Len( subGrid1_Class) > 0 )
                     {
                        subGrid1_Linesclass = subGrid1_Class+"UniformTitle";
                     }
                  }
                  else
                  {
                     if ( StringUtil.Len( subGrid1_Class) > 0 )
                     {
                        subGrid1_Linesclass = subGrid1_Class+"Title";
                     }
                  }
               }
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"SelectionAttribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"DescriptionAttribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Id") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Sexo") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Edad") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Reconocido") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"ImageAttribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Foto") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Tipo Cuota") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Carnet Id") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlTextNl( "</tr>") ;
               Grid1Container.AddObjectProperty("GridName", "Grid1");
            }
            else
            {
               if ( isAjaxCallMode( ) )
               {
                  Grid1Container = new GXWebGrid( context);
               }
               else
               {
                  Grid1Container.Clear();
               }
               Grid1Container.SetWrapped(nGXWrapped);
               Grid1Container.AddObjectProperty("GridName", "Grid1");
               Grid1Container.AddObjectProperty("Header", subGrid1_Header);
               Grid1Container.AddObjectProperty("Class", "PromptGrid");
               Grid1Container.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
               Grid1Container.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
               Grid1Container.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Backcolorstyle), 1, 0, ".", "")));
               Grid1Container.AddObjectProperty("CmpContext", "");
               Grid1Container.AddObjectProperty("InMasterPage", "false");
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", context.convertURL( AV5LinkSelection));
               Grid1Column.AddObjectProperty("Link", StringUtil.RTrim( edtavLinkselection_Link));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A5SocioId), 4, 0, ".", "")));
               Grid1Column.AddObjectProperty("Link", StringUtil.RTrim( edtSocioId_Link));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A19SocioSexo));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A20SocioEdad), 4, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.BoolToStr( A24SocioReconocido));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", context.convertURL( A21SocioFoto));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A33SocioTipoCuota));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A36CarnetId), 4, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Container.AddObjectProperty("Selectedindex", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Selectedindex), 4, 0, ".", "")));
               Grid1Container.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Allowselection), 1, 0, ".", "")));
               Grid1Container.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Selectioncolor), 9, 0, ".", "")));
               Grid1Container.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Allowhovering), 1, 0, ".", "")));
               Grid1Container.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Hoveringcolor), 9, 0, ".", "")));
               Grid1Container.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Allowcollapsing), 1, 0, ".", "")));
               Grid1Container.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Collapsed), 1, 0, ".", "")));
            }
         }
         if ( wbEnd == 74 )
         {
            wbEnd = 0;
            nRC_GXsfl_74 = (short)(nGXsfl_74_idx-1);
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "</table>") ;
               context.WriteHtmlText( "</div>") ;
            }
            else
            {
               Grid1Container.AddObjectProperty("GRID1_nEOF", GRID1_nEOF);
               Grid1Container.AddObjectProperty("GRID1_nFirstRecordOnPage", GRID1_nFirstRecordOnPage);
               sStyleString = "";
               context.WriteHtmlText( "<div id=\""+"Grid1Container"+"Div\" "+sStyleString+">"+"</div>") ;
               context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Grid1", Grid1Container);
               if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, "Grid1ContainerData", Grid1Container.ToJavascriptSource());
               }
               if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, "Grid1ContainerData"+"V", Grid1Container.GridValuesHidden());
               }
               else
               {
                  context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Grid1ContainerData"+"V"+"\" value='"+Grid1Container.GridValuesHidden()+"'/>") ;
               }
            }
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 85,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(74), 2, 0)+","+"null"+");", "Cancel", bttBtn_cancel_Jsonclick, 1, "Cancel", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Gx0040.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         if ( wbEnd == 74 )
         {
            wbEnd = 0;
            if ( isFullAjaxMode( ) )
            {
               if ( Grid1Container.GetWrapped() == 1 )
               {
                  context.WriteHtmlText( "</table>") ;
                  context.WriteHtmlText( "</div>") ;
               }
               else
               {
                  Grid1Container.AddObjectProperty("GRID1_nEOF", GRID1_nEOF);
                  Grid1Container.AddObjectProperty("GRID1_nFirstRecordOnPage", GRID1_nFirstRecordOnPage);
                  sStyleString = "";
                  context.WriteHtmlText( "<div id=\""+"Grid1Container"+"Div\" "+sStyleString+">"+"</div>") ;
                  context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Grid1", Grid1Container);
                  if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
                  {
                     GxWebStd.gx_hidden_field( context, "Grid1ContainerData", Grid1Container.ToJavascriptSource());
                  }
                  if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
                  {
                     GxWebStd.gx_hidden_field( context, "Grid1ContainerData"+"V", Grid1Container.GridValuesHidden());
                  }
                  else
                  {
                     context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Grid1ContainerData"+"V"+"\" value='"+Grid1Container.GridValuesHidden()+"'/>") ;
                  }
               }
            }
         }
         wbLoad = true;
      }

      protected void START0Y2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 15_0_12-126726", 0) ;
            Form.Meta.addItem("description", "Selection List Socio", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP0Y0( ) ;
      }

      protected void WS0Y2( )
      {
         START0Y2( ) ;
         EVT0Y2( ) ;
      }

      protected void EVT0Y2( )
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
                              /* No code required for Cancel button. It is implemented as the Reset button. */
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRID1PAGING") == 0 )
                           {
                              context.wbHandled = 1;
                              sEvt = cgiGet( "GRID1PAGING");
                              if ( StringUtil.StrCmp(sEvt, "FIRST") == 0 )
                              {
                                 subgrid1_firstpage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "PREV") == 0 )
                              {
                                 subgrid1_previouspage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "NEXT") == 0 )
                              {
                                 subgrid1_nextpage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "LAST") == 0 )
                              {
                                 subgrid1_lastpage( ) ;
                              }
                              dynload_actions( ) ;
                           }
                        }
                        else
                        {
                           sEvtType = StringUtil.Right( sEvt, 4);
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4));
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 4), "LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) )
                           {
                              nGXsfl_74_idx = (short)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_74_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_74_idx), 4, 0)), 4, "0");
                              SubsflControlProps_742( ) ;
                              AV5LinkSelection = cgiGet( edtavLinkselection_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)) ? AV18Linkselection_GXI : context.convertURL( context.PathToRelativeUrl( AV5LinkSelection))), !bGXsfl_74_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "SrcSet", context.GetImageSrcSet( AV5LinkSelection), true);
                              A5SocioId = (short)(context.localUtil.CToN( cgiGet( edtSocioId_Internalname), ".", ","));
                              cmbSocioSexo.Name = cmbSocioSexo_Internalname;
                              cmbSocioSexo.CurrentValue = cgiGet( cmbSocioSexo_Internalname);
                              A19SocioSexo = cgiGet( cmbSocioSexo_Internalname);
                              A20SocioEdad = (short)(context.localUtil.CToN( cgiGet( edtSocioEdad_Internalname), ".", ","));
                              A24SocioReconocido = StringUtil.StrToBool( cgiGet( chkSocioReconocido_Internalname));
                              A21SocioFoto = cgiGet( edtSocioFoto_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSocioFoto_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A21SocioFoto)) ? A40000SocioFoto_GXI : context.convertURL( context.PathToRelativeUrl( A21SocioFoto))), !bGXsfl_74_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSocioFoto_Internalname, "SrcSet", context.GetImageSrcSet( A21SocioFoto), true);
                              cmbSocioTipoCuota.Name = cmbSocioTipoCuota_Internalname;
                              cmbSocioTipoCuota.CurrentValue = cgiGet( cmbSocioTipoCuota_Internalname);
                              A33SocioTipoCuota = cgiGet( cmbSocioTipoCuota_Internalname);
                              A36CarnetId = (short)(context.localUtil.CToN( cgiGet( edtCarnetId_Internalname), ".", ","));
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E180Y2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Load */
                                    E190Y2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false;
                                       /* Set Refresh If Csocioid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCSOCIOID"), ".", ",") != Convert.ToDecimal( AV6cSocioId )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Csociosexo Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCSOCIOSEXO"), AV7cSocioSexo) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Csocioedad Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCSOCIOEDAD"), ".", ",") != Convert.ToDecimal( AV8cSocioEdad )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Csocioreconocido Changed */
                                       if ( StringUtil.StrToBool( cgiGet( "GXH_vCSOCIORECONOCIDO")) != AV10cSocioReconocido )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Csociotipocuota Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCSOCIOTIPOCUOTA"), AV14cSocioTipoCuota) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Ccarnetid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCCARNETID"), ".", ",") != Convert.ToDecimal( AV15cCarnetId )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       if ( ! Rfr0gs )
                                       {
                                          /* Execute user event: Enter */
                                          E200Y2 ();
                                       }
                                       dynload_actions( ) ;
                                    }
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                 }
                              }
                              else
                              {
                              }
                           }
                        }
                     }
                     context.wbHandled = 1;
                  }
               }
            }
         }
      }

      protected void WE0Y2( )
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

      protected void PA0Y2( )
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
            nDonePA = 1;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void gxnrGrid1_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         SubsflControlProps_742( ) ;
         while ( nGXsfl_74_idx <= nRC_GXsfl_74 )
         {
            sendrow_742( ) ;
            nGXsfl_74_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_74_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_74_idx+1));
            sGXsfl_74_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_74_idx), 4, 0)), 4, "0");
            SubsflControlProps_742( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( Grid1Container));
         /* End function gxnrGrid1_newrow */
      }

      protected void gxgrGrid1_refresh( int subGrid1_Rows ,
                                        short AV6cSocioId ,
                                        String AV7cSocioSexo ,
                                        short AV8cSocioEdad ,
                                        bool AV10cSocioReconocido ,
                                        String AV14cSocioTipoCuota ,
                                        short AV15cCarnetId )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID1_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Rows), 6, 0, ".", "")));
         GRID1_nCurrentRecord = 0;
         RF0Y2( ) ;
         /* End function gxgrGrid1_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_SOCIOID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A5SocioId), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "SOCIOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A5SocioId), 4, 0, ".", "")));
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
         if ( cmbavCsociosexo.ItemCount > 0 )
         {
            AV7cSocioSexo = cmbavCsociosexo.getValidValue(AV7cSocioSexo);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cSocioSexo", AV7cSocioSexo);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavCsociosexo.CurrentValue = StringUtil.RTrim( AV7cSocioSexo);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavCsociosexo_Internalname, "Values", cmbavCsociosexo.ToJavascriptSource(), true);
         }
         if ( cmbavCsociotipocuota.ItemCount > 0 )
         {
            AV14cSocioTipoCuota = cmbavCsociotipocuota.getValidValue(AV14cSocioTipoCuota);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14cSocioTipoCuota", AV14cSocioTipoCuota);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavCsociotipocuota.CurrentValue = StringUtil.RTrim( AV14cSocioTipoCuota);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavCsociotipocuota_Internalname, "Values", cmbavCsociotipocuota.ToJavascriptSource(), true);
         }
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF0Y2( ) ;
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

      protected void RF0Y2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            Grid1Container.ClearRows();
         }
         wbStart = 74;
         nGXsfl_74_idx = 1;
         sGXsfl_74_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_74_idx), 4, 0)), 4, "0");
         SubsflControlProps_742( ) ;
         bGXsfl_74_Refreshing = true;
         Grid1Container.AddObjectProperty("GridName", "Grid1");
         Grid1Container.AddObjectProperty("CmpContext", "");
         Grid1Container.AddObjectProperty("InMasterPage", "false");
         Grid1Container.AddObjectProperty("Class", "PromptGrid");
         Grid1Container.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         Grid1Container.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
         Grid1Container.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Backcolorstyle), 1, 0, ".", "")));
         Grid1Container.PageSize = subGrid1_Recordsperpage( );
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            SubsflControlProps_742( ) ;
            GXPagingFrom2 = (int)(((10==0) ? 0 : GRID1_nFirstRecordOnPage));
            GXPagingTo2 = ((10==0) ? 10000 : subGrid1_Recordsperpage( )+1);
            pr_default.dynParam(0, new Object[]{ new Object[]{
                                                 AV7cSocioSexo ,
                                                 AV8cSocioEdad ,
                                                 AV10cSocioReconocido ,
                                                 AV14cSocioTipoCuota ,
                                                 AV15cCarnetId ,
                                                 A19SocioSexo ,
                                                 A20SocioEdad ,
                                                 A24SocioReconocido ,
                                                 A33SocioTipoCuota ,
                                                 A36CarnetId ,
                                                 AV6cSocioId } ,
                                                 new int[]{
                                                 TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.SHORT,
                                                 TypeConstants.SHORT
                                                 }
            } ) ;
            lV7cSocioSexo = StringUtil.PadR( StringUtil.RTrim( AV7cSocioSexo), 20, "%");
            lV14cSocioTipoCuota = StringUtil.PadR( StringUtil.RTrim( AV14cSocioTipoCuota), 20, "%");
            /* Using cursor H000Y2 */
            pr_default.execute(0, new Object[] {AV6cSocioId, lV7cSocioSexo, AV8cSocioEdad, AV10cSocioReconocido, lV14cSocioTipoCuota, AV15cCarnetId, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_74_idx = 1;
            sGXsfl_74_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_74_idx), 4, 0)), 4, "0");
            SubsflControlProps_742( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( 10 == 0 ) || ( GRID1_nCurrentRecord < subGrid1_Recordsperpage( ) ) ) ) )
            {
               A36CarnetId = H000Y2_A36CarnetId[0];
               A33SocioTipoCuota = H000Y2_A33SocioTipoCuota[0];
               A40000SocioFoto_GXI = H000Y2_A40000SocioFoto_GXI[0];
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSocioFoto_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A21SocioFoto)) ? A40000SocioFoto_GXI : context.convertURL( context.PathToRelativeUrl( A21SocioFoto))), !bGXsfl_74_Refreshing);
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSocioFoto_Internalname, "SrcSet", context.GetImageSrcSet( A21SocioFoto), true);
               A24SocioReconocido = H000Y2_A24SocioReconocido[0];
               A20SocioEdad = H000Y2_A20SocioEdad[0];
               A19SocioSexo = H000Y2_A19SocioSexo[0];
               A5SocioId = H000Y2_A5SocioId[0];
               A21SocioFoto = H000Y2_A21SocioFoto[0];
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSocioFoto_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A21SocioFoto)) ? A40000SocioFoto_GXI : context.convertURL( context.PathToRelativeUrl( A21SocioFoto))), !bGXsfl_74_Refreshing);
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSocioFoto_Internalname, "SrcSet", context.GetImageSrcSet( A21SocioFoto), true);
               /* Execute user event: Load */
               E190Y2 ();
               pr_default.readNext(0);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 74;
            WB0Y0( ) ;
         }
         bGXsfl_74_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes0Y2( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_SOCIOID"+"_"+sGXsfl_74_idx, GetSecureSignedToken( sGXsfl_74_idx, context.localUtil.Format( (decimal)(A5SocioId), "ZZZ9"), context));
      }

      protected int subGrid1_Pagecount( )
      {
         GRID1_nRecordCount = subGrid1_Recordcount( );
         if ( ((int)((GRID1_nRecordCount) % (subGrid1_Recordsperpage( )))) == 0 )
         {
            return (int)(NumberUtil.Int( (long)(GRID1_nRecordCount/ (decimal)(subGrid1_Recordsperpage( ))))) ;
         }
         return (int)(NumberUtil.Int( (long)(GRID1_nRecordCount/ (decimal)(subGrid1_Recordsperpage( ))))+1) ;
      }

      protected int subGrid1_Recordcount( )
      {
         pr_default.dynParam(1, new Object[]{ new Object[]{
                                              AV7cSocioSexo ,
                                              AV8cSocioEdad ,
                                              AV10cSocioReconocido ,
                                              AV14cSocioTipoCuota ,
                                              AV15cCarnetId ,
                                              A19SocioSexo ,
                                              A20SocioEdad ,
                                              A24SocioReconocido ,
                                              A33SocioTipoCuota ,
                                              A36CarnetId ,
                                              AV6cSocioId } ,
                                              new int[]{
                                              TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.SHORT,
                                              TypeConstants.SHORT
                                              }
         } ) ;
         lV7cSocioSexo = StringUtil.PadR( StringUtil.RTrim( AV7cSocioSexo), 20, "%");
         lV14cSocioTipoCuota = StringUtil.PadR( StringUtil.RTrim( AV14cSocioTipoCuota), 20, "%");
         /* Using cursor H000Y3 */
         pr_default.execute(1, new Object[] {AV6cSocioId, lV7cSocioSexo, AV8cSocioEdad, AV10cSocioReconocido, lV14cSocioTipoCuota, AV15cCarnetId});
         GRID1_nRecordCount = H000Y3_AGRID1_nRecordCount[0];
         pr_default.close(1);
         return (int)(GRID1_nRecordCount) ;
      }

      protected int subGrid1_Recordsperpage( )
      {
         return (int)(10*1) ;
      }

      protected int subGrid1_Currentpage( )
      {
         return (int)(NumberUtil.Int( (long)(GRID1_nFirstRecordOnPage/ (decimal)(subGrid1_Recordsperpage( ))))+1) ;
      }

      protected short subgrid1_firstpage( )
      {
         GRID1_nFirstRecordOnPage = 0;
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid1_refresh( subGrid1_Rows, AV6cSocioId, AV7cSocioSexo, AV8cSocioEdad, AV10cSocioReconocido, AV14cSocioTipoCuota, AV15cCarnetId) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid1_nextpage( )
      {
         GRID1_nRecordCount = subGrid1_Recordcount( );
         if ( ( GRID1_nRecordCount >= subGrid1_Recordsperpage( ) ) && ( GRID1_nEOF == 0 ) )
         {
            GRID1_nFirstRecordOnPage = (long)(GRID1_nFirstRecordOnPage+subGrid1_Recordsperpage( ));
         }
         else
         {
            return 2 ;
         }
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ".", "")));
         Grid1Container.AddObjectProperty("GRID1_nFirstRecordOnPage", GRID1_nFirstRecordOnPage);
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid1_refresh( subGrid1_Rows, AV6cSocioId, AV7cSocioSexo, AV8cSocioEdad, AV10cSocioReconocido, AV14cSocioTipoCuota, AV15cCarnetId) ;
         }
         send_integrity_footer_hashes( ) ;
         return (short)(((GRID1_nEOF==0) ? 0 : 2)) ;
      }

      protected short subgrid1_previouspage( )
      {
         if ( GRID1_nFirstRecordOnPage >= subGrid1_Recordsperpage( ) )
         {
            GRID1_nFirstRecordOnPage = (long)(GRID1_nFirstRecordOnPage-subGrid1_Recordsperpage( ));
         }
         else
         {
            return 2 ;
         }
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid1_refresh( subGrid1_Rows, AV6cSocioId, AV7cSocioSexo, AV8cSocioEdad, AV10cSocioReconocido, AV14cSocioTipoCuota, AV15cCarnetId) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid1_lastpage( )
      {
         GRID1_nRecordCount = subGrid1_Recordcount( );
         if ( GRID1_nRecordCount > subGrid1_Recordsperpage( ) )
         {
            if ( ((int)((GRID1_nRecordCount) % (subGrid1_Recordsperpage( )))) == 0 )
            {
               GRID1_nFirstRecordOnPage = (long)(GRID1_nRecordCount-subGrid1_Recordsperpage( ));
            }
            else
            {
               GRID1_nFirstRecordOnPage = (long)(GRID1_nRecordCount-((int)((GRID1_nRecordCount) % (subGrid1_Recordsperpage( )))));
            }
         }
         else
         {
            GRID1_nFirstRecordOnPage = 0;
         }
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid1_refresh( subGrid1_Rows, AV6cSocioId, AV7cSocioSexo, AV8cSocioEdad, AV10cSocioReconocido, AV14cSocioTipoCuota, AV15cCarnetId) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected int subgrid1_gotopage( int nPageNo )
      {
         if ( nPageNo > 0 )
         {
            GRID1_nFirstRecordOnPage = (long)(subGrid1_Recordsperpage( )*(nPageNo-1));
         }
         else
         {
            GRID1_nFirstRecordOnPage = 0;
         }
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid1_refresh( subGrid1_Rows, AV6cSocioId, AV7cSocioSexo, AV8cSocioEdad, AV10cSocioReconocido, AV14cSocioTipoCuota, AV15cCarnetId) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP0Y0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E180Y2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCsocioid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCsocioid_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCSOCIOID");
               GX_FocusControl = edtavCsocioid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV6cSocioId = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cSocioId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cSocioId), 4, 0)));
            }
            else
            {
               AV6cSocioId = (short)(context.localUtil.CToN( cgiGet( edtavCsocioid_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cSocioId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cSocioId), 4, 0)));
            }
            cmbavCsociosexo.Name = cmbavCsociosexo_Internalname;
            cmbavCsociosexo.CurrentValue = cgiGet( cmbavCsociosexo_Internalname);
            AV7cSocioSexo = cgiGet( cmbavCsociosexo_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cSocioSexo", AV7cSocioSexo);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCsocioedad_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCsocioedad_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCSOCIOEDAD");
               GX_FocusControl = edtavCsocioedad_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV8cSocioEdad = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cSocioEdad", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8cSocioEdad), 4, 0)));
            }
            else
            {
               AV8cSocioEdad = (short)(context.localUtil.CToN( cgiGet( edtavCsocioedad_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cSocioEdad", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8cSocioEdad), 4, 0)));
            }
            AV10cSocioReconocido = StringUtil.StrToBool( cgiGet( chkavCsocioreconocido_Internalname));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cSocioReconocido", AV10cSocioReconocido);
            cmbavCsociotipocuota.Name = cmbavCsociotipocuota_Internalname;
            cmbavCsociotipocuota.CurrentValue = cgiGet( cmbavCsociotipocuota_Internalname);
            AV14cSocioTipoCuota = cgiGet( cmbavCsociotipocuota_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14cSocioTipoCuota", AV14cSocioTipoCuota);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCcarnetid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCcarnetid_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCCARNETID");
               GX_FocusControl = edtavCcarnetid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV15cCarnetId = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15cCarnetId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15cCarnetId), 4, 0)));
            }
            else
            {
               AV15cCarnetId = (short)(context.localUtil.CToN( cgiGet( edtavCcarnetid_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15cCarnetId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15cCarnetId), 4, 0)));
            }
            /* Read saved values. */
            nRC_GXsfl_74 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_74"), ".", ","));
            GRID1_nFirstRecordOnPage = (long)(context.localUtil.CToN( cgiGet( "GRID1_nFirstRecordOnPage"), ".", ","));
            GRID1_nEOF = (short)(context.localUtil.CToN( cgiGet( "GRID1_nEOF"), ".", ","));
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            /* Check if conditions changed and reset current page numbers */
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCSOCIOID"), ".", ",") != Convert.ToDecimal( AV6cSocioId )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCSOCIOSEXO"), AV7cSocioSexo) != 0 )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCSOCIOEDAD"), ".", ",") != Convert.ToDecimal( AV8cSocioEdad )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrToBool( cgiGet( "GXH_vCSOCIORECONOCIDO")) != AV10cSocioReconocido )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCSOCIOTIPOCUOTA"), AV14cSocioTipoCuota) != 0 )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCCARNETID"), ".", ",") != Convert.ToDecimal( AV15cCarnetId )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      protected void GXStart( )
      {
         /* Execute user event: Start */
         E180Y2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E180Y2( )
      {
         /* Start Routine */
         Form.Caption = StringUtil.Format( "Selection List %1", "Socio", "", "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption, true);
         AV12ADVANCED_LABEL_TEMPLATE = "%1 <strong>%2</strong>";
      }

      private void E190Y2( )
      {
         /* Load Routine */
         AV5LinkSelection = context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavLinkselection_Internalname, AV5LinkSelection);
         AV18Linkselection_GXI = GXDbFile.PathToUrl( context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( )));
         sendrow_742( ) ;
         GRID1_nCurrentRecord = (long)(GRID1_nCurrentRecord+1);
         if ( isFullAjaxMode( ) && ! bGXsfl_74_Refreshing )
         {
            context.DoAjaxLoad(74, Grid1Row);
         }
      }

      public void GXEnter( )
      {
         /* Execute user event: Enter */
         E200Y2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E200Y2( )
      {
         /* Enter Routine */
         AV11pSocioId = A5SocioId;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11pSocioId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11pSocioId), 4, 0)));
         context.setWebReturnParms(new Object[] {(short)AV11pSocioId});
         context.setWebReturnParmsMetadata(new Object[] {"AV11pSocioId"});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
         /*  Sending Event outputs  */
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV11pSocioId = Convert.ToInt16(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11pSocioId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11pSocioId), 4, 0)));
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
         PA0Y2( ) ;
         WS0Y2( ) ;
         WE0Y2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20194121731618", true);
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
         context.AddJavascriptSource("gx0040.js", "?20194121731619", false);
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_742( )
      {
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_74_idx;
         edtSocioId_Internalname = "SOCIOID_"+sGXsfl_74_idx;
         cmbSocioSexo_Internalname = "SOCIOSEXO_"+sGXsfl_74_idx;
         edtSocioEdad_Internalname = "SOCIOEDAD_"+sGXsfl_74_idx;
         chkSocioReconocido_Internalname = "SOCIORECONOCIDO_"+sGXsfl_74_idx;
         edtSocioFoto_Internalname = "SOCIOFOTO_"+sGXsfl_74_idx;
         cmbSocioTipoCuota_Internalname = "SOCIOTIPOCUOTA_"+sGXsfl_74_idx;
         edtCarnetId_Internalname = "CARNETID_"+sGXsfl_74_idx;
      }

      protected void SubsflControlProps_fel_742( )
      {
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_74_fel_idx;
         edtSocioId_Internalname = "SOCIOID_"+sGXsfl_74_fel_idx;
         cmbSocioSexo_Internalname = "SOCIOSEXO_"+sGXsfl_74_fel_idx;
         edtSocioEdad_Internalname = "SOCIOEDAD_"+sGXsfl_74_fel_idx;
         chkSocioReconocido_Internalname = "SOCIORECONOCIDO_"+sGXsfl_74_fel_idx;
         edtSocioFoto_Internalname = "SOCIOFOTO_"+sGXsfl_74_fel_idx;
         cmbSocioTipoCuota_Internalname = "SOCIOTIPOCUOTA_"+sGXsfl_74_fel_idx;
         edtCarnetId_Internalname = "CARNETID_"+sGXsfl_74_fel_idx;
      }

      protected void sendrow_742( )
      {
         SubsflControlProps_742( ) ;
         WB0Y0( ) ;
         if ( ( 10 * 1 == 0 ) || ( nGXsfl_74_idx <= subGrid1_Recordsperpage( ) * 1 ) )
         {
            Grid1Row = GXWebRow.GetNew(context,Grid1Container);
            if ( subGrid1_Backcolorstyle == 0 )
            {
               /* None style subfile background logic. */
               subGrid1_Backstyle = 0;
               if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
               {
                  subGrid1_Linesclass = subGrid1_Class+"Odd";
               }
            }
            else if ( subGrid1_Backcolorstyle == 1 )
            {
               /* Uniform style subfile background logic. */
               subGrid1_Backstyle = 0;
               subGrid1_Backcolor = subGrid1_Allbackcolor;
               if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
               {
                  subGrid1_Linesclass = subGrid1_Class+"Uniform";
               }
            }
            else if ( subGrid1_Backcolorstyle == 2 )
            {
               /* Header style subfile background logic. */
               subGrid1_Backstyle = 1;
               if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
               {
                  subGrid1_Linesclass = subGrid1_Class+"Odd";
               }
               subGrid1_Backcolor = (int)(0x0);
            }
            else if ( subGrid1_Backcolorstyle == 3 )
            {
               /* Report style subfile background logic. */
               subGrid1_Backstyle = 1;
               if ( ((int)(((nGXsfl_74_idx-1)/ (decimal)(1)) % (2))) == 0 )
               {
                  subGrid1_Backcolor = (int)(0x0);
                  if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
                  {
                     subGrid1_Linesclass = subGrid1_Class+"Odd";
                  }
               }
               else
               {
                  subGrid1_Backcolor = (int)(0x0);
                  if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
                  {
                     subGrid1_Linesclass = subGrid1_Class+"Even";
                  }
               }
            }
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<tr ") ;
               context.WriteHtmlText( " class=\""+"PromptGrid"+"\" style=\""+""+"\"") ;
               context.WriteHtmlText( " gxrow=\""+sGXsfl_74_idx+"\">") ;
            }
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Static Bitmap Variable */
            edtavLinkselection_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A5SocioId), 4, 0, ".", "")))+"'"+"]);";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Link", edtavLinkselection_Link, !bGXsfl_74_Refreshing);
            ClassString = "SelectionAttribute";
            StyleString = "";
            AV5LinkSelection_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection))&&String.IsNullOrEmpty(StringUtil.RTrim( AV18Linkselection_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)) ? AV18Linkselection_GXI : context.PathToRelativeUrl( AV5LinkSelection));
            Grid1Row.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavLinkselection_Internalname,(String)sImgUrl,(String)edtavLinkselection_Link,(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)"",(short)1,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV5LinkSelection_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "DescriptionAttribute";
            edtSocioId_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A5SocioId), 4, 0, ".", "")))+"'"+"]);";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSocioId_Internalname, "Link", edtSocioId_Link, !bGXsfl_74_Refreshing);
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSocioId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A5SocioId), 4, 0, ".", "")),context.localUtil.Format( (decimal)(A5SocioId), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)edtSocioId_Link,(String)"",(String)"",(String)"",(String)edtSocioId_Jsonclick,(short)0,(String)"DescriptionAttribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)74,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            if ( ( cmbSocioSexo.ItemCount == 0 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "SOCIOSEXO_" + sGXsfl_74_idx;
               cmbSocioSexo.Name = GXCCtl;
               cmbSocioSexo.WebTags = "";
               cmbSocioSexo.addItem("Hombre", "H", 0);
               cmbSocioSexo.addItem("Mujer", "M", 0);
               cmbSocioSexo.addItem("Otro", "O", 0);
               if ( cmbSocioSexo.ItemCount > 0 )
               {
                  A19SocioSexo = cmbSocioSexo.getValidValue(A19SocioSexo);
               }
            }
            /* ComboBox */
            Grid1Row.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbSocioSexo,(String)cmbSocioSexo_Internalname,StringUtil.RTrim( A19SocioSexo),(short)1,(String)cmbSocioSexo_Jsonclick,(short)0,(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"char",(String)"",(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)"",(String)"Attribute",(String)"WWColumn OptionalColumn",(String)"",(String)"",(String)"",(bool)true});
            cmbSocioSexo.CurrentValue = StringUtil.RTrim( A19SocioSexo);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbSocioSexo_Internalname, "Values", (String)(cmbSocioSexo.ToJavascriptSource()), !bGXsfl_74_Refreshing);
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSocioEdad_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A20SocioEdad), 4, 0, ".", "")),context.localUtil.Format( (decimal)(A20SocioEdad), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtSocioEdad_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)74,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Check box */
            ClassString = "Attribute";
            StyleString = "";
            Grid1Row.AddColumnProperties("checkbox", 1, isAjaxCallMode( ), new Object[] {(String)chkSocioReconocido_Internalname,StringUtil.BoolToStr( A24SocioReconocido),(String)"",(String)"",(short)-1,(short)0,(String)"true",(String)"",(String)StyleString,(String)ClassString,(String)"WWColumn OptionalColumn",(String)"",(String)""});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "ImageAttribute";
            StyleString = "";
            A21SocioFoto_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( A21SocioFoto))&&String.IsNullOrEmpty(StringUtil.RTrim( A40000SocioFoto_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( A21SocioFoto)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( A21SocioFoto)) ? A40000SocioFoto_GXI : context.PathToRelativeUrl( A21SocioFoto));
            Grid1Row.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtSocioFoto_Internalname,(String)sImgUrl,(String)"",(String)"",(String)"",context.GetTheme( ),(short)-1,(short)0,(String)"",(String)"",(short)1,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWColumn OptionalColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)A21SocioFoto_IsBlob,(bool)true,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            if ( ( cmbSocioTipoCuota.ItemCount == 0 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "SOCIOTIPOCUOTA_" + sGXsfl_74_idx;
               cmbSocioTipoCuota.Name = GXCCtl;
               cmbSocioTipoCuota.WebTags = "";
               cmbSocioTipoCuota.addItem("V", "Verano", 0);
               cmbSocioTipoCuota.addItem("P", "Permanente", 0);
               if ( cmbSocioTipoCuota.ItemCount > 0 )
               {
                  A33SocioTipoCuota = cmbSocioTipoCuota.getValidValue(A33SocioTipoCuota);
               }
            }
            /* ComboBox */
            Grid1Row.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbSocioTipoCuota,(String)cmbSocioTipoCuota_Internalname,StringUtil.RTrim( A33SocioTipoCuota),(short)1,(String)cmbSocioTipoCuota_Jsonclick,(short)0,(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"char",(String)"",(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)"",(String)"Attribute",(String)"WWColumn OptionalColumn",(String)"",(String)"",(String)"",(bool)true});
            cmbSocioTipoCuota.CurrentValue = StringUtil.RTrim( A33SocioTipoCuota);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbSocioTipoCuota_Internalname, "Values", (String)(cmbSocioTipoCuota.ToJavascriptSource()), !bGXsfl_74_Refreshing);
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtCarnetId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A36CarnetId), 4, 0, ".", "")),context.localUtil.Format( (decimal)(A36CarnetId), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtCarnetId_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)74,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            send_integrity_lvl_hashes0Y2( ) ;
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_74_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_74_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_74_idx+1));
            sGXsfl_74_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_74_idx), 4, 0)), 4, "0");
            SubsflControlProps_742( ) ;
         }
         /* End function sendrow_742 */
      }

      protected void init_web_controls( )
      {
         cmbavCsociosexo.Name = "vCSOCIOSEXO";
         cmbavCsociosexo.WebTags = "";
         cmbavCsociosexo.addItem("Hombre", "H", 0);
         cmbavCsociosexo.addItem("Mujer", "M", 0);
         cmbavCsociosexo.addItem("Otro", "O", 0);
         if ( cmbavCsociosexo.ItemCount > 0 )
         {
            AV7cSocioSexo = cmbavCsociosexo.getValidValue(AV7cSocioSexo);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cSocioSexo", AV7cSocioSexo);
         }
         chkavCsocioreconocido.Name = "vCSOCIORECONOCIDO";
         chkavCsocioreconocido.WebTags = "";
         chkavCsocioreconocido.Caption = "";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavCsocioreconocido_Internalname, "TitleCaption", chkavCsocioreconocido.Caption, true);
         chkavCsocioreconocido.CheckedValue = "false";
         cmbavCsociotipocuota.Name = "vCSOCIOTIPOCUOTA";
         cmbavCsociotipocuota.WebTags = "";
         cmbavCsociotipocuota.addItem("V", "Verano", 0);
         cmbavCsociotipocuota.addItem("P", "Permanente", 0);
         if ( cmbavCsociotipocuota.ItemCount > 0 )
         {
            AV14cSocioTipoCuota = cmbavCsociotipocuota.getValidValue(AV14cSocioTipoCuota);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14cSocioTipoCuota", AV14cSocioTipoCuota);
         }
         GXCCtl = "SOCIOSEXO_" + sGXsfl_74_idx;
         cmbSocioSexo.Name = GXCCtl;
         cmbSocioSexo.WebTags = "";
         cmbSocioSexo.addItem("Hombre", "H", 0);
         cmbSocioSexo.addItem("Mujer", "M", 0);
         cmbSocioSexo.addItem("Otro", "O", 0);
         if ( cmbSocioSexo.ItemCount > 0 )
         {
            A19SocioSexo = cmbSocioSexo.getValidValue(A19SocioSexo);
         }
         GXCCtl = "SOCIORECONOCIDO_" + sGXsfl_74_idx;
         chkSocioReconocido.Name = GXCCtl;
         chkSocioReconocido.WebTags = "";
         chkSocioReconocido.Caption = "";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkSocioReconocido_Internalname, "TitleCaption", chkSocioReconocido.Caption, !bGXsfl_74_Refreshing);
         chkSocioReconocido.CheckedValue = "false";
         GXCCtl = "SOCIOTIPOCUOTA_" + sGXsfl_74_idx;
         cmbSocioTipoCuota.Name = GXCCtl;
         cmbSocioTipoCuota.WebTags = "";
         cmbSocioTipoCuota.addItem("V", "Verano", 0);
         cmbSocioTipoCuota.addItem("P", "Permanente", 0);
         if ( cmbSocioTipoCuota.ItemCount > 0 )
         {
            A33SocioTipoCuota = cmbSocioTipoCuota.getValidValue(A33SocioTipoCuota);
         }
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         lblLblsocioidfilter_Internalname = "LBLSOCIOIDFILTER";
         edtavCsocioid_Internalname = "vCSOCIOID";
         divSocioidfiltercontainer_Internalname = "SOCIOIDFILTERCONTAINER";
         lblLblsociosexofilter_Internalname = "LBLSOCIOSEXOFILTER";
         cmbavCsociosexo_Internalname = "vCSOCIOSEXO";
         divSociosexofiltercontainer_Internalname = "SOCIOSEXOFILTERCONTAINER";
         lblLblsocioedadfilter_Internalname = "LBLSOCIOEDADFILTER";
         edtavCsocioedad_Internalname = "vCSOCIOEDAD";
         divSocioedadfiltercontainer_Internalname = "SOCIOEDADFILTERCONTAINER";
         lblLblsocioreconocidofilter_Internalname = "LBLSOCIORECONOCIDOFILTER";
         chkavCsocioreconocido_Internalname = "vCSOCIORECONOCIDO";
         divSocioreconocidofiltercontainer_Internalname = "SOCIORECONOCIDOFILTERCONTAINER";
         lblLblsociotipocuotafilter_Internalname = "LBLSOCIOTIPOCUOTAFILTER";
         cmbavCsociotipocuota_Internalname = "vCSOCIOTIPOCUOTA";
         divSociotipocuotafiltercontainer_Internalname = "SOCIOTIPOCUOTAFILTERCONTAINER";
         lblLblcarnetidfilter_Internalname = "LBLCARNETIDFILTER";
         edtavCcarnetid_Internalname = "vCCARNETID";
         divCarnetidfiltercontainer_Internalname = "CARNETIDFILTERCONTAINER";
         divAdvancedcontainer_Internalname = "ADVANCEDCONTAINER";
         bttBtntoggle_Internalname = "BTNTOGGLE";
         edtavLinkselection_Internalname = "vLINKSELECTION";
         edtSocioId_Internalname = "SOCIOID";
         cmbSocioSexo_Internalname = "SOCIOSEXO";
         edtSocioEdad_Internalname = "SOCIOEDAD";
         chkSocioReconocido_Internalname = "SOCIORECONOCIDO";
         edtSocioFoto_Internalname = "SOCIOFOTO";
         cmbSocioTipoCuota_Internalname = "SOCIOTIPOCUOTA";
         edtCarnetId_Internalname = "CARNETID";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         divGridtable_Internalname = "GRIDTABLE";
         divMain_Internalname = "MAIN";
         Form.Internalname = "FORM";
         subGrid1_Internalname = "GRID1";
      }

      public override void initialize_properties( )
      {
         context.SetDefaultTheme("Carmine");
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_default_properties( ) ;
         chkSocioReconocido.Caption = "";
         chkavCsocioreconocido.Caption = "Socio Reconocido";
         edtCarnetId_Jsonclick = "";
         cmbSocioTipoCuota_Jsonclick = "";
         edtSocioEdad_Jsonclick = "";
         cmbSocioSexo_Jsonclick = "";
         edtSocioId_Jsonclick = "";
         subGrid1_Allowcollapsing = 0;
         subGrid1_Allowselection = 0;
         edtSocioId_Link = "";
         edtavLinkselection_Link = "";
         subGrid1_Header = "";
         subGrid1_Class = "PromptGrid";
         subGrid1_Backcolorstyle = 0;
         edtavCcarnetid_Jsonclick = "";
         edtavCcarnetid_Enabled = 1;
         edtavCcarnetid_Visible = 1;
         cmbavCsociotipocuota_Jsonclick = "";
         cmbavCsociotipocuota.Enabled = 1;
         cmbavCsociotipocuota.Visible = 1;
         chkavCsocioreconocido.Enabled = 1;
         chkavCsocioreconocido.Visible = 1;
         edtavCsocioedad_Jsonclick = "";
         edtavCsocioedad_Enabled = 1;
         edtavCsocioedad_Visible = 1;
         cmbavCsociosexo_Jsonclick = "";
         cmbavCsociosexo.Enabled = 1;
         cmbavCsociosexo.Visible = 1;
         edtavCsocioid_Jsonclick = "";
         edtavCsocioid_Enabled = 1;
         edtavCsocioid_Visible = 1;
         divCarnetidfiltercontainer_Class = "AdvancedContainerItem";
         divSociotipocuotafiltercontainer_Class = "AdvancedContainerItem";
         divSocioreconocidofiltercontainer_Class = "AdvancedContainerItem";
         divSocioedadfiltercontainer_Class = "AdvancedContainerItem";
         divSociosexofiltercontainer_Class = "AdvancedContainerItem";
         divSocioidfiltercontainer_Class = "AdvancedContainerItem";
         bttBtntoggle_Class = "BtnToggle";
         divAdvancedcontainer_Class = "AdvancedContainerVisible";
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Selection List Socio";
         subGrid1_Rows = 10;
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows',ctrl:'GRID1',prop:'Rows'},{av:'AV6cSocioId',fld:'vCSOCIOID',pic:'ZZZ9'},{av:'cmbavCsociosexo'},{av:'AV7cSocioSexo',fld:'vCSOCIOSEXO',pic:''},{av:'AV8cSocioEdad',fld:'vCSOCIOEDAD',pic:'ZZZ9'},{av:'AV10cSocioReconocido',fld:'vCSOCIORECONOCIDO',pic:''},{av:'cmbavCsociotipocuota'},{av:'AV14cSocioTipoCuota',fld:'vCSOCIOTIPOCUOTA',pic:''},{av:'AV15cCarnetId',fld:'vCCARNETID',pic:'ZZZ9'}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("'TOGGLE'","{handler:'E170Y1',iparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER',prop:'Class'},{ctrl:'BTNTOGGLE',prop:'Class'}]");
         setEventMetadata("'TOGGLE'",",oparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER',prop:'Class'},{ctrl:'BTNTOGGLE',prop:'Class'}]}");
         setEventMetadata("LBLSOCIOIDFILTER.CLICK","{handler:'E110Y1',iparms:[{av:'divSocioidfiltercontainer_Class',ctrl:'SOCIOIDFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLSOCIOIDFILTER.CLICK",",oparms:[{av:'divSocioidfiltercontainer_Class',ctrl:'SOCIOIDFILTERCONTAINER',prop:'Class'},{av:'edtavCsocioid_Visible',ctrl:'vCSOCIOID',prop:'Visible'}]}");
         setEventMetadata("LBLSOCIOSEXOFILTER.CLICK","{handler:'E120Y1',iparms:[{av:'divSociosexofiltercontainer_Class',ctrl:'SOCIOSEXOFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLSOCIOSEXOFILTER.CLICK",",oparms:[{av:'divSociosexofiltercontainer_Class',ctrl:'SOCIOSEXOFILTERCONTAINER',prop:'Class'},{av:'cmbavCsociosexo'}]}");
         setEventMetadata("LBLSOCIOEDADFILTER.CLICK","{handler:'E130Y1',iparms:[{av:'divSocioedadfiltercontainer_Class',ctrl:'SOCIOEDADFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLSOCIOEDADFILTER.CLICK",",oparms:[{av:'divSocioedadfiltercontainer_Class',ctrl:'SOCIOEDADFILTERCONTAINER',prop:'Class'},{av:'edtavCsocioedad_Visible',ctrl:'vCSOCIOEDAD',prop:'Visible'}]}");
         setEventMetadata("LBLSOCIORECONOCIDOFILTER.CLICK","{handler:'E140Y1',iparms:[{av:'divSocioreconocidofiltercontainer_Class',ctrl:'SOCIORECONOCIDOFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLSOCIORECONOCIDOFILTER.CLICK",",oparms:[{av:'divSocioreconocidofiltercontainer_Class',ctrl:'SOCIORECONOCIDOFILTERCONTAINER',prop:'Class'},{av:'chkavCsocioreconocido.Visible',ctrl:'vCSOCIORECONOCIDO',prop:'Visible'}]}");
         setEventMetadata("LBLSOCIOTIPOCUOTAFILTER.CLICK","{handler:'E150Y1',iparms:[{av:'divSociotipocuotafiltercontainer_Class',ctrl:'SOCIOTIPOCUOTAFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLSOCIOTIPOCUOTAFILTER.CLICK",",oparms:[{av:'divSociotipocuotafiltercontainer_Class',ctrl:'SOCIOTIPOCUOTAFILTERCONTAINER',prop:'Class'},{av:'cmbavCsociotipocuota'}]}");
         setEventMetadata("LBLCARNETIDFILTER.CLICK","{handler:'E160Y1',iparms:[{av:'divCarnetidfiltercontainer_Class',ctrl:'CARNETIDFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLCARNETIDFILTER.CLICK",",oparms:[{av:'divCarnetidfiltercontainer_Class',ctrl:'CARNETIDFILTERCONTAINER',prop:'Class'},{av:'edtavCcarnetid_Visible',ctrl:'vCCARNETID',prop:'Visible'}]}");
         setEventMetadata("ENTER","{handler:'E200Y2',iparms:[{av:'A5SocioId',fld:'SOCIOID',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[{av:'AV11pSocioId',fld:'vPSOCIOID',pic:'ZZZ9'}]}");
         setEventMetadata("GRID1_FIRSTPAGE","{handler:'subgrid1_firstpage',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows',ctrl:'GRID1',prop:'Rows'},{av:'AV6cSocioId',fld:'vCSOCIOID',pic:'ZZZ9'},{av:'cmbavCsociosexo'},{av:'AV7cSocioSexo',fld:'vCSOCIOSEXO',pic:''},{av:'AV8cSocioEdad',fld:'vCSOCIOEDAD',pic:'ZZZ9'},{av:'AV10cSocioReconocido',fld:'vCSOCIORECONOCIDO',pic:''},{av:'cmbavCsociotipocuota'},{av:'AV14cSocioTipoCuota',fld:'vCSOCIOTIPOCUOTA',pic:''},{av:'AV15cCarnetId',fld:'vCCARNETID',pic:'ZZZ9'}]");
         setEventMetadata("GRID1_FIRSTPAGE",",oparms:[]}");
         setEventMetadata("GRID1_PREVPAGE","{handler:'subgrid1_previouspage',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows',ctrl:'GRID1',prop:'Rows'},{av:'AV6cSocioId',fld:'vCSOCIOID',pic:'ZZZ9'},{av:'cmbavCsociosexo'},{av:'AV7cSocioSexo',fld:'vCSOCIOSEXO',pic:''},{av:'AV8cSocioEdad',fld:'vCSOCIOEDAD',pic:'ZZZ9'},{av:'AV10cSocioReconocido',fld:'vCSOCIORECONOCIDO',pic:''},{av:'cmbavCsociotipocuota'},{av:'AV14cSocioTipoCuota',fld:'vCSOCIOTIPOCUOTA',pic:''},{av:'AV15cCarnetId',fld:'vCCARNETID',pic:'ZZZ9'}]");
         setEventMetadata("GRID1_PREVPAGE",",oparms:[]}");
         setEventMetadata("GRID1_NEXTPAGE","{handler:'subgrid1_nextpage',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows',ctrl:'GRID1',prop:'Rows'},{av:'AV6cSocioId',fld:'vCSOCIOID',pic:'ZZZ9'},{av:'cmbavCsociosexo'},{av:'AV7cSocioSexo',fld:'vCSOCIOSEXO',pic:''},{av:'AV8cSocioEdad',fld:'vCSOCIOEDAD',pic:'ZZZ9'},{av:'AV10cSocioReconocido',fld:'vCSOCIORECONOCIDO',pic:''},{av:'cmbavCsociotipocuota'},{av:'AV14cSocioTipoCuota',fld:'vCSOCIOTIPOCUOTA',pic:''},{av:'AV15cCarnetId',fld:'vCCARNETID',pic:'ZZZ9'}]");
         setEventMetadata("GRID1_NEXTPAGE",",oparms:[]}");
         setEventMetadata("GRID1_LASTPAGE","{handler:'subgrid1_lastpage',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows',ctrl:'GRID1',prop:'Rows'},{av:'AV6cSocioId',fld:'vCSOCIOID',pic:'ZZZ9'},{av:'cmbavCsociosexo'},{av:'AV7cSocioSexo',fld:'vCSOCIOSEXO',pic:''},{av:'AV8cSocioEdad',fld:'vCSOCIOEDAD',pic:'ZZZ9'},{av:'AV10cSocioReconocido',fld:'vCSOCIORECONOCIDO',pic:''},{av:'cmbavCsociotipocuota'},{av:'AV14cSocioTipoCuota',fld:'vCSOCIOTIPOCUOTA',pic:''},{av:'AV15cCarnetId',fld:'vCCARNETID',pic:'ZZZ9'}]");
         setEventMetadata("GRID1_LASTPAGE",",oparms:[]}");
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
         AV7cSocioSexo = "";
         AV14cSocioTipoCuota = "";
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         lblLblsocioidfilter_Jsonclick = "";
         TempTags = "";
         lblLblsociosexofilter_Jsonclick = "";
         lblLblsocioedadfilter_Jsonclick = "";
         lblLblsocioreconocidofilter_Jsonclick = "";
         ClassString = "";
         StyleString = "";
         lblLblsociotipocuotafilter_Jsonclick = "";
         lblLblcarnetidfilter_Jsonclick = "";
         bttBtntoggle_Jsonclick = "";
         Grid1Container = new GXWebGrid( context);
         sStyleString = "";
         subGrid1_Linesclass = "";
         Grid1Column = new GXWebColumn();
         AV5LinkSelection = "";
         A19SocioSexo = "";
         A21SocioFoto = "";
         A33SocioTipoCuota = "";
         bttBtn_cancel_Jsonclick = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV18Linkselection_GXI = "";
         A40000SocioFoto_GXI = "";
         scmdbuf = "";
         lV7cSocioSexo = "";
         lV14cSocioTipoCuota = "";
         H000Y2_A36CarnetId = new short[1] ;
         H000Y2_A33SocioTipoCuota = new String[] {""} ;
         H000Y2_A40000SocioFoto_GXI = new String[] {""} ;
         H000Y2_A24SocioReconocido = new bool[] {false} ;
         H000Y2_A20SocioEdad = new short[1] ;
         H000Y2_A19SocioSexo = new String[] {""} ;
         H000Y2_A5SocioId = new short[1] ;
         H000Y2_A21SocioFoto = new String[] {""} ;
         H000Y3_AGRID1_nRecordCount = new long[1] ;
         AV12ADVANCED_LABEL_TEMPLATE = "";
         Grid1Row = new GXWebRow();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sImgUrl = "";
         ROClassString = "";
         GXCCtl = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gx0040__default(),
            new Object[][] {
                new Object[] {
               H000Y2_A36CarnetId, H000Y2_A33SocioTipoCuota, H000Y2_A40000SocioFoto_GXI, H000Y2_A24SocioReconocido, H000Y2_A20SocioEdad, H000Y2_A19SocioSexo, H000Y2_A5SocioId, H000Y2_A21SocioFoto
               }
               , new Object[] {
               H000Y3_AGRID1_nRecordCount
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_GXsfl_74 ;
      private short nGXsfl_74_idx=1 ;
      private short GRID1_nEOF ;
      private short AV6cSocioId ;
      private short AV8cSocioEdad ;
      private short AV15cCarnetId ;
      private short AV11pSocioId ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short A5SocioId ;
      private short A20SocioEdad ;
      private short A36CarnetId ;
      private short subGrid1_Allowselection ;
      private short subGrid1_Allowhovering ;
      private short subGrid1_Allowcollapsing ;
      private short subGrid1_Collapsed ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short nGXWrapped ;
      private short subGrid1_Backstyle ;
      private int subGrid1_Rows ;
      private int edtavCsocioid_Enabled ;
      private int edtavCsocioid_Visible ;
      private int edtavCsocioedad_Enabled ;
      private int edtavCsocioedad_Visible ;
      private int edtavCcarnetid_Enabled ;
      private int edtavCcarnetid_Visible ;
      private int subGrid1_Titlebackcolor ;
      private int subGrid1_Allbackcolor ;
      private int subGrid1_Selectedindex ;
      private int subGrid1_Selectioncolor ;
      private int subGrid1_Hoveringcolor ;
      private int subGrid1_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int idxLst ;
      private int subGrid1_Backcolor ;
      private long GRID1_nFirstRecordOnPage ;
      private long GRID1_nCurrentRecord ;
      private long GRID1_nRecordCount ;
      private String divAdvancedcontainer_Class ;
      private String bttBtntoggle_Class ;
      private String divSocioidfiltercontainer_Class ;
      private String divSociosexofiltercontainer_Class ;
      private String divSocioedadfiltercontainer_Class ;
      private String divSocioreconocidofiltercontainer_Class ;
      private String divSociotipocuotafiltercontainer_Class ;
      private String divCarnetidfiltercontainer_Class ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_74_idx="0001" ;
      private String AV7cSocioSexo ;
      private String AV14cSocioTipoCuota ;
      private String GXKey ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divMain_Internalname ;
      private String divAdvancedcontainer_Internalname ;
      private String divSocioidfiltercontainer_Internalname ;
      private String lblLblsocioidfilter_Internalname ;
      private String lblLblsocioidfilter_Jsonclick ;
      private String edtavCsocioid_Internalname ;
      private String TempTags ;
      private String edtavCsocioid_Jsonclick ;
      private String divSociosexofiltercontainer_Internalname ;
      private String lblLblsociosexofilter_Internalname ;
      private String lblLblsociosexofilter_Jsonclick ;
      private String cmbavCsociosexo_Internalname ;
      private String cmbavCsociosexo_Jsonclick ;
      private String divSocioedadfiltercontainer_Internalname ;
      private String lblLblsocioedadfilter_Internalname ;
      private String lblLblsocioedadfilter_Jsonclick ;
      private String edtavCsocioedad_Internalname ;
      private String edtavCsocioedad_Jsonclick ;
      private String divSocioreconocidofiltercontainer_Internalname ;
      private String lblLblsocioreconocidofilter_Internalname ;
      private String lblLblsocioreconocidofilter_Jsonclick ;
      private String chkavCsocioreconocido_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String divSociotipocuotafiltercontainer_Internalname ;
      private String lblLblsociotipocuotafilter_Internalname ;
      private String lblLblsociotipocuotafilter_Jsonclick ;
      private String cmbavCsociotipocuota_Internalname ;
      private String cmbavCsociotipocuota_Jsonclick ;
      private String divCarnetidfiltercontainer_Internalname ;
      private String lblLblcarnetidfilter_Internalname ;
      private String lblLblcarnetidfilter_Jsonclick ;
      private String edtavCcarnetid_Internalname ;
      private String edtavCcarnetid_Jsonclick ;
      private String divGridtable_Internalname ;
      private String bttBtntoggle_Internalname ;
      private String bttBtntoggle_Jsonclick ;
      private String sStyleString ;
      private String subGrid1_Internalname ;
      private String subGrid1_Class ;
      private String subGrid1_Linesclass ;
      private String subGrid1_Header ;
      private String edtavLinkselection_Link ;
      private String edtSocioId_Link ;
      private String A19SocioSexo ;
      private String A33SocioTipoCuota ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavLinkselection_Internalname ;
      private String edtSocioId_Internalname ;
      private String cmbSocioSexo_Internalname ;
      private String edtSocioEdad_Internalname ;
      private String chkSocioReconocido_Internalname ;
      private String edtSocioFoto_Internalname ;
      private String cmbSocioTipoCuota_Internalname ;
      private String edtCarnetId_Internalname ;
      private String scmdbuf ;
      private String lV7cSocioSexo ;
      private String lV14cSocioTipoCuota ;
      private String AV12ADVANCED_LABEL_TEMPLATE ;
      private String sGXsfl_74_fel_idx="0001" ;
      private String sImgUrl ;
      private String ROClassString ;
      private String edtSocioId_Jsonclick ;
      private String GXCCtl ;
      private String cmbSocioSexo_Jsonclick ;
      private String edtSocioEdad_Jsonclick ;
      private String cmbSocioTipoCuota_Jsonclick ;
      private String edtCarnetId_Jsonclick ;
      private bool entryPointCalled ;
      private bool AV10cSocioReconocido ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool A24SocioReconocido ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_74_Refreshing=false ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool AV5LinkSelection_IsBlob ;
      private bool A21SocioFoto_IsBlob ;
      private String AV18Linkselection_GXI ;
      private String A40000SocioFoto_GXI ;
      private String AV5LinkSelection ;
      private String A21SocioFoto ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbavCsociosexo ;
      private GXCheckbox chkavCsocioreconocido ;
      private GXCombobox cmbavCsociotipocuota ;
      private GXCombobox cmbSocioSexo ;
      private GXCheckbox chkSocioReconocido ;
      private GXCombobox cmbSocioTipoCuota ;
      private IDataStoreProvider pr_default ;
      private short[] H000Y2_A36CarnetId ;
      private String[] H000Y2_A33SocioTipoCuota ;
      private String[] H000Y2_A40000SocioFoto_GXI ;
      private bool[] H000Y2_A24SocioReconocido ;
      private short[] H000Y2_A20SocioEdad ;
      private String[] H000Y2_A19SocioSexo ;
      private short[] H000Y2_A5SocioId ;
      private String[] H000Y2_A21SocioFoto ;
      private long[] H000Y3_AGRID1_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private short aP0_pSocioId ;
      private GXWebForm Form ;
   }

   public class gx0040__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H000Y2( IGxContext context ,
                                             String AV7cSocioSexo ,
                                             short AV8cSocioEdad ,
                                             bool AV10cSocioReconocido ,
                                             String AV14cSocioTipoCuota ,
                                             short AV15cCarnetId ,
                                             String A19SocioSexo ,
                                             short A20SocioEdad ,
                                             bool A24SocioReconocido ,
                                             String A33SocioTipoCuota ,
                                             short A36CarnetId ,
                                             short AV6cSocioId )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int1 ;
         GXv_int1 = new short [9] ;
         Object[] GXv_Object2 ;
         GXv_Object2 = new Object [2] ;
         String sSelectString ;
         String sFromString ;
         String sOrderString ;
         sSelectString = " [CarnetId], [SocioTipoCuota], [SocioFoto_GXI], [SocioReconocido], [SocioEdad], [SocioSexo], [SocioId], [SocioFoto]";
         sFromString = " FROM [Socio] WITH (NOLOCK)";
         sOrderString = "";
         sWhereString = sWhereString + " WHERE ([SocioId] >= @AV6cSocioId)";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV7cSocioSexo)) )
         {
            sWhereString = sWhereString + " and ([SocioSexo] like @lV7cSocioSexo)";
         }
         else
         {
            GXv_int1[1] = 1;
         }
         if ( ! (0==AV8cSocioEdad) )
         {
            sWhereString = sWhereString + " and ([SocioEdad] >= @AV8cSocioEdad)";
         }
         else
         {
            GXv_int1[2] = 1;
         }
         if ( ! (false==AV10cSocioReconocido) )
         {
            sWhereString = sWhereString + " and ([SocioReconocido] >= @AV10cSocioReconocido)";
         }
         else
         {
            GXv_int1[3] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV14cSocioTipoCuota)) )
         {
            sWhereString = sWhereString + " and ([SocioTipoCuota] like @lV14cSocioTipoCuota)";
         }
         else
         {
            GXv_int1[4] = 1;
         }
         if ( ! (0==AV15cCarnetId) )
         {
            sWhereString = sWhereString + " and ([CarnetId] >= @AV15cCarnetId)";
         }
         else
         {
            GXv_int1[5] = 1;
         }
         sOrderString = sOrderString + " ORDER BY [SocioId]";
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object2[0] = scmdbuf;
         GXv_Object2[1] = GXv_int1;
         return GXv_Object2 ;
      }

      protected Object[] conditional_H000Y3( IGxContext context ,
                                             String AV7cSocioSexo ,
                                             short AV8cSocioEdad ,
                                             bool AV10cSocioReconocido ,
                                             String AV14cSocioTipoCuota ,
                                             short AV15cCarnetId ,
                                             String A19SocioSexo ,
                                             short A20SocioEdad ,
                                             bool A24SocioReconocido ,
                                             String A33SocioTipoCuota ,
                                             short A36CarnetId ,
                                             short AV6cSocioId )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int3 ;
         GXv_int3 = new short [6] ;
         Object[] GXv_Object4 ;
         GXv_Object4 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM [Socio] WITH (NOLOCK)";
         scmdbuf = scmdbuf + " WHERE ([SocioId] >= @AV6cSocioId)";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV7cSocioSexo)) )
         {
            sWhereString = sWhereString + " and ([SocioSexo] like @lV7cSocioSexo)";
         }
         else
         {
            GXv_int3[1] = 1;
         }
         if ( ! (0==AV8cSocioEdad) )
         {
            sWhereString = sWhereString + " and ([SocioEdad] >= @AV8cSocioEdad)";
         }
         else
         {
            GXv_int3[2] = 1;
         }
         if ( ! (false==AV10cSocioReconocido) )
         {
            sWhereString = sWhereString + " and ([SocioReconocido] >= @AV10cSocioReconocido)";
         }
         else
         {
            GXv_int3[3] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV14cSocioTipoCuota)) )
         {
            sWhereString = sWhereString + " and ([SocioTipoCuota] like @lV14cSocioTipoCuota)";
         }
         else
         {
            GXv_int3[4] = 1;
         }
         if ( ! (0==AV15cCarnetId) )
         {
            sWhereString = sWhereString + " and ([CarnetId] >= @AV15cCarnetId)";
         }
         else
         {
            GXv_int3[5] = 1;
         }
         scmdbuf = scmdbuf + sWhereString;
         scmdbuf = scmdbuf + "";
         GXv_Object4[0] = scmdbuf;
         GXv_Object4[1] = GXv_int3;
         return GXv_Object4 ;
      }

      public override Object [] getDynamicStatement( int cursor ,
                                                     IGxContext context ,
                                                     Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 0 :
                     return conditional_H000Y2(context, (String)dynConstraints[0] , (short)dynConstraints[1] , (bool)dynConstraints[2] , (String)dynConstraints[3] , (short)dynConstraints[4] , (String)dynConstraints[5] , (short)dynConstraints[6] , (bool)dynConstraints[7] , (String)dynConstraints[8] , (short)dynConstraints[9] , (short)dynConstraints[10] );
               case 1 :
                     return conditional_H000Y3(context, (String)dynConstraints[0] , (short)dynConstraints[1] , (bool)dynConstraints[2] , (String)dynConstraints[3] , (short)dynConstraints[4] , (String)dynConstraints[5] , (short)dynConstraints[6] , (bool)dynConstraints[7] , (String)dynConstraints[8] , (short)dynConstraints[9] , (short)dynConstraints[10] );
         }
         return base.getDynamicStatement(cursor, context, dynConstraints);
      }

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
          Object[] prmH000Y2 ;
          prmH000Y2 = new Object[] {
          new Object[] {"@AV6cSocioId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@lV7cSocioSexo",SqlDbType.Char,20,0} ,
          new Object[] {"@AV8cSocioEdad",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV10cSocioReconocido",SqlDbType.Bit,4,0} ,
          new Object[] {"@lV14cSocioTipoCuota",SqlDbType.Char,20,0} ,
          new Object[] {"@AV15cCarnetId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH000Y3 ;
          prmH000Y3 = new Object[] {
          new Object[] {"@AV6cSocioId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@lV7cSocioSexo",SqlDbType.Char,20,0} ,
          new Object[] {"@AV8cSocioEdad",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV10cSocioReconocido",SqlDbType.Bit,4,0} ,
          new Object[] {"@lV14cSocioTipoCuota",SqlDbType.Char,20,0} ,
          new Object[] {"@AV15cCarnetId",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H000Y2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000Y2,11,0,false,false )
             ,new CursorDef("H000Y3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000Y3,1,0,false,false )
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
                ((String[]) buf[2])[0] = rslt.getMultimediaUri(3) ;
                ((bool[]) buf[3])[0] = rslt.getBool(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((String[]) buf[5])[0] = rslt.getString(6, 20) ;
                ((short[]) buf[6])[0] = rslt.getShort(7) ;
                ((String[]) buf[7])[0] = rslt.getMultimediaFile(8, rslt.getVarchar(3)) ;
                return;
             case 1 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                return;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       short sIdx ;
       switch ( cursor )
       {
             case 0 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[9]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[10]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[11]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (bool)parms[12]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[13]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[14]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[15]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[16]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[17]);
                }
                return;
             case 1 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[6]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[7]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[8]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (bool)parms[9]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[10]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[11]);
                }
                return;
       }
    }

 }

}
