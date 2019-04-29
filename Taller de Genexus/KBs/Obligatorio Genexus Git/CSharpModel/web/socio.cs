/*
               File: Socio
        Description: Socio
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 4/12/2019 21:1:43.29
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
using System.Runtime.Remoting;
using GeneXus.WebControls;
using GeneXus.Http;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class socio : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      protected void INITENV( )
      {
         if ( GxWebError != 0 )
         {
            return  ;
         }
      }

      protected void INITTRN( )
      {
         initialize_properties( ) ;
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxJX_Action13") == 0 )
         {
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            XC_13_054( ) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel6"+"_"+"SOCIOID") == 0 )
         {
            AV12SocioId = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12SocioId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12SocioId), 4, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vSOCIOID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV12SocioId), "ZZZ9"), context));
            Gx_BScreen = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX6ASASOCIOID054( AV12SocioId, Gx_BScreen) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_15") == 0 )
         {
            A36CarnetId = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36CarnetId", StringUtil.LTrim( StringUtil.Str( (decimal)(A36CarnetId), 4, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_15( A36CarnetId) ;
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
            Gx_mode = gxfirstwebparm;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
            {
               AV12SocioId = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12SocioId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12SocioId), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vSOCIOID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV12SocioId), "ZZZ9"), context));
            }
         }
         if ( context.isSpaRequest( ) )
         {
            enableJsOutput();
         }
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
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 15_0_12-126726", 0) ;
            Form.Meta.addItem("description", "Socio", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtSocioId_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("Carmine");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public socio( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public socio( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( String aP0_Gx_mode ,
                           short aP1_SocioId )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV12SocioId = aP1_SocioId;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         cmbSocioSexo = new GXCombobox();
         cmbSocioTipoCuota = new GXCombobox();
         chkSocioReconocido = new GXCheckbox();
      }

      public override void webExecute( )
      {
         if ( initialized == 0 )
         {
            createObjects();
            initialize();
         }
         INITENV( ) ;
         INITTRN( ) ;
         if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
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

      protected void fix_multi_value_controls( )
      {
         if ( cmbSocioSexo.ItemCount > 0 )
         {
            A19SocioSexo = cmbSocioSexo.getValidValue(A19SocioSexo);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19SocioSexo", A19SocioSexo);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbSocioSexo.CurrentValue = StringUtil.RTrim( A19SocioSexo);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbSocioSexo_Internalname, "Values", cmbSocioSexo.ToJavascriptSource(), true);
         }
         if ( cmbSocioTipoCuota.ItemCount > 0 )
         {
            A33SocioTipoCuota = cmbSocioTipoCuota.getValidValue(A33SocioTipoCuota);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33SocioTipoCuota", A33SocioTipoCuota);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbSocioTipoCuota.CurrentValue = StringUtil.RTrim( A33SocioTipoCuota);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbSocioTipoCuota_Internalname, "Values", cmbSocioTipoCuota.ToJavascriptSource(), true);
         }
      }

      protected void Draw( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! GxWebStd.gx_redirect( context) )
         {
            disable_std_buttons( ) ;
            enableDisable( ) ;
            set_caption( ) ;
            /* Form start */
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divMaintable_Internalname, 1, 0, "px", 0, "px", "WWAdvancedContainer", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8 col-sm-offset-2", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTitlecontainer_Internalname, 1, 0, "px", 0, "px", "TableTop", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "Socio", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_Socio.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            ClassString = "ErrorViewer";
            StyleString = "";
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, "", "false");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8 col-sm-offset-2", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divFormcontainer_Internalname, 1, 0, "px", 0, "px", "FormContainer", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divToolbarcell_Internalname, 1, 0, "px", 0, "px", "col-xs-12 col-sm-9 col-sm-offset-3 ToolbarCellClass", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group ActionGroup", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "btn-group", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'',0)\"";
            ClassString = "BtnFirst";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "", bttBtn_first_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_first_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Socio.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "", bttBtn_previous_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_previous_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_Socio.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", "", bttBtn_next_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_next_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_Socio.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", "", bttBtn_last_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_last_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Socio.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Select", bttBtn_select_Jsonclick, 5, "Select", "", StyleString, ClassString, bttBtn_select_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "", 2, "HLP_Socio.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCellAdvanced", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtSocioId_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtSocioId_Internalname, "Id", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtSocioId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A5SocioId), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A5SocioId), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,34);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtSocioId_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtSocioId_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Socio.htm");
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
            GxWebStd.gx_label_element( context, edtSocioDireccion_Internalname, "Direccion", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtSocioDireccion_Internalname, A18SocioDireccion, "http://maps.google.com/maps?q="+GXUtil.UrlEncode( A18SocioDireccion), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,39);\"", 0, 1, edtSocioDireccion_Enabled, 0, 80, "chr", 10, "row", StyleString, ClassString, "", "", "1024", -1, 0, "_blank", "", 0, true, "GeneXus\\Address", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_Socio.htm");
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
            GxWebStd.gx_label_element( context, cmbSocioSexo_Internalname, "Sexo", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbSocioSexo, cmbSocioSexo_Internalname, StringUtil.RTrim( A19SocioSexo), 1, cmbSocioSexo_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "char", "", 1, cmbSocioSexo.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,44);\"", "", true, "HLP_Socio.htm");
            cmbSocioSexo.CurrentValue = StringUtil.RTrim( A19SocioSexo);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbSocioSexo_Internalname, "Values", (String)(cmbSocioSexo.ToJavascriptSource()), true);
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
            GxWebStd.gx_label_element( context, edtSocioEdad_Internalname, "Edad", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 49,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtSocioEdad_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A20SocioEdad), 4, 0, ".", "")), ((edtSocioEdad_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A20SocioEdad), "ZZZ9")) : context.localUtil.Format( (decimal)(A20SocioEdad), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,49);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtSocioEdad_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtSocioEdad_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Socio.htm");
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
            GxWebStd.gx_label_element( context, cmbSocioTipoCuota_Internalname, "Tipo Cuota", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 54,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbSocioTipoCuota, cmbSocioTipoCuota_Internalname, StringUtil.RTrim( A33SocioTipoCuota), 1, cmbSocioTipoCuota_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "char", "", 1, cmbSocioTipoCuota.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,54);\"", "", true, "HLP_Socio.htm");
            cmbSocioTipoCuota.CurrentValue = StringUtil.RTrim( A33SocioTipoCuota);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbSocioTipoCuota_Internalname, "Values", (String)(cmbSocioTipoCuota.ToJavascriptSource()), true);
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
            GxWebStd.gx_label_element( context, chkSocioReconocido_Internalname, "Reconocido", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 59,'',false,'',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkSocioReconocido_Internalname, StringUtil.BoolToStr( A24SocioReconocido), "", "Reconocido", 1, chkSocioReconocido.Enabled, "true", "", StyleString, ClassString, "", "", TempTags+" onclick=\"gx.fn.checkboxClick(59, this, 'true', 'false');gx.evt.onchange(this, event);\" ");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+imgSocioFoto_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, imgSocioFoto_Internalname, "Foto", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Static Bitmap Variable */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 64,'',false,'',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            A21SocioFoto_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( A21SocioFoto))&&String.IsNullOrEmpty(StringUtil.RTrim( A40000SocioFoto_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( A21SocioFoto)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( A21SocioFoto)) ? A40000SocioFoto_GXI : context.PathToRelativeUrl( A21SocioFoto));
            GxWebStd.gx_bitmap( context, imgSocioFoto_Internalname, sImgUrl, "", "", "", context.GetTheme( ), 1, imgSocioFoto_Enabled, "", "", 1, -1, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,64);\"", "", "", "", 0, A21SocioFoto_IsBlob, true, context.GetImageSrcSet( sImgUrl), "HLP_Socio.htm");
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgSocioFoto_Internalname, "URL", (String.IsNullOrEmpty(StringUtil.RTrim( A21SocioFoto)) ? A40000SocioFoto_GXI : context.PathToRelativeUrl( A21SocioFoto)), true);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgSocioFoto_Internalname, "IsBlob", StringUtil.BoolToStr( A21SocioFoto_IsBlob), true);
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
            GxWebStd.gx_label_element( context, edtSocioMonto_Internalname, "Monto", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtSocioMonto_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A32SocioMonto), 4, 0, ".", "")), ((edtSocioMonto_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A32SocioMonto), "ZZZ9")) : context.localUtil.Format( (decimal)(A32SocioMonto), "ZZZ9")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtSocioMonto_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtSocioMonto_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Socio.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtCarnetId_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtCarnetId_Internalname, "Carnet Id", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 74,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtCarnetId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A36CarnetId), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A36CarnetId), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,74);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtCarnetId_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtCarnetId_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Socio.htm");
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgprompt_36_Internalname, sImgUrl, imgprompt_36_Link, "", "", context.GetTheme( ), imgprompt_36_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_Socio.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtCarnetFechaIngreso_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtCarnetFechaIngreso_Internalname, "Carnet Fecha Ingreso", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            context.WriteHtmlText( "<div id=\""+edtCarnetFechaIngreso_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtCarnetFechaIngreso_Internalname, context.localUtil.Format(A37CarnetFechaIngreso, "99/99/99"), context.localUtil.Format( A37CarnetFechaIngreso, "99/99/99"), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtCarnetFechaIngreso_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtCarnetFechaIngreso_Enabled, 0, "text", "", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Socio.htm");
            GxWebStd.gx_bitmap( context, edtCarnetFechaIngreso_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtCarnetFechaIngreso_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_Socio.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "Center", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group Confirm", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 84,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirm", bttBtn_enter_Jsonclick, 5, "Confirm", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_Socio.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 86,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancel", bttBtn_cancel_Jsonclick, 1, "Cancel", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Socio.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 88,'',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Delete", bttBtn_delete_Jsonclick, 5, "Delete", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_Socio.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            fix_multi_value_controls( ) ;
         }
         /* Execute Exit event if defined. */
      }

      protected void UserMain( )
      {
         standaloneStartup( ) ;
      }

      protected void UserMainFullajax( )
      {
         INITENV( ) ;
         INITTRN( ) ;
         UserMain( ) ;
         Draw( ) ;
         SendCloseFormHiddens( ) ;
      }

      protected void standaloneStartup( )
      {
         standaloneStartupServer( ) ;
         disable_std_buttons( ) ;
         enableDisable( ) ;
         Process( ) ;
      }

      protected void standaloneStartupServer( )
      {
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E11052 ();
         context.wbGlbDoneStart = 1;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read variables values. */
               if ( ( ( context.localUtil.CToN( cgiGet( edtSocioId_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtSocioId_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "SOCIOID");
                  AnyError = 1;
                  GX_FocusControl = edtSocioId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A5SocioId = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5SocioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A5SocioId), 4, 0)));
               }
               else
               {
                  A5SocioId = (short)(context.localUtil.CToN( cgiGet( edtSocioId_Internalname), ".", ","));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5SocioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A5SocioId), 4, 0)));
               }
               A18SocioDireccion = cgiGet( edtSocioDireccion_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18SocioDireccion", A18SocioDireccion);
               cmbSocioSexo.CurrentValue = cgiGet( cmbSocioSexo_Internalname);
               A19SocioSexo = cgiGet( cmbSocioSexo_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19SocioSexo", A19SocioSexo);
               if ( ( ( context.localUtil.CToN( cgiGet( edtSocioEdad_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtSocioEdad_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "SOCIOEDAD");
                  AnyError = 1;
                  GX_FocusControl = edtSocioEdad_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A20SocioEdad = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20SocioEdad", StringUtil.LTrim( StringUtil.Str( (decimal)(A20SocioEdad), 4, 0)));
               }
               else
               {
                  A20SocioEdad = (short)(context.localUtil.CToN( cgiGet( edtSocioEdad_Internalname), ".", ","));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20SocioEdad", StringUtil.LTrim( StringUtil.Str( (decimal)(A20SocioEdad), 4, 0)));
               }
               cmbSocioTipoCuota.CurrentValue = cgiGet( cmbSocioTipoCuota_Internalname);
               A33SocioTipoCuota = cgiGet( cmbSocioTipoCuota_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33SocioTipoCuota", A33SocioTipoCuota);
               A24SocioReconocido = StringUtil.StrToBool( cgiGet( chkSocioReconocido_Internalname));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A24SocioReconocido", A24SocioReconocido);
               A21SocioFoto = cgiGet( imgSocioFoto_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A21SocioFoto", A21SocioFoto);
               A32SocioMonto = (short)(context.localUtil.CToN( cgiGet( edtSocioMonto_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32SocioMonto", StringUtil.LTrim( StringUtil.Str( (decimal)(A32SocioMonto), 4, 0)));
               if ( ( ( context.localUtil.CToN( cgiGet( edtCarnetId_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtCarnetId_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "CARNETID");
                  AnyError = 1;
                  GX_FocusControl = edtCarnetId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A36CarnetId = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36CarnetId", StringUtil.LTrim( StringUtil.Str( (decimal)(A36CarnetId), 4, 0)));
               }
               else
               {
                  A36CarnetId = (short)(context.localUtil.CToN( cgiGet( edtCarnetId_Internalname), ".", ","));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36CarnetId", StringUtil.LTrim( StringUtil.Str( (decimal)(A36CarnetId), 4, 0)));
               }
               A37CarnetFechaIngreso = context.localUtil.CToD( cgiGet( edtCarnetFechaIngreso_Internalname), 1);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37CarnetFechaIngreso", context.localUtil.Format(A37CarnetFechaIngreso, "99/99/99"));
               /* Read saved values. */
               Z5SocioId = (short)(context.localUtil.CToN( cgiGet( "Z5SocioId"), ".", ","));
               Z18SocioDireccion = cgiGet( "Z18SocioDireccion");
               Z19SocioSexo = cgiGet( "Z19SocioSexo");
               Z20SocioEdad = (short)(context.localUtil.CToN( cgiGet( "Z20SocioEdad"), ".", ","));
               Z33SocioTipoCuota = cgiGet( "Z33SocioTipoCuota");
               Z24SocioReconocido = StringUtil.StrToBool( cgiGet( "Z24SocioReconocido"));
               Z36CarnetId = (short)(context.localUtil.CToN( cgiGet( "Z36CarnetId"), ".", ","));
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ","));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ".", ","));
               Gx_mode = cgiGet( "Mode");
               N36CarnetId = (short)(context.localUtil.CToN( cgiGet( "N36CarnetId"), ".", ","));
               AV12SocioId = (short)(context.localUtil.CToN( cgiGet( "vSOCIOID"), ".", ","));
               Gx_BScreen = (short)(context.localUtil.CToN( cgiGet( "vGXBSCREEN"), ".", ","));
               AV13Insert_CarnetId = (short)(context.localUtil.CToN( cgiGet( "vINSERT_CARNETID"), ".", ","));
               A40000SocioFoto_GXI = cgiGet( "SOCIOFOTO_GXI");
               AV16Pgmname = cgiGet( "vPGMNAME");
               Gx_mode = cgiGet( "vMODE");
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               getMultimediaValue(imgSocioFoto_Internalname, ref  A21SocioFoto, ref  A40000SocioFoto_GXI);
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               forbiddenHiddens = "hsh" + "Socio";
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV13Insert_CarnetId), "ZZZ9");
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( A5SocioId != Z5SocioId ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
               {
                  GXUtil.WriteLog("socio:[SecurityCheckFailed value for]"+"Insert_CarnetId:"+context.localUtil.Format( (decimal)(AV13Insert_CarnetId), "ZZZ9"));
                  GXUtil.WriteLog("socio:[SecurityCheckFailed value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
                  GxWebError = 1;
                  context.HttpContext.Response.StatusDescription = 403.ToString();
                  context.HttpContext.Response.StatusCode = 403;
                  context.WriteHtmlText( "<title>403 Forbidden</title>") ;
                  context.WriteHtmlText( "<h1>403 Forbidden</h1>") ;
                  context.WriteHtmlText( "<p /><hr />") ;
                  GXUtil.WriteLog("send_http_error_code " + 403.ToString());
                  AnyError = 1;
                  return  ;
               }
               standaloneNotModal( ) ;
            }
            else
            {
               standaloneNotModal( ) ;
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") == 0 )
               {
                  Gx_mode = "DSP";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  A5SocioId = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5SocioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A5SocioId), 4, 0)));
                  getEqualNoModal( ) ;
                  if ( ! (0==AV12SocioId) )
                  {
                     A5SocioId = AV12SocioId;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5SocioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A5SocioId), 4, 0)));
                  }
                  else
                  {
                     if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && (0==A5SocioId) && ( Gx_BScreen == 0 ) )
                     {
                        GXt_int1 = A5SocioId;
                        new ultimoidsocio(context ).execute( out  GXt_int1) ;
                        A5SocioId = GXt_int1;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5SocioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A5SocioId), 4, 0)));
                     }
                  }
                  Gx_mode = "DSP";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  disable_std_buttons( ) ;
                  standaloneModal( ) ;
               }
               else
               {
                  if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
                  {
                     sMode4 = Gx_mode;
                     Gx_mode = "UPD";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     if ( ! (0==AV12SocioId) )
                     {
                        A5SocioId = AV12SocioId;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5SocioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A5SocioId), 4, 0)));
                     }
                     else
                     {
                        if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && (0==A5SocioId) && ( Gx_BScreen == 0 ) )
                        {
                           GXt_int1 = A5SocioId;
                           new ultimoidsocio(context ).execute( out  GXt_int1) ;
                           A5SocioId = GXt_int1;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5SocioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A5SocioId), 4, 0)));
                        }
                     }
                     Gx_mode = sMode4;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound4 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_050( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtn_enter_Internalname;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert", ""), 1, "SOCIOID");
                        AnyError = 1;
                        GX_FocusControl = edtSocioId_Internalname;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
         }
      }

      protected void Process( )
      {
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read Transaction buttons. */
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
                        if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: Start */
                           E11052 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: After Trn */
                           E12052 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DELETE") == 0 )
                        {
                           context.wbHandled = 1;
                           if ( StringUtil.StrCmp(Gx_mode, "DSP") != 0 )
                           {
                              btn_delete( ) ;
                           }
                        }
                        else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                        {
                           context.wbHandled = 1;
                           if ( StringUtil.StrCmp(Gx_mode, "DSP") != 0 )
                           {
                              btn_enter( ) ;
                           }
                           /* No code required for Cancel button. It is implemented as the Reset button. */
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

      protected void AfterTrn( )
      {
         if ( trnEnded == 1 )
         {
            /* Execute user event: After Trn */
            E12052 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll054( ) ;
               standaloneNotModal( ) ;
               standaloneModal( ) ;
            }
         }
      }

      public override String ToString( )
      {
         return "" ;
      }

      public GxContentInfo GetContentInfo( )
      {
         return (GxContentInfo)(null) ;
      }

      protected void disable_std_buttons( )
      {
         bttBtn_delete_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Visible), 5, 0)), true);
         bttBtn_first_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_first_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_first_Visible), 5, 0)), true);
         bttBtn_previous_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_previous_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_previous_Visible), 5, 0)), true);
         bttBtn_next_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_next_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_next_Visible), 5, 0)), true);
         bttBtn_last_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_last_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_last_Visible), 5, 0)), true);
         bttBtn_select_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_select_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_select_Visible), 5, 0)), true);
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            bttBtn_delete_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Visible), 5, 0)), true);
            if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
            {
               bttBtn_enter_Visible = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_enter_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_enter_Visible), 5, 0)), true);
            }
            DisableAttributes054( ) ;
         }
      }

      protected void set_caption( )
      {
         if ( ( IsConfirmed == 1 ) && ( AnyError == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_confdelete", ""), 0, "", true);
            }
            else
            {
               GX_msglist.addItem(context.GetMessage( "GXM_mustconfirm", ""), 0, "", true);
            }
         }
      }

      protected void CONFIRM_050( )
      {
         BeforeValidate054( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls054( ) ;
            }
            else
            {
               CheckExtendedTable054( ) ;
               CloseExtendedTableCursors054( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         }
      }

      protected void ResetCaption050( )
      {
      }

      protected void E11052( )
      {
         /* Start Routine */
         if ( ! new isauthorized(context).executeUdp(  AV16Pgmname) )
         {
            CallWebObject(formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV16Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         AV9TrnContext.FromXml(AV10WebSession.Get("TrnContext"), null, "TransactionContext", "ObligatorioGenexusGit");
         AV13Insert_CarnetId = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13Insert_CarnetId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13Insert_CarnetId), 4, 0)));
         if ( ( StringUtil.StrCmp(AV9TrnContext.gxTpr_Transactionname, AV16Pgmname) == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) )
         {
            AV17GXV1 = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17GXV1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17GXV1), 8, 0)));
            while ( AV17GXV1 <= AV9TrnContext.gxTpr_Attributes.Count )
            {
               AV14TrnContextAtt = ((SdtTransactionContext_Attribute)AV9TrnContext.gxTpr_Attributes.Item(AV17GXV1));
               if ( StringUtil.StrCmp(AV14TrnContextAtt.gxTpr_Attributename, "CarnetId") == 0 )
               {
                  AV13Insert_CarnetId = (short)(NumberUtil.Val( AV14TrnContextAtt.gxTpr_Attributevalue, "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13Insert_CarnetId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13Insert_CarnetId), 4, 0)));
               }
               AV17GXV1 = (int)(AV17GXV1+1);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17GXV1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17GXV1), 8, 0)));
            }
         }
      }

      protected void E12052( )
      {
         /* After Trn Routine */
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV9TrnContext.gxTpr_Callerondelete )
         {
            CallWebObject(formatLink("wwsocio.aspx") );
            context.wjLocDisableFrm = 1;
         }
         context.setWebReturnParms(new Object[] {});
         context.setWebReturnParmsMetadata(new Object[] {});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      protected void E13052( )
      {
         /* Delete Routine */
         new borrarcarnets(context ).execute( ) ;
      }

      protected void ZM054( short GX_JID )
      {
         if ( ( GX_JID == 14 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z18SocioDireccion = T00053_A18SocioDireccion[0];
               Z19SocioSexo = T00053_A19SocioSexo[0];
               Z20SocioEdad = T00053_A20SocioEdad[0];
               Z33SocioTipoCuota = T00053_A33SocioTipoCuota[0];
               Z24SocioReconocido = T00053_A24SocioReconocido[0];
               Z36CarnetId = T00053_A36CarnetId[0];
            }
            else
            {
               Z18SocioDireccion = A18SocioDireccion;
               Z19SocioSexo = A19SocioSexo;
               Z20SocioEdad = A20SocioEdad;
               Z33SocioTipoCuota = A33SocioTipoCuota;
               Z24SocioReconocido = A24SocioReconocido;
               Z36CarnetId = A36CarnetId;
            }
         }
         if ( GX_JID == -14 )
         {
            Z5SocioId = A5SocioId;
            Z18SocioDireccion = A18SocioDireccion;
            Z19SocioSexo = A19SocioSexo;
            Z20SocioEdad = A20SocioEdad;
            Z33SocioTipoCuota = A33SocioTipoCuota;
            Z24SocioReconocido = A24SocioReconocido;
            Z21SocioFoto = A21SocioFoto;
            Z40000SocioFoto_GXI = A40000SocioFoto_GXI;
            Z36CarnetId = A36CarnetId;
            Z37CarnetFechaIngreso = A37CarnetFechaIngreso;
         }
      }

      protected void standaloneNotModal( )
      {
         Gx_BScreen = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
         imgprompt_36_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx00e0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CARNETID"+"'), id:'"+"CARNETID"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"false"+");");
         bttBtn_delete_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Enabled), 5, 0)), true);
         if ( ! (0==AV12SocioId) )
         {
            edtSocioId_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSocioId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSocioId_Enabled), 5, 0)), true);
         }
         else
         {
            edtSocioId_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSocioId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSocioId_Enabled), 5, 0)), true);
         }
         if ( ! (0==AV12SocioId) )
         {
            edtSocioId_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSocioId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSocioId_Enabled), 5, 0)), true);
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV13Insert_CarnetId) )
         {
            edtCarnetId_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCarnetId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCarnetId_Enabled), 5, 0)), true);
         }
         else
         {
            edtCarnetId_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCarnetId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCarnetId_Enabled), 5, 0)), true);
         }
      }

      protected void standaloneModal( )
      {
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV13Insert_CarnetId) )
         {
            A36CarnetId = AV13Insert_CarnetId;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36CarnetId", StringUtil.LTrim( StringUtil.Str( (decimal)(A36CarnetId), 4, 0)));
         }
         if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
         {
            bttBtn_enter_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_enter_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_enter_Enabled), 5, 0)), true);
         }
         else
         {
            bttBtn_enter_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_enter_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_enter_Enabled), 5, 0)), true);
         }
         if ( ! (0==AV12SocioId) )
         {
            A5SocioId = AV12SocioId;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5SocioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A5SocioId), 4, 0)));
         }
         else
         {
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && (0==A5SocioId) && ( Gx_BScreen == 0 ) )
            {
               GXt_int1 = A5SocioId;
               new ultimoidsocio(context ).execute( out  GXt_int1) ;
               A5SocioId = GXt_int1;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5SocioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A5SocioId), 4, 0)));
            }
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && (0==A32SocioMonto) && ( Gx_BScreen == 0 ) )
         {
            A32SocioMonto = 2500;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32SocioMonto", StringUtil.LTrim( StringUtil.Str( (decimal)(A32SocioMonto), 4, 0)));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ( Gx_BScreen == 0 ) )
         {
            AV16Pgmname = "Socio";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16Pgmname", AV16Pgmname);
            /* Using cursor T00054 */
            pr_default.execute(2, new Object[] {A36CarnetId});
            A37CarnetFechaIngreso = T00054_A37CarnetFechaIngreso[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37CarnetFechaIngreso", context.localUtil.Format(A37CarnetFechaIngreso, "99/99/99"));
            pr_default.close(2);
         }
      }

      protected void Load054( )
      {
         /* Using cursor T00055 */
         pr_default.execute(3, new Object[] {A5SocioId});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound4 = 1;
            A18SocioDireccion = T00055_A18SocioDireccion[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18SocioDireccion", A18SocioDireccion);
            A19SocioSexo = T00055_A19SocioSexo[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19SocioSexo", A19SocioSexo);
            A20SocioEdad = T00055_A20SocioEdad[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20SocioEdad", StringUtil.LTrim( StringUtil.Str( (decimal)(A20SocioEdad), 4, 0)));
            A33SocioTipoCuota = T00055_A33SocioTipoCuota[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33SocioTipoCuota", A33SocioTipoCuota);
            A24SocioReconocido = T00055_A24SocioReconocido[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A24SocioReconocido", A24SocioReconocido);
            A40000SocioFoto_GXI = T00055_A40000SocioFoto_GXI[0];
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgSocioFoto_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A21SocioFoto)) ? A40000SocioFoto_GXI : context.convertURL( context.PathToRelativeUrl( A21SocioFoto))), true);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgSocioFoto_Internalname, "SrcSet", context.GetImageSrcSet( A21SocioFoto), true);
            A37CarnetFechaIngreso = T00055_A37CarnetFechaIngreso[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37CarnetFechaIngreso", context.localUtil.Format(A37CarnetFechaIngreso, "99/99/99"));
            A36CarnetId = T00055_A36CarnetId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36CarnetId", StringUtil.LTrim( StringUtil.Str( (decimal)(A36CarnetId), 4, 0)));
            A21SocioFoto = T00055_A21SocioFoto[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A21SocioFoto", A21SocioFoto);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgSocioFoto_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A21SocioFoto)) ? A40000SocioFoto_GXI : context.convertURL( context.PathToRelativeUrl( A21SocioFoto))), true);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgSocioFoto_Internalname, "SrcSet", context.GetImageSrcSet( A21SocioFoto), true);
            ZM054( -14) ;
         }
         pr_default.close(3);
         OnLoadActions054( ) ;
      }

      protected void OnLoadActions054( )
      {
         AV16Pgmname = "Socio";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16Pgmname", AV16Pgmname);
         if ( ( StringUtil.StrCmp(A33SocioTipoCuota, "P") == 0 ) && ( A20SocioEdad > 65 ) )
         {
            A32SocioMonto = (short)(1500-(1500*0.3m));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32SocioMonto", StringUtil.LTrim( StringUtil.Str( (decimal)(A32SocioMonto), 4, 0)));
         }
         else
         {
            if ( ( StringUtil.StrCmp(A33SocioTipoCuota, "V") == 0 ) && ( A20SocioEdad > 65 ) )
            {
               A32SocioMonto = (short)(2500-(2500*0.3m));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32SocioMonto", StringUtil.LTrim( StringUtil.Str( (decimal)(A32SocioMonto), 4, 0)));
            }
            else
            {
               if ( StringUtil.StrCmp(A33SocioTipoCuota, "P") == 0 )
               {
                  A32SocioMonto = 1500;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32SocioMonto", StringUtil.LTrim( StringUtil.Str( (decimal)(A32SocioMonto), 4, 0)));
               }
               else
               {
                  if ( true )
                  {
                     A32SocioMonto = 2500;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32SocioMonto", StringUtil.LTrim( StringUtil.Str( (decimal)(A32SocioMonto), 4, 0)));
                  }
                  else
                  {
                     A32SocioMonto = 0;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32SocioMonto", StringUtil.LTrim( StringUtil.Str( (decimal)(A32SocioMonto), 4, 0)));
                  }
               }
            }
         }
      }

      protected void CheckExtendedTable054( )
      {
         Gx_BScreen = 1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
         standaloneModal( ) ;
         AV16Pgmname = "Socio";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16Pgmname", AV16Pgmname);
         if ( ! ( ( StringUtil.StrCmp(A19SocioSexo, "Hombre") == 0 ) || ( StringUtil.StrCmp(A19SocioSexo, "Mujer") == 0 ) || ( StringUtil.StrCmp(A19SocioSexo, "Otro") == 0 ) ) )
         {
            GX_msglist.addItem("Field Socio Sexo is out of range", "OutOfRange", 1, "SOCIOSEXO");
            AnyError = 1;
            GX_FocusControl = cmbSocioSexo_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ( StringUtil.StrCmp(A33SocioTipoCuota, "P") == 0 ) && ( A20SocioEdad > 65 ) )
         {
            A32SocioMonto = (short)(1500-(1500*0.3m));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32SocioMonto", StringUtil.LTrim( StringUtil.Str( (decimal)(A32SocioMonto), 4, 0)));
         }
         else
         {
            if ( ( StringUtil.StrCmp(A33SocioTipoCuota, "V") == 0 ) && ( A20SocioEdad > 65 ) )
            {
               A32SocioMonto = (short)(2500-(2500*0.3m));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32SocioMonto", StringUtil.LTrim( StringUtil.Str( (decimal)(A32SocioMonto), 4, 0)));
            }
            else
            {
               if ( StringUtil.StrCmp(A33SocioTipoCuota, "P") == 0 )
               {
                  A32SocioMonto = 1500;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32SocioMonto", StringUtil.LTrim( StringUtil.Str( (decimal)(A32SocioMonto), 4, 0)));
               }
               else
               {
                  if ( true )
                  {
                     A32SocioMonto = 2500;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32SocioMonto", StringUtil.LTrim( StringUtil.Str( (decimal)(A32SocioMonto), 4, 0)));
                  }
                  else
                  {
                     A32SocioMonto = 0;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32SocioMonto", StringUtil.LTrim( StringUtil.Str( (decimal)(A32SocioMonto), 4, 0)));
                  }
               }
            }
         }
         if ( ! ( ( StringUtil.StrCmp(A33SocioTipoCuota, "V") == 0 ) || ( StringUtil.StrCmp(A33SocioTipoCuota, "P") == 0 ) ) )
         {
            GX_msglist.addItem("Field Socio Tipo Cuota is out of range", "OutOfRange", 1, "SOCIOTIPOCUOTA");
            AnyError = 1;
            GX_FocusControl = cmbSocioTipoCuota_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         /* Using cursor T00054 */
         pr_default.execute(2, new Object[] {A36CarnetId});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("No matching 'Carnet'.", "ForeignKeyNotFound", 1, "CARNETID");
            AnyError = 1;
            GX_FocusControl = edtCarnetId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A37CarnetFechaIngreso = T00054_A37CarnetFechaIngreso[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37CarnetFechaIngreso", context.localUtil.Format(A37CarnetFechaIngreso, "99/99/99"));
         pr_default.close(2);
      }

      protected void CloseExtendedTableCursors054( )
      {
         pr_default.close(2);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_15( short A36CarnetId )
      {
         /* Using cursor T00056 */
         pr_default.execute(4, new Object[] {A36CarnetId});
         if ( (pr_default.getStatus(4) == 101) )
         {
            GX_msglist.addItem("No matching 'Carnet'.", "ForeignKeyNotFound", 1, "CARNETID");
            AnyError = 1;
            GX_FocusControl = edtCarnetId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A37CarnetFechaIngreso = T00056_A37CarnetFechaIngreso[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37CarnetFechaIngreso", context.localUtil.Format(A37CarnetFechaIngreso, "99/99/99"));
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( context.localUtil.Format(A37CarnetFechaIngreso, "99/99/99"))+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(4) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(4);
      }

      protected void GetKey054( )
      {
         /* Using cursor T00057 */
         pr_default.execute(5, new Object[] {A5SocioId});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound4 = 1;
         }
         else
         {
            RcdFound4 = 0;
         }
         pr_default.close(5);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00053 */
         pr_default.execute(1, new Object[] {A5SocioId});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM054( 14) ;
            RcdFound4 = 1;
            A5SocioId = T00053_A5SocioId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5SocioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A5SocioId), 4, 0)));
            A18SocioDireccion = T00053_A18SocioDireccion[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18SocioDireccion", A18SocioDireccion);
            A19SocioSexo = T00053_A19SocioSexo[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19SocioSexo", A19SocioSexo);
            A20SocioEdad = T00053_A20SocioEdad[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20SocioEdad", StringUtil.LTrim( StringUtil.Str( (decimal)(A20SocioEdad), 4, 0)));
            A33SocioTipoCuota = T00053_A33SocioTipoCuota[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33SocioTipoCuota", A33SocioTipoCuota);
            A24SocioReconocido = T00053_A24SocioReconocido[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A24SocioReconocido", A24SocioReconocido);
            A40000SocioFoto_GXI = T00053_A40000SocioFoto_GXI[0];
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgSocioFoto_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A21SocioFoto)) ? A40000SocioFoto_GXI : context.convertURL( context.PathToRelativeUrl( A21SocioFoto))), true);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgSocioFoto_Internalname, "SrcSet", context.GetImageSrcSet( A21SocioFoto), true);
            A36CarnetId = T00053_A36CarnetId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36CarnetId", StringUtil.LTrim( StringUtil.Str( (decimal)(A36CarnetId), 4, 0)));
            A21SocioFoto = T00053_A21SocioFoto[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A21SocioFoto", A21SocioFoto);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgSocioFoto_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A21SocioFoto)) ? A40000SocioFoto_GXI : context.convertURL( context.PathToRelativeUrl( A21SocioFoto))), true);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgSocioFoto_Internalname, "SrcSet", context.GetImageSrcSet( A21SocioFoto), true);
            Z5SocioId = A5SocioId;
            sMode4 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load054( ) ;
            if ( AnyError == 1 )
            {
               RcdFound4 = 0;
               InitializeNonKey054( ) ;
            }
            Gx_mode = sMode4;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound4 = 0;
            InitializeNonKey054( ) ;
            sMode4 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal( ) ;
            Gx_mode = sMode4;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey054( ) ;
         if ( RcdFound4 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound4 = 0;
         /* Using cursor T00058 */
         pr_default.execute(6, new Object[] {A5SocioId});
         if ( (pr_default.getStatus(6) != 101) )
         {
            while ( (pr_default.getStatus(6) != 101) && ( ( T00058_A5SocioId[0] < A5SocioId ) ) )
            {
               pr_default.readNext(6);
            }
            if ( (pr_default.getStatus(6) != 101) && ( ( T00058_A5SocioId[0] > A5SocioId ) ) )
            {
               A5SocioId = T00058_A5SocioId[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5SocioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A5SocioId), 4, 0)));
               RcdFound4 = 1;
            }
         }
         pr_default.close(6);
      }

      protected void move_previous( )
      {
         RcdFound4 = 0;
         /* Using cursor T00059 */
         pr_default.execute(7, new Object[] {A5SocioId});
         if ( (pr_default.getStatus(7) != 101) )
         {
            while ( (pr_default.getStatus(7) != 101) && ( ( T00059_A5SocioId[0] > A5SocioId ) ) )
            {
               pr_default.readNext(7);
            }
            if ( (pr_default.getStatus(7) != 101) && ( ( T00059_A5SocioId[0] < A5SocioId ) ) )
            {
               A5SocioId = T00059_A5SocioId[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5SocioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A5SocioId), 4, 0)));
               RcdFound4 = 1;
            }
         }
         pr_default.close(7);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey054( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtSocioId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert054( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound4 == 1 )
            {
               if ( A5SocioId != Z5SocioId )
               {
                  A5SocioId = Z5SocioId;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5SocioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A5SocioId), 4, 0)));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "SOCIOID");
                  AnyError = 1;
                  GX_FocusControl = edtSocioId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtSocioId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Update record */
                  Update054( ) ;
                  GX_FocusControl = edtSocioId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A5SocioId != Z5SocioId )
               {
                  /* Insert record */
                  GX_FocusControl = edtSocioId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert054( ) ;
                  if ( AnyError == 1 )
                  {
                     GX_FocusControl = "";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "SOCIOID");
                     AnyError = 1;
                     GX_FocusControl = edtSocioId_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     /* Insert record */
                     GX_FocusControl = edtSocioId_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert054( ) ;
                     if ( AnyError == 1 )
                     {
                        GX_FocusControl = "";
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
         }
         AfterTrn( ) ;
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            if ( AnyError == 0 )
            {
               context.nUserReturn = 1;
            }
         }
      }

      protected void btn_delete( )
      {
         if ( A5SocioId != Z5SocioId )
         {
            A5SocioId = Z5SocioId;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5SocioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A5SocioId), 4, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "SOCIOID");
            AnyError = 1;
            GX_FocusControl = edtSocioId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtSocioId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency054( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00052 */
            pr_default.execute(0, new Object[] {A5SocioId});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Socio"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z18SocioDireccion, T00052_A18SocioDireccion[0]) != 0 ) || ( StringUtil.StrCmp(Z19SocioSexo, T00052_A19SocioSexo[0]) != 0 ) || ( Z20SocioEdad != T00052_A20SocioEdad[0] ) || ( StringUtil.StrCmp(Z33SocioTipoCuota, T00052_A33SocioTipoCuota[0]) != 0 ) || ( Z24SocioReconocido != T00052_A24SocioReconocido[0] ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( Z36CarnetId != T00052_A36CarnetId[0] ) )
            {
               if ( StringUtil.StrCmp(Z18SocioDireccion, T00052_A18SocioDireccion[0]) != 0 )
               {
                  GXUtil.WriteLog("socio:[seudo value changed for attri]"+"SocioDireccion");
                  GXUtil.WriteLogRaw("Old: ",Z18SocioDireccion);
                  GXUtil.WriteLogRaw("Current: ",T00052_A18SocioDireccion[0]);
               }
               if ( StringUtil.StrCmp(Z19SocioSexo, T00052_A19SocioSexo[0]) != 0 )
               {
                  GXUtil.WriteLog("socio:[seudo value changed for attri]"+"SocioSexo");
                  GXUtil.WriteLogRaw("Old: ",Z19SocioSexo);
                  GXUtil.WriteLogRaw("Current: ",T00052_A19SocioSexo[0]);
               }
               if ( Z20SocioEdad != T00052_A20SocioEdad[0] )
               {
                  GXUtil.WriteLog("socio:[seudo value changed for attri]"+"SocioEdad");
                  GXUtil.WriteLogRaw("Old: ",Z20SocioEdad);
                  GXUtil.WriteLogRaw("Current: ",T00052_A20SocioEdad[0]);
               }
               if ( StringUtil.StrCmp(Z33SocioTipoCuota, T00052_A33SocioTipoCuota[0]) != 0 )
               {
                  GXUtil.WriteLog("socio:[seudo value changed for attri]"+"SocioTipoCuota");
                  GXUtil.WriteLogRaw("Old: ",Z33SocioTipoCuota);
                  GXUtil.WriteLogRaw("Current: ",T00052_A33SocioTipoCuota[0]);
               }
               if ( Z24SocioReconocido != T00052_A24SocioReconocido[0] )
               {
                  GXUtil.WriteLog("socio:[seudo value changed for attri]"+"SocioReconocido");
                  GXUtil.WriteLogRaw("Old: ",Z24SocioReconocido);
                  GXUtil.WriteLogRaw("Current: ",T00052_A24SocioReconocido[0]);
               }
               if ( Z36CarnetId != T00052_A36CarnetId[0] )
               {
                  GXUtil.WriteLog("socio:[seudo value changed for attri]"+"CarnetId");
                  GXUtil.WriteLogRaw("Old: ",Z36CarnetId);
                  GXUtil.WriteLogRaw("Current: ",T00052_A36CarnetId[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Socio"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert054( )
      {
         BeforeValidate054( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable054( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM054( 0) ;
            CheckOptimisticConcurrency054( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm054( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert054( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000510 */
                     pr_default.execute(8, new Object[] {A5SocioId, A18SocioDireccion, A19SocioSexo, A20SocioEdad, A33SocioTipoCuota, A24SocioReconocido, A21SocioFoto, A40000SocioFoto_GXI, A36CarnetId});
                     pr_default.close(8);
                     dsDefault.SmartCacheProvider.SetUpdated("Socio") ;
                     if ( (pr_default.getStatus(8) == 1) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
                        AnyError = 1;
                     }
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        new ingresarcarneauto(context ).execute( ) ;
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
                           {
                              if ( AnyError == 0 )
                              {
                                 context.nUserReturn = 1;
                              }
                           }
                        }
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                     AnyError = 1;
                  }
               }
            }
            else
            {
               Load054( ) ;
            }
            EndLevel054( ) ;
         }
         CloseExtendedTableCursors054( ) ;
      }

      protected void Update054( )
      {
         BeforeValidate054( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable054( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency054( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm054( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate054( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000511 */
                     pr_default.execute(9, new Object[] {A18SocioDireccion, A19SocioSexo, A20SocioEdad, A33SocioTipoCuota, A24SocioReconocido, A36CarnetId, A5SocioId});
                     pr_default.close(9);
                     dsDefault.SmartCacheProvider.SetUpdated("Socio") ;
                     if ( (pr_default.getStatus(9) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Socio"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate054( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
                           {
                              if ( AnyError == 0 )
                              {
                                 context.nUserReturn = 1;
                              }
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                        AnyError = 1;
                     }
                  }
               }
            }
            EndLevel054( ) ;
         }
         CloseExtendedTableCursors054( ) ;
      }

      protected void DeferredUpdate054( )
      {
         if ( AnyError == 0 )
         {
            /* Using cursor T000512 */
            pr_default.execute(10, new Object[] {A21SocioFoto, A40000SocioFoto_GXI, A5SocioId});
            pr_default.close(10);
            dsDefault.SmartCacheProvider.SetUpdated("Socio") ;
         }
      }

      protected void delete( )
      {
         BeforeValidate054( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency054( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls054( ) ;
            AfterConfirm054( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete054( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000513 */
                  pr_default.execute(11, new Object[] {A5SocioId});
                  pr_default.close(11);
                  dsDefault.SmartCacheProvider.SetUpdated("Socio") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
                        {
                           if ( AnyError == 0 )
                           {
                              context.nUserReturn = 1;
                           }
                        }
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                     AnyError = 1;
                  }
               }
            }
         }
         sMode4 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel054( ) ;
         Gx_mode = sMode4;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls054( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV16Pgmname = "Socio";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16Pgmname", AV16Pgmname);
            if ( ( StringUtil.StrCmp(A33SocioTipoCuota, "P") == 0 ) && ( A20SocioEdad > 65 ) )
            {
               A32SocioMonto = (short)(1500-(1500*0.3m));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32SocioMonto", StringUtil.LTrim( StringUtil.Str( (decimal)(A32SocioMonto), 4, 0)));
            }
            else
            {
               if ( ( StringUtil.StrCmp(A33SocioTipoCuota, "V") == 0 ) && ( A20SocioEdad > 65 ) )
               {
                  A32SocioMonto = (short)(2500-(2500*0.3m));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32SocioMonto", StringUtil.LTrim( StringUtil.Str( (decimal)(A32SocioMonto), 4, 0)));
               }
               else
               {
                  if ( StringUtil.StrCmp(A33SocioTipoCuota, "P") == 0 )
                  {
                     A32SocioMonto = 1500;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32SocioMonto", StringUtil.LTrim( StringUtil.Str( (decimal)(A32SocioMonto), 4, 0)));
                  }
                  else
                  {
                     if ( true )
                     {
                        A32SocioMonto = 2500;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32SocioMonto", StringUtil.LTrim( StringUtil.Str( (decimal)(A32SocioMonto), 4, 0)));
                     }
                     else
                     {
                        A32SocioMonto = 0;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32SocioMonto", StringUtil.LTrim( StringUtil.Str( (decimal)(A32SocioMonto), 4, 0)));
                     }
                  }
               }
            }
            /* Using cursor T000514 */
            pr_default.execute(12, new Object[] {A36CarnetId});
            A37CarnetFechaIngreso = T000514_A37CarnetFechaIngreso[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37CarnetFechaIngreso", context.localUtil.Format(A37CarnetFechaIngreso, "99/99/99"));
            pr_default.close(12);
         }
         if ( AnyError == 0 )
         {
            /* Using cursor T000515 */
            pr_default.execute(13, new Object[] {A5SocioId});
            if ( (pr_default.getStatus(13) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Socios"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(13);
         }
      }

      protected void EndLevel054( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete054( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(1);
            pr_default.close(12);
            context.CommitDataStores("socio",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues050( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(1);
            pr_default.close(12);
            context.RollbackDataStores("socio",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart054( )
      {
         /* Scan By routine */
         /* Using cursor T000516 */
         pr_default.execute(14);
         RcdFound4 = 0;
         if ( (pr_default.getStatus(14) != 101) )
         {
            RcdFound4 = 1;
            A5SocioId = T000516_A5SocioId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5SocioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A5SocioId), 4, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext054( )
      {
         /* Scan next routine */
         pr_default.readNext(14);
         RcdFound4 = 0;
         if ( (pr_default.getStatus(14) != 101) )
         {
            RcdFound4 = 1;
            A5SocioId = T000516_A5SocioId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5SocioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A5SocioId), 4, 0)));
         }
      }

      protected void ScanEnd054( )
      {
         pr_default.close(14);
      }

      protected void AfterConfirm054( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert054( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate054( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete054( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete054( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate054( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes054( )
      {
         edtSocioId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSocioId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSocioId_Enabled), 5, 0)), true);
         edtSocioDireccion_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSocioDireccion_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSocioDireccion_Enabled), 5, 0)), true);
         cmbSocioSexo.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbSocioSexo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbSocioSexo.Enabled), 5, 0)), true);
         edtSocioEdad_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSocioEdad_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSocioEdad_Enabled), 5, 0)), true);
         cmbSocioTipoCuota.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbSocioTipoCuota_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbSocioTipoCuota.Enabled), 5, 0)), true);
         chkSocioReconocido.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkSocioReconocido_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkSocioReconocido.Enabled), 5, 0)), true);
         imgSocioFoto_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgSocioFoto_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(imgSocioFoto_Enabled), 5, 0)), true);
         edtSocioMonto_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSocioMonto_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSocioMonto_Enabled), 5, 0)), true);
         edtCarnetId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCarnetId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCarnetId_Enabled), 5, 0)), true);
         edtCarnetFechaIngreso_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCarnetFechaIngreso_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCarnetFechaIngreso_Enabled), 5, 0)), true);
      }

      protected void send_integrity_lvl_hashes054( )
      {
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues050( )
      {
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
         MasterPageObj.master_styles();
         if ( ( ( context.GetBrowserType( ) == 1 ) || ( context.GetBrowserType( ) == 5 ) ) && ( StringUtil.StrCmp(context.GetBrowserVersion( ), "7.0") == 0 ) )
         {
            context.AddJavascriptSource("json2.js", "?"+context.GetBuildNumber( 126726), false);
         }
         context.AddJavascriptSource("jquery.js", "?"+context.GetBuildNumber( 126726), false);
         context.AddJavascriptSource("gxtimezone.js", "?"+context.GetBuildNumber( 126726), false);
         context.AddJavascriptSource("gxgral.js", "?"+context.GetBuildNumber( 126726), false);
         context.AddJavascriptSource("bootstrap/js/bootstrap.min.js", "?"+context.GetBuildNumber( 126726), false);
         context.AddJavascriptSource("gxcfg.js", "?20194122114476", false);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.AddJavascriptSource("calendar.js", "?"+context.GetBuildNumber( 126726), false);
         context.AddJavascriptSource("calendar-setup.js", "?"+context.GetBuildNumber( 126726), false);
         context.AddJavascriptSource("calendar-en.js", "?"+context.GetBuildNumber( 126726), false);
         context.WriteHtmlText( Form.Headerrawhtml) ;
         context.CloseHtmlHeader();
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         FormProcess = " data-HasEnter=\"true\" data-Skiponenter=\"false\"";
         context.WriteHtmlText( "<body ") ;
         bodyStyle = "" + "background-color:" + context.BuildHTMLColor( Form.Backcolor) + ";color:" + context.BuildHTMLColor( Form.Textcolor) + ";";
         bodyStyle = bodyStyle + "-moz-opacity:0;opacity:0;";
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( Form.Background)) ) )
         {
            bodyStyle = bodyStyle + " background-image:url(" + context.convertURL( Form.Background) + ")";
         }
         context.WriteHtmlText( " "+"class=\"form-horizontal Form\""+" "+ "style='"+bodyStyle+"'") ;
         context.WriteHtmlText( FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("socio.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV12SocioId)+"\">") ;
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
         forbiddenHiddens = "hsh" + "Socio";
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV13Insert_CarnetId), "ZZZ9");
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("socio:[SendSecurityCheck value for]"+"Insert_CarnetId:"+context.localUtil.Format( (decimal)(AV13Insert_CarnetId), "ZZZ9"));
         GXUtil.WriteLog("socio:[SendSecurityCheck value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z5SocioId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z5SocioId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z18SocioDireccion", Z18SocioDireccion);
         GxWebStd.gx_hidden_field( context, "Z19SocioSexo", StringUtil.RTrim( Z19SocioSexo));
         GxWebStd.gx_hidden_field( context, "Z20SocioEdad", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z20SocioEdad), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z33SocioTipoCuota", StringUtil.RTrim( Z33SocioTipoCuota));
         GxWebStd.gx_boolean_hidden_field( context, "Z24SocioReconocido", Z24SocioReconocido);
         GxWebStd.gx_hidden_field( context, "Z36CarnetId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z36CarnetId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_Mode", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GxWebStd.gx_hidden_field( context, "N36CarnetId", StringUtil.LTrim( StringUtil.NToC( (decimal)(A36CarnetId), 4, 0, ".", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vTRNCONTEXT", AV9TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vTRNCONTEXT", AV9TrnContext);
         }
         GxWebStd.gx_hidden_field( context, "vSOCIOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV12SocioId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vSOCIOID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV12SocioId), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vGXBSCREEN", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gx_BScreen), 1, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vINSERT_CARNETID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13Insert_CarnetId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "SOCIOFOTO_GXI", A40000SocioFoto_GXI);
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV16Pgmname));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GXCCtlgxBlob = "SOCIOFOTO" + "_gxBlob";
         GxWebStd.gx_hidden_field( context, GXCCtlgxBlob, A21SocioFoto);
      }

      public override void RenderHtmlCloseForm( )
      {
         SendCloseFormHiddens( ) ;
         GxWebStd.gx_hidden_field( context, "GX_FocusControl", GX_FocusControl);
         SendAjaxEncryptionKey();
         SendSecurityToken(sPrefix);
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

      public override short ExecuteStartEvent( )
      {
         standaloneStartup( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         return gxajaxcallmode ;
      }

      public override void RenderHtmlContent( )
      {
         context.WriteHtmlText( "<div") ;
         GxWebStd.ClassAttribute( context, "gx-ct-body"+" "+(String.IsNullOrEmpty(StringUtil.RTrim( Form.Class)) ? "form-horizontal Form" : Form.Class)+"-fx");
         context.WriteHtmlText( ">") ;
         Draw( ) ;
         context.WriteHtmlText( "</div>") ;
      }

      public override void DispatchEvents( )
      {
         Process( ) ;
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
         return formatLink("socio.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV12SocioId) ;
      }

      public override String GetPgmname( )
      {
         return "Socio" ;
      }

      public override String GetPgmdesc( )
      {
         return "Socio" ;
      }

      protected void InitializeNonKey054( )
      {
         A36CarnetId = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36CarnetId", StringUtil.LTrim( StringUtil.Str( (decimal)(A36CarnetId), 4, 0)));
         A18SocioDireccion = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18SocioDireccion", A18SocioDireccion);
         A19SocioSexo = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19SocioSexo", A19SocioSexo);
         A20SocioEdad = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20SocioEdad", StringUtil.LTrim( StringUtil.Str( (decimal)(A20SocioEdad), 4, 0)));
         A33SocioTipoCuota = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33SocioTipoCuota", A33SocioTipoCuota);
         A24SocioReconocido = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A24SocioReconocido", A24SocioReconocido);
         A21SocioFoto = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A21SocioFoto", A21SocioFoto);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgSocioFoto_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A21SocioFoto)) ? A40000SocioFoto_GXI : context.convertURL( context.PathToRelativeUrl( A21SocioFoto))), true);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgSocioFoto_Internalname, "SrcSet", context.GetImageSrcSet( A21SocioFoto), true);
         A40000SocioFoto_GXI = "";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgSocioFoto_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A21SocioFoto)) ? A40000SocioFoto_GXI : context.convertURL( context.PathToRelativeUrl( A21SocioFoto))), true);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgSocioFoto_Internalname, "SrcSet", context.GetImageSrcSet( A21SocioFoto), true);
         A37CarnetFechaIngreso = DateTime.MinValue;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37CarnetFechaIngreso", context.localUtil.Format(A37CarnetFechaIngreso, "99/99/99"));
         A32SocioMonto = 2500;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32SocioMonto", StringUtil.LTrim( StringUtil.Str( (decimal)(A32SocioMonto), 4, 0)));
         Z18SocioDireccion = "";
         Z19SocioSexo = "";
         Z20SocioEdad = 0;
         Z33SocioTipoCuota = "";
         Z24SocioReconocido = false;
         Z36CarnetId = 0;
      }

      protected void InitAll054( )
      {
         A5SocioId = new ultimoidsocio(context).executeUdp( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5SocioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A5SocioId), 4, 0)));
         InitializeNonKey054( ) ;
      }

      protected void StandaloneModalInsert( )
      {
         A32SocioMonto = i32SocioMonto;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32SocioMonto", StringUtil.LTrim( StringUtil.Str( (decimal)(A32SocioMonto), 4, 0)));
      }

      protected void define_styles( )
      {
         AddStyleSheetFile("calendar-system.css", "");
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?"+GetCacheInvalidationToken( ), true);
         bool outputEnabled = isOutputEnabled( ) ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20194122114485", true);
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
         context.AddJavascriptSource("socio.js", "?20194122114486", false);
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         lblTitle_Internalname = "TITLE";
         divTitlecontainer_Internalname = "TITLECONTAINER";
         bttBtn_first_Internalname = "BTN_FIRST";
         bttBtn_previous_Internalname = "BTN_PREVIOUS";
         bttBtn_next_Internalname = "BTN_NEXT";
         bttBtn_last_Internalname = "BTN_LAST";
         bttBtn_select_Internalname = "BTN_SELECT";
         divToolbarcell_Internalname = "TOOLBARCELL";
         edtSocioId_Internalname = "SOCIOID";
         edtSocioDireccion_Internalname = "SOCIODIRECCION";
         cmbSocioSexo_Internalname = "SOCIOSEXO";
         edtSocioEdad_Internalname = "SOCIOEDAD";
         cmbSocioTipoCuota_Internalname = "SOCIOTIPOCUOTA";
         chkSocioReconocido_Internalname = "SOCIORECONOCIDO";
         imgSocioFoto_Internalname = "SOCIOFOTO";
         edtSocioMonto_Internalname = "SOCIOMONTO";
         edtCarnetId_Internalname = "CARNETID";
         edtCarnetFechaIngreso_Internalname = "CARNETFECHAINGRESO";
         divFormcontainer_Internalname = "FORMCONTAINER";
         bttBtn_enter_Internalname = "BTN_ENTER";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         bttBtn_delete_Internalname = "BTN_DELETE";
         divMaintable_Internalname = "MAINTABLE";
         Form.Internalname = "FORM";
         imgprompt_36_Internalname = "PROMPT_36";
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
         Form.Caption = "Socio";
         bttBtn_delete_Enabled = 0;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edtCarnetFechaIngreso_Jsonclick = "";
         edtCarnetFechaIngreso_Enabled = 0;
         imgprompt_36_Visible = 1;
         imgprompt_36_Link = "";
         edtCarnetId_Jsonclick = "";
         edtCarnetId_Enabled = 1;
         edtSocioMonto_Jsonclick = "";
         edtSocioMonto_Enabled = 0;
         imgSocioFoto_Enabled = 1;
         chkSocioReconocido.Enabled = 1;
         cmbSocioTipoCuota_Jsonclick = "";
         cmbSocioTipoCuota.Enabled = 1;
         edtSocioEdad_Jsonclick = "";
         edtSocioEdad_Enabled = 1;
         cmbSocioSexo_Jsonclick = "";
         cmbSocioSexo.Enabled = 1;
         edtSocioDireccion_Enabled = 1;
         edtSocioId_Jsonclick = "";
         edtSocioId_Enabled = 1;
         bttBtn_select_Visible = 1;
         bttBtn_last_Visible = 1;
         bttBtn_next_Visible = 1;
         bttBtn_previous_Visible = 1;
         bttBtn_first_Visible = 1;
         context.GX_msglist.DisplayMode = 1;
         if ( context.isSpaRequest( ) )
         {
            enableJsOutput();
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void GX6ASASOCIOID054( short AV12SocioId ,
                                       short Gx_BScreen )
      {
         if ( ! (0==AV12SocioId) )
         {
            A5SocioId = AV12SocioId;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5SocioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A5SocioId), 4, 0)));
         }
         else
         {
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && (0==A5SocioId) && ( Gx_BScreen == 0 ) )
            {
               GXt_int1 = A5SocioId;
               new ultimoidsocio(context ).execute( out  GXt_int1) ;
               A5SocioId = GXt_int1;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5SocioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A5SocioId), 4, 0)));
            }
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A5SocioId), 4, 0, ".", "")))+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void XC_13_054( )
      {
         new ingresarcarneauto(context ).execute( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
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
            A19SocioSexo = cmbSocioSexo.getValidValue(A19SocioSexo);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19SocioSexo", A19SocioSexo);
         }
         cmbSocioTipoCuota.Name = "SOCIOTIPOCUOTA";
         cmbSocioTipoCuota.WebTags = "";
         cmbSocioTipoCuota.addItem("V", "Verano", 0);
         cmbSocioTipoCuota.addItem("P", "Permanente", 0);
         if ( cmbSocioTipoCuota.ItemCount > 0 )
         {
            A33SocioTipoCuota = cmbSocioTipoCuota.getValidValue(A33SocioTipoCuota);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33SocioTipoCuota", A33SocioTipoCuota);
         }
         chkSocioReconocido.Name = "SOCIORECONOCIDO";
         chkSocioReconocido.WebTags = "";
         chkSocioReconocido.Caption = "";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkSocioReconocido_Internalname, "TitleCaption", chkSocioReconocido.Caption, true);
         chkSocioReconocido.CheckedValue = "false";
         /* End function init_web_controls */
      }

      public void Valid_Carnetid( short GX_Parm1 ,
                                  DateTime GX_Parm2 )
      {
         A36CarnetId = GX_Parm1;
         A37CarnetFechaIngreso = GX_Parm2;
         /* Using cursor T000514 */
         pr_default.execute(12, new Object[] {A36CarnetId});
         if ( (pr_default.getStatus(12) == 101) )
         {
            GX_msglist.addItem("No matching 'Carnet'.", "ForeignKeyNotFound", 1, "CARNETID");
            AnyError = 1;
            GX_FocusControl = edtCarnetId_Internalname;
         }
         A37CarnetFechaIngreso = T000514_A37CarnetFechaIngreso[0];
         pr_default.close(12);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A37CarnetFechaIngreso = DateTime.MinValue;
         }
         isValidOutput.Add(context.localUtil.Format(A37CarnetFechaIngreso, "99/99/99"));
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         isValidOutput.Add(context.httpAjaxContext.ajax_rsp_get_hiddens( ));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public override bool SupportAjaxEvent( )
      {
         return true ;
      }

      public override void InitializeDynEvents( )
      {
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV12SocioId',fld:'vSOCIOID',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV12SocioId',fld:'vSOCIOID',pic:'ZZZ9',hsh:true},{av:'AV13Insert_CarnetId',fld:'vINSERT_CARNETID',pic:'ZZZ9'}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("AFTER TRN","{handler:'E12052',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV9TrnContext',fld:'vTRNCONTEXT',pic:''}]");
         setEventMetadata("AFTER TRN",",oparms:[]}");
         setEventMetadata("DELETE","{handler:'E13052',iparms:[]");
         setEventMetadata("DELETE",",oparms:[]}");
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
         pr_default.close(1);
         pr_default.close(12);
      }

      public override void initialize( )
      {
         sPrefix = "";
         wcpOGx_mode = "";
         Z18SocioDireccion = "";
         Z19SocioSexo = "";
         Z33SocioTipoCuota = "";
         scmdbuf = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         GXKey = "";
         PreviousTooltip = "";
         PreviousCaption = "";
         Form = new GXWebForm();
         GX_FocusControl = "";
         A19SocioSexo = "";
         A33SocioTipoCuota = "";
         lblTitle_Jsonclick = "";
         ClassString = "";
         StyleString = "";
         TempTags = "";
         bttBtn_first_Jsonclick = "";
         bttBtn_previous_Jsonclick = "";
         bttBtn_next_Jsonclick = "";
         bttBtn_last_Jsonclick = "";
         bttBtn_select_Jsonclick = "";
         A18SocioDireccion = "";
         A21SocioFoto = "";
         A40000SocioFoto_GXI = "";
         sImgUrl = "";
         A37CarnetFechaIngreso = DateTime.MinValue;
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         AV16Pgmname = "";
         forbiddenHiddens = "";
         hsh = "";
         sMode4 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV9TrnContext = new SdtTransactionContext(context);
         AV10WebSession = context.GetSession();
         AV14TrnContextAtt = new SdtTransactionContext_Attribute(context);
         Z21SocioFoto = "";
         Z40000SocioFoto_GXI = "";
         Z37CarnetFechaIngreso = DateTime.MinValue;
         T00054_A37CarnetFechaIngreso = new DateTime[] {DateTime.MinValue} ;
         T00055_A5SocioId = new short[1] ;
         T00055_A18SocioDireccion = new String[] {""} ;
         T00055_A19SocioSexo = new String[] {""} ;
         T00055_A20SocioEdad = new short[1] ;
         T00055_A33SocioTipoCuota = new String[] {""} ;
         T00055_A24SocioReconocido = new bool[] {false} ;
         T00055_A40000SocioFoto_GXI = new String[] {""} ;
         T00055_A37CarnetFechaIngreso = new DateTime[] {DateTime.MinValue} ;
         T00055_A36CarnetId = new short[1] ;
         T00055_A21SocioFoto = new String[] {""} ;
         T00056_A37CarnetFechaIngreso = new DateTime[] {DateTime.MinValue} ;
         T00057_A5SocioId = new short[1] ;
         T00053_A5SocioId = new short[1] ;
         T00053_A18SocioDireccion = new String[] {""} ;
         T00053_A19SocioSexo = new String[] {""} ;
         T00053_A20SocioEdad = new short[1] ;
         T00053_A33SocioTipoCuota = new String[] {""} ;
         T00053_A24SocioReconocido = new bool[] {false} ;
         T00053_A40000SocioFoto_GXI = new String[] {""} ;
         T00053_A36CarnetId = new short[1] ;
         T00053_A21SocioFoto = new String[] {""} ;
         T00058_A5SocioId = new short[1] ;
         T00059_A5SocioId = new short[1] ;
         T00052_A5SocioId = new short[1] ;
         T00052_A18SocioDireccion = new String[] {""} ;
         T00052_A19SocioSexo = new String[] {""} ;
         T00052_A20SocioEdad = new short[1] ;
         T00052_A33SocioTipoCuota = new String[] {""} ;
         T00052_A24SocioReconocido = new bool[] {false} ;
         T00052_A40000SocioFoto_GXI = new String[] {""} ;
         T00052_A36CarnetId = new short[1] ;
         T00052_A21SocioFoto = new String[] {""} ;
         T000514_A37CarnetFechaIngreso = new DateTime[] {DateTime.MinValue} ;
         T000515_A3ClaseId = new short[1] ;
         T000515_A5SocioId = new short[1] ;
         T000516_A5SocioId = new short[1] ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GXCCtlgxBlob = "";
         isValidOutput = new GxUnknownObjectCollection();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.socio__default(),
            new Object[][] {
                new Object[] {
               T00052_A5SocioId, T00052_A18SocioDireccion, T00052_A19SocioSexo, T00052_A20SocioEdad, T00052_A33SocioTipoCuota, T00052_A24SocioReconocido, T00052_A40000SocioFoto_GXI, T00052_A36CarnetId, T00052_A21SocioFoto
               }
               , new Object[] {
               T00053_A5SocioId, T00053_A18SocioDireccion, T00053_A19SocioSexo, T00053_A20SocioEdad, T00053_A33SocioTipoCuota, T00053_A24SocioReconocido, T00053_A40000SocioFoto_GXI, T00053_A36CarnetId, T00053_A21SocioFoto
               }
               , new Object[] {
               T00054_A37CarnetFechaIngreso
               }
               , new Object[] {
               T00055_A5SocioId, T00055_A18SocioDireccion, T00055_A19SocioSexo, T00055_A20SocioEdad, T00055_A33SocioTipoCuota, T00055_A24SocioReconocido, T00055_A40000SocioFoto_GXI, T00055_A37CarnetFechaIngreso, T00055_A36CarnetId, T00055_A21SocioFoto
               }
               , new Object[] {
               T00056_A37CarnetFechaIngreso
               }
               , new Object[] {
               T00057_A5SocioId
               }
               , new Object[] {
               T00058_A5SocioId
               }
               , new Object[] {
               T00059_A5SocioId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000514_A37CarnetFechaIngreso
               }
               , new Object[] {
               T000515_A3ClaseId, T000515_A5SocioId
               }
               , new Object[] {
               T000516_A5SocioId
               }
            }
         );
         AV16Pgmname = "Socio";
         Z5SocioId = new ultimoidsocio(context).executeUdp( );
         A5SocioId = new ultimoidsocio(context).executeUdp( );
         A32SocioMonto = 2500;
         i32SocioMonto = 2500;
      }

      private short wcpOAV12SocioId ;
      private short Z5SocioId ;
      private short Z20SocioEdad ;
      private short Z36CarnetId ;
      private short N36CarnetId ;
      private short GxWebError ;
      private short AV12SocioId ;
      private short Gx_BScreen ;
      private short A36CarnetId ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short A5SocioId ;
      private short A20SocioEdad ;
      private short A32SocioMonto ;
      private short AV13Insert_CarnetId ;
      private short RcdFound4 ;
      private short GX_JID ;
      private short gxajaxcallmode ;
      private short i32SocioMonto ;
      private short GXt_int1 ;
      private short wbTemp ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int edtSocioId_Enabled ;
      private int edtSocioDireccion_Enabled ;
      private int edtSocioEdad_Enabled ;
      private int imgSocioFoto_Enabled ;
      private int edtSocioMonto_Enabled ;
      private int edtCarnetId_Enabled ;
      private int imgprompt_36_Visible ;
      private int edtCarnetFechaIngreso_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int AV17GXV1 ;
      private int idxLst ;
      private String sPrefix ;
      private String wcpOGx_mode ;
      private String Z19SocioSexo ;
      private String Z33SocioTipoCuota ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String Gx_mode ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtSocioId_Internalname ;
      private String A19SocioSexo ;
      private String cmbSocioSexo_Internalname ;
      private String A33SocioTipoCuota ;
      private String cmbSocioTipoCuota_Internalname ;
      private String divMaintable_Internalname ;
      private String divTitlecontainer_Internalname ;
      private String lblTitle_Internalname ;
      private String lblTitle_Jsonclick ;
      private String ClassString ;
      private String StyleString ;
      private String divFormcontainer_Internalname ;
      private String divToolbarcell_Internalname ;
      private String TempTags ;
      private String bttBtn_first_Internalname ;
      private String bttBtn_first_Jsonclick ;
      private String bttBtn_previous_Internalname ;
      private String bttBtn_previous_Jsonclick ;
      private String bttBtn_next_Internalname ;
      private String bttBtn_next_Jsonclick ;
      private String bttBtn_last_Internalname ;
      private String bttBtn_last_Jsonclick ;
      private String bttBtn_select_Internalname ;
      private String bttBtn_select_Jsonclick ;
      private String edtSocioId_Jsonclick ;
      private String edtSocioDireccion_Internalname ;
      private String cmbSocioSexo_Jsonclick ;
      private String edtSocioEdad_Internalname ;
      private String edtSocioEdad_Jsonclick ;
      private String cmbSocioTipoCuota_Jsonclick ;
      private String chkSocioReconocido_Internalname ;
      private String imgSocioFoto_Internalname ;
      private String sImgUrl ;
      private String edtSocioMonto_Internalname ;
      private String edtSocioMonto_Jsonclick ;
      private String edtCarnetId_Internalname ;
      private String edtCarnetId_Jsonclick ;
      private String imgprompt_36_Internalname ;
      private String imgprompt_36_Link ;
      private String edtCarnetFechaIngreso_Internalname ;
      private String edtCarnetFechaIngreso_Jsonclick ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String AV16Pgmname ;
      private String forbiddenHiddens ;
      private String hsh ;
      private String sMode4 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GXCCtlgxBlob ;
      private DateTime A37CarnetFechaIngreso ;
      private DateTime Z37CarnetFechaIngreso ;
      private bool Z24SocioReconocido ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool A24SocioReconocido ;
      private bool A21SocioFoto_IsBlob ;
      private bool returnInSub ;
      private bool Gx_longc ;
      private String Z18SocioDireccion ;
      private String A18SocioDireccion ;
      private String A40000SocioFoto_GXI ;
      private String Z40000SocioFoto_GXI ;
      private String A21SocioFoto ;
      private String Z21SocioFoto ;
      private IGxSession AV10WebSession ;
      private GxUnknownObjectCollection isValidOutput ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbSocioSexo ;
      private GXCombobox cmbSocioTipoCuota ;
      private GXCheckbox chkSocioReconocido ;
      private IDataStoreProvider pr_default ;
      private DateTime[] T00054_A37CarnetFechaIngreso ;
      private short[] T00055_A5SocioId ;
      private String[] T00055_A18SocioDireccion ;
      private String[] T00055_A19SocioSexo ;
      private short[] T00055_A20SocioEdad ;
      private String[] T00055_A33SocioTipoCuota ;
      private bool[] T00055_A24SocioReconocido ;
      private String[] T00055_A40000SocioFoto_GXI ;
      private DateTime[] T00055_A37CarnetFechaIngreso ;
      private short[] T00055_A36CarnetId ;
      private String[] T00055_A21SocioFoto ;
      private DateTime[] T00056_A37CarnetFechaIngreso ;
      private short[] T00057_A5SocioId ;
      private short[] T00053_A5SocioId ;
      private String[] T00053_A18SocioDireccion ;
      private String[] T00053_A19SocioSexo ;
      private short[] T00053_A20SocioEdad ;
      private String[] T00053_A33SocioTipoCuota ;
      private bool[] T00053_A24SocioReconocido ;
      private String[] T00053_A40000SocioFoto_GXI ;
      private short[] T00053_A36CarnetId ;
      private String[] T00053_A21SocioFoto ;
      private short[] T00058_A5SocioId ;
      private short[] T00059_A5SocioId ;
      private short[] T00052_A5SocioId ;
      private String[] T00052_A18SocioDireccion ;
      private String[] T00052_A19SocioSexo ;
      private short[] T00052_A20SocioEdad ;
      private String[] T00052_A33SocioTipoCuota ;
      private bool[] T00052_A24SocioReconocido ;
      private String[] T00052_A40000SocioFoto_GXI ;
      private short[] T00052_A36CarnetId ;
      private String[] T00052_A21SocioFoto ;
      private DateTime[] T000514_A37CarnetFechaIngreso ;
      private short[] T000515_A3ClaseId ;
      private short[] T000515_A5SocioId ;
      private short[] T000516_A5SocioId ;
      private GXWebForm Form ;
      private SdtTransactionContext AV9TrnContext ;
      private SdtTransactionContext_Attribute AV14TrnContextAtt ;
   }

   public class socio__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new ForEachCursor(def[5])
         ,new ForEachCursor(def[6])
         ,new ForEachCursor(def[7])
         ,new UpdateCursor(def[8])
         ,new UpdateCursor(def[9])
         ,new UpdateCursor(def[10])
         ,new UpdateCursor(def[11])
         ,new ForEachCursor(def[12])
         ,new ForEachCursor(def[13])
         ,new ForEachCursor(def[14])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT00055 ;
          prmT00055 = new Object[] {
          new Object[] {"@SocioId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00054 ;
          prmT00054 = new Object[] {
          new Object[] {"@CarnetId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00056 ;
          prmT00056 = new Object[] {
          new Object[] {"@CarnetId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00057 ;
          prmT00057 = new Object[] {
          new Object[] {"@SocioId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00053 ;
          prmT00053 = new Object[] {
          new Object[] {"@SocioId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00058 ;
          prmT00058 = new Object[] {
          new Object[] {"@SocioId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00059 ;
          prmT00059 = new Object[] {
          new Object[] {"@SocioId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00052 ;
          prmT00052 = new Object[] {
          new Object[] {"@SocioId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000510 ;
          prmT000510 = new Object[] {
          new Object[] {"@SocioId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@SocioDireccion",SqlDbType.VarChar,1024,0} ,
          new Object[] {"@SocioSexo",SqlDbType.Char,20,0} ,
          new Object[] {"@SocioEdad",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@SocioTipoCuota",SqlDbType.Char,20,0} ,
          new Object[] {"@SocioReconocido",SqlDbType.Bit,4,0} ,
          new Object[] {"@SocioFoto",SqlDbType.VarBinary,1024,0} ,
          new Object[] {"@SocioFoto_GXI",SqlDbType.VarChar,2048,0} ,
          new Object[] {"@CarnetId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000511 ;
          prmT000511 = new Object[] {
          new Object[] {"@SocioDireccion",SqlDbType.VarChar,1024,0} ,
          new Object[] {"@SocioSexo",SqlDbType.Char,20,0} ,
          new Object[] {"@SocioEdad",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@SocioTipoCuota",SqlDbType.Char,20,0} ,
          new Object[] {"@SocioReconocido",SqlDbType.Bit,4,0} ,
          new Object[] {"@CarnetId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@SocioId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000512 ;
          prmT000512 = new Object[] {
          new Object[] {"@SocioFoto",SqlDbType.VarBinary,1024,0} ,
          new Object[] {"@SocioFoto_GXI",SqlDbType.VarChar,2048,0} ,
          new Object[] {"@SocioId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000513 ;
          prmT000513 = new Object[] {
          new Object[] {"@SocioId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000515 ;
          prmT000515 = new Object[] {
          new Object[] {"@SocioId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000516 ;
          prmT000516 = new Object[] {
          } ;
          Object[] prmT000514 ;
          prmT000514 = new Object[] {
          new Object[] {"@CarnetId",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T00052", "SELECT [SocioId], [SocioDireccion], [SocioSexo], [SocioEdad], [SocioTipoCuota], [SocioReconocido], [SocioFoto_GXI], [CarnetId], [SocioFoto] FROM [Socio] WITH (UPDLOCK) WHERE [SocioId] = @SocioId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00052,1,0,true,false )
             ,new CursorDef("T00053", "SELECT [SocioId], [SocioDireccion], [SocioSexo], [SocioEdad], [SocioTipoCuota], [SocioReconocido], [SocioFoto_GXI], [CarnetId], [SocioFoto] FROM [Socio] WITH (NOLOCK) WHERE [SocioId] = @SocioId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00053,1,0,true,false )
             ,new CursorDef("T00054", "SELECT [CarnetFechaIngreso] FROM [Carnet] WITH (NOLOCK) WHERE [CarnetId] = @CarnetId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00054,1,0,true,false )
             ,new CursorDef("T00055", "SELECT TM1.[SocioId], TM1.[SocioDireccion], TM1.[SocioSexo], TM1.[SocioEdad], TM1.[SocioTipoCuota], TM1.[SocioReconocido], TM1.[SocioFoto_GXI], T2.[CarnetFechaIngreso], TM1.[CarnetId], TM1.[SocioFoto] FROM ([Socio] TM1 WITH (NOLOCK) INNER JOIN [Carnet] T2 WITH (NOLOCK) ON T2.[CarnetId] = TM1.[CarnetId]) WHERE TM1.[SocioId] = @SocioId ORDER BY TM1.[SocioId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00055,100,0,true,false )
             ,new CursorDef("T00056", "SELECT [CarnetFechaIngreso] FROM [Carnet] WITH (NOLOCK) WHERE [CarnetId] = @CarnetId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00056,1,0,true,false )
             ,new CursorDef("T00057", "SELECT [SocioId] FROM [Socio] WITH (NOLOCK) WHERE [SocioId] = @SocioId  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00057,1,0,true,false )
             ,new CursorDef("T00058", "SELECT TOP 1 [SocioId] FROM [Socio] WITH (NOLOCK) WHERE ( [SocioId] > @SocioId) ORDER BY [SocioId]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00058,1,0,true,true )
             ,new CursorDef("T00059", "SELECT TOP 1 [SocioId] FROM [Socio] WITH (NOLOCK) WHERE ( [SocioId] < @SocioId) ORDER BY [SocioId] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00059,1,0,true,true )
             ,new CursorDef("T000510", "INSERT INTO [Socio]([SocioId], [SocioDireccion], [SocioSexo], [SocioEdad], [SocioTipoCuota], [SocioReconocido], [SocioFoto], [SocioFoto_GXI], [CarnetId]) VALUES(@SocioId, @SocioDireccion, @SocioSexo, @SocioEdad, @SocioTipoCuota, @SocioReconocido, @SocioFoto, @SocioFoto_GXI, @CarnetId)", GxErrorMask.GX_NOMASK,prmT000510)
             ,new CursorDef("T000511", "UPDATE [Socio] SET [SocioDireccion]=@SocioDireccion, [SocioSexo]=@SocioSexo, [SocioEdad]=@SocioEdad, [SocioTipoCuota]=@SocioTipoCuota, [SocioReconocido]=@SocioReconocido, [CarnetId]=@CarnetId  WHERE [SocioId] = @SocioId", GxErrorMask.GX_NOMASK,prmT000511)
             ,new CursorDef("T000512", "UPDATE [Socio] SET [SocioFoto]=@SocioFoto, [SocioFoto_GXI]=@SocioFoto_GXI  WHERE [SocioId] = @SocioId", GxErrorMask.GX_NOMASK,prmT000512)
             ,new CursorDef("T000513", "DELETE FROM [Socio]  WHERE [SocioId] = @SocioId", GxErrorMask.GX_NOMASK,prmT000513)
             ,new CursorDef("T000514", "SELECT [CarnetFechaIngreso] FROM [Carnet] WITH (NOLOCK) WHERE [CarnetId] = @CarnetId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000514,1,0,true,false )
             ,new CursorDef("T000515", "SELECT TOP 1 [ClaseId], [SocioId] FROM [ClaseSocios] WITH (NOLOCK) WHERE [SocioId] = @SocioId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000515,1,0,true,true )
             ,new CursorDef("T000516", "SELECT [SocioId] FROM [Socio] WITH (NOLOCK) ORDER BY [SocioId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000516,100,0,true,false )
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
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 20) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 20) ;
                ((bool[]) buf[5])[0] = rslt.getBool(6) ;
                ((String[]) buf[6])[0] = rslt.getMultimediaUri(7) ;
                ((short[]) buf[7])[0] = rslt.getShort(8) ;
                ((String[]) buf[8])[0] = rslt.getMultimediaFile(9, rslt.getVarchar(7)) ;
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 20) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 20) ;
                ((bool[]) buf[5])[0] = rslt.getBool(6) ;
                ((String[]) buf[6])[0] = rslt.getMultimediaUri(7) ;
                ((short[]) buf[7])[0] = rslt.getShort(8) ;
                ((String[]) buf[8])[0] = rslt.getMultimediaFile(9, rslt.getVarchar(7)) ;
                return;
             case 2 :
                ((DateTime[]) buf[0])[0] = rslt.getGXDate(1) ;
                return;
             case 3 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 20) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 20) ;
                ((bool[]) buf[5])[0] = rslt.getBool(6) ;
                ((String[]) buf[6])[0] = rslt.getMultimediaUri(7) ;
                ((DateTime[]) buf[7])[0] = rslt.getGXDate(8) ;
                ((short[]) buf[8])[0] = rslt.getShort(9) ;
                ((String[]) buf[9])[0] = rslt.getMultimediaFile(10, rslt.getVarchar(7)) ;
                return;
             case 4 :
                ((DateTime[]) buf[0])[0] = rslt.getGXDate(1) ;
                return;
             case 5 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 6 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 7 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 12 :
                ((DateTime[]) buf[0])[0] = rslt.getGXDate(1) ;
                return;
             case 13 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                return;
             case 14 :
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
             case 0 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 2 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 3 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 4 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 5 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 6 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 7 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 8 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (bool)parms[5]);
                stmt.SetParameterBlob(7, (String)parms[6], false);
                stmt.SetParameterMultimedia(8, (String)parms[7], (String)parms[6], "Socio", "SocioFoto");
                stmt.SetParameter(9, (short)parms[8]);
                return;
             case 9 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (bool)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                stmt.SetParameter(7, (short)parms[6]);
                return;
             case 10 :
                stmt.SetParameterBlob(1, (String)parms[0], false);
                stmt.SetParameterMultimedia(2, (String)parms[1], (String)parms[0], "Socio", "SocioFoto");
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 11 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 12 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 13 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
       }
    }

 }

}
