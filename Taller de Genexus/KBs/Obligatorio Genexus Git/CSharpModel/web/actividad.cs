/*
               File: Actividad
        Description: Actividad
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 3/22/2019 19:1:12.7
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
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class actividad : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_6") == 0 )
         {
            A5SocioId = (short)(NumberUtil.Val( GetNextPar( ), "."));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_6( A5SocioId) ;
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Gridactividad_socioenactividad") == 0 )
         {
            nRC_GXsfl_53 = (short)(NumberUtil.Val( GetNextPar( ), "."));
            nGXsfl_53_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
            sGXsfl_53_idx = GetNextPar( );
            Gx_mode = GetNextPar( );
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxnrGridactividad_socioenactividad_newrow( ) ;
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
               AV7ActividadId = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7ActividadId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7ActividadId), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vACTIVIDADID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7ActividadId), "ZZZ9"), context));
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
            Form.Meta.addItem("description", "Actividad", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtActividadId_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("Carmine");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public actividad( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public actividad( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( String aP0_Gx_mode ,
                           short aP1_ActividadId )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV7ActividadId = aP1_ActividadId;
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
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "Actividad", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_Actividad.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "", bttBtn_first_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_first_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Actividad.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "", bttBtn_previous_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_previous_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_Actividad.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", "", bttBtn_next_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_next_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_Actividad.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", "", bttBtn_last_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_last_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Actividad.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Select", bttBtn_select_Jsonclick, 5, "Select", "", StyleString, ClassString, bttBtn_select_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "", 2, "HLP_Actividad.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtActividadId_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtActividadId_Internalname, "Id", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtActividadId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A1ActividadId), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A1ActividadId), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,34);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtActividadId_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtActividadId_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Actividad.htm");
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
            GxWebStd.gx_label_element( context, edtActividadDescripcion_Internalname, "Descripcion", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtActividadDescripcion_Internalname, StringUtil.RTrim( A13ActividadDescripcion), StringUtil.RTrim( context.localUtil.Format( A13ActividadDescripcion, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,39);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtActividadDescripcion_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtActividadDescripcion_Enabled, 0, "text", "", 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Actividad.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtActividadTipo_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtActividadTipo_Internalname, "Tipo", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtActividadTipo_Internalname, StringUtil.RTrim( A14ActividadTipo), StringUtil.RTrim( context.localUtil.Format( A14ActividadTipo, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,44);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtActividadTipo_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtActividadTipo_Enabled, 0, "text", "", 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Actividad.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 LevelTable", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divSocioenactividadtable_Internalname, 1, 0, "px", 0, "px", "LevelTable", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTitlesocioenactividad_Internalname, "Socio En Actividad", "", "", lblTitlesocioenactividad_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_Actividad.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            gxdraw_Gridactividad_socioenactividad( ) ;
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 64,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirm", bttBtn_enter_Jsonclick, 5, "Confirm", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_Actividad.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 66,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancel", bttBtn_cancel_Jsonclick, 1, "Cancel", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Actividad.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 68,'',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Delete", bttBtn_delete_Jsonclick, 5, "Delete", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_Actividad.htm");
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

      protected void gxdraw_Gridactividad_socioenactividad( )
      {
         /*  Grid Control  */
         Gridactividad_socioenactividadContainer.AddObjectProperty("GridName", "Gridactividad_socioenactividad");
         Gridactividad_socioenactividadContainer.AddObjectProperty("Header", subGridactividad_socioenactividad_Header);
         Gridactividad_socioenactividadContainer.AddObjectProperty("Class", "Grid");
         Gridactividad_socioenactividadContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         Gridactividad_socioenactividadContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
         Gridactividad_socioenactividadContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridactividad_socioenactividad_Backcolorstyle), 1, 0, ".", "")));
         Gridactividad_socioenactividadContainer.AddObjectProperty("CmpContext", "");
         Gridactividad_socioenactividadContainer.AddObjectProperty("InMasterPage", "false");
         Gridactividad_socioenactividadColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridactividad_socioenactividadColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A5SocioId), 4, 0, ".", "")));
         Gridactividad_socioenactividadColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSocioId_Enabled), 5, 0, ".", "")));
         Gridactividad_socioenactividadContainer.AddColumnProperties(Gridactividad_socioenactividadColumn);
         Gridactividad_socioenactividadColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridactividad_socioenactividadContainer.AddColumnProperties(Gridactividad_socioenactividadColumn);
         Gridactividad_socioenactividadColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridactividad_socioenactividadColumn.AddObjectProperty("Value", A18SocioDireccion);
         Gridactividad_socioenactividadColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSocioDireccion_Enabled), 5, 0, ".", "")));
         Gridactividad_socioenactividadContainer.AddColumnProperties(Gridactividad_socioenactividadColumn);
         Gridactividad_socioenactividadColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridactividad_socioenactividadColumn.AddObjectProperty("Value", context.convertURL( A21SocioFoto));
         Gridactividad_socioenactividadColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSocioFoto_Enabled), 5, 0, ".", "")));
         Gridactividad_socioenactividadContainer.AddColumnProperties(Gridactividad_socioenactividadColumn);
         Gridactividad_socioenactividadColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridactividad_socioenactividadColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A20SocioEdad), 4, 0, ".", "")));
         Gridactividad_socioenactividadColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSocioEdad_Enabled), 5, 0, ".", "")));
         Gridactividad_socioenactividadContainer.AddColumnProperties(Gridactividad_socioenactividadColumn);
         Gridactividad_socioenactividadColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridactividad_socioenactividadColumn.AddObjectProperty("Value", StringUtil.RTrim( A24SocioReconocido));
         Gridactividad_socioenactividadColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSocioReconocido_Enabled), 5, 0, ".", "")));
         Gridactividad_socioenactividadContainer.AddColumnProperties(Gridactividad_socioenactividadColumn);
         Gridactividad_socioenactividadColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridactividad_socioenactividadColumn.AddObjectProperty("Value", StringUtil.RTrim( A19SocioSexo));
         Gridactividad_socioenactividadColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSocioSexo_Enabled), 5, 0, ".", "")));
         Gridactividad_socioenactividadContainer.AddColumnProperties(Gridactividad_socioenactividadColumn);
         Gridactividad_socioenactividadContainer.AddObjectProperty("Selectedindex", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridactividad_socioenactividad_Selectedindex), 4, 0, ".", "")));
         Gridactividad_socioenactividadContainer.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridactividad_socioenactividad_Allowselection), 1, 0, ".", "")));
         Gridactividad_socioenactividadContainer.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridactividad_socioenactividad_Selectioncolor), 9, 0, ".", "")));
         Gridactividad_socioenactividadContainer.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridactividad_socioenactividad_Allowhovering), 1, 0, ".", "")));
         Gridactividad_socioenactividadContainer.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridactividad_socioenactividad_Hoveringcolor), 9, 0, ".", "")));
         Gridactividad_socioenactividadContainer.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridactividad_socioenactividad_Allowcollapsing), 1, 0, ".", "")));
         Gridactividad_socioenactividadContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridactividad_socioenactividad_Collapsed), 1, 0, ".", "")));
         nGXsfl_53_idx = 0;
         if ( ( nKeyPressed == 1 ) && ( AnyError == 0 ) )
         {
            /* Enter key processing. */
            nBlankRcdCount2 = 5;
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               /* Display confirmed (stored) records */
               nRcdExists_2 = 1;
               ScanStart012( ) ;
               while ( RcdFound2 != 0 )
               {
                  init_level_properties2( ) ;
                  getByPrimaryKey012( ) ;
                  AddRow012( ) ;
                  ScanNext012( ) ;
               }
               ScanEnd012( ) ;
               nBlankRcdCount2 = 5;
            }
         }
         else if ( ( nKeyPressed == 3 ) || ( nKeyPressed == 4 ) || ( ( nKeyPressed == 1 ) && ( AnyError != 0 ) ) )
         {
            /* Button check  or addlines. */
            standaloneNotModal012( ) ;
            standaloneModal012( ) ;
            sMode2 = Gx_mode;
            while ( nGXsfl_53_idx < nRC_GXsfl_53 )
            {
               bGXsfl_53_Refreshing = true;
               ReadRow012( ) ;
               edtSocioId_Enabled = (int)(context.localUtil.CToN( cgiGet( "SOCIOID_"+sGXsfl_53_idx+"Enabled"), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSocioId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSocioId_Enabled), 5, 0)), !bGXsfl_53_Refreshing);
               edtSocioDireccion_Enabled = (int)(context.localUtil.CToN( cgiGet( "SOCIODIRECCION_"+sGXsfl_53_idx+"Enabled"), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSocioDireccion_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSocioDireccion_Enabled), 5, 0)), !bGXsfl_53_Refreshing);
               edtSocioFoto_Enabled = (int)(context.localUtil.CToN( cgiGet( "SOCIOFOTO_"+sGXsfl_53_idx+"Enabled"), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSocioFoto_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSocioFoto_Enabled), 5, 0)), !bGXsfl_53_Refreshing);
               edtSocioEdad_Enabled = (int)(context.localUtil.CToN( cgiGet( "SOCIOEDAD_"+sGXsfl_53_idx+"Enabled"), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSocioEdad_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSocioEdad_Enabled), 5, 0)), !bGXsfl_53_Refreshing);
               edtSocioReconocido_Enabled = (int)(context.localUtil.CToN( cgiGet( "SOCIORECONOCIDO_"+sGXsfl_53_idx+"Enabled"), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSocioReconocido_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSocioReconocido_Enabled), 5, 0)), !bGXsfl_53_Refreshing);
               edtSocioSexo_Enabled = (int)(context.localUtil.CToN( cgiGet( "SOCIOSEXO_"+sGXsfl_53_idx+"Enabled"), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSocioSexo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSocioSexo_Enabled), 5, 0)), !bGXsfl_53_Refreshing);
               imgprompt_5_Link = cgiGet( "PROMPT_5_"+sGXsfl_53_idx+"Link");
               if ( ( nRcdExists_2 == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") != 0 ) )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  standaloneModal012( ) ;
               }
               SendRow012( ) ;
               bGXsfl_53_Refreshing = false;
            }
            Gx_mode = sMode2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            /* Get or get-alike key processing. */
            nBlankRcdCount2 = 5;
            nRcdExists_2 = 1;
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               ScanStart012( ) ;
               while ( RcdFound2 != 0 )
               {
                  sGXsfl_53_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_53_idx+1), 4, 0)), 4, "0");
                  SubsflControlProps_532( ) ;
                  init_level_properties2( ) ;
                  standaloneNotModal012( ) ;
                  getByPrimaryKey012( ) ;
                  standaloneModal012( ) ;
                  AddRow012( ) ;
                  ScanNext012( ) ;
               }
               ScanEnd012( ) ;
            }
         }
         /* Initialize fields for 'new' records and send them. */
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") != 0 ) && ( StringUtil.StrCmp(Gx_mode, "DLT") != 0 ) )
         {
            sMode2 = Gx_mode;
            Gx_mode = "INS";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            sGXsfl_53_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_53_idx+1), 4, 0)), 4, "0");
            SubsflControlProps_532( ) ;
            InitAll012( ) ;
            init_level_properties2( ) ;
            standaloneNotModal012( ) ;
            standaloneModal012( ) ;
            nRcdExists_2 = 0;
            nIsMod_2 = 0;
            nRcdDeleted_2 = 0;
            nBlankRcdCount2 = (short)(nBlankRcdUsr2+nBlankRcdCount2);
            fRowAdded = 0;
            while ( nBlankRcdCount2 > 0 )
            {
               AddRow012( ) ;
               if ( ( nKeyPressed == 4 ) && ( fRowAdded == 0 ) )
               {
                  fRowAdded = 1;
                  GX_FocusControl = edtSocioId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               nBlankRcdCount2 = (short)(nBlankRcdCount2-1);
            }
            Gx_mode = sMode2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         sStyleString = "";
         context.WriteHtmlText( "<div id=\""+"Gridactividad_socioenactividadContainer"+"Div\" "+sStyleString+">"+"</div>") ;
         context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Gridactividad_socioenactividad", Gridactividad_socioenactividadContainer);
         if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
         {
            GxWebStd.gx_hidden_field( context, "Gridactividad_socioenactividadContainerData", Gridactividad_socioenactividadContainer.ToJavascriptSource());
         }
         if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
         {
            GxWebStd.gx_hidden_field( context, "Gridactividad_socioenactividadContainerData"+"V", Gridactividad_socioenactividadContainer.GridValuesHidden());
         }
         else
         {
            context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Gridactividad_socioenactividadContainerData"+"V"+"\" value='"+Gridactividad_socioenactividadContainer.GridValuesHidden()+"'/>") ;
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
         E11012 ();
         context.wbGlbDoneStart = 1;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read variables values. */
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
               A14ActividadTipo = cgiGet( edtActividadTipo_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A14ActividadTipo", A14ActividadTipo);
               /* Read saved values. */
               Z1ActividadId = (short)(context.localUtil.CToN( cgiGet( "Z1ActividadId"), ".", ","));
               Z13ActividadDescripcion = cgiGet( "Z13ActividadDescripcion");
               Z14ActividadTipo = cgiGet( "Z14ActividadTipo");
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ","));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ".", ","));
               Gx_mode = cgiGet( "Mode");
               nRC_GXsfl_53 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_53"), ".", ","));
               AV7ActividadId = (short)(context.localUtil.CToN( cgiGet( "vACTIVIDADID"), ".", ","));
               AV11Pgmname = cgiGet( "vPGMNAME");
               Gx_mode = cgiGet( "vMODE");
               A40000SocioFoto_GXI = cgiGet( "SOCIOFOTO_GXI");
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               forbiddenHiddens = "hsh" + "Actividad";
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( A1ActividadId != Z1ActividadId ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
               {
                  GXUtil.WriteLog("actividad:[SecurityCheckFailed value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
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
                  A1ActividadId = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1ActividadId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1ActividadId), 4, 0)));
                  getEqualNoModal( ) ;
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
                     sMode1 = Gx_mode;
                     Gx_mode = "UPD";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     Gx_mode = sMode1;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound1 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_010( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtn_enter_Internalname;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert", ""), 1, "ACTIVIDADID");
                        AnyError = 1;
                        GX_FocusControl = edtActividadId_Internalname;
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
                        if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
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
                        if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 9), "AFTER TRN") == 0 ) )
                        {
                           nGXsfl_53_idx = (short)(NumberUtil.Val( sEvtType, "."));
                           sGXsfl_53_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_53_idx), 4, 0)), 4, "0");
                           SubsflControlProps_532( ) ;
                           if ( ( ( context.localUtil.CToN( cgiGet( edtSocioId_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtSocioId_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
                           {
                              GXCCtl = "SOCIOID_" + sGXsfl_53_idx;
                              GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
                              AnyError = 1;
                              GX_FocusControl = edtSocioId_Internalname;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                              wbErr = true;
                              A5SocioId = 0;
                           }
                           else
                           {
                              A5SocioId = (short)(context.localUtil.CToN( cgiGet( edtSocioId_Internalname), ".", ","));
                           }
                           A18SocioDireccion = cgiGet( edtSocioDireccion_Internalname);
                           A21SocioFoto = cgiGet( edtSocioFoto_Internalname);
                           context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSocioFoto_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A21SocioFoto)) ? A40000SocioFoto_GXI : context.convertURL( context.PathToRelativeUrl( A21SocioFoto))), !bGXsfl_53_Refreshing);
                           context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSocioFoto_Internalname, "SrcSet", context.GetImageSrcSet( A21SocioFoto), true);
                           A20SocioEdad = (short)(context.localUtil.CToN( cgiGet( edtSocioEdad_Internalname), ".", ","));
                           A24SocioReconocido = cgiGet( edtSocioReconocido_Internalname);
                           A19SocioSexo = cgiGet( edtSocioSexo_Internalname);
                           GXCCtl = "Z5SocioId_" + sGXsfl_53_idx;
                           Z5SocioId = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ","));
                           GXCCtl = "nRcdDeleted_2_" + sGXsfl_53_idx;
                           nRcdDeleted_2 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ","));
                           GXCCtl = "nRcdExists_2_" + sGXsfl_53_idx;
                           nRcdExists_2 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ","));
                           GXCCtl = "nIsMod_2_" + sGXsfl_53_idx;
                           nIsMod_2 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ","));
                           getMultimediaValue(edtSocioFoto_Internalname, ref  A21SocioFoto, ref  A40000SocioFoto_GXI);
                           sEvtType = StringUtil.Right( sEvt, 1);
                           if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                           {
                              sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                              if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 /* Execute user event: Start */
                                 E11012 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 /* Execute user event: After Trn */
                                 E12012 ();
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

      protected void AfterTrn( )
      {
         if ( trnEnded == 1 )
         {
            /* Execute user event: After Trn */
            E12012 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll011( ) ;
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
            DisableAttributes011( ) ;
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

      protected void CONFIRM_010( )
      {
         BeforeValidate011( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls011( ) ;
            }
            else
            {
               CheckExtendedTable011( ) ;
               CloseExtendedTableCursors011( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            /* Save parent mode. */
            sMode1 = Gx_mode;
            CONFIRM_012( ) ;
            if ( AnyError == 0 )
            {
               /* Restore parent mode. */
               Gx_mode = sMode1;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
               IsConfirmed = 1;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
            }
            /* Restore parent mode. */
            Gx_mode = sMode1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
      }

      protected void CONFIRM_012( )
      {
         nGXsfl_53_idx = 0;
         while ( nGXsfl_53_idx < nRC_GXsfl_53 )
         {
            ReadRow012( ) ;
            if ( ( nRcdExists_2 != 0 ) || ( nIsMod_2 != 0 ) )
            {
               GetKey012( ) ;
               if ( ( nRcdExists_2 == 0 ) && ( nRcdDeleted_2 == 0 ) )
               {
                  if ( RcdFound2 == 0 )
                  {
                     Gx_mode = "INS";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     BeforeValidate012( ) ;
                     if ( AnyError == 0 )
                     {
                        CheckExtendedTable012( ) ;
                        CloseExtendedTableCursors012( ) ;
                        if ( AnyError == 0 )
                        {
                           IsConfirmed = 1;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
                        }
                     }
                  }
                  else
                  {
                     GXCCtl = "SOCIOID_" + sGXsfl_53_idx;
                     GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, GXCCtl);
                     AnyError = 1;
                     GX_FocusControl = edtSocioId_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( RcdFound2 != 0 )
                  {
                     if ( nRcdDeleted_2 != 0 )
                     {
                        Gx_mode = "DLT";
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                        getByPrimaryKey012( ) ;
                        Load012( ) ;
                        BeforeValidate012( ) ;
                        if ( AnyError == 0 )
                        {
                           OnDeleteControls012( ) ;
                        }
                     }
                     else
                     {
                        if ( nIsMod_2 != 0 )
                        {
                           Gx_mode = "UPD";
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                           BeforeValidate012( ) ;
                           if ( AnyError == 0 )
                           {
                              CheckExtendedTable012( ) ;
                              CloseExtendedTableCursors012( ) ;
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
                     if ( nRcdDeleted_2 == 0 )
                     {
                        GXCCtl = "SOCIOID_" + sGXsfl_53_idx;
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, GXCCtl);
                        AnyError = 1;
                        GX_FocusControl = edtSocioId_Internalname;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtSocioId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A5SocioId), 4, 0, ".", ""))) ;
            ChangePostValue( edtSocioDireccion_Internalname, A18SocioDireccion) ;
            ChangePostValue( edtSocioFoto_Internalname, A21SocioFoto) ;
            ChangePostValue( edtSocioEdad_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A20SocioEdad), 4, 0, ".", ""))) ;
            ChangePostValue( edtSocioReconocido_Internalname, StringUtil.RTrim( A24SocioReconocido)) ;
            ChangePostValue( edtSocioSexo_Internalname, StringUtil.RTrim( A19SocioSexo)) ;
            ChangePostValue( "ZT_"+"Z5SocioId_"+sGXsfl_53_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z5SocioId), 4, 0, ".", ""))) ;
            ChangePostValue( "nRcdDeleted_2_"+sGXsfl_53_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_2), 4, 0, ".", ""))) ;
            ChangePostValue( "nRcdExists_2_"+sGXsfl_53_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_2), 4, 0, ".", ""))) ;
            ChangePostValue( "nIsMod_2_"+sGXsfl_53_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_2), 4, 0, ".", ""))) ;
            if ( nIsMod_2 != 0 )
            {
               ChangePostValue( "SOCIOID_"+sGXsfl_53_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSocioId_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SOCIODIRECCION_"+sGXsfl_53_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSocioDireccion_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SOCIOFOTO_"+sGXsfl_53_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSocioFoto_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SOCIOEDAD_"+sGXsfl_53_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSocioEdad_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SOCIORECONOCIDO_"+sGXsfl_53_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSocioReconocido_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SOCIOSEXO_"+sGXsfl_53_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSocioSexo_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
      }

      protected void ResetCaption010( )
      {
      }

      protected void E11012( )
      {
         /* Start Routine */
         if ( ! new isauthorized(context).executeUdp(  AV11Pgmname) )
         {
            CallWebObject(formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV11Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         AV9TrnContext.FromXml(AV10WebSession.Get("TrnContext"), null, "TransactionContext", "ObligatorioGenexusGit");
      }

      protected void E12012( )
      {
         /* After Trn Routine */
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV9TrnContext.gxTpr_Callerondelete )
         {
            CallWebObject(formatLink("wwactividad.aspx") );
            context.wjLocDisableFrm = 1;
         }
         context.setWebReturnParms(new Object[] {});
         context.setWebReturnParmsMetadata(new Object[] {});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         pr_default.close(1);
         pr_default.close(2);
         returnInSub = true;
         if (true) return;
      }

      protected void ZM011( short GX_JID )
      {
         if ( ( GX_JID == 4 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z13ActividadDescripcion = T00016_A13ActividadDescripcion[0];
               Z14ActividadTipo = T00016_A14ActividadTipo[0];
            }
            else
            {
               Z13ActividadDescripcion = A13ActividadDescripcion;
               Z14ActividadTipo = A14ActividadTipo;
            }
         }
         if ( GX_JID == -4 )
         {
            Z1ActividadId = A1ActividadId;
            Z13ActividadDescripcion = A13ActividadDescripcion;
            Z14ActividadTipo = A14ActividadTipo;
         }
      }

      protected void standaloneNotModal( )
      {
         bttBtn_delete_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Enabled), 5, 0)), true);
         if ( ! (0==AV7ActividadId) )
         {
            A1ActividadId = AV7ActividadId;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1ActividadId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1ActividadId), 4, 0)));
         }
         if ( ! (0==AV7ActividadId) )
         {
            edtActividadId_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtActividadId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtActividadId_Enabled), 5, 0)), true);
         }
         else
         {
            edtActividadId_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtActividadId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtActividadId_Enabled), 5, 0)), true);
         }
         if ( ! (0==AV7ActividadId) )
         {
            edtActividadId_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtActividadId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtActividadId_Enabled), 5, 0)), true);
         }
      }

      protected void standaloneModal( )
      {
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
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ( Gx_BScreen == 0 ) )
         {
            AV11Pgmname = "Actividad";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11Pgmname", AV11Pgmname);
         }
      }

      protected void Load011( )
      {
         /* Using cursor T00017 */
         pr_default.execute(5, new Object[] {A1ActividadId});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound1 = 1;
            A13ActividadDescripcion = T00017_A13ActividadDescripcion[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13ActividadDescripcion", A13ActividadDescripcion);
            A14ActividadTipo = T00017_A14ActividadTipo[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A14ActividadTipo", A14ActividadTipo);
            ZM011( -4) ;
         }
         pr_default.close(5);
         OnLoadActions011( ) ;
      }

      protected void OnLoadActions011( )
      {
         AV11Pgmname = "Actividad";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11Pgmname", AV11Pgmname);
      }

      protected void CheckExtendedTable011( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
         AV11Pgmname = "Actividad";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11Pgmname", AV11Pgmname);
      }

      protected void CloseExtendedTableCursors011( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey011( )
      {
         /* Using cursor T00018 */
         pr_default.execute(6, new Object[] {A1ActividadId});
         if ( (pr_default.getStatus(6) != 101) )
         {
            RcdFound1 = 1;
         }
         else
         {
            RcdFound1 = 0;
         }
         pr_default.close(6);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00016 */
         pr_default.execute(4, new Object[] {A1ActividadId});
         if ( (pr_default.getStatus(4) != 101) )
         {
            ZM011( 4) ;
            RcdFound1 = 1;
            A1ActividadId = T00016_A1ActividadId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1ActividadId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1ActividadId), 4, 0)));
            A13ActividadDescripcion = T00016_A13ActividadDescripcion[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13ActividadDescripcion", A13ActividadDescripcion);
            A14ActividadTipo = T00016_A14ActividadTipo[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A14ActividadTipo", A14ActividadTipo);
            Z1ActividadId = A1ActividadId;
            sMode1 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load011( ) ;
            if ( AnyError == 1 )
            {
               RcdFound1 = 0;
               InitializeNonKey011( ) ;
            }
            Gx_mode = sMode1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound1 = 0;
            InitializeNonKey011( ) ;
            sMode1 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal( ) ;
            Gx_mode = sMode1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         pr_default.close(4);
      }

      protected void getEqualNoModal( )
      {
         GetKey011( ) ;
         if ( RcdFound1 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound1 = 0;
         /* Using cursor T00019 */
         pr_default.execute(7, new Object[] {A1ActividadId});
         if ( (pr_default.getStatus(7) != 101) )
         {
            while ( (pr_default.getStatus(7) != 101) && ( ( T00019_A1ActividadId[0] < A1ActividadId ) ) )
            {
               pr_default.readNext(7);
            }
            if ( (pr_default.getStatus(7) != 101) && ( ( T00019_A1ActividadId[0] > A1ActividadId ) ) )
            {
               A1ActividadId = T00019_A1ActividadId[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1ActividadId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1ActividadId), 4, 0)));
               RcdFound1 = 1;
            }
         }
         pr_default.close(7);
      }

      protected void move_previous( )
      {
         RcdFound1 = 0;
         /* Using cursor T000110 */
         pr_default.execute(8, new Object[] {A1ActividadId});
         if ( (pr_default.getStatus(8) != 101) )
         {
            while ( (pr_default.getStatus(8) != 101) && ( ( T000110_A1ActividadId[0] > A1ActividadId ) ) )
            {
               pr_default.readNext(8);
            }
            if ( (pr_default.getStatus(8) != 101) && ( ( T000110_A1ActividadId[0] < A1ActividadId ) ) )
            {
               A1ActividadId = T000110_A1ActividadId[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1ActividadId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1ActividadId), 4, 0)));
               RcdFound1 = 1;
            }
         }
         pr_default.close(8);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey011( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtActividadId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert011( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound1 == 1 )
            {
               if ( A1ActividadId != Z1ActividadId )
               {
                  A1ActividadId = Z1ActividadId;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1ActividadId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1ActividadId), 4, 0)));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "ACTIVIDADID");
                  AnyError = 1;
                  GX_FocusControl = edtActividadId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtActividadId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Update record */
                  Update011( ) ;
                  GX_FocusControl = edtActividadId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A1ActividadId != Z1ActividadId )
               {
                  /* Insert record */
                  GX_FocusControl = edtActividadId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert011( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "ACTIVIDADID");
                     AnyError = 1;
                     GX_FocusControl = edtActividadId_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     /* Insert record */
                     GX_FocusControl = edtActividadId_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert011( ) ;
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
         if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            if ( AnyError == 0 )
            {
               context.nUserReturn = 1;
            }
         }
      }

      protected void btn_delete( )
      {
         if ( A1ActividadId != Z1ActividadId )
         {
            A1ActividadId = Z1ActividadId;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1ActividadId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1ActividadId), 4, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "ACTIVIDADID");
            AnyError = 1;
            GX_FocusControl = edtActividadId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtActividadId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency011( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00015 */
            pr_default.execute(3, new Object[] {A1ActividadId});
            if ( (pr_default.getStatus(3) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Actividad1"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(3) == 101) || ( StringUtil.StrCmp(Z13ActividadDescripcion, T00015_A13ActividadDescripcion[0]) != 0 ) || ( StringUtil.StrCmp(Z14ActividadTipo, T00015_A14ActividadTipo[0]) != 0 ) )
            {
               if ( StringUtil.StrCmp(Z13ActividadDescripcion, T00015_A13ActividadDescripcion[0]) != 0 )
               {
                  GXUtil.WriteLog("actividad:[seudo value changed for attri]"+"ActividadDescripcion");
                  GXUtil.WriteLogRaw("Old: ",Z13ActividadDescripcion);
                  GXUtil.WriteLogRaw("Current: ",T00015_A13ActividadDescripcion[0]);
               }
               if ( StringUtil.StrCmp(Z14ActividadTipo, T00015_A14ActividadTipo[0]) != 0 )
               {
                  GXUtil.WriteLog("actividad:[seudo value changed for attri]"+"ActividadTipo");
                  GXUtil.WriteLogRaw("Old: ",Z14ActividadTipo);
                  GXUtil.WriteLogRaw("Current: ",T00015_A14ActividadTipo[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Actividad1"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert011( )
      {
         BeforeValidate011( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable011( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM011( 0) ;
            CheckOptimisticConcurrency011( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm011( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert011( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000111 */
                     pr_default.execute(9, new Object[] {A1ActividadId, A13ActividadDescripcion, A14ActividadTipo});
                     pr_default.close(9);
                     dsDefault.SmartCacheProvider.SetUpdated("Actividad1") ;
                     if ( (pr_default.getStatus(9) == 1) )
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
                           ProcessLevel011( ) ;
                           if ( AnyError == 0 )
                           {
                              /* Save values for previous() function. */
                              GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                              ResetCaption010( ) ;
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
               Load011( ) ;
            }
            EndLevel011( ) ;
         }
         CloseExtendedTableCursors011( ) ;
      }

      protected void Update011( )
      {
         BeforeValidate011( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable011( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency011( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm011( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate011( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000112 */
                     pr_default.execute(10, new Object[] {A13ActividadDescripcion, A14ActividadTipo, A1ActividadId});
                     pr_default.close(10);
                     dsDefault.SmartCacheProvider.SetUpdated("Actividad1") ;
                     if ( (pr_default.getStatus(10) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Actividad1"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate011( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           ProcessLevel011( ) ;
                           if ( AnyError == 0 )
                           {
                              if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
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
            EndLevel011( ) ;
         }
         CloseExtendedTableCursors011( ) ;
      }

      protected void DeferredUpdate011( )
      {
      }

      protected void delete( )
      {
         BeforeValidate011( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency011( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls011( ) ;
            AfterConfirm011( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete011( ) ;
               if ( AnyError == 0 )
               {
                  ScanStart012( ) ;
                  while ( RcdFound2 != 0 )
                  {
                     getByPrimaryKey012( ) ;
                     Delete012( ) ;
                     ScanNext012( ) ;
                  }
                  ScanEnd012( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000113 */
                     pr_default.execute(11, new Object[] {A1ActividadId});
                     pr_default.close(11);
                     dsDefault.SmartCacheProvider.SetUpdated("Actividad1") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( delete) rules */
                        /* End of After( delete) rules */
                        if ( AnyError == 0 )
                        {
                           if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
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
         sMode1 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel011( ) ;
         Gx_mode = sMode1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls011( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV11Pgmname = "Actividad";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11Pgmname", AV11Pgmname);
         }
         if ( AnyError == 0 )
         {
            /* Using cursor T000114 */
            pr_default.execute(12, new Object[] {A1ActividadId});
            if ( (pr_default.getStatus(12) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Profesor"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(12);
         }
      }

      protected void ProcessNestedLevel012( )
      {
         nGXsfl_53_idx = 0;
         while ( nGXsfl_53_idx < nRC_GXsfl_53 )
         {
            ReadRow012( ) ;
            if ( ( nRcdExists_2 != 0 ) || ( nIsMod_2 != 0 ) )
            {
               standaloneNotModal012( ) ;
               GetKey012( ) ;
               if ( ( nRcdExists_2 == 0 ) && ( nRcdDeleted_2 == 0 ) )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  Insert012( ) ;
               }
               else
               {
                  if ( RcdFound2 != 0 )
                  {
                     if ( ( nRcdDeleted_2 != 0 ) && ( nRcdExists_2 != 0 ) )
                     {
                        Gx_mode = "DLT";
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                        Delete012( ) ;
                     }
                     else
                     {
                        if ( ( nIsMod_2 != 0 ) && ( nRcdExists_2 != 0 ) )
                        {
                           Gx_mode = "UPD";
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                           Update012( ) ;
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_2 == 0 )
                     {
                        GXCCtl = "SOCIOID_" + sGXsfl_53_idx;
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, GXCCtl);
                        AnyError = 1;
                        GX_FocusControl = edtSocioId_Internalname;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtSocioId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A5SocioId), 4, 0, ".", ""))) ;
            ChangePostValue( edtSocioDireccion_Internalname, A18SocioDireccion) ;
            ChangePostValue( edtSocioFoto_Internalname, A21SocioFoto) ;
            ChangePostValue( edtSocioEdad_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A20SocioEdad), 4, 0, ".", ""))) ;
            ChangePostValue( edtSocioReconocido_Internalname, StringUtil.RTrim( A24SocioReconocido)) ;
            ChangePostValue( edtSocioSexo_Internalname, StringUtil.RTrim( A19SocioSexo)) ;
            ChangePostValue( "ZT_"+"Z5SocioId_"+sGXsfl_53_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z5SocioId), 4, 0, ".", ""))) ;
            ChangePostValue( "nRcdDeleted_2_"+sGXsfl_53_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_2), 4, 0, ".", ""))) ;
            ChangePostValue( "nRcdExists_2_"+sGXsfl_53_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_2), 4, 0, ".", ""))) ;
            ChangePostValue( "nIsMod_2_"+sGXsfl_53_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_2), 4, 0, ".", ""))) ;
            if ( nIsMod_2 != 0 )
            {
               ChangePostValue( "SOCIOID_"+sGXsfl_53_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSocioId_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SOCIODIRECCION_"+sGXsfl_53_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSocioDireccion_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SOCIOFOTO_"+sGXsfl_53_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSocioFoto_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SOCIOEDAD_"+sGXsfl_53_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSocioEdad_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SOCIORECONOCIDO_"+sGXsfl_53_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSocioReconocido_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SOCIOSEXO_"+sGXsfl_53_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSocioSexo_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
         InitAll012( ) ;
         if ( AnyError != 0 )
         {
         }
         nRcdExists_2 = 0;
         nIsMod_2 = 0;
         nRcdDeleted_2 = 0;
      }

      protected void ProcessLevel011( )
      {
         /* Save parent mode. */
         sMode1 = Gx_mode;
         ProcessNestedLevel012( ) ;
         if ( AnyError != 0 )
         {
         }
         /* Restore parent mode. */
         Gx_mode = sMode1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         /* ' Update level parameters */
      }

      protected void EndLevel011( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(3);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete011( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(4);
            pr_default.close(1);
            pr_default.close(0);
            pr_default.close(2);
            context.CommitDataStores("actividad",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues010( ) ;
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
            pr_default.close(2);
            context.RollbackDataStores("actividad",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart011( )
      {
         /* Scan By routine */
         /* Using cursor T000115 */
         pr_default.execute(13);
         RcdFound1 = 0;
         if ( (pr_default.getStatus(13) != 101) )
         {
            RcdFound1 = 1;
            A1ActividadId = T000115_A1ActividadId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1ActividadId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1ActividadId), 4, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext011( )
      {
         /* Scan next routine */
         pr_default.readNext(13);
         RcdFound1 = 0;
         if ( (pr_default.getStatus(13) != 101) )
         {
            RcdFound1 = 1;
            A1ActividadId = T000115_A1ActividadId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1ActividadId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1ActividadId), 4, 0)));
         }
      }

      protected void ScanEnd011( )
      {
         pr_default.close(13);
      }

      protected void AfterConfirm011( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert011( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate011( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete011( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete011( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate011( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes011( )
      {
         edtActividadId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtActividadId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtActividadId_Enabled), 5, 0)), true);
         edtActividadDescripcion_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtActividadDescripcion_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtActividadDescripcion_Enabled), 5, 0)), true);
         edtActividadTipo_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtActividadTipo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtActividadTipo_Enabled), 5, 0)), true);
      }

      protected void ZM012( short GX_JID )
      {
         if ( ( GX_JID == 5 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
            }
            else
            {
            }
         }
         if ( GX_JID == -5 )
         {
            Z1ActividadId = A1ActividadId;
            Z5SocioId = A5SocioId;
            Z18SocioDireccion = A18SocioDireccion;
            Z21SocioFoto = A21SocioFoto;
            Z40000SocioFoto_GXI = A40000SocioFoto_GXI;
            Z20SocioEdad = A20SocioEdad;
            Z24SocioReconocido = A24SocioReconocido;
            Z19SocioSexo = A19SocioSexo;
         }
      }

      protected void standaloneNotModal012( )
      {
      }

      protected void standaloneModal012( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            edtSocioId_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSocioId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSocioId_Enabled), 5, 0)), !bGXsfl_53_Refreshing);
         }
         else
         {
            edtSocioId_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSocioId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSocioId_Enabled), 5, 0)), !bGXsfl_53_Refreshing);
         }
      }

      protected void Load012( )
      {
         /* Using cursor T000116 */
         pr_default.execute(14, new Object[] {A1ActividadId, A5SocioId});
         if ( (pr_default.getStatus(14) != 101) )
         {
            RcdFound2 = 1;
            A18SocioDireccion = T000116_A18SocioDireccion[0];
            A40000SocioFoto_GXI = T000116_A40000SocioFoto_GXI[0];
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSocioFoto_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A21SocioFoto)) ? A40000SocioFoto_GXI : context.convertURL( context.PathToRelativeUrl( A21SocioFoto))), !bGXsfl_53_Refreshing);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSocioFoto_Internalname, "SrcSet", context.GetImageSrcSet( A21SocioFoto), true);
            A20SocioEdad = T000116_A20SocioEdad[0];
            A24SocioReconocido = T000116_A24SocioReconocido[0];
            A19SocioSexo = T000116_A19SocioSexo[0];
            A21SocioFoto = T000116_A21SocioFoto[0];
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSocioFoto_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A21SocioFoto)) ? A40000SocioFoto_GXI : context.convertURL( context.PathToRelativeUrl( A21SocioFoto))), !bGXsfl_53_Refreshing);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSocioFoto_Internalname, "SrcSet", context.GetImageSrcSet( A21SocioFoto), true);
            ZM012( -5) ;
         }
         pr_default.close(14);
         OnLoadActions012( ) ;
      }

      protected void OnLoadActions012( )
      {
      }

      protected void CheckExtendedTable012( )
      {
         Gx_BScreen = 1;
         standaloneModal012( ) ;
         /* Using cursor T00014 */
         pr_default.execute(2, new Object[] {A5SocioId});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GXCCtl = "SOCIOID_" + sGXsfl_53_idx;
            GX_msglist.addItem("No matching 'Socio'.", "ForeignKeyNotFound", 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtSocioId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A18SocioDireccion = T00014_A18SocioDireccion[0];
         A40000SocioFoto_GXI = T00014_A40000SocioFoto_GXI[0];
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSocioFoto_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A21SocioFoto)) ? A40000SocioFoto_GXI : context.convertURL( context.PathToRelativeUrl( A21SocioFoto))), !bGXsfl_53_Refreshing);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSocioFoto_Internalname, "SrcSet", context.GetImageSrcSet( A21SocioFoto), true);
         A20SocioEdad = T00014_A20SocioEdad[0];
         A24SocioReconocido = T00014_A24SocioReconocido[0];
         A19SocioSexo = T00014_A19SocioSexo[0];
         A21SocioFoto = T00014_A21SocioFoto[0];
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSocioFoto_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A21SocioFoto)) ? A40000SocioFoto_GXI : context.convertURL( context.PathToRelativeUrl( A21SocioFoto))), !bGXsfl_53_Refreshing);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSocioFoto_Internalname, "SrcSet", context.GetImageSrcSet( A21SocioFoto), true);
         pr_default.close(2);
      }

      protected void CloseExtendedTableCursors012( )
      {
         pr_default.close(2);
      }

      protected void enableDisable012( )
      {
      }

      protected void gxLoad_6( short A5SocioId )
      {
         /* Using cursor T000117 */
         pr_default.execute(15, new Object[] {A5SocioId});
         if ( (pr_default.getStatus(15) == 101) )
         {
            GXCCtl = "SOCIOID_" + sGXsfl_53_idx;
            GX_msglist.addItem("No matching 'Socio'.", "ForeignKeyNotFound", 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtSocioId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A18SocioDireccion = T000117_A18SocioDireccion[0];
         A40000SocioFoto_GXI = T000117_A40000SocioFoto_GXI[0];
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSocioFoto_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A21SocioFoto)) ? A40000SocioFoto_GXI : context.convertURL( context.PathToRelativeUrl( A21SocioFoto))), !bGXsfl_53_Refreshing);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSocioFoto_Internalname, "SrcSet", context.GetImageSrcSet( A21SocioFoto), true);
         A20SocioEdad = T000117_A20SocioEdad[0];
         A24SocioReconocido = T000117_A24SocioReconocido[0];
         A19SocioSexo = T000117_A19SocioSexo[0];
         A21SocioFoto = T000117_A21SocioFoto[0];
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSocioFoto_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A21SocioFoto)) ? A40000SocioFoto_GXI : context.convertURL( context.PathToRelativeUrl( A21SocioFoto))), !bGXsfl_53_Refreshing);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSocioFoto_Internalname, "SrcSet", context.GetImageSrcSet( A21SocioFoto), true);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A18SocioDireccion)+"\""+","+"\""+GXUtil.EncodeJSConstant( A21SocioFoto)+"\""+","+"\""+GXUtil.EncodeJSConstant( A40000SocioFoto_GXI)+"\""+","+"\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A20SocioEdad), 4, 0, ".", "")))+"\""+","+"\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A24SocioReconocido))+"\""+","+"\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A19SocioSexo))+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(15) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(15);
      }

      protected void GetKey012( )
      {
         /* Using cursor T000118 */
         pr_default.execute(16, new Object[] {A1ActividadId, A5SocioId});
         if ( (pr_default.getStatus(16) != 101) )
         {
            RcdFound2 = 1;
         }
         else
         {
            RcdFound2 = 0;
         }
         pr_default.close(16);
      }

      protected void getByPrimaryKey012( )
      {
         /* Using cursor T00013 */
         pr_default.execute(1, new Object[] {A1ActividadId, A5SocioId});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM012( 5) ;
            RcdFound2 = 1;
            InitializeNonKey012( ) ;
            A5SocioId = T00013_A5SocioId[0];
            Z1ActividadId = A1ActividadId;
            Z5SocioId = A5SocioId;
            sMode2 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load012( ) ;
            Gx_mode = sMode2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound2 = 0;
            InitializeNonKey012( ) ;
            sMode2 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal012( ) ;
            Gx_mode = sMode2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            DisableAttributes012( ) ;
         }
         pr_default.close(1);
      }

      protected void CheckOptimisticConcurrency012( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00012 */
            pr_default.execute(0, new Object[] {A1ActividadId, A5SocioId});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"ActividadSocioEnActividad"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"ActividadSocioEnActividad"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert012( )
      {
         BeforeValidate012( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable012( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM012( 0) ;
            CheckOptimisticConcurrency012( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm012( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert012( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000119 */
                     pr_default.execute(17, new Object[] {A1ActividadId, A5SocioId});
                     pr_default.close(17);
                     dsDefault.SmartCacheProvider.SetUpdated("ActividadSocioEnActividad") ;
                     if ( (pr_default.getStatus(17) == 1) )
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
               Load012( ) ;
            }
            EndLevel012( ) ;
         }
         CloseExtendedTableCursors012( ) ;
      }

      protected void Update012( )
      {
         BeforeValidate012( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable012( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency012( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm012( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate012( ) ;
                  if ( AnyError == 0 )
                  {
                     /* No attributes to update on table [ActividadSocioEnActividad] */
                     DeferredUpdate012( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey012( ) ;
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
            EndLevel012( ) ;
         }
         CloseExtendedTableCursors012( ) ;
      }

      protected void DeferredUpdate012( )
      {
      }

      protected void Delete012( )
      {
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         BeforeValidate012( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency012( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls012( ) ;
            AfterConfirm012( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete012( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000120 */
                  pr_default.execute(18, new Object[] {A1ActividadId, A5SocioId});
                  pr_default.close(18);
                  dsDefault.SmartCacheProvider.SetUpdated("ActividadSocioEnActividad") ;
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
         sMode2 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel012( ) ;
         Gx_mode = sMode2;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls012( )
      {
         standaloneModal012( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            /* Using cursor T000121 */
            pr_default.execute(19, new Object[] {A5SocioId});
            A18SocioDireccion = T000121_A18SocioDireccion[0];
            A40000SocioFoto_GXI = T000121_A40000SocioFoto_GXI[0];
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSocioFoto_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A21SocioFoto)) ? A40000SocioFoto_GXI : context.convertURL( context.PathToRelativeUrl( A21SocioFoto))), !bGXsfl_53_Refreshing);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSocioFoto_Internalname, "SrcSet", context.GetImageSrcSet( A21SocioFoto), true);
            A20SocioEdad = T000121_A20SocioEdad[0];
            A24SocioReconocido = T000121_A24SocioReconocido[0];
            A19SocioSexo = T000121_A19SocioSexo[0];
            A21SocioFoto = T000121_A21SocioFoto[0];
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSocioFoto_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A21SocioFoto)) ? A40000SocioFoto_GXI : context.convertURL( context.PathToRelativeUrl( A21SocioFoto))), !bGXsfl_53_Refreshing);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSocioFoto_Internalname, "SrcSet", context.GetImageSrcSet( A21SocioFoto), true);
            pr_default.close(19);
         }
      }

      protected void EndLevel012( )
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

      public void ScanStart012( )
      {
         /* Scan By routine */
         /* Using cursor T000122 */
         pr_default.execute(20, new Object[] {A1ActividadId});
         RcdFound2 = 0;
         if ( (pr_default.getStatus(20) != 101) )
         {
            RcdFound2 = 1;
            A5SocioId = T000122_A5SocioId[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext012( )
      {
         /* Scan next routine */
         pr_default.readNext(20);
         RcdFound2 = 0;
         if ( (pr_default.getStatus(20) != 101) )
         {
            RcdFound2 = 1;
            A5SocioId = T000122_A5SocioId[0];
         }
      }

      protected void ScanEnd012( )
      {
         pr_default.close(20);
      }

      protected void AfterConfirm012( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert012( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate012( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete012( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete012( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate012( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes012( )
      {
         edtSocioId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSocioId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSocioId_Enabled), 5, 0)), !bGXsfl_53_Refreshing);
         edtSocioDireccion_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSocioDireccion_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSocioDireccion_Enabled), 5, 0)), !bGXsfl_53_Refreshing);
         edtSocioFoto_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSocioFoto_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSocioFoto_Enabled), 5, 0)), !bGXsfl_53_Refreshing);
         edtSocioEdad_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSocioEdad_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSocioEdad_Enabled), 5, 0)), !bGXsfl_53_Refreshing);
         edtSocioReconocido_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSocioReconocido_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSocioReconocido_Enabled), 5, 0)), !bGXsfl_53_Refreshing);
         edtSocioSexo_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSocioSexo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSocioSexo_Enabled), 5, 0)), !bGXsfl_53_Refreshing);
      }

      protected void send_integrity_lvl_hashes012( )
      {
      }

      protected void send_integrity_lvl_hashes011( )
      {
      }

      protected void SubsflControlProps_532( )
      {
         edtSocioId_Internalname = "SOCIOID_"+sGXsfl_53_idx;
         imgprompt_5_Internalname = "PROMPT_5_"+sGXsfl_53_idx;
         edtSocioDireccion_Internalname = "SOCIODIRECCION_"+sGXsfl_53_idx;
         edtSocioFoto_Internalname = "SOCIOFOTO_"+sGXsfl_53_idx;
         edtSocioEdad_Internalname = "SOCIOEDAD_"+sGXsfl_53_idx;
         edtSocioReconocido_Internalname = "SOCIORECONOCIDO_"+sGXsfl_53_idx;
         edtSocioSexo_Internalname = "SOCIOSEXO_"+sGXsfl_53_idx;
      }

      protected void SubsflControlProps_fel_532( )
      {
         edtSocioId_Internalname = "SOCIOID_"+sGXsfl_53_fel_idx;
         imgprompt_5_Internalname = "PROMPT_5_"+sGXsfl_53_fel_idx;
         edtSocioDireccion_Internalname = "SOCIODIRECCION_"+sGXsfl_53_fel_idx;
         edtSocioFoto_Internalname = "SOCIOFOTO_"+sGXsfl_53_fel_idx;
         edtSocioEdad_Internalname = "SOCIOEDAD_"+sGXsfl_53_fel_idx;
         edtSocioReconocido_Internalname = "SOCIORECONOCIDO_"+sGXsfl_53_fel_idx;
         edtSocioSexo_Internalname = "SOCIOSEXO_"+sGXsfl_53_fel_idx;
      }

      protected void AddRow012( )
      {
         nGXsfl_53_idx = (short)(nGXsfl_53_idx+1);
         sGXsfl_53_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_53_idx), 4, 0)), 4, "0");
         SubsflControlProps_532( ) ;
         SendRow012( ) ;
      }

      protected void SendRow012( )
      {
         Gridactividad_socioenactividadRow = GXWebRow.GetNew(context);
         if ( subGridactividad_socioenactividad_Backcolorstyle == 0 )
         {
            /* None style subfile background logic. */
            subGridactividad_socioenactividad_Backstyle = 0;
            if ( StringUtil.StrCmp(subGridactividad_socioenactividad_Class, "") != 0 )
            {
               subGridactividad_socioenactividad_Linesclass = subGridactividad_socioenactividad_Class+"Odd";
            }
         }
         else if ( subGridactividad_socioenactividad_Backcolorstyle == 1 )
         {
            /* Uniform style subfile background logic. */
            subGridactividad_socioenactividad_Backstyle = 0;
            subGridactividad_socioenactividad_Backcolor = subGridactividad_socioenactividad_Allbackcolor;
            if ( StringUtil.StrCmp(subGridactividad_socioenactividad_Class, "") != 0 )
            {
               subGridactividad_socioenactividad_Linesclass = subGridactividad_socioenactividad_Class+"Uniform";
            }
         }
         else if ( subGridactividad_socioenactividad_Backcolorstyle == 2 )
         {
            /* Header style subfile background logic. */
            subGridactividad_socioenactividad_Backstyle = 1;
            if ( StringUtil.StrCmp(subGridactividad_socioenactividad_Class, "") != 0 )
            {
               subGridactividad_socioenactividad_Linesclass = subGridactividad_socioenactividad_Class+"Odd";
            }
            subGridactividad_socioenactividad_Backcolor = (int)(0x0);
         }
         else if ( subGridactividad_socioenactividad_Backcolorstyle == 3 )
         {
            /* Report style subfile background logic. */
            subGridactividad_socioenactividad_Backstyle = 1;
            if ( ((int)(((nGXsfl_53_idx-1)/ (decimal)(1)) % (2))) == 0 )
            {
               subGridactividad_socioenactividad_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGridactividad_socioenactividad_Class, "") != 0 )
               {
                  subGridactividad_socioenactividad_Linesclass = subGridactividad_socioenactividad_Class+"Odd";
               }
            }
            else
            {
               subGridactividad_socioenactividad_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGridactividad_socioenactividad_Class, "") != 0 )
               {
                  subGridactividad_socioenactividad_Linesclass = subGridactividad_socioenactividad_Class+"Even";
               }
            }
         }
         imgprompt_5_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0)||(StringUtil.StrCmp(Gx_mode, "UPD")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0040.aspx"+"',["+"{Ctrl:gx.dom.el('"+"SOCIOID_"+sGXsfl_53_idx+"'), id:'"+"SOCIOID_"+sGXsfl_53_idx+"'"+",IOType:'out'}"+"],"+"gx.dom.form()."+"nIsMod_2_"+sGXsfl_53_idx+","+"'', false"+","+"false"+");");
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_2_" + sGXsfl_53_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 54,'',false,'" + sGXsfl_53_idx + "',53)\"";
         ROClassString = "Attribute";
         Gridactividad_socioenactividadRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSocioId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A5SocioId), 4, 0, ".", "")),StringUtil.LTrim( context.localUtil.Format( (decimal)(A5SocioId), "ZZZ9")),TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,54);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtSocioId_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtSocioId_Enabled,(short)1,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)53,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         /* Static images/pictures */
         ClassString = "gx-prompt Image";
         StyleString = "";
         sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
         Gridactividad_socioenactividadRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)imgprompt_5_Internalname,(String)sImgUrl,(String)imgprompt_5_Link,(String)"",(String)"",context.GetTheme( ),(int)imgprompt_5_Visible,(short)1,(String)"",(String)"",(short)0,(short)0,(short)0,(String)"",(short)0,(String)"",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)false,(bool)false,context.GetImageSrcSet( sImgUrl)});
         /* Subfile cell */
         /* Single line edit */
         ROClassString = "Attribute";
         Gridactividad_socioenactividadRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSocioDireccion_Internalname,(String)A18SocioDireccion,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'","http://maps.google.com/maps?q="+GXUtil.UrlEncode( A18SocioDireccion),(String)"_blank",(String)"",(String)"",(String)edtSocioDireccion_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtSocioDireccion_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)1024,(short)0,(short)0,(short)53,(short)1,(short)-1,(short)0,(bool)true,(String)"GeneXus\\Address",(String)"left",(bool)true});
         /* Subfile cell */
         /* Static Bitmap Variable */
         ClassString = "ImageAttribute";
         StyleString = "";
         A21SocioFoto_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( A21SocioFoto))&&String.IsNullOrEmpty(StringUtil.RTrim( A40000SocioFoto_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( A21SocioFoto)));
         sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( A21SocioFoto)) ? A40000SocioFoto_GXI : context.PathToRelativeUrl( A21SocioFoto));
         Gridactividad_socioenactividadRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtSocioFoto_Internalname,(String)sImgUrl,(String)"",(String)"",(String)"",context.GetTheme( ),(short)-1,(int)edtSocioFoto_Enabled,(String)"",(String)"",(short)1,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)0,(bool)A21SocioFoto_IsBlob,(bool)true,context.GetImageSrcSet( sImgUrl)});
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSocioFoto_Internalname, "URL", (String.IsNullOrEmpty(StringUtil.RTrim( A21SocioFoto)) ? A40000SocioFoto_GXI : context.PathToRelativeUrl( A21SocioFoto)), !bGXsfl_53_Refreshing);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSocioFoto_Internalname, "IsBlob", StringUtil.BoolToStr( A21SocioFoto_IsBlob), !bGXsfl_53_Refreshing);
         /* Subfile cell */
         /* Single line edit */
         ROClassString = "Attribute";
         Gridactividad_socioenactividadRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSocioEdad_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A20SocioEdad), 4, 0, ".", "")),((edtSocioEdad_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A20SocioEdad), "ZZZ9")) : context.localUtil.Format( (decimal)(A20SocioEdad), "ZZZ9")),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtSocioEdad_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtSocioEdad_Enabled,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)53,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         /* Single line edit */
         ROClassString = "Attribute";
         Gridactividad_socioenactividadRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSocioReconocido_Internalname,StringUtil.RTrim( A24SocioReconocido),(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtSocioReconocido_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtSocioReconocido_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)20,(short)0,(short)0,(short)53,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
         /* Subfile cell */
         /* Single line edit */
         ROClassString = "Attribute";
         Gridactividad_socioenactividadRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSocioSexo_Internalname,StringUtil.RTrim( A19SocioSexo),(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtSocioSexo_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtSocioSexo_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)20,(short)0,(short)0,(short)53,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
         context.httpAjaxContext.ajax_sending_grid_row(Gridactividad_socioenactividadRow);
         send_integrity_lvl_hashes012( ) ;
         GXCCtl = "Z5SocioId_" + sGXsfl_53_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z5SocioId), 4, 0, ".", "")));
         GXCCtl = "nRcdDeleted_2_" + sGXsfl_53_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_2), 4, 0, ".", "")));
         GXCCtl = "nRcdExists_2_" + sGXsfl_53_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_2), 4, 0, ".", "")));
         GXCCtl = "nIsMod_2_" + sGXsfl_53_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_2), 4, 0, ".", "")));
         GXCCtl = "vMODE_" + sGXsfl_53_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Gx_mode));
         GXCCtl = "vTRNCONTEXT_" + sGXsfl_53_idx;
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, GXCCtl, AV9TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(GXCCtl, AV9TrnContext);
         }
         GXCCtl = "vACTIVIDADID_" + sGXsfl_53_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7ActividadId), 4, 0, ".", "")));
         GXCCtl = "SOCIOFOTO_" + sGXsfl_53_idx;
         GXCCtlgxBlob = GXCCtl + "_gxBlob";
         GxWebStd.gx_hidden_field( context, GXCCtlgxBlob, A21SocioFoto);
         GxWebStd.gx_hidden_field( context, "SOCIOID_"+sGXsfl_53_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSocioId_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "SOCIODIRECCION_"+sGXsfl_53_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSocioDireccion_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "SOCIOFOTO_"+sGXsfl_53_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSocioFoto_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "SOCIOEDAD_"+sGXsfl_53_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSocioEdad_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "SOCIORECONOCIDO_"+sGXsfl_53_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSocioReconocido_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "SOCIOSEXO_"+sGXsfl_53_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSocioSexo_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "PROMPT_5_"+sGXsfl_53_idx+"Link", StringUtil.RTrim( imgprompt_5_Link));
         context.httpAjaxContext.ajax_sending_grid_row(null);
         Gridactividad_socioenactividadContainer.AddRow(Gridactividad_socioenactividadRow);
      }

      protected void ReadRow012( )
      {
         nGXsfl_53_idx = (short)(nGXsfl_53_idx+1);
         sGXsfl_53_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_53_idx), 4, 0)), 4, "0");
         SubsflControlProps_532( ) ;
         edtSocioId_Enabled = (int)(context.localUtil.CToN( cgiGet( "SOCIOID_"+sGXsfl_53_idx+"Enabled"), ".", ","));
         edtSocioDireccion_Enabled = (int)(context.localUtil.CToN( cgiGet( "SOCIODIRECCION_"+sGXsfl_53_idx+"Enabled"), ".", ","));
         edtSocioFoto_Enabled = (int)(context.localUtil.CToN( cgiGet( "SOCIOFOTO_"+sGXsfl_53_idx+"Enabled"), ".", ","));
         edtSocioEdad_Enabled = (int)(context.localUtil.CToN( cgiGet( "SOCIOEDAD_"+sGXsfl_53_idx+"Enabled"), ".", ","));
         edtSocioReconocido_Enabled = (int)(context.localUtil.CToN( cgiGet( "SOCIORECONOCIDO_"+sGXsfl_53_idx+"Enabled"), ".", ","));
         edtSocioSexo_Enabled = (int)(context.localUtil.CToN( cgiGet( "SOCIOSEXO_"+sGXsfl_53_idx+"Enabled"), ".", ","));
         imgprompt_5_Link = cgiGet( "PROMPT_5_"+sGXsfl_53_idx+"Link");
         if ( ( ( context.localUtil.CToN( cgiGet( edtSocioId_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtSocioId_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
         {
            GXCCtl = "SOCIOID_" + sGXsfl_53_idx;
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
         A18SocioDireccion = cgiGet( edtSocioDireccion_Internalname);
         A21SocioFoto = cgiGet( edtSocioFoto_Internalname);
         A20SocioEdad = (short)(context.localUtil.CToN( cgiGet( edtSocioEdad_Internalname), ".", ","));
         A24SocioReconocido = cgiGet( edtSocioReconocido_Internalname);
         A19SocioSexo = cgiGet( edtSocioSexo_Internalname);
         GXCCtl = "Z5SocioId_" + sGXsfl_53_idx;
         Z5SocioId = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ","));
         GXCCtl = "nRcdDeleted_2_" + sGXsfl_53_idx;
         nRcdDeleted_2 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ","));
         GXCCtl = "nRcdExists_2_" + sGXsfl_53_idx;
         nRcdExists_2 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ","));
         GXCCtl = "nIsMod_2_" + sGXsfl_53_idx;
         nIsMod_2 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ","));
         getMultimediaValue(edtSocioFoto_Internalname, ref  A21SocioFoto, ref  A40000SocioFoto_GXI);
      }

      protected void assign_properties_default( )
      {
         defedtSocioId_Enabled = edtSocioId_Enabled;
      }

      protected void ConfirmValues010( )
      {
         nGXsfl_53_idx = 0;
         sGXsfl_53_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_53_idx), 4, 0)), 4, "0");
         SubsflControlProps_532( ) ;
         while ( nGXsfl_53_idx < nRC_GXsfl_53 )
         {
            nGXsfl_53_idx = (short)(nGXsfl_53_idx+1);
            sGXsfl_53_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_53_idx), 4, 0)), 4, "0");
            SubsflControlProps_532( ) ;
            ChangePostValue( "Z5SocioId_"+sGXsfl_53_idx, cgiGet( "ZT_"+"Z5SocioId_"+sGXsfl_53_idx)) ;
            DeletePostValue( "ZT_"+"Z5SocioId_"+sGXsfl_53_idx) ;
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
         context.AddJavascriptSource("gxcfg.js", "?20193221911431", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("actividad.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7ActividadId)+"\">") ;
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
         forbiddenHiddens = "hsh" + "Actividad";
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("actividad:[SendSecurityCheck value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z1ActividadId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z1ActividadId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z13ActividadDescripcion", StringUtil.RTrim( Z13ActividadDescripcion));
         GxWebStd.gx_hidden_field( context, "Z14ActividadTipo", StringUtil.RTrim( Z14ActividadTipo));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_Mode", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_53", StringUtil.LTrim( StringUtil.NToC( (decimal)(nGXsfl_53_idx), 4, 0, ".", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vTRNCONTEXT", AV9TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vTRNCONTEXT", AV9TrnContext);
         }
         GxWebStd.gx_hidden_field( context, "vACTIVIDADID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7ActividadId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vACTIVIDADID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7ActividadId), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV11Pgmname));
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
         return formatLink("actividad.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7ActividadId) ;
      }

      public override String GetPgmname( )
      {
         return "Actividad" ;
      }

      public override String GetPgmdesc( )
      {
         return "Actividad" ;
      }

      protected void InitializeNonKey011( )
      {
         A13ActividadDescripcion = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13ActividadDescripcion", A13ActividadDescripcion);
         A14ActividadTipo = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A14ActividadTipo", A14ActividadTipo);
         Z13ActividadDescripcion = "";
         Z14ActividadTipo = "";
      }

      protected void InitAll011( )
      {
         A1ActividadId = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1ActividadId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1ActividadId), 4, 0)));
         InitializeNonKey011( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void InitializeNonKey012( )
      {
         A18SocioDireccion = "";
         A21SocioFoto = "";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSocioFoto_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A21SocioFoto)) ? A40000SocioFoto_GXI : context.convertURL( context.PathToRelativeUrl( A21SocioFoto))), !bGXsfl_53_Refreshing);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSocioFoto_Internalname, "SrcSet", context.GetImageSrcSet( A21SocioFoto), true);
         A40000SocioFoto_GXI = "";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSocioFoto_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A21SocioFoto)) ? A40000SocioFoto_GXI : context.convertURL( context.PathToRelativeUrl( A21SocioFoto))), !bGXsfl_53_Refreshing);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSocioFoto_Internalname, "SrcSet", context.GetImageSrcSet( A21SocioFoto), true);
         A20SocioEdad = 0;
         A24SocioReconocido = "";
         A19SocioSexo = "";
      }

      protected void InitAll012( )
      {
         A5SocioId = 0;
         InitializeNonKey012( ) ;
      }

      protected void StandaloneModalInsert012( )
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20193221911439", true);
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
         context.AddJavascriptSource("actividad.js", "?20193221911439", false);
         /* End function include_jscripts */
      }

      protected void init_level_properties2( )
      {
         edtSocioId_Enabled = defedtSocioId_Enabled;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSocioId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSocioId_Enabled), 5, 0)), !bGXsfl_53_Refreshing);
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
         edtActividadId_Internalname = "ACTIVIDADID";
         edtActividadDescripcion_Internalname = "ACTIVIDADDESCRIPCION";
         edtActividadTipo_Internalname = "ACTIVIDADTIPO";
         lblTitlesocioenactividad_Internalname = "TITLESOCIOENACTIVIDAD";
         edtSocioId_Internalname = "SOCIOID";
         edtSocioDireccion_Internalname = "SOCIODIRECCION";
         edtSocioFoto_Internalname = "SOCIOFOTO";
         edtSocioEdad_Internalname = "SOCIOEDAD";
         edtSocioReconocido_Internalname = "SOCIORECONOCIDO";
         edtSocioSexo_Internalname = "SOCIOSEXO";
         divSocioenactividadtable_Internalname = "SOCIOENACTIVIDADTABLE";
         divFormcontainer_Internalname = "FORMCONTAINER";
         bttBtn_enter_Internalname = "BTN_ENTER";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         bttBtn_delete_Internalname = "BTN_DELETE";
         divMaintable_Internalname = "MAINTABLE";
         Form.Internalname = "FORM";
         imgprompt_5_Internalname = "PROMPT_5";
         subGridactividad_socioenactividad_Internalname = "GRIDACTIVIDAD_SOCIOENACTIVIDAD";
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
         Form.Caption = "Actividad";
         edtSocioSexo_Jsonclick = "";
         edtSocioReconocido_Jsonclick = "";
         edtSocioEdad_Jsonclick = "";
         edtSocioDireccion_Jsonclick = "";
         imgprompt_5_Visible = 1;
         imgprompt_5_Link = "";
         imgprompt_5_Visible = 1;
         edtSocioId_Jsonclick = "";
         subGridactividad_socioenactividad_Class = "Grid";
         subGridactividad_socioenactividad_Backcolorstyle = 0;
         subGridactividad_socioenactividad_Allowcollapsing = 0;
         subGridactividad_socioenactividad_Allowselection = 0;
         edtSocioSexo_Enabled = 0;
         edtSocioReconocido_Enabled = 0;
         edtSocioEdad_Enabled = 0;
         edtSocioFoto_Enabled = 0;
         edtSocioDireccion_Enabled = 0;
         edtSocioId_Enabled = 1;
         subGridactividad_socioenactividad_Header = "";
         bttBtn_delete_Enabled = 0;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edtActividadTipo_Jsonclick = "";
         edtActividadTipo_Enabled = 1;
         edtActividadDescripcion_Jsonclick = "";
         edtActividadDescripcion_Enabled = 1;
         edtActividadId_Jsonclick = "";
         edtActividadId_Enabled = 1;
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

      protected void gxnrGridactividad_socioenactividad_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         Gx_mode = "INS";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         SubsflControlProps_532( ) ;
         while ( nGXsfl_53_idx <= nRC_GXsfl_53 )
         {
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            standaloneNotModal012( ) ;
            standaloneModal012( ) ;
            init_web_controls( ) ;
            dynload_actions( ) ;
            SendRow012( ) ;
            nGXsfl_53_idx = (short)(nGXsfl_53_idx+1);
            sGXsfl_53_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_53_idx), 4, 0)), 4, "0");
            SubsflControlProps_532( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( Gridactividad_socioenactividadContainer));
         /* End function gxnrGridactividad_socioenactividad_newrow */
      }

      protected void init_web_controls( )
      {
         /* End function init_web_controls */
      }

      public void Valid_Socioid( short GX_Parm1 ,
                                 String GX_Parm2 ,
                                 String GX_Parm3 ,
                                 String GX_Parm4 ,
                                 short GX_Parm5 ,
                                 String GX_Parm6 ,
                                 String GX_Parm7 )
      {
         A5SocioId = GX_Parm1;
         A18SocioDireccion = GX_Parm2;
         A21SocioFoto = GX_Parm3;
         A40000SocioFoto_GXI = GX_Parm4;
         A20SocioEdad = GX_Parm5;
         A24SocioReconocido = GX_Parm6;
         A19SocioSexo = GX_Parm7;
         /* Using cursor T000121 */
         pr_default.execute(19, new Object[] {A5SocioId});
         if ( (pr_default.getStatus(19) == 101) )
         {
            GX_msglist.addItem("No matching 'Socio'.", "ForeignKeyNotFound", 1, "SOCIOID");
            AnyError = 1;
            GX_FocusControl = edtSocioId_Internalname;
         }
         A18SocioDireccion = T000121_A18SocioDireccion[0];
         A40000SocioFoto_GXI = T000121_A40000SocioFoto_GXI[0];
         A20SocioEdad = T000121_A20SocioEdad[0];
         A24SocioReconocido = T000121_A24SocioReconocido[0];
         A19SocioSexo = T000121_A19SocioSexo[0];
         A21SocioFoto = T000121_A21SocioFoto[0];
         pr_default.close(19);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A18SocioDireccion = "";
            A21SocioFoto = "";
            A40000SocioFoto_GXI = "";
            A20SocioEdad = 0;
            A24SocioReconocido = "";
            A19SocioSexo = "";
         }
         isValidOutput.Add(A18SocioDireccion);
         isValidOutput.Add(context.PathToRelativeUrl( A21SocioFoto));
         isValidOutput.Add(A21SocioFoto);
         isValidOutput.Add(A40000SocioFoto_GXI);
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(A20SocioEdad), 4, 0, ".", "")));
         isValidOutput.Add(StringUtil.RTrim( A24SocioReconocido));
         isValidOutput.Add(StringUtil.RTrim( A19SocioSexo));
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
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7ActividadId',fld:'vACTIVIDADID',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7ActividadId',fld:'vACTIVIDADID',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("AFTER TRN","{handler:'E12012',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV9TrnContext',fld:'vTRNCONTEXT',pic:''}]");
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
         pr_default.close(19);
         pr_default.close(4);
      }

      public override void initialize( )
      {
         sPrefix = "";
         wcpOGx_mode = "";
         Z13ActividadDescripcion = "";
         Z14ActividadTipo = "";
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
         A14ActividadTipo = "";
         lblTitlesocioenactividad_Jsonclick = "";
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         Gridactividad_socioenactividadContainer = new GXWebGrid( context);
         Gridactividad_socioenactividadColumn = new GXWebColumn();
         A18SocioDireccion = "";
         A21SocioFoto = "";
         A24SocioReconocido = "";
         A19SocioSexo = "";
         sMode2 = "";
         sStyleString = "";
         AV11Pgmname = "";
         A40000SocioFoto_GXI = "";
         forbiddenHiddens = "";
         hsh = "";
         sMode1 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         GXCCtl = "";
         AV9TrnContext = new SdtTransactionContext(context);
         AV10WebSession = context.GetSession();
         T00017_A1ActividadId = new short[1] ;
         T00017_A13ActividadDescripcion = new String[] {""} ;
         T00017_A14ActividadTipo = new String[] {""} ;
         T00018_A1ActividadId = new short[1] ;
         T00016_A1ActividadId = new short[1] ;
         T00016_A13ActividadDescripcion = new String[] {""} ;
         T00016_A14ActividadTipo = new String[] {""} ;
         T00019_A1ActividadId = new short[1] ;
         T000110_A1ActividadId = new short[1] ;
         T00015_A1ActividadId = new short[1] ;
         T00015_A13ActividadDescripcion = new String[] {""} ;
         T00015_A14ActividadTipo = new String[] {""} ;
         T000114_A2ProfesorId = new short[1] ;
         T000115_A1ActividadId = new short[1] ;
         Z18SocioDireccion = "";
         Z21SocioFoto = "";
         Z40000SocioFoto_GXI = "";
         Z24SocioReconocido = "";
         Z19SocioSexo = "";
         T000116_A1ActividadId = new short[1] ;
         T000116_A18SocioDireccion = new String[] {""} ;
         T000116_A40000SocioFoto_GXI = new String[] {""} ;
         T000116_A20SocioEdad = new short[1] ;
         T000116_A24SocioReconocido = new String[] {""} ;
         T000116_A19SocioSexo = new String[] {""} ;
         T000116_A5SocioId = new short[1] ;
         T000116_A21SocioFoto = new String[] {""} ;
         T00014_A18SocioDireccion = new String[] {""} ;
         T00014_A40000SocioFoto_GXI = new String[] {""} ;
         T00014_A20SocioEdad = new short[1] ;
         T00014_A24SocioReconocido = new String[] {""} ;
         T00014_A19SocioSexo = new String[] {""} ;
         T00014_A21SocioFoto = new String[] {""} ;
         T000117_A18SocioDireccion = new String[] {""} ;
         T000117_A40000SocioFoto_GXI = new String[] {""} ;
         T000117_A20SocioEdad = new short[1] ;
         T000117_A24SocioReconocido = new String[] {""} ;
         T000117_A19SocioSexo = new String[] {""} ;
         T000117_A21SocioFoto = new String[] {""} ;
         T000118_A1ActividadId = new short[1] ;
         T000118_A5SocioId = new short[1] ;
         T00013_A1ActividadId = new short[1] ;
         T00013_A5SocioId = new short[1] ;
         T00012_A1ActividadId = new short[1] ;
         T00012_A5SocioId = new short[1] ;
         T000121_A18SocioDireccion = new String[] {""} ;
         T000121_A40000SocioFoto_GXI = new String[] {""} ;
         T000121_A20SocioEdad = new short[1] ;
         T000121_A24SocioReconocido = new String[] {""} ;
         T000121_A19SocioSexo = new String[] {""} ;
         T000121_A21SocioFoto = new String[] {""} ;
         T000122_A1ActividadId = new short[1] ;
         T000122_A5SocioId = new short[1] ;
         Gridactividad_socioenactividadRow = new GXWebRow();
         subGridactividad_socioenactividad_Linesclass = "";
         ROClassString = "";
         sImgUrl = "";
         GXCCtlgxBlob = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         isValidOutput = new GxUnknownObjectCollection();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.actividad__default(),
            new Object[][] {
                new Object[] {
               T00012_A1ActividadId, T00012_A5SocioId
               }
               , new Object[] {
               T00013_A1ActividadId, T00013_A5SocioId
               }
               , new Object[] {
               T00014_A18SocioDireccion, T00014_A40000SocioFoto_GXI, T00014_A20SocioEdad, T00014_A24SocioReconocido, T00014_A19SocioSexo, T00014_A21SocioFoto
               }
               , new Object[] {
               T00015_A1ActividadId, T00015_A13ActividadDescripcion, T00015_A14ActividadTipo
               }
               , new Object[] {
               T00016_A1ActividadId, T00016_A13ActividadDescripcion, T00016_A14ActividadTipo
               }
               , new Object[] {
               T00017_A1ActividadId, T00017_A13ActividadDescripcion, T00017_A14ActividadTipo
               }
               , new Object[] {
               T00018_A1ActividadId
               }
               , new Object[] {
               T00019_A1ActividadId
               }
               , new Object[] {
               T000110_A1ActividadId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000114_A2ProfesorId
               }
               , new Object[] {
               T000115_A1ActividadId
               }
               , new Object[] {
               T000116_A1ActividadId, T000116_A18SocioDireccion, T000116_A40000SocioFoto_GXI, T000116_A20SocioEdad, T000116_A24SocioReconocido, T000116_A19SocioSexo, T000116_A5SocioId, T000116_A21SocioFoto
               }
               , new Object[] {
               T000117_A18SocioDireccion, T000117_A40000SocioFoto_GXI, T000117_A20SocioEdad, T000117_A24SocioReconocido, T000117_A19SocioSexo, T000117_A21SocioFoto
               }
               , new Object[] {
               T000118_A1ActividadId, T000118_A5SocioId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000121_A18SocioDireccion, T000121_A40000SocioFoto_GXI, T000121_A20SocioEdad, T000121_A24SocioReconocido, T000121_A19SocioSexo, T000121_A21SocioFoto
               }
               , new Object[] {
               T000122_A1ActividadId, T000122_A5SocioId
               }
            }
         );
         AV11Pgmname = "Actividad";
      }

      private short nIsMod_2 ;
      private short wcpOAV7ActividadId ;
      private short Z1ActividadId ;
      private short nRC_GXsfl_53 ;
      private short nGXsfl_53_idx=1 ;
      private short Z5SocioId ;
      private short nRcdDeleted_2 ;
      private short nRcdExists_2 ;
      private short GxWebError ;
      private short A5SocioId ;
      private short AV7ActividadId ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short A1ActividadId ;
      private short subGridactividad_socioenactividad_Backcolorstyle ;
      private short A20SocioEdad ;
      private short subGridactividad_socioenactividad_Allowselection ;
      private short subGridactividad_socioenactividad_Allowhovering ;
      private short subGridactividad_socioenactividad_Allowcollapsing ;
      private short subGridactividad_socioenactividad_Collapsed ;
      private short nBlankRcdCount2 ;
      private short RcdFound2 ;
      private short nBlankRcdUsr2 ;
      private short RcdFound1 ;
      private short GX_JID ;
      private short Gx_BScreen ;
      private short Z20SocioEdad ;
      private short subGridactividad_socioenactividad_Backstyle ;
      private short gxajaxcallmode ;
      private short wbTemp ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int edtActividadId_Enabled ;
      private int edtActividadDescripcion_Enabled ;
      private int edtActividadTipo_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int edtSocioId_Enabled ;
      private int edtSocioDireccion_Enabled ;
      private int edtSocioFoto_Enabled ;
      private int edtSocioEdad_Enabled ;
      private int edtSocioReconocido_Enabled ;
      private int edtSocioSexo_Enabled ;
      private int subGridactividad_socioenactividad_Selectedindex ;
      private int subGridactividad_socioenactividad_Selectioncolor ;
      private int subGridactividad_socioenactividad_Hoveringcolor ;
      private int fRowAdded ;
      private int subGridactividad_socioenactividad_Backcolor ;
      private int subGridactividad_socioenactividad_Allbackcolor ;
      private int imgprompt_5_Visible ;
      private int defedtSocioId_Enabled ;
      private int idxLst ;
      private long GRIDACTIVIDAD_SOCIOENACTIVIDAD_nFirstRecordOnPage ;
      private String sPrefix ;
      private String sGXsfl_53_idx="0001" ;
      private String wcpOGx_mode ;
      private String Z13ActividadDescripcion ;
      private String Z14ActividadTipo ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String Gx_mode ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtActividadId_Internalname ;
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
      private String edtActividadId_Jsonclick ;
      private String edtActividadDescripcion_Internalname ;
      private String A13ActividadDescripcion ;
      private String edtActividadDescripcion_Jsonclick ;
      private String edtActividadTipo_Internalname ;
      private String A14ActividadTipo ;
      private String edtActividadTipo_Jsonclick ;
      private String divSocioenactividadtable_Internalname ;
      private String lblTitlesocioenactividad_Internalname ;
      private String lblTitlesocioenactividad_Jsonclick ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String subGridactividad_socioenactividad_Header ;
      private String A24SocioReconocido ;
      private String A19SocioSexo ;
      private String sMode2 ;
      private String edtSocioId_Internalname ;
      private String edtSocioDireccion_Internalname ;
      private String edtSocioFoto_Internalname ;
      private String edtSocioEdad_Internalname ;
      private String edtSocioReconocido_Internalname ;
      private String edtSocioSexo_Internalname ;
      private String imgprompt_5_Link ;
      private String sStyleString ;
      private String AV11Pgmname ;
      private String forbiddenHiddens ;
      private String hsh ;
      private String sMode1 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String GXCCtl ;
      private String Z24SocioReconocido ;
      private String Z19SocioSexo ;
      private String imgprompt_5_Internalname ;
      private String sGXsfl_53_fel_idx="0001" ;
      private String subGridactividad_socioenactividad_Class ;
      private String subGridactividad_socioenactividad_Linesclass ;
      private String ROClassString ;
      private String edtSocioId_Jsonclick ;
      private String sImgUrl ;
      private String edtSocioDireccion_Jsonclick ;
      private String edtSocioEdad_Jsonclick ;
      private String edtSocioReconocido_Jsonclick ;
      private String edtSocioSexo_Jsonclick ;
      private String GXCCtlgxBlob ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String subGridactividad_socioenactividad_Internalname ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool bGXsfl_53_Refreshing=false ;
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
      private GXWebGrid Gridactividad_socioenactividadContainer ;
      private GXWebRow Gridactividad_socioenactividadRow ;
      private GXWebColumn Gridactividad_socioenactividadColumn ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] T00017_A1ActividadId ;
      private String[] T00017_A13ActividadDescripcion ;
      private String[] T00017_A14ActividadTipo ;
      private short[] T00018_A1ActividadId ;
      private short[] T00016_A1ActividadId ;
      private String[] T00016_A13ActividadDescripcion ;
      private String[] T00016_A14ActividadTipo ;
      private short[] T00019_A1ActividadId ;
      private short[] T000110_A1ActividadId ;
      private short[] T00015_A1ActividadId ;
      private String[] T00015_A13ActividadDescripcion ;
      private String[] T00015_A14ActividadTipo ;
      private short[] T000114_A2ProfesorId ;
      private short[] T000115_A1ActividadId ;
      private short[] T000116_A1ActividadId ;
      private String[] T000116_A18SocioDireccion ;
      private String[] T000116_A40000SocioFoto_GXI ;
      private short[] T000116_A20SocioEdad ;
      private String[] T000116_A24SocioReconocido ;
      private String[] T000116_A19SocioSexo ;
      private short[] T000116_A5SocioId ;
      private String[] T000116_A21SocioFoto ;
      private String[] T00014_A18SocioDireccion ;
      private String[] T00014_A40000SocioFoto_GXI ;
      private short[] T00014_A20SocioEdad ;
      private String[] T00014_A24SocioReconocido ;
      private String[] T00014_A19SocioSexo ;
      private String[] T00014_A21SocioFoto ;
      private String[] T000117_A18SocioDireccion ;
      private String[] T000117_A40000SocioFoto_GXI ;
      private short[] T000117_A20SocioEdad ;
      private String[] T000117_A24SocioReconocido ;
      private String[] T000117_A19SocioSexo ;
      private String[] T000117_A21SocioFoto ;
      private short[] T000118_A1ActividadId ;
      private short[] T000118_A5SocioId ;
      private short[] T00013_A1ActividadId ;
      private short[] T00013_A5SocioId ;
      private short[] T00012_A1ActividadId ;
      private short[] T00012_A5SocioId ;
      private String[] T000121_A18SocioDireccion ;
      private String[] T000121_A40000SocioFoto_GXI ;
      private short[] T000121_A20SocioEdad ;
      private String[] T000121_A24SocioReconocido ;
      private String[] T000121_A19SocioSexo ;
      private String[] T000121_A21SocioFoto ;
      private short[] T000122_A1ActividadId ;
      private short[] T000122_A5SocioId ;
      private GXWebForm Form ;
      private SdtTransactionContext AV9TrnContext ;
   }

   public class actividad__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new UpdateCursor(def[9])
         ,new UpdateCursor(def[10])
         ,new UpdateCursor(def[11])
         ,new ForEachCursor(def[12])
         ,new ForEachCursor(def[13])
         ,new ForEachCursor(def[14])
         ,new ForEachCursor(def[15])
         ,new ForEachCursor(def[16])
         ,new UpdateCursor(def[17])
         ,new UpdateCursor(def[18])
         ,new ForEachCursor(def[19])
         ,new ForEachCursor(def[20])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT00017 ;
          prmT00017 = new Object[] {
          new Object[] {"@ActividadId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00018 ;
          prmT00018 = new Object[] {
          new Object[] {"@ActividadId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00016 ;
          prmT00016 = new Object[] {
          new Object[] {"@ActividadId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00019 ;
          prmT00019 = new Object[] {
          new Object[] {"@ActividadId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000110 ;
          prmT000110 = new Object[] {
          new Object[] {"@ActividadId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00015 ;
          prmT00015 = new Object[] {
          new Object[] {"@ActividadId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000111 ;
          prmT000111 = new Object[] {
          new Object[] {"@ActividadId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ActividadDescripcion",SqlDbType.Char,20,0} ,
          new Object[] {"@ActividadTipo",SqlDbType.Char,20,0}
          } ;
          Object[] prmT000112 ;
          prmT000112 = new Object[] {
          new Object[] {"@ActividadDescripcion",SqlDbType.Char,20,0} ,
          new Object[] {"@ActividadTipo",SqlDbType.Char,20,0} ,
          new Object[] {"@ActividadId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000113 ;
          prmT000113 = new Object[] {
          new Object[] {"@ActividadId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000114 ;
          prmT000114 = new Object[] {
          new Object[] {"@ActividadId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000115 ;
          prmT000115 = new Object[] {
          } ;
          Object[] prmT000116 ;
          prmT000116 = new Object[] {
          new Object[] {"@ActividadId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@SocioId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00014 ;
          prmT00014 = new Object[] {
          new Object[] {"@SocioId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000117 ;
          prmT000117 = new Object[] {
          new Object[] {"@SocioId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000118 ;
          prmT000118 = new Object[] {
          new Object[] {"@ActividadId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@SocioId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00013 ;
          prmT00013 = new Object[] {
          new Object[] {"@ActividadId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@SocioId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00012 ;
          prmT00012 = new Object[] {
          new Object[] {"@ActividadId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@SocioId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000119 ;
          prmT000119 = new Object[] {
          new Object[] {"@ActividadId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@SocioId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000120 ;
          prmT000120 = new Object[] {
          new Object[] {"@ActividadId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@SocioId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000122 ;
          prmT000122 = new Object[] {
          new Object[] {"@ActividadId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000121 ;
          prmT000121 = new Object[] {
          new Object[] {"@SocioId",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T00012", "SELECT [ActividadId], [SocioId] FROM [ActividadSocioEnActividad] WITH (UPDLOCK) WHERE [ActividadId] = @ActividadId AND [SocioId] = @SocioId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00012,1,0,true,false )
             ,new CursorDef("T00013", "SELECT [ActividadId], [SocioId] FROM [ActividadSocioEnActividad] WITH (NOLOCK) WHERE [ActividadId] = @ActividadId AND [SocioId] = @SocioId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00013,1,0,true,false )
             ,new CursorDef("T00014", "SELECT [SocioDireccion], [SocioFoto_GXI], [SocioEdad], [SocioReconocido], [SocioSexo], [SocioFoto] FROM [Socio] WITH (NOLOCK) WHERE [SocioId] = @SocioId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00014,1,0,true,false )
             ,new CursorDef("T00015", "SELECT [ActividadId], [ActividadDescripcion], [ActividadTipo] FROM [Actividad1] WITH (UPDLOCK) WHERE [ActividadId] = @ActividadId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00015,1,0,true,false )
             ,new CursorDef("T00016", "SELECT [ActividadId], [ActividadDescripcion], [ActividadTipo] FROM [Actividad1] WITH (NOLOCK) WHERE [ActividadId] = @ActividadId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00016,1,0,true,false )
             ,new CursorDef("T00017", "SELECT TM1.[ActividadId], TM1.[ActividadDescripcion], TM1.[ActividadTipo] FROM [Actividad1] TM1 WITH (NOLOCK) WHERE TM1.[ActividadId] = @ActividadId ORDER BY TM1.[ActividadId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00017,100,0,true,false )
             ,new CursorDef("T00018", "SELECT [ActividadId] FROM [Actividad1] WITH (NOLOCK) WHERE [ActividadId] = @ActividadId  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00018,1,0,true,false )
             ,new CursorDef("T00019", "SELECT TOP 1 [ActividadId] FROM [Actividad1] WITH (NOLOCK) WHERE ( [ActividadId] > @ActividadId) ORDER BY [ActividadId]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00019,1,0,true,true )
             ,new CursorDef("T000110", "SELECT TOP 1 [ActividadId] FROM [Actividad1] WITH (NOLOCK) WHERE ( [ActividadId] < @ActividadId) ORDER BY [ActividadId] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000110,1,0,true,true )
             ,new CursorDef("T000111", "INSERT INTO [Actividad1]([ActividadId], [ActividadDescripcion], [ActividadTipo]) VALUES(@ActividadId, @ActividadDescripcion, @ActividadTipo)", GxErrorMask.GX_NOMASK,prmT000111)
             ,new CursorDef("T000112", "UPDATE [Actividad1] SET [ActividadDescripcion]=@ActividadDescripcion, [ActividadTipo]=@ActividadTipo  WHERE [ActividadId] = @ActividadId", GxErrorMask.GX_NOMASK,prmT000112)
             ,new CursorDef("T000113", "DELETE FROM [Actividad1]  WHERE [ActividadId] = @ActividadId", GxErrorMask.GX_NOMASK,prmT000113)
             ,new CursorDef("T000114", "SELECT TOP 1 [ProfesorId] FROM [Profesor] WITH (NOLOCK) WHERE [ActividadId] = @ActividadId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000114,1,0,true,true )
             ,new CursorDef("T000115", "SELECT [ActividadId] FROM [Actividad1] WITH (NOLOCK) ORDER BY [ActividadId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000115,100,0,true,false )
             ,new CursorDef("T000116", "SELECT T1.[ActividadId], T2.[SocioDireccion], T2.[SocioFoto_GXI], T2.[SocioEdad], T2.[SocioReconocido], T2.[SocioSexo], T1.[SocioId], T2.[SocioFoto] FROM ([ActividadSocioEnActividad] T1 WITH (NOLOCK) INNER JOIN [Socio] T2 WITH (NOLOCK) ON T2.[SocioId] = T1.[SocioId]) WHERE T1.[ActividadId] = @ActividadId and T1.[SocioId] = @SocioId ORDER BY T1.[ActividadId], T1.[SocioId] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000116,11,0,true,false )
             ,new CursorDef("T000117", "SELECT [SocioDireccion], [SocioFoto_GXI], [SocioEdad], [SocioReconocido], [SocioSexo], [SocioFoto] FROM [Socio] WITH (NOLOCK) WHERE [SocioId] = @SocioId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000117,1,0,true,false )
             ,new CursorDef("T000118", "SELECT [ActividadId], [SocioId] FROM [ActividadSocioEnActividad] WITH (NOLOCK) WHERE [ActividadId] = @ActividadId AND [SocioId] = @SocioId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000118,1,0,true,false )
             ,new CursorDef("T000119", "INSERT INTO [ActividadSocioEnActividad]([ActividadId], [SocioId]) VALUES(@ActividadId, @SocioId)", GxErrorMask.GX_NOMASK,prmT000119)
             ,new CursorDef("T000120", "DELETE FROM [ActividadSocioEnActividad]  WHERE [ActividadId] = @ActividadId AND [SocioId] = @SocioId", GxErrorMask.GX_NOMASK,prmT000120)
             ,new CursorDef("T000121", "SELECT [SocioDireccion], [SocioFoto_GXI], [SocioEdad], [SocioReconocido], [SocioSexo], [SocioFoto] FROM [Socio] WITH (NOLOCK) WHERE [SocioId] = @SocioId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000121,1,0,true,false )
             ,new CursorDef("T000122", "SELECT [ActividadId], [SocioId] FROM [ActividadSocioEnActividad] WITH (NOLOCK) WHERE [ActividadId] = @ActividadId ORDER BY [ActividadId], [SocioId] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000122,11,0,true,false )
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
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getMultimediaUri(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 20) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 20) ;
                ((String[]) buf[5])[0] = rslt.getMultimediaFile(6, rslt.getVarchar(2)) ;
                return;
             case 3 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 20) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 20) ;
                return;
             case 4 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 20) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 20) ;
                return;
             case 5 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 20) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 20) ;
                return;
             case 6 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 7 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 8 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 12 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 13 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 14 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getMultimediaUri(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 20) ;
                ((String[]) buf[5])[0] = rslt.getString(6, 20) ;
                ((short[]) buf[6])[0] = rslt.getShort(7) ;
                ((String[]) buf[7])[0] = rslt.getMultimediaFile(8, rslt.getVarchar(3)) ;
                return;
             case 15 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getMultimediaUri(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 20) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 20) ;
                ((String[]) buf[5])[0] = rslt.getMultimediaFile(6, rslt.getVarchar(2)) ;
                return;
             case 16 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                return;
             case 19 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getMultimediaUri(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 20) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 20) ;
                ((String[]) buf[5])[0] = rslt.getMultimediaFile(6, rslt.getVarchar(2)) ;
                return;
             case 20 :
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
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                return;
             case 10 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 11 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 12 :
                stmt.SetParameter(1, (short)parms[0]);
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
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 17 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 18 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 19 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 20 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
       }
    }

 }

}
