/*
               File: Cliente
        Description: Cliente
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 3/8/2019 21:17:29.1
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
   public class cliente : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_14") == 0 )
         {
            A7DepartamentoCodigo = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7DepartamentoCodigo", StringUtil.LTrim( StringUtil.Str( (decimal)(A7DepartamentoCodigo), 4, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_14( A7DepartamentoCodigo) ;
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Gridcliente_telefono") == 0 )
         {
            nRC_GXsfl_98 = (short)(NumberUtil.Val( GetNextPar( ), "."));
            nGXsfl_98_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
            sGXsfl_98_idx = GetNextPar( );
            A16ClienteUltimoTelefonoId = (short)(NumberUtil.Val( GetNextPar( ), "."));
            Gx_BScreen = (short)(NumberUtil.Val( GetNextPar( ), "."));
            Gx_mode = GetNextPar( );
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxnrGridcliente_telefono_newrow( ) ;
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
            Form.Meta.addItem("description", "Cliente", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtClienteCi_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("Carmine");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public cliente( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public cliente( IGxContext context )
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
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "Cliente", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_Cliente.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "", bttBtn_first_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_first_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Cliente.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "", bttBtn_previous_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_previous_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_Cliente.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", "", bttBtn_next_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_next_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_Cliente.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", "", bttBtn_last_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_last_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Cliente.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Select", bttBtn_select_Jsonclick, 4, "Select", "", StyleString, ClassString, bttBtn_select_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "gx.popup.openPrompt('"+"gx0010.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLIENTECI"+"'), id:'"+"CLIENTECI"+"'"+",IOType:'out',isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", 2, "HLP_Cliente.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtClienteCi_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtClienteCi_Internalname, "Ci", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtClienteCi_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A1ClienteCi), 8, 0, ".", "")), ((edtClienteCi_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A1ClienteCi), "ZZZZZZZ9")) : context.localUtil.Format( (decimal)(A1ClienteCi), "ZZZZZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,34);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtClienteCi_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtClienteCi_Enabled, 0, "number", "1", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Cliente.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtClienteNombre_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtClienteNombre_Internalname, "Nombre", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtClienteNombre_Internalname, StringUtil.RTrim( A2ClienteNombre), StringUtil.RTrim( context.localUtil.Format( A2ClienteNombre, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,39);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtClienteNombre_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtClienteNombre_Enabled, 0, "text", "", 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, -1, true, "PalabraCorta", "left", true, "HLP_Cliente.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtClienteApellido_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtClienteApellido_Internalname, "Apellido", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtClienteApellido_Internalname, StringUtil.RTrim( A3ClienteApellido), StringUtil.RTrim( context.localUtil.Format( A3ClienteApellido, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,44);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtClienteApellido_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtClienteApellido_Enabled, 0, "text", "", 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, -1, true, "PalabraCorta", "left", true, "HLP_Cliente.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtClienteEmail_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtClienteEmail_Internalname, "Email", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 49,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtClienteEmail_Internalname, A4ClienteEmail, StringUtil.RTrim( context.localUtil.Format( A4ClienteEmail, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,49);\"", "'"+""+"'"+",false,"+"'"+""+"'", "mailto:"+A4ClienteEmail, "", "", "", edtClienteEmail_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtClienteEmail_Enabled, 0, "email", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, 0, true, "GeneXus\\Email", "left", true, "HLP_Cliente.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtClienteDireccion_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtClienteDireccion_Internalname, "Direccion", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 54,'',false,'',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtClienteDireccion_Internalname, A5ClienteDireccion, "http://maps.google.com/maps?q="+GXUtil.UrlEncode( A5ClienteDireccion), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,54);\"", 0, 1, edtClienteDireccion_Enabled, 0, 80, "chr", 10, "row", StyleString, ClassString, "", "", "1024", -1, 0, "_blank", "", 0, true, "GeneXus\\Address", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_Cliente.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtClienteObservacion_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtClienteObservacion_Internalname, "Observacion", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 59,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtClienteObservacion_Internalname, StringUtil.RTrim( A6ClienteObservacion), StringUtil.RTrim( context.localUtil.Format( A6ClienteObservacion, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,59);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtClienteObservacion_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtClienteObservacion_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "DescripcionCorta", "left", true, "HLP_Cliente.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtDepartamentoCodigo_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtDepartamentoCodigo_Internalname, "Departamento Codigo", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 64,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtDepartamentoCodigo_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A7DepartamentoCodigo), 4, 0, ".", "")), ((edtDepartamentoCodigo_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A7DepartamentoCodigo), "ZZZ9")) : context.localUtil.Format( (decimal)(A7DepartamentoCodigo), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,64);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtDepartamentoCodigo_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtDepartamentoCodigo_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "CodigoAuto", "right", false, "HLP_Cliente.htm");
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "prompt.gif", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgprompt_7_Internalname, sImgUrl, imgprompt_7_Link, "", "", context.GetTheme( ), imgprompt_7_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_Cliente.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtDepartamentoDescripcion_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtDepartamentoDescripcion_Internalname, "Departamento Descripcion", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtDepartamentoDescripcion_Internalname, StringUtil.RTrim( A8DepartamentoDescripcion), StringUtil.RTrim( context.localUtil.Format( A8DepartamentoDescripcion, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtDepartamentoDescripcion_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtDepartamentoDescripcion_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "DescripcionCorta", "left", true, "HLP_Cliente.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtClienteFechaIngreso_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtClienteFechaIngreso_Internalname, "Fecha Ingreso", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            context.WriteHtmlText( "<div id=\""+edtClienteFechaIngreso_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtClienteFechaIngreso_Internalname, context.localUtil.Format(A14ClienteFechaIngreso, "99/99/99"), context.localUtil.Format( A14ClienteFechaIngreso, "99/99/99"), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtClienteFechaIngreso_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtClienteFechaIngreso_Enabled, 0, "text", "", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Cliente.htm");
            GxWebStd.gx_bitmap( context, edtClienteFechaIngreso_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtClienteFechaIngreso_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_Cliente.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", edtClienteUltimoTelefonoId_Visible, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtClienteUltimoTelefonoId_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtClienteUltimoTelefonoId_Internalname, "Telefono Id", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtClienteUltimoTelefonoId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A16ClienteUltimoTelefonoId), 4, 0, ".", "")), ((edtClienteUltimoTelefonoId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A16ClienteUltimoTelefonoId), "ZZZ9")) : context.localUtil.Format( (decimal)(A16ClienteUltimoTelefonoId), "ZZZ9")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtClienteUltimoTelefonoId_Jsonclick, 0, "Attribute", "", "", "", "", edtClienteUltimoTelefonoId_Visible, edtClienteUltimoTelefonoId_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Cliente.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtClienteEdad_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtClienteEdad_Internalname, "Edad", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 84,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtClienteEdad_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A18ClienteEdad), 4, 0, ".", "")), ((edtClienteEdad_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A18ClienteEdad), "ZZZ9")) : context.localUtil.Format( (decimal)(A18ClienteEdad), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,84);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtClienteEdad_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtClienteEdad_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Cliente.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtClienteEdadFormula_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtClienteEdadFormula_Internalname, "Edad Formula", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtClienteEdadFormula_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A19ClienteEdadFormula), 4, 0, ".", "")), ((edtClienteEdadFormula_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A19ClienteEdadFormula), "ZZZ9")) : context.localUtil.Format( (decimal)(A19ClienteEdadFormula), "ZZZ9")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtClienteEdadFormula_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtClienteEdadFormula_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Cliente.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 LevelTable", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTelefonotable_Internalname, 1, 0, "px", 0, "px", "LevelTable", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTitletelefono_Internalname, "Telefono", "", "", lblTitletelefono_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_Cliente.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            gxdraw_Gridcliente_telefono( ) ;
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 106,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirm", bttBtn_enter_Jsonclick, 5, "Confirm", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_Cliente.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 108,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancel", bttBtn_cancel_Jsonclick, 1, "Cancel", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Cliente.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 110,'',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Delete", bttBtn_delete_Jsonclick, 5, "Delete", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_Cliente.htm");
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

      protected void gxdraw_Gridcliente_telefono( )
      {
         /*  Grid Control  */
         Gridcliente_telefonoContainer.AddObjectProperty("GridName", "Gridcliente_telefono");
         Gridcliente_telefonoContainer.AddObjectProperty("Header", subGridcliente_telefono_Header);
         Gridcliente_telefonoContainer.AddObjectProperty("Class", "Grid");
         Gridcliente_telefonoContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         Gridcliente_telefonoContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
         Gridcliente_telefonoContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridcliente_telefono_Backcolorstyle), 1, 0, ".", "")));
         Gridcliente_telefonoContainer.AddObjectProperty("CmpContext", "");
         Gridcliente_telefonoContainer.AddObjectProperty("InMasterPage", "false");
         Gridcliente_telefonoColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridcliente_telefonoColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A17ClienteTelefonoId), 4, 0, ".", "")));
         Gridcliente_telefonoColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtClienteTelefonoId_Enabled), 5, 0, ".", "")));
         Gridcliente_telefonoContainer.AddColumnProperties(Gridcliente_telefonoColumn);
         Gridcliente_telefonoColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridcliente_telefonoColumn.AddObjectProperty("Value", StringUtil.RTrim( A13ClienteTelefonoNumero));
         Gridcliente_telefonoColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtClienteTelefonoNumero_Enabled), 5, 0, ".", "")));
         Gridcliente_telefonoContainer.AddColumnProperties(Gridcliente_telefonoColumn);
         Gridcliente_telefonoColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridcliente_telefonoColumn.AddObjectProperty("Value", StringUtil.RTrim( A15ClienteTelefonoDescripcion));
         Gridcliente_telefonoColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtClienteTelefonoDescripcion_Enabled), 5, 0, ".", "")));
         Gridcliente_telefonoContainer.AddColumnProperties(Gridcliente_telefonoColumn);
         Gridcliente_telefonoContainer.AddObjectProperty("Selectedindex", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridcliente_telefono_Selectedindex), 4, 0, ".", "")));
         Gridcliente_telefonoContainer.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridcliente_telefono_Allowselection), 1, 0, ".", "")));
         Gridcliente_telefonoContainer.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridcliente_telefono_Selectioncolor), 9, 0, ".", "")));
         Gridcliente_telefonoContainer.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridcliente_telefono_Allowhovering), 1, 0, ".", "")));
         Gridcliente_telefonoContainer.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridcliente_telefono_Hoveringcolor), 9, 0, ".", "")));
         Gridcliente_telefonoContainer.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridcliente_telefono_Allowcollapsing), 1, 0, ".", "")));
         Gridcliente_telefonoContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridcliente_telefono_Collapsed), 1, 0, ".", "")));
         nGXsfl_98_idx = 0;
         if ( ( nKeyPressed == 1 ) && ( AnyError == 0 ) )
         {
            /* Enter key processing. */
            nBlankRcdCount6 = 5;
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               /* Display confirmed (stored) records */
               nRcdExists_6 = 1;
               ScanStart016( ) ;
               while ( RcdFound6 != 0 )
               {
                  init_level_properties6( ) ;
                  getByPrimaryKey016( ) ;
                  AddRow016( ) ;
                  ScanNext016( ) ;
               }
               ScanEnd016( ) ;
               nBlankRcdCount6 = 5;
            }
         }
         else if ( ( nKeyPressed == 3 ) || ( nKeyPressed == 4 ) || ( ( nKeyPressed == 1 ) && ( AnyError != 0 ) ) )
         {
            /* Button check  or addlines. */
            B16ClienteUltimoTelefonoId = A16ClienteUltimoTelefonoId;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16ClienteUltimoTelefonoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A16ClienteUltimoTelefonoId), 4, 0)));
            standaloneNotModal016( ) ;
            standaloneModal016( ) ;
            sMode6 = Gx_mode;
            while ( nGXsfl_98_idx < nRC_GXsfl_98 )
            {
               bGXsfl_98_Refreshing = true;
               ReadRow016( ) ;
               edtClienteTelefonoId_Enabled = (int)(context.localUtil.CToN( cgiGet( "CLIENTETELEFONOID_"+sGXsfl_98_idx+"Enabled"), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClienteTelefonoId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClienteTelefonoId_Enabled), 5, 0)), !bGXsfl_98_Refreshing);
               edtClienteTelefonoNumero_Enabled = (int)(context.localUtil.CToN( cgiGet( "CLIENTETELEFONONUMERO_"+sGXsfl_98_idx+"Enabled"), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClienteTelefonoNumero_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClienteTelefonoNumero_Enabled), 5, 0)), !bGXsfl_98_Refreshing);
               edtClienteTelefonoDescripcion_Enabled = (int)(context.localUtil.CToN( cgiGet( "CLIENTETELEFONODESCRIPCION_"+sGXsfl_98_idx+"Enabled"), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClienteTelefonoDescripcion_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClienteTelefonoDescripcion_Enabled), 5, 0)), !bGXsfl_98_Refreshing);
               if ( ( nRcdExists_6 == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") != 0 ) )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  standaloneModal016( ) ;
               }
               SendRow016( ) ;
               bGXsfl_98_Refreshing = false;
            }
            Gx_mode = sMode6;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            A16ClienteUltimoTelefonoId = B16ClienteUltimoTelefonoId;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16ClienteUltimoTelefonoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A16ClienteUltimoTelefonoId), 4, 0)));
         }
         else
         {
            /* Get or get-alike key processing. */
            nBlankRcdCount6 = 5;
            nRcdExists_6 = 1;
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               ScanStart016( ) ;
               while ( RcdFound6 != 0 )
               {
                  sGXsfl_98_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_98_idx+1), 4, 0)), 4, "0");
                  SubsflControlProps_986( ) ;
                  init_level_properties6( ) ;
                  standaloneNotModal016( ) ;
                  getByPrimaryKey016( ) ;
                  standaloneModal016( ) ;
                  AddRow016( ) ;
                  ScanNext016( ) ;
               }
               ScanEnd016( ) ;
            }
         }
         /* Initialize fields for 'new' records and send them. */
         sMode6 = Gx_mode;
         Gx_mode = "INS";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         sGXsfl_98_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_98_idx+1), 4, 0)), 4, "0");
         SubsflControlProps_986( ) ;
         InitAll016( ) ;
         init_level_properties6( ) ;
         B16ClienteUltimoTelefonoId = A16ClienteUltimoTelefonoId;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16ClienteUltimoTelefonoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A16ClienteUltimoTelefonoId), 4, 0)));
         standaloneNotModal016( ) ;
         standaloneModal016( ) ;
         nRcdExists_6 = 0;
         nIsMod_6 = 0;
         nRcdDeleted_6 = 0;
         nBlankRcdCount6 = (short)(nBlankRcdUsr6+nBlankRcdCount6);
         fRowAdded = 0;
         while ( nBlankRcdCount6 > 0 )
         {
            AddRow016( ) ;
            if ( ( nKeyPressed == 4 ) && ( fRowAdded == 0 ) )
            {
               fRowAdded = 1;
               GX_FocusControl = edtClienteTelefonoId_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            nBlankRcdCount6 = (short)(nBlankRcdCount6-1);
         }
         Gx_mode = sMode6;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         A16ClienteUltimoTelefonoId = B16ClienteUltimoTelefonoId;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16ClienteUltimoTelefonoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A16ClienteUltimoTelefonoId), 4, 0)));
         sStyleString = "";
         context.WriteHtmlText( "<div id=\""+"Gridcliente_telefonoContainer"+"Div\" "+sStyleString+">"+"</div>") ;
         context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Gridcliente_telefono", Gridcliente_telefonoContainer);
         if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
         {
            GxWebStd.gx_hidden_field( context, "Gridcliente_telefonoContainerData", Gridcliente_telefonoContainer.ToJavascriptSource());
         }
         if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
         {
            GxWebStd.gx_hidden_field( context, "Gridcliente_telefonoContainerData"+"V", Gridcliente_telefonoContainer.GridValuesHidden());
         }
         else
         {
            context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Gridcliente_telefonoContainerData"+"V"+"\" value='"+Gridcliente_telefonoContainer.GridValuesHidden()+"'/>") ;
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
         context.wbGlbDoneStart = 1;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read variables values. */
               if ( ( ( context.localUtil.CToN( cgiGet( edtClienteCi_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtClienteCi_Internalname), ".", ",") > Convert.ToDecimal( 99999999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "CLIENTECI");
                  AnyError = 1;
                  GX_FocusControl = edtClienteCi_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A1ClienteCi = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1ClienteCi", StringUtil.LTrim( StringUtil.Str( (decimal)(A1ClienteCi), 8, 0)));
               }
               else
               {
                  A1ClienteCi = (int)(context.localUtil.CToN( cgiGet( edtClienteCi_Internalname), ".", ","));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1ClienteCi", StringUtil.LTrim( StringUtil.Str( (decimal)(A1ClienteCi), 8, 0)));
               }
               A2ClienteNombre = cgiGet( edtClienteNombre_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2ClienteNombre", A2ClienteNombre);
               A3ClienteApellido = cgiGet( edtClienteApellido_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3ClienteApellido", A3ClienteApellido);
               A4ClienteEmail = cgiGet( edtClienteEmail_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4ClienteEmail", A4ClienteEmail);
               A5ClienteDireccion = cgiGet( edtClienteDireccion_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5ClienteDireccion", A5ClienteDireccion);
               A6ClienteObservacion = cgiGet( edtClienteObservacion_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6ClienteObservacion", A6ClienteObservacion);
               if ( ( ( context.localUtil.CToN( cgiGet( edtDepartamentoCodigo_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtDepartamentoCodigo_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "DEPARTAMENTOCODIGO");
                  AnyError = 1;
                  GX_FocusControl = edtDepartamentoCodigo_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A7DepartamentoCodigo = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7DepartamentoCodigo", StringUtil.LTrim( StringUtil.Str( (decimal)(A7DepartamentoCodigo), 4, 0)));
               }
               else
               {
                  A7DepartamentoCodigo = (short)(context.localUtil.CToN( cgiGet( edtDepartamentoCodigo_Internalname), ".", ","));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7DepartamentoCodigo", StringUtil.LTrim( StringUtil.Str( (decimal)(A7DepartamentoCodigo), 4, 0)));
               }
               A8DepartamentoDescripcion = cgiGet( edtDepartamentoDescripcion_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8DepartamentoDescripcion", A8DepartamentoDescripcion);
               A14ClienteFechaIngreso = context.localUtil.CToD( cgiGet( edtClienteFechaIngreso_Internalname), 1);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A14ClienteFechaIngreso", context.localUtil.Format(A14ClienteFechaIngreso, "99/99/99"));
               A16ClienteUltimoTelefonoId = (short)(context.localUtil.CToN( cgiGet( edtClienteUltimoTelefonoId_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16ClienteUltimoTelefonoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A16ClienteUltimoTelefonoId), 4, 0)));
               if ( ( ( context.localUtil.CToN( cgiGet( edtClienteEdad_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtClienteEdad_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "CLIENTEEDAD");
                  AnyError = 1;
                  GX_FocusControl = edtClienteEdad_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A18ClienteEdad = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18ClienteEdad", StringUtil.LTrim( StringUtil.Str( (decimal)(A18ClienteEdad), 4, 0)));
               }
               else
               {
                  A18ClienteEdad = (short)(context.localUtil.CToN( cgiGet( edtClienteEdad_Internalname), ".", ","));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18ClienteEdad", StringUtil.LTrim( StringUtil.Str( (decimal)(A18ClienteEdad), 4, 0)));
               }
               A19ClienteEdadFormula = (short)(context.localUtil.CToN( cgiGet( edtClienteEdadFormula_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19ClienteEdadFormula", StringUtil.LTrim( StringUtil.Str( (decimal)(A19ClienteEdadFormula), 4, 0)));
               /* Read saved values. */
               Z1ClienteCi = (int)(context.localUtil.CToN( cgiGet( "Z1ClienteCi"), ".", ","));
               Z2ClienteNombre = cgiGet( "Z2ClienteNombre");
               Z3ClienteApellido = cgiGet( "Z3ClienteApellido");
               Z4ClienteEmail = cgiGet( "Z4ClienteEmail");
               Z5ClienteDireccion = cgiGet( "Z5ClienteDireccion");
               Z6ClienteObservacion = cgiGet( "Z6ClienteObservacion");
               Z14ClienteFechaIngreso = context.localUtil.CToD( cgiGet( "Z14ClienteFechaIngreso"), 0);
               Z16ClienteUltimoTelefonoId = (short)(context.localUtil.CToN( cgiGet( "Z16ClienteUltimoTelefonoId"), ".", ","));
               Z18ClienteEdad = (short)(context.localUtil.CToN( cgiGet( "Z18ClienteEdad"), ".", ","));
               Z7DepartamentoCodigo = (short)(context.localUtil.CToN( cgiGet( "Z7DepartamentoCodigo"), ".", ","));
               O16ClienteUltimoTelefonoId = (short)(context.localUtil.CToN( cgiGet( "O16ClienteUltimoTelefonoId"), ".", ","));
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ","));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ".", ","));
               Gx_mode = cgiGet( "Mode");
               nRC_GXsfl_98 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_98"), ".", ","));
               Gx_date = context.localUtil.CToD( cgiGet( "vTODAY"), 0);
               Gx_BScreen = (short)(context.localUtil.CToN( cgiGet( "vGXBSCREEN"), ".", ","));
               Gx_mode = cgiGet( "vMODE");
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               forbiddenHiddens = "hsh" + "Cliente";
               A14ClienteFechaIngreso = context.localUtil.CToD( cgiGet( edtClienteFechaIngreso_Internalname), 1);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A14ClienteFechaIngreso", context.localUtil.Format(A14ClienteFechaIngreso, "99/99/99"));
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format(A14ClienteFechaIngreso, "99/99/99");
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( A1ClienteCi != Z1ClienteCi ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
               {
                  GXUtil.WriteLog("cliente:[SecurityCheckFailed value for]"+"ClienteFechaIngreso:"+context.localUtil.Format(A14ClienteFechaIngreso, "99/99/99"));
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
                  A1ClienteCi = (int)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1ClienteCi", StringUtil.LTrim( StringUtil.Str( (decimal)(A1ClienteCi), 8, 0)));
                  getEqualNoModal( ) ;
                  Gx_mode = "DSP";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  disable_std_buttons_dsp( ) ;
                  standaloneModal( ) ;
               }
               else
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  standaloneModal( ) ;
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
                           btn_enter( ) ;
                           /* No code required for Cancel button. It is implemented as the Reset button. */
                        }
                        else if ( StringUtil.StrCmp(sEvt, "FIRST") == 0 )
                        {
                           context.wbHandled = 1;
                           btn_first( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "PREVIOUS") == 0 )
                        {
                           context.wbHandled = 1;
                           btn_previous( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "NEXT") == 0 )
                        {
                           context.wbHandled = 1;
                           btn_next( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "LAST") == 0 )
                        {
                           context.wbHandled = 1;
                           btn_last( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "SELECT") == 0 )
                        {
                           context.wbHandled = 1;
                           btn_select( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DELETE") == 0 )
                        {
                           context.wbHandled = 1;
                           btn_delete( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                        {
                           context.wbHandled = 1;
                           AfterKeyLoadScreen( ) ;
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
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            bttBtn_delete_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Enabled), 5, 0)), true);
         }
      }

      protected void disable_std_buttons_dsp( )
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
         bttBtn_delete_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Visible), 5, 0)), true);
         if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
         {
            bttBtn_enter_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_enter_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_enter_Visible), 5, 0)), true);
         }
         DisableAttributes011( ) ;
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

      protected void CONFIRM_016( )
      {
         s16ClienteUltimoTelefonoId = O16ClienteUltimoTelefonoId;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16ClienteUltimoTelefonoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A16ClienteUltimoTelefonoId), 4, 0)));
         nGXsfl_98_idx = 0;
         while ( nGXsfl_98_idx < nRC_GXsfl_98 )
         {
            ReadRow016( ) ;
            if ( ( nRcdExists_6 != 0 ) || ( nIsMod_6 != 0 ) )
            {
               GetKey016( ) ;
               if ( ( nRcdExists_6 == 0 ) && ( nRcdDeleted_6 == 0 ) )
               {
                  if ( RcdFound6 == 0 )
                  {
                     Gx_mode = "INS";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     BeforeValidate016( ) ;
                     if ( AnyError == 0 )
                     {
                        CheckExtendedTable016( ) ;
                        CloseExtendedTableCursors016( ) ;
                        if ( AnyError == 0 )
                        {
                           IsConfirmed = 1;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
                        }
                        O16ClienteUltimoTelefonoId = A16ClienteUltimoTelefonoId;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16ClienteUltimoTelefonoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A16ClienteUltimoTelefonoId), 4, 0)));
                     }
                  }
                  else
                  {
                     GXCCtl = "CLIENTETELEFONOID_" + sGXsfl_98_idx;
                     GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, GXCCtl);
                     AnyError = 1;
                     GX_FocusControl = edtClienteTelefonoId_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( RcdFound6 != 0 )
                  {
                     if ( nRcdDeleted_6 != 0 )
                     {
                        Gx_mode = "DLT";
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        getByPrimaryKey016( ) ;
                        Load016( ) ;
                        BeforeValidate016( ) ;
                        if ( AnyError == 0 )
                        {
                           OnDeleteControls016( ) ;
                           O16ClienteUltimoTelefonoId = A16ClienteUltimoTelefonoId;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16ClienteUltimoTelefonoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A16ClienteUltimoTelefonoId), 4, 0)));
                        }
                     }
                     else
                     {
                        if ( nIsMod_6 != 0 )
                        {
                           Gx_mode = "UPD";
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           BeforeValidate016( ) ;
                           if ( AnyError == 0 )
                           {
                              CheckExtendedTable016( ) ;
                              CloseExtendedTableCursors016( ) ;
                              if ( AnyError == 0 )
                              {
                                 IsConfirmed = 1;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
                              }
                              O16ClienteUltimoTelefonoId = A16ClienteUltimoTelefonoId;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16ClienteUltimoTelefonoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A16ClienteUltimoTelefonoId), 4, 0)));
                           }
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_6 == 0 )
                     {
                        GXCCtl = "CLIENTETELEFONOID_" + sGXsfl_98_idx;
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, GXCCtl);
                        AnyError = 1;
                        GX_FocusControl = edtClienteTelefonoId_Internalname;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtClienteTelefonoId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A17ClienteTelefonoId), 4, 0, ".", ""))) ;
            ChangePostValue( edtClienteTelefonoNumero_Internalname, StringUtil.RTrim( A13ClienteTelefonoNumero)) ;
            ChangePostValue( edtClienteTelefonoDescripcion_Internalname, StringUtil.RTrim( A15ClienteTelefonoDescripcion)) ;
            ChangePostValue( "ZT_"+"Z17ClienteTelefonoId_"+sGXsfl_98_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z17ClienteTelefonoId), 4, 0, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z13ClienteTelefonoNumero_"+sGXsfl_98_idx, StringUtil.RTrim( Z13ClienteTelefonoNumero)) ;
            ChangePostValue( "ZT_"+"Z15ClienteTelefonoDescripcion_"+sGXsfl_98_idx, StringUtil.RTrim( Z15ClienteTelefonoDescripcion)) ;
            ChangePostValue( "nRcdDeleted_6_"+sGXsfl_98_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_6), 4, 0, ".", ""))) ;
            ChangePostValue( "nRcdExists_6_"+sGXsfl_98_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_6), 4, 0, ".", ""))) ;
            ChangePostValue( "nIsMod_6_"+sGXsfl_98_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_6), 4, 0, ".", ""))) ;
            if ( nIsMod_6 != 0 )
            {
               ChangePostValue( "CLIENTETELEFONOID_"+sGXsfl_98_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtClienteTelefonoId_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "CLIENTETELEFONONUMERO_"+sGXsfl_98_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtClienteTelefonoNumero_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "CLIENTETELEFONODESCRIPCION_"+sGXsfl_98_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtClienteTelefonoDescripcion_Enabled), 5, 0, ".", ""))) ;
            }
         }
         O16ClienteUltimoTelefonoId = s16ClienteUltimoTelefonoId;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16ClienteUltimoTelefonoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A16ClienteUltimoTelefonoId), 4, 0)));
         /* Start of After( level) rules */
         /* End of After( level) rules */
      }

      protected void ResetCaption010( )
      {
      }

      protected void ZM011( short GX_JID )
      {
         if ( ( GX_JID == 13 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z2ClienteNombre = T00015_A2ClienteNombre[0];
               Z3ClienteApellido = T00015_A3ClienteApellido[0];
               Z4ClienteEmail = T00015_A4ClienteEmail[0];
               Z5ClienteDireccion = T00015_A5ClienteDireccion[0];
               Z6ClienteObservacion = T00015_A6ClienteObservacion[0];
               Z14ClienteFechaIngreso = T00015_A14ClienteFechaIngreso[0];
               Z16ClienteUltimoTelefonoId = T00015_A16ClienteUltimoTelefonoId[0];
               Z18ClienteEdad = T00015_A18ClienteEdad[0];
               Z7DepartamentoCodigo = T00015_A7DepartamentoCodigo[0];
            }
            else
            {
               Z2ClienteNombre = A2ClienteNombre;
               Z3ClienteApellido = A3ClienteApellido;
               Z4ClienteEmail = A4ClienteEmail;
               Z5ClienteDireccion = A5ClienteDireccion;
               Z6ClienteObservacion = A6ClienteObservacion;
               Z14ClienteFechaIngreso = A14ClienteFechaIngreso;
               Z16ClienteUltimoTelefonoId = A16ClienteUltimoTelefonoId;
               Z18ClienteEdad = A18ClienteEdad;
               Z7DepartamentoCodigo = A7DepartamentoCodigo;
            }
         }
         if ( GX_JID == -13 )
         {
            Z1ClienteCi = A1ClienteCi;
            Z2ClienteNombre = A2ClienteNombre;
            Z3ClienteApellido = A3ClienteApellido;
            Z4ClienteEmail = A4ClienteEmail;
            Z5ClienteDireccion = A5ClienteDireccion;
            Z6ClienteObservacion = A6ClienteObservacion;
            Z14ClienteFechaIngreso = A14ClienteFechaIngreso;
            Z16ClienteUltimoTelefonoId = A16ClienteUltimoTelefonoId;
            Z18ClienteEdad = A18ClienteEdad;
            Z7DepartamentoCodigo = A7DepartamentoCodigo;
            Z8DepartamentoDescripcion = A8DepartamentoDescripcion;
         }
      }

      protected void standaloneNotModal( )
      {
         edtClienteFechaIngreso_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClienteFechaIngreso_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClienteFechaIngreso_Enabled), 5, 0)), true);
         edtClienteUltimoTelefonoId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClienteUltimoTelefonoId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClienteUltimoTelefonoId_Enabled), 5, 0)), true);
         edtClienteUltimoTelefonoId_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClienteUltimoTelefonoId_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClienteUltimoTelefonoId_Visible), 5, 0)), true);
         Gx_BScreen = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
         Gx_date = DateTimeUtil.Today( context);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_date", context.localUtil.Format(Gx_date, "99/99/99"));
         imgprompt_7_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0020.aspx"+"',["+"{Ctrl:gx.dom.el('"+"DEPARTAMENTOCODIGO"+"'), id:'"+"DEPARTAMENTOCODIGO"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"false"+");");
         edtClienteFechaIngreso_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClienteFechaIngreso_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClienteFechaIngreso_Enabled), 5, 0)), true);
         edtClienteUltimoTelefonoId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClienteUltimoTelefonoId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClienteUltimoTelefonoId_Enabled), 5, 0)), true);
      }

      protected void standaloneModal( )
      {
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && (DateTime.MinValue==A14ClienteFechaIngreso) && ( Gx_BScreen == 0 ) )
         {
            A14ClienteFechaIngreso = Gx_date;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A14ClienteFechaIngreso", context.localUtil.Format(A14ClienteFechaIngreso, "99/99/99"));
         }
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            bttBtn_delete_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Enabled), 5, 0)), true);
         }
         else
         {
            bttBtn_delete_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Enabled), 5, 0)), true);
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
      }

      protected void Load011( )
      {
         /* Using cursor T00017 */
         pr_default.execute(5, new Object[] {A1ClienteCi});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound1 = 1;
            A2ClienteNombre = T00017_A2ClienteNombre[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2ClienteNombre", A2ClienteNombre);
            A3ClienteApellido = T00017_A3ClienteApellido[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3ClienteApellido", A3ClienteApellido);
            A4ClienteEmail = T00017_A4ClienteEmail[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4ClienteEmail", A4ClienteEmail);
            A5ClienteDireccion = T00017_A5ClienteDireccion[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5ClienteDireccion", A5ClienteDireccion);
            A6ClienteObservacion = T00017_A6ClienteObservacion[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6ClienteObservacion", A6ClienteObservacion);
            A8DepartamentoDescripcion = T00017_A8DepartamentoDescripcion[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8DepartamentoDescripcion", A8DepartamentoDescripcion);
            A14ClienteFechaIngreso = T00017_A14ClienteFechaIngreso[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A14ClienteFechaIngreso", context.localUtil.Format(A14ClienteFechaIngreso, "99/99/99"));
            A16ClienteUltimoTelefonoId = T00017_A16ClienteUltimoTelefonoId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16ClienteUltimoTelefonoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A16ClienteUltimoTelefonoId), 4, 0)));
            A18ClienteEdad = T00017_A18ClienteEdad[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18ClienteEdad", StringUtil.LTrim( StringUtil.Str( (decimal)(A18ClienteEdad), 4, 0)));
            A7DepartamentoCodigo = T00017_A7DepartamentoCodigo[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7DepartamentoCodigo", StringUtil.LTrim( StringUtil.Str( (decimal)(A7DepartamentoCodigo), 4, 0)));
            ZM011( -13) ;
         }
         pr_default.close(5);
         OnLoadActions011( ) ;
      }

      protected void OnLoadActions011( )
      {
         A19ClienteEdadFormula = (short)(A18ClienteEdad*2);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19ClienteEdadFormula", StringUtil.LTrim( StringUtil.Str( (decimal)(A19ClienteEdadFormula), 4, 0)));
      }

      protected void CheckExtendedTable011( )
      {
         Gx_BScreen = 1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
         standaloneModal( ) ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( A2ClienteNombre)) )
         {
            GX_msglist.addItem("Ingrese el nombre del cliente", 1, "CLIENTENOMBRE");
            AnyError = 1;
            GX_FocusControl = edtClienteNombre_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( A3ClienteApellido)) )
         {
            GX_msglist.addItem("El campo apellido esta en blanco", 0, "CLIENTEAPELLIDO");
         }
         if ( ! ( GxRegex.IsMatch(A4ClienteEmail,"^((\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*)|(\\s*))$") ) )
         {
            GX_msglist.addItem("Field Cliente Email does not match the specified pattern", "OutOfRange", 1, "CLIENTEEMAIL");
            AnyError = 1;
            GX_FocusControl = edtClienteEmail_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         /* Using cursor T00016 */
         pr_default.execute(4, new Object[] {A7DepartamentoCodigo});
         if ( (pr_default.getStatus(4) == 101) )
         {
            GX_msglist.addItem("No matching 'Departamento'.", "ForeignKeyNotFound", 1, "DEPARTAMENTOCODIGO");
            AnyError = 1;
            GX_FocusControl = edtDepartamentoCodigo_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A8DepartamentoDescripcion = T00016_A8DepartamentoDescripcion[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8DepartamentoDescripcion", A8DepartamentoDescripcion);
         pr_default.close(4);
         A19ClienteEdadFormula = (short)(A18ClienteEdad*2);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19ClienteEdadFormula", StringUtil.LTrim( StringUtil.Str( (decimal)(A19ClienteEdadFormula), 4, 0)));
      }

      protected void CloseExtendedTableCursors011( )
      {
         pr_default.close(4);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_14( short A7DepartamentoCodigo )
      {
         /* Using cursor T00018 */
         pr_default.execute(6, new Object[] {A7DepartamentoCodigo});
         if ( (pr_default.getStatus(6) == 101) )
         {
            GX_msglist.addItem("No matching 'Departamento'.", "ForeignKeyNotFound", 1, "DEPARTAMENTOCODIGO");
            AnyError = 1;
            GX_FocusControl = edtDepartamentoCodigo_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A8DepartamentoDescripcion = T00018_A8DepartamentoDescripcion[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8DepartamentoDescripcion", A8DepartamentoDescripcion);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A8DepartamentoDescripcion))+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(6) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(6);
      }

      protected void GetKey011( )
      {
         /* Using cursor T00019 */
         pr_default.execute(7, new Object[] {A1ClienteCi});
         if ( (pr_default.getStatus(7) != 101) )
         {
            RcdFound1 = 1;
         }
         else
         {
            RcdFound1 = 0;
         }
         pr_default.close(7);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00015 */
         pr_default.execute(3, new Object[] {A1ClienteCi});
         if ( (pr_default.getStatus(3) != 101) )
         {
            ZM011( 13) ;
            RcdFound1 = 1;
            A1ClienteCi = T00015_A1ClienteCi[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1ClienteCi", StringUtil.LTrim( StringUtil.Str( (decimal)(A1ClienteCi), 8, 0)));
            A2ClienteNombre = T00015_A2ClienteNombre[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2ClienteNombre", A2ClienteNombre);
            A3ClienteApellido = T00015_A3ClienteApellido[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3ClienteApellido", A3ClienteApellido);
            A4ClienteEmail = T00015_A4ClienteEmail[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4ClienteEmail", A4ClienteEmail);
            A5ClienteDireccion = T00015_A5ClienteDireccion[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5ClienteDireccion", A5ClienteDireccion);
            A6ClienteObservacion = T00015_A6ClienteObservacion[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6ClienteObservacion", A6ClienteObservacion);
            A14ClienteFechaIngreso = T00015_A14ClienteFechaIngreso[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A14ClienteFechaIngreso", context.localUtil.Format(A14ClienteFechaIngreso, "99/99/99"));
            A16ClienteUltimoTelefonoId = T00015_A16ClienteUltimoTelefonoId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16ClienteUltimoTelefonoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A16ClienteUltimoTelefonoId), 4, 0)));
            A18ClienteEdad = T00015_A18ClienteEdad[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18ClienteEdad", StringUtil.LTrim( StringUtil.Str( (decimal)(A18ClienteEdad), 4, 0)));
            A7DepartamentoCodigo = T00015_A7DepartamentoCodigo[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7DepartamentoCodigo", StringUtil.LTrim( StringUtil.Str( (decimal)(A7DepartamentoCodigo), 4, 0)));
            O16ClienteUltimoTelefonoId = A16ClienteUltimoTelefonoId;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16ClienteUltimoTelefonoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A16ClienteUltimoTelefonoId), 4, 0)));
            Z1ClienteCi = A1ClienteCi;
            sMode1 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load011( ) ;
            if ( AnyError == 1 )
            {
               RcdFound1 = 0;
               InitializeNonKey011( ) ;
            }
            Gx_mode = sMode1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound1 = 0;
            InitializeNonKey011( ) ;
            sMode1 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(3);
      }

      protected void getEqualNoModal( )
      {
         GetKey011( ) ;
         if ( RcdFound1 == 0 )
         {
            Gx_mode = "INS";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound1 = 0;
         /* Using cursor T000110 */
         pr_default.execute(8, new Object[] {A1ClienteCi});
         if ( (pr_default.getStatus(8) != 101) )
         {
            while ( (pr_default.getStatus(8) != 101) && ( ( T000110_A1ClienteCi[0] < A1ClienteCi ) ) )
            {
               pr_default.readNext(8);
            }
            if ( (pr_default.getStatus(8) != 101) && ( ( T000110_A1ClienteCi[0] > A1ClienteCi ) ) )
            {
               A1ClienteCi = T000110_A1ClienteCi[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1ClienteCi", StringUtil.LTrim( StringUtil.Str( (decimal)(A1ClienteCi), 8, 0)));
               RcdFound1 = 1;
            }
         }
         pr_default.close(8);
      }

      protected void move_previous( )
      {
         RcdFound1 = 0;
         /* Using cursor T000111 */
         pr_default.execute(9, new Object[] {A1ClienteCi});
         if ( (pr_default.getStatus(9) != 101) )
         {
            while ( (pr_default.getStatus(9) != 101) && ( ( T000111_A1ClienteCi[0] > A1ClienteCi ) ) )
            {
               pr_default.readNext(9);
            }
            if ( (pr_default.getStatus(9) != 101) && ( ( T000111_A1ClienteCi[0] < A1ClienteCi ) ) )
            {
               A1ClienteCi = T000111_A1ClienteCi[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1ClienteCi", StringUtil.LTrim( StringUtil.Str( (decimal)(A1ClienteCi), 8, 0)));
               RcdFound1 = 1;
            }
         }
         pr_default.close(9);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey011( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            A16ClienteUltimoTelefonoId = O16ClienteUltimoTelefonoId;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16ClienteUltimoTelefonoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A16ClienteUltimoTelefonoId), 4, 0)));
            GX_FocusControl = edtClienteCi_Internalname;
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
               if ( A1ClienteCi != Z1ClienteCi )
               {
                  A1ClienteCi = Z1ClienteCi;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1ClienteCi", StringUtil.LTrim( StringUtil.Str( (decimal)(A1ClienteCi), 8, 0)));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "CLIENTECI");
                  AnyError = 1;
                  GX_FocusControl = edtClienteCi_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  A16ClienteUltimoTelefonoId = O16ClienteUltimoTelefonoId;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16ClienteUltimoTelefonoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A16ClienteUltimoTelefonoId), 4, 0)));
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtClienteCi_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  Gx_mode = "UPD";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Update record */
                  A16ClienteUltimoTelefonoId = O16ClienteUltimoTelefonoId;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16ClienteUltimoTelefonoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A16ClienteUltimoTelefonoId), 4, 0)));
                  Update011( ) ;
                  GX_FocusControl = edtClienteCi_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A1ClienteCi != Z1ClienteCi )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Insert record */
                  A16ClienteUltimoTelefonoId = O16ClienteUltimoTelefonoId;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16ClienteUltimoTelefonoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A16ClienteUltimoTelefonoId), 4, 0)));
                  GX_FocusControl = edtClienteCi_Internalname;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "CLIENTECI");
                     AnyError = 1;
                     GX_FocusControl = edtClienteCi_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     Gx_mode = "INS";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     /* Insert record */
                     A16ClienteUltimoTelefonoId = O16ClienteUltimoTelefonoId;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16ClienteUltimoTelefonoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A16ClienteUltimoTelefonoId), 4, 0)));
                     GX_FocusControl = edtClienteCi_Internalname;
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
      }

      protected void btn_delete( )
      {
         if ( A1ClienteCi != Z1ClienteCi )
         {
            A1ClienteCi = Z1ClienteCi;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1ClienteCi", StringUtil.LTrim( StringUtil.Str( (decimal)(A1ClienteCi), 8, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "CLIENTECI");
            AnyError = 1;
            GX_FocusControl = edtClienteCi_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            A16ClienteUltimoTelefonoId = O16ClienteUltimoTelefonoId;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16ClienteUltimoTelefonoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A16ClienteUltimoTelefonoId), 4, 0)));
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtClienteCi_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            getByPrimaryKey( ) ;
         }
         CloseOpenCursors();
      }

      protected void btn_get( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         getEqualNoModal( ) ;
         if ( RcdFound1 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "CLIENTECI");
            AnyError = 1;
            GX_FocusControl = edtClienteCi_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         GX_FocusControl = edtClienteNombre_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         ScanStart011( ) ;
         if ( RcdFound1 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtClienteNombre_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd011( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_previous( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         move_previous( ) ;
         if ( RcdFound1 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtClienteNombre_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_next( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         move_next( ) ;
         if ( RcdFound1 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtClienteNombre_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_last( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         ScanStart011( ) ;
         if ( RcdFound1 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            while ( RcdFound1 != 0 )
            {
               ScanNext011( ) ;
            }
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtClienteNombre_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd011( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency011( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00014 */
            pr_default.execute(2, new Object[] {A1ClienteCi});
            if ( (pr_default.getStatus(2) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Cliente"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(2) == 101) || ( StringUtil.StrCmp(Z2ClienteNombre, T00014_A2ClienteNombre[0]) != 0 ) || ( StringUtil.StrCmp(Z3ClienteApellido, T00014_A3ClienteApellido[0]) != 0 ) || ( StringUtil.StrCmp(Z4ClienteEmail, T00014_A4ClienteEmail[0]) != 0 ) || ( StringUtil.StrCmp(Z5ClienteDireccion, T00014_A5ClienteDireccion[0]) != 0 ) || ( StringUtil.StrCmp(Z6ClienteObservacion, T00014_A6ClienteObservacion[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( Z14ClienteFechaIngreso != T00014_A14ClienteFechaIngreso[0] ) || ( Z16ClienteUltimoTelefonoId != T00014_A16ClienteUltimoTelefonoId[0] ) || ( Z18ClienteEdad != T00014_A18ClienteEdad[0] ) || ( Z7DepartamentoCodigo != T00014_A7DepartamentoCodigo[0] ) )
            {
               if ( StringUtil.StrCmp(Z2ClienteNombre, T00014_A2ClienteNombre[0]) != 0 )
               {
                  GXUtil.WriteLog("cliente:[seudo value changed for attri]"+"ClienteNombre");
                  GXUtil.WriteLogRaw("Old: ",Z2ClienteNombre);
                  GXUtil.WriteLogRaw("Current: ",T00014_A2ClienteNombre[0]);
               }
               if ( StringUtil.StrCmp(Z3ClienteApellido, T00014_A3ClienteApellido[0]) != 0 )
               {
                  GXUtil.WriteLog("cliente:[seudo value changed for attri]"+"ClienteApellido");
                  GXUtil.WriteLogRaw("Old: ",Z3ClienteApellido);
                  GXUtil.WriteLogRaw("Current: ",T00014_A3ClienteApellido[0]);
               }
               if ( StringUtil.StrCmp(Z4ClienteEmail, T00014_A4ClienteEmail[0]) != 0 )
               {
                  GXUtil.WriteLog("cliente:[seudo value changed for attri]"+"ClienteEmail");
                  GXUtil.WriteLogRaw("Old: ",Z4ClienteEmail);
                  GXUtil.WriteLogRaw("Current: ",T00014_A4ClienteEmail[0]);
               }
               if ( StringUtil.StrCmp(Z5ClienteDireccion, T00014_A5ClienteDireccion[0]) != 0 )
               {
                  GXUtil.WriteLog("cliente:[seudo value changed for attri]"+"ClienteDireccion");
                  GXUtil.WriteLogRaw("Old: ",Z5ClienteDireccion);
                  GXUtil.WriteLogRaw("Current: ",T00014_A5ClienteDireccion[0]);
               }
               if ( StringUtil.StrCmp(Z6ClienteObservacion, T00014_A6ClienteObservacion[0]) != 0 )
               {
                  GXUtil.WriteLog("cliente:[seudo value changed for attri]"+"ClienteObservacion");
                  GXUtil.WriteLogRaw("Old: ",Z6ClienteObservacion);
                  GXUtil.WriteLogRaw("Current: ",T00014_A6ClienteObservacion[0]);
               }
               if ( Z14ClienteFechaIngreso != T00014_A14ClienteFechaIngreso[0] )
               {
                  GXUtil.WriteLog("cliente:[seudo value changed for attri]"+"ClienteFechaIngreso");
                  GXUtil.WriteLogRaw("Old: ",Z14ClienteFechaIngreso);
                  GXUtil.WriteLogRaw("Current: ",T00014_A14ClienteFechaIngreso[0]);
               }
               if ( Z16ClienteUltimoTelefonoId != T00014_A16ClienteUltimoTelefonoId[0] )
               {
                  GXUtil.WriteLog("cliente:[seudo value changed for attri]"+"ClienteUltimoTelefonoId");
                  GXUtil.WriteLogRaw("Old: ",Z16ClienteUltimoTelefonoId);
                  GXUtil.WriteLogRaw("Current: ",T00014_A16ClienteUltimoTelefonoId[0]);
               }
               if ( Z18ClienteEdad != T00014_A18ClienteEdad[0] )
               {
                  GXUtil.WriteLog("cliente:[seudo value changed for attri]"+"ClienteEdad");
                  GXUtil.WriteLogRaw("Old: ",Z18ClienteEdad);
                  GXUtil.WriteLogRaw("Current: ",T00014_A18ClienteEdad[0]);
               }
               if ( Z7DepartamentoCodigo != T00014_A7DepartamentoCodigo[0] )
               {
                  GXUtil.WriteLog("cliente:[seudo value changed for attri]"+"DepartamentoCodigo");
                  GXUtil.WriteLogRaw("Old: ",Z7DepartamentoCodigo);
                  GXUtil.WriteLogRaw("Current: ",T00014_A7DepartamentoCodigo[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Cliente"}), "RecordWasChanged", 1, "");
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
                     /* Using cursor T000112 */
                     pr_default.execute(10, new Object[] {A1ClienteCi, A2ClienteNombre, A3ClienteApellido, A4ClienteEmail, A5ClienteDireccion, A6ClienteObservacion, A14ClienteFechaIngreso, A16ClienteUltimoTelefonoId, A18ClienteEdad, A7DepartamentoCodigo});
                     pr_default.close(10);
                     dsDefault.SmartCacheProvider.SetUpdated("Cliente") ;
                     if ( (pr_default.getStatus(10) == 1) )
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
                     /* Using cursor T000113 */
                     pr_default.execute(11, new Object[] {A2ClienteNombre, A3ClienteApellido, A4ClienteEmail, A5ClienteDireccion, A6ClienteObservacion, A14ClienteFechaIngreso, A16ClienteUltimoTelefonoId, A18ClienteEdad, A7DepartamentoCodigo, A1ClienteCi});
                     pr_default.close(11);
                     dsDefault.SmartCacheProvider.SetUpdated("Cliente") ;
                     if ( (pr_default.getStatus(11) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Cliente"}), "RecordIsLocked", 1, "");
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
                              getByPrimaryKey( ) ;
                              GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), "SuccessfullyUpdated", 0, "", true);
                              ResetCaption010( ) ;
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
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
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
                  A16ClienteUltimoTelefonoId = O16ClienteUltimoTelefonoId;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16ClienteUltimoTelefonoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A16ClienteUltimoTelefonoId), 4, 0)));
                  ScanStart016( ) ;
                  while ( RcdFound6 != 0 )
                  {
                     getByPrimaryKey016( ) ;
                     Delete016( ) ;
                     ScanNext016( ) ;
                     O16ClienteUltimoTelefonoId = A16ClienteUltimoTelefonoId;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16ClienteUltimoTelefonoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A16ClienteUltimoTelefonoId), 4, 0)));
                  }
                  ScanEnd016( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000114 */
                     pr_default.execute(12, new Object[] {A1ClienteCi});
                     pr_default.close(12);
                     dsDefault.SmartCacheProvider.SetUpdated("Cliente") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( delete) rules */
                        /* End of After( delete) rules */
                        if ( AnyError == 0 )
                        {
                           move_next( ) ;
                           if ( RcdFound1 == 0 )
                           {
                              InitAll011( ) ;
                              Gx_mode = "INS";
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           }
                           else
                           {
                              getByPrimaryKey( ) ;
                              Gx_mode = "UPD";
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           }
                           GX_msglist.addItem(context.GetMessage( "GXM_sucdeleted", ""), "SuccessfullyDeleted", 0, "", true);
                           ResetCaption010( ) ;
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
         EndLevel011( ) ;
         Gx_mode = sMode1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls011( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            /* Using cursor T000115 */
            pr_default.execute(13, new Object[] {A7DepartamentoCodigo});
            A8DepartamentoDescripcion = T000115_A8DepartamentoDescripcion[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8DepartamentoDescripcion", A8DepartamentoDescripcion);
            pr_default.close(13);
            A19ClienteEdadFormula = (short)(A18ClienteEdad*2);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19ClienteEdadFormula", StringUtil.LTrim( StringUtil.Str( (decimal)(A19ClienteEdadFormula), 4, 0)));
         }
      }

      protected void ProcessNestedLevel016( )
      {
         s16ClienteUltimoTelefonoId = O16ClienteUltimoTelefonoId;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16ClienteUltimoTelefonoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A16ClienteUltimoTelefonoId), 4, 0)));
         nGXsfl_98_idx = 0;
         while ( nGXsfl_98_idx < nRC_GXsfl_98 )
         {
            ReadRow016( ) ;
            if ( ( nRcdExists_6 != 0 ) || ( nIsMod_6 != 0 ) )
            {
               standaloneNotModal016( ) ;
               GetKey016( ) ;
               if ( ( nRcdExists_6 == 0 ) && ( nRcdDeleted_6 == 0 ) )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  Insert016( ) ;
               }
               else
               {
                  if ( RcdFound6 != 0 )
                  {
                     if ( ( nRcdDeleted_6 != 0 ) && ( nRcdExists_6 != 0 ) )
                     {
                        Gx_mode = "DLT";
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        Delete016( ) ;
                     }
                     else
                     {
                        if ( ( nIsMod_6 != 0 ) && ( nRcdExists_6 != 0 ) )
                        {
                           Gx_mode = "UPD";
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           Update016( ) ;
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_6 == 0 )
                     {
                        GXCCtl = "CLIENTETELEFONOID_" + sGXsfl_98_idx;
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, GXCCtl);
                        AnyError = 1;
                        GX_FocusControl = edtClienteTelefonoId_Internalname;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
               O16ClienteUltimoTelefonoId = A16ClienteUltimoTelefonoId;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16ClienteUltimoTelefonoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A16ClienteUltimoTelefonoId), 4, 0)));
            }
            ChangePostValue( edtClienteTelefonoId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A17ClienteTelefonoId), 4, 0, ".", ""))) ;
            ChangePostValue( edtClienteTelefonoNumero_Internalname, StringUtil.RTrim( A13ClienteTelefonoNumero)) ;
            ChangePostValue( edtClienteTelefonoDescripcion_Internalname, StringUtil.RTrim( A15ClienteTelefonoDescripcion)) ;
            ChangePostValue( "ZT_"+"Z17ClienteTelefonoId_"+sGXsfl_98_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z17ClienteTelefonoId), 4, 0, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z13ClienteTelefonoNumero_"+sGXsfl_98_idx, StringUtil.RTrim( Z13ClienteTelefonoNumero)) ;
            ChangePostValue( "ZT_"+"Z15ClienteTelefonoDescripcion_"+sGXsfl_98_idx, StringUtil.RTrim( Z15ClienteTelefonoDescripcion)) ;
            ChangePostValue( "nRcdDeleted_6_"+sGXsfl_98_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_6), 4, 0, ".", ""))) ;
            ChangePostValue( "nRcdExists_6_"+sGXsfl_98_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_6), 4, 0, ".", ""))) ;
            ChangePostValue( "nIsMod_6_"+sGXsfl_98_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_6), 4, 0, ".", ""))) ;
            if ( nIsMod_6 != 0 )
            {
               ChangePostValue( "CLIENTETELEFONOID_"+sGXsfl_98_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtClienteTelefonoId_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "CLIENTETELEFONONUMERO_"+sGXsfl_98_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtClienteTelefonoNumero_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "CLIENTETELEFONODESCRIPCION_"+sGXsfl_98_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtClienteTelefonoDescripcion_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
         InitAll016( ) ;
         if ( AnyError != 0 )
         {
            O16ClienteUltimoTelefonoId = s16ClienteUltimoTelefonoId;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16ClienteUltimoTelefonoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A16ClienteUltimoTelefonoId), 4, 0)));
         }
         nRcdExists_6 = 0;
         nIsMod_6 = 0;
         nRcdDeleted_6 = 0;
      }

      protected void ProcessLevel011( )
      {
         /* Save parent mode. */
         sMode1 = Gx_mode;
         ProcessNestedLevel016( ) ;
         if ( AnyError != 0 )
         {
            O16ClienteUltimoTelefonoId = s16ClienteUltimoTelefonoId;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16ClienteUltimoTelefonoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A16ClienteUltimoTelefonoId), 4, 0)));
         }
         /* Restore parent mode. */
         Gx_mode = sMode1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         /* ' Update level parameters */
         /* Using cursor T000116 */
         pr_default.execute(14, new Object[] {A16ClienteUltimoTelefonoId, A1ClienteCi});
         pr_default.close(14);
         dsDefault.SmartCacheProvider.SetUpdated("Cliente") ;
      }

      protected void EndLevel011( )
      {
         pr_default.close(2);
         if ( AnyError == 0 )
         {
            BeforeComplete011( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(3);
            pr_default.close(1);
            pr_default.close(0);
            pr_default.close(13);
            context.CommitDataStores("cliente",pr_default);
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
            pr_default.close(3);
            pr_default.close(1);
            pr_default.close(0);
            pr_default.close(13);
            context.RollbackDataStores("cliente",pr_default);
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
         /* Using cursor T000117 */
         pr_default.execute(15);
         RcdFound1 = 0;
         if ( (pr_default.getStatus(15) != 101) )
         {
            RcdFound1 = 1;
            A1ClienteCi = T000117_A1ClienteCi[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1ClienteCi", StringUtil.LTrim( StringUtil.Str( (decimal)(A1ClienteCi), 8, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext011( )
      {
         /* Scan next routine */
         pr_default.readNext(15);
         RcdFound1 = 0;
         if ( (pr_default.getStatus(15) != 101) )
         {
            RcdFound1 = 1;
            A1ClienteCi = T000117_A1ClienteCi[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1ClienteCi", StringUtil.LTrim( StringUtil.Str( (decimal)(A1ClienteCi), 8, 0)));
         }
      }

      protected void ScanEnd011( )
      {
         pr_default.close(15);
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
         edtClienteCi_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClienteCi_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClienteCi_Enabled), 5, 0)), true);
         edtClienteNombre_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClienteNombre_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClienteNombre_Enabled), 5, 0)), true);
         edtClienteApellido_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClienteApellido_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClienteApellido_Enabled), 5, 0)), true);
         edtClienteEmail_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClienteEmail_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClienteEmail_Enabled), 5, 0)), true);
         edtClienteDireccion_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClienteDireccion_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClienteDireccion_Enabled), 5, 0)), true);
         edtClienteObservacion_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClienteObservacion_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClienteObservacion_Enabled), 5, 0)), true);
         edtDepartamentoCodigo_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDepartamentoCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDepartamentoCodigo_Enabled), 5, 0)), true);
         edtDepartamentoDescripcion_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDepartamentoDescripcion_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDepartamentoDescripcion_Enabled), 5, 0)), true);
         edtClienteFechaIngreso_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClienteFechaIngreso_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClienteFechaIngreso_Enabled), 5, 0)), true);
         edtClienteUltimoTelefonoId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClienteUltimoTelefonoId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClienteUltimoTelefonoId_Enabled), 5, 0)), true);
         edtClienteEdad_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClienteEdad_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClienteEdad_Enabled), 5, 0)), true);
         edtClienteEdadFormula_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClienteEdadFormula_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClienteEdadFormula_Enabled), 5, 0)), true);
      }

      protected void ZM016( short GX_JID )
      {
         if ( ( GX_JID == 15 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z13ClienteTelefonoNumero = T00013_A13ClienteTelefonoNumero[0];
               Z15ClienteTelefonoDescripcion = T00013_A15ClienteTelefonoDescripcion[0];
            }
            else
            {
               Z13ClienteTelefonoNumero = A13ClienteTelefonoNumero;
               Z15ClienteTelefonoDescripcion = A15ClienteTelefonoDescripcion;
            }
         }
         if ( GX_JID == -15 )
         {
            Z1ClienteCi = A1ClienteCi;
            Z17ClienteTelefonoId = A17ClienteTelefonoId;
            Z13ClienteTelefonoNumero = A13ClienteTelefonoNumero;
            Z15ClienteTelefonoDescripcion = A15ClienteTelefonoDescripcion;
         }
      }

      protected void standaloneNotModal016( )
      {
         edtClienteUltimoTelefonoId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClienteUltimoTelefonoId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClienteUltimoTelefonoId_Enabled), 5, 0)), true);
         edtClienteUltimoTelefonoId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClienteUltimoTelefonoId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClienteUltimoTelefonoId_Enabled), 5, 0)), true);
      }

      protected void standaloneModal016( )
      {
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
         {
            A16ClienteUltimoTelefonoId = (short)(O16ClienteUltimoTelefonoId+1);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16ClienteUltimoTelefonoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A16ClienteUltimoTelefonoId), 4, 0)));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && ( Gx_BScreen == 1 ) )
         {
            A17ClienteTelefonoId = A16ClienteUltimoTelefonoId;
         }
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            edtClienteTelefonoId_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClienteTelefonoId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClienteTelefonoId_Enabled), 5, 0)), !bGXsfl_98_Refreshing);
         }
         else
         {
            edtClienteTelefonoId_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClienteTelefonoId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClienteTelefonoId_Enabled), 5, 0)), !bGXsfl_98_Refreshing);
         }
      }

      protected void Load016( )
      {
         /* Using cursor T000118 */
         pr_default.execute(16, new Object[] {A1ClienteCi, A17ClienteTelefonoId});
         if ( (pr_default.getStatus(16) != 101) )
         {
            RcdFound6 = 1;
            A13ClienteTelefonoNumero = T000118_A13ClienteTelefonoNumero[0];
            A15ClienteTelefonoDescripcion = T000118_A15ClienteTelefonoDescripcion[0];
            ZM016( -15) ;
         }
         pr_default.close(16);
         OnLoadActions016( ) ;
      }

      protected void OnLoadActions016( )
      {
      }

      protected void CheckExtendedTable016( )
      {
         Gx_BScreen = 1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
         standaloneModal016( ) ;
      }

      protected void CloseExtendedTableCursors016( )
      {
      }

      protected void enableDisable016( )
      {
      }

      protected void GetKey016( )
      {
         /* Using cursor T000119 */
         pr_default.execute(17, new Object[] {A1ClienteCi, A17ClienteTelefonoId});
         if ( (pr_default.getStatus(17) != 101) )
         {
            RcdFound6 = 1;
         }
         else
         {
            RcdFound6 = 0;
         }
         pr_default.close(17);
      }

      protected void getByPrimaryKey016( )
      {
         /* Using cursor T00013 */
         pr_default.execute(1, new Object[] {A1ClienteCi, A17ClienteTelefonoId});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM016( 15) ;
            RcdFound6 = 1;
            InitializeNonKey016( ) ;
            A17ClienteTelefonoId = T00013_A17ClienteTelefonoId[0];
            A13ClienteTelefonoNumero = T00013_A13ClienteTelefonoNumero[0];
            A15ClienteTelefonoDescripcion = T00013_A15ClienteTelefonoDescripcion[0];
            Z1ClienteCi = A1ClienteCi;
            Z17ClienteTelefonoId = A17ClienteTelefonoId;
            sMode6 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal016( ) ;
            Load016( ) ;
            Gx_mode = sMode6;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound6 = 0;
            InitializeNonKey016( ) ;
            sMode6 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal016( ) ;
            Gx_mode = sMode6;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            DisableAttributes016( ) ;
         }
         pr_default.close(1);
      }

      protected void CheckOptimisticConcurrency016( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00012 */
            pr_default.execute(0, new Object[] {A1ClienteCi, A17ClienteTelefonoId});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"ClienteTelefono"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z13ClienteTelefonoNumero, T00012_A13ClienteTelefonoNumero[0]) != 0 ) || ( StringUtil.StrCmp(Z15ClienteTelefonoDescripcion, T00012_A15ClienteTelefonoDescripcion[0]) != 0 ) )
            {
               if ( StringUtil.StrCmp(Z13ClienteTelefonoNumero, T00012_A13ClienteTelefonoNumero[0]) != 0 )
               {
                  GXUtil.WriteLog("cliente:[seudo value changed for attri]"+"ClienteTelefonoNumero");
                  GXUtil.WriteLogRaw("Old: ",Z13ClienteTelefonoNumero);
                  GXUtil.WriteLogRaw("Current: ",T00012_A13ClienteTelefonoNumero[0]);
               }
               if ( StringUtil.StrCmp(Z15ClienteTelefonoDescripcion, T00012_A15ClienteTelefonoDescripcion[0]) != 0 )
               {
                  GXUtil.WriteLog("cliente:[seudo value changed for attri]"+"ClienteTelefonoDescripcion");
                  GXUtil.WriteLogRaw("Old: ",Z15ClienteTelefonoDescripcion);
                  GXUtil.WriteLogRaw("Current: ",T00012_A15ClienteTelefonoDescripcion[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"ClienteTelefono"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert016( )
      {
         BeforeValidate016( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable016( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM016( 0) ;
            CheckOptimisticConcurrency016( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm016( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert016( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000120 */
                     pr_default.execute(18, new Object[] {A1ClienteCi, A17ClienteTelefonoId, A13ClienteTelefonoNumero, A15ClienteTelefonoDescripcion});
                     pr_default.close(18);
                     dsDefault.SmartCacheProvider.SetUpdated("ClienteTelefono") ;
                     if ( (pr_default.getStatus(18) == 1) )
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
               Load016( ) ;
            }
            EndLevel016( ) ;
         }
         CloseExtendedTableCursors016( ) ;
      }

      protected void Update016( )
      {
         BeforeValidate016( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable016( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency016( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm016( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate016( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000121 */
                     pr_default.execute(19, new Object[] {A13ClienteTelefonoNumero, A15ClienteTelefonoDescripcion, A1ClienteCi, A17ClienteTelefonoId});
                     pr_default.close(19);
                     dsDefault.SmartCacheProvider.SetUpdated("ClienteTelefono") ;
                     if ( (pr_default.getStatus(19) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"ClienteTelefono"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate016( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey016( ) ;
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
            EndLevel016( ) ;
         }
         CloseExtendedTableCursors016( ) ;
      }

      protected void DeferredUpdate016( )
      {
      }

      protected void Delete016( )
      {
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate016( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency016( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls016( ) ;
            AfterConfirm016( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete016( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000122 */
                  pr_default.execute(20, new Object[] {A1ClienteCi, A17ClienteTelefonoId});
                  pr_default.close(20);
                  dsDefault.SmartCacheProvider.SetUpdated("ClienteTelefono") ;
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
         sMode6 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel016( ) ;
         Gx_mode = sMode6;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls016( )
      {
         standaloneModal016( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel016( )
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

      public void ScanStart016( )
      {
         /* Scan By routine */
         /* Using cursor T000123 */
         pr_default.execute(21, new Object[] {A1ClienteCi});
         RcdFound6 = 0;
         if ( (pr_default.getStatus(21) != 101) )
         {
            RcdFound6 = 1;
            A17ClienteTelefonoId = T000123_A17ClienteTelefonoId[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext016( )
      {
         /* Scan next routine */
         pr_default.readNext(21);
         RcdFound6 = 0;
         if ( (pr_default.getStatus(21) != 101) )
         {
            RcdFound6 = 1;
            A17ClienteTelefonoId = T000123_A17ClienteTelefonoId[0];
         }
      }

      protected void ScanEnd016( )
      {
         pr_default.close(21);
      }

      protected void AfterConfirm016( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert016( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate016( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete016( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete016( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate016( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes016( )
      {
         edtClienteTelefonoId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClienteTelefonoId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClienteTelefonoId_Enabled), 5, 0)), !bGXsfl_98_Refreshing);
         edtClienteTelefonoNumero_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClienteTelefonoNumero_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClienteTelefonoNumero_Enabled), 5, 0)), !bGXsfl_98_Refreshing);
         edtClienteTelefonoDescripcion_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClienteTelefonoDescripcion_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClienteTelefonoDescripcion_Enabled), 5, 0)), !bGXsfl_98_Refreshing);
      }

      protected void send_integrity_lvl_hashes016( )
      {
      }

      protected void send_integrity_lvl_hashes011( )
      {
      }

      protected void SubsflControlProps_986( )
      {
         edtClienteTelefonoId_Internalname = "CLIENTETELEFONOID_"+sGXsfl_98_idx;
         edtClienteTelefonoNumero_Internalname = "CLIENTETELEFONONUMERO_"+sGXsfl_98_idx;
         edtClienteTelefonoDescripcion_Internalname = "CLIENTETELEFONODESCRIPCION_"+sGXsfl_98_idx;
      }

      protected void SubsflControlProps_fel_986( )
      {
         edtClienteTelefonoId_Internalname = "CLIENTETELEFONOID_"+sGXsfl_98_fel_idx;
         edtClienteTelefonoNumero_Internalname = "CLIENTETELEFONONUMERO_"+sGXsfl_98_fel_idx;
         edtClienteTelefonoDescripcion_Internalname = "CLIENTETELEFONODESCRIPCION_"+sGXsfl_98_fel_idx;
      }

      protected void AddRow016( )
      {
         nGXsfl_98_idx = (short)(nGXsfl_98_idx+1);
         sGXsfl_98_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_98_idx), 4, 0)), 4, "0");
         SubsflControlProps_986( ) ;
         SendRow016( ) ;
      }

      protected void SendRow016( )
      {
         Gridcliente_telefonoRow = GXWebRow.GetNew(context);
         if ( subGridcliente_telefono_Backcolorstyle == 0 )
         {
            /* None style subfile background logic. */
            subGridcliente_telefono_Backstyle = 0;
            if ( StringUtil.StrCmp(subGridcliente_telefono_Class, "") != 0 )
            {
               subGridcliente_telefono_Linesclass = subGridcliente_telefono_Class+"Odd";
            }
         }
         else if ( subGridcliente_telefono_Backcolorstyle == 1 )
         {
            /* Uniform style subfile background logic. */
            subGridcliente_telefono_Backstyle = 0;
            subGridcliente_telefono_Backcolor = subGridcliente_telefono_Allbackcolor;
            if ( StringUtil.StrCmp(subGridcliente_telefono_Class, "") != 0 )
            {
               subGridcliente_telefono_Linesclass = subGridcliente_telefono_Class+"Uniform";
            }
         }
         else if ( subGridcliente_telefono_Backcolorstyle == 2 )
         {
            /* Header style subfile background logic. */
            subGridcliente_telefono_Backstyle = 1;
            if ( StringUtil.StrCmp(subGridcliente_telefono_Class, "") != 0 )
            {
               subGridcliente_telefono_Linesclass = subGridcliente_telefono_Class+"Odd";
            }
            subGridcliente_telefono_Backcolor = (int)(0x0);
         }
         else if ( subGridcliente_telefono_Backcolorstyle == 3 )
         {
            /* Report style subfile background logic. */
            subGridcliente_telefono_Backstyle = 1;
            if ( ((int)(((nGXsfl_98_idx-1)/ (decimal)(1)) % (2))) == 0 )
            {
               subGridcliente_telefono_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGridcliente_telefono_Class, "") != 0 )
               {
                  subGridcliente_telefono_Linesclass = subGridcliente_telefono_Class+"Odd";
               }
            }
            else
            {
               subGridcliente_telefono_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGridcliente_telefono_Class, "") != 0 )
               {
                  subGridcliente_telefono_Linesclass = subGridcliente_telefono_Class+"Even";
               }
            }
         }
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_6_" + sGXsfl_98_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 99,'',false,'" + sGXsfl_98_idx + "',98)\"";
         ROClassString = "Attribute";
         Gridcliente_telefonoRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtClienteTelefonoId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A17ClienteTelefonoId), 4, 0, ".", "")),StringUtil.LTrim( context.localUtil.Format( (decimal)(A17ClienteTelefonoId), "ZZZ9")),TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,99);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtClienteTelefonoId_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtClienteTelefonoId_Enabled,(short)1,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)98,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         /* Single line edit */
         if ( context.isSmartDevice( ) )
         {
            gxphoneLink = "tel:" + StringUtil.RTrim( A13ClienteTelefonoNumero);
         }
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_6_" + sGXsfl_98_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 100,'',false,'" + sGXsfl_98_idx + "',98)\"";
         ROClassString = "Attribute";
         Gridcliente_telefonoRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtClienteTelefonoNumero_Internalname,StringUtil.RTrim( A13ClienteTelefonoNumero),(String)"",TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,100);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)gxphoneLink,(String)"",(String)"",(String)"",(String)edtClienteTelefonoNumero_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtClienteTelefonoNumero_Enabled,(short)0,(String)"tel",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)20,(short)0,(short)0,(short)98,(short)1,(short)-1,(short)0,(bool)true,(String)"GeneXus\\Phone",(String)"left",(bool)true});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_6_" + sGXsfl_98_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 101,'',false,'" + sGXsfl_98_idx + "',98)\"";
         ROClassString = "Attribute";
         Gridcliente_telefonoRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtClienteTelefonoDescripcion_Internalname,StringUtil.RTrim( A15ClienteTelefonoDescripcion),(String)"",TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,101);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtClienteTelefonoDescripcion_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtClienteTelefonoDescripcion_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)98,(short)1,(short)-1,(short)-1,(bool)true,(String)"DescripcionCorta",(String)"left",(bool)true});
         context.httpAjaxContext.ajax_sending_grid_row(Gridcliente_telefonoRow);
         send_integrity_lvl_hashes016( ) ;
         GXCCtl = "Z17ClienteTelefonoId_" + sGXsfl_98_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z17ClienteTelefonoId), 4, 0, ".", "")));
         GXCCtl = "Z13ClienteTelefonoNumero_" + sGXsfl_98_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Z13ClienteTelefonoNumero));
         GXCCtl = "Z15ClienteTelefonoDescripcion_" + sGXsfl_98_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Z15ClienteTelefonoDescripcion));
         GXCCtl = "nRcdDeleted_6_" + sGXsfl_98_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_6), 4, 0, ".", "")));
         GXCCtl = "nRcdExists_6_" + sGXsfl_98_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_6), 4, 0, ".", "")));
         GXCCtl = "nIsMod_6_" + sGXsfl_98_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_6), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "CLIENTETELEFONOID_"+sGXsfl_98_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtClienteTelefonoId_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "CLIENTETELEFONONUMERO_"+sGXsfl_98_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtClienteTelefonoNumero_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "CLIENTETELEFONODESCRIPCION_"+sGXsfl_98_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtClienteTelefonoDescripcion_Enabled), 5, 0, ".", "")));
         context.httpAjaxContext.ajax_sending_grid_row(null);
         Gridcliente_telefonoContainer.AddRow(Gridcliente_telefonoRow);
      }

      protected void ReadRow016( )
      {
         nGXsfl_98_idx = (short)(nGXsfl_98_idx+1);
         sGXsfl_98_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_98_idx), 4, 0)), 4, "0");
         SubsflControlProps_986( ) ;
         edtClienteTelefonoId_Enabled = (int)(context.localUtil.CToN( cgiGet( "CLIENTETELEFONOID_"+sGXsfl_98_idx+"Enabled"), ".", ","));
         edtClienteTelefonoNumero_Enabled = (int)(context.localUtil.CToN( cgiGet( "CLIENTETELEFONONUMERO_"+sGXsfl_98_idx+"Enabled"), ".", ","));
         edtClienteTelefonoDescripcion_Enabled = (int)(context.localUtil.CToN( cgiGet( "CLIENTETELEFONODESCRIPCION_"+sGXsfl_98_idx+"Enabled"), ".", ","));
         if ( ( ( context.localUtil.CToN( cgiGet( edtClienteTelefonoId_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtClienteTelefonoId_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
         {
            GXCCtl = "CLIENTETELEFONOID_" + sGXsfl_98_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtClienteTelefonoId_Internalname;
            wbErr = true;
            A17ClienteTelefonoId = 0;
         }
         else
         {
            A17ClienteTelefonoId = (short)(context.localUtil.CToN( cgiGet( edtClienteTelefonoId_Internalname), ".", ","));
         }
         A13ClienteTelefonoNumero = cgiGet( edtClienteTelefonoNumero_Internalname);
         A15ClienteTelefonoDescripcion = cgiGet( edtClienteTelefonoDescripcion_Internalname);
         GXCCtl = "Z17ClienteTelefonoId_" + sGXsfl_98_idx;
         Z17ClienteTelefonoId = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ","));
         GXCCtl = "Z13ClienteTelefonoNumero_" + sGXsfl_98_idx;
         Z13ClienteTelefonoNumero = cgiGet( GXCCtl);
         GXCCtl = "Z15ClienteTelefonoDescripcion_" + sGXsfl_98_idx;
         Z15ClienteTelefonoDescripcion = cgiGet( GXCCtl);
         GXCCtl = "nRcdDeleted_6_" + sGXsfl_98_idx;
         nRcdDeleted_6 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ","));
         GXCCtl = "nRcdExists_6_" + sGXsfl_98_idx;
         nRcdExists_6 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ","));
         GXCCtl = "nIsMod_6_" + sGXsfl_98_idx;
         nIsMod_6 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ","));
      }

      protected void assign_properties_default( )
      {
         defedtClienteTelefonoId_Enabled = edtClienteTelefonoId_Enabled;
      }

      protected void ConfirmValues010( )
      {
         nGXsfl_98_idx = 0;
         sGXsfl_98_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_98_idx), 4, 0)), 4, "0");
         SubsflControlProps_986( ) ;
         while ( nGXsfl_98_idx < nRC_GXsfl_98 )
         {
            nGXsfl_98_idx = (short)(nGXsfl_98_idx+1);
            sGXsfl_98_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_98_idx), 4, 0)), 4, "0");
            SubsflControlProps_986( ) ;
            ChangePostValue( "Z17ClienteTelefonoId_"+sGXsfl_98_idx, cgiGet( "ZT_"+"Z17ClienteTelefonoId_"+sGXsfl_98_idx)) ;
            DeletePostValue( "ZT_"+"Z17ClienteTelefonoId_"+sGXsfl_98_idx) ;
            ChangePostValue( "Z13ClienteTelefonoNumero_"+sGXsfl_98_idx, cgiGet( "ZT_"+"Z13ClienteTelefonoNumero_"+sGXsfl_98_idx)) ;
            DeletePostValue( "ZT_"+"Z13ClienteTelefonoNumero_"+sGXsfl_98_idx) ;
            ChangePostValue( "Z15ClienteTelefonoDescripcion_"+sGXsfl_98_idx, cgiGet( "ZT_"+"Z15ClienteTelefonoDescripcion_"+sGXsfl_98_idx)) ;
            DeletePostValue( "ZT_"+"Z15ClienteTelefonoDescripcion_"+sGXsfl_98_idx) ;
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
         context.AddJavascriptSource("gxcfg.js", "?20193821173211", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("cliente.aspx") +"\">") ;
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
         forbiddenHiddens = "hsh" + "Cliente";
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format(A14ClienteFechaIngreso, "99/99/99");
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("cliente:[SendSecurityCheck value for]"+"ClienteFechaIngreso:"+context.localUtil.Format(A14ClienteFechaIngreso, "99/99/99"));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z1ClienteCi", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z1ClienteCi), 8, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z2ClienteNombre", StringUtil.RTrim( Z2ClienteNombre));
         GxWebStd.gx_hidden_field( context, "Z3ClienteApellido", StringUtil.RTrim( Z3ClienteApellido));
         GxWebStd.gx_hidden_field( context, "Z4ClienteEmail", Z4ClienteEmail);
         GxWebStd.gx_hidden_field( context, "Z5ClienteDireccion", Z5ClienteDireccion);
         GxWebStd.gx_hidden_field( context, "Z6ClienteObservacion", StringUtil.RTrim( Z6ClienteObservacion));
         GxWebStd.gx_hidden_field( context, "Z14ClienteFechaIngreso", context.localUtil.DToC( Z14ClienteFechaIngreso, 0, "/"));
         GxWebStd.gx_hidden_field( context, "Z16ClienteUltimoTelefonoId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z16ClienteUltimoTelefonoId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z18ClienteEdad", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z18ClienteEdad), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z7DepartamentoCodigo", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z7DepartamentoCodigo), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "O16ClienteUltimoTelefonoId", StringUtil.LTrim( StringUtil.NToC( (decimal)(O16ClienteUltimoTelefonoId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_98", StringUtil.LTrim( StringUtil.NToC( (decimal)(nGXsfl_98_idx), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vTODAY", context.localUtil.DToC( Gx_date, 0, "/"));
         GxWebStd.gx_hidden_field( context, "vGXBSCREEN", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gx_BScreen), 1, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
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
         return formatLink("cliente.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "Cliente" ;
      }

      public override String GetPgmdesc( )
      {
         return "Cliente" ;
      }

      protected void InitializeNonKey011( )
      {
         A2ClienteNombre = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2ClienteNombre", A2ClienteNombre);
         A3ClienteApellido = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3ClienteApellido", A3ClienteApellido);
         A4ClienteEmail = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4ClienteEmail", A4ClienteEmail);
         A5ClienteDireccion = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5ClienteDireccion", A5ClienteDireccion);
         A6ClienteObservacion = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6ClienteObservacion", A6ClienteObservacion);
         A7DepartamentoCodigo = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7DepartamentoCodigo", StringUtil.LTrim( StringUtil.Str( (decimal)(A7DepartamentoCodigo), 4, 0)));
         A8DepartamentoDescripcion = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8DepartamentoDescripcion", A8DepartamentoDescripcion);
         A16ClienteUltimoTelefonoId = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16ClienteUltimoTelefonoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A16ClienteUltimoTelefonoId), 4, 0)));
         A18ClienteEdad = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18ClienteEdad", StringUtil.LTrim( StringUtil.Str( (decimal)(A18ClienteEdad), 4, 0)));
         A19ClienteEdadFormula = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19ClienteEdadFormula", StringUtil.LTrim( StringUtil.Str( (decimal)(A19ClienteEdadFormula), 4, 0)));
         A14ClienteFechaIngreso = Gx_date;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A14ClienteFechaIngreso", context.localUtil.Format(A14ClienteFechaIngreso, "99/99/99"));
         O16ClienteUltimoTelefonoId = A16ClienteUltimoTelefonoId;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16ClienteUltimoTelefonoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A16ClienteUltimoTelefonoId), 4, 0)));
         Z2ClienteNombre = "";
         Z3ClienteApellido = "";
         Z4ClienteEmail = "";
         Z5ClienteDireccion = "";
         Z6ClienteObservacion = "";
         Z14ClienteFechaIngreso = DateTime.MinValue;
         Z16ClienteUltimoTelefonoId = 0;
         Z18ClienteEdad = 0;
         Z7DepartamentoCodigo = 0;
      }

      protected void InitAll011( )
      {
         A1ClienteCi = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1ClienteCi", StringUtil.LTrim( StringUtil.Str( (decimal)(A1ClienteCi), 8, 0)));
         InitializeNonKey011( ) ;
      }

      protected void StandaloneModalInsert( )
      {
         A14ClienteFechaIngreso = i14ClienteFechaIngreso;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A14ClienteFechaIngreso", context.localUtil.Format(A14ClienteFechaIngreso, "99/99/99"));
      }

      protected void InitializeNonKey016( )
      {
         A13ClienteTelefonoNumero = "";
         A15ClienteTelefonoDescripcion = "";
         Z13ClienteTelefonoNumero = "";
         Z15ClienteTelefonoDescripcion = "";
      }

      protected void InitAll016( )
      {
         A17ClienteTelefonoId = 0;
         InitializeNonKey016( ) ;
      }

      protected void StandaloneModalInsert016( )
      {
         A16ClienteUltimoTelefonoId = i16ClienteUltimoTelefonoId;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16ClienteUltimoTelefonoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A16ClienteUltimoTelefonoId), 4, 0)));
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20193821173223", true);
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
         context.AddJavascriptSource("cliente.js", "?20193821173223", false);
         /* End function include_jscripts */
      }

      protected void init_level_properties6( )
      {
         edtClienteTelefonoId_Enabled = defedtClienteTelefonoId_Enabled;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClienteTelefonoId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClienteTelefonoId_Enabled), 5, 0)), !bGXsfl_98_Refreshing);
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
         edtClienteCi_Internalname = "CLIENTECI";
         edtClienteNombre_Internalname = "CLIENTENOMBRE";
         edtClienteApellido_Internalname = "CLIENTEAPELLIDO";
         edtClienteEmail_Internalname = "CLIENTEEMAIL";
         edtClienteDireccion_Internalname = "CLIENTEDIRECCION";
         edtClienteObservacion_Internalname = "CLIENTEOBSERVACION";
         edtDepartamentoCodigo_Internalname = "DEPARTAMENTOCODIGO";
         edtDepartamentoDescripcion_Internalname = "DEPARTAMENTODESCRIPCION";
         edtClienteFechaIngreso_Internalname = "CLIENTEFECHAINGRESO";
         edtClienteUltimoTelefonoId_Internalname = "CLIENTEULTIMOTELEFONOID";
         edtClienteEdad_Internalname = "CLIENTEEDAD";
         edtClienteEdadFormula_Internalname = "CLIENTEEDADFORMULA";
         lblTitletelefono_Internalname = "TITLETELEFONO";
         edtClienteTelefonoId_Internalname = "CLIENTETELEFONOID";
         edtClienteTelefonoNumero_Internalname = "CLIENTETELEFONONUMERO";
         edtClienteTelefonoDescripcion_Internalname = "CLIENTETELEFONODESCRIPCION";
         divTelefonotable_Internalname = "TELEFONOTABLE";
         divFormcontainer_Internalname = "FORMCONTAINER";
         bttBtn_enter_Internalname = "BTN_ENTER";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         bttBtn_delete_Internalname = "BTN_DELETE";
         divMaintable_Internalname = "MAINTABLE";
         Form.Internalname = "FORM";
         imgprompt_7_Internalname = "PROMPT_7";
         subGridcliente_telefono_Internalname = "GRIDCLIENTE_TELEFONO";
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
         Form.Caption = "Cliente";
         edtClienteTelefonoDescripcion_Jsonclick = "";
         edtClienteTelefonoNumero_Jsonclick = "";
         edtClienteTelefonoId_Jsonclick = "";
         subGridcliente_telefono_Class = "Grid";
         subGridcliente_telefono_Backcolorstyle = 0;
         subGridcliente_telefono_Allowcollapsing = 0;
         subGridcliente_telefono_Allowselection = 0;
         edtClienteTelefonoDescripcion_Enabled = 1;
         edtClienteTelefonoNumero_Enabled = 1;
         edtClienteTelefonoId_Enabled = 1;
         subGridcliente_telefono_Header = "";
         bttBtn_delete_Enabled = 1;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edtClienteEdadFormula_Jsonclick = "";
         edtClienteEdadFormula_Enabled = 0;
         edtClienteEdad_Jsonclick = "";
         edtClienteEdad_Enabled = 1;
         edtClienteUltimoTelefonoId_Jsonclick = "";
         edtClienteUltimoTelefonoId_Enabled = 0;
         edtClienteUltimoTelefonoId_Visible = 1;
         edtClienteFechaIngreso_Jsonclick = "";
         edtClienteFechaIngreso_Enabled = 0;
         edtDepartamentoDescripcion_Jsonclick = "";
         edtDepartamentoDescripcion_Enabled = 0;
         imgprompt_7_Visible = 1;
         imgprompt_7_Link = "";
         edtDepartamentoCodigo_Jsonclick = "";
         edtDepartamentoCodigo_Enabled = 1;
         edtClienteObservacion_Jsonclick = "";
         edtClienteObservacion_Enabled = 1;
         edtClienteDireccion_Enabled = 1;
         edtClienteEmail_Jsonclick = "";
         edtClienteEmail_Enabled = 1;
         edtClienteApellido_Jsonclick = "";
         edtClienteApellido_Enabled = 1;
         edtClienteNombre_Jsonclick = "";
         edtClienteNombre_Enabled = 1;
         edtClienteCi_Jsonclick = "";
         edtClienteCi_Enabled = 1;
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

      protected void gxnrGridcliente_telefono_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         Gx_mode = "INS";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         SubsflControlProps_986( ) ;
         while ( nGXsfl_98_idx <= nRC_GXsfl_98 )
         {
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            standaloneNotModal016( ) ;
            standaloneModal016( ) ;
            init_web_controls( ) ;
            dynload_actions( ) ;
            SendRow016( ) ;
            nGXsfl_98_idx = (short)(nGXsfl_98_idx+1);
            sGXsfl_98_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_98_idx), 4, 0)), 4, "0");
            SubsflControlProps_986( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( Gridcliente_telefonoContainer));
         /* End function gxnrGridcliente_telefono_newrow */
      }

      protected void init_web_controls( )
      {
         /* End function init_web_controls */
      }

      protected void AfterKeyLoadScreen( )
      {
         IsConfirmed = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         getEqualNoModal( ) ;
         GX_FocusControl = edtClienteNombre_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         /* End function AfterKeyLoadScreen */
      }

      public void Valid_Clienteci( String GX_Parm1 ,
                                   short GX_Parm2 ,
                                   int GX_Parm3 ,
                                   String GX_Parm4 ,
                                   String GX_Parm5 ,
                                   String GX_Parm6 ,
                                   String GX_Parm7 ,
                                   String GX_Parm8 ,
                                   DateTime GX_Parm9 ,
                                   short GX_Parm10 ,
                                   short GX_Parm11 ,
                                   short GX_Parm12 )
      {
         Gx_mode = GX_Parm1;
         Gx_BScreen = GX_Parm2;
         A1ClienteCi = GX_Parm3;
         A2ClienteNombre = GX_Parm4;
         A3ClienteApellido = GX_Parm5;
         A4ClienteEmail = GX_Parm6;
         A5ClienteDireccion = GX_Parm7;
         A6ClienteObservacion = GX_Parm8;
         A14ClienteFechaIngreso = GX_Parm9;
         A16ClienteUltimoTelefonoId = GX_Parm10;
         A18ClienteEdad = GX_Parm11;
         A7DepartamentoCodigo = GX_Parm12;
         context.wbHandled = 1;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         send_integrity_footer_hashes( ) ;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A8DepartamentoDescripcion = "";
         }
         isValidOutput.Add(StringUtil.RTrim( A2ClienteNombre));
         isValidOutput.Add(StringUtil.RTrim( A3ClienteApellido));
         isValidOutput.Add(A4ClienteEmail);
         isValidOutput.Add(A5ClienteDireccion);
         isValidOutput.Add(StringUtil.RTrim( A6ClienteObservacion));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(A7DepartamentoCodigo), 4, 0, ".", "")));
         isValidOutput.Add(context.localUtil.Format(A14ClienteFechaIngreso, "99/99/99"));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(A16ClienteUltimoTelefonoId), 4, 0, ".", "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(A18ClienteEdad), 4, 0, ".", "")));
         isValidOutput.Add(StringUtil.RTrim( A8DepartamentoDescripcion));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(A19ClienteEdadFormula), 4, 0, ".", "")));
         isValidOutput.Add(StringUtil.RTrim( Gx_mode));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z1ClienteCi), 8, 0, ".", "")));
         isValidOutput.Add(StringUtil.RTrim( Z2ClienteNombre));
         isValidOutput.Add(StringUtil.RTrim( Z3ClienteApellido));
         isValidOutput.Add(Z4ClienteEmail);
         isValidOutput.Add(Z5ClienteDireccion);
         isValidOutput.Add(StringUtil.RTrim( Z6ClienteObservacion));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z7DepartamentoCodigo), 4, 0, ".", "")));
         isValidOutput.Add(context.localUtil.DToC( Z14ClienteFechaIngreso, 0, "/"));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z16ClienteUltimoTelefonoId), 4, 0, ".", "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z18ClienteEdad), 4, 0, ".", "")));
         isValidOutput.Add(StringUtil.RTrim( Z8DepartamentoDescripcion));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z19ClienteEdadFormula), 4, 0, ".", "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(O16ClienteUltimoTelefonoId), 4, 0, ".", "")));
         isValidOutput.Add(Gridcliente_telefonoContainer);
         isValidOutput.Add(bttBtn_delete_Enabled);
         isValidOutput.Add(bttBtn_enter_Enabled);
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         isValidOutput.Add(context.httpAjaxContext.ajax_rsp_get_hiddens( ));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public void Valid_Departamentocodigo( short GX_Parm1 ,
                                            String GX_Parm2 )
      {
         A7DepartamentoCodigo = GX_Parm1;
         A8DepartamentoDescripcion = GX_Parm2;
         /* Using cursor T000115 */
         pr_default.execute(13, new Object[] {A7DepartamentoCodigo});
         if ( (pr_default.getStatus(13) == 101) )
         {
            GX_msglist.addItem("No matching 'Departamento'.", "ForeignKeyNotFound", 1, "DEPARTAMENTOCODIGO");
            AnyError = 1;
            GX_FocusControl = edtDepartamentoCodigo_Internalname;
         }
         A8DepartamentoDescripcion = T000115_A8DepartamentoDescripcion[0];
         pr_default.close(13);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A8DepartamentoDescripcion = "";
         }
         isValidOutput.Add(StringUtil.RTrim( A8DepartamentoDescripcion));
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
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true}]");
         setEventMetadata("ENTER",",oparms:[]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'A14ClienteFechaIngreso',fld:'CLIENTEFECHAINGRESO',pic:''}]");
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
         pr_default.close(1);
         pr_default.close(3);
         pr_default.close(13);
      }

      public override void initialize( )
      {
         sPrefix = "";
         Z2ClienteNombre = "";
         Z3ClienteApellido = "";
         Z4ClienteEmail = "";
         Z5ClienteDireccion = "";
         Z6ClienteObservacion = "";
         Z14ClienteFechaIngreso = DateTime.MinValue;
         Z13ClienteTelefonoNumero = "";
         Z15ClienteTelefonoDescripcion = "";
         scmdbuf = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         Gx_mode = "";
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
         A2ClienteNombre = "";
         A3ClienteApellido = "";
         A4ClienteEmail = "";
         A5ClienteDireccion = "";
         A6ClienteObservacion = "";
         sImgUrl = "";
         A8DepartamentoDescripcion = "";
         A14ClienteFechaIngreso = DateTime.MinValue;
         lblTitletelefono_Jsonclick = "";
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         Gridcliente_telefonoContainer = new GXWebGrid( context);
         Gridcliente_telefonoColumn = new GXWebColumn();
         A13ClienteTelefonoNumero = "";
         A15ClienteTelefonoDescripcion = "";
         sMode6 = "";
         sStyleString = "";
         Gx_date = DateTime.MinValue;
         forbiddenHiddens = "";
         hsh = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         GXCCtl = "";
         Z8DepartamentoDescripcion = "";
         T00017_A1ClienteCi = new int[1] ;
         T00017_A2ClienteNombre = new String[] {""} ;
         T00017_A3ClienteApellido = new String[] {""} ;
         T00017_A4ClienteEmail = new String[] {""} ;
         T00017_A5ClienteDireccion = new String[] {""} ;
         T00017_A6ClienteObservacion = new String[] {""} ;
         T00017_A8DepartamentoDescripcion = new String[] {""} ;
         T00017_A14ClienteFechaIngreso = new DateTime[] {DateTime.MinValue} ;
         T00017_A16ClienteUltimoTelefonoId = new short[1] ;
         T00017_A18ClienteEdad = new short[1] ;
         T00017_A7DepartamentoCodigo = new short[1] ;
         T00016_A8DepartamentoDescripcion = new String[] {""} ;
         T00018_A8DepartamentoDescripcion = new String[] {""} ;
         T00019_A1ClienteCi = new int[1] ;
         T00015_A1ClienteCi = new int[1] ;
         T00015_A2ClienteNombre = new String[] {""} ;
         T00015_A3ClienteApellido = new String[] {""} ;
         T00015_A4ClienteEmail = new String[] {""} ;
         T00015_A5ClienteDireccion = new String[] {""} ;
         T00015_A6ClienteObservacion = new String[] {""} ;
         T00015_A14ClienteFechaIngreso = new DateTime[] {DateTime.MinValue} ;
         T00015_A16ClienteUltimoTelefonoId = new short[1] ;
         T00015_A18ClienteEdad = new short[1] ;
         T00015_A7DepartamentoCodigo = new short[1] ;
         sMode1 = "";
         T000110_A1ClienteCi = new int[1] ;
         T000111_A1ClienteCi = new int[1] ;
         T00014_A1ClienteCi = new int[1] ;
         T00014_A2ClienteNombre = new String[] {""} ;
         T00014_A3ClienteApellido = new String[] {""} ;
         T00014_A4ClienteEmail = new String[] {""} ;
         T00014_A5ClienteDireccion = new String[] {""} ;
         T00014_A6ClienteObservacion = new String[] {""} ;
         T00014_A14ClienteFechaIngreso = new DateTime[] {DateTime.MinValue} ;
         T00014_A16ClienteUltimoTelefonoId = new short[1] ;
         T00014_A18ClienteEdad = new short[1] ;
         T00014_A7DepartamentoCodigo = new short[1] ;
         T000115_A8DepartamentoDescripcion = new String[] {""} ;
         T000117_A1ClienteCi = new int[1] ;
         T000118_A1ClienteCi = new int[1] ;
         T000118_A17ClienteTelefonoId = new short[1] ;
         T000118_A13ClienteTelefonoNumero = new String[] {""} ;
         T000118_A15ClienteTelefonoDescripcion = new String[] {""} ;
         T000119_A1ClienteCi = new int[1] ;
         T000119_A17ClienteTelefonoId = new short[1] ;
         T00013_A1ClienteCi = new int[1] ;
         T00013_A17ClienteTelefonoId = new short[1] ;
         T00013_A13ClienteTelefonoNumero = new String[] {""} ;
         T00013_A15ClienteTelefonoDescripcion = new String[] {""} ;
         T00012_A1ClienteCi = new int[1] ;
         T00012_A17ClienteTelefonoId = new short[1] ;
         T00012_A13ClienteTelefonoNumero = new String[] {""} ;
         T00012_A15ClienteTelefonoDescripcion = new String[] {""} ;
         T000123_A1ClienteCi = new int[1] ;
         T000123_A17ClienteTelefonoId = new short[1] ;
         Gridcliente_telefonoRow = new GXWebRow();
         subGridcliente_telefono_Linesclass = "";
         ROClassString = "";
         gxphoneLink = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         i14ClienteFechaIngreso = DateTime.MinValue;
         isValidOutput = new GxUnknownObjectCollection();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.cliente__default(),
            new Object[][] {
                new Object[] {
               T00012_A1ClienteCi, T00012_A17ClienteTelefonoId, T00012_A13ClienteTelefonoNumero, T00012_A15ClienteTelefonoDescripcion
               }
               , new Object[] {
               T00013_A1ClienteCi, T00013_A17ClienteTelefonoId, T00013_A13ClienteTelefonoNumero, T00013_A15ClienteTelefonoDescripcion
               }
               , new Object[] {
               T00014_A1ClienteCi, T00014_A2ClienteNombre, T00014_A3ClienteApellido, T00014_A4ClienteEmail, T00014_A5ClienteDireccion, T00014_A6ClienteObservacion, T00014_A14ClienteFechaIngreso, T00014_A16ClienteUltimoTelefonoId, T00014_A18ClienteEdad, T00014_A7DepartamentoCodigo
               }
               , new Object[] {
               T00015_A1ClienteCi, T00015_A2ClienteNombre, T00015_A3ClienteApellido, T00015_A4ClienteEmail, T00015_A5ClienteDireccion, T00015_A6ClienteObservacion, T00015_A14ClienteFechaIngreso, T00015_A16ClienteUltimoTelefonoId, T00015_A18ClienteEdad, T00015_A7DepartamentoCodigo
               }
               , new Object[] {
               T00016_A8DepartamentoDescripcion
               }
               , new Object[] {
               T00017_A1ClienteCi, T00017_A2ClienteNombre, T00017_A3ClienteApellido, T00017_A4ClienteEmail, T00017_A5ClienteDireccion, T00017_A6ClienteObservacion, T00017_A8DepartamentoDescripcion, T00017_A14ClienteFechaIngreso, T00017_A16ClienteUltimoTelefonoId, T00017_A18ClienteEdad,
               T00017_A7DepartamentoCodigo
               }
               , new Object[] {
               T00018_A8DepartamentoDescripcion
               }
               , new Object[] {
               T00019_A1ClienteCi
               }
               , new Object[] {
               T000110_A1ClienteCi
               }
               , new Object[] {
               T000111_A1ClienteCi
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000115_A8DepartamentoDescripcion
               }
               , new Object[] {
               }
               , new Object[] {
               T000117_A1ClienteCi
               }
               , new Object[] {
               T000118_A1ClienteCi, T000118_A17ClienteTelefonoId, T000118_A13ClienteTelefonoNumero, T000118_A15ClienteTelefonoDescripcion
               }
               , new Object[] {
               T000119_A1ClienteCi, T000119_A17ClienteTelefonoId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000123_A1ClienteCi, T000123_A17ClienteTelefonoId
               }
            }
         );
         Z14ClienteFechaIngreso = DateTime.MinValue;
         A14ClienteFechaIngreso = DateTime.MinValue;
         i14ClienteFechaIngreso = DateTime.MinValue;
         Gx_date = DateTimeUtil.Today( context);
      }

      private short Z16ClienteUltimoTelefonoId ;
      private short Z18ClienteEdad ;
      private short Z7DepartamentoCodigo ;
      private short O16ClienteUltimoTelefonoId ;
      private short nRC_GXsfl_98 ;
      private short nGXsfl_98_idx=1 ;
      private short Z17ClienteTelefonoId ;
      private short nRcdDeleted_6 ;
      private short nRcdExists_6 ;
      private short nIsMod_6 ;
      private short GxWebError ;
      private short A7DepartamentoCodigo ;
      private short A16ClienteUltimoTelefonoId ;
      private short Gx_BScreen ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short A18ClienteEdad ;
      private short A19ClienteEdadFormula ;
      private short subGridcliente_telefono_Backcolorstyle ;
      private short A17ClienteTelefonoId ;
      private short subGridcliente_telefono_Allowselection ;
      private short subGridcliente_telefono_Allowhovering ;
      private short subGridcliente_telefono_Allowcollapsing ;
      private short subGridcliente_telefono_Collapsed ;
      private short nBlankRcdCount6 ;
      private short RcdFound6 ;
      private short B16ClienteUltimoTelefonoId ;
      private short nBlankRcdUsr6 ;
      private short s16ClienteUltimoTelefonoId ;
      private short GX_JID ;
      private short RcdFound1 ;
      private short subGridcliente_telefono_Backstyle ;
      private short gxajaxcallmode ;
      private short i16ClienteUltimoTelefonoId ;
      private short Z19ClienteEdadFormula ;
      private short wbTemp ;
      private int Z1ClienteCi ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int A1ClienteCi ;
      private int edtClienteCi_Enabled ;
      private int edtClienteNombre_Enabled ;
      private int edtClienteApellido_Enabled ;
      private int edtClienteEmail_Enabled ;
      private int edtClienteDireccion_Enabled ;
      private int edtClienteObservacion_Enabled ;
      private int edtDepartamentoCodigo_Enabled ;
      private int imgprompt_7_Visible ;
      private int edtDepartamentoDescripcion_Enabled ;
      private int edtClienteFechaIngreso_Enabled ;
      private int edtClienteUltimoTelefonoId_Visible ;
      private int edtClienteUltimoTelefonoId_Enabled ;
      private int edtClienteEdad_Enabled ;
      private int edtClienteEdadFormula_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int edtClienteTelefonoId_Enabled ;
      private int edtClienteTelefonoNumero_Enabled ;
      private int edtClienteTelefonoDescripcion_Enabled ;
      private int subGridcliente_telefono_Selectedindex ;
      private int subGridcliente_telefono_Selectioncolor ;
      private int subGridcliente_telefono_Hoveringcolor ;
      private int fRowAdded ;
      private int subGridcliente_telefono_Backcolor ;
      private int subGridcliente_telefono_Allbackcolor ;
      private int defedtClienteTelefonoId_Enabled ;
      private int idxLst ;
      private long GRIDCLIENTE_TELEFONO_nFirstRecordOnPage ;
      private String sPrefix ;
      private String Z2ClienteNombre ;
      private String Z3ClienteApellido ;
      private String Z6ClienteObservacion ;
      private String Z13ClienteTelefonoNumero ;
      private String Z15ClienteTelefonoDescripcion ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_98_idx="0001" ;
      private String Gx_mode ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtClienteCi_Internalname ;
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
      private String edtClienteCi_Jsonclick ;
      private String edtClienteNombre_Internalname ;
      private String A2ClienteNombre ;
      private String edtClienteNombre_Jsonclick ;
      private String edtClienteApellido_Internalname ;
      private String A3ClienteApellido ;
      private String edtClienteApellido_Jsonclick ;
      private String edtClienteEmail_Internalname ;
      private String edtClienteEmail_Jsonclick ;
      private String edtClienteDireccion_Internalname ;
      private String edtClienteObservacion_Internalname ;
      private String A6ClienteObservacion ;
      private String edtClienteObservacion_Jsonclick ;
      private String edtDepartamentoCodigo_Internalname ;
      private String edtDepartamentoCodigo_Jsonclick ;
      private String sImgUrl ;
      private String imgprompt_7_Internalname ;
      private String imgprompt_7_Link ;
      private String edtDepartamentoDescripcion_Internalname ;
      private String A8DepartamentoDescripcion ;
      private String edtDepartamentoDescripcion_Jsonclick ;
      private String edtClienteFechaIngreso_Internalname ;
      private String edtClienteFechaIngreso_Jsonclick ;
      private String edtClienteUltimoTelefonoId_Internalname ;
      private String edtClienteUltimoTelefonoId_Jsonclick ;
      private String edtClienteEdad_Internalname ;
      private String edtClienteEdad_Jsonclick ;
      private String edtClienteEdadFormula_Internalname ;
      private String edtClienteEdadFormula_Jsonclick ;
      private String divTelefonotable_Internalname ;
      private String lblTitletelefono_Internalname ;
      private String lblTitletelefono_Jsonclick ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String subGridcliente_telefono_Header ;
      private String A13ClienteTelefonoNumero ;
      private String A15ClienteTelefonoDescripcion ;
      private String sMode6 ;
      private String edtClienteTelefonoId_Internalname ;
      private String edtClienteTelefonoNumero_Internalname ;
      private String edtClienteTelefonoDescripcion_Internalname ;
      private String sStyleString ;
      private String forbiddenHiddens ;
      private String hsh ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String GXCCtl ;
      private String Z8DepartamentoDescripcion ;
      private String sMode1 ;
      private String sGXsfl_98_fel_idx="0001" ;
      private String subGridcliente_telefono_Class ;
      private String subGridcliente_telefono_Linesclass ;
      private String ROClassString ;
      private String edtClienteTelefonoId_Jsonclick ;
      private String gxphoneLink ;
      private String edtClienteTelefonoNumero_Jsonclick ;
      private String edtClienteTelefonoDescripcion_Jsonclick ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String subGridcliente_telefono_Internalname ;
      private DateTime Z14ClienteFechaIngreso ;
      private DateTime A14ClienteFechaIngreso ;
      private DateTime Gx_date ;
      private DateTime i14ClienteFechaIngreso ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool bGXsfl_98_Refreshing=false ;
      private bool Gx_longc ;
      private String Z4ClienteEmail ;
      private String Z5ClienteDireccion ;
      private String A4ClienteEmail ;
      private String A5ClienteDireccion ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXWebGrid Gridcliente_telefonoContainer ;
      private GXWebRow Gridcliente_telefonoRow ;
      private GXWebColumn Gridcliente_telefonoColumn ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private int[] T00017_A1ClienteCi ;
      private String[] T00017_A2ClienteNombre ;
      private String[] T00017_A3ClienteApellido ;
      private String[] T00017_A4ClienteEmail ;
      private String[] T00017_A5ClienteDireccion ;
      private String[] T00017_A6ClienteObservacion ;
      private String[] T00017_A8DepartamentoDescripcion ;
      private DateTime[] T00017_A14ClienteFechaIngreso ;
      private short[] T00017_A16ClienteUltimoTelefonoId ;
      private short[] T00017_A18ClienteEdad ;
      private short[] T00017_A7DepartamentoCodigo ;
      private String[] T00016_A8DepartamentoDescripcion ;
      private String[] T00018_A8DepartamentoDescripcion ;
      private int[] T00019_A1ClienteCi ;
      private int[] T00015_A1ClienteCi ;
      private String[] T00015_A2ClienteNombre ;
      private String[] T00015_A3ClienteApellido ;
      private String[] T00015_A4ClienteEmail ;
      private String[] T00015_A5ClienteDireccion ;
      private String[] T00015_A6ClienteObservacion ;
      private DateTime[] T00015_A14ClienteFechaIngreso ;
      private short[] T00015_A16ClienteUltimoTelefonoId ;
      private short[] T00015_A18ClienteEdad ;
      private short[] T00015_A7DepartamentoCodigo ;
      private int[] T000110_A1ClienteCi ;
      private int[] T000111_A1ClienteCi ;
      private int[] T00014_A1ClienteCi ;
      private String[] T00014_A2ClienteNombre ;
      private String[] T00014_A3ClienteApellido ;
      private String[] T00014_A4ClienteEmail ;
      private String[] T00014_A5ClienteDireccion ;
      private String[] T00014_A6ClienteObservacion ;
      private DateTime[] T00014_A14ClienteFechaIngreso ;
      private short[] T00014_A16ClienteUltimoTelefonoId ;
      private short[] T00014_A18ClienteEdad ;
      private short[] T00014_A7DepartamentoCodigo ;
      private String[] T000115_A8DepartamentoDescripcion ;
      private int[] T000117_A1ClienteCi ;
      private int[] T000118_A1ClienteCi ;
      private short[] T000118_A17ClienteTelefonoId ;
      private String[] T000118_A13ClienteTelefonoNumero ;
      private String[] T000118_A15ClienteTelefonoDescripcion ;
      private int[] T000119_A1ClienteCi ;
      private short[] T000119_A17ClienteTelefonoId ;
      private int[] T00013_A1ClienteCi ;
      private short[] T00013_A17ClienteTelefonoId ;
      private String[] T00013_A13ClienteTelefonoNumero ;
      private String[] T00013_A15ClienteTelefonoDescripcion ;
      private int[] T00012_A1ClienteCi ;
      private short[] T00012_A17ClienteTelefonoId ;
      private String[] T00012_A13ClienteTelefonoNumero ;
      private String[] T00012_A15ClienteTelefonoDescripcion ;
      private int[] T000123_A1ClienteCi ;
      private short[] T000123_A17ClienteTelefonoId ;
      private GXWebForm Form ;
   }

   public class cliente__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new UpdateCursor(def[10])
         ,new UpdateCursor(def[11])
         ,new UpdateCursor(def[12])
         ,new ForEachCursor(def[13])
         ,new UpdateCursor(def[14])
         ,new ForEachCursor(def[15])
         ,new ForEachCursor(def[16])
         ,new ForEachCursor(def[17])
         ,new UpdateCursor(def[18])
         ,new UpdateCursor(def[19])
         ,new UpdateCursor(def[20])
         ,new ForEachCursor(def[21])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT00017 ;
          prmT00017 = new Object[] {
          new Object[] {"@ClienteCi",SqlDbType.Int,8,0}
          } ;
          Object[] prmT00016 ;
          prmT00016 = new Object[] {
          new Object[] {"@DepartamentoCodigo",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00018 ;
          prmT00018 = new Object[] {
          new Object[] {"@DepartamentoCodigo",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00019 ;
          prmT00019 = new Object[] {
          new Object[] {"@ClienteCi",SqlDbType.Int,8,0}
          } ;
          Object[] prmT00015 ;
          prmT00015 = new Object[] {
          new Object[] {"@ClienteCi",SqlDbType.Int,8,0}
          } ;
          Object[] prmT000110 ;
          prmT000110 = new Object[] {
          new Object[] {"@ClienteCi",SqlDbType.Int,8,0}
          } ;
          Object[] prmT000111 ;
          prmT000111 = new Object[] {
          new Object[] {"@ClienteCi",SqlDbType.Int,8,0}
          } ;
          Object[] prmT00014 ;
          prmT00014 = new Object[] {
          new Object[] {"@ClienteCi",SqlDbType.Int,8,0}
          } ;
          Object[] prmT000112 ;
          prmT000112 = new Object[] {
          new Object[] {"@ClienteCi",SqlDbType.Int,8,0} ,
          new Object[] {"@ClienteNombre",SqlDbType.Char,20,0} ,
          new Object[] {"@ClienteApellido",SqlDbType.Char,20,0} ,
          new Object[] {"@ClienteEmail",SqlDbType.VarChar,100,0} ,
          new Object[] {"@ClienteDireccion",SqlDbType.VarChar,1024,0} ,
          new Object[] {"@ClienteObservacion",SqlDbType.Char,100,0} ,
          new Object[] {"@ClienteFechaIngreso",SqlDbType.DateTime,8,0} ,
          new Object[] {"@ClienteUltimoTelefonoId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ClienteEdad",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@DepartamentoCodigo",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000113 ;
          prmT000113 = new Object[] {
          new Object[] {"@ClienteNombre",SqlDbType.Char,20,0} ,
          new Object[] {"@ClienteApellido",SqlDbType.Char,20,0} ,
          new Object[] {"@ClienteEmail",SqlDbType.VarChar,100,0} ,
          new Object[] {"@ClienteDireccion",SqlDbType.VarChar,1024,0} ,
          new Object[] {"@ClienteObservacion",SqlDbType.Char,100,0} ,
          new Object[] {"@ClienteFechaIngreso",SqlDbType.DateTime,8,0} ,
          new Object[] {"@ClienteUltimoTelefonoId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ClienteEdad",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@DepartamentoCodigo",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ClienteCi",SqlDbType.Int,8,0}
          } ;
          Object[] prmT000114 ;
          prmT000114 = new Object[] {
          new Object[] {"@ClienteCi",SqlDbType.Int,8,0}
          } ;
          Object[] prmT000116 ;
          prmT000116 = new Object[] {
          new Object[] {"@ClienteUltimoTelefonoId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ClienteCi",SqlDbType.Int,8,0}
          } ;
          Object[] prmT000117 ;
          prmT000117 = new Object[] {
          } ;
          Object[] prmT000118 ;
          prmT000118 = new Object[] {
          new Object[] {"@ClienteCi",SqlDbType.Int,8,0} ,
          new Object[] {"@ClienteTelefonoId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000119 ;
          prmT000119 = new Object[] {
          new Object[] {"@ClienteCi",SqlDbType.Int,8,0} ,
          new Object[] {"@ClienteTelefonoId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00013 ;
          prmT00013 = new Object[] {
          new Object[] {"@ClienteCi",SqlDbType.Int,8,0} ,
          new Object[] {"@ClienteTelefonoId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00012 ;
          prmT00012 = new Object[] {
          new Object[] {"@ClienteCi",SqlDbType.Int,8,0} ,
          new Object[] {"@ClienteTelefonoId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000120 ;
          prmT000120 = new Object[] {
          new Object[] {"@ClienteCi",SqlDbType.Int,8,0} ,
          new Object[] {"@ClienteTelefonoId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ClienteTelefonoNumero",SqlDbType.Char,20,0} ,
          new Object[] {"@ClienteTelefonoDescripcion",SqlDbType.Char,100,0}
          } ;
          Object[] prmT000121 ;
          prmT000121 = new Object[] {
          new Object[] {"@ClienteTelefonoNumero",SqlDbType.Char,20,0} ,
          new Object[] {"@ClienteTelefonoDescripcion",SqlDbType.Char,100,0} ,
          new Object[] {"@ClienteCi",SqlDbType.Int,8,0} ,
          new Object[] {"@ClienteTelefonoId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000122 ;
          prmT000122 = new Object[] {
          new Object[] {"@ClienteCi",SqlDbType.Int,8,0} ,
          new Object[] {"@ClienteTelefonoId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000123 ;
          prmT000123 = new Object[] {
          new Object[] {"@ClienteCi",SqlDbType.Int,8,0}
          } ;
          Object[] prmT000115 ;
          prmT000115 = new Object[] {
          new Object[] {"@DepartamentoCodigo",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T00012", "SELECT [ClienteCi], [ClienteTelefonoId], [ClienteTelefonoNumero], [ClienteTelefonoDescripcion] FROM [ClienteTelefono] WITH (UPDLOCK) WHERE [ClienteCi] = @ClienteCi AND [ClienteTelefonoId] = @ClienteTelefonoId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00012,1,0,true,false )
             ,new CursorDef("T00013", "SELECT [ClienteCi], [ClienteTelefonoId], [ClienteTelefonoNumero], [ClienteTelefonoDescripcion] FROM [ClienteTelefono] WITH (NOLOCK) WHERE [ClienteCi] = @ClienteCi AND [ClienteTelefonoId] = @ClienteTelefonoId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00013,1,0,true,false )
             ,new CursorDef("T00014", "SELECT [ClienteCi], [ClienteNombre], [ClienteApellido], [ClienteEmail], [ClienteDireccion], [ClienteObservacion], [ClienteFechaIngreso], [ClienteUltimoTelefonoId], [ClienteEdad], [DepartamentoCodigo] FROM [Cliente] WITH (UPDLOCK) WHERE [ClienteCi] = @ClienteCi ",true, GxErrorMask.GX_NOMASK, false, this,prmT00014,1,0,true,false )
             ,new CursorDef("T00015", "SELECT [ClienteCi], [ClienteNombre], [ClienteApellido], [ClienteEmail], [ClienteDireccion], [ClienteObservacion], [ClienteFechaIngreso], [ClienteUltimoTelefonoId], [ClienteEdad], [DepartamentoCodigo] FROM [Cliente] WITH (NOLOCK) WHERE [ClienteCi] = @ClienteCi ",true, GxErrorMask.GX_NOMASK, false, this,prmT00015,1,0,true,false )
             ,new CursorDef("T00016", "SELECT [DepartamentoDescripcion] FROM [Departamento] WITH (NOLOCK) WHERE [DepartamentoCodigo] = @DepartamentoCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00016,1,0,true,false )
             ,new CursorDef("T00017", "SELECT TM1.[ClienteCi], TM1.[ClienteNombre], TM1.[ClienteApellido], TM1.[ClienteEmail], TM1.[ClienteDireccion], TM1.[ClienteObservacion], T2.[DepartamentoDescripcion], TM1.[ClienteFechaIngreso], TM1.[ClienteUltimoTelefonoId], TM1.[ClienteEdad], TM1.[DepartamentoCodigo] FROM ([Cliente] TM1 WITH (NOLOCK) INNER JOIN [Departamento] T2 WITH (NOLOCK) ON T2.[DepartamentoCodigo] = TM1.[DepartamentoCodigo]) WHERE TM1.[ClienteCi] = @ClienteCi ORDER BY TM1.[ClienteCi]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00017,100,0,true,false )
             ,new CursorDef("T00018", "SELECT [DepartamentoDescripcion] FROM [Departamento] WITH (NOLOCK) WHERE [DepartamentoCodigo] = @DepartamentoCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00018,1,0,true,false )
             ,new CursorDef("T00019", "SELECT [ClienteCi] FROM [Cliente] WITH (NOLOCK) WHERE [ClienteCi] = @ClienteCi  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00019,1,0,true,false )
             ,new CursorDef("T000110", "SELECT TOP 1 [ClienteCi] FROM [Cliente] WITH (NOLOCK) WHERE ( [ClienteCi] > @ClienteCi) ORDER BY [ClienteCi]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000110,1,0,true,true )
             ,new CursorDef("T000111", "SELECT TOP 1 [ClienteCi] FROM [Cliente] WITH (NOLOCK) WHERE ( [ClienteCi] < @ClienteCi) ORDER BY [ClienteCi] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000111,1,0,true,true )
             ,new CursorDef("T000112", "INSERT INTO [Cliente]([ClienteCi], [ClienteNombre], [ClienteApellido], [ClienteEmail], [ClienteDireccion], [ClienteObservacion], [ClienteFechaIngreso], [ClienteUltimoTelefonoId], [ClienteEdad], [DepartamentoCodigo]) VALUES(@ClienteCi, @ClienteNombre, @ClienteApellido, @ClienteEmail, @ClienteDireccion, @ClienteObservacion, @ClienteFechaIngreso, @ClienteUltimoTelefonoId, @ClienteEdad, @DepartamentoCodigo)", GxErrorMask.GX_NOMASK,prmT000112)
             ,new CursorDef("T000113", "UPDATE [Cliente] SET [ClienteNombre]=@ClienteNombre, [ClienteApellido]=@ClienteApellido, [ClienteEmail]=@ClienteEmail, [ClienteDireccion]=@ClienteDireccion, [ClienteObservacion]=@ClienteObservacion, [ClienteFechaIngreso]=@ClienteFechaIngreso, [ClienteUltimoTelefonoId]=@ClienteUltimoTelefonoId, [ClienteEdad]=@ClienteEdad, [DepartamentoCodigo]=@DepartamentoCodigo  WHERE [ClienteCi] = @ClienteCi", GxErrorMask.GX_NOMASK,prmT000113)
             ,new CursorDef("T000114", "DELETE FROM [Cliente]  WHERE [ClienteCi] = @ClienteCi", GxErrorMask.GX_NOMASK,prmT000114)
             ,new CursorDef("T000115", "SELECT [DepartamentoDescripcion] FROM [Departamento] WITH (NOLOCK) WHERE [DepartamentoCodigo] = @DepartamentoCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000115,1,0,true,false )
             ,new CursorDef("T000116", "UPDATE [Cliente] SET [ClienteUltimoTelefonoId]=@ClienteUltimoTelefonoId  WHERE [ClienteCi] = @ClienteCi", GxErrorMask.GX_NOMASK,prmT000116)
             ,new CursorDef("T000117", "SELECT [ClienteCi] FROM [Cliente] WITH (NOLOCK) ORDER BY [ClienteCi]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000117,100,0,true,false )
             ,new CursorDef("T000118", "SELECT [ClienteCi], [ClienteTelefonoId], [ClienteTelefonoNumero], [ClienteTelefonoDescripcion] FROM [ClienteTelefono] WITH (NOLOCK) WHERE [ClienteCi] = @ClienteCi and [ClienteTelefonoId] = @ClienteTelefonoId ORDER BY [ClienteCi], [ClienteTelefonoId] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000118,11,0,true,false )
             ,new CursorDef("T000119", "SELECT [ClienteCi], [ClienteTelefonoId] FROM [ClienteTelefono] WITH (NOLOCK) WHERE [ClienteCi] = @ClienteCi AND [ClienteTelefonoId] = @ClienteTelefonoId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000119,1,0,true,false )
             ,new CursorDef("T000120", "INSERT INTO [ClienteTelefono]([ClienteCi], [ClienteTelefonoId], [ClienteTelefonoNumero], [ClienteTelefonoDescripcion]) VALUES(@ClienteCi, @ClienteTelefonoId, @ClienteTelefonoNumero, @ClienteTelefonoDescripcion)", GxErrorMask.GX_NOMASK,prmT000120)
             ,new CursorDef("T000121", "UPDATE [ClienteTelefono] SET [ClienteTelefonoNumero]=@ClienteTelefonoNumero, [ClienteTelefonoDescripcion]=@ClienteTelefonoDescripcion  WHERE [ClienteCi] = @ClienteCi AND [ClienteTelefonoId] = @ClienteTelefonoId", GxErrorMask.GX_NOMASK,prmT000121)
             ,new CursorDef("T000122", "DELETE FROM [ClienteTelefono]  WHERE [ClienteCi] = @ClienteCi AND [ClienteTelefonoId] = @ClienteTelefonoId", GxErrorMask.GX_NOMASK,prmT000122)
             ,new CursorDef("T000123", "SELECT [ClienteCi], [ClienteTelefonoId] FROM [ClienteTelefono] WITH (NOLOCK) WHERE [ClienteCi] = @ClienteCi ORDER BY [ClienteCi], [ClienteTelefonoId] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000123,11,0,true,false )
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
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 20) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 100) ;
                return;
             case 1 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 20) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 100) ;
                return;
             case 2 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 20) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 20) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getString(6, 100) ;
                ((DateTime[]) buf[6])[0] = rslt.getGXDate(7) ;
                ((short[]) buf[7])[0] = rslt.getShort(8) ;
                ((short[]) buf[8])[0] = rslt.getShort(9) ;
                ((short[]) buf[9])[0] = rslt.getShort(10) ;
                return;
             case 3 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 20) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 20) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getString(6, 100) ;
                ((DateTime[]) buf[6])[0] = rslt.getGXDate(7) ;
                ((short[]) buf[7])[0] = rslt.getShort(8) ;
                ((short[]) buf[8])[0] = rslt.getShort(9) ;
                ((short[]) buf[9])[0] = rslt.getShort(10) ;
                return;
             case 4 :
                ((String[]) buf[0])[0] = rslt.getString(1, 100) ;
                return;
             case 5 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 20) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 20) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getString(6, 100) ;
                ((String[]) buf[6])[0] = rslt.getString(7, 100) ;
                ((DateTime[]) buf[7])[0] = rslt.getGXDate(8) ;
                ((short[]) buf[8])[0] = rslt.getShort(9) ;
                ((short[]) buf[9])[0] = rslt.getShort(10) ;
                ((short[]) buf[10])[0] = rslt.getShort(11) ;
                return;
             case 6 :
                ((String[]) buf[0])[0] = rslt.getString(1, 100) ;
                return;
             case 7 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                return;
             case 8 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                return;
             case 9 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                return;
             case 13 :
                ((String[]) buf[0])[0] = rslt.getString(1, 100) ;
                return;
             case 15 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                return;
             case 16 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 20) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 100) ;
                return;
             case 17 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                return;
             case 21 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
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
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 1 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 2 :
                stmt.SetParameter(1, (int)parms[0]);
                return;
             case 3 :
                stmt.SetParameter(1, (int)parms[0]);
                return;
             case 4 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 5 :
                stmt.SetParameter(1, (int)parms[0]);
                return;
             case 6 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 7 :
                stmt.SetParameter(1, (int)parms[0]);
                return;
             case 8 :
                stmt.SetParameter(1, (int)parms[0]);
                return;
             case 9 :
                stmt.SetParameter(1, (int)parms[0]);
                return;
             case 10 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                stmt.SetParameter(7, (DateTime)parms[6]);
                stmt.SetParameter(8, (short)parms[7]);
                stmt.SetParameter(9, (short)parms[8]);
                stmt.SetParameter(10, (short)parms[9]);
                return;
             case 11 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (DateTime)parms[5]);
                stmt.SetParameter(7, (short)parms[6]);
                stmt.SetParameter(8, (short)parms[7]);
                stmt.SetParameter(9, (short)parms[8]);
                stmt.SetParameter(10, (int)parms[9]);
                return;
             case 12 :
                stmt.SetParameter(1, (int)parms[0]);
                return;
             case 13 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 14 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                return;
             case 16 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 17 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 18 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                return;
             case 19 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                return;
             case 20 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 21 :
                stmt.SetParameter(1, (int)parms[0]);
                return;
       }
    }

 }

}
