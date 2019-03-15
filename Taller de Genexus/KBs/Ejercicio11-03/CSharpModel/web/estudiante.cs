/*
               File: Estudiante
        Description: Estudiante
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 3/14/2019 20:6:59.89
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
   public class estudiante : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_10") == 0 )
         {
            A20EstudiantePersonaId = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20EstudiantePersonaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A20EstudiantePersonaId), 4, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_10( A20EstudiantePersonaId) ;
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
               AV7EstudianteNumero = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7EstudianteNumero", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7EstudianteNumero), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vESTUDIANTENUMERO", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7EstudianteNumero), "ZZZ9"), context));
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
            Form.Meta.addItem("description", "Estudiante", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtEstudianteNumero_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("Carmine");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public estudiante( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public estudiante( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( String aP0_Gx_mode ,
                           short aP1_EstudianteNumero )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV7EstudianteNumero = aP1_EstudianteNumero;
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
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "Estudiante", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_Estudiante.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "", bttBtn_first_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_first_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Estudiante.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "", bttBtn_previous_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_previous_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_Estudiante.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", "", bttBtn_next_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_next_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_Estudiante.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", "", bttBtn_last_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_last_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Estudiante.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Select", bttBtn_select_Jsonclick, 5, "Select", "", StyleString, ClassString, bttBtn_select_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "", 2, "HLP_Estudiante.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtEstudianteNumero_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtEstudianteNumero_Internalname, "Numero", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtEstudianteNumero_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A11EstudianteNumero), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A11EstudianteNumero), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,34);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtEstudianteNumero_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtEstudianteNumero_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Estudiante.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtEstudiantePersonaId_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtEstudiantePersonaId_Internalname, "Persona Id", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtEstudiantePersonaId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A20EstudiantePersonaId), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A20EstudiantePersonaId), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,39);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtEstudiantePersonaId_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtEstudiantePersonaId_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Estudiante.htm");
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "prompt.gif", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgprompt_20_Internalname, sImgUrl, imgprompt_20_Link, "", "", context.GetTheme( ), imgprompt_20_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_Estudiante.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtEstudiantePersonaNombre_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtEstudiantePersonaNombre_Internalname, "Persona Nombre", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtEstudiantePersonaNombre_Internalname, StringUtil.RTrim( A21EstudiantePersonaNombre), StringUtil.RTrim( context.localUtil.Format( A21EstudiantePersonaNombre, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtEstudiantePersonaNombre_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtEstudiantePersonaNombre_Enabled, 0, "text", "", 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Estudiante.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 49,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirm", bttBtn_enter_Jsonclick, 5, "Confirm", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_Estudiante.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 51,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancel", bttBtn_cancel_Jsonclick, 1, "Cancel", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Estudiante.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Delete", bttBtn_delete_Jsonclick, 5, "Delete", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_Estudiante.htm");
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
         E11032 ();
         context.wbGlbDoneStart = 1;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read variables values. */
               if ( ( ( context.localUtil.CToN( cgiGet( edtEstudianteNumero_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtEstudianteNumero_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "ESTUDIANTENUMERO");
                  AnyError = 1;
                  GX_FocusControl = edtEstudianteNumero_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A11EstudianteNumero = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11EstudianteNumero", StringUtil.LTrim( StringUtil.Str( (decimal)(A11EstudianteNumero), 4, 0)));
               }
               else
               {
                  A11EstudianteNumero = (short)(context.localUtil.CToN( cgiGet( edtEstudianteNumero_Internalname), ".", ","));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11EstudianteNumero", StringUtil.LTrim( StringUtil.Str( (decimal)(A11EstudianteNumero), 4, 0)));
               }
               if ( ( ( context.localUtil.CToN( cgiGet( edtEstudiantePersonaId_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtEstudiantePersonaId_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "ESTUDIANTEPERSONAID");
                  AnyError = 1;
                  GX_FocusControl = edtEstudiantePersonaId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A20EstudiantePersonaId = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20EstudiantePersonaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A20EstudiantePersonaId), 4, 0)));
               }
               else
               {
                  A20EstudiantePersonaId = (short)(context.localUtil.CToN( cgiGet( edtEstudiantePersonaId_Internalname), ".", ","));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20EstudiantePersonaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A20EstudiantePersonaId), 4, 0)));
               }
               A21EstudiantePersonaNombre = cgiGet( edtEstudiantePersonaNombre_Internalname);
               n21EstudiantePersonaNombre = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A21EstudiantePersonaNombre", A21EstudiantePersonaNombre);
               /* Read saved values. */
               Z11EstudianteNumero = (short)(context.localUtil.CToN( cgiGet( "Z11EstudianteNumero"), ".", ","));
               Z20EstudiantePersonaId = (short)(context.localUtil.CToN( cgiGet( "Z20EstudiantePersonaId"), ".", ","));
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ","));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ".", ","));
               Gx_mode = cgiGet( "Mode");
               N20EstudiantePersonaId = (short)(context.localUtil.CToN( cgiGet( "N20EstudiantePersonaId"), ".", ","));
               AV7EstudianteNumero = (short)(context.localUtil.CToN( cgiGet( "vESTUDIANTENUMERO"), ".", ","));
               AV11Insert_EstudiantePersonaId = (short)(context.localUtil.CToN( cgiGet( "vINSERT_ESTUDIANTEPERSONAID"), ".", ","));
               AV13Pgmname = cgiGet( "vPGMNAME");
               Gx_mode = cgiGet( "vMODE");
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               forbiddenHiddens = "hsh" + "Estudiante";
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV11Insert_EstudiantePersonaId), "ZZZ9");
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( A11EstudianteNumero != Z11EstudianteNumero ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
               {
                  GXUtil.WriteLog("estudiante:[SecurityCheckFailed value for]"+"Insert_EstudiantePersonaId:"+context.localUtil.Format( (decimal)(AV11Insert_EstudiantePersonaId), "ZZZ9"));
                  GXUtil.WriteLog("estudiante:[SecurityCheckFailed value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
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
                  A11EstudianteNumero = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11EstudianteNumero", StringUtil.LTrim( StringUtil.Str( (decimal)(A11EstudianteNumero), 4, 0)));
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
                     sMode3 = Gx_mode;
                     Gx_mode = "UPD";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     Gx_mode = sMode3;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound3 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_030( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtn_enter_Internalname;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert", ""), 1, "ESTUDIANTENUMERO");
                        AnyError = 1;
                        GX_FocusControl = edtEstudianteNumero_Internalname;
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
                           E11032 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: After Trn */
                           E12032 ();
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
            E12032 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll033( ) ;
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
            DisableAttributes033( ) ;
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

      protected void CONFIRM_030( )
      {
         BeforeValidate033( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls033( ) ;
            }
            else
            {
               CheckExtendedTable033( ) ;
               CloseExtendedTableCursors033( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         }
      }

      protected void ResetCaption030( )
      {
      }

      protected void E11032( )
      {
         /* Start Routine */
         if ( ! new isauthorized(context).executeUdp(  AV13Pgmname) )
         {
            CallWebObject(formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV13Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         AV9TrnContext.FromXml(AV10WebSession.Get("TrnContext"), null, "TransactionContext", "Ejercicio1103");
         AV11Insert_EstudiantePersonaId = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11Insert_EstudiantePersonaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11Insert_EstudiantePersonaId), 4, 0)));
         if ( ( StringUtil.StrCmp(AV9TrnContext.gxTpr_Transactionname, AV13Pgmname) == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) )
         {
            AV14GXV1 = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14GXV1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14GXV1), 8, 0)));
            while ( AV14GXV1 <= AV9TrnContext.gxTpr_Attributes.Count )
            {
               AV12TrnContextAtt = ((SdtTransactionContext_Attribute)AV9TrnContext.gxTpr_Attributes.Item(AV14GXV1));
               if ( StringUtil.StrCmp(AV12TrnContextAtt.gxTpr_Attributename, "EstudiantePersonaId") == 0 )
               {
                  AV11Insert_EstudiantePersonaId = (short)(NumberUtil.Val( AV12TrnContextAtt.gxTpr_Attributevalue, "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11Insert_EstudiantePersonaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11Insert_EstudiantePersonaId), 4, 0)));
               }
               AV14GXV1 = (int)(AV14GXV1+1);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14GXV1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14GXV1), 8, 0)));
            }
         }
      }

      protected void E12032( )
      {
         /* After Trn Routine */
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV9TrnContext.gxTpr_Callerondelete )
         {
            CallWebObject(formatLink("wwestudiante.aspx") );
            context.wjLocDisableFrm = 1;
         }
         context.setWebReturnParms(new Object[] {});
         context.setWebReturnParmsMetadata(new Object[] {});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      protected void ZM033( short GX_JID )
      {
         if ( ( GX_JID == 9 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z20EstudiantePersonaId = T00033_A20EstudiantePersonaId[0];
            }
            else
            {
               Z20EstudiantePersonaId = A20EstudiantePersonaId;
            }
         }
         if ( GX_JID == -9 )
         {
            Z11EstudianteNumero = A11EstudianteNumero;
            Z20EstudiantePersonaId = A20EstudiantePersonaId;
            Z21EstudiantePersonaNombre = A21EstudiantePersonaNombre;
         }
      }

      protected void standaloneNotModal( )
      {
         imgprompt_20_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0020.aspx"+"',["+"{Ctrl:gx.dom.el('"+"ESTUDIANTEPERSONAID"+"'), id:'"+"ESTUDIANTEPERSONAID"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"false"+");");
         bttBtn_delete_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Enabled), 5, 0)), true);
         if ( ! (0==AV7EstudianteNumero) )
         {
            A11EstudianteNumero = AV7EstudianteNumero;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11EstudianteNumero", StringUtil.LTrim( StringUtil.Str( (decimal)(A11EstudianteNumero), 4, 0)));
         }
         if ( ! (0==AV7EstudianteNumero) )
         {
            edtEstudianteNumero_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtEstudianteNumero_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtEstudianteNumero_Enabled), 5, 0)), true);
         }
         else
         {
            edtEstudianteNumero_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtEstudianteNumero_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtEstudianteNumero_Enabled), 5, 0)), true);
         }
         if ( ! (0==AV7EstudianteNumero) )
         {
            edtEstudianteNumero_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtEstudianteNumero_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtEstudianteNumero_Enabled), 5, 0)), true);
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV11Insert_EstudiantePersonaId) )
         {
            edtEstudiantePersonaId_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtEstudiantePersonaId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtEstudiantePersonaId_Enabled), 5, 0)), true);
         }
         else
         {
            edtEstudiantePersonaId_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtEstudiantePersonaId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtEstudiantePersonaId_Enabled), 5, 0)), true);
         }
      }

      protected void standaloneModal( )
      {
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV11Insert_EstudiantePersonaId) )
         {
            A20EstudiantePersonaId = AV11Insert_EstudiantePersonaId;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20EstudiantePersonaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A20EstudiantePersonaId), 4, 0)));
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
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ( Gx_BScreen == 0 ) )
         {
            AV13Pgmname = "Estudiante";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13Pgmname", AV13Pgmname);
            /* Using cursor T00034 */
            pr_default.execute(2, new Object[] {A20EstudiantePersonaId});
            A21EstudiantePersonaNombre = T00034_A21EstudiantePersonaNombre[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A21EstudiantePersonaNombre", A21EstudiantePersonaNombre);
            n21EstudiantePersonaNombre = T00034_n21EstudiantePersonaNombre[0];
            pr_default.close(2);
         }
      }

      protected void Load033( )
      {
         /* Using cursor T00035 */
         pr_default.execute(3, new Object[] {A11EstudianteNumero});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound3 = 1;
            A21EstudiantePersonaNombre = T00035_A21EstudiantePersonaNombre[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A21EstudiantePersonaNombre", A21EstudiantePersonaNombre);
            n21EstudiantePersonaNombre = T00035_n21EstudiantePersonaNombre[0];
            A20EstudiantePersonaId = T00035_A20EstudiantePersonaId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20EstudiantePersonaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A20EstudiantePersonaId), 4, 0)));
            ZM033( -9) ;
         }
         pr_default.close(3);
         OnLoadActions033( ) ;
      }

      protected void OnLoadActions033( )
      {
         AV13Pgmname = "Estudiante";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13Pgmname", AV13Pgmname);
      }

      protected void CheckExtendedTable033( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
         AV13Pgmname = "Estudiante";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13Pgmname", AV13Pgmname);
         /* Using cursor T00034 */
         pr_default.execute(2, new Object[] {A20EstudiantePersonaId});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("No matching 'Estudiante Persona'.", "ForeignKeyNotFound", 1, "ESTUDIANTEPERSONAID");
            AnyError = 1;
            GX_FocusControl = edtEstudiantePersonaId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A21EstudiantePersonaNombre = T00034_A21EstudiantePersonaNombre[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A21EstudiantePersonaNombre", A21EstudiantePersonaNombre);
         n21EstudiantePersonaNombre = T00034_n21EstudiantePersonaNombre[0];
         pr_default.close(2);
      }

      protected void CloseExtendedTableCursors033( )
      {
         pr_default.close(2);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_10( short A20EstudiantePersonaId )
      {
         /* Using cursor T00036 */
         pr_default.execute(4, new Object[] {A20EstudiantePersonaId});
         if ( (pr_default.getStatus(4) == 101) )
         {
            GX_msglist.addItem("No matching 'Estudiante Persona'.", "ForeignKeyNotFound", 1, "ESTUDIANTEPERSONAID");
            AnyError = 1;
            GX_FocusControl = edtEstudiantePersonaId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A21EstudiantePersonaNombre = T00036_A21EstudiantePersonaNombre[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A21EstudiantePersonaNombre", A21EstudiantePersonaNombre);
         n21EstudiantePersonaNombre = T00036_n21EstudiantePersonaNombre[0];
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A21EstudiantePersonaNombre))+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(4) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(4);
      }

      protected void GetKey033( )
      {
         /* Using cursor T00037 */
         pr_default.execute(5, new Object[] {A11EstudianteNumero});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound3 = 1;
         }
         else
         {
            RcdFound3 = 0;
         }
         pr_default.close(5);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00033 */
         pr_default.execute(1, new Object[] {A11EstudianteNumero});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM033( 9) ;
            RcdFound3 = 1;
            A11EstudianteNumero = T00033_A11EstudianteNumero[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11EstudianteNumero", StringUtil.LTrim( StringUtil.Str( (decimal)(A11EstudianteNumero), 4, 0)));
            A20EstudiantePersonaId = T00033_A20EstudiantePersonaId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20EstudiantePersonaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A20EstudiantePersonaId), 4, 0)));
            Z11EstudianteNumero = A11EstudianteNumero;
            sMode3 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load033( ) ;
            if ( AnyError == 1 )
            {
               RcdFound3 = 0;
               InitializeNonKey033( ) ;
            }
            Gx_mode = sMode3;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound3 = 0;
            InitializeNonKey033( ) ;
            sMode3 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal( ) ;
            Gx_mode = sMode3;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey033( ) ;
         if ( RcdFound3 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound3 = 0;
         /* Using cursor T00038 */
         pr_default.execute(6, new Object[] {A11EstudianteNumero});
         if ( (pr_default.getStatus(6) != 101) )
         {
            while ( (pr_default.getStatus(6) != 101) && ( ( T00038_A11EstudianteNumero[0] < A11EstudianteNumero ) ) )
            {
               pr_default.readNext(6);
            }
            if ( (pr_default.getStatus(6) != 101) && ( ( T00038_A11EstudianteNumero[0] > A11EstudianteNumero ) ) )
            {
               A11EstudianteNumero = T00038_A11EstudianteNumero[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11EstudianteNumero", StringUtil.LTrim( StringUtil.Str( (decimal)(A11EstudianteNumero), 4, 0)));
               RcdFound3 = 1;
            }
         }
         pr_default.close(6);
      }

      protected void move_previous( )
      {
         RcdFound3 = 0;
         /* Using cursor T00039 */
         pr_default.execute(7, new Object[] {A11EstudianteNumero});
         if ( (pr_default.getStatus(7) != 101) )
         {
            while ( (pr_default.getStatus(7) != 101) && ( ( T00039_A11EstudianteNumero[0] > A11EstudianteNumero ) ) )
            {
               pr_default.readNext(7);
            }
            if ( (pr_default.getStatus(7) != 101) && ( ( T00039_A11EstudianteNumero[0] < A11EstudianteNumero ) ) )
            {
               A11EstudianteNumero = T00039_A11EstudianteNumero[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11EstudianteNumero", StringUtil.LTrim( StringUtil.Str( (decimal)(A11EstudianteNumero), 4, 0)));
               RcdFound3 = 1;
            }
         }
         pr_default.close(7);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey033( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtEstudianteNumero_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert033( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound3 == 1 )
            {
               if ( A11EstudianteNumero != Z11EstudianteNumero )
               {
                  A11EstudianteNumero = Z11EstudianteNumero;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11EstudianteNumero", StringUtil.LTrim( StringUtil.Str( (decimal)(A11EstudianteNumero), 4, 0)));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "ESTUDIANTENUMERO");
                  AnyError = 1;
                  GX_FocusControl = edtEstudianteNumero_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtEstudianteNumero_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Update record */
                  Update033( ) ;
                  GX_FocusControl = edtEstudianteNumero_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A11EstudianteNumero != Z11EstudianteNumero )
               {
                  /* Insert record */
                  GX_FocusControl = edtEstudianteNumero_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert033( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "ESTUDIANTENUMERO");
                     AnyError = 1;
                     GX_FocusControl = edtEstudianteNumero_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     /* Insert record */
                     GX_FocusControl = edtEstudianteNumero_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert033( ) ;
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
         if ( A11EstudianteNumero != Z11EstudianteNumero )
         {
            A11EstudianteNumero = Z11EstudianteNumero;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11EstudianteNumero", StringUtil.LTrim( StringUtil.Str( (decimal)(A11EstudianteNumero), 4, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "ESTUDIANTENUMERO");
            AnyError = 1;
            GX_FocusControl = edtEstudianteNumero_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtEstudianteNumero_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency033( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00032 */
            pr_default.execute(0, new Object[] {A11EstudianteNumero});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Estudiante"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( Z20EstudiantePersonaId != T00032_A20EstudiantePersonaId[0] ) )
            {
               if ( Z20EstudiantePersonaId != T00032_A20EstudiantePersonaId[0] )
               {
                  GXUtil.WriteLog("estudiante:[seudo value changed for attri]"+"EstudiantePersonaId");
                  GXUtil.WriteLogRaw("Old: ",Z20EstudiantePersonaId);
                  GXUtil.WriteLogRaw("Current: ",T00032_A20EstudiantePersonaId[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Estudiante"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert033( )
      {
         BeforeValidate033( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable033( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM033( 0) ;
            CheckOptimisticConcurrency033( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm033( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert033( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000310 */
                     pr_default.execute(8, new Object[] {A11EstudianteNumero, A20EstudiantePersonaId});
                     pr_default.close(8);
                     dsDefault.SmartCacheProvider.SetUpdated("Estudiante") ;
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
                           /* Save values for previous() function. */
                           GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                           ResetCaption030( ) ;
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
               Load033( ) ;
            }
            EndLevel033( ) ;
         }
         CloseExtendedTableCursors033( ) ;
      }

      protected void Update033( )
      {
         BeforeValidate033( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable033( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency033( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm033( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate033( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000311 */
                     pr_default.execute(9, new Object[] {A20EstudiantePersonaId, A11EstudianteNumero});
                     pr_default.close(9);
                     dsDefault.SmartCacheProvider.SetUpdated("Estudiante") ;
                     if ( (pr_default.getStatus(9) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Estudiante"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate033( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
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
            EndLevel033( ) ;
         }
         CloseExtendedTableCursors033( ) ;
      }

      protected void DeferredUpdate033( )
      {
      }

      protected void delete( )
      {
         BeforeValidate033( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency033( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls033( ) ;
            AfterConfirm033( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete033( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000312 */
                  pr_default.execute(10, new Object[] {A11EstudianteNumero});
                  pr_default.close(10);
                  dsDefault.SmartCacheProvider.SetUpdated("Estudiante") ;
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
         sMode3 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel033( ) ;
         Gx_mode = sMode3;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls033( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV13Pgmname = "Estudiante";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13Pgmname", AV13Pgmname);
            /* Using cursor T000313 */
            pr_default.execute(11, new Object[] {A20EstudiantePersonaId});
            A21EstudiantePersonaNombre = T000313_A21EstudiantePersonaNombre[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A21EstudiantePersonaNombre", A21EstudiantePersonaNombre);
            n21EstudiantePersonaNombre = T000313_n21EstudiantePersonaNombre[0];
            pr_default.close(11);
         }
      }

      protected void EndLevel033( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete033( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(1);
            pr_default.close(11);
            context.CommitDataStores("estudiante",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues030( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(1);
            pr_default.close(11);
            context.RollbackDataStores("estudiante",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart033( )
      {
         /* Scan By routine */
         /* Using cursor T000314 */
         pr_default.execute(12);
         RcdFound3 = 0;
         if ( (pr_default.getStatus(12) != 101) )
         {
            RcdFound3 = 1;
            A11EstudianteNumero = T000314_A11EstudianteNumero[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11EstudianteNumero", StringUtil.LTrim( StringUtil.Str( (decimal)(A11EstudianteNumero), 4, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext033( )
      {
         /* Scan next routine */
         pr_default.readNext(12);
         RcdFound3 = 0;
         if ( (pr_default.getStatus(12) != 101) )
         {
            RcdFound3 = 1;
            A11EstudianteNumero = T000314_A11EstudianteNumero[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11EstudianteNumero", StringUtil.LTrim( StringUtil.Str( (decimal)(A11EstudianteNumero), 4, 0)));
         }
      }

      protected void ScanEnd033( )
      {
         pr_default.close(12);
      }

      protected void AfterConfirm033( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert033( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate033( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete033( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete033( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate033( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes033( )
      {
         edtEstudianteNumero_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtEstudianteNumero_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtEstudianteNumero_Enabled), 5, 0)), true);
         edtEstudiantePersonaId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtEstudiantePersonaId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtEstudiantePersonaId_Enabled), 5, 0)), true);
         edtEstudiantePersonaNombre_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtEstudiantePersonaNombre_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtEstudiantePersonaNombre_Enabled), 5, 0)), true);
      }

      protected void send_integrity_lvl_hashes033( )
      {
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues030( )
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
         context.AddJavascriptSource("gxcfg.js", "?2019314207124", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("estudiante.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7EstudianteNumero)+"\">") ;
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
         forbiddenHiddens = "hsh" + "Estudiante";
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV11Insert_EstudiantePersonaId), "ZZZ9");
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("estudiante:[SendSecurityCheck value for]"+"Insert_EstudiantePersonaId:"+context.localUtil.Format( (decimal)(AV11Insert_EstudiantePersonaId), "ZZZ9"));
         GXUtil.WriteLog("estudiante:[SendSecurityCheck value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z11EstudianteNumero", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z11EstudianteNumero), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z20EstudiantePersonaId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z20EstudiantePersonaId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_Mode", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GxWebStd.gx_hidden_field( context, "N20EstudiantePersonaId", StringUtil.LTrim( StringUtil.NToC( (decimal)(A20EstudiantePersonaId), 4, 0, ".", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vTRNCONTEXT", AV9TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vTRNCONTEXT", AV9TrnContext);
         }
         GxWebStd.gx_hidden_field( context, "vESTUDIANTENUMERO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7EstudianteNumero), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vESTUDIANTENUMERO", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7EstudianteNumero), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vINSERT_ESTUDIANTEPERSONAID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11Insert_EstudiantePersonaId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV13Pgmname));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
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
         return formatLink("estudiante.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7EstudianteNumero) ;
      }

      public override String GetPgmname( )
      {
         return "Estudiante" ;
      }

      public override String GetPgmdesc( )
      {
         return "Estudiante" ;
      }

      protected void InitializeNonKey033( )
      {
         A20EstudiantePersonaId = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20EstudiantePersonaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A20EstudiantePersonaId), 4, 0)));
         A21EstudiantePersonaNombre = "";
         n21EstudiantePersonaNombre = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A21EstudiantePersonaNombre", A21EstudiantePersonaNombre);
         Z20EstudiantePersonaId = 0;
      }

      protected void InitAll033( )
      {
         A11EstudianteNumero = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11EstudianteNumero", StringUtil.LTrim( StringUtil.Str( (decimal)(A11EstudianteNumero), 4, 0)));
         InitializeNonKey033( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2019314207133", true);
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
         context.AddJavascriptSource("estudiante.js", "?2019314207133", false);
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
         edtEstudianteNumero_Internalname = "ESTUDIANTENUMERO";
         edtEstudiantePersonaId_Internalname = "ESTUDIANTEPERSONAID";
         edtEstudiantePersonaNombre_Internalname = "ESTUDIANTEPERSONANOMBRE";
         divFormcontainer_Internalname = "FORMCONTAINER";
         bttBtn_enter_Internalname = "BTN_ENTER";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         bttBtn_delete_Internalname = "BTN_DELETE";
         divMaintable_Internalname = "MAINTABLE";
         Form.Internalname = "FORM";
         imgprompt_20_Internalname = "PROMPT_20";
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
         Form.Caption = "Estudiante";
         bttBtn_delete_Enabled = 0;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edtEstudiantePersonaNombre_Jsonclick = "";
         edtEstudiantePersonaNombre_Enabled = 0;
         imgprompt_20_Visible = 1;
         imgprompt_20_Link = "";
         edtEstudiantePersonaId_Jsonclick = "";
         edtEstudiantePersonaId_Enabled = 1;
         edtEstudianteNumero_Jsonclick = "";
         edtEstudianteNumero_Enabled = 1;
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

      protected void init_web_controls( )
      {
         /* End function init_web_controls */
      }

      public void Valid_Estudiantepersonaid( short GX_Parm1 ,
                                             String GX_Parm2 )
      {
         A20EstudiantePersonaId = GX_Parm1;
         A21EstudiantePersonaNombre = GX_Parm2;
         n21EstudiantePersonaNombre = false;
         /* Using cursor T000313 */
         pr_default.execute(11, new Object[] {A20EstudiantePersonaId});
         if ( (pr_default.getStatus(11) == 101) )
         {
            GX_msglist.addItem("No matching 'Estudiante Persona'.", "ForeignKeyNotFound", 1, "ESTUDIANTEPERSONAID");
            AnyError = 1;
            GX_FocusControl = edtEstudiantePersonaId_Internalname;
         }
         A21EstudiantePersonaNombre = T000313_A21EstudiantePersonaNombre[0];
         n21EstudiantePersonaNombre = T000313_n21EstudiantePersonaNombre[0];
         pr_default.close(11);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A21EstudiantePersonaNombre = "";
            n21EstudiantePersonaNombre = false;
         }
         isValidOutput.Add(StringUtil.RTrim( A21EstudiantePersonaNombre));
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
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7EstudianteNumero',fld:'vESTUDIANTENUMERO',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7EstudianteNumero',fld:'vESTUDIANTENUMERO',pic:'ZZZ9',hsh:true},{av:'AV11Insert_EstudiantePersonaId',fld:'vINSERT_ESTUDIANTEPERSONAID',pic:'ZZZ9'}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("AFTER TRN","{handler:'E12032',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV9TrnContext',fld:'vTRNCONTEXT',pic:''}]");
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
         pr_default.close(11);
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
         sImgUrl = "";
         A21EstudiantePersonaNombre = "";
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         AV13Pgmname = "";
         forbiddenHiddens = "";
         hsh = "";
         sMode3 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV9TrnContext = new SdtTransactionContext(context);
         AV10WebSession = context.GetSession();
         AV12TrnContextAtt = new SdtTransactionContext_Attribute(context);
         Z21EstudiantePersonaNombre = "";
         T00034_A21EstudiantePersonaNombre = new String[] {""} ;
         T00034_n21EstudiantePersonaNombre = new bool[] {false} ;
         T00035_A11EstudianteNumero = new short[1] ;
         T00035_A21EstudiantePersonaNombre = new String[] {""} ;
         T00035_n21EstudiantePersonaNombre = new bool[] {false} ;
         T00035_A20EstudiantePersonaId = new short[1] ;
         T00036_A21EstudiantePersonaNombre = new String[] {""} ;
         T00036_n21EstudiantePersonaNombre = new bool[] {false} ;
         T00037_A11EstudianteNumero = new short[1] ;
         T00033_A11EstudianteNumero = new short[1] ;
         T00033_A20EstudiantePersonaId = new short[1] ;
         T00038_A11EstudianteNumero = new short[1] ;
         T00039_A11EstudianteNumero = new short[1] ;
         T00032_A11EstudianteNumero = new short[1] ;
         T00032_A20EstudiantePersonaId = new short[1] ;
         T000313_A21EstudiantePersonaNombre = new String[] {""} ;
         T000313_n21EstudiantePersonaNombre = new bool[] {false} ;
         T000314_A11EstudianteNumero = new short[1] ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         isValidOutput = new GxUnknownObjectCollection();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.estudiante__default(),
            new Object[][] {
                new Object[] {
               T00032_A11EstudianteNumero, T00032_A20EstudiantePersonaId
               }
               , new Object[] {
               T00033_A11EstudianteNumero, T00033_A20EstudiantePersonaId
               }
               , new Object[] {
               T00034_A21EstudiantePersonaNombre, T00034_n21EstudiantePersonaNombre
               }
               , new Object[] {
               T00035_A11EstudianteNumero, T00035_A21EstudiantePersonaNombre, T00035_n21EstudiantePersonaNombre, T00035_A20EstudiantePersonaId
               }
               , new Object[] {
               T00036_A21EstudiantePersonaNombre, T00036_n21EstudiantePersonaNombre
               }
               , new Object[] {
               T00037_A11EstudianteNumero
               }
               , new Object[] {
               T00038_A11EstudianteNumero
               }
               , new Object[] {
               T00039_A11EstudianteNumero
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000313_A21EstudiantePersonaNombre, T000313_n21EstudiantePersonaNombre
               }
               , new Object[] {
               T000314_A11EstudianteNumero
               }
            }
         );
         AV13Pgmname = "Estudiante";
      }

      private short wcpOAV7EstudianteNumero ;
      private short Z11EstudianteNumero ;
      private short Z20EstudiantePersonaId ;
      private short N20EstudiantePersonaId ;
      private short GxWebError ;
      private short A20EstudiantePersonaId ;
      private short AV7EstudianteNumero ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short A11EstudianteNumero ;
      private short AV11Insert_EstudiantePersonaId ;
      private short RcdFound3 ;
      private short GX_JID ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private short wbTemp ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int edtEstudianteNumero_Enabled ;
      private int edtEstudiantePersonaId_Enabled ;
      private int imgprompt_20_Visible ;
      private int edtEstudiantePersonaNombre_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int AV14GXV1 ;
      private int idxLst ;
      private String sPrefix ;
      private String wcpOGx_mode ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String Gx_mode ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtEstudianteNumero_Internalname ;
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
      private String edtEstudianteNumero_Jsonclick ;
      private String edtEstudiantePersonaId_Internalname ;
      private String edtEstudiantePersonaId_Jsonclick ;
      private String sImgUrl ;
      private String imgprompt_20_Internalname ;
      private String imgprompt_20_Link ;
      private String edtEstudiantePersonaNombre_Internalname ;
      private String A21EstudiantePersonaNombre ;
      private String edtEstudiantePersonaNombre_Jsonclick ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String AV13Pgmname ;
      private String forbiddenHiddens ;
      private String hsh ;
      private String sMode3 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String Z21EstudiantePersonaNombre ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool n21EstudiantePersonaNombre ;
      private bool returnInSub ;
      private IGxSession AV10WebSession ;
      private GxUnknownObjectCollection isValidOutput ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] T00034_A21EstudiantePersonaNombre ;
      private bool[] T00034_n21EstudiantePersonaNombre ;
      private short[] T00035_A11EstudianteNumero ;
      private String[] T00035_A21EstudiantePersonaNombre ;
      private bool[] T00035_n21EstudiantePersonaNombre ;
      private short[] T00035_A20EstudiantePersonaId ;
      private String[] T00036_A21EstudiantePersonaNombre ;
      private bool[] T00036_n21EstudiantePersonaNombre ;
      private short[] T00037_A11EstudianteNumero ;
      private short[] T00033_A11EstudianteNumero ;
      private short[] T00033_A20EstudiantePersonaId ;
      private short[] T00038_A11EstudianteNumero ;
      private short[] T00039_A11EstudianteNumero ;
      private short[] T00032_A11EstudianteNumero ;
      private short[] T00032_A20EstudiantePersonaId ;
      private String[] T000313_A21EstudiantePersonaNombre ;
      private bool[] T000313_n21EstudiantePersonaNombre ;
      private short[] T000314_A11EstudianteNumero ;
      private GXWebForm Form ;
      private SdtTransactionContext AV9TrnContext ;
      private SdtTransactionContext_Attribute AV12TrnContextAtt ;
   }

   public class estudiante__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new ForEachCursor(def[11])
         ,new ForEachCursor(def[12])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT00035 ;
          prmT00035 = new Object[] {
          new Object[] {"@EstudianteNumero",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00034 ;
          prmT00034 = new Object[] {
          new Object[] {"@EstudiantePersonaId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00036 ;
          prmT00036 = new Object[] {
          new Object[] {"@EstudiantePersonaId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00037 ;
          prmT00037 = new Object[] {
          new Object[] {"@EstudianteNumero",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00033 ;
          prmT00033 = new Object[] {
          new Object[] {"@EstudianteNumero",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00038 ;
          prmT00038 = new Object[] {
          new Object[] {"@EstudianteNumero",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00039 ;
          prmT00039 = new Object[] {
          new Object[] {"@EstudianteNumero",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00032 ;
          prmT00032 = new Object[] {
          new Object[] {"@EstudianteNumero",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000310 ;
          prmT000310 = new Object[] {
          new Object[] {"@EstudianteNumero",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@EstudiantePersonaId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000311 ;
          prmT000311 = new Object[] {
          new Object[] {"@EstudiantePersonaId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@EstudianteNumero",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000312 ;
          prmT000312 = new Object[] {
          new Object[] {"@EstudianteNumero",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000314 ;
          prmT000314 = new Object[] {
          } ;
          Object[] prmT000313 ;
          prmT000313 = new Object[] {
          new Object[] {"@EstudiantePersonaId",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T00032", "SELECT [EstudianteNumero], [EstudiantePersonaId] AS EstudiantePersonaId FROM [Estudiante] WITH (UPDLOCK) WHERE [EstudianteNumero] = @EstudianteNumero ",true, GxErrorMask.GX_NOMASK, false, this,prmT00032,1,0,true,false )
             ,new CursorDef("T00033", "SELECT [EstudianteNumero], [EstudiantePersonaId] AS EstudiantePersonaId FROM [Estudiante] WITH (NOLOCK) WHERE [EstudianteNumero] = @EstudianteNumero ",true, GxErrorMask.GX_NOMASK, false, this,prmT00033,1,0,true,false )
             ,new CursorDef("T00034", "SELECT [PersonaNombre] AS EstudiantePersonaNombre FROM [Persona] WITH (NOLOCK) WHERE [PersonaId] = @EstudiantePersonaId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00034,1,0,true,false )
             ,new CursorDef("T00035", "SELECT TM1.[EstudianteNumero], T2.[PersonaNombre] AS EstudiantePersonaNombre, TM1.[EstudiantePersonaId] AS EstudiantePersonaId FROM ([Estudiante] TM1 WITH (NOLOCK) INNER JOIN [Persona] T2 WITH (NOLOCK) ON T2.[PersonaId] = TM1.[EstudiantePersonaId]) WHERE TM1.[EstudianteNumero] = @EstudianteNumero ORDER BY TM1.[EstudianteNumero]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00035,100,0,true,false )
             ,new CursorDef("T00036", "SELECT [PersonaNombre] AS EstudiantePersonaNombre FROM [Persona] WITH (NOLOCK) WHERE [PersonaId] = @EstudiantePersonaId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00036,1,0,true,false )
             ,new CursorDef("T00037", "SELECT [EstudianteNumero] FROM [Estudiante] WITH (NOLOCK) WHERE [EstudianteNumero] = @EstudianteNumero  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00037,1,0,true,false )
             ,new CursorDef("T00038", "SELECT TOP 1 [EstudianteNumero] FROM [Estudiante] WITH (NOLOCK) WHERE ( [EstudianteNumero] > @EstudianteNumero) ORDER BY [EstudianteNumero]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00038,1,0,true,true )
             ,new CursorDef("T00039", "SELECT TOP 1 [EstudianteNumero] FROM [Estudiante] WITH (NOLOCK) WHERE ( [EstudianteNumero] < @EstudianteNumero) ORDER BY [EstudianteNumero] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00039,1,0,true,true )
             ,new CursorDef("T000310", "INSERT INTO [Estudiante]([EstudianteNumero], [EstudiantePersonaId]) VALUES(@EstudianteNumero, @EstudiantePersonaId)", GxErrorMask.GX_NOMASK,prmT000310)
             ,new CursorDef("T000311", "UPDATE [Estudiante] SET [EstudiantePersonaId]=@EstudiantePersonaId  WHERE [EstudianteNumero] = @EstudianteNumero", GxErrorMask.GX_NOMASK,prmT000311)
             ,new CursorDef("T000312", "DELETE FROM [Estudiante]  WHERE [EstudianteNumero] = @EstudianteNumero", GxErrorMask.GX_NOMASK,prmT000312)
             ,new CursorDef("T000313", "SELECT [PersonaNombre] AS EstudiantePersonaNombre FROM [Persona] WITH (NOLOCK) WHERE [PersonaId] = @EstudiantePersonaId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000313,1,0,true,false )
             ,new CursorDef("T000314", "SELECT [EstudianteNumero] FROM [Estudiante] WITH (NOLOCK) ORDER BY [EstudianteNumero]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000314,100,0,true,false )
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
                ((String[]) buf[0])[0] = rslt.getString(1, 20) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 3 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 20) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((short[]) buf[3])[0] = rslt.getShort(3) ;
                return;
             case 4 :
                ((String[]) buf[0])[0] = rslt.getString(1, 20) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
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
             case 11 :
                ((String[]) buf[0])[0] = rslt.getString(1, 20) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 12 :
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
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 9 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 10 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 11 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
       }
    }

 }

}
