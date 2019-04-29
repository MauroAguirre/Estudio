/*
               File: Profesor
        Description: Profesor
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 4/12/2019 21:1:41.94
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
   public class profesor : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel3"+"_"+"PROFESORID") == 0 )
         {
            AV7ProfesorId = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7ProfesorId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7ProfesorId), 4, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vPROFESORID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7ProfesorId), "ZZZ9"), context));
            Gx_BScreen = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX3ASAPROFESORID0211( AV7ProfesorId, Gx_BScreen) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_10") == 0 )
         {
            A1ActividadId = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1ActividadId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1ActividadId), 4, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_10( A1ActividadId) ;
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
               AV7ProfesorId = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7ProfesorId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7ProfesorId), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vPROFESORID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7ProfesorId), "ZZZ9"), context));
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
            Form.Meta.addItem("description", "Profesor", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtProfesorId_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("Carmine");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public profesor( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public profesor( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( String aP0_Gx_mode ,
                           short aP1_ProfesorId )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV7ProfesorId = aP1_ProfesorId;
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
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "Profesor", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_Profesor.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "", bttBtn_first_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_first_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Profesor.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "", bttBtn_previous_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_previous_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_Profesor.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", "", bttBtn_next_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_next_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_Profesor.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", "", bttBtn_last_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_last_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Profesor.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Select", bttBtn_select_Jsonclick, 5, "Select", "", StyleString, ClassString, bttBtn_select_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "", 2, "HLP_Profesor.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtProfesorId_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtProfesorId_Internalname, "Id", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtProfesorId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A2ProfesorId), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A2ProfesorId), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,34);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtProfesorId_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtProfesorId_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Profesor.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtProfesorNombre_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtProfesorNombre_Internalname, "Nombre", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtProfesorNombre_Internalname, StringUtil.RTrim( A15ProfesorNombre), StringUtil.RTrim( context.localUtil.Format( A15ProfesorNombre, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,39);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtProfesorNombre_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtProfesorNombre_Enabled, 0, "text", "", 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Profesor.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtProfesorDireccion_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtProfesorDireccion_Internalname, "Direccion", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtProfesorDireccion_Internalname, A16ProfesorDireccion, "http://maps.google.com/maps?q="+GXUtil.UrlEncode( A16ProfesorDireccion), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,44);\"", 0, 1, edtProfesorDireccion_Enabled, 0, 80, "chr", 10, "row", StyleString, ClassString, "", "", "1024", -1, 0, "_blank", "", 0, true, "GeneXus\\Address", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_Profesor.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+imgProfesorFoto_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, imgProfesorFoto_Internalname, "Foto", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Static Bitmap Variable */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 49,'',false,'',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            A17ProfesorFoto_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( A17ProfesorFoto))&&String.IsNullOrEmpty(StringUtil.RTrim( A40000ProfesorFoto_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( A17ProfesorFoto)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( A17ProfesorFoto)) ? A40000ProfesorFoto_GXI : context.PathToRelativeUrl( A17ProfesorFoto));
            GxWebStd.gx_bitmap( context, imgProfesorFoto_Internalname, sImgUrl, "", "", "", context.GetTheme( ), 1, imgProfesorFoto_Enabled, "", "", 1, -1, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,49);\"", "", "", "", 0, A17ProfesorFoto_IsBlob, true, context.GetImageSrcSet( sImgUrl), "HLP_Profesor.htm");
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgProfesorFoto_Internalname, "URL", (String.IsNullOrEmpty(StringUtil.RTrim( A17ProfesorFoto)) ? A40000ProfesorFoto_GXI : context.PathToRelativeUrl( A17ProfesorFoto)), true);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgProfesorFoto_Internalname, "IsBlob", StringUtil.BoolToStr( A17ProfesorFoto_IsBlob), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtActividadId_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtActividadId_Internalname, "Actividad Id", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 54,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtActividadId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A1ActividadId), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A1ActividadId), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,54);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtActividadId_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtActividadId_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Profesor.htm");
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgprompt_1_Internalname, sImgUrl, imgprompt_1_Link, "", "", context.GetTheme( ), imgprompt_1_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_Profesor.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtActividadDescripcion_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtActividadDescripcion_Internalname, "Actividad Descripcion", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtActividadDescripcion_Internalname, StringUtil.RTrim( A13ActividadDescripcion), StringUtil.RTrim( context.localUtil.Format( A13ActividadDescripcion, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtActividadDescripcion_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtActividadDescripcion_Enabled, 0, "text", "", 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Profesor.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 64,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirm", bttBtn_enter_Jsonclick, 5, "Confirm", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_Profesor.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 66,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancel", bttBtn_cancel_Jsonclick, 1, "Cancel", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Profesor.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 68,'',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Delete", bttBtn_delete_Jsonclick, 5, "Delete", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_Profesor.htm");
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
         E11022 ();
         context.wbGlbDoneStart = 1;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read variables values. */
               if ( ( ( context.localUtil.CToN( cgiGet( edtProfesorId_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtProfesorId_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "PROFESORID");
                  AnyError = 1;
                  GX_FocusControl = edtProfesorId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A2ProfesorId = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2ProfesorId", StringUtil.LTrim( StringUtil.Str( (decimal)(A2ProfesorId), 4, 0)));
               }
               else
               {
                  A2ProfesorId = (short)(context.localUtil.CToN( cgiGet( edtProfesorId_Internalname), ".", ","));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2ProfesorId", StringUtil.LTrim( StringUtil.Str( (decimal)(A2ProfesorId), 4, 0)));
               }
               A15ProfesorNombre = cgiGet( edtProfesorNombre_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A15ProfesorNombre", A15ProfesorNombre);
               A16ProfesorDireccion = cgiGet( edtProfesorDireccion_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16ProfesorDireccion", A16ProfesorDireccion);
               A17ProfesorFoto = cgiGet( imgProfesorFoto_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A17ProfesorFoto", A17ProfesorFoto);
               if ( ( ( context.localUtil.CToN( cgiGet( edtActividadId_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtActividadId_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "ACTIVIDADID");
                  AnyError = 1;
                  GX_FocusControl = edtActividadId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A1ActividadId = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1ActividadId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1ActividadId), 4, 0)));
               }
               else
               {
                  A1ActividadId = (short)(context.localUtil.CToN( cgiGet( edtActividadId_Internalname), ".", ","));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1ActividadId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1ActividadId), 4, 0)));
               }
               A13ActividadDescripcion = cgiGet( edtActividadDescripcion_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13ActividadDescripcion", A13ActividadDescripcion);
               /* Read saved values. */
               Z2ProfesorId = (short)(context.localUtil.CToN( cgiGet( "Z2ProfesorId"), ".", ","));
               Z15ProfesorNombre = cgiGet( "Z15ProfesorNombre");
               Z16ProfesorDireccion = cgiGet( "Z16ProfesorDireccion");
               Z1ActividadId = (short)(context.localUtil.CToN( cgiGet( "Z1ActividadId"), ".", ","));
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ","));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ".", ","));
               Gx_mode = cgiGet( "Mode");
               N1ActividadId = (short)(context.localUtil.CToN( cgiGet( "N1ActividadId"), ".", ","));
               AV7ProfesorId = (short)(context.localUtil.CToN( cgiGet( "vPROFESORID"), ".", ","));
               Gx_BScreen = (short)(context.localUtil.CToN( cgiGet( "vGXBSCREEN"), ".", ","));
               AV11Insert_ActividadId = (short)(context.localUtil.CToN( cgiGet( "vINSERT_ACTIVIDADID"), ".", ","));
               A40000ProfesorFoto_GXI = cgiGet( "PROFESORFOTO_GXI");
               AV15Pgmname = cgiGet( "vPGMNAME");
               Gx_mode = cgiGet( "vMODE");
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               getMultimediaValue(imgProfesorFoto_Internalname, ref  A17ProfesorFoto, ref  A40000ProfesorFoto_GXI);
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               forbiddenHiddens = "hsh" + "Profesor";
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV11Insert_ActividadId), "ZZZ9");
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( A2ProfesorId != Z2ProfesorId ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
               {
                  GXUtil.WriteLog("profesor:[SecurityCheckFailed value for]"+"Insert_ActividadId:"+context.localUtil.Format( (decimal)(AV11Insert_ActividadId), "ZZZ9"));
                  GXUtil.WriteLog("profesor:[SecurityCheckFailed value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
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
                  A2ProfesorId = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2ProfesorId", StringUtil.LTrim( StringUtil.Str( (decimal)(A2ProfesorId), 4, 0)));
                  getEqualNoModal( ) ;
                  if ( ! (0==AV7ProfesorId) )
                  {
                     A2ProfesorId = AV7ProfesorId;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2ProfesorId", StringUtil.LTrim( StringUtil.Str( (decimal)(A2ProfesorId), 4, 0)));
                  }
                  else
                  {
                     if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && (0==A2ProfesorId) && ( Gx_BScreen == 0 ) )
                     {
                        GXt_int1 = A2ProfesorId;
                        new ultimoidprofesor(context ).execute( out  GXt_int1) ;
                        A2ProfesorId = GXt_int1;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2ProfesorId", StringUtil.LTrim( StringUtil.Str( (decimal)(A2ProfesorId), 4, 0)));
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
                     sMode11 = Gx_mode;
                     Gx_mode = "UPD";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     if ( ! (0==AV7ProfesorId) )
                     {
                        A2ProfesorId = AV7ProfesorId;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2ProfesorId", StringUtil.LTrim( StringUtil.Str( (decimal)(A2ProfesorId), 4, 0)));
                     }
                     else
                     {
                        if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && (0==A2ProfesorId) && ( Gx_BScreen == 0 ) )
                        {
                           GXt_int1 = A2ProfesorId;
                           new ultimoidprofesor(context ).execute( out  GXt_int1) ;
                           A2ProfesorId = GXt_int1;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2ProfesorId", StringUtil.LTrim( StringUtil.Str( (decimal)(A2ProfesorId), 4, 0)));
                        }
                     }
                     Gx_mode = sMode11;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound11 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_020( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtn_enter_Internalname;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert", ""), 1, "PROFESORID");
                        AnyError = 1;
                        GX_FocusControl = edtProfesorId_Internalname;
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
                           E11022 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: After Trn */
                           E12022 ();
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
            E12022 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll0211( ) ;
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
            DisableAttributes0211( ) ;
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

      protected void CONFIRM_020( )
      {
         BeforeValidate0211( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0211( ) ;
            }
            else
            {
               CheckExtendedTable0211( ) ;
               CloseExtendedTableCursors0211( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         }
      }

      protected void ResetCaption020( )
      {
      }

      protected void E11022( )
      {
         /* Start Routine */
         if ( ! new isauthorized(context).executeUdp(  AV15Pgmname) )
         {
            CallWebObject(formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV15Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         AV9TrnContext.FromXml(AV10WebSession.Get("TrnContext"), null, "TransactionContext", "ObligatorioGenexusGit");
         AV11Insert_ActividadId = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11Insert_ActividadId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11Insert_ActividadId), 4, 0)));
         if ( ( StringUtil.StrCmp(AV9TrnContext.gxTpr_Transactionname, AV15Pgmname) == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) )
         {
            AV16GXV1 = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16GXV1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV16GXV1), 8, 0)));
            while ( AV16GXV1 <= AV9TrnContext.gxTpr_Attributes.Count )
            {
               AV12TrnContextAtt = ((SdtTransactionContext_Attribute)AV9TrnContext.gxTpr_Attributes.Item(AV16GXV1));
               if ( StringUtil.StrCmp(AV12TrnContextAtt.gxTpr_Attributename, "ActividadId") == 0 )
               {
                  AV11Insert_ActividadId = (short)(NumberUtil.Val( AV12TrnContextAtt.gxTpr_Attributevalue, "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11Insert_ActividadId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11Insert_ActividadId), 4, 0)));
               }
               AV16GXV1 = (int)(AV16GXV1+1);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16GXV1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV16GXV1), 8, 0)));
            }
         }
      }

      protected void E12022( )
      {
         /* After Trn Routine */
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV9TrnContext.gxTpr_Callerondelete )
         {
            CallWebObject(formatLink("wwprofesor.aspx") );
            context.wjLocDisableFrm = 1;
         }
         context.setWebReturnParms(new Object[] {});
         context.setWebReturnParmsMetadata(new Object[] {});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      protected void ZM0211( short GX_JID )
      {
         if ( ( GX_JID == 9 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z15ProfesorNombre = T00023_A15ProfesorNombre[0];
               Z16ProfesorDireccion = T00023_A16ProfesorDireccion[0];
               Z1ActividadId = T00023_A1ActividadId[0];
            }
            else
            {
               Z15ProfesorNombre = A15ProfesorNombre;
               Z16ProfesorDireccion = A16ProfesorDireccion;
               Z1ActividadId = A1ActividadId;
            }
         }
         if ( GX_JID == -9 )
         {
            Z2ProfesorId = A2ProfesorId;
            Z15ProfesorNombre = A15ProfesorNombre;
            Z16ProfesorDireccion = A16ProfesorDireccion;
            Z17ProfesorFoto = A17ProfesorFoto;
            Z40000ProfesorFoto_GXI = A40000ProfesorFoto_GXI;
            Z1ActividadId = A1ActividadId;
            Z13ActividadDescripcion = A13ActividadDescripcion;
         }
      }

      protected void standaloneNotModal( )
      {
         Gx_BScreen = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
         imgprompt_1_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0010.aspx"+"',["+"{Ctrl:gx.dom.el('"+"ACTIVIDADID"+"'), id:'"+"ACTIVIDADID"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"false"+");");
         bttBtn_delete_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Enabled), 5, 0)), true);
         if ( ! (0==AV7ProfesorId) )
         {
            edtProfesorId_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtProfesorId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtProfesorId_Enabled), 5, 0)), true);
         }
         else
         {
            edtProfesorId_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtProfesorId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtProfesorId_Enabled), 5, 0)), true);
         }
         if ( ! (0==AV7ProfesorId) )
         {
            edtProfesorId_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtProfesorId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtProfesorId_Enabled), 5, 0)), true);
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV11Insert_ActividadId) )
         {
            edtActividadId_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtActividadId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtActividadId_Enabled), 5, 0)), true);
         }
         else
         {
            edtActividadId_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtActividadId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtActividadId_Enabled), 5, 0)), true);
         }
      }

      protected void standaloneModal( )
      {
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV11Insert_ActividadId) )
         {
            A1ActividadId = AV11Insert_ActividadId;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1ActividadId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1ActividadId), 4, 0)));
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
         if ( ! (0==AV7ProfesorId) )
         {
            A2ProfesorId = AV7ProfesorId;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2ProfesorId", StringUtil.LTrim( StringUtil.Str( (decimal)(A2ProfesorId), 4, 0)));
         }
         else
         {
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && (0==A2ProfesorId) && ( Gx_BScreen == 0 ) )
            {
               GXt_int1 = A2ProfesorId;
               new ultimoidprofesor(context ).execute( out  GXt_int1) ;
               A2ProfesorId = GXt_int1;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2ProfesorId", StringUtil.LTrim( StringUtil.Str( (decimal)(A2ProfesorId), 4, 0)));
            }
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ( Gx_BScreen == 0 ) )
         {
            AV15Pgmname = "Profesor";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15Pgmname", AV15Pgmname);
            /* Using cursor T00024 */
            pr_default.execute(2, new Object[] {A1ActividadId});
            A13ActividadDescripcion = T00024_A13ActividadDescripcion[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13ActividadDescripcion", A13ActividadDescripcion);
            pr_default.close(2);
         }
      }

      protected void Load0211( )
      {
         /* Using cursor T00025 */
         pr_default.execute(3, new Object[] {A2ProfesorId});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound11 = 1;
            A15ProfesorNombre = T00025_A15ProfesorNombre[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A15ProfesorNombre", A15ProfesorNombre);
            A16ProfesorDireccion = T00025_A16ProfesorDireccion[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16ProfesorDireccion", A16ProfesorDireccion);
            A40000ProfesorFoto_GXI = T00025_A40000ProfesorFoto_GXI[0];
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgProfesorFoto_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A17ProfesorFoto)) ? A40000ProfesorFoto_GXI : context.convertURL( context.PathToRelativeUrl( A17ProfesorFoto))), true);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgProfesorFoto_Internalname, "SrcSet", context.GetImageSrcSet( A17ProfesorFoto), true);
            A13ActividadDescripcion = T00025_A13ActividadDescripcion[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13ActividadDescripcion", A13ActividadDescripcion);
            A1ActividadId = T00025_A1ActividadId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1ActividadId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1ActividadId), 4, 0)));
            A17ProfesorFoto = T00025_A17ProfesorFoto[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A17ProfesorFoto", A17ProfesorFoto);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgProfesorFoto_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A17ProfesorFoto)) ? A40000ProfesorFoto_GXI : context.convertURL( context.PathToRelativeUrl( A17ProfesorFoto))), true);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgProfesorFoto_Internalname, "SrcSet", context.GetImageSrcSet( A17ProfesorFoto), true);
            ZM0211( -9) ;
         }
         pr_default.close(3);
         OnLoadActions0211( ) ;
      }

      protected void OnLoadActions0211( )
      {
         AV15Pgmname = "Profesor";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15Pgmname", AV15Pgmname);
      }

      protected void CheckExtendedTable0211( )
      {
         Gx_BScreen = 1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
         standaloneModal( ) ;
         AV15Pgmname = "Profesor";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15Pgmname", AV15Pgmname);
         /* Using cursor T00024 */
         pr_default.execute(2, new Object[] {A1ActividadId});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("No matching 'Actividad'.", "ForeignKeyNotFound", 1, "ACTIVIDADID");
            AnyError = 1;
            GX_FocusControl = edtActividadId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A13ActividadDescripcion = T00024_A13ActividadDescripcion[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13ActividadDescripcion", A13ActividadDescripcion);
         pr_default.close(2);
      }

      protected void CloseExtendedTableCursors0211( )
      {
         pr_default.close(2);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_10( short A1ActividadId )
      {
         /* Using cursor T00026 */
         pr_default.execute(4, new Object[] {A1ActividadId});
         if ( (pr_default.getStatus(4) == 101) )
         {
            GX_msglist.addItem("No matching 'Actividad'.", "ForeignKeyNotFound", 1, "ACTIVIDADID");
            AnyError = 1;
            GX_FocusControl = edtActividadId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A13ActividadDescripcion = T00026_A13ActividadDescripcion[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13ActividadDescripcion", A13ActividadDescripcion);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A13ActividadDescripcion))+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(4) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(4);
      }

      protected void GetKey0211( )
      {
         /* Using cursor T00027 */
         pr_default.execute(5, new Object[] {A2ProfesorId});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound11 = 1;
         }
         else
         {
            RcdFound11 = 0;
         }
         pr_default.close(5);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00023 */
         pr_default.execute(1, new Object[] {A2ProfesorId});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0211( 9) ;
            RcdFound11 = 1;
            A2ProfesorId = T00023_A2ProfesorId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2ProfesorId", StringUtil.LTrim( StringUtil.Str( (decimal)(A2ProfesorId), 4, 0)));
            A15ProfesorNombre = T00023_A15ProfesorNombre[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A15ProfesorNombre", A15ProfesorNombre);
            A16ProfesorDireccion = T00023_A16ProfesorDireccion[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16ProfesorDireccion", A16ProfesorDireccion);
            A40000ProfesorFoto_GXI = T00023_A40000ProfesorFoto_GXI[0];
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgProfesorFoto_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A17ProfesorFoto)) ? A40000ProfesorFoto_GXI : context.convertURL( context.PathToRelativeUrl( A17ProfesorFoto))), true);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgProfesorFoto_Internalname, "SrcSet", context.GetImageSrcSet( A17ProfesorFoto), true);
            A1ActividadId = T00023_A1ActividadId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1ActividadId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1ActividadId), 4, 0)));
            A17ProfesorFoto = T00023_A17ProfesorFoto[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A17ProfesorFoto", A17ProfesorFoto);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgProfesorFoto_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A17ProfesorFoto)) ? A40000ProfesorFoto_GXI : context.convertURL( context.PathToRelativeUrl( A17ProfesorFoto))), true);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgProfesorFoto_Internalname, "SrcSet", context.GetImageSrcSet( A17ProfesorFoto), true);
            Z2ProfesorId = A2ProfesorId;
            sMode11 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load0211( ) ;
            if ( AnyError == 1 )
            {
               RcdFound11 = 0;
               InitializeNonKey0211( ) ;
            }
            Gx_mode = sMode11;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound11 = 0;
            InitializeNonKey0211( ) ;
            sMode11 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal( ) ;
            Gx_mode = sMode11;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0211( ) ;
         if ( RcdFound11 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound11 = 0;
         /* Using cursor T00028 */
         pr_default.execute(6, new Object[] {A2ProfesorId});
         if ( (pr_default.getStatus(6) != 101) )
         {
            while ( (pr_default.getStatus(6) != 101) && ( ( T00028_A2ProfesorId[0] < A2ProfesorId ) ) )
            {
               pr_default.readNext(6);
            }
            if ( (pr_default.getStatus(6) != 101) && ( ( T00028_A2ProfesorId[0] > A2ProfesorId ) ) )
            {
               A2ProfesorId = T00028_A2ProfesorId[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2ProfesorId", StringUtil.LTrim( StringUtil.Str( (decimal)(A2ProfesorId), 4, 0)));
               RcdFound11 = 1;
            }
         }
         pr_default.close(6);
      }

      protected void move_previous( )
      {
         RcdFound11 = 0;
         /* Using cursor T00029 */
         pr_default.execute(7, new Object[] {A2ProfesorId});
         if ( (pr_default.getStatus(7) != 101) )
         {
            while ( (pr_default.getStatus(7) != 101) && ( ( T00029_A2ProfesorId[0] > A2ProfesorId ) ) )
            {
               pr_default.readNext(7);
            }
            if ( (pr_default.getStatus(7) != 101) && ( ( T00029_A2ProfesorId[0] < A2ProfesorId ) ) )
            {
               A2ProfesorId = T00029_A2ProfesorId[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2ProfesorId", StringUtil.LTrim( StringUtil.Str( (decimal)(A2ProfesorId), 4, 0)));
               RcdFound11 = 1;
            }
         }
         pr_default.close(7);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey0211( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtProfesorId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert0211( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound11 == 1 )
            {
               if ( A2ProfesorId != Z2ProfesorId )
               {
                  A2ProfesorId = Z2ProfesorId;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2ProfesorId", StringUtil.LTrim( StringUtil.Str( (decimal)(A2ProfesorId), 4, 0)));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "PROFESORID");
                  AnyError = 1;
                  GX_FocusControl = edtProfesorId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtProfesorId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Update record */
                  Update0211( ) ;
                  GX_FocusControl = edtProfesorId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A2ProfesorId != Z2ProfesorId )
               {
                  /* Insert record */
                  GX_FocusControl = edtProfesorId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert0211( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "PROFESORID");
                     AnyError = 1;
                     GX_FocusControl = edtProfesorId_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     /* Insert record */
                     GX_FocusControl = edtProfesorId_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert0211( ) ;
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
         if ( A2ProfesorId != Z2ProfesorId )
         {
            A2ProfesorId = Z2ProfesorId;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2ProfesorId", StringUtil.LTrim( StringUtil.Str( (decimal)(A2ProfesorId), 4, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "PROFESORID");
            AnyError = 1;
            GX_FocusControl = edtProfesorId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtProfesorId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency0211( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00022 */
            pr_default.execute(0, new Object[] {A2ProfesorId});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Profesor"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z15ProfesorNombre, T00022_A15ProfesorNombre[0]) != 0 ) || ( StringUtil.StrCmp(Z16ProfesorDireccion, T00022_A16ProfesorDireccion[0]) != 0 ) || ( Z1ActividadId != T00022_A1ActividadId[0] ) )
            {
               if ( StringUtil.StrCmp(Z15ProfesorNombre, T00022_A15ProfesorNombre[0]) != 0 )
               {
                  GXUtil.WriteLog("profesor:[seudo value changed for attri]"+"ProfesorNombre");
                  GXUtil.WriteLogRaw("Old: ",Z15ProfesorNombre);
                  GXUtil.WriteLogRaw("Current: ",T00022_A15ProfesorNombre[0]);
               }
               if ( StringUtil.StrCmp(Z16ProfesorDireccion, T00022_A16ProfesorDireccion[0]) != 0 )
               {
                  GXUtil.WriteLog("profesor:[seudo value changed for attri]"+"ProfesorDireccion");
                  GXUtil.WriteLogRaw("Old: ",Z16ProfesorDireccion);
                  GXUtil.WriteLogRaw("Current: ",T00022_A16ProfesorDireccion[0]);
               }
               if ( Z1ActividadId != T00022_A1ActividadId[0] )
               {
                  GXUtil.WriteLog("profesor:[seudo value changed for attri]"+"ActividadId");
                  GXUtil.WriteLogRaw("Old: ",Z1ActividadId);
                  GXUtil.WriteLogRaw("Current: ",T00022_A1ActividadId[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Profesor"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0211( )
      {
         BeforeValidate0211( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0211( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0211( 0) ;
            CheckOptimisticConcurrency0211( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0211( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0211( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000210 */
                     pr_default.execute(8, new Object[] {A2ProfesorId, A15ProfesorNombre, A16ProfesorDireccion, A17ProfesorFoto, A40000ProfesorFoto_GXI, A1ActividadId});
                     pr_default.close(8);
                     dsDefault.SmartCacheProvider.SetUpdated("Profesor") ;
                     if ( (pr_default.getStatus(8) == 1) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
                        AnyError = 1;
                     }
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
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
               Load0211( ) ;
            }
            EndLevel0211( ) ;
         }
         CloseExtendedTableCursors0211( ) ;
      }

      protected void Update0211( )
      {
         BeforeValidate0211( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0211( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0211( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0211( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0211( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000211 */
                     pr_default.execute(9, new Object[] {A15ProfesorNombre, A16ProfesorDireccion, A1ActividadId, A2ProfesorId});
                     pr_default.close(9);
                     dsDefault.SmartCacheProvider.SetUpdated("Profesor") ;
                     if ( (pr_default.getStatus(9) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Profesor"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0211( ) ;
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
            EndLevel0211( ) ;
         }
         CloseExtendedTableCursors0211( ) ;
      }

      protected void DeferredUpdate0211( )
      {
         if ( AnyError == 0 )
         {
            /* Using cursor T000212 */
            pr_default.execute(10, new Object[] {A17ProfesorFoto, A40000ProfesorFoto_GXI, A2ProfesorId});
            pr_default.close(10);
            dsDefault.SmartCacheProvider.SetUpdated("Profesor") ;
         }
      }

      protected void delete( )
      {
         BeforeValidate0211( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0211( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0211( ) ;
            AfterConfirm0211( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0211( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000213 */
                  pr_default.execute(11, new Object[] {A2ProfesorId});
                  pr_default.close(11);
                  dsDefault.SmartCacheProvider.SetUpdated("Profesor") ;
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
         sMode11 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel0211( ) ;
         Gx_mode = sMode11;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls0211( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV15Pgmname = "Profesor";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15Pgmname", AV15Pgmname);
            /* Using cursor T000214 */
            pr_default.execute(12, new Object[] {A1ActividadId});
            A13ActividadDescripcion = T000214_A13ActividadDescripcion[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13ActividadDescripcion", A13ActividadDescripcion);
            pr_default.close(12);
         }
         if ( AnyError == 0 )
         {
            /* Using cursor T000215 */
            pr_default.execute(13, new Object[] {A2ProfesorId});
            if ( (pr_default.getStatus(13) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Clase"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(13);
         }
      }

      protected void EndLevel0211( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0211( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(1);
            pr_default.close(12);
            context.CommitDataStores("profesor",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues020( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(1);
            pr_default.close(12);
            context.RollbackDataStores("profesor",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart0211( )
      {
         /* Scan By routine */
         /* Using cursor T000216 */
         pr_default.execute(14);
         RcdFound11 = 0;
         if ( (pr_default.getStatus(14) != 101) )
         {
            RcdFound11 = 1;
            A2ProfesorId = T000216_A2ProfesorId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2ProfesorId", StringUtil.LTrim( StringUtil.Str( (decimal)(A2ProfesorId), 4, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0211( )
      {
         /* Scan next routine */
         pr_default.readNext(14);
         RcdFound11 = 0;
         if ( (pr_default.getStatus(14) != 101) )
         {
            RcdFound11 = 1;
            A2ProfesorId = T000216_A2ProfesorId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2ProfesorId", StringUtil.LTrim( StringUtil.Str( (decimal)(A2ProfesorId), 4, 0)));
         }
      }

      protected void ScanEnd0211( )
      {
         pr_default.close(14);
      }

      protected void AfterConfirm0211( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0211( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0211( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0211( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0211( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0211( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0211( )
      {
         edtProfesorId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtProfesorId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtProfesorId_Enabled), 5, 0)), true);
         edtProfesorNombre_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtProfesorNombre_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtProfesorNombre_Enabled), 5, 0)), true);
         edtProfesorDireccion_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtProfesorDireccion_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtProfesorDireccion_Enabled), 5, 0)), true);
         imgProfesorFoto_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgProfesorFoto_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(imgProfesorFoto_Enabled), 5, 0)), true);
         edtActividadId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtActividadId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtActividadId_Enabled), 5, 0)), true);
         edtActividadDescripcion_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtActividadDescripcion_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtActividadDescripcion_Enabled), 5, 0)), true);
      }

      protected void send_integrity_lvl_hashes0211( )
      {
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues020( )
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
         context.AddJavascriptSource("gxcfg.js", "?20194122114294", false);
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
         bodyStyle = bodyStyle + "-moz-opacity:0;opacity:0;";
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( Form.Background)) ) )
         {
            bodyStyle = bodyStyle + " background-image:url(" + context.convertURL( Form.Background) + ")";
         }
         context.WriteHtmlText( " "+"class=\"form-horizontal Form\""+" "+ "style='"+bodyStyle+"'") ;
         context.WriteHtmlText( FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("profesor.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7ProfesorId)+"\">") ;
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
         forbiddenHiddens = "hsh" + "Profesor";
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV11Insert_ActividadId), "ZZZ9");
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("profesor:[SendSecurityCheck value for]"+"Insert_ActividadId:"+context.localUtil.Format( (decimal)(AV11Insert_ActividadId), "ZZZ9"));
         GXUtil.WriteLog("profesor:[SendSecurityCheck value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z2ProfesorId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z2ProfesorId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z15ProfesorNombre", StringUtil.RTrim( Z15ProfesorNombre));
         GxWebStd.gx_hidden_field( context, "Z16ProfesorDireccion", Z16ProfesorDireccion);
         GxWebStd.gx_hidden_field( context, "Z1ActividadId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z1ActividadId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_Mode", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GxWebStd.gx_hidden_field( context, "N1ActividadId", StringUtil.LTrim( StringUtil.NToC( (decimal)(A1ActividadId), 4, 0, ".", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vTRNCONTEXT", AV9TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vTRNCONTEXT", AV9TrnContext);
         }
         GxWebStd.gx_hidden_field( context, "vPROFESORID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7ProfesorId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vPROFESORID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7ProfesorId), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vGXBSCREEN", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gx_BScreen), 1, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vINSERT_ACTIVIDADID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11Insert_ActividadId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "PROFESORFOTO_GXI", A40000ProfesorFoto_GXI);
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV15Pgmname));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GXCCtlgxBlob = "PROFESORFOTO" + "_gxBlob";
         GxWebStd.gx_hidden_field( context, GXCCtlgxBlob, A17ProfesorFoto);
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
         return formatLink("profesor.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7ProfesorId) ;
      }

      public override String GetPgmname( )
      {
         return "Profesor" ;
      }

      public override String GetPgmdesc( )
      {
         return "Profesor" ;
      }

      protected void InitializeNonKey0211( )
      {
         A1ActividadId = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1ActividadId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1ActividadId), 4, 0)));
         A15ProfesorNombre = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A15ProfesorNombre", A15ProfesorNombre);
         A16ProfesorDireccion = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16ProfesorDireccion", A16ProfesorDireccion);
         A17ProfesorFoto = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A17ProfesorFoto", A17ProfesorFoto);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgProfesorFoto_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A17ProfesorFoto)) ? A40000ProfesorFoto_GXI : context.convertURL( context.PathToRelativeUrl( A17ProfesorFoto))), true);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgProfesorFoto_Internalname, "SrcSet", context.GetImageSrcSet( A17ProfesorFoto), true);
         A40000ProfesorFoto_GXI = "";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgProfesorFoto_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A17ProfesorFoto)) ? A40000ProfesorFoto_GXI : context.convertURL( context.PathToRelativeUrl( A17ProfesorFoto))), true);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgProfesorFoto_Internalname, "SrcSet", context.GetImageSrcSet( A17ProfesorFoto), true);
         A13ActividadDescripcion = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13ActividadDescripcion", A13ActividadDescripcion);
         Z15ProfesorNombre = "";
         Z16ProfesorDireccion = "";
         Z1ActividadId = 0;
      }

      protected void InitAll0211( )
      {
         A2ProfesorId = new ultimoidprofesor(context).executeUdp( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2ProfesorId", StringUtil.LTrim( StringUtil.Str( (decimal)(A2ProfesorId), 4, 0)));
         InitializeNonKey0211( ) ;
      }

      protected void StandaloneModalInsert( )
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2019412211431", true);
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
         context.AddJavascriptSource("profesor.js", "?2019412211431", false);
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
         edtProfesorId_Internalname = "PROFESORID";
         edtProfesorNombre_Internalname = "PROFESORNOMBRE";
         edtProfesorDireccion_Internalname = "PROFESORDIRECCION";
         imgProfesorFoto_Internalname = "PROFESORFOTO";
         edtActividadId_Internalname = "ACTIVIDADID";
         edtActividadDescripcion_Internalname = "ACTIVIDADDESCRIPCION";
         divFormcontainer_Internalname = "FORMCONTAINER";
         bttBtn_enter_Internalname = "BTN_ENTER";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         bttBtn_delete_Internalname = "BTN_DELETE";
         divMaintable_Internalname = "MAINTABLE";
         Form.Internalname = "FORM";
         imgprompt_1_Internalname = "PROMPT_1";
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
         Form.Caption = "Profesor";
         bttBtn_delete_Enabled = 0;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edtActividadDescripcion_Jsonclick = "";
         edtActividadDescripcion_Enabled = 0;
         imgprompt_1_Visible = 1;
         imgprompt_1_Link = "";
         edtActividadId_Jsonclick = "";
         edtActividadId_Enabled = 1;
         imgProfesorFoto_Enabled = 1;
         edtProfesorDireccion_Enabled = 1;
         edtProfesorNombre_Jsonclick = "";
         edtProfesorNombre_Enabled = 1;
         edtProfesorId_Jsonclick = "";
         edtProfesorId_Enabled = 1;
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

      protected void GX3ASAPROFESORID0211( short AV7ProfesorId ,
                                           short Gx_BScreen )
      {
         if ( ! (0==AV7ProfesorId) )
         {
            A2ProfesorId = AV7ProfesorId;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2ProfesorId", StringUtil.LTrim( StringUtil.Str( (decimal)(A2ProfesorId), 4, 0)));
         }
         else
         {
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && (0==A2ProfesorId) && ( Gx_BScreen == 0 ) )
            {
               GXt_int1 = A2ProfesorId;
               new ultimoidprofesor(context ).execute( out  GXt_int1) ;
               A2ProfesorId = GXt_int1;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2ProfesorId", StringUtil.LTrim( StringUtil.Str( (decimal)(A2ProfesorId), 4, 0)));
            }
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A2ProfesorId), 4, 0, ".", "")))+"\"");
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
         /* End function init_web_controls */
      }

      public void Valid_Actividadid( short GX_Parm1 ,
                                     String GX_Parm2 )
      {
         A1ActividadId = GX_Parm1;
         A13ActividadDescripcion = GX_Parm2;
         /* Using cursor T000214 */
         pr_default.execute(12, new Object[] {A1ActividadId});
         if ( (pr_default.getStatus(12) == 101) )
         {
            GX_msglist.addItem("No matching 'Actividad'.", "ForeignKeyNotFound", 1, "ACTIVIDADID");
            AnyError = 1;
            GX_FocusControl = edtActividadId_Internalname;
         }
         A13ActividadDescripcion = T000214_A13ActividadDescripcion[0];
         pr_default.close(12);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A13ActividadDescripcion = "";
         }
         isValidOutput.Add(StringUtil.RTrim( A13ActividadDescripcion));
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
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7ProfesorId',fld:'vPROFESORID',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7ProfesorId',fld:'vPROFESORID',pic:'ZZZ9',hsh:true},{av:'AV11Insert_ActividadId',fld:'vINSERT_ACTIVIDADID',pic:'ZZZ9'}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("AFTER TRN","{handler:'E12022',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV9TrnContext',fld:'vTRNCONTEXT',pic:''}]");
         setEventMetadata("AFTER TRN",",oparms:[]}");
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
         Z15ProfesorNombre = "";
         Z16ProfesorDireccion = "";
         scmdbuf = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         GXKey = "";
         PreviousTooltip = "";
         PreviousCaption = "";
         Form = new GXWebForm();
         GX_FocusControl = "";
         lblTitle_Jsonclick = "";
         ClassString = "";
         StyleString = "";
         TempTags = "";
         bttBtn_first_Jsonclick = "";
         bttBtn_previous_Jsonclick = "";
         bttBtn_next_Jsonclick = "";
         bttBtn_last_Jsonclick = "";
         bttBtn_select_Jsonclick = "";
         A15ProfesorNombre = "";
         A16ProfesorDireccion = "";
         A17ProfesorFoto = "";
         A40000ProfesorFoto_GXI = "";
         sImgUrl = "";
         A13ActividadDescripcion = "";
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         AV15Pgmname = "";
         forbiddenHiddens = "";
         hsh = "";
         sMode11 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV9TrnContext = new SdtTransactionContext(context);
         AV10WebSession = context.GetSession();
         AV12TrnContextAtt = new SdtTransactionContext_Attribute(context);
         Z17ProfesorFoto = "";
         Z40000ProfesorFoto_GXI = "";
         Z13ActividadDescripcion = "";
         T00024_A13ActividadDescripcion = new String[] {""} ;
         T00025_A2ProfesorId = new short[1] ;
         T00025_A15ProfesorNombre = new String[] {""} ;
         T00025_A16ProfesorDireccion = new String[] {""} ;
         T00025_A40000ProfesorFoto_GXI = new String[] {""} ;
         T00025_A13ActividadDescripcion = new String[] {""} ;
         T00025_A1ActividadId = new short[1] ;
         T00025_A17ProfesorFoto = new String[] {""} ;
         T00026_A13ActividadDescripcion = new String[] {""} ;
         T00027_A2ProfesorId = new short[1] ;
         T00023_A2ProfesorId = new short[1] ;
         T00023_A15ProfesorNombre = new String[] {""} ;
         T00023_A16ProfesorDireccion = new String[] {""} ;
         T00023_A40000ProfesorFoto_GXI = new String[] {""} ;
         T00023_A1ActividadId = new short[1] ;
         T00023_A17ProfesorFoto = new String[] {""} ;
         T00028_A2ProfesorId = new short[1] ;
         T00029_A2ProfesorId = new short[1] ;
         T00022_A2ProfesorId = new short[1] ;
         T00022_A15ProfesorNombre = new String[] {""} ;
         T00022_A16ProfesorDireccion = new String[] {""} ;
         T00022_A40000ProfesorFoto_GXI = new String[] {""} ;
         T00022_A1ActividadId = new short[1] ;
         T00022_A17ProfesorFoto = new String[] {""} ;
         T000214_A13ActividadDescripcion = new String[] {""} ;
         T000215_A3ClaseId = new short[1] ;
         T000216_A2ProfesorId = new short[1] ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GXCCtlgxBlob = "";
         isValidOutput = new GxUnknownObjectCollection();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.profesor__default(),
            new Object[][] {
                new Object[] {
               T00022_A2ProfesorId, T00022_A15ProfesorNombre, T00022_A16ProfesorDireccion, T00022_A40000ProfesorFoto_GXI, T00022_A1ActividadId, T00022_A17ProfesorFoto
               }
               , new Object[] {
               T00023_A2ProfesorId, T00023_A15ProfesorNombre, T00023_A16ProfesorDireccion, T00023_A40000ProfesorFoto_GXI, T00023_A1ActividadId, T00023_A17ProfesorFoto
               }
               , new Object[] {
               T00024_A13ActividadDescripcion
               }
               , new Object[] {
               T00025_A2ProfesorId, T00025_A15ProfesorNombre, T00025_A16ProfesorDireccion, T00025_A40000ProfesorFoto_GXI, T00025_A13ActividadDescripcion, T00025_A1ActividadId, T00025_A17ProfesorFoto
               }
               , new Object[] {
               T00026_A13ActividadDescripcion
               }
               , new Object[] {
               T00027_A2ProfesorId
               }
               , new Object[] {
               T00028_A2ProfesorId
               }
               , new Object[] {
               T00029_A2ProfesorId
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
               T000214_A13ActividadDescripcion
               }
               , new Object[] {
               T000215_A3ClaseId
               }
               , new Object[] {
               T000216_A2ProfesorId
               }
            }
         );
         AV15Pgmname = "Profesor";
         Z2ProfesorId = new ultimoidprofesor(context).executeUdp( );
         A2ProfesorId = new ultimoidprofesor(context).executeUdp( );
      }

      private short wcpOAV7ProfesorId ;
      private short Z2ProfesorId ;
      private short Z1ActividadId ;
      private short N1ActividadId ;
      private short GxWebError ;
      private short AV7ProfesorId ;
      private short Gx_BScreen ;
      private short A1ActividadId ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short A2ProfesorId ;
      private short AV11Insert_ActividadId ;
      private short RcdFound11 ;
      private short GX_JID ;
      private short gxajaxcallmode ;
      private short GXt_int1 ;
      private short wbTemp ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int edtProfesorId_Enabled ;
      private int edtProfesorNombre_Enabled ;
      private int edtProfesorDireccion_Enabled ;
      private int imgProfesorFoto_Enabled ;
      private int edtActividadId_Enabled ;
      private int imgprompt_1_Visible ;
      private int edtActividadDescripcion_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int AV16GXV1 ;
      private int idxLst ;
      private String sPrefix ;
      private String wcpOGx_mode ;
      private String Z15ProfesorNombre ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String Gx_mode ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtProfesorId_Internalname ;
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
      private String edtProfesorId_Jsonclick ;
      private String edtProfesorNombre_Internalname ;
      private String A15ProfesorNombre ;
      private String edtProfesorNombre_Jsonclick ;
      private String edtProfesorDireccion_Internalname ;
      private String imgProfesorFoto_Internalname ;
      private String sImgUrl ;
      private String edtActividadId_Internalname ;
      private String edtActividadId_Jsonclick ;
      private String imgprompt_1_Internalname ;
      private String imgprompt_1_Link ;
      private String edtActividadDescripcion_Internalname ;
      private String A13ActividadDescripcion ;
      private String edtActividadDescripcion_Jsonclick ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String AV15Pgmname ;
      private String forbiddenHiddens ;
      private String hsh ;
      private String sMode11 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String Z13ActividadDescripcion ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GXCCtlgxBlob ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool A17ProfesorFoto_IsBlob ;
      private bool returnInSub ;
      private String Z16ProfesorDireccion ;
      private String A16ProfesorDireccion ;
      private String A40000ProfesorFoto_GXI ;
      private String Z40000ProfesorFoto_GXI ;
      private String A17ProfesorFoto ;
      private String Z17ProfesorFoto ;
      private IGxSession AV10WebSession ;
      private GxUnknownObjectCollection isValidOutput ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] T00024_A13ActividadDescripcion ;
      private short[] T00025_A2ProfesorId ;
      private String[] T00025_A15ProfesorNombre ;
      private String[] T00025_A16ProfesorDireccion ;
      private String[] T00025_A40000ProfesorFoto_GXI ;
      private String[] T00025_A13ActividadDescripcion ;
      private short[] T00025_A1ActividadId ;
      private String[] T00025_A17ProfesorFoto ;
      private String[] T00026_A13ActividadDescripcion ;
      private short[] T00027_A2ProfesorId ;
      private short[] T00023_A2ProfesorId ;
      private String[] T00023_A15ProfesorNombre ;
      private String[] T00023_A16ProfesorDireccion ;
      private String[] T00023_A40000ProfesorFoto_GXI ;
      private short[] T00023_A1ActividadId ;
      private String[] T00023_A17ProfesorFoto ;
      private short[] T00028_A2ProfesorId ;
      private short[] T00029_A2ProfesorId ;
      private short[] T00022_A2ProfesorId ;
      private String[] T00022_A15ProfesorNombre ;
      private String[] T00022_A16ProfesorDireccion ;
      private String[] T00022_A40000ProfesorFoto_GXI ;
      private short[] T00022_A1ActividadId ;
      private String[] T00022_A17ProfesorFoto ;
      private String[] T000214_A13ActividadDescripcion ;
      private short[] T000215_A3ClaseId ;
      private short[] T000216_A2ProfesorId ;
      private GXWebForm Form ;
      private SdtTransactionContext AV9TrnContext ;
      private SdtTransactionContext_Attribute AV12TrnContextAtt ;
   }

   public class profesor__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmT00025 ;
          prmT00025 = new Object[] {
          new Object[] {"@ProfesorId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00024 ;
          prmT00024 = new Object[] {
          new Object[] {"@ActividadId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00026 ;
          prmT00026 = new Object[] {
          new Object[] {"@ActividadId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00027 ;
          prmT00027 = new Object[] {
          new Object[] {"@ProfesorId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00023 ;
          prmT00023 = new Object[] {
          new Object[] {"@ProfesorId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00028 ;
          prmT00028 = new Object[] {
          new Object[] {"@ProfesorId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00029 ;
          prmT00029 = new Object[] {
          new Object[] {"@ProfesorId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00022 ;
          prmT00022 = new Object[] {
          new Object[] {"@ProfesorId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000210 ;
          prmT000210 = new Object[] {
          new Object[] {"@ProfesorId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ProfesorNombre",SqlDbType.Char,20,0} ,
          new Object[] {"@ProfesorDireccion",SqlDbType.VarChar,1024,0} ,
          new Object[] {"@ProfesorFoto",SqlDbType.VarBinary,1024,0} ,
          new Object[] {"@ProfesorFoto_GXI",SqlDbType.VarChar,2048,0} ,
          new Object[] {"@ActividadId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000211 ;
          prmT000211 = new Object[] {
          new Object[] {"@ProfesorNombre",SqlDbType.Char,20,0} ,
          new Object[] {"@ProfesorDireccion",SqlDbType.VarChar,1024,0} ,
          new Object[] {"@ActividadId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ProfesorId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000212 ;
          prmT000212 = new Object[] {
          new Object[] {"@ProfesorFoto",SqlDbType.VarBinary,1024,0} ,
          new Object[] {"@ProfesorFoto_GXI",SqlDbType.VarChar,2048,0} ,
          new Object[] {"@ProfesorId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000213 ;
          prmT000213 = new Object[] {
          new Object[] {"@ProfesorId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000215 ;
          prmT000215 = new Object[] {
          new Object[] {"@ProfesorId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000216 ;
          prmT000216 = new Object[] {
          } ;
          Object[] prmT000214 ;
          prmT000214 = new Object[] {
          new Object[] {"@ActividadId",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T00022", "SELECT [ProfesorId], [ProfesorNombre], [ProfesorDireccion], [ProfesorFoto_GXI], [ActividadId], [ProfesorFoto] FROM [Profesor] WITH (UPDLOCK) WHERE [ProfesorId] = @ProfesorId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00022,1,0,true,false )
             ,new CursorDef("T00023", "SELECT [ProfesorId], [ProfesorNombre], [ProfesorDireccion], [ProfesorFoto_GXI], [ActividadId], [ProfesorFoto] FROM [Profesor] WITH (NOLOCK) WHERE [ProfesorId] = @ProfesorId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00023,1,0,true,false )
             ,new CursorDef("T00024", "SELECT [ActividadDescripcion] FROM [Actividad1] WITH (NOLOCK) WHERE [ActividadId] = @ActividadId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00024,1,0,true,false )
             ,new CursorDef("T00025", "SELECT TM1.[ProfesorId], TM1.[ProfesorNombre], TM1.[ProfesorDireccion], TM1.[ProfesorFoto_GXI], T2.[ActividadDescripcion], TM1.[ActividadId], TM1.[ProfesorFoto] FROM ([Profesor] TM1 WITH (NOLOCK) INNER JOIN [Actividad1] T2 WITH (NOLOCK) ON T2.[ActividadId] = TM1.[ActividadId]) WHERE TM1.[ProfesorId] = @ProfesorId ORDER BY TM1.[ProfesorId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00025,100,0,true,false )
             ,new CursorDef("T00026", "SELECT [ActividadDescripcion] FROM [Actividad1] WITH (NOLOCK) WHERE [ActividadId] = @ActividadId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00026,1,0,true,false )
             ,new CursorDef("T00027", "SELECT [ProfesorId] FROM [Profesor] WITH (NOLOCK) WHERE [ProfesorId] = @ProfesorId  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00027,1,0,true,false )
             ,new CursorDef("T00028", "SELECT TOP 1 [ProfesorId] FROM [Profesor] WITH (NOLOCK) WHERE ( [ProfesorId] > @ProfesorId) ORDER BY [ProfesorId]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00028,1,0,true,true )
             ,new CursorDef("T00029", "SELECT TOP 1 [ProfesorId] FROM [Profesor] WITH (NOLOCK) WHERE ( [ProfesorId] < @ProfesorId) ORDER BY [ProfesorId] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00029,1,0,true,true )
             ,new CursorDef("T000210", "INSERT INTO [Profesor]([ProfesorId], [ProfesorNombre], [ProfesorDireccion], [ProfesorFoto], [ProfesorFoto_GXI], [ActividadId]) VALUES(@ProfesorId, @ProfesorNombre, @ProfesorDireccion, @ProfesorFoto, @ProfesorFoto_GXI, @ActividadId)", GxErrorMask.GX_NOMASK,prmT000210)
             ,new CursorDef("T000211", "UPDATE [Profesor] SET [ProfesorNombre]=@ProfesorNombre, [ProfesorDireccion]=@ProfesorDireccion, [ActividadId]=@ActividadId  WHERE [ProfesorId] = @ProfesorId", GxErrorMask.GX_NOMASK,prmT000211)
             ,new CursorDef("T000212", "UPDATE [Profesor] SET [ProfesorFoto]=@ProfesorFoto, [ProfesorFoto_GXI]=@ProfesorFoto_GXI  WHERE [ProfesorId] = @ProfesorId", GxErrorMask.GX_NOMASK,prmT000212)
             ,new CursorDef("T000213", "DELETE FROM [Profesor]  WHERE [ProfesorId] = @ProfesorId", GxErrorMask.GX_NOMASK,prmT000213)
             ,new CursorDef("T000214", "SELECT [ActividadDescripcion] FROM [Actividad1] WITH (NOLOCK) WHERE [ActividadId] = @ActividadId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000214,1,0,true,false )
             ,new CursorDef("T000215", "SELECT TOP 1 [ClaseId] FROM [Clase] WITH (NOLOCK) WHERE [ProfesorId] = @ProfesorId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000215,1,0,true,true )
             ,new CursorDef("T000216", "SELECT [ProfesorId] FROM [Profesor] WITH (NOLOCK) ORDER BY [ProfesorId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000216,100,0,true,false )
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
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getMultimediaUri(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((String[]) buf[5])[0] = rslt.getMultimediaFile(6, rslt.getVarchar(4)) ;
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 20) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getMultimediaUri(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((String[]) buf[5])[0] = rslt.getMultimediaFile(6, rslt.getVarchar(4)) ;
                return;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getString(1, 20) ;
                return;
             case 3 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 20) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getMultimediaUri(4) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 20) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((String[]) buf[6])[0] = rslt.getMultimediaFile(7, rslt.getVarchar(4)) ;
                return;
             case 4 :
                ((String[]) buf[0])[0] = rslt.getString(1, 20) ;
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
                ((String[]) buf[0])[0] = rslt.getString(1, 20) ;
                return;
             case 13 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
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
                stmt.SetParameterBlob(4, (String)parms[3], false);
                stmt.SetParameterMultimedia(5, (String)parms[4], (String)parms[3], "Profesor", "ProfesorFoto");
                stmt.SetParameter(6, (short)parms[5]);
                return;
             case 9 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                return;
             case 10 :
                stmt.SetParameterBlob(1, (String)parms[0], false);
                stmt.SetParameterMultimedia(2, (String)parms[1], (String)parms[0], "Profesor", "ProfesorFoto");
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
