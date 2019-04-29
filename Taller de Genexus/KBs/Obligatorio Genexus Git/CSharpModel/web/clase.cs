/*
               File: Clase
        Description: Clase
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 4/12/2019 21:1:36.63
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
   public class clase : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel3"+"_"+"CLASEID") == 0 )
         {
            AV15ClaseId = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15ClaseId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15ClaseId), 4, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vCLASEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV15ClaseId), "ZZZ9"), context));
            Gx_BScreen = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX3ASACLASEID0412( AV15ClaseId, Gx_BScreen) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_10") == 0 )
         {
            A2ProfesorId = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2ProfesorId", StringUtil.LTrim( StringUtil.Str( (decimal)(A2ProfesorId), 4, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_10( A2ProfesorId) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_11") == 0 )
         {
            A1ActividadId = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1ActividadId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1ActividadId), 4, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_11( A1ActividadId) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_13") == 0 )
         {
            A5SocioId = (short)(NumberUtil.Val( GetNextPar( ), "."));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_13( A5SocioId) ;
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Gridclase_socios") == 0 )
         {
            nRC_GXsfl_63 = (short)(NumberUtil.Val( GetNextPar( ), "."));
            nGXsfl_63_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
            sGXsfl_63_idx = GetNextPar( );
            Gx_mode = GetNextPar( );
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxnrGridclase_socios_newrow( ) ;
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
            Gx_mode = gxfirstwebparm;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
            {
               AV15ClaseId = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15ClaseId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15ClaseId), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vCLASEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV15ClaseId), "ZZZ9"), context));
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
            Form.Meta.addItem("description", "Clase", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtClaseId_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("Carmine");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public clase( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public clase( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( String aP0_Gx_mode ,
                           short aP1_ClaseId )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV15ClaseId = aP1_ClaseId;
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
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "Clase", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_Clase.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "", bttBtn_first_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_first_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Clase.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "", bttBtn_previous_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_previous_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_Clase.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", "", bttBtn_next_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_next_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_Clase.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", "", bttBtn_last_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_last_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Clase.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Select", bttBtn_select_Jsonclick, 5, "Select", "", StyleString, ClassString, bttBtn_select_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "", 2, "HLP_Clase.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtClaseId_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtClaseId_Internalname, "Id", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtClaseId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A3ClaseId), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A3ClaseId), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,34);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtClaseId_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtClaseId_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Clase.htm");
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
            GxWebStd.gx_single_line_edit( context, edtActividadId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A1ActividadId), 4, 0, ".", "")), ((edtActividadId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A1ActividadId), "ZZZ9")) : context.localUtil.Format( (decimal)(A1ActividadId), "ZZZ9")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtActividadId_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtActividadId_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Clase.htm");
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
            GxWebStd.gx_single_line_edit( context, edtActividadDescripcion_Internalname, StringUtil.RTrim( A13ActividadDescripcion), StringUtil.RTrim( context.localUtil.Format( A13ActividadDescripcion, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtActividadDescripcion_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtActividadDescripcion_Enabled, 0, "text", "", 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Clase.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtProfesorId_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtProfesorId_Internalname, "Profesor Id", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 49,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtProfesorId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A2ProfesorId), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A2ProfesorId), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,49);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtProfesorId_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtProfesorId_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Clase.htm");
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgprompt_2_Internalname, sImgUrl, imgprompt_2_Link, "", "", context.GetTheme( ), imgprompt_2_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_Clase.htm");
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
            GxWebStd.gx_label_element( context, edtProfesorNombre_Internalname, "Profesor Nombre", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtProfesorNombre_Internalname, StringUtil.RTrim( A15ProfesorNombre), StringUtil.RTrim( context.localUtil.Format( A15ProfesorNombre, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtProfesorNombre_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtProfesorNombre_Enabled, 0, "text", "", 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Clase.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 LevelTable", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divSociostable_Internalname, 1, 0, "px", 0, "px", "LevelTable", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTitlesocios_Internalname, "Socios", "", "", lblTitlesocios_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_Clase.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            gxdraw_Gridclase_socios( ) ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 72,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirm", bttBtn_enter_Jsonclick, 5, "Confirm", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_Clase.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 74,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancel", bttBtn_cancel_Jsonclick, 1, "Cancel", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Clase.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 76,'',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Delete", bttBtn_delete_Jsonclick, 5, "Delete", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_Clase.htm");
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

      protected void gxdraw_Gridclase_socios( )
      {
         /*  Grid Control  */
         Gridclase_sociosContainer.AddObjectProperty("GridName", "Gridclase_socios");
         Gridclase_sociosContainer.AddObjectProperty("Header", subGridclase_socios_Header);
         Gridclase_sociosContainer.AddObjectProperty("Class", "Grid");
         Gridclase_sociosContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         Gridclase_sociosContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
         Gridclase_sociosContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridclase_socios_Backcolorstyle), 1, 0, ".", "")));
         Gridclase_sociosContainer.AddObjectProperty("CmpContext", "");
         Gridclase_sociosContainer.AddObjectProperty("InMasterPage", "false");
         Gridclase_sociosColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridclase_sociosColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A5SocioId), 4, 0, ".", "")));
         Gridclase_sociosColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSocioId_Enabled), 5, 0, ".", "")));
         Gridclase_sociosContainer.AddColumnProperties(Gridclase_sociosColumn);
         Gridclase_sociosColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridclase_sociosContainer.AddColumnProperties(Gridclase_sociosColumn);
         Gridclase_sociosColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridclase_sociosColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A20SocioEdad), 4, 0, ".", "")));
         Gridclase_sociosColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSocioEdad_Enabled), 5, 0, ".", "")));
         Gridclase_sociosContainer.AddColumnProperties(Gridclase_sociosColumn);
         Gridclase_sociosColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridclase_sociosColumn.AddObjectProperty("Value", A18SocioDireccion);
         Gridclase_sociosColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSocioDireccion_Enabled), 5, 0, ".", "")));
         Gridclase_sociosContainer.AddColumnProperties(Gridclase_sociosColumn);
         Gridclase_sociosColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridclase_sociosColumn.AddObjectProperty("Value", context.convertURL( A21SocioFoto));
         Gridclase_sociosColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSocioFoto_Enabled), 5, 0, ".", "")));
         Gridclase_sociosContainer.AddColumnProperties(Gridclase_sociosColumn);
         Gridclase_sociosContainer.AddObjectProperty("Selectedindex", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridclase_socios_Selectedindex), 4, 0, ".", "")));
         Gridclase_sociosContainer.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridclase_socios_Allowselection), 1, 0, ".", "")));
         Gridclase_sociosContainer.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridclase_socios_Selectioncolor), 9, 0, ".", "")));
         Gridclase_sociosContainer.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridclase_socios_Allowhovering), 1, 0, ".", "")));
         Gridclase_sociosContainer.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridclase_socios_Hoveringcolor), 9, 0, ".", "")));
         Gridclase_sociosContainer.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridclase_socios_Allowcollapsing), 1, 0, ".", "")));
         Gridclase_sociosContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridclase_socios_Collapsed), 1, 0, ".", "")));
         nGXsfl_63_idx = 0;
         if ( ( nKeyPressed == 1 ) && ( AnyError == 0 ) )
         {
            /* Enter key processing. */
            nBlankRcdCount13 = 5;
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               /* Display confirmed (stored) records */
               nRcdExists_13 = 1;
               ScanStart0413( ) ;
               while ( RcdFound13 != 0 )
               {
                  init_level_properties13( ) ;
                  getByPrimaryKey0413( ) ;
                  AddRow0413( ) ;
                  ScanNext0413( ) ;
               }
               ScanEnd0413( ) ;
               nBlankRcdCount13 = 5;
            }
         }
         else if ( ( nKeyPressed == 3 ) || ( nKeyPressed == 4 ) || ( ( nKeyPressed == 1 ) && ( AnyError != 0 ) ) )
         {
            /* Button check  or addlines. */
            standaloneNotModal0413( ) ;
            standaloneModal0413( ) ;
            sMode13 = Gx_mode;
            while ( nGXsfl_63_idx < nRC_GXsfl_63 )
            {
               bGXsfl_63_Refreshing = true;
               ReadRow0413( ) ;
               edtSocioId_Enabled = (int)(context.localUtil.CToN( cgiGet( "SOCIOID_"+sGXsfl_63_idx+"Enabled"), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSocioId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSocioId_Enabled), 5, 0)), !bGXsfl_63_Refreshing);
               edtSocioEdad_Enabled = (int)(context.localUtil.CToN( cgiGet( "SOCIOEDAD_"+sGXsfl_63_idx+"Enabled"), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSocioEdad_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSocioEdad_Enabled), 5, 0)), !bGXsfl_63_Refreshing);
               edtSocioDireccion_Enabled = (int)(context.localUtil.CToN( cgiGet( "SOCIODIRECCION_"+sGXsfl_63_idx+"Enabled"), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSocioDireccion_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSocioDireccion_Enabled), 5, 0)), !bGXsfl_63_Refreshing);
               edtSocioFoto_Enabled = (int)(context.localUtil.CToN( cgiGet( "SOCIOFOTO_"+sGXsfl_63_idx+"Enabled"), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSocioFoto_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSocioFoto_Enabled), 5, 0)), !bGXsfl_63_Refreshing);
               imgprompt_2_Link = cgiGet( "PROMPT_5_"+sGXsfl_63_idx+"Link");
               if ( ( nRcdExists_13 == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") != 0 ) )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  standaloneModal0413( ) ;
               }
               SendRow0413( ) ;
               bGXsfl_63_Refreshing = false;
            }
            Gx_mode = sMode13;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            /* Get or get-alike key processing. */
            nBlankRcdCount13 = 5;
            nRcdExists_13 = 1;
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               ScanStart0413( ) ;
               while ( RcdFound13 != 0 )
               {
                  sGXsfl_63_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_63_idx+1), 4, 0)), 4, "0");
                  SubsflControlProps_6313( ) ;
                  init_level_properties13( ) ;
                  standaloneNotModal0413( ) ;
                  getByPrimaryKey0413( ) ;
                  standaloneModal0413( ) ;
                  AddRow0413( ) ;
                  ScanNext0413( ) ;
               }
               ScanEnd0413( ) ;
            }
         }
         /* Initialize fields for 'new' records and send them. */
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") != 0 ) && ( StringUtil.StrCmp(Gx_mode, "DLT") != 0 ) )
         {
            sMode13 = Gx_mode;
            Gx_mode = "INS";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            sGXsfl_63_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_63_idx+1), 4, 0)), 4, "0");
            SubsflControlProps_6313( ) ;
            InitAll0413( ) ;
            init_level_properties13( ) ;
            standaloneNotModal0413( ) ;
            standaloneModal0413( ) ;
            nRcdExists_13 = 0;
            nIsMod_13 = 0;
            nRcdDeleted_13 = 0;
            nBlankRcdCount13 = (short)(nBlankRcdUsr13+nBlankRcdCount13);
            fRowAdded = 0;
            while ( nBlankRcdCount13 > 0 )
            {
               AddRow0413( ) ;
               if ( ( nKeyPressed == 4 ) && ( fRowAdded == 0 ) )
               {
                  fRowAdded = 1;
                  GX_FocusControl = edtSocioId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               nBlankRcdCount13 = (short)(nBlankRcdCount13-1);
            }
            Gx_mode = sMode13;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         sStyleString = "";
         context.WriteHtmlText( "<div id=\""+"Gridclase_sociosContainer"+"Div\" "+sStyleString+">"+"</div>") ;
         context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Gridclase_socios", Gridclase_sociosContainer);
         if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
         {
            GxWebStd.gx_hidden_field( context, "Gridclase_sociosContainerData", Gridclase_sociosContainer.ToJavascriptSource());
         }
         if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
         {
            GxWebStd.gx_hidden_field( context, "Gridclase_sociosContainerData"+"V", Gridclase_sociosContainer.GridValuesHidden());
         }
         else
         {
            context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Gridclase_sociosContainerData"+"V"+"\" value='"+Gridclase_sociosContainer.GridValuesHidden()+"'/>") ;
         }
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
         E11042 ();
         context.wbGlbDoneStart = 1;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read variables values. */
               if ( ( ( context.localUtil.CToN( cgiGet( edtClaseId_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtClaseId_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "CLASEID");
                  AnyError = 1;
                  GX_FocusControl = edtClaseId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A3ClaseId = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3ClaseId", StringUtil.LTrim( StringUtil.Str( (decimal)(A3ClaseId), 4, 0)));
               }
               else
               {
                  A3ClaseId = (short)(context.localUtil.CToN( cgiGet( edtClaseId_Internalname), ".", ","));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3ClaseId", StringUtil.LTrim( StringUtil.Str( (decimal)(A3ClaseId), 4, 0)));
               }
               A1ActividadId = (short)(context.localUtil.CToN( cgiGet( edtActividadId_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1ActividadId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1ActividadId), 4, 0)));
               A13ActividadDescripcion = cgiGet( edtActividadDescripcion_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13ActividadDescripcion", A13ActividadDescripcion);
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
               /* Read saved values. */
               Z3ClaseId = (short)(context.localUtil.CToN( cgiGet( "Z3ClaseId"), ".", ","));
               Z2ProfesorId = (short)(context.localUtil.CToN( cgiGet( "Z2ProfesorId"), ".", ","));
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ","));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ".", ","));
               Gx_mode = cgiGet( "Mode");
               nRC_GXsfl_63 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_63"), ".", ","));
               N2ProfesorId = (short)(context.localUtil.CToN( cgiGet( "N2ProfesorId"), ".", ","));
               AV15ClaseId = (short)(context.localUtil.CToN( cgiGet( "vCLASEID"), ".", ","));
               Gx_BScreen = (short)(context.localUtil.CToN( cgiGet( "vGXBSCREEN"), ".", ","));
               AV11Insert_ProfesorId = (short)(context.localUtil.CToN( cgiGet( "vINSERT_PROFESORID"), ".", ","));
               AV17Pgmname = cgiGet( "vPGMNAME");
               Gx_mode = cgiGet( "vMODE");
               A40000SocioFoto_GXI = cgiGet( "SOCIOFOTO_GXI");
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               forbiddenHiddens = "hsh" + "Clase";
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV11Insert_ProfesorId), "ZZZ9");
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( A3ClaseId != Z3ClaseId ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
               {
                  GXUtil.WriteLog("clase:[SecurityCheckFailed value for]"+"Insert_ProfesorId:"+context.localUtil.Format( (decimal)(AV11Insert_ProfesorId), "ZZZ9"));
                  GXUtil.WriteLog("clase:[SecurityCheckFailed value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
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
               /* Check if conditions changed and reset current page numbers */
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
                  A3ClaseId = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3ClaseId", StringUtil.LTrim( StringUtil.Str( (decimal)(A3ClaseId), 4, 0)));
                  getEqualNoModal( ) ;
                  if ( ! (0==AV15ClaseId) )
                  {
                     A3ClaseId = AV15ClaseId;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3ClaseId", StringUtil.LTrim( StringUtil.Str( (decimal)(A3ClaseId), 4, 0)));
                  }
                  else
                  {
                     if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && (0==A3ClaseId) && ( Gx_BScreen == 0 ) )
                     {
                        GXt_int1 = A3ClaseId;
                        new ultimoidclase(context ).execute( out  GXt_int1) ;
                        A3ClaseId = GXt_int1;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3ClaseId", StringUtil.LTrim( StringUtil.Str( (decimal)(A3ClaseId), 4, 0)));
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
                     sMode12 = Gx_mode;
                     Gx_mode = "UPD";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     if ( ! (0==AV15ClaseId) )
                     {
                        A3ClaseId = AV15ClaseId;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3ClaseId", StringUtil.LTrim( StringUtil.Str( (decimal)(A3ClaseId), 4, 0)));
                     }
                     else
                     {
                        if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && (0==A3ClaseId) && ( Gx_BScreen == 0 ) )
                        {
                           GXt_int1 = A3ClaseId;
                           new ultimoidclase(context ).execute( out  GXt_int1) ;
                           A3ClaseId = GXt_int1;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3ClaseId", StringUtil.LTrim( StringUtil.Str( (decimal)(A3ClaseId), 4, 0)));
                        }
                     }
                     Gx_mode = sMode12;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound12 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_040( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtn_enter_Internalname;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert", ""), 1, "CLASEID");
                        AnyError = 1;
                        GX_FocusControl = edtClaseId_Internalname;
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
                           E11042 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: After Trn */
                           E12042 ();
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
                        sEvtType = StringUtil.Right( sEvt, 4);
                        sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4));
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
            E12042 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll0412( ) ;
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
            DisableAttributes0412( ) ;
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

      protected void CONFIRM_040( )
      {
         BeforeValidate0412( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0412( ) ;
            }
            else
            {
               CheckExtendedTable0412( ) ;
               CloseExtendedTableCursors0412( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            /* Save parent mode. */
            sMode12 = Gx_mode;
            CONFIRM_0413( ) ;
            if ( AnyError == 0 )
            {
               /* Restore parent mode. */
               Gx_mode = sMode12;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
               IsConfirmed = 1;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
            }
            /* Restore parent mode. */
            Gx_mode = sMode12;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
      }

      protected void CONFIRM_0413( )
      {
         nGXsfl_63_idx = 0;
         while ( nGXsfl_63_idx < nRC_GXsfl_63 )
         {
            ReadRow0413( ) ;
            if ( ( nRcdExists_13 != 0 ) || ( nIsMod_13 != 0 ) )
            {
               GetKey0413( ) ;
               if ( ( nRcdExists_13 == 0 ) && ( nRcdDeleted_13 == 0 ) )
               {
                  if ( RcdFound13 == 0 )
                  {
                     Gx_mode = "INS";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     BeforeValidate0413( ) ;
                     if ( AnyError == 0 )
                     {
                        CheckExtendedTable0413( ) ;
                        CloseExtendedTableCursors0413( ) ;
                        if ( AnyError == 0 )
                        {
                           IsConfirmed = 1;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
                        }
                     }
                  }
                  else
                  {
                     GXCCtl = "SOCIOID_" + sGXsfl_63_idx;
                     GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, GXCCtl);
                     AnyError = 1;
                     GX_FocusControl = edtSocioId_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( RcdFound13 != 0 )
                  {
                     if ( nRcdDeleted_13 != 0 )
                     {
                        Gx_mode = "DLT";
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                        getByPrimaryKey0413( ) ;
                        Load0413( ) ;
                        BeforeValidate0413( ) ;
                        if ( AnyError == 0 )
                        {
                           OnDeleteControls0413( ) ;
                        }
                     }
                     else
                     {
                        if ( nIsMod_13 != 0 )
                        {
                           Gx_mode = "UPD";
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                           BeforeValidate0413( ) ;
                           if ( AnyError == 0 )
                           {
                              CheckExtendedTable0413( ) ;
                              CloseExtendedTableCursors0413( ) ;
                              if ( AnyError == 0 )
                              {
                                 IsConfirmed = 1;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
                              }
                           }
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_13 == 0 )
                     {
                        GXCCtl = "SOCIOID_" + sGXsfl_63_idx;
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, GXCCtl);
                        AnyError = 1;
                        GX_FocusControl = edtSocioId_Internalname;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtSocioId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A5SocioId), 4, 0, ".", ""))) ;
            ChangePostValue( edtSocioEdad_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A20SocioEdad), 4, 0, ".", ""))) ;
            ChangePostValue( edtSocioDireccion_Internalname, A18SocioDireccion) ;
            ChangePostValue( edtSocioFoto_Internalname, A21SocioFoto) ;
            ChangePostValue( "ZT_"+"Z5SocioId_"+sGXsfl_63_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z5SocioId), 4, 0, ".", ""))) ;
            ChangePostValue( "nRcdDeleted_13_"+sGXsfl_63_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_13), 4, 0, ".", ""))) ;
            ChangePostValue( "nRcdExists_13_"+sGXsfl_63_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_13), 4, 0, ".", ""))) ;
            ChangePostValue( "nIsMod_13_"+sGXsfl_63_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_13), 4, 0, ".", ""))) ;
            if ( nIsMod_13 != 0 )
            {
               ChangePostValue( "SOCIOID_"+sGXsfl_63_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSocioId_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SOCIOEDAD_"+sGXsfl_63_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSocioEdad_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SOCIODIRECCION_"+sGXsfl_63_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSocioDireccion_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SOCIOFOTO_"+sGXsfl_63_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSocioFoto_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
      }

      protected void ResetCaption040( )
      {
      }

      protected void E11042( )
      {
         /* Start Routine */
         if ( ! new isauthorized(context).executeUdp(  AV17Pgmname) )
         {
            CallWebObject(formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV17Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         AV9TrnContext.FromXml(AV10WebSession.Get("TrnContext"), null, "TransactionContext", "ObligatorioGenexusGit");
         AV11Insert_ProfesorId = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11Insert_ProfesorId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11Insert_ProfesorId), 4, 0)));
         if ( ( StringUtil.StrCmp(AV9TrnContext.gxTpr_Transactionname, AV17Pgmname) == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) )
         {
            AV18GXV1 = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18GXV1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18GXV1), 8, 0)));
            while ( AV18GXV1 <= AV9TrnContext.gxTpr_Attributes.Count )
            {
               AV12TrnContextAtt = ((SdtTransactionContext_Attribute)AV9TrnContext.gxTpr_Attributes.Item(AV18GXV1));
               if ( StringUtil.StrCmp(AV12TrnContextAtt.gxTpr_Attributename, "ProfesorId") == 0 )
               {
                  AV11Insert_ProfesorId = (short)(NumberUtil.Val( AV12TrnContextAtt.gxTpr_Attributevalue, "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11Insert_ProfesorId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11Insert_ProfesorId), 4, 0)));
               }
               AV18GXV1 = (int)(AV18GXV1+1);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18GXV1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18GXV1), 8, 0)));
            }
         }
      }

      protected void E12042( )
      {
         /* After Trn Routine */
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV9TrnContext.gxTpr_Callerondelete )
         {
            CallWebObject(formatLink("wwclase.aspx") );
            context.wjLocDisableFrm = 1;
         }
         context.setWebReturnParms(new Object[] {});
         context.setWebReturnParmsMetadata(new Object[] {});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      protected void ZM0412( short GX_JID )
      {
         if ( ( GX_JID == 9 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z2ProfesorId = T00046_A2ProfesorId[0];
            }
            else
            {
               Z2ProfesorId = A2ProfesorId;
            }
         }
         if ( GX_JID == -9 )
         {
            Z3ClaseId = A3ClaseId;
            Z2ProfesorId = A2ProfesorId;
            Z15ProfesorNombre = A15ProfesorNombre;
            Z1ActividadId = A1ActividadId;
            Z13ActividadDescripcion = A13ActividadDescripcion;
         }
      }

      protected void standaloneNotModal( )
      {
         Gx_BScreen = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
         imgprompt_2_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx00b0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"PROFESORID"+"'), id:'"+"PROFESORID"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"false"+");");
         bttBtn_delete_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Enabled), 5, 0)), true);
         if ( ! (0==AV15ClaseId) )
         {
            edtClaseId_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClaseId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClaseId_Enabled), 5, 0)), true);
         }
         else
         {
            edtClaseId_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClaseId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClaseId_Enabled), 5, 0)), true);
         }
         if ( ! (0==AV15ClaseId) )
         {
            edtClaseId_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClaseId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClaseId_Enabled), 5, 0)), true);
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV11Insert_ProfesorId) )
         {
            edtProfesorId_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtProfesorId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtProfesorId_Enabled), 5, 0)), true);
         }
         else
         {
            edtProfesorId_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtProfesorId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtProfesorId_Enabled), 5, 0)), true);
         }
      }

      protected void standaloneModal( )
      {
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV11Insert_ProfesorId) )
         {
            A2ProfesorId = AV11Insert_ProfesorId;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2ProfesorId", StringUtil.LTrim( StringUtil.Str( (decimal)(A2ProfesorId), 4, 0)));
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
         if ( ! (0==AV15ClaseId) )
         {
            A3ClaseId = AV15ClaseId;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3ClaseId", StringUtil.LTrim( StringUtil.Str( (decimal)(A3ClaseId), 4, 0)));
         }
         else
         {
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && (0==A3ClaseId) && ( Gx_BScreen == 0 ) )
            {
               GXt_int1 = A3ClaseId;
               new ultimoidclase(context ).execute( out  GXt_int1) ;
               A3ClaseId = GXt_int1;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3ClaseId", StringUtil.LTrim( StringUtil.Str( (decimal)(A3ClaseId), 4, 0)));
            }
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ( Gx_BScreen == 0 ) )
         {
            AV17Pgmname = "Clase";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17Pgmname", AV17Pgmname);
            /* Using cursor T00047 */
            pr_default.execute(5, new Object[] {A2ProfesorId});
            A15ProfesorNombre = T00047_A15ProfesorNombre[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A15ProfesorNombre", A15ProfesorNombre);
            A1ActividadId = T00047_A1ActividadId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1ActividadId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1ActividadId), 4, 0)));
            pr_default.close(5);
            /* Using cursor T00048 */
            pr_default.execute(6, new Object[] {A1ActividadId});
            A13ActividadDescripcion = T00048_A13ActividadDescripcion[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13ActividadDescripcion", A13ActividadDescripcion);
            pr_default.close(6);
         }
      }

      protected void Load0412( )
      {
         /* Using cursor T00049 */
         pr_default.execute(7, new Object[] {A3ClaseId});
         if ( (pr_default.getStatus(7) != 101) )
         {
            RcdFound12 = 1;
            A13ActividadDescripcion = T00049_A13ActividadDescripcion[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13ActividadDescripcion", A13ActividadDescripcion);
            A15ProfesorNombre = T00049_A15ProfesorNombre[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A15ProfesorNombre", A15ProfesorNombre);
            A2ProfesorId = T00049_A2ProfesorId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2ProfesorId", StringUtil.LTrim( StringUtil.Str( (decimal)(A2ProfesorId), 4, 0)));
            A1ActividadId = T00049_A1ActividadId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1ActividadId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1ActividadId), 4, 0)));
            ZM0412( -9) ;
         }
         pr_default.close(7);
         OnLoadActions0412( ) ;
      }

      protected void OnLoadActions0412( )
      {
         AV17Pgmname = "Clase";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17Pgmname", AV17Pgmname);
      }

      protected void CheckExtendedTable0412( )
      {
         Gx_BScreen = 1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
         standaloneModal( ) ;
         AV17Pgmname = "Clase";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17Pgmname", AV17Pgmname);
         /* Using cursor T00047 */
         pr_default.execute(5, new Object[] {A2ProfesorId});
         if ( (pr_default.getStatus(5) == 101) )
         {
            GX_msglist.addItem("No matching 'Profesor'.", "ForeignKeyNotFound", 1, "PROFESORID");
            AnyError = 1;
            GX_FocusControl = edtProfesorId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A15ProfesorNombre = T00047_A15ProfesorNombre[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A15ProfesorNombre", A15ProfesorNombre);
         A1ActividadId = T00047_A1ActividadId[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1ActividadId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1ActividadId), 4, 0)));
         pr_default.close(5);
         /* Using cursor T00048 */
         pr_default.execute(6, new Object[] {A1ActividadId});
         if ( (pr_default.getStatus(6) == 101) )
         {
            GX_msglist.addItem("No matching 'Actividad'.", "ForeignKeyNotFound", 1, "");
            AnyError = 1;
         }
         A13ActividadDescripcion = T00048_A13ActividadDescripcion[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13ActividadDescripcion", A13ActividadDescripcion);
         pr_default.close(6);
      }

      protected void CloseExtendedTableCursors0412( )
      {
         pr_default.close(5);
         pr_default.close(6);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_10( short A2ProfesorId )
      {
         /* Using cursor T000410 */
         pr_default.execute(8, new Object[] {A2ProfesorId});
         if ( (pr_default.getStatus(8) == 101) )
         {
            GX_msglist.addItem("No matching 'Profesor'.", "ForeignKeyNotFound", 1, "PROFESORID");
            AnyError = 1;
            GX_FocusControl = edtProfesorId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A15ProfesorNombre = T000410_A15ProfesorNombre[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A15ProfesorNombre", A15ProfesorNombre);
         A1ActividadId = T000410_A1ActividadId[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1ActividadId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1ActividadId), 4, 0)));
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A15ProfesorNombre))+"\""+","+"\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A1ActividadId), 4, 0, ".", "")))+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(8) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(8);
      }

      protected void gxLoad_11( short A1ActividadId )
      {
         /* Using cursor T000411 */
         pr_default.execute(9, new Object[] {A1ActividadId});
         if ( (pr_default.getStatus(9) == 101) )
         {
            GX_msglist.addItem("No matching 'Actividad'.", "ForeignKeyNotFound", 1, "");
            AnyError = 1;
         }
         A13ActividadDescripcion = T000411_A13ActividadDescripcion[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13ActividadDescripcion", A13ActividadDescripcion);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A13ActividadDescripcion))+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(9) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(9);
      }

      protected void GetKey0412( )
      {
         /* Using cursor T000412 */
         pr_default.execute(10, new Object[] {A3ClaseId});
         if ( (pr_default.getStatus(10) != 101) )
         {
            RcdFound12 = 1;
         }
         else
         {
            RcdFound12 = 0;
         }
         pr_default.close(10);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00046 */
         pr_default.execute(4, new Object[] {A3ClaseId});
         if ( (pr_default.getStatus(4) != 101) )
         {
            ZM0412( 9) ;
            RcdFound12 = 1;
            A3ClaseId = T00046_A3ClaseId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3ClaseId", StringUtil.LTrim( StringUtil.Str( (decimal)(A3ClaseId), 4, 0)));
            A2ProfesorId = T00046_A2ProfesorId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2ProfesorId", StringUtil.LTrim( StringUtil.Str( (decimal)(A2ProfesorId), 4, 0)));
            Z3ClaseId = A3ClaseId;
            sMode12 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load0412( ) ;
            if ( AnyError == 1 )
            {
               RcdFound12 = 0;
               InitializeNonKey0412( ) ;
            }
            Gx_mode = sMode12;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound12 = 0;
            InitializeNonKey0412( ) ;
            sMode12 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal( ) ;
            Gx_mode = sMode12;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         pr_default.close(4);
      }

      protected void getEqualNoModal( )
      {
         GetKey0412( ) ;
         if ( RcdFound12 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound12 = 0;
         /* Using cursor T000413 */
         pr_default.execute(11, new Object[] {A3ClaseId});
         if ( (pr_default.getStatus(11) != 101) )
         {
            while ( (pr_default.getStatus(11) != 101) && ( ( T000413_A3ClaseId[0] < A3ClaseId ) ) )
            {
               pr_default.readNext(11);
            }
            if ( (pr_default.getStatus(11) != 101) && ( ( T000413_A3ClaseId[0] > A3ClaseId ) ) )
            {
               A3ClaseId = T000413_A3ClaseId[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3ClaseId", StringUtil.LTrim( StringUtil.Str( (decimal)(A3ClaseId), 4, 0)));
               RcdFound12 = 1;
            }
         }
         pr_default.close(11);
      }

      protected void move_previous( )
      {
         RcdFound12 = 0;
         /* Using cursor T000414 */
         pr_default.execute(12, new Object[] {A3ClaseId});
         if ( (pr_default.getStatus(12) != 101) )
         {
            while ( (pr_default.getStatus(12) != 101) && ( ( T000414_A3ClaseId[0] > A3ClaseId ) ) )
            {
               pr_default.readNext(12);
            }
            if ( (pr_default.getStatus(12) != 101) && ( ( T000414_A3ClaseId[0] < A3ClaseId ) ) )
            {
               A3ClaseId = T000414_A3ClaseId[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3ClaseId", StringUtil.LTrim( StringUtil.Str( (decimal)(A3ClaseId), 4, 0)));
               RcdFound12 = 1;
            }
         }
         pr_default.close(12);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey0412( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtClaseId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert0412( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound12 == 1 )
            {
               if ( A3ClaseId != Z3ClaseId )
               {
                  A3ClaseId = Z3ClaseId;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3ClaseId", StringUtil.LTrim( StringUtil.Str( (decimal)(A3ClaseId), 4, 0)));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "CLASEID");
                  AnyError = 1;
                  GX_FocusControl = edtClaseId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtClaseId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Update record */
                  Update0412( ) ;
                  GX_FocusControl = edtClaseId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A3ClaseId != Z3ClaseId )
               {
                  /* Insert record */
                  GX_FocusControl = edtClaseId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert0412( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "CLASEID");
                     AnyError = 1;
                     GX_FocusControl = edtClaseId_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     /* Insert record */
                     GX_FocusControl = edtClaseId_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert0412( ) ;
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
         if ( A3ClaseId != Z3ClaseId )
         {
            A3ClaseId = Z3ClaseId;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3ClaseId", StringUtil.LTrim( StringUtil.Str( (decimal)(A3ClaseId), 4, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "CLASEID");
            AnyError = 1;
            GX_FocusControl = edtClaseId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtClaseId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency0412( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00045 */
            pr_default.execute(3, new Object[] {A3ClaseId});
            if ( (pr_default.getStatus(3) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Clase"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(3) == 101) || ( Z2ProfesorId != T00045_A2ProfesorId[0] ) )
            {
               if ( Z2ProfesorId != T00045_A2ProfesorId[0] )
               {
                  GXUtil.WriteLog("clase:[seudo value changed for attri]"+"ProfesorId");
                  GXUtil.WriteLogRaw("Old: ",Z2ProfesorId);
                  GXUtil.WriteLogRaw("Current: ",T00045_A2ProfesorId[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Clase"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0412( )
      {
         BeforeValidate0412( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0412( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0412( 0) ;
            CheckOptimisticConcurrency0412( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0412( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0412( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000415 */
                     pr_default.execute(13, new Object[] {A3ClaseId, A2ProfesorId});
                     pr_default.close(13);
                     dsDefault.SmartCacheProvider.SetUpdated("Clase") ;
                     if ( (pr_default.getStatus(13) == 1) )
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
                           ProcessLevel0412( ) ;
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
               Load0412( ) ;
            }
            EndLevel0412( ) ;
         }
         CloseExtendedTableCursors0412( ) ;
      }

      protected void Update0412( )
      {
         BeforeValidate0412( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0412( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0412( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0412( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0412( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000416 */
                     pr_default.execute(14, new Object[] {A2ProfesorId, A3ClaseId});
                     pr_default.close(14);
                     dsDefault.SmartCacheProvider.SetUpdated("Clase") ;
                     if ( (pr_default.getStatus(14) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Clase"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0412( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           ProcessLevel0412( ) ;
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
            }
            EndLevel0412( ) ;
         }
         CloseExtendedTableCursors0412( ) ;
      }

      protected void DeferredUpdate0412( )
      {
      }

      protected void delete( )
      {
         BeforeValidate0412( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0412( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0412( ) ;
            AfterConfirm0412( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0412( ) ;
               if ( AnyError == 0 )
               {
                  ScanStart0413( ) ;
                  while ( RcdFound13 != 0 )
                  {
                     getByPrimaryKey0413( ) ;
                     Delete0413( ) ;
                     ScanNext0413( ) ;
                  }
                  ScanEnd0413( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000417 */
                     pr_default.execute(15, new Object[] {A3ClaseId});
                     pr_default.close(15);
                     dsDefault.SmartCacheProvider.SetUpdated("Clase") ;
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
         }
         sMode12 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel0412( ) ;
         Gx_mode = sMode12;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls0412( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV17Pgmname = "Clase";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17Pgmname", AV17Pgmname);
            /* Using cursor T000418 */
            pr_default.execute(16, new Object[] {A2ProfesorId});
            A15ProfesorNombre = T000418_A15ProfesorNombre[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A15ProfesorNombre", A15ProfesorNombre);
            A1ActividadId = T000418_A1ActividadId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1ActividadId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1ActividadId), 4, 0)));
            pr_default.close(16);
            /* Using cursor T000419 */
            pr_default.execute(17, new Object[] {A1ActividadId});
            A13ActividadDescripcion = T000419_A13ActividadDescripcion[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13ActividadDescripcion", A13ActividadDescripcion);
            pr_default.close(17);
         }
      }

      protected void ProcessNestedLevel0413( )
      {
         nGXsfl_63_idx = 0;
         while ( nGXsfl_63_idx < nRC_GXsfl_63 )
         {
            ReadRow0413( ) ;
            if ( ( nRcdExists_13 != 0 ) || ( nIsMod_13 != 0 ) )
            {
               standaloneNotModal0413( ) ;
               GetKey0413( ) ;
               if ( ( nRcdExists_13 == 0 ) && ( nRcdDeleted_13 == 0 ) )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  Insert0413( ) ;
               }
               else
               {
                  if ( RcdFound13 != 0 )
                  {
                     if ( ( nRcdDeleted_13 != 0 ) && ( nRcdExists_13 != 0 ) )
                     {
                        Gx_mode = "DLT";
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                        Delete0413( ) ;
                     }
                     else
                     {
                        if ( ( nIsMod_13 != 0 ) && ( nRcdExists_13 != 0 ) )
                        {
                           Gx_mode = "UPD";
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                           Update0413( ) ;
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_13 == 0 )
                     {
                        GXCCtl = "SOCIOID_" + sGXsfl_63_idx;
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, GXCCtl);
                        AnyError = 1;
                        GX_FocusControl = edtSocioId_Internalname;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtSocioId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A5SocioId), 4, 0, ".", ""))) ;
            ChangePostValue( edtSocioEdad_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A20SocioEdad), 4, 0, ".", ""))) ;
            ChangePostValue( edtSocioDireccion_Internalname, A18SocioDireccion) ;
            ChangePostValue( edtSocioFoto_Internalname, A21SocioFoto) ;
            ChangePostValue( "ZT_"+"Z5SocioId_"+sGXsfl_63_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z5SocioId), 4, 0, ".", ""))) ;
            ChangePostValue( "nRcdDeleted_13_"+sGXsfl_63_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_13), 4, 0, ".", ""))) ;
            ChangePostValue( "nRcdExists_13_"+sGXsfl_63_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_13), 4, 0, ".", ""))) ;
            ChangePostValue( "nIsMod_13_"+sGXsfl_63_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_13), 4, 0, ".", ""))) ;
            if ( nIsMod_13 != 0 )
            {
               ChangePostValue( "SOCIOID_"+sGXsfl_63_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSocioId_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SOCIOEDAD_"+sGXsfl_63_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSocioEdad_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SOCIODIRECCION_"+sGXsfl_63_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSocioDireccion_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SOCIOFOTO_"+sGXsfl_63_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSocioFoto_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
         InitAll0413( ) ;
         if ( AnyError != 0 )
         {
         }
         nRcdExists_13 = 0;
         nIsMod_13 = 0;
         nRcdDeleted_13 = 0;
      }

      protected void ProcessLevel0412( )
      {
         /* Save parent mode. */
         sMode12 = Gx_mode;
         ProcessNestedLevel0413( ) ;
         if ( AnyError != 0 )
         {
         }
         /* Restore parent mode. */
         Gx_mode = sMode12;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         /* ' Update level parameters */
      }

      protected void EndLevel0412( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(3);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0412( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(4);
            pr_default.close(1);
            pr_default.close(0);
            pr_default.close(16);
            pr_default.close(17);
            pr_default.close(2);
            context.CommitDataStores("clase",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues040( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(4);
            pr_default.close(1);
            pr_default.close(0);
            pr_default.close(16);
            pr_default.close(17);
            pr_default.close(2);
            context.RollbackDataStores("clase",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart0412( )
      {
         /* Scan By routine */
         /* Using cursor T000420 */
         pr_default.execute(18);
         RcdFound12 = 0;
         if ( (pr_default.getStatus(18) != 101) )
         {
            RcdFound12 = 1;
            A3ClaseId = T000420_A3ClaseId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3ClaseId", StringUtil.LTrim( StringUtil.Str( (decimal)(A3ClaseId), 4, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0412( )
      {
         /* Scan next routine */
         pr_default.readNext(18);
         RcdFound12 = 0;
         if ( (pr_default.getStatus(18) != 101) )
         {
            RcdFound12 = 1;
            A3ClaseId = T000420_A3ClaseId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3ClaseId", StringUtil.LTrim( StringUtil.Str( (decimal)(A3ClaseId), 4, 0)));
         }
      }

      protected void ScanEnd0412( )
      {
         pr_default.close(18);
      }

      protected void AfterConfirm0412( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0412( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0412( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0412( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0412( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0412( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0412( )
      {
         edtClaseId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClaseId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClaseId_Enabled), 5, 0)), true);
         edtActividadId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtActividadId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtActividadId_Enabled), 5, 0)), true);
         edtActividadDescripcion_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtActividadDescripcion_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtActividadDescripcion_Enabled), 5, 0)), true);
         edtProfesorId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtProfesorId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtProfesorId_Enabled), 5, 0)), true);
         edtProfesorNombre_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtProfesorNombre_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtProfesorNombre_Enabled), 5, 0)), true);
      }

      protected void ZM0413( short GX_JID )
      {
         if ( ( GX_JID == 12 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
            }
            else
            {
            }
         }
         if ( GX_JID == -12 )
         {
            Z3ClaseId = A3ClaseId;
            Z5SocioId = A5SocioId;
            Z20SocioEdad = A20SocioEdad;
            Z18SocioDireccion = A18SocioDireccion;
            Z21SocioFoto = A21SocioFoto;
            Z40000SocioFoto_GXI = A40000SocioFoto_GXI;
         }
      }

      protected void standaloneNotModal0413( )
      {
      }

      protected void standaloneModal0413( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            edtSocioId_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSocioId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSocioId_Enabled), 5, 0)), !bGXsfl_63_Refreshing);
         }
         else
         {
            edtSocioId_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSocioId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSocioId_Enabled), 5, 0)), !bGXsfl_63_Refreshing);
         }
      }

      protected void Load0413( )
      {
         /* Using cursor T000421 */
         pr_default.execute(19, new Object[] {A3ClaseId, A5SocioId});
         if ( (pr_default.getStatus(19) != 101) )
         {
            RcdFound13 = 1;
            A20SocioEdad = T000421_A20SocioEdad[0];
            A18SocioDireccion = T000421_A18SocioDireccion[0];
            A40000SocioFoto_GXI = T000421_A40000SocioFoto_GXI[0];
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSocioFoto_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A21SocioFoto)) ? A40000SocioFoto_GXI : context.convertURL( context.PathToRelativeUrl( A21SocioFoto))), !bGXsfl_63_Refreshing);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSocioFoto_Internalname, "SrcSet", context.GetImageSrcSet( A21SocioFoto), true);
            A21SocioFoto = T000421_A21SocioFoto[0];
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSocioFoto_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A21SocioFoto)) ? A40000SocioFoto_GXI : context.convertURL( context.PathToRelativeUrl( A21SocioFoto))), !bGXsfl_63_Refreshing);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSocioFoto_Internalname, "SrcSet", context.GetImageSrcSet( A21SocioFoto), true);
            ZM0413( -12) ;
         }
         pr_default.close(19);
         OnLoadActions0413( ) ;
      }

      protected void OnLoadActions0413( )
      {
      }

      protected void CheckExtendedTable0413( )
      {
         Gx_BScreen = 1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
         standaloneModal0413( ) ;
         /* Using cursor T00044 */
         pr_default.execute(2, new Object[] {A5SocioId});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GXCCtl = "SOCIOID_" + sGXsfl_63_idx;
            GX_msglist.addItem("No matching 'Socio'.", "ForeignKeyNotFound", 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtSocioId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A20SocioEdad = T00044_A20SocioEdad[0];
         A18SocioDireccion = T00044_A18SocioDireccion[0];
         A40000SocioFoto_GXI = T00044_A40000SocioFoto_GXI[0];
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSocioFoto_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A21SocioFoto)) ? A40000SocioFoto_GXI : context.convertURL( context.PathToRelativeUrl( A21SocioFoto))), !bGXsfl_63_Refreshing);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSocioFoto_Internalname, "SrcSet", context.GetImageSrcSet( A21SocioFoto), true);
         A21SocioFoto = T00044_A21SocioFoto[0];
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSocioFoto_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A21SocioFoto)) ? A40000SocioFoto_GXI : context.convertURL( context.PathToRelativeUrl( A21SocioFoto))), !bGXsfl_63_Refreshing);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSocioFoto_Internalname, "SrcSet", context.GetImageSrcSet( A21SocioFoto), true);
         pr_default.close(2);
      }

      protected void CloseExtendedTableCursors0413( )
      {
         pr_default.close(2);
      }

      protected void enableDisable0413( )
      {
      }

      protected void gxLoad_13( short A5SocioId )
      {
         /* Using cursor T000422 */
         pr_default.execute(20, new Object[] {A5SocioId});
         if ( (pr_default.getStatus(20) == 101) )
         {
            GXCCtl = "SOCIOID_" + sGXsfl_63_idx;
            GX_msglist.addItem("No matching 'Socio'.", "ForeignKeyNotFound", 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtSocioId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A20SocioEdad = T000422_A20SocioEdad[0];
         A18SocioDireccion = T000422_A18SocioDireccion[0];
         A40000SocioFoto_GXI = T000422_A40000SocioFoto_GXI[0];
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSocioFoto_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A21SocioFoto)) ? A40000SocioFoto_GXI : context.convertURL( context.PathToRelativeUrl( A21SocioFoto))), !bGXsfl_63_Refreshing);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSocioFoto_Internalname, "SrcSet", context.GetImageSrcSet( A21SocioFoto), true);
         A21SocioFoto = T000422_A21SocioFoto[0];
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSocioFoto_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A21SocioFoto)) ? A40000SocioFoto_GXI : context.convertURL( context.PathToRelativeUrl( A21SocioFoto))), !bGXsfl_63_Refreshing);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSocioFoto_Internalname, "SrcSet", context.GetImageSrcSet( A21SocioFoto), true);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A20SocioEdad), 4, 0, ".", "")))+"\""+","+"\""+GXUtil.EncodeJSConstant( A18SocioDireccion)+"\""+","+"\""+GXUtil.EncodeJSConstant( A21SocioFoto)+"\""+","+"\""+GXUtil.EncodeJSConstant( A40000SocioFoto_GXI)+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(20) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(20);
      }

      protected void GetKey0413( )
      {
         /* Using cursor T000423 */
         pr_default.execute(21, new Object[] {A3ClaseId, A5SocioId});
         if ( (pr_default.getStatus(21) != 101) )
         {
            RcdFound13 = 1;
         }
         else
         {
            RcdFound13 = 0;
         }
         pr_default.close(21);
      }

      protected void getByPrimaryKey0413( )
      {
         /* Using cursor T00043 */
         pr_default.execute(1, new Object[] {A3ClaseId, A5SocioId});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0413( 12) ;
            RcdFound13 = 1;
            InitializeNonKey0413( ) ;
            A5SocioId = T00043_A5SocioId[0];
            Z3ClaseId = A3ClaseId;
            Z5SocioId = A5SocioId;
            sMode13 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load0413( ) ;
            Gx_mode = sMode13;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound13 = 0;
            InitializeNonKey0413( ) ;
            sMode13 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal0413( ) ;
            Gx_mode = sMode13;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            DisableAttributes0413( ) ;
         }
         pr_default.close(1);
      }

      protected void CheckOptimisticConcurrency0413( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00042 */
            pr_default.execute(0, new Object[] {A3ClaseId, A5SocioId});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"ClaseSocios"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"ClaseSocios"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0413( )
      {
         BeforeValidate0413( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0413( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0413( 0) ;
            CheckOptimisticConcurrency0413( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0413( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0413( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000424 */
                     pr_default.execute(22, new Object[] {A3ClaseId, A5SocioId});
                     pr_default.close(22);
                     dsDefault.SmartCacheProvider.SetUpdated("ClaseSocios") ;
                     if ( (pr_default.getStatus(22) == 1) )
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
                           /* Save values for previous() function. */
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
               Load0413( ) ;
            }
            EndLevel0413( ) ;
         }
         CloseExtendedTableCursors0413( ) ;
      }

      protected void Update0413( )
      {
         BeforeValidate0413( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0413( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0413( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0413( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0413( ) ;
                  if ( AnyError == 0 )
                  {
                     /* No attributes to update on table [ClaseSocios] */
                     DeferredUpdate0413( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey0413( ) ;
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
            EndLevel0413( ) ;
         }
         CloseExtendedTableCursors0413( ) ;
      }

      protected void DeferredUpdate0413( )
      {
      }

      protected void Delete0413( )
      {
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         BeforeValidate0413( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0413( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0413( ) ;
            AfterConfirm0413( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0413( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000425 */
                  pr_default.execute(23, new Object[] {A3ClaseId, A5SocioId});
                  pr_default.close(23);
                  dsDefault.SmartCacheProvider.SetUpdated("ClaseSocios") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                     AnyError = 1;
                  }
               }
            }
         }
         sMode13 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel0413( ) ;
         Gx_mode = sMode13;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls0413( )
      {
         standaloneModal0413( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            /* Using cursor T000426 */
            pr_default.execute(24, new Object[] {A5SocioId});
            A20SocioEdad = T000426_A20SocioEdad[0];
            A18SocioDireccion = T000426_A18SocioDireccion[0];
            A40000SocioFoto_GXI = T000426_A40000SocioFoto_GXI[0];
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSocioFoto_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A21SocioFoto)) ? A40000SocioFoto_GXI : context.convertURL( context.PathToRelativeUrl( A21SocioFoto))), !bGXsfl_63_Refreshing);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSocioFoto_Internalname, "SrcSet", context.GetImageSrcSet( A21SocioFoto), true);
            A21SocioFoto = T000426_A21SocioFoto[0];
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSocioFoto_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A21SocioFoto)) ? A40000SocioFoto_GXI : context.convertURL( context.PathToRelativeUrl( A21SocioFoto))), !bGXsfl_63_Refreshing);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSocioFoto_Internalname, "SrcSet", context.GetImageSrcSet( A21SocioFoto), true);
            pr_default.close(24);
         }
      }

      protected void EndLevel0413( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart0413( )
      {
         /* Scan By routine */
         /* Using cursor T000427 */
         pr_default.execute(25, new Object[] {A3ClaseId});
         RcdFound13 = 0;
         if ( (pr_default.getStatus(25) != 101) )
         {
            RcdFound13 = 1;
            A5SocioId = T000427_A5SocioId[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0413( )
      {
         /* Scan next routine */
         pr_default.readNext(25);
         RcdFound13 = 0;
         if ( (pr_default.getStatus(25) != 101) )
         {
            RcdFound13 = 1;
            A5SocioId = T000427_A5SocioId[0];
         }
      }

      protected void ScanEnd0413( )
      {
         pr_default.close(25);
      }

      protected void AfterConfirm0413( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0413( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0413( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0413( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0413( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0413( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0413( )
      {
         edtSocioId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSocioId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSocioId_Enabled), 5, 0)), !bGXsfl_63_Refreshing);
         edtSocioEdad_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSocioEdad_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSocioEdad_Enabled), 5, 0)), !bGXsfl_63_Refreshing);
         edtSocioDireccion_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSocioDireccion_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSocioDireccion_Enabled), 5, 0)), !bGXsfl_63_Refreshing);
         edtSocioFoto_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSocioFoto_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSocioFoto_Enabled), 5, 0)), !bGXsfl_63_Refreshing);
      }

      protected void send_integrity_lvl_hashes0413( )
      {
      }

      protected void send_integrity_lvl_hashes0412( )
      {
      }

      protected void SubsflControlProps_6313( )
      {
         edtSocioId_Internalname = "SOCIOID_"+sGXsfl_63_idx;
         imgprompt_5_Internalname = "PROMPT_5_"+sGXsfl_63_idx;
         edtSocioEdad_Internalname = "SOCIOEDAD_"+sGXsfl_63_idx;
         edtSocioDireccion_Internalname = "SOCIODIRECCION_"+sGXsfl_63_idx;
         edtSocioFoto_Internalname = "SOCIOFOTO_"+sGXsfl_63_idx;
      }

      protected void SubsflControlProps_fel_6313( )
      {
         edtSocioId_Internalname = "SOCIOID_"+sGXsfl_63_fel_idx;
         imgprompt_5_Internalname = "PROMPT_5_"+sGXsfl_63_fel_idx;
         edtSocioEdad_Internalname = "SOCIOEDAD_"+sGXsfl_63_fel_idx;
         edtSocioDireccion_Internalname = "SOCIODIRECCION_"+sGXsfl_63_fel_idx;
         edtSocioFoto_Internalname = "SOCIOFOTO_"+sGXsfl_63_fel_idx;
      }

      protected void AddRow0413( )
      {
         nGXsfl_63_idx = (short)(nGXsfl_63_idx+1);
         sGXsfl_63_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_63_idx), 4, 0)), 4, "0");
         SubsflControlProps_6313( ) ;
         SendRow0413( ) ;
      }

      protected void SendRow0413( )
      {
         Gridclase_sociosRow = GXWebRow.GetNew(context);
         if ( subGridclase_socios_Backcolorstyle == 0 )
         {
            /* None style subfile background logic. */
            subGridclase_socios_Backstyle = 0;
            if ( StringUtil.StrCmp(subGridclase_socios_Class, "") != 0 )
            {
               subGridclase_socios_Linesclass = subGridclase_socios_Class+"Odd";
            }
         }
         else if ( subGridclase_socios_Backcolorstyle == 1 )
         {
            /* Uniform style subfile background logic. */
            subGridclase_socios_Backstyle = 0;
            subGridclase_socios_Backcolor = subGridclase_socios_Allbackcolor;
            if ( StringUtil.StrCmp(subGridclase_socios_Class, "") != 0 )
            {
               subGridclase_socios_Linesclass = subGridclase_socios_Class+"Uniform";
            }
         }
         else if ( subGridclase_socios_Backcolorstyle == 2 )
         {
            /* Header style subfile background logic. */
            subGridclase_socios_Backstyle = 1;
            if ( StringUtil.StrCmp(subGridclase_socios_Class, "") != 0 )
            {
               subGridclase_socios_Linesclass = subGridclase_socios_Class+"Odd";
            }
            subGridclase_socios_Backcolor = (int)(0x0);
         }
         else if ( subGridclase_socios_Backcolorstyle == 3 )
         {
            /* Report style subfile background logic. */
            subGridclase_socios_Backstyle = 1;
            if ( ((int)(((nGXsfl_63_idx-1)/ (decimal)(1)) % (2))) == 0 )
            {
               subGridclase_socios_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGridclase_socios_Class, "") != 0 )
               {
                  subGridclase_socios_Linesclass = subGridclase_socios_Class+"Odd";
               }
            }
            else
            {
               subGridclase_socios_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGridclase_socios_Class, "") != 0 )
               {
                  subGridclase_socios_Linesclass = subGridclase_socios_Class+"Even";
               }
            }
         }
         imgprompt_5_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0)||(StringUtil.StrCmp(Gx_mode, "UPD")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0040.aspx"+"',["+"{Ctrl:gx.dom.el('"+"SOCIOID_"+sGXsfl_63_idx+"'), id:'"+"SOCIOID_"+sGXsfl_63_idx+"'"+",IOType:'out'}"+"],"+"gx.dom.form()."+"nIsMod_13_"+sGXsfl_63_idx+","+"'', false"+","+"false"+");");
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_13_" + sGXsfl_63_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 64,'',false,'" + sGXsfl_63_idx + "',63)\"";
         ROClassString = "Attribute";
         Gridclase_sociosRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSocioId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A5SocioId), 4, 0, ".", "")),StringUtil.LTrim( context.localUtil.Format( (decimal)(A5SocioId), "ZZZ9")),TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,64);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtSocioId_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtSocioId_Enabled,(short)1,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)63,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         /* Static images/pictures */
         ClassString = "gx-prompt Image";
         StyleString = "";
         sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
         Gridclase_sociosRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)imgprompt_5_Internalname,(String)sImgUrl,(String)imgprompt_5_Link,(String)"",(String)"",context.GetTheme( ),(int)imgprompt_5_Visible,(short)1,(String)"",(String)"",(short)0,(short)0,(short)0,(String)"",(short)0,(String)"",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)false,(bool)false,context.GetImageSrcSet( sImgUrl)});
         /* Subfile cell */
         /* Single line edit */
         ROClassString = "Attribute";
         Gridclase_sociosRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSocioEdad_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A20SocioEdad), 4, 0, ".", "")),((edtSocioEdad_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A20SocioEdad), "ZZZ9")) : context.localUtil.Format( (decimal)(A20SocioEdad), "ZZZ9")),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtSocioEdad_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtSocioEdad_Enabled,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)63,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         /* Single line edit */
         ROClassString = "Attribute";
         Gridclase_sociosRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSocioDireccion_Internalname,(String)A18SocioDireccion,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'","http://maps.google.com/maps?q="+GXUtil.UrlEncode( A18SocioDireccion),(String)"_blank",(String)"",(String)"",(String)edtSocioDireccion_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtSocioDireccion_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)1024,(short)0,(short)0,(short)63,(short)1,(short)-1,(short)0,(bool)true,(String)"GeneXus\\Address",(String)"left",(bool)true});
         /* Subfile cell */
         /* Static Bitmap Variable */
         ClassString = "ImageAttribute";
         StyleString = "";
         A21SocioFoto_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( A21SocioFoto))&&String.IsNullOrEmpty(StringUtil.RTrim( A40000SocioFoto_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( A21SocioFoto)));
         sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( A21SocioFoto)) ? A40000SocioFoto_GXI : context.PathToRelativeUrl( A21SocioFoto));
         Gridclase_sociosRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtSocioFoto_Internalname,(String)sImgUrl,(String)"",(String)"",(String)"",context.GetTheme( ),(short)-1,(int)edtSocioFoto_Enabled,(String)"",(String)"",(short)1,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)0,(bool)A21SocioFoto_IsBlob,(bool)true,context.GetImageSrcSet( sImgUrl)});
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSocioFoto_Internalname, "URL", (String.IsNullOrEmpty(StringUtil.RTrim( A21SocioFoto)) ? A40000SocioFoto_GXI : context.PathToRelativeUrl( A21SocioFoto)), !bGXsfl_63_Refreshing);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSocioFoto_Internalname, "IsBlob", StringUtil.BoolToStr( A21SocioFoto_IsBlob), !bGXsfl_63_Refreshing);
         context.httpAjaxContext.ajax_sending_grid_row(Gridclase_sociosRow);
         send_integrity_lvl_hashes0413( ) ;
         GXCCtl = "Z5SocioId_" + sGXsfl_63_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z5SocioId), 4, 0, ".", "")));
         GXCCtl = "nRcdDeleted_13_" + sGXsfl_63_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_13), 4, 0, ".", "")));
         GXCCtl = "nRcdExists_13_" + sGXsfl_63_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_13), 4, 0, ".", "")));
         GXCCtl = "nIsMod_13_" + sGXsfl_63_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_13), 4, 0, ".", "")));
         GXCCtl = "vMODE_" + sGXsfl_63_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Gx_mode));
         GXCCtl = "vTRNCONTEXT_" + sGXsfl_63_idx;
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, GXCCtl, AV9TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(GXCCtl, AV9TrnContext);
         }
         GXCCtl = "vCLASEID_" + sGXsfl_63_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV15ClaseId), 4, 0, ".", "")));
         GXCCtl = "SOCIOFOTO_" + sGXsfl_63_idx;
         GXCCtlgxBlob = GXCCtl + "_gxBlob";
         GxWebStd.gx_hidden_field( context, GXCCtlgxBlob, A21SocioFoto);
         GxWebStd.gx_hidden_field( context, "SOCIOID_"+sGXsfl_63_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSocioId_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "SOCIOEDAD_"+sGXsfl_63_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSocioEdad_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "SOCIODIRECCION_"+sGXsfl_63_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSocioDireccion_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "SOCIOFOTO_"+sGXsfl_63_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSocioFoto_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "PROMPT_5_"+sGXsfl_63_idx+"Link", StringUtil.RTrim( imgprompt_5_Link));
         context.httpAjaxContext.ajax_sending_grid_row(null);
         Gridclase_sociosContainer.AddRow(Gridclase_sociosRow);
      }

      protected void ReadRow0413( )
      {
         nGXsfl_63_idx = (short)(nGXsfl_63_idx+1);
         sGXsfl_63_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_63_idx), 4, 0)), 4, "0");
         SubsflControlProps_6313( ) ;
         edtSocioId_Enabled = (int)(context.localUtil.CToN( cgiGet( "SOCIOID_"+sGXsfl_63_idx+"Enabled"), ".", ","));
         edtSocioEdad_Enabled = (int)(context.localUtil.CToN( cgiGet( "SOCIOEDAD_"+sGXsfl_63_idx+"Enabled"), ".", ","));
         edtSocioDireccion_Enabled = (int)(context.localUtil.CToN( cgiGet( "SOCIODIRECCION_"+sGXsfl_63_idx+"Enabled"), ".", ","));
         edtSocioFoto_Enabled = (int)(context.localUtil.CToN( cgiGet( "SOCIOFOTO_"+sGXsfl_63_idx+"Enabled"), ".", ","));
         imgprompt_2_Link = cgiGet( "PROMPT_5_"+sGXsfl_63_idx+"Link");
         if ( ( ( context.localUtil.CToN( cgiGet( edtSocioId_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtSocioId_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
         {
            GXCCtl = "SOCIOID_" + sGXsfl_63_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtSocioId_Internalname;
            wbErr = true;
            A5SocioId = 0;
         }
         else
         {
            A5SocioId = (short)(context.localUtil.CToN( cgiGet( edtSocioId_Internalname), ".", ","));
         }
         A20SocioEdad = (short)(context.localUtil.CToN( cgiGet( edtSocioEdad_Internalname), ".", ","));
         A18SocioDireccion = cgiGet( edtSocioDireccion_Internalname);
         A21SocioFoto = cgiGet( edtSocioFoto_Internalname);
         GXCCtl = "Z5SocioId_" + sGXsfl_63_idx;
         Z5SocioId = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ","));
         GXCCtl = "nRcdDeleted_13_" + sGXsfl_63_idx;
         nRcdDeleted_13 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ","));
         GXCCtl = "nRcdExists_13_" + sGXsfl_63_idx;
         nRcdExists_13 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ","));
         GXCCtl = "nIsMod_13_" + sGXsfl_63_idx;
         nIsMod_13 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ","));
         getMultimediaValue(edtSocioFoto_Internalname, ref  A21SocioFoto, ref  A40000SocioFoto_GXI);
      }

      protected void assign_properties_default( )
      {
         defedtSocioId_Enabled = edtSocioId_Enabled;
      }

      protected void ConfirmValues040( )
      {
         nGXsfl_63_idx = 0;
         sGXsfl_63_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_63_idx), 4, 0)), 4, "0");
         SubsflControlProps_6313( ) ;
         while ( nGXsfl_63_idx < nRC_GXsfl_63 )
         {
            nGXsfl_63_idx = (short)(nGXsfl_63_idx+1);
            sGXsfl_63_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_63_idx), 4, 0)), 4, "0");
            SubsflControlProps_6313( ) ;
            ChangePostValue( "Z5SocioId_"+sGXsfl_63_idx, cgiGet( "ZT_"+"Z5SocioId_"+sGXsfl_63_idx)) ;
            DeletePostValue( "ZT_"+"Z5SocioId_"+sGXsfl_63_idx) ;
         }
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
         context.AddJavascriptSource("gxcfg.js", "?20194122113840", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("clase.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV15ClaseId)+"\">") ;
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
         forbiddenHiddens = "hsh" + "Clase";
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV11Insert_ProfesorId), "ZZZ9");
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("clase:[SendSecurityCheck value for]"+"Insert_ProfesorId:"+context.localUtil.Format( (decimal)(AV11Insert_ProfesorId), "ZZZ9"));
         GXUtil.WriteLog("clase:[SendSecurityCheck value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z3ClaseId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z3ClaseId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z2ProfesorId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z2ProfesorId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_Mode", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_63", StringUtil.LTrim( StringUtil.NToC( (decimal)(nGXsfl_63_idx), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "N2ProfesorId", StringUtil.LTrim( StringUtil.NToC( (decimal)(A2ProfesorId), 4, 0, ".", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vTRNCONTEXT", AV9TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vTRNCONTEXT", AV9TrnContext);
         }
         GxWebStd.gx_hidden_field( context, "vCLASEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV15ClaseId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vCLASEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV15ClaseId), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vGXBSCREEN", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gx_BScreen), 1, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vINSERT_PROFESORID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11Insert_ProfesorId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV17Pgmname));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GxWebStd.gx_hidden_field( context, "SOCIOFOTO_GXI", A40000SocioFoto_GXI);
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
         return formatLink("clase.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV15ClaseId) ;
      }

      public override String GetPgmname( )
      {
         return "Clase" ;
      }

      public override String GetPgmdesc( )
      {
         return "Clase" ;
      }

      protected void InitializeNonKey0412( )
      {
         A2ProfesorId = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2ProfesorId", StringUtil.LTrim( StringUtil.Str( (decimal)(A2ProfesorId), 4, 0)));
         A1ActividadId = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1ActividadId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1ActividadId), 4, 0)));
         A13ActividadDescripcion = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13ActividadDescripcion", A13ActividadDescripcion);
         A15ProfesorNombre = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A15ProfesorNombre", A15ProfesorNombre);
         Z2ProfesorId = 0;
      }

      protected void InitAll0412( )
      {
         A3ClaseId = new ultimoidclase(context).executeUdp( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3ClaseId", StringUtil.LTrim( StringUtil.Str( (decimal)(A3ClaseId), 4, 0)));
         InitializeNonKey0412( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void InitializeNonKey0413( )
      {
         A20SocioEdad = 0;
         A18SocioDireccion = "";
         A21SocioFoto = "";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSocioFoto_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A21SocioFoto)) ? A40000SocioFoto_GXI : context.convertURL( context.PathToRelativeUrl( A21SocioFoto))), !bGXsfl_63_Refreshing);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSocioFoto_Internalname, "SrcSet", context.GetImageSrcSet( A21SocioFoto), true);
         A40000SocioFoto_GXI = "";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSocioFoto_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A21SocioFoto)) ? A40000SocioFoto_GXI : context.convertURL( context.PathToRelativeUrl( A21SocioFoto))), !bGXsfl_63_Refreshing);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSocioFoto_Internalname, "SrcSet", context.GetImageSrcSet( A21SocioFoto), true);
      }

      protected void InitAll0413( )
      {
         A5SocioId = 0;
         InitializeNonKey0413( ) ;
      }

      protected void StandaloneModalInsert0413( )
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20194122113848", true);
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
         context.AddJavascriptSource("clase.js", "?20194122113848", false);
         /* End function include_jscripts */
      }

      protected void init_level_properties13( )
      {
         edtSocioId_Enabled = defedtSocioId_Enabled;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSocioId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSocioId_Enabled), 5, 0)), !bGXsfl_63_Refreshing);
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
         edtClaseId_Internalname = "CLASEID";
         edtActividadId_Internalname = "ACTIVIDADID";
         edtActividadDescripcion_Internalname = "ACTIVIDADDESCRIPCION";
         edtProfesorId_Internalname = "PROFESORID";
         edtProfesorNombre_Internalname = "PROFESORNOMBRE";
         lblTitlesocios_Internalname = "TITLESOCIOS";
         edtSocioId_Internalname = "SOCIOID";
         edtSocioEdad_Internalname = "SOCIOEDAD";
         edtSocioDireccion_Internalname = "SOCIODIRECCION";
         edtSocioFoto_Internalname = "SOCIOFOTO";
         divSociostable_Internalname = "SOCIOSTABLE";
         divFormcontainer_Internalname = "FORMCONTAINER";
         bttBtn_enter_Internalname = "BTN_ENTER";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         bttBtn_delete_Internalname = "BTN_DELETE";
         divMaintable_Internalname = "MAINTABLE";
         Form.Internalname = "FORM";
         imgprompt_2_Internalname = "PROMPT_2";
         imgprompt_5_Internalname = "PROMPT_5";
         subGridclase_socios_Internalname = "GRIDCLASE_SOCIOS";
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
         Form.Caption = "Clase";
         edtSocioDireccion_Jsonclick = "";
         edtSocioEdad_Jsonclick = "";
         imgprompt_5_Visible = 1;
         imgprompt_5_Link = "";
         imgprompt_2_Visible = 1;
         edtSocioId_Jsonclick = "";
         subGridclase_socios_Class = "Grid";
         subGridclase_socios_Backcolorstyle = 0;
         subGridclase_socios_Allowcollapsing = 0;
         subGridclase_socios_Allowselection = 0;
         edtSocioFoto_Enabled = 0;
         edtSocioDireccion_Enabled = 0;
         edtSocioEdad_Enabled = 0;
         edtSocioId_Enabled = 1;
         subGridclase_socios_Header = "";
         bttBtn_delete_Enabled = 0;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edtProfesorNombre_Jsonclick = "";
         edtProfesorNombre_Enabled = 0;
         imgprompt_2_Visible = 1;
         imgprompt_2_Link = "";
         edtProfesorId_Jsonclick = "";
         edtProfesorId_Enabled = 1;
         edtActividadDescripcion_Jsonclick = "";
         edtActividadDescripcion_Enabled = 0;
         edtActividadId_Jsonclick = "";
         edtActividadId_Enabled = 0;
         edtClaseId_Jsonclick = "";
         edtClaseId_Enabled = 1;
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

      protected void GX3ASACLASEID0412( short AV15ClaseId ,
                                        short Gx_BScreen )
      {
         if ( ! (0==AV15ClaseId) )
         {
            A3ClaseId = AV15ClaseId;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3ClaseId", StringUtil.LTrim( StringUtil.Str( (decimal)(A3ClaseId), 4, 0)));
         }
         else
         {
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && (0==A3ClaseId) && ( Gx_BScreen == 0 ) )
            {
               GXt_int1 = A3ClaseId;
               new ultimoidclase(context ).execute( out  GXt_int1) ;
               A3ClaseId = GXt_int1;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3ClaseId", StringUtil.LTrim( StringUtil.Str( (decimal)(A3ClaseId), 4, 0)));
            }
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A3ClaseId), 4, 0, ".", "")))+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void gxnrGridclase_socios_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         Gx_mode = "INS";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         SubsflControlProps_6313( ) ;
         while ( nGXsfl_63_idx <= nRC_GXsfl_63 )
         {
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            standaloneNotModal0413( ) ;
            standaloneModal0413( ) ;
            init_web_controls( ) ;
            dynload_actions( ) ;
            SendRow0413( ) ;
            nGXsfl_63_idx = (short)(nGXsfl_63_idx+1);
            sGXsfl_63_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_63_idx), 4, 0)), 4, "0");
            SubsflControlProps_6313( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( Gridclase_sociosContainer));
         /* End function gxnrGridclase_socios_newrow */
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
         /* Using cursor T000419 */
         pr_default.execute(17, new Object[] {A1ActividadId});
         if ( (pr_default.getStatus(17) == 101) )
         {
            GX_msglist.addItem("No matching 'Actividad'.", "ForeignKeyNotFound", 1, "");
            AnyError = 1;
         }
         A13ActividadDescripcion = T000419_A13ActividadDescripcion[0];
         pr_default.close(17);
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

      public void Valid_Profesorid( short GX_Parm1 ,
                                    String GX_Parm2 ,
                                    short GX_Parm3 )
      {
         A2ProfesorId = GX_Parm1;
         A15ProfesorNombre = GX_Parm2;
         A1ActividadId = GX_Parm3;
         /* Using cursor T000418 */
         pr_default.execute(16, new Object[] {A2ProfesorId});
         if ( (pr_default.getStatus(16) == 101) )
         {
            GX_msglist.addItem("No matching 'Profesor'.", "ForeignKeyNotFound", 1, "PROFESORID");
            AnyError = 1;
            GX_FocusControl = edtProfesorId_Internalname;
         }
         A15ProfesorNombre = T000418_A15ProfesorNombre[0];
         A1ActividadId = T000418_A1ActividadId[0];
         pr_default.close(16);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A15ProfesorNombre = "";
            A1ActividadId = 0;
         }
         isValidOutput.Add(StringUtil.RTrim( A15ProfesorNombre));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(A1ActividadId), 4, 0, ".", "")));
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         isValidOutput.Add(context.httpAjaxContext.ajax_rsp_get_hiddens( ));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public void Valid_Socioid( short GX_Parm1 ,
                                 short GX_Parm2 ,
                                 String GX_Parm3 ,
                                 String GX_Parm4 ,
                                 String GX_Parm5 )
      {
         A5SocioId = GX_Parm1;
         A20SocioEdad = GX_Parm2;
         A18SocioDireccion = GX_Parm3;
         A21SocioFoto = GX_Parm4;
         A40000SocioFoto_GXI = GX_Parm5;
         /* Using cursor T000426 */
         pr_default.execute(24, new Object[] {A5SocioId});
         if ( (pr_default.getStatus(24) == 101) )
         {
            GX_msglist.addItem("No matching 'Socio'.", "ForeignKeyNotFound", 1, "SOCIOID");
            AnyError = 1;
            GX_FocusControl = edtSocioId_Internalname;
         }
         A20SocioEdad = T000426_A20SocioEdad[0];
         A18SocioDireccion = T000426_A18SocioDireccion[0];
         A40000SocioFoto_GXI = T000426_A40000SocioFoto_GXI[0];
         A21SocioFoto = T000426_A21SocioFoto[0];
         pr_default.close(24);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A20SocioEdad = 0;
            A18SocioDireccion = "";
            A21SocioFoto = "";
            A40000SocioFoto_GXI = "";
         }
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(A20SocioEdad), 4, 0, ".", "")));
         isValidOutput.Add(A18SocioDireccion);
         isValidOutput.Add(context.PathToRelativeUrl( A21SocioFoto));
         isValidOutput.Add(A21SocioFoto);
         isValidOutput.Add(A40000SocioFoto_GXI);
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
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV15ClaseId',fld:'vCLASEID',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV15ClaseId',fld:'vCLASEID',pic:'ZZZ9',hsh:true},{av:'AV11Insert_ProfesorId',fld:'vINSERT_PROFESORID',pic:'ZZZ9'}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("AFTER TRN","{handler:'E12042',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV9TrnContext',fld:'vTRNCONTEXT',pic:''}]");
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
         pr_default.close(24);
         pr_default.close(4);
         pr_default.close(16);
         pr_default.close(17);
      }

      public override void initialize( )
      {
         sPrefix = "";
         wcpOGx_mode = "";
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
         A13ActividadDescripcion = "";
         sImgUrl = "";
         A15ProfesorNombre = "";
         lblTitlesocios_Jsonclick = "";
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         Gridclase_sociosContainer = new GXWebGrid( context);
         Gridclase_sociosColumn = new GXWebColumn();
         A18SocioDireccion = "";
         A21SocioFoto = "";
         sMode13 = "";
         sStyleString = "";
         AV17Pgmname = "";
         A40000SocioFoto_GXI = "";
         forbiddenHiddens = "";
         hsh = "";
         sMode12 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         GXCCtl = "";
         AV9TrnContext = new SdtTransactionContext(context);
         AV10WebSession = context.GetSession();
         AV12TrnContextAtt = new SdtTransactionContext_Attribute(context);
         Z15ProfesorNombre = "";
         Z13ActividadDescripcion = "";
         T00047_A15ProfesorNombre = new String[] {""} ;
         T00047_A1ActividadId = new short[1] ;
         T00048_A13ActividadDescripcion = new String[] {""} ;
         T00049_A3ClaseId = new short[1] ;
         T00049_A13ActividadDescripcion = new String[] {""} ;
         T00049_A15ProfesorNombre = new String[] {""} ;
         T00049_A2ProfesorId = new short[1] ;
         T00049_A1ActividadId = new short[1] ;
         T000410_A15ProfesorNombre = new String[] {""} ;
         T000410_A1ActividadId = new short[1] ;
         T000411_A13ActividadDescripcion = new String[] {""} ;
         T000412_A3ClaseId = new short[1] ;
         T00046_A3ClaseId = new short[1] ;
         T00046_A2ProfesorId = new short[1] ;
         T000413_A3ClaseId = new short[1] ;
         T000414_A3ClaseId = new short[1] ;
         T00045_A3ClaseId = new short[1] ;
         T00045_A2ProfesorId = new short[1] ;
         T000418_A15ProfesorNombre = new String[] {""} ;
         T000418_A1ActividadId = new short[1] ;
         T000419_A13ActividadDescripcion = new String[] {""} ;
         T000420_A3ClaseId = new short[1] ;
         Z18SocioDireccion = "";
         Z21SocioFoto = "";
         Z40000SocioFoto_GXI = "";
         T000421_A3ClaseId = new short[1] ;
         T000421_A20SocioEdad = new short[1] ;
         T000421_A18SocioDireccion = new String[] {""} ;
         T000421_A40000SocioFoto_GXI = new String[] {""} ;
         T000421_A5SocioId = new short[1] ;
         T000421_A21SocioFoto = new String[] {""} ;
         T00044_A20SocioEdad = new short[1] ;
         T00044_A18SocioDireccion = new String[] {""} ;
         T00044_A40000SocioFoto_GXI = new String[] {""} ;
         T00044_A21SocioFoto = new String[] {""} ;
         T000422_A20SocioEdad = new short[1] ;
         T000422_A18SocioDireccion = new String[] {""} ;
         T000422_A40000SocioFoto_GXI = new String[] {""} ;
         T000422_A21SocioFoto = new String[] {""} ;
         T000423_A3ClaseId = new short[1] ;
         T000423_A5SocioId = new short[1] ;
         T00043_A3ClaseId = new short[1] ;
         T00043_A5SocioId = new short[1] ;
         T00042_A3ClaseId = new short[1] ;
         T00042_A5SocioId = new short[1] ;
         T000426_A20SocioEdad = new short[1] ;
         T000426_A18SocioDireccion = new String[] {""} ;
         T000426_A40000SocioFoto_GXI = new String[] {""} ;
         T000426_A21SocioFoto = new String[] {""} ;
         T000427_A3ClaseId = new short[1] ;
         T000427_A5SocioId = new short[1] ;
         Gridclase_sociosRow = new GXWebRow();
         subGridclase_socios_Linesclass = "";
         ROClassString = "";
         GXCCtlgxBlob = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         isValidOutput = new GxUnknownObjectCollection();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.clase__default(),
            new Object[][] {
                new Object[] {
               T00042_A3ClaseId, T00042_A5SocioId
               }
               , new Object[] {
               T00043_A3ClaseId, T00043_A5SocioId
               }
               , new Object[] {
               T00044_A20SocioEdad, T00044_A18SocioDireccion, T00044_A40000SocioFoto_GXI, T00044_A21SocioFoto
               }
               , new Object[] {
               T00045_A3ClaseId, T00045_A2ProfesorId
               }
               , new Object[] {
               T00046_A3ClaseId, T00046_A2ProfesorId
               }
               , new Object[] {
               T00047_A15ProfesorNombre, T00047_A1ActividadId
               }
               , new Object[] {
               T00048_A13ActividadDescripcion
               }
               , new Object[] {
               T00049_A3ClaseId, T00049_A13ActividadDescripcion, T00049_A15ProfesorNombre, T00049_A2ProfesorId, T00049_A1ActividadId
               }
               , new Object[] {
               T000410_A15ProfesorNombre, T000410_A1ActividadId
               }
               , new Object[] {
               T000411_A13ActividadDescripcion
               }
               , new Object[] {
               T000412_A3ClaseId
               }
               , new Object[] {
               T000413_A3ClaseId
               }
               , new Object[] {
               T000414_A3ClaseId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000418_A15ProfesorNombre, T000418_A1ActividadId
               }
               , new Object[] {
               T000419_A13ActividadDescripcion
               }
               , new Object[] {
               T000420_A3ClaseId
               }
               , new Object[] {
               T000421_A3ClaseId, T000421_A20SocioEdad, T000421_A18SocioDireccion, T000421_A40000SocioFoto_GXI, T000421_A5SocioId, T000421_A21SocioFoto
               }
               , new Object[] {
               T000422_A20SocioEdad, T000422_A18SocioDireccion, T000422_A40000SocioFoto_GXI, T000422_A21SocioFoto
               }
               , new Object[] {
               T000423_A3ClaseId, T000423_A5SocioId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000426_A20SocioEdad, T000426_A18SocioDireccion, T000426_A40000SocioFoto_GXI, T000426_A21SocioFoto
               }
               , new Object[] {
               T000427_A3ClaseId, T000427_A5SocioId
               }
            }
         );
         AV17Pgmname = "Clase";
         Z3ClaseId = new ultimoidclase(context).executeUdp( );
         A3ClaseId = new ultimoidclase(context).executeUdp( );
      }

      private short nIsMod_13 ;
      private short wcpOAV15ClaseId ;
      private short Z3ClaseId ;
      private short Z2ProfesorId ;
      private short nRC_GXsfl_63 ;
      private short nGXsfl_63_idx=1 ;
      private short N2ProfesorId ;
      private short Z5SocioId ;
      private short nRcdDeleted_13 ;
      private short nRcdExists_13 ;
      private short GxWebError ;
      private short AV15ClaseId ;
      private short Gx_BScreen ;
      private short A2ProfesorId ;
      private short A1ActividadId ;
      private short A5SocioId ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short A3ClaseId ;
      private short subGridclase_socios_Backcolorstyle ;
      private short A20SocioEdad ;
      private short subGridclase_socios_Allowselection ;
      private short subGridclase_socios_Allowhovering ;
      private short subGridclase_socios_Allowcollapsing ;
      private short subGridclase_socios_Collapsed ;
      private short nBlankRcdCount13 ;
      private short RcdFound13 ;
      private short nBlankRcdUsr13 ;
      private short AV11Insert_ProfesorId ;
      private short RcdFound12 ;
      private short GX_JID ;
      private short Z1ActividadId ;
      private short Z20SocioEdad ;
      private short subGridclase_socios_Backstyle ;
      private short gxajaxcallmode ;
      private short GXt_int1 ;
      private short wbTemp ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int edtClaseId_Enabled ;
      private int edtActividadId_Enabled ;
      private int edtActividadDescripcion_Enabled ;
      private int edtProfesorId_Enabled ;
      private int imgprompt_2_Visible ;
      private int edtProfesorNombre_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int edtSocioId_Enabled ;
      private int edtSocioEdad_Enabled ;
      private int edtSocioDireccion_Enabled ;
      private int edtSocioFoto_Enabled ;
      private int subGridclase_socios_Selectedindex ;
      private int subGridclase_socios_Selectioncolor ;
      private int subGridclase_socios_Hoveringcolor ;
      private int fRowAdded ;
      private int AV18GXV1 ;
      private int subGridclase_socios_Backcolor ;
      private int subGridclase_socios_Allbackcolor ;
      private int imgprompt_5_Visible ;
      private int defedtSocioId_Enabled ;
      private int idxLst ;
      private long GRIDCLASE_SOCIOS_nFirstRecordOnPage ;
      private String sPrefix ;
      private String sGXsfl_63_idx="0001" ;
      private String wcpOGx_mode ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String Gx_mode ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtClaseId_Internalname ;
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
      private String edtClaseId_Jsonclick ;
      private String edtActividadId_Internalname ;
      private String edtActividadId_Jsonclick ;
      private String edtActividadDescripcion_Internalname ;
      private String A13ActividadDescripcion ;
      private String edtActividadDescripcion_Jsonclick ;
      private String edtProfesorId_Internalname ;
      private String edtProfesorId_Jsonclick ;
      private String sImgUrl ;
      private String imgprompt_2_Internalname ;
      private String imgprompt_2_Link ;
      private String edtProfesorNombre_Internalname ;
      private String A15ProfesorNombre ;
      private String edtProfesorNombre_Jsonclick ;
      private String divSociostable_Internalname ;
      private String lblTitlesocios_Internalname ;
      private String lblTitlesocios_Jsonclick ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String subGridclase_socios_Header ;
      private String sMode13 ;
      private String edtSocioId_Internalname ;
      private String edtSocioEdad_Internalname ;
      private String edtSocioDireccion_Internalname ;
      private String edtSocioFoto_Internalname ;
      private String sStyleString ;
      private String AV17Pgmname ;
      private String forbiddenHiddens ;
      private String hsh ;
      private String sMode12 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String GXCCtl ;
      private String Z15ProfesorNombre ;
      private String Z13ActividadDescripcion ;
      private String imgprompt_5_Internalname ;
      private String sGXsfl_63_fel_idx="0001" ;
      private String subGridclase_socios_Class ;
      private String subGridclase_socios_Linesclass ;
      private String imgprompt_5_Link ;
      private String ROClassString ;
      private String edtSocioId_Jsonclick ;
      private String edtSocioEdad_Jsonclick ;
      private String edtSocioDireccion_Jsonclick ;
      private String GXCCtlgxBlob ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String subGridclase_socios_Internalname ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool bGXsfl_63_Refreshing=false ;
      private bool returnInSub ;
      private bool A21SocioFoto_IsBlob ;
      private String A18SocioDireccion ;
      private String A40000SocioFoto_GXI ;
      private String Z18SocioDireccion ;
      private String Z40000SocioFoto_GXI ;
      private String A21SocioFoto ;
      private String Z21SocioFoto ;
      private IGxSession AV10WebSession ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXWebGrid Gridclase_sociosContainer ;
      private GXWebRow Gridclase_sociosRow ;
      private GXWebColumn Gridclase_sociosColumn ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] T00047_A15ProfesorNombre ;
      private short[] T00047_A1ActividadId ;
      private String[] T00048_A13ActividadDescripcion ;
      private short[] T00049_A3ClaseId ;
      private String[] T00049_A13ActividadDescripcion ;
      private String[] T00049_A15ProfesorNombre ;
      private short[] T00049_A2ProfesorId ;
      private short[] T00049_A1ActividadId ;
      private String[] T000410_A15ProfesorNombre ;
      private short[] T000410_A1ActividadId ;
      private String[] T000411_A13ActividadDescripcion ;
      private short[] T000412_A3ClaseId ;
      private short[] T00046_A3ClaseId ;
      private short[] T00046_A2ProfesorId ;
      private short[] T000413_A3ClaseId ;
      private short[] T000414_A3ClaseId ;
      private short[] T00045_A3ClaseId ;
      private short[] T00045_A2ProfesorId ;
      private String[] T000418_A15ProfesorNombre ;
      private short[] T000418_A1ActividadId ;
      private String[] T000419_A13ActividadDescripcion ;
      private short[] T000420_A3ClaseId ;
      private short[] T000421_A3ClaseId ;
      private short[] T000421_A20SocioEdad ;
      private String[] T000421_A18SocioDireccion ;
      private String[] T000421_A40000SocioFoto_GXI ;
      private short[] T000421_A5SocioId ;
      private String[] T000421_A21SocioFoto ;
      private short[] T00044_A20SocioEdad ;
      private String[] T00044_A18SocioDireccion ;
      private String[] T00044_A40000SocioFoto_GXI ;
      private String[] T00044_A21SocioFoto ;
      private short[] T000422_A20SocioEdad ;
      private String[] T000422_A18SocioDireccion ;
      private String[] T000422_A40000SocioFoto_GXI ;
      private String[] T000422_A21SocioFoto ;
      private short[] T000423_A3ClaseId ;
      private short[] T000423_A5SocioId ;
      private short[] T00043_A3ClaseId ;
      private short[] T00043_A5SocioId ;
      private short[] T00042_A3ClaseId ;
      private short[] T00042_A5SocioId ;
      private short[] T000426_A20SocioEdad ;
      private String[] T000426_A18SocioDireccion ;
      private String[] T000426_A40000SocioFoto_GXI ;
      private String[] T000426_A21SocioFoto ;
      private short[] T000427_A3ClaseId ;
      private short[] T000427_A5SocioId ;
      private GXWebForm Form ;
      private SdtTransactionContext AV9TrnContext ;
      private SdtTransactionContext_Attribute AV12TrnContextAtt ;
   }

   public class clase__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new ForEachCursor(def[8])
         ,new ForEachCursor(def[9])
         ,new ForEachCursor(def[10])
         ,new ForEachCursor(def[11])
         ,new ForEachCursor(def[12])
         ,new UpdateCursor(def[13])
         ,new UpdateCursor(def[14])
         ,new UpdateCursor(def[15])
         ,new ForEachCursor(def[16])
         ,new ForEachCursor(def[17])
         ,new ForEachCursor(def[18])
         ,new ForEachCursor(def[19])
         ,new ForEachCursor(def[20])
         ,new ForEachCursor(def[21])
         ,new UpdateCursor(def[22])
         ,new UpdateCursor(def[23])
         ,new ForEachCursor(def[24])
         ,new ForEachCursor(def[25])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT00049 ;
          prmT00049 = new Object[] {
          new Object[] {"@ClaseId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00047 ;
          prmT00047 = new Object[] {
          new Object[] {"@ProfesorId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00048 ;
          prmT00048 = new Object[] {
          new Object[] {"@ActividadId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000410 ;
          prmT000410 = new Object[] {
          new Object[] {"@ProfesorId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000411 ;
          prmT000411 = new Object[] {
          new Object[] {"@ActividadId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000412 ;
          prmT000412 = new Object[] {
          new Object[] {"@ClaseId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00046 ;
          prmT00046 = new Object[] {
          new Object[] {"@ClaseId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000413 ;
          prmT000413 = new Object[] {
          new Object[] {"@ClaseId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000414 ;
          prmT000414 = new Object[] {
          new Object[] {"@ClaseId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00045 ;
          prmT00045 = new Object[] {
          new Object[] {"@ClaseId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000415 ;
          prmT000415 = new Object[] {
          new Object[] {"@ClaseId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ProfesorId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000416 ;
          prmT000416 = new Object[] {
          new Object[] {"@ProfesorId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ClaseId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000417 ;
          prmT000417 = new Object[] {
          new Object[] {"@ClaseId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000420 ;
          prmT000420 = new Object[] {
          } ;
          Object[] prmT000421 ;
          prmT000421 = new Object[] {
          new Object[] {"@ClaseId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@SocioId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00044 ;
          prmT00044 = new Object[] {
          new Object[] {"@SocioId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000422 ;
          prmT000422 = new Object[] {
          new Object[] {"@SocioId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000423 ;
          prmT000423 = new Object[] {
          new Object[] {"@ClaseId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@SocioId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00043 ;
          prmT00043 = new Object[] {
          new Object[] {"@ClaseId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@SocioId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00042 ;
          prmT00042 = new Object[] {
          new Object[] {"@ClaseId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@SocioId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000424 ;
          prmT000424 = new Object[] {
          new Object[] {"@ClaseId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@SocioId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000425 ;
          prmT000425 = new Object[] {
          new Object[] {"@ClaseId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@SocioId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000427 ;
          prmT000427 = new Object[] {
          new Object[] {"@ClaseId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000419 ;
          prmT000419 = new Object[] {
          new Object[] {"@ActividadId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000418 ;
          prmT000418 = new Object[] {
          new Object[] {"@ProfesorId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000426 ;
          prmT000426 = new Object[] {
          new Object[] {"@SocioId",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T00042", "SELECT [ClaseId], [SocioId] FROM [ClaseSocios] WITH (UPDLOCK) WHERE [ClaseId] = @ClaseId AND [SocioId] = @SocioId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00042,1,0,true,false )
             ,new CursorDef("T00043", "SELECT [ClaseId], [SocioId] FROM [ClaseSocios] WITH (NOLOCK) WHERE [ClaseId] = @ClaseId AND [SocioId] = @SocioId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00043,1,0,true,false )
             ,new CursorDef("T00044", "SELECT [SocioEdad], [SocioDireccion], [SocioFoto_GXI], [SocioFoto] FROM [Socio] WITH (NOLOCK) WHERE [SocioId] = @SocioId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00044,1,0,true,false )
             ,new CursorDef("T00045", "SELECT [ClaseId], [ProfesorId] FROM [Clase] WITH (UPDLOCK) WHERE [ClaseId] = @ClaseId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00045,1,0,true,false )
             ,new CursorDef("T00046", "SELECT [ClaseId], [ProfesorId] FROM [Clase] WITH (NOLOCK) WHERE [ClaseId] = @ClaseId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00046,1,0,true,false )
             ,new CursorDef("T00047", "SELECT [ProfesorNombre], [ActividadId] FROM [Profesor] WITH (NOLOCK) WHERE [ProfesorId] = @ProfesorId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00047,1,0,true,false )
             ,new CursorDef("T00048", "SELECT [ActividadDescripcion] FROM [Actividad1] WITH (NOLOCK) WHERE [ActividadId] = @ActividadId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00048,1,0,true,false )
             ,new CursorDef("T00049", "SELECT TM1.[ClaseId], T3.[ActividadDescripcion], T2.[ProfesorNombre], TM1.[ProfesorId], T2.[ActividadId] FROM (([Clase] TM1 WITH (NOLOCK) INNER JOIN [Profesor] T2 WITH (NOLOCK) ON T2.[ProfesorId] = TM1.[ProfesorId]) INNER JOIN [Actividad1] T3 WITH (NOLOCK) ON T3.[ActividadId] = T2.[ActividadId]) WHERE TM1.[ClaseId] = @ClaseId ORDER BY TM1.[ClaseId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00049,100,0,true,false )
             ,new CursorDef("T000410", "SELECT [ProfesorNombre], [ActividadId] FROM [Profesor] WITH (NOLOCK) WHERE [ProfesorId] = @ProfesorId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000410,1,0,true,false )
             ,new CursorDef("T000411", "SELECT [ActividadDescripcion] FROM [Actividad1] WITH (NOLOCK) WHERE [ActividadId] = @ActividadId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000411,1,0,true,false )
             ,new CursorDef("T000412", "SELECT [ClaseId] FROM [Clase] WITH (NOLOCK) WHERE [ClaseId] = @ClaseId  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000412,1,0,true,false )
             ,new CursorDef("T000413", "SELECT TOP 1 [ClaseId] FROM [Clase] WITH (NOLOCK) WHERE ( [ClaseId] > @ClaseId) ORDER BY [ClaseId]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000413,1,0,true,true )
             ,new CursorDef("T000414", "SELECT TOP 1 [ClaseId] FROM [Clase] WITH (NOLOCK) WHERE ( [ClaseId] < @ClaseId) ORDER BY [ClaseId] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000414,1,0,true,true )
             ,new CursorDef("T000415", "INSERT INTO [Clase]([ClaseId], [ProfesorId]) VALUES(@ClaseId, @ProfesorId)", GxErrorMask.GX_NOMASK,prmT000415)
             ,new CursorDef("T000416", "UPDATE [Clase] SET [ProfesorId]=@ProfesorId  WHERE [ClaseId] = @ClaseId", GxErrorMask.GX_NOMASK,prmT000416)
             ,new CursorDef("T000417", "DELETE FROM [Clase]  WHERE [ClaseId] = @ClaseId", GxErrorMask.GX_NOMASK,prmT000417)
             ,new CursorDef("T000418", "SELECT [ProfesorNombre], [ActividadId] FROM [Profesor] WITH (NOLOCK) WHERE [ProfesorId] = @ProfesorId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000418,1,0,true,false )
             ,new CursorDef("T000419", "SELECT [ActividadDescripcion] FROM [Actividad1] WITH (NOLOCK) WHERE [ActividadId] = @ActividadId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000419,1,0,true,false )
             ,new CursorDef("T000420", "SELECT [ClaseId] FROM [Clase] WITH (NOLOCK) ORDER BY [ClaseId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000420,100,0,true,false )
             ,new CursorDef("T000421", "SELECT T1.[ClaseId], T2.[SocioEdad], T2.[SocioDireccion], T2.[SocioFoto_GXI], T1.[SocioId], T2.[SocioFoto] FROM ([ClaseSocios] T1 WITH (NOLOCK) INNER JOIN [Socio] T2 WITH (NOLOCK) ON T2.[SocioId] = T1.[SocioId]) WHERE T1.[ClaseId] = @ClaseId and T1.[SocioId] = @SocioId ORDER BY T1.[ClaseId], T1.[SocioId] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000421,11,0,true,false )
             ,new CursorDef("T000422", "SELECT [SocioEdad], [SocioDireccion], [SocioFoto_GXI], [SocioFoto] FROM [Socio] WITH (NOLOCK) WHERE [SocioId] = @SocioId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000422,1,0,true,false )
             ,new CursorDef("T000423", "SELECT [ClaseId], [SocioId] FROM [ClaseSocios] WITH (NOLOCK) WHERE [ClaseId] = @ClaseId AND [SocioId] = @SocioId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000423,1,0,true,false )
             ,new CursorDef("T000424", "INSERT INTO [ClaseSocios]([ClaseId], [SocioId]) VALUES(@ClaseId, @SocioId)", GxErrorMask.GX_NOMASK,prmT000424)
             ,new CursorDef("T000425", "DELETE FROM [ClaseSocios]  WHERE [ClaseId] = @ClaseId AND [SocioId] = @SocioId", GxErrorMask.GX_NOMASK,prmT000425)
             ,new CursorDef("T000426", "SELECT [SocioEdad], [SocioDireccion], [SocioFoto_GXI], [SocioFoto] FROM [Socio] WITH (NOLOCK) WHERE [SocioId] = @SocioId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000426,1,0,true,false )
             ,new CursorDef("T000427", "SELECT [ClaseId], [SocioId] FROM [ClaseSocios] WITH (NOLOCK) WHERE [ClaseId] = @ClaseId ORDER BY [ClaseId], [SocioId] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000427,11,0,true,false )
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
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                return;
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getMultimediaUri(3) ;
                ((String[]) buf[3])[0] = rslt.getMultimediaFile(4, rslt.getVarchar(3)) ;
                return;
             case 3 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                return;
             case 4 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                return;
             case 5 :
                ((String[]) buf[0])[0] = rslt.getString(1, 20) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                return;
             case 6 :
                ((String[]) buf[0])[0] = rslt.getString(1, 20) ;
                return;
             case 7 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 20) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 20) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                return;
             case 8 :
                ((String[]) buf[0])[0] = rslt.getString(1, 20) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                return;
             case 9 :
                ((String[]) buf[0])[0] = rslt.getString(1, 20) ;
                return;
             case 10 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 11 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 12 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 16 :
                ((String[]) buf[0])[0] = rslt.getString(1, 20) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                return;
             case 17 :
                ((String[]) buf[0])[0] = rslt.getString(1, 20) ;
                return;
             case 18 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 19 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getMultimediaUri(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((String[]) buf[5])[0] = rslt.getMultimediaFile(6, rslt.getVarchar(4)) ;
                return;
             case 20 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getMultimediaUri(3) ;
                ((String[]) buf[3])[0] = rslt.getMultimediaFile(4, rslt.getVarchar(3)) ;
                return;
             case 21 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                return;
             case 24 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getMultimediaUri(3) ;
                ((String[]) buf[3])[0] = rslt.getMultimediaFile(4, rslt.getVarchar(3)) ;
                return;
             case 25 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
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
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
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
                return;
             case 9 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 10 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 11 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 12 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 13 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 14 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 15 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 16 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 17 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 19 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 20 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 21 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 22 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 23 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 24 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 25 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
       }
    }

 }

}
