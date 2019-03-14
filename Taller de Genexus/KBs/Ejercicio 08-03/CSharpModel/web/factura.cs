/*
               File: Factura
        Description: Factura
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 3/11/2019 19:40:55.28
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
   public class factura : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_5") == 0 )
         {
            A6FacturaNumero = (short)(NumberUtil.Val( GetNextPar( ), "."));
            n6FacturaNumero = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6FacturaNumero", StringUtil.LTrim( StringUtil.Str( (decimal)(A6FacturaNumero), 4, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_5( A6FacturaNumero) ;
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Gridfactura_articulo") == 0 )
         {
            nRC_GXsfl_58 = (short)(NumberUtil.Val( GetNextPar( ), "."));
            nGXsfl_58_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
            sGXsfl_58_idx = GetNextPar( );
            Gx_mode = GetNextPar( );
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxnrGridfactura_articulo_newrow( ) ;
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
            Form.Meta.addItem("description", "Factura", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtFacturaNumero_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("Carmine");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public factura( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public factura( IGxContext context )
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
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "Factura", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_Factura.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "", bttBtn_first_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_first_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Factura.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "", bttBtn_previous_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_previous_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_Factura.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", "", bttBtn_next_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_next_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_Factura.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", "", bttBtn_last_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_last_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Factura.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Select", bttBtn_select_Jsonclick, 4, "Select", "", StyleString, ClassString, bttBtn_select_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "gx.popup.openPrompt('"+"gx0010.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLIENTEID"+"'), id:'"+"CLIENTEID"+"'"+",IOType:'out',isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", 2, "HLP_Factura.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtFacturaNumero_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtFacturaNumero_Internalname, "Numero", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtFacturaNumero_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A6FacturaNumero), 4, 0, ".", "")), ((edtFacturaNumero_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A6FacturaNumero), "ZZZ9")) : context.localUtil.Format( (decimal)(A6FacturaNumero), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,34);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtFacturaNumero_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtFacturaNumero_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Factura.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtFacturaFecha_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtFacturaFecha_Internalname, "Fecha", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            context.WriteHtmlText( "<div id=\""+edtFacturaFecha_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtFacturaFecha_Internalname, context.localUtil.Format(A7FacturaFecha, "99/99/99"), context.localUtil.Format( A7FacturaFecha, "99/99/99"), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtFacturaFecha_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtFacturaFecha_Enabled, 0, "text", "", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Factura.htm");
            GxWebStd.gx_bitmap( context, edtFacturaFecha_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtFacturaFecha_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_Factura.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtClienteId_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtClienteId_Internalname, "Id", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtClienteId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A1ClienteId), 4, 0, ".", "")), ((edtClienteId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A1ClienteId), "ZZZ9")) : context.localUtil.Format( (decimal)(A1ClienteId), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,44);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtClienteId_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtClienteId_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "AutoNumero", "right", false, "HLP_Factura.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtFacturaTotal_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtFacturaTotal_Internalname, "Total", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtFacturaTotal_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A8FacturaTotal), 4, 0, ".", "")), ((edtFacturaTotal_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A8FacturaTotal), "ZZZ9")) : context.localUtil.Format( (decimal)(A8FacturaTotal), "ZZZ9")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtFacturaTotal_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtFacturaTotal_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Factura.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 LevelTable", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divArticulotable_Internalname, 1, 0, "px", 0, "px", "LevelTable", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTitlearticulo_Internalname, "Articulo", "", "", lblTitlearticulo_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_Factura.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            gxdraw_Gridfactura_articulo( ) ;
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 67,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirm", bttBtn_enter_Jsonclick, 5, "Confirm", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_Factura.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 69,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancel", bttBtn_cancel_Jsonclick, 1, "Cancel", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Factura.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 71,'',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Delete", bttBtn_delete_Jsonclick, 5, "Delete", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_Factura.htm");
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

      protected void gxdraw_Gridfactura_articulo( )
      {
         /*  Grid Control  */
         Gridfactura_articuloContainer.AddObjectProperty("GridName", "Gridfactura_articulo");
         Gridfactura_articuloContainer.AddObjectProperty("Header", subGridfactura_articulo_Header);
         Gridfactura_articuloContainer.AddObjectProperty("Class", "Grid");
         Gridfactura_articuloContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         Gridfactura_articuloContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
         Gridfactura_articuloContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridfactura_articulo_Backcolorstyle), 1, 0, ".", "")));
         Gridfactura_articuloContainer.AddObjectProperty("CmpContext", "");
         Gridfactura_articuloContainer.AddObjectProperty("InMasterPage", "false");
         Gridfactura_articuloColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridfactura_articuloColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A9ArticuloCodigo), 4, 0, ".", "")));
         Gridfactura_articuloColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtArticuloCodigo_Enabled), 5, 0, ".", "")));
         Gridfactura_articuloContainer.AddColumnProperties(Gridfactura_articuloColumn);
         Gridfactura_articuloColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridfactura_articuloColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A10ArticuloCantidad), 4, 0, ".", "")));
         Gridfactura_articuloColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtArticuloCantidad_Enabled), 5, 0, ".", "")));
         Gridfactura_articuloContainer.AddColumnProperties(Gridfactura_articuloColumn);
         Gridfactura_articuloColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridfactura_articuloColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A11ArticuloPrecio), 4, 0, ".", "")));
         Gridfactura_articuloColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtArticuloPrecio_Enabled), 5, 0, ".", "")));
         Gridfactura_articuloContainer.AddColumnProperties(Gridfactura_articuloColumn);
         Gridfactura_articuloColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridfactura_articuloColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A12ArticuloTotal), 4, 0, ".", "")));
         Gridfactura_articuloColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtArticuloTotal_Enabled), 5, 0, ".", "")));
         Gridfactura_articuloContainer.AddColumnProperties(Gridfactura_articuloColumn);
         Gridfactura_articuloContainer.AddObjectProperty("Selectedindex", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridfactura_articulo_Selectedindex), 4, 0, ".", "")));
         Gridfactura_articuloContainer.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridfactura_articulo_Allowselection), 1, 0, ".", "")));
         Gridfactura_articuloContainer.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridfactura_articulo_Selectioncolor), 9, 0, ".", "")));
         Gridfactura_articuloContainer.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridfactura_articulo_Allowhovering), 1, 0, ".", "")));
         Gridfactura_articuloContainer.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridfactura_articulo_Hoveringcolor), 9, 0, ".", "")));
         Gridfactura_articuloContainer.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridfactura_articulo_Allowcollapsing), 1, 0, ".", "")));
         Gridfactura_articuloContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridfactura_articulo_Collapsed), 1, 0, ".", "")));
         nGXsfl_58_idx = 0;
         if ( ( nKeyPressed == 1 ) && ( AnyError == 0 ) )
         {
            /* Enter key processing. */
            nBlankRcdCount3 = 5;
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               /* Display confirmed (stored) records */
               nRcdExists_3 = 1;
               ScanStart023( ) ;
               while ( RcdFound3 != 0 )
               {
                  init_level_properties3( ) ;
                  getByPrimaryKey023( ) ;
                  AddRow023( ) ;
                  ScanNext023( ) ;
               }
               ScanEnd023( ) ;
               nBlankRcdCount3 = 5;
            }
         }
         else if ( ( nKeyPressed == 3 ) || ( nKeyPressed == 4 ) || ( ( nKeyPressed == 1 ) && ( AnyError != 0 ) ) )
         {
            /* Button check  or addlines. */
            standaloneNotModal023( ) ;
            standaloneModal023( ) ;
            sMode3 = Gx_mode;
            while ( nGXsfl_58_idx < nRC_GXsfl_58 )
            {
               bGXsfl_58_Refreshing = true;
               ReadRow023( ) ;
               edtArticuloCodigo_Enabled = (int)(context.localUtil.CToN( cgiGet( "ARTICULOCODIGO_"+sGXsfl_58_idx+"Enabled"), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtArticuloCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtArticuloCodigo_Enabled), 5, 0)), !bGXsfl_58_Refreshing);
               edtArticuloCantidad_Enabled = (int)(context.localUtil.CToN( cgiGet( "ARTICULOCANTIDAD_"+sGXsfl_58_idx+"Enabled"), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtArticuloCantidad_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtArticuloCantidad_Enabled), 5, 0)), !bGXsfl_58_Refreshing);
               edtArticuloPrecio_Enabled = (int)(context.localUtil.CToN( cgiGet( "ARTICULOPRECIO_"+sGXsfl_58_idx+"Enabled"), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtArticuloPrecio_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtArticuloPrecio_Enabled), 5, 0)), !bGXsfl_58_Refreshing);
               edtArticuloTotal_Enabled = (int)(context.localUtil.CToN( cgiGet( "ARTICULOTOTAL_"+sGXsfl_58_idx+"Enabled"), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtArticuloTotal_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtArticuloTotal_Enabled), 5, 0)), !bGXsfl_58_Refreshing);
               if ( ( nRcdExists_3 == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") != 0 ) )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  standaloneModal023( ) ;
               }
               SendRow023( ) ;
               bGXsfl_58_Refreshing = false;
            }
            Gx_mode = sMode3;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            /* Get or get-alike key processing. */
            nBlankRcdCount3 = 5;
            nRcdExists_3 = 1;
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               ScanStart023( ) ;
               while ( RcdFound3 != 0 )
               {
                  sGXsfl_58_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_58_idx+1), 4, 0)), 4, "0");
                  SubsflControlProps_583( ) ;
                  init_level_properties3( ) ;
                  standaloneNotModal023( ) ;
                  getByPrimaryKey023( ) ;
                  standaloneModal023( ) ;
                  AddRow023( ) ;
                  ScanNext023( ) ;
               }
               ScanEnd023( ) ;
            }
         }
         /* Initialize fields for 'new' records and send them. */
         sMode3 = Gx_mode;
         Gx_mode = "INS";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         sGXsfl_58_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_58_idx+1), 4, 0)), 4, "0");
         SubsflControlProps_583( ) ;
         InitAll023( ) ;
         init_level_properties3( ) ;
         standaloneNotModal023( ) ;
         standaloneModal023( ) ;
         nRcdExists_3 = 0;
         nIsMod_3 = 0;
         nRcdDeleted_3 = 0;
         nBlankRcdCount3 = (short)(nBlankRcdUsr3+nBlankRcdCount3);
         fRowAdded = 0;
         while ( nBlankRcdCount3 > 0 )
         {
            AddRow023( ) ;
            if ( ( nKeyPressed == 4 ) && ( fRowAdded == 0 ) )
            {
               fRowAdded = 1;
               GX_FocusControl = edtArticuloCodigo_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            nBlankRcdCount3 = (short)(nBlankRcdCount3-1);
         }
         Gx_mode = sMode3;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         sStyleString = "";
         context.WriteHtmlText( "<div id=\""+"Gridfactura_articuloContainer"+"Div\" "+sStyleString+">"+"</div>") ;
         context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Gridfactura_articulo", Gridfactura_articuloContainer);
         if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
         {
            GxWebStd.gx_hidden_field( context, "Gridfactura_articuloContainerData", Gridfactura_articuloContainer.ToJavascriptSource());
         }
         if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
         {
            GxWebStd.gx_hidden_field( context, "Gridfactura_articuloContainerData"+"V", Gridfactura_articuloContainer.GridValuesHidden());
         }
         else
         {
            context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Gridfactura_articuloContainerData"+"V"+"\" value='"+Gridfactura_articuloContainer.GridValuesHidden()+"'/>") ;
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
               if ( ( ( context.localUtil.CToN( cgiGet( edtFacturaNumero_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtFacturaNumero_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "FACTURANUMERO");
                  AnyError = 1;
                  GX_FocusControl = edtFacturaNumero_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A6FacturaNumero = 0;
                  n6FacturaNumero = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6FacturaNumero", StringUtil.LTrim( StringUtil.Str( (decimal)(A6FacturaNumero), 4, 0)));
               }
               else
               {
                  A6FacturaNumero = (short)(context.localUtil.CToN( cgiGet( edtFacturaNumero_Internalname), ".", ","));
                  n6FacturaNumero = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6FacturaNumero", StringUtil.LTrim( StringUtil.Str( (decimal)(A6FacturaNumero), 4, 0)));
               }
               A7FacturaFecha = context.localUtil.CToD( cgiGet( edtFacturaFecha_Internalname), 1);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7FacturaFecha", context.localUtil.Format(A7FacturaFecha, "99/99/99"));
               if ( ( ( context.localUtil.CToN( cgiGet( edtClienteId_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtClienteId_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "CLIENTEID");
                  AnyError = 1;
                  GX_FocusControl = edtClienteId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A1ClienteId = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1ClienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1ClienteId), 4, 0)));
               }
               else
               {
                  A1ClienteId = (short)(context.localUtil.CToN( cgiGet( edtClienteId_Internalname), ".", ","));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1ClienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1ClienteId), 4, 0)));
               }
               A8FacturaTotal = (short)(context.localUtil.CToN( cgiGet( edtFacturaTotal_Internalname), ".", ","));
               n8FacturaTotal = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8FacturaTotal", StringUtil.LTrim( StringUtil.Str( (decimal)(A8FacturaTotal), 4, 0)));
               /* Read saved values. */
               Z1ClienteId = (short)(context.localUtil.CToN( cgiGet( "Z1ClienteId"), ".", ","));
               Z6FacturaNumero = (short)(context.localUtil.CToN( cgiGet( "Z6FacturaNumero"), ".", ","));
               Z7FacturaFecha = context.localUtil.CToD( cgiGet( "Z7FacturaFecha"), 0);
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ","));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ".", ","));
               Gx_mode = cgiGet( "Mode");
               nRC_GXsfl_58 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_58"), ".", ","));
               Gx_date = context.localUtil.CToD( cgiGet( "vTODAY"), 0);
               Gx_BScreen = (short)(context.localUtil.CToN( cgiGet( "vGXBSCREEN"), ".", ","));
               Gx_mode = cgiGet( "vMODE");
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               forbiddenHiddens = "hsh" + "Factura";
               A7FacturaFecha = context.localUtil.CToD( cgiGet( edtFacturaFecha_Internalname), 1);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7FacturaFecha", context.localUtil.Format(A7FacturaFecha, "99/99/99"));
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format(A7FacturaFecha, "99/99/99");
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( A1ClienteId != Z1ClienteId ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
               {
                  GXUtil.WriteLog("factura:[SecurityCheckFailed value for]"+"FacturaFecha:"+context.localUtil.Format(A7FacturaFecha, "99/99/99"));
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
                  A1ClienteId = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1ClienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1ClienteId), 4, 0)));
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
               InitAll021( ) ;
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
         DisableAttributes021( ) ;
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

      protected void CONFIRM_023( )
      {
         nGXsfl_58_idx = 0;
         while ( nGXsfl_58_idx < nRC_GXsfl_58 )
         {
            ReadRow023( ) ;
            if ( ( nRcdExists_3 != 0 ) || ( nIsMod_3 != 0 ) )
            {
               GetKey023( ) ;
               if ( ( nRcdExists_3 == 0 ) && ( nRcdDeleted_3 == 0 ) )
               {
                  if ( RcdFound3 == 0 )
                  {
                     Gx_mode = "INS";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     BeforeValidate023( ) ;
                     if ( AnyError == 0 )
                     {
                        CheckExtendedTable023( ) ;
                        CloseExtendedTableCursors023( ) ;
                        if ( AnyError == 0 )
                        {
                           IsConfirmed = 1;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
                        }
                     }
                  }
                  else
                  {
                     GXCCtl = "ARTICULOCODIGO_" + sGXsfl_58_idx;
                     GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, GXCCtl);
                     AnyError = 1;
                     GX_FocusControl = edtArticuloCodigo_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( RcdFound3 != 0 )
                  {
                     if ( nRcdDeleted_3 != 0 )
                     {
                        Gx_mode = "DLT";
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        getByPrimaryKey023( ) ;
                        Load023( ) ;
                        BeforeValidate023( ) ;
                        if ( AnyError == 0 )
                        {
                           OnDeleteControls023( ) ;
                        }
                     }
                     else
                     {
                        if ( nIsMod_3 != 0 )
                        {
                           Gx_mode = "UPD";
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           BeforeValidate023( ) ;
                           if ( AnyError == 0 )
                           {
                              CheckExtendedTable023( ) ;
                              CloseExtendedTableCursors023( ) ;
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
                     if ( nRcdDeleted_3 == 0 )
                     {
                        GXCCtl = "ARTICULOCODIGO_" + sGXsfl_58_idx;
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, GXCCtl);
                        AnyError = 1;
                        GX_FocusControl = edtArticuloCodigo_Internalname;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtArticuloCodigo_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A9ArticuloCodigo), 4, 0, ".", ""))) ;
            ChangePostValue( edtArticuloCantidad_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A10ArticuloCantidad), 4, 0, ".", ""))) ;
            ChangePostValue( edtArticuloPrecio_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A11ArticuloPrecio), 4, 0, ".", ""))) ;
            ChangePostValue( edtArticuloTotal_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A12ArticuloTotal), 4, 0, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z9ArticuloCodigo_"+sGXsfl_58_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z9ArticuloCodigo), 4, 0, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z10ArticuloCantidad_"+sGXsfl_58_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z10ArticuloCantidad), 4, 0, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z11ArticuloPrecio_"+sGXsfl_58_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z11ArticuloPrecio), 4, 0, ".", ""))) ;
            ChangePostValue( "nRcdDeleted_3_"+sGXsfl_58_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_3), 4, 0, ".", ""))) ;
            ChangePostValue( "nRcdExists_3_"+sGXsfl_58_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_3), 4, 0, ".", ""))) ;
            ChangePostValue( "nIsMod_3_"+sGXsfl_58_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_3), 4, 0, ".", ""))) ;
            if ( nIsMod_3 != 0 )
            {
               ChangePostValue( "ARTICULOCODIGO_"+sGXsfl_58_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtArticuloCodigo_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "ARTICULOCANTIDAD_"+sGXsfl_58_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtArticuloCantidad_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "ARTICULOPRECIO_"+sGXsfl_58_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtArticuloPrecio_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "ARTICULOTOTAL_"+sGXsfl_58_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtArticuloTotal_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
      }

      protected void ResetCaption020( )
      {
      }

      protected void ZM021( short GX_JID )
      {
         if ( ( GX_JID == 4 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z6FacturaNumero = T00025_A6FacturaNumero[0];
               Z7FacturaFecha = T00025_A7FacturaFecha[0];
            }
            else
            {
               Z6FacturaNumero = A6FacturaNumero;
               Z7FacturaFecha = A7FacturaFecha;
            }
         }
         if ( GX_JID == -4 )
         {
            Z1ClienteId = A1ClienteId;
            Z6FacturaNumero = A6FacturaNumero;
            Z7FacturaFecha = A7FacturaFecha;
            Z8FacturaTotal = A8FacturaTotal;
         }
      }

      protected void standaloneNotModal( )
      {
         edtFacturaFecha_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtFacturaFecha_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtFacturaFecha_Enabled), 5, 0)), true);
         Gx_BScreen = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
         Gx_date = DateTimeUtil.Today( context);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_date", context.localUtil.Format(Gx_date, "99/99/99"));
         edtFacturaFecha_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtFacturaFecha_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtFacturaFecha_Enabled), 5, 0)), true);
      }

      protected void standaloneModal( )
      {
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && (DateTime.MinValue==A7FacturaFecha) && ( Gx_BScreen == 0 ) )
         {
            A7FacturaFecha = Gx_date;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7FacturaFecha", context.localUtil.Format(A7FacturaFecha, "99/99/99"));
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

      protected void Load021( )
      {
         /* Using cursor T00029 */
         pr_default.execute(5, new Object[] {A1ClienteId});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound1 = 1;
            A6FacturaNumero = T00029_A6FacturaNumero[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6FacturaNumero", StringUtil.LTrim( StringUtil.Str( (decimal)(A6FacturaNumero), 4, 0)));
            n6FacturaNumero = T00029_n6FacturaNumero[0];
            A7FacturaFecha = T00029_A7FacturaFecha[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7FacturaFecha", context.localUtil.Format(A7FacturaFecha, "99/99/99"));
            A8FacturaTotal = T00029_A8FacturaTotal[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8FacturaTotal", StringUtil.LTrim( StringUtil.Str( (decimal)(A8FacturaTotal), 4, 0)));
            n8FacturaTotal = T00029_n8FacturaTotal[0];
            ZM021( -4) ;
         }
         pr_default.close(5);
         OnLoadActions021( ) ;
      }

      protected void OnLoadActions021( )
      {
      }

      protected void CheckExtendedTable021( )
      {
         Gx_BScreen = 1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
         standaloneModal( ) ;
         /* Using cursor T00027 */
         pr_default.execute(4, new Object[] {n6FacturaNumero, A6FacturaNumero});
         if ( (pr_default.getStatus(4) != 101) )
         {
            A8FacturaTotal = T00027_A8FacturaTotal[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8FacturaTotal", StringUtil.LTrim( StringUtil.Str( (decimal)(A8FacturaTotal), 4, 0)));
            n8FacturaTotal = T00027_n8FacturaTotal[0];
         }
         else
         {
            A8FacturaTotal = 0;
            n8FacturaTotal = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8FacturaTotal", StringUtil.LTrim( StringUtil.Str( (decimal)(A8FacturaTotal), 4, 0)));
         }
         pr_default.close(4);
      }

      protected void CloseExtendedTableCursors021( )
      {
         pr_default.close(4);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_5( short A6FacturaNumero )
      {
         /* Using cursor T000211 */
         pr_default.execute(6, new Object[] {n6FacturaNumero, A6FacturaNumero});
         if ( (pr_default.getStatus(6) != 101) )
         {
            A8FacturaTotal = T000211_A8FacturaTotal[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8FacturaTotal", StringUtil.LTrim( StringUtil.Str( (decimal)(A8FacturaTotal), 4, 0)));
            n8FacturaTotal = T000211_n8FacturaTotal[0];
         }
         else
         {
            A8FacturaTotal = 0;
            n8FacturaTotal = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8FacturaTotal", StringUtil.LTrim( StringUtil.Str( (decimal)(A8FacturaTotal), 4, 0)));
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A8FacturaTotal), 4, 0, ".", "")))+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(6) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(6);
      }

      protected void GetKey021( )
      {
         /* Using cursor T000212 */
         pr_default.execute(7, new Object[] {A1ClienteId});
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
         /* Using cursor T00025 */
         pr_default.execute(3, new Object[] {A1ClienteId});
         if ( (pr_default.getStatus(3) != 101) )
         {
            ZM021( 4) ;
            RcdFound1 = 1;
            A1ClienteId = T00025_A1ClienteId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1ClienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1ClienteId), 4, 0)));
            A6FacturaNumero = T00025_A6FacturaNumero[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6FacturaNumero", StringUtil.LTrim( StringUtil.Str( (decimal)(A6FacturaNumero), 4, 0)));
            n6FacturaNumero = T00025_n6FacturaNumero[0];
            A7FacturaFecha = T00025_A7FacturaFecha[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7FacturaFecha", context.localUtil.Format(A7FacturaFecha, "99/99/99"));
            Z1ClienteId = A1ClienteId;
            sMode1 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load021( ) ;
            if ( AnyError == 1 )
            {
               RcdFound1 = 0;
               InitializeNonKey021( ) ;
            }
            Gx_mode = sMode1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound1 = 0;
            InitializeNonKey021( ) ;
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
         GetKey021( ) ;
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
         /* Using cursor T000213 */
         pr_default.execute(8, new Object[] {A1ClienteId});
         if ( (pr_default.getStatus(8) != 101) )
         {
            while ( (pr_default.getStatus(8) != 101) && ( ( T000213_A1ClienteId[0] < A1ClienteId ) ) )
            {
               pr_default.readNext(8);
            }
            if ( (pr_default.getStatus(8) != 101) && ( ( T000213_A1ClienteId[0] > A1ClienteId ) ) )
            {
               A1ClienteId = T000213_A1ClienteId[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1ClienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1ClienteId), 4, 0)));
               RcdFound1 = 1;
            }
         }
         pr_default.close(8);
      }

      protected void move_previous( )
      {
         RcdFound1 = 0;
         /* Using cursor T000214 */
         pr_default.execute(9, new Object[] {A1ClienteId});
         if ( (pr_default.getStatus(9) != 101) )
         {
            while ( (pr_default.getStatus(9) != 101) && ( ( T000214_A1ClienteId[0] > A1ClienteId ) ) )
            {
               pr_default.readNext(9);
            }
            if ( (pr_default.getStatus(9) != 101) && ( ( T000214_A1ClienteId[0] < A1ClienteId ) ) )
            {
               A1ClienteId = T000214_A1ClienteId[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1ClienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1ClienteId), 4, 0)));
               RcdFound1 = 1;
            }
         }
         pr_default.close(9);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey021( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtFacturaNumero_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert021( ) ;
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
               if ( A1ClienteId != Z1ClienteId )
               {
                  A1ClienteId = Z1ClienteId;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1ClienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1ClienteId), 4, 0)));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "CLIENTEID");
                  AnyError = 1;
                  GX_FocusControl = edtClienteId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtFacturaNumero_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  Gx_mode = "UPD";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Update record */
                  Update021( ) ;
                  GX_FocusControl = edtFacturaNumero_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A1ClienteId != Z1ClienteId )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Insert record */
                  GX_FocusControl = edtFacturaNumero_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert021( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "CLIENTEID");
                     AnyError = 1;
                     GX_FocusControl = edtClienteId_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     Gx_mode = "INS";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     /* Insert record */
                     GX_FocusControl = edtFacturaNumero_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert021( ) ;
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
         if ( A1ClienteId != Z1ClienteId )
         {
            A1ClienteId = Z1ClienteId;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1ClienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1ClienteId), 4, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "CLIENTEID");
            AnyError = 1;
            GX_FocusControl = edtClienteId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtFacturaNumero_Internalname;
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
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "CLIENTEID");
            AnyError = 1;
            GX_FocusControl = edtClienteId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         GX_FocusControl = edtFacturaNumero_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         ScanStart021( ) ;
         if ( RcdFound1 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtFacturaNumero_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd021( ) ;
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
         GX_FocusControl = edtFacturaNumero_Internalname;
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
         GX_FocusControl = edtFacturaNumero_Internalname;
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
         ScanStart021( ) ;
         if ( RcdFound1 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            while ( RcdFound1 != 0 )
            {
               ScanNext021( ) ;
            }
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtFacturaNumero_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd021( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency021( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00024 */
            pr_default.execute(2, new Object[] {A1ClienteId});
            if ( (pr_default.getStatus(2) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Cliente"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(2) == 101) || ( Z6FacturaNumero != T00024_A6FacturaNumero[0] ) || ( Z7FacturaFecha != T00024_A7FacturaFecha[0] ) )
            {
               if ( Z6FacturaNumero != T00024_A6FacturaNumero[0] )
               {
                  GXUtil.WriteLog("factura:[seudo value changed for attri]"+"FacturaNumero");
                  GXUtil.WriteLogRaw("Old: ",Z6FacturaNumero);
                  GXUtil.WriteLogRaw("Current: ",T00024_A6FacturaNumero[0]);
               }
               if ( Z7FacturaFecha != T00024_A7FacturaFecha[0] )
               {
                  GXUtil.WriteLog("factura:[seudo value changed for attri]"+"FacturaFecha");
                  GXUtil.WriteLogRaw("Old: ",Z7FacturaFecha);
                  GXUtil.WriteLogRaw("Current: ",T00024_A7FacturaFecha[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Cliente"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert021( )
      {
         BeforeValidate021( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable021( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM021( 0) ;
            CheckOptimisticConcurrency021( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm021( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert021( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000215 */
                     pr_default.execute(10, new Object[] {n6FacturaNumero, A6FacturaNumero, A7FacturaFecha});
                     A1ClienteId = T000215_A1ClienteId[0];
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1ClienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1ClienteId), 4, 0)));
                     pr_default.close(10);
                     dsDefault.SmartCacheProvider.SetUpdated("Cliente") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           ProcessLevel021( ) ;
                           if ( AnyError == 0 )
                           {
                              /* Save values for previous() function. */
                              GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                              ResetCaption020( ) ;
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
               Load021( ) ;
            }
            EndLevel021( ) ;
         }
         CloseExtendedTableCursors021( ) ;
      }

      protected void Update021( )
      {
         BeforeValidate021( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable021( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency021( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm021( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate021( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000216 */
                     pr_default.execute(11, new Object[] {n6FacturaNumero, A6FacturaNumero, A7FacturaFecha, A1ClienteId});
                     pr_default.close(11);
                     dsDefault.SmartCacheProvider.SetUpdated("Cliente") ;
                     if ( (pr_default.getStatus(11) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Cliente"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate021( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           ProcessLevel021( ) ;
                           if ( AnyError == 0 )
                           {
                              getByPrimaryKey( ) ;
                              GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), "SuccessfullyUpdated", 0, "", true);
                              ResetCaption020( ) ;
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
            EndLevel021( ) ;
         }
         CloseExtendedTableCursors021( ) ;
      }

      protected void DeferredUpdate021( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate021( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency021( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls021( ) ;
            AfterConfirm021( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete021( ) ;
               if ( AnyError == 0 )
               {
                  ScanStart023( ) ;
                  while ( RcdFound3 != 0 )
                  {
                     getByPrimaryKey023( ) ;
                     Delete023( ) ;
                     ScanNext023( ) ;
                  }
                  ScanEnd023( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000217 */
                     pr_default.execute(12, new Object[] {A1ClienteId});
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
                              InitAll021( ) ;
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
                           ResetCaption020( ) ;
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
         EndLevel021( ) ;
         Gx_mode = sMode1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls021( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            /* Using cursor T000219 */
            pr_default.execute(13, new Object[] {n6FacturaNumero, A6FacturaNumero});
            if ( (pr_default.getStatus(13) != 101) )
            {
               A8FacturaTotal = T000219_A8FacturaTotal[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8FacturaTotal", StringUtil.LTrim( StringUtil.Str( (decimal)(A8FacturaTotal), 4, 0)));
               n8FacturaTotal = T000219_n8FacturaTotal[0];
            }
            else
            {
               A8FacturaTotal = 0;
               n8FacturaTotal = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8FacturaTotal", StringUtil.LTrim( StringUtil.Str( (decimal)(A8FacturaTotal), 4, 0)));
            }
            pr_default.close(13);
         }
      }

      protected void ProcessNestedLevel023( )
      {
         nGXsfl_58_idx = 0;
         while ( nGXsfl_58_idx < nRC_GXsfl_58 )
         {
            ReadRow023( ) ;
            if ( ( nRcdExists_3 != 0 ) || ( nIsMod_3 != 0 ) )
            {
               standaloneNotModal023( ) ;
               GetKey023( ) ;
               if ( ( nRcdExists_3 == 0 ) && ( nRcdDeleted_3 == 0 ) )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  Insert023( ) ;
               }
               else
               {
                  if ( RcdFound3 != 0 )
                  {
                     if ( ( nRcdDeleted_3 != 0 ) && ( nRcdExists_3 != 0 ) )
                     {
                        Gx_mode = "DLT";
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        Delete023( ) ;
                     }
                     else
                     {
                        if ( ( nIsMod_3 != 0 ) && ( nRcdExists_3 != 0 ) )
                        {
                           Gx_mode = "UPD";
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           Update023( ) ;
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_3 == 0 )
                     {
                        GXCCtl = "ARTICULOCODIGO_" + sGXsfl_58_idx;
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, GXCCtl);
                        AnyError = 1;
                        GX_FocusControl = edtArticuloCodigo_Internalname;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtArticuloCodigo_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A9ArticuloCodigo), 4, 0, ".", ""))) ;
            ChangePostValue( edtArticuloCantidad_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A10ArticuloCantidad), 4, 0, ".", ""))) ;
            ChangePostValue( edtArticuloPrecio_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A11ArticuloPrecio), 4, 0, ".", ""))) ;
            ChangePostValue( edtArticuloTotal_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A12ArticuloTotal), 4, 0, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z9ArticuloCodigo_"+sGXsfl_58_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z9ArticuloCodigo), 4, 0, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z10ArticuloCantidad_"+sGXsfl_58_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z10ArticuloCantidad), 4, 0, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z11ArticuloPrecio_"+sGXsfl_58_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z11ArticuloPrecio), 4, 0, ".", ""))) ;
            ChangePostValue( "nRcdDeleted_3_"+sGXsfl_58_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_3), 4, 0, ".", ""))) ;
            ChangePostValue( "nRcdExists_3_"+sGXsfl_58_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_3), 4, 0, ".", ""))) ;
            ChangePostValue( "nIsMod_3_"+sGXsfl_58_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_3), 4, 0, ".", ""))) ;
            if ( nIsMod_3 != 0 )
            {
               ChangePostValue( "ARTICULOCODIGO_"+sGXsfl_58_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtArticuloCodigo_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "ARTICULOCANTIDAD_"+sGXsfl_58_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtArticuloCantidad_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "ARTICULOPRECIO_"+sGXsfl_58_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtArticuloPrecio_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "ARTICULOTOTAL_"+sGXsfl_58_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtArticuloTotal_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
         InitAll023( ) ;
         if ( AnyError != 0 )
         {
         }
         nRcdExists_3 = 0;
         nIsMod_3 = 0;
         nRcdDeleted_3 = 0;
      }

      protected void ProcessLevel021( )
      {
         /* Save parent mode. */
         sMode1 = Gx_mode;
         ProcessNestedLevel023( ) ;
         if ( AnyError != 0 )
         {
         }
         /* Restore parent mode. */
         Gx_mode = sMode1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         /* ' Update level parameters */
      }

      protected void EndLevel021( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(2);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete021( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(3);
            pr_default.close(1);
            pr_default.close(0);
            pr_default.close(13);
            context.CommitDataStores("factura",pr_default);
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
            pr_default.close(3);
            pr_default.close(1);
            pr_default.close(0);
            pr_default.close(13);
            context.RollbackDataStores("factura",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart021( )
      {
         /* Using cursor T000220 */
         pr_default.execute(14);
         RcdFound1 = 0;
         if ( (pr_default.getStatus(14) != 101) )
         {
            RcdFound1 = 1;
            A1ClienteId = T000220_A1ClienteId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1ClienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1ClienteId), 4, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext021( )
      {
         /* Scan next routine */
         pr_default.readNext(14);
         RcdFound1 = 0;
         if ( (pr_default.getStatus(14) != 101) )
         {
            RcdFound1 = 1;
            A1ClienteId = T000220_A1ClienteId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1ClienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1ClienteId), 4, 0)));
         }
      }

      protected void ScanEnd021( )
      {
         pr_default.close(14);
      }

      protected void AfterConfirm021( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert021( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate021( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete021( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete021( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate021( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes021( )
      {
         edtFacturaNumero_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtFacturaNumero_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtFacturaNumero_Enabled), 5, 0)), true);
         edtFacturaFecha_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtFacturaFecha_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtFacturaFecha_Enabled), 5, 0)), true);
         edtClienteId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClienteId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClienteId_Enabled), 5, 0)), true);
         edtFacturaTotal_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtFacturaTotal_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtFacturaTotal_Enabled), 5, 0)), true);
      }

      protected void ZM023( short GX_JID )
      {
         if ( ( GX_JID == 6 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z10ArticuloCantidad = T00023_A10ArticuloCantidad[0];
               Z11ArticuloPrecio = T00023_A11ArticuloPrecio[0];
            }
            else
            {
               Z10ArticuloCantidad = A10ArticuloCantidad;
               Z11ArticuloPrecio = A11ArticuloPrecio;
            }
         }
         if ( GX_JID == -6 )
         {
            Z6FacturaNumero = A6FacturaNumero;
            Z9ArticuloCodigo = A9ArticuloCodigo;
            Z10ArticuloCantidad = A10ArticuloCantidad;
            Z11ArticuloPrecio = A11ArticuloPrecio;
         }
      }

      protected void standaloneNotModal023( )
      {
      }

      protected void standaloneModal023( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            edtArticuloCodigo_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtArticuloCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtArticuloCodigo_Enabled), 5, 0)), !bGXsfl_58_Refreshing);
         }
         else
         {
            edtArticuloCodigo_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtArticuloCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtArticuloCodigo_Enabled), 5, 0)), !bGXsfl_58_Refreshing);
         }
      }

      protected void Load023( )
      {
         /* Using cursor T000221 */
         pr_default.execute(15, new Object[] {n6FacturaNumero, A6FacturaNumero, A9ArticuloCodigo});
         if ( (pr_default.getStatus(15) != 101) )
         {
            RcdFound3 = 1;
            A10ArticuloCantidad = T000221_A10ArticuloCantidad[0];
            A11ArticuloPrecio = T000221_A11ArticuloPrecio[0];
            ZM023( -6) ;
         }
         pr_default.close(15);
         OnLoadActions023( ) ;
      }

      protected void OnLoadActions023( )
      {
         A12ArticuloTotal = (short)(A11ArticuloPrecio*A10ArticuloCantidad);
      }

      protected void CheckExtendedTable023( )
      {
         Gx_BScreen = 1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
         standaloneModal023( ) ;
         A12ArticuloTotal = (short)(A11ArticuloPrecio*A10ArticuloCantidad);
      }

      protected void CloseExtendedTableCursors023( )
      {
      }

      protected void enableDisable023( )
      {
      }

      protected void GetKey023( )
      {
         /* Using cursor T000222 */
         pr_default.execute(16, new Object[] {n6FacturaNumero, A6FacturaNumero, A9ArticuloCodigo});
         if ( (pr_default.getStatus(16) != 101) )
         {
            RcdFound3 = 1;
         }
         else
         {
            RcdFound3 = 0;
         }
         pr_default.close(16);
      }

      protected void getByPrimaryKey023( )
      {
         /* Using cursor T00023 */
         pr_default.execute(1, new Object[] {n6FacturaNumero, A6FacturaNumero, A9ArticuloCodigo});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM023( 6) ;
            RcdFound3 = 1;
            InitializeNonKey023( ) ;
            A9ArticuloCodigo = T00023_A9ArticuloCodigo[0];
            A10ArticuloCantidad = T00023_A10ArticuloCantidad[0];
            A11ArticuloPrecio = T00023_A11ArticuloPrecio[0];
            Z6FacturaNumero = A6FacturaNumero;
            Z9ArticuloCodigo = A9ArticuloCodigo;
            sMode3 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal023( ) ;
            Load023( ) ;
            Gx_mode = sMode3;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound3 = 0;
            InitializeNonKey023( ) ;
            sMode3 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal023( ) ;
            Gx_mode = sMode3;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            DisableAttributes023( ) ;
         }
         pr_default.close(1);
      }

      protected void CheckOptimisticConcurrency023( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00022 */
            pr_default.execute(0, new Object[] {n6FacturaNumero, A6FacturaNumero, A9ArticuloCodigo});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"FacturaArticulo"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( Z10ArticuloCantidad != T00022_A10ArticuloCantidad[0] ) || ( Z11ArticuloPrecio != T00022_A11ArticuloPrecio[0] ) )
            {
               if ( Z10ArticuloCantidad != T00022_A10ArticuloCantidad[0] )
               {
                  GXUtil.WriteLog("factura:[seudo value changed for attri]"+"ArticuloCantidad");
                  GXUtil.WriteLogRaw("Old: ",Z10ArticuloCantidad);
                  GXUtil.WriteLogRaw("Current: ",T00022_A10ArticuloCantidad[0]);
               }
               if ( Z11ArticuloPrecio != T00022_A11ArticuloPrecio[0] )
               {
                  GXUtil.WriteLog("factura:[seudo value changed for attri]"+"ArticuloPrecio");
                  GXUtil.WriteLogRaw("Old: ",Z11ArticuloPrecio);
                  GXUtil.WriteLogRaw("Current: ",T00022_A11ArticuloPrecio[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"FacturaArticulo"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert023( )
      {
         BeforeValidate023( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable023( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM023( 0) ;
            CheckOptimisticConcurrency023( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm023( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert023( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000223 */
                     pr_default.execute(17, new Object[] {n6FacturaNumero, A6FacturaNumero, A9ArticuloCodigo, A10ArticuloCantidad, A11ArticuloPrecio});
                     pr_default.close(17);
                     dsDefault.SmartCacheProvider.SetUpdated("FacturaArticulo") ;
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
               Load023( ) ;
            }
            EndLevel023( ) ;
         }
         CloseExtendedTableCursors023( ) ;
      }

      protected void Update023( )
      {
         BeforeValidate023( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable023( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency023( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm023( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate023( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000224 */
                     pr_default.execute(18, new Object[] {A10ArticuloCantidad, A11ArticuloPrecio, n6FacturaNumero, A6FacturaNumero, A9ArticuloCodigo});
                     pr_default.close(18);
                     dsDefault.SmartCacheProvider.SetUpdated("FacturaArticulo") ;
                     if ( (pr_default.getStatus(18) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"FacturaArticulo"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate023( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey023( ) ;
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
            EndLevel023( ) ;
         }
         CloseExtendedTableCursors023( ) ;
      }

      protected void DeferredUpdate023( )
      {
      }

      protected void Delete023( )
      {
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate023( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency023( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls023( ) ;
            AfterConfirm023( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete023( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000225 */
                  pr_default.execute(19, new Object[] {n6FacturaNumero, A6FacturaNumero, A9ArticuloCodigo});
                  pr_default.close(19);
                  dsDefault.SmartCacheProvider.SetUpdated("FacturaArticulo") ;
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
         sMode3 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel023( ) ;
         Gx_mode = sMode3;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls023( )
      {
         standaloneModal023( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            A12ArticuloTotal = (short)(A11ArticuloPrecio*A10ArticuloCantidad);
         }
      }

      protected void EndLevel023( )
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

      public void ScanStart023( )
      {
         /* Scan By routine */
         /* Using cursor T000226 */
         pr_default.execute(20, new Object[] {n6FacturaNumero, A6FacturaNumero});
         RcdFound3 = 0;
         if ( (pr_default.getStatus(20) != 101) )
         {
            RcdFound3 = 1;
            A9ArticuloCodigo = T000226_A9ArticuloCodigo[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext023( )
      {
         /* Scan next routine */
         pr_default.readNext(20);
         RcdFound3 = 0;
         if ( (pr_default.getStatus(20) != 101) )
         {
            RcdFound3 = 1;
            A9ArticuloCodigo = T000226_A9ArticuloCodigo[0];
         }
      }

      protected void ScanEnd023( )
      {
         pr_default.close(20);
      }

      protected void AfterConfirm023( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert023( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate023( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete023( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete023( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate023( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes023( )
      {
         edtArticuloCodigo_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtArticuloCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtArticuloCodigo_Enabled), 5, 0)), !bGXsfl_58_Refreshing);
         edtArticuloCantidad_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtArticuloCantidad_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtArticuloCantidad_Enabled), 5, 0)), !bGXsfl_58_Refreshing);
         edtArticuloPrecio_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtArticuloPrecio_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtArticuloPrecio_Enabled), 5, 0)), !bGXsfl_58_Refreshing);
         edtArticuloTotal_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtArticuloTotal_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtArticuloTotal_Enabled), 5, 0)), !bGXsfl_58_Refreshing);
      }

      protected void send_integrity_lvl_hashes023( )
      {
      }

      protected void send_integrity_lvl_hashes021( )
      {
      }

      protected void SubsflControlProps_583( )
      {
         edtArticuloCodigo_Internalname = "ARTICULOCODIGO_"+sGXsfl_58_idx;
         edtArticuloCantidad_Internalname = "ARTICULOCANTIDAD_"+sGXsfl_58_idx;
         edtArticuloPrecio_Internalname = "ARTICULOPRECIO_"+sGXsfl_58_idx;
         edtArticuloTotal_Internalname = "ARTICULOTOTAL_"+sGXsfl_58_idx;
      }

      protected void SubsflControlProps_fel_583( )
      {
         edtArticuloCodigo_Internalname = "ARTICULOCODIGO_"+sGXsfl_58_fel_idx;
         edtArticuloCantidad_Internalname = "ARTICULOCANTIDAD_"+sGXsfl_58_fel_idx;
         edtArticuloPrecio_Internalname = "ARTICULOPRECIO_"+sGXsfl_58_fel_idx;
         edtArticuloTotal_Internalname = "ARTICULOTOTAL_"+sGXsfl_58_fel_idx;
      }

      protected void AddRow023( )
      {
         nGXsfl_58_idx = (short)(nGXsfl_58_idx+1);
         sGXsfl_58_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_58_idx), 4, 0)), 4, "0");
         SubsflControlProps_583( ) ;
         SendRow023( ) ;
      }

      protected void SendRow023( )
      {
         Gridfactura_articuloRow = GXWebRow.GetNew(context);
         if ( subGridfactura_articulo_Backcolorstyle == 0 )
         {
            /* None style subfile background logic. */
            subGridfactura_articulo_Backstyle = 0;
            if ( StringUtil.StrCmp(subGridfactura_articulo_Class, "") != 0 )
            {
               subGridfactura_articulo_Linesclass = subGridfactura_articulo_Class+"Odd";
            }
         }
         else if ( subGridfactura_articulo_Backcolorstyle == 1 )
         {
            /* Uniform style subfile background logic. */
            subGridfactura_articulo_Backstyle = 0;
            subGridfactura_articulo_Backcolor = subGridfactura_articulo_Allbackcolor;
            if ( StringUtil.StrCmp(subGridfactura_articulo_Class, "") != 0 )
            {
               subGridfactura_articulo_Linesclass = subGridfactura_articulo_Class+"Uniform";
            }
         }
         else if ( subGridfactura_articulo_Backcolorstyle == 2 )
         {
            /* Header style subfile background logic. */
            subGridfactura_articulo_Backstyle = 1;
            if ( StringUtil.StrCmp(subGridfactura_articulo_Class, "") != 0 )
            {
               subGridfactura_articulo_Linesclass = subGridfactura_articulo_Class+"Odd";
            }
            subGridfactura_articulo_Backcolor = (int)(0x0);
         }
         else if ( subGridfactura_articulo_Backcolorstyle == 3 )
         {
            /* Report style subfile background logic. */
            subGridfactura_articulo_Backstyle = 1;
            if ( ((int)(((nGXsfl_58_idx-1)/ (decimal)(1)) % (2))) == 0 )
            {
               subGridfactura_articulo_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGridfactura_articulo_Class, "") != 0 )
               {
                  subGridfactura_articulo_Linesclass = subGridfactura_articulo_Class+"Odd";
               }
            }
            else
            {
               subGridfactura_articulo_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGridfactura_articulo_Class, "") != 0 )
               {
                  subGridfactura_articulo_Linesclass = subGridfactura_articulo_Class+"Even";
               }
            }
         }
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_3_" + sGXsfl_58_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 59,'',false,'" + sGXsfl_58_idx + "',58)\"";
         ROClassString = "Attribute";
         Gridfactura_articuloRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtArticuloCodigo_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A9ArticuloCodigo), 4, 0, ".", "")),StringUtil.LTrim( context.localUtil.Format( (decimal)(A9ArticuloCodigo), "ZZZ9")),TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,59);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtArticuloCodigo_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtArticuloCodigo_Enabled,(short)1,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)58,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_3_" + sGXsfl_58_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 60,'',false,'" + sGXsfl_58_idx + "',58)\"";
         ROClassString = "Attribute";
         Gridfactura_articuloRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtArticuloCantidad_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A10ArticuloCantidad), 4, 0, ".", "")),((edtArticuloCantidad_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A10ArticuloCantidad), "ZZZ9")) : context.localUtil.Format( (decimal)(A10ArticuloCantidad), "ZZZ9")),TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,60);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtArticuloCantidad_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtArticuloCantidad_Enabled,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)58,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_3_" + sGXsfl_58_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 61,'',false,'" + sGXsfl_58_idx + "',58)\"";
         ROClassString = "Attribute";
         Gridfactura_articuloRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtArticuloPrecio_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A11ArticuloPrecio), 4, 0, ".", "")),((edtArticuloPrecio_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A11ArticuloPrecio), "ZZZ9")) : context.localUtil.Format( (decimal)(A11ArticuloPrecio), "ZZZ9")),TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,61);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtArticuloPrecio_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtArticuloPrecio_Enabled,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)58,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         /* Single line edit */
         ROClassString = "Attribute";
         Gridfactura_articuloRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtArticuloTotal_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A12ArticuloTotal), 4, 0, ".", "")),((edtArticuloTotal_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A12ArticuloTotal), "ZZZ9")) : context.localUtil.Format( (decimal)(A12ArticuloTotal), "ZZZ9")),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtArticuloTotal_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtArticuloTotal_Enabled,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)58,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         context.httpAjaxContext.ajax_sending_grid_row(Gridfactura_articuloRow);
         send_integrity_lvl_hashes023( ) ;
         GXCCtl = "Z9ArticuloCodigo_" + sGXsfl_58_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z9ArticuloCodigo), 4, 0, ".", "")));
         GXCCtl = "Z10ArticuloCantidad_" + sGXsfl_58_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z10ArticuloCantidad), 4, 0, ".", "")));
         GXCCtl = "Z11ArticuloPrecio_" + sGXsfl_58_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z11ArticuloPrecio), 4, 0, ".", "")));
         GXCCtl = "nRcdDeleted_3_" + sGXsfl_58_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_3), 4, 0, ".", "")));
         GXCCtl = "nRcdExists_3_" + sGXsfl_58_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_3), 4, 0, ".", "")));
         GXCCtl = "nIsMod_3_" + sGXsfl_58_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_3), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "ARTICULOCODIGO_"+sGXsfl_58_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtArticuloCodigo_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "ARTICULOCANTIDAD_"+sGXsfl_58_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtArticuloCantidad_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "ARTICULOPRECIO_"+sGXsfl_58_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtArticuloPrecio_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "ARTICULOTOTAL_"+sGXsfl_58_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtArticuloTotal_Enabled), 5, 0, ".", "")));
         context.httpAjaxContext.ajax_sending_grid_row(null);
         Gridfactura_articuloContainer.AddRow(Gridfactura_articuloRow);
      }

      protected void ReadRow023( )
      {
         nGXsfl_58_idx = (short)(nGXsfl_58_idx+1);
         sGXsfl_58_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_58_idx), 4, 0)), 4, "0");
         SubsflControlProps_583( ) ;
         edtArticuloCodigo_Enabled = (int)(context.localUtil.CToN( cgiGet( "ARTICULOCODIGO_"+sGXsfl_58_idx+"Enabled"), ".", ","));
         edtArticuloCantidad_Enabled = (int)(context.localUtil.CToN( cgiGet( "ARTICULOCANTIDAD_"+sGXsfl_58_idx+"Enabled"), ".", ","));
         edtArticuloPrecio_Enabled = (int)(context.localUtil.CToN( cgiGet( "ARTICULOPRECIO_"+sGXsfl_58_idx+"Enabled"), ".", ","));
         edtArticuloTotal_Enabled = (int)(context.localUtil.CToN( cgiGet( "ARTICULOTOTAL_"+sGXsfl_58_idx+"Enabled"), ".", ","));
         if ( ( ( context.localUtil.CToN( cgiGet( edtArticuloCodigo_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtArticuloCodigo_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
         {
            GXCCtl = "ARTICULOCODIGO_" + sGXsfl_58_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtArticuloCodigo_Internalname;
            wbErr = true;
            A9ArticuloCodigo = 0;
         }
         else
         {
            A9ArticuloCodigo = (short)(context.localUtil.CToN( cgiGet( edtArticuloCodigo_Internalname), ".", ","));
         }
         if ( ( ( context.localUtil.CToN( cgiGet( edtArticuloCantidad_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtArticuloCantidad_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
         {
            GXCCtl = "ARTICULOCANTIDAD_" + sGXsfl_58_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtArticuloCantidad_Internalname;
            wbErr = true;
            A10ArticuloCantidad = 0;
         }
         else
         {
            A10ArticuloCantidad = (short)(context.localUtil.CToN( cgiGet( edtArticuloCantidad_Internalname), ".", ","));
         }
         if ( ( ( context.localUtil.CToN( cgiGet( edtArticuloPrecio_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtArticuloPrecio_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
         {
            GXCCtl = "ARTICULOPRECIO_" + sGXsfl_58_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtArticuloPrecio_Internalname;
            wbErr = true;
            A11ArticuloPrecio = 0;
         }
         else
         {
            A11ArticuloPrecio = (short)(context.localUtil.CToN( cgiGet( edtArticuloPrecio_Internalname), ".", ","));
         }
         A12ArticuloTotal = (short)(context.localUtil.CToN( cgiGet( edtArticuloTotal_Internalname), ".", ","));
         GXCCtl = "Z9ArticuloCodigo_" + sGXsfl_58_idx;
         Z9ArticuloCodigo = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ","));
         GXCCtl = "Z10ArticuloCantidad_" + sGXsfl_58_idx;
         Z10ArticuloCantidad = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ","));
         GXCCtl = "Z11ArticuloPrecio_" + sGXsfl_58_idx;
         Z11ArticuloPrecio = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ","));
         GXCCtl = "nRcdDeleted_3_" + sGXsfl_58_idx;
         nRcdDeleted_3 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ","));
         GXCCtl = "nRcdExists_3_" + sGXsfl_58_idx;
         nRcdExists_3 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ","));
         GXCCtl = "nIsMod_3_" + sGXsfl_58_idx;
         nIsMod_3 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ","));
      }

      protected void assign_properties_default( )
      {
         defedtArticuloCodigo_Enabled = edtArticuloCodigo_Enabled;
      }

      protected void ConfirmValues020( )
      {
         nGXsfl_58_idx = 0;
         sGXsfl_58_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_58_idx), 4, 0)), 4, "0");
         SubsflControlProps_583( ) ;
         while ( nGXsfl_58_idx < nRC_GXsfl_58 )
         {
            nGXsfl_58_idx = (short)(nGXsfl_58_idx+1);
            sGXsfl_58_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_58_idx), 4, 0)), 4, "0");
            SubsflControlProps_583( ) ;
            ChangePostValue( "Z9ArticuloCodigo_"+sGXsfl_58_idx, cgiGet( "ZT_"+"Z9ArticuloCodigo_"+sGXsfl_58_idx)) ;
            DeletePostValue( "ZT_"+"Z9ArticuloCodigo_"+sGXsfl_58_idx) ;
            ChangePostValue( "Z10ArticuloCantidad_"+sGXsfl_58_idx, cgiGet( "ZT_"+"Z10ArticuloCantidad_"+sGXsfl_58_idx)) ;
            DeletePostValue( "ZT_"+"Z10ArticuloCantidad_"+sGXsfl_58_idx) ;
            ChangePostValue( "Z11ArticuloPrecio_"+sGXsfl_58_idx, cgiGet( "ZT_"+"Z11ArticuloPrecio_"+sGXsfl_58_idx)) ;
            DeletePostValue( "ZT_"+"Z11ArticuloPrecio_"+sGXsfl_58_idx) ;
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
         context.AddJavascriptSource("gxcfg.js", "?201931119405745", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("factura.aspx") +"\">") ;
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
         forbiddenHiddens = "hsh" + "Factura";
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format(A7FacturaFecha, "99/99/99");
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("factura:[SendSecurityCheck value for]"+"FacturaFecha:"+context.localUtil.Format(A7FacturaFecha, "99/99/99"));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z1ClienteId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z1ClienteId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z6FacturaNumero", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z6FacturaNumero), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z7FacturaFecha", context.localUtil.DToC( Z7FacturaFecha, 0, "/"));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_58", StringUtil.LTrim( StringUtil.NToC( (decimal)(nGXsfl_58_idx), 4, 0, ".", "")));
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
         return formatLink("factura.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "Factura" ;
      }

      public override String GetPgmdesc( )
      {
         return "Factura" ;
      }

      protected void InitializeNonKey021( )
      {
         A6FacturaNumero = 0;
         n6FacturaNumero = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6FacturaNumero", StringUtil.LTrim( StringUtil.Str( (decimal)(A6FacturaNumero), 4, 0)));
         A8FacturaTotal = 0;
         n8FacturaTotal = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8FacturaTotal", StringUtil.LTrim( StringUtil.Str( (decimal)(A8FacturaTotal), 4, 0)));
         A7FacturaFecha = Gx_date;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7FacturaFecha", context.localUtil.Format(A7FacturaFecha, "99/99/99"));
         Z6FacturaNumero = 0;
         Z7FacturaFecha = DateTime.MinValue;
      }

      protected void InitAll021( )
      {
         A1ClienteId = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1ClienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1ClienteId), 4, 0)));
         InitializeNonKey021( ) ;
      }

      protected void StandaloneModalInsert( )
      {
         A7FacturaFecha = i7FacturaFecha;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7FacturaFecha", context.localUtil.Format(A7FacturaFecha, "99/99/99"));
      }

      protected void InitializeNonKey023( )
      {
         A10ArticuloCantidad = 0;
         A11ArticuloPrecio = 0;
         A12ArticuloTotal = 0;
         Z10ArticuloCantidad = 0;
         Z11ArticuloPrecio = 0;
      }

      protected void InitAll023( )
      {
         A9ArticuloCodigo = 0;
         InitializeNonKey023( ) ;
      }

      protected void StandaloneModalInsert023( )
      {
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?201931119405751", true);
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
         context.AddJavascriptSource("factura.js", "?201931119405752", false);
         /* End function include_jscripts */
      }

      protected void init_level_properties3( )
      {
         edtArticuloCodigo_Enabled = defedtArticuloCodigo_Enabled;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtArticuloCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtArticuloCodigo_Enabled), 5, 0)), !bGXsfl_58_Refreshing);
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
         edtFacturaNumero_Internalname = "FACTURANUMERO";
         edtFacturaFecha_Internalname = "FACTURAFECHA";
         edtClienteId_Internalname = "CLIENTEID";
         edtFacturaTotal_Internalname = "FACTURATOTAL";
         lblTitlearticulo_Internalname = "TITLEARTICULO";
         edtArticuloCodigo_Internalname = "ARTICULOCODIGO";
         edtArticuloCantidad_Internalname = "ARTICULOCANTIDAD";
         edtArticuloPrecio_Internalname = "ARTICULOPRECIO";
         edtArticuloTotal_Internalname = "ARTICULOTOTAL";
         divArticulotable_Internalname = "ARTICULOTABLE";
         divFormcontainer_Internalname = "FORMCONTAINER";
         bttBtn_enter_Internalname = "BTN_ENTER";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         bttBtn_delete_Internalname = "BTN_DELETE";
         divMaintable_Internalname = "MAINTABLE";
         Form.Internalname = "FORM";
         subGridfactura_articulo_Internalname = "GRIDFACTURA_ARTICULO";
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
         Form.Caption = "Factura";
         edtArticuloTotal_Jsonclick = "";
         edtArticuloPrecio_Jsonclick = "";
         edtArticuloCantidad_Jsonclick = "";
         edtArticuloCodigo_Jsonclick = "";
         subGridfactura_articulo_Class = "Grid";
         subGridfactura_articulo_Backcolorstyle = 0;
         subGridfactura_articulo_Allowcollapsing = 0;
         subGridfactura_articulo_Allowselection = 0;
         edtArticuloTotal_Enabled = 0;
         edtArticuloPrecio_Enabled = 1;
         edtArticuloCantidad_Enabled = 1;
         edtArticuloCodigo_Enabled = 1;
         subGridfactura_articulo_Header = "";
         bttBtn_delete_Enabled = 1;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edtFacturaTotal_Jsonclick = "";
         edtFacturaTotal_Enabled = 0;
         edtClienteId_Jsonclick = "";
         edtClienteId_Enabled = 1;
         edtFacturaFecha_Jsonclick = "";
         edtFacturaFecha_Enabled = 0;
         edtFacturaNumero_Jsonclick = "";
         edtFacturaNumero_Enabled = 1;
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

      protected void gxnrGridfactura_articulo_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         Gx_mode = "INS";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         SubsflControlProps_583( ) ;
         while ( nGXsfl_58_idx <= nRC_GXsfl_58 )
         {
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            standaloneNotModal023( ) ;
            standaloneModal023( ) ;
            init_web_controls( ) ;
            dynload_actions( ) ;
            SendRow023( ) ;
            nGXsfl_58_idx = (short)(nGXsfl_58_idx+1);
            sGXsfl_58_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_58_idx), 4, 0)), 4, "0");
            SubsflControlProps_583( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( Gridfactura_articuloContainer));
         /* End function gxnrGridfactura_articulo_newrow */
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
         GX_FocusControl = edtFacturaNumero_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         /* End function AfterKeyLoadScreen */
      }

      public void Valid_Clienteid( String GX_Parm1 ,
                                   short GX_Parm2 ,
                                   short GX_Parm3 ,
                                   DateTime GX_Parm4 )
      {
         Gx_mode = GX_Parm1;
         A1ClienteId = GX_Parm2;
         A6FacturaNumero = GX_Parm3;
         n6FacturaNumero = false;
         A7FacturaFecha = GX_Parm4;
         context.wbHandled = 1;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         send_integrity_footer_hashes( ) ;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A8FacturaTotal = 0;
            n8FacturaTotal = false;
         }
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(A6FacturaNumero), 4, 0, ".", "")));
         isValidOutput.Add(context.localUtil.Format(A7FacturaFecha, "99/99/99"));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(A8FacturaTotal), 4, 0, ".", "")));
         isValidOutput.Add(StringUtil.RTrim( Gx_mode));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z1ClienteId), 4, 0, ".", "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z6FacturaNumero), 4, 0, ".", "")));
         isValidOutput.Add(context.localUtil.DToC( Z7FacturaFecha, 0, "/"));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z8FacturaTotal), 4, 0, ".", "")));
         isValidOutput.Add(Gridfactura_articuloContainer);
         isValidOutput.Add(bttBtn_delete_Enabled);
         isValidOutput.Add(bttBtn_enter_Enabled);
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         isValidOutput.Add(context.httpAjaxContext.ajax_rsp_get_hiddens( ));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public void Valid_Facturanumero( short GX_Parm1 ,
                                       short GX_Parm2 )
      {
         A6FacturaNumero = GX_Parm1;
         n6FacturaNumero = false;
         A8FacturaTotal = GX_Parm2;
         n8FacturaTotal = false;
         /* Using cursor T000219 */
         pr_default.execute(13, new Object[] {n6FacturaNumero, A6FacturaNumero});
         if ( (pr_default.getStatus(13) != 101) )
         {
            A8FacturaTotal = T000219_A8FacturaTotal[0];
            n8FacturaTotal = T000219_n8FacturaTotal[0];
         }
         else
         {
            A8FacturaTotal = 0;
            n8FacturaTotal = false;
         }
         pr_default.close(13);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A8FacturaTotal = 0;
            n8FacturaTotal = false;
         }
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(A8FacturaTotal), 4, 0, ".", "")));
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'A7FacturaFecha',fld:'FACTURAFECHA',pic:''}]");
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
         Z7FacturaFecha = DateTime.MinValue;
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
         A7FacturaFecha = DateTime.MinValue;
         lblTitlearticulo_Jsonclick = "";
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         Gridfactura_articuloContainer = new GXWebGrid( context);
         Gridfactura_articuloColumn = new GXWebColumn();
         sMode3 = "";
         sStyleString = "";
         Gx_date = DateTime.MinValue;
         forbiddenHiddens = "";
         hsh = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         GXCCtl = "";
         T00029_A1ClienteId = new short[1] ;
         T00029_A6FacturaNumero = new short[1] ;
         T00029_n6FacturaNumero = new bool[] {false} ;
         T00029_A7FacturaFecha = new DateTime[] {DateTime.MinValue} ;
         T00029_A8FacturaTotal = new short[1] ;
         T00029_n8FacturaTotal = new bool[] {false} ;
         T00027_A8FacturaTotal = new short[1] ;
         T00027_n8FacturaTotal = new bool[] {false} ;
         T000211_A8FacturaTotal = new short[1] ;
         T000211_n8FacturaTotal = new bool[] {false} ;
         T000212_A1ClienteId = new short[1] ;
         T00025_A1ClienteId = new short[1] ;
         T00025_A6FacturaNumero = new short[1] ;
         T00025_n6FacturaNumero = new bool[] {false} ;
         T00025_A7FacturaFecha = new DateTime[] {DateTime.MinValue} ;
         sMode1 = "";
         T000213_A1ClienteId = new short[1] ;
         T000214_A1ClienteId = new short[1] ;
         T00024_A1ClienteId = new short[1] ;
         T00024_A6FacturaNumero = new short[1] ;
         T00024_n6FacturaNumero = new bool[] {false} ;
         T00024_A7FacturaFecha = new DateTime[] {DateTime.MinValue} ;
         T000215_A1ClienteId = new short[1] ;
         T000219_A8FacturaTotal = new short[1] ;
         T000219_n8FacturaTotal = new bool[] {false} ;
         T000220_A1ClienteId = new short[1] ;
         T000221_A6FacturaNumero = new short[1] ;
         T000221_n6FacturaNumero = new bool[] {false} ;
         T000221_A9ArticuloCodigo = new short[1] ;
         T000221_A10ArticuloCantidad = new short[1] ;
         T000221_A11ArticuloPrecio = new short[1] ;
         T000222_A6FacturaNumero = new short[1] ;
         T000222_n6FacturaNumero = new bool[] {false} ;
         T000222_A9ArticuloCodigo = new short[1] ;
         T00023_A6FacturaNumero = new short[1] ;
         T00023_n6FacturaNumero = new bool[] {false} ;
         T00023_A9ArticuloCodigo = new short[1] ;
         T00023_A10ArticuloCantidad = new short[1] ;
         T00023_A11ArticuloPrecio = new short[1] ;
         T00022_A6FacturaNumero = new short[1] ;
         T00022_n6FacturaNumero = new bool[] {false} ;
         T00022_A9ArticuloCodigo = new short[1] ;
         T00022_A10ArticuloCantidad = new short[1] ;
         T00022_A11ArticuloPrecio = new short[1] ;
         T000226_A6FacturaNumero = new short[1] ;
         T000226_n6FacturaNumero = new bool[] {false} ;
         T000226_A9ArticuloCodigo = new short[1] ;
         Gridfactura_articuloRow = new GXWebRow();
         subGridfactura_articulo_Linesclass = "";
         ROClassString = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         i7FacturaFecha = DateTime.MinValue;
         isValidOutput = new GxUnknownObjectCollection();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.factura__default(),
            new Object[][] {
                new Object[] {
               T00022_A6FacturaNumero, T00022_A9ArticuloCodigo, T00022_A10ArticuloCantidad, T00022_A11ArticuloPrecio
               }
               , new Object[] {
               T00023_A6FacturaNumero, T00023_A9ArticuloCodigo, T00023_A10ArticuloCantidad, T00023_A11ArticuloPrecio
               }
               , new Object[] {
               T00024_A1ClienteId, T00024_A6FacturaNumero, T00024_A7FacturaFecha
               }
               , new Object[] {
               T00025_A1ClienteId, T00025_A6FacturaNumero, T00025_A7FacturaFecha
               }
               , new Object[] {
               T00027_A8FacturaTotal, T00027_n8FacturaTotal
               }
               , new Object[] {
               T00029_A1ClienteId, T00029_A6FacturaNumero, T00029_n6FacturaNumero, T00029_A7FacturaFecha, T00029_A8FacturaTotal, T00029_n8FacturaTotal
               }
               , new Object[] {
               T000211_A8FacturaTotal, T000211_n8FacturaTotal
               }
               , new Object[] {
               T000212_A1ClienteId
               }
               , new Object[] {
               T000213_A1ClienteId
               }
               , new Object[] {
               T000214_A1ClienteId
               }
               , new Object[] {
               T000215_A1ClienteId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000219_A8FacturaTotal, T000219_n8FacturaTotal
               }
               , new Object[] {
               T000220_A1ClienteId
               }
               , new Object[] {
               T000221_A6FacturaNumero, T000221_A9ArticuloCodigo, T000221_A10ArticuloCantidad, T000221_A11ArticuloPrecio
               }
               , new Object[] {
               T000222_A6FacturaNumero, T000222_A9ArticuloCodigo
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000226_A6FacturaNumero, T000226_A9ArticuloCodigo
               }
            }
         );
         Z1ClienteId = 0;
         A1ClienteId = 0;
         Z7FacturaFecha = DateTime.MinValue;
         A7FacturaFecha = DateTime.MinValue;
         i7FacturaFecha = DateTime.MinValue;
         Gx_date = DateTimeUtil.Today( context);
      }

      private short Z1ClienteId ;
      private short Z6FacturaNumero ;
      private short nRC_GXsfl_58 ;
      private short nGXsfl_58_idx=1 ;
      private short Z9ArticuloCodigo ;
      private short Z10ArticuloCantidad ;
      private short Z11ArticuloPrecio ;
      private short nRcdDeleted_3 ;
      private short nRcdExists_3 ;
      private short nIsMod_3 ;
      private short GxWebError ;
      private short A6FacturaNumero ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short A1ClienteId ;
      private short A8FacturaTotal ;
      private short subGridfactura_articulo_Backcolorstyle ;
      private short A9ArticuloCodigo ;
      private short A10ArticuloCantidad ;
      private short A11ArticuloPrecio ;
      private short A12ArticuloTotal ;
      private short subGridfactura_articulo_Allowselection ;
      private short subGridfactura_articulo_Allowhovering ;
      private short subGridfactura_articulo_Allowcollapsing ;
      private short subGridfactura_articulo_Collapsed ;
      private short nBlankRcdCount3 ;
      private short RcdFound3 ;
      private short nBlankRcdUsr3 ;
      private short Gx_BScreen ;
      private short GX_JID ;
      private short Z8FacturaTotal ;
      private short RcdFound1 ;
      private short subGridfactura_articulo_Backstyle ;
      private short gxajaxcallmode ;
      private short wbTemp ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int edtFacturaNumero_Enabled ;
      private int edtFacturaFecha_Enabled ;
      private int edtClienteId_Enabled ;
      private int edtFacturaTotal_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int edtArticuloCodigo_Enabled ;
      private int edtArticuloCantidad_Enabled ;
      private int edtArticuloPrecio_Enabled ;
      private int edtArticuloTotal_Enabled ;
      private int subGridfactura_articulo_Selectedindex ;
      private int subGridfactura_articulo_Selectioncolor ;
      private int subGridfactura_articulo_Hoveringcolor ;
      private int fRowAdded ;
      private int subGridfactura_articulo_Backcolor ;
      private int subGridfactura_articulo_Allbackcolor ;
      private int defedtArticuloCodigo_Enabled ;
      private int idxLst ;
      private long GRIDFACTURA_ARTICULO_nFirstRecordOnPage ;
      private String sPrefix ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_58_idx="0001" ;
      private String Gx_mode ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtFacturaNumero_Internalname ;
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
      private String edtFacturaNumero_Jsonclick ;
      private String edtFacturaFecha_Internalname ;
      private String edtFacturaFecha_Jsonclick ;
      private String edtClienteId_Internalname ;
      private String edtClienteId_Jsonclick ;
      private String edtFacturaTotal_Internalname ;
      private String edtFacturaTotal_Jsonclick ;
      private String divArticulotable_Internalname ;
      private String lblTitlearticulo_Internalname ;
      private String lblTitlearticulo_Jsonclick ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String subGridfactura_articulo_Header ;
      private String sMode3 ;
      private String edtArticuloCodigo_Internalname ;
      private String edtArticuloCantidad_Internalname ;
      private String edtArticuloPrecio_Internalname ;
      private String edtArticuloTotal_Internalname ;
      private String sStyleString ;
      private String forbiddenHiddens ;
      private String hsh ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String GXCCtl ;
      private String sMode1 ;
      private String sGXsfl_58_fel_idx="0001" ;
      private String subGridfactura_articulo_Class ;
      private String subGridfactura_articulo_Linesclass ;
      private String ROClassString ;
      private String edtArticuloCodigo_Jsonclick ;
      private String edtArticuloCantidad_Jsonclick ;
      private String edtArticuloPrecio_Jsonclick ;
      private String edtArticuloTotal_Jsonclick ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String subGridfactura_articulo_Internalname ;
      private DateTime Z7FacturaFecha ;
      private DateTime A7FacturaFecha ;
      private DateTime Gx_date ;
      private DateTime i7FacturaFecha ;
      private bool entryPointCalled ;
      private bool n6FacturaNumero ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool bGXsfl_58_Refreshing=false ;
      private bool n8FacturaTotal ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXWebGrid Gridfactura_articuloContainer ;
      private GXWebRow Gridfactura_articuloRow ;
      private GXWebColumn Gridfactura_articuloColumn ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] T00029_A1ClienteId ;
      private short[] T00029_A6FacturaNumero ;
      private bool[] T00029_n6FacturaNumero ;
      private DateTime[] T00029_A7FacturaFecha ;
      private short[] T00029_A8FacturaTotal ;
      private bool[] T00029_n8FacturaTotal ;
      private short[] T00027_A8FacturaTotal ;
      private bool[] T00027_n8FacturaTotal ;
      private short[] T000211_A8FacturaTotal ;
      private bool[] T000211_n8FacturaTotal ;
      private short[] T000212_A1ClienteId ;
      private short[] T00025_A1ClienteId ;
      private short[] T00025_A6FacturaNumero ;
      private bool[] T00025_n6FacturaNumero ;
      private DateTime[] T00025_A7FacturaFecha ;
      private short[] T000213_A1ClienteId ;
      private short[] T000214_A1ClienteId ;
      private short[] T00024_A1ClienteId ;
      private short[] T00024_A6FacturaNumero ;
      private bool[] T00024_n6FacturaNumero ;
      private DateTime[] T00024_A7FacturaFecha ;
      private short[] T000215_A1ClienteId ;
      private short[] T000219_A8FacturaTotal ;
      private bool[] T000219_n8FacturaTotal ;
      private short[] T000220_A1ClienteId ;
      private short[] T000221_A6FacturaNumero ;
      private bool[] T000221_n6FacturaNumero ;
      private short[] T000221_A9ArticuloCodigo ;
      private short[] T000221_A10ArticuloCantidad ;
      private short[] T000221_A11ArticuloPrecio ;
      private short[] T000222_A6FacturaNumero ;
      private bool[] T000222_n6FacturaNumero ;
      private short[] T000222_A9ArticuloCodigo ;
      private short[] T00023_A6FacturaNumero ;
      private bool[] T00023_n6FacturaNumero ;
      private short[] T00023_A9ArticuloCodigo ;
      private short[] T00023_A10ArticuloCantidad ;
      private short[] T00023_A11ArticuloPrecio ;
      private short[] T00022_A6FacturaNumero ;
      private bool[] T00022_n6FacturaNumero ;
      private short[] T00022_A9ArticuloCodigo ;
      private short[] T00022_A10ArticuloCantidad ;
      private short[] T00022_A11ArticuloPrecio ;
      private short[] T000226_A6FacturaNumero ;
      private bool[] T000226_n6FacturaNumero ;
      private short[] T000226_A9ArticuloCodigo ;
      private GXWebForm Form ;
   }

   public class factura__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new UpdateCursor(def[11])
         ,new UpdateCursor(def[12])
         ,new ForEachCursor(def[13])
         ,new ForEachCursor(def[14])
         ,new ForEachCursor(def[15])
         ,new ForEachCursor(def[16])
         ,new UpdateCursor(def[17])
         ,new UpdateCursor(def[18])
         ,new UpdateCursor(def[19])
         ,new ForEachCursor(def[20])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT00029 ;
          prmT00029 = new Object[] {
          new Object[] {"@ClienteId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00027 ;
          prmT00027 = new Object[] {
          new Object[] {"@FacturaNumero",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000211 ;
          prmT000211 = new Object[] {
          new Object[] {"@FacturaNumero",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000212 ;
          prmT000212 = new Object[] {
          new Object[] {"@ClienteId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00025 ;
          prmT00025 = new Object[] {
          new Object[] {"@ClienteId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000213 ;
          prmT000213 = new Object[] {
          new Object[] {"@ClienteId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000214 ;
          prmT000214 = new Object[] {
          new Object[] {"@ClienteId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00024 ;
          prmT00024 = new Object[] {
          new Object[] {"@ClienteId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000215 ;
          prmT000215 = new Object[] {
          new Object[] {"@FacturaNumero",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@FacturaFecha",SqlDbType.DateTime,8,0}
          } ;
          Object[] prmT000216 ;
          prmT000216 = new Object[] {
          new Object[] {"@FacturaNumero",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@FacturaFecha",SqlDbType.DateTime,8,0} ,
          new Object[] {"@ClienteId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000217 ;
          prmT000217 = new Object[] {
          new Object[] {"@ClienteId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000220 ;
          prmT000220 = new Object[] {
          } ;
          Object[] prmT000221 ;
          prmT000221 = new Object[] {
          new Object[] {"@FacturaNumero",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ArticuloCodigo",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000222 ;
          prmT000222 = new Object[] {
          new Object[] {"@FacturaNumero",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ArticuloCodigo",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00023 ;
          prmT00023 = new Object[] {
          new Object[] {"@FacturaNumero",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ArticuloCodigo",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00022 ;
          prmT00022 = new Object[] {
          new Object[] {"@FacturaNumero",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ArticuloCodigo",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000223 ;
          prmT000223 = new Object[] {
          new Object[] {"@FacturaNumero",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ArticuloCodigo",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ArticuloCantidad",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ArticuloPrecio",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000224 ;
          prmT000224 = new Object[] {
          new Object[] {"@ArticuloCantidad",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ArticuloPrecio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@FacturaNumero",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ArticuloCodigo",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000225 ;
          prmT000225 = new Object[] {
          new Object[] {"@FacturaNumero",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ArticuloCodigo",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000226 ;
          prmT000226 = new Object[] {
          new Object[] {"@FacturaNumero",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000219 ;
          prmT000219 = new Object[] {
          new Object[] {"@FacturaNumero",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T00022", "SELECT [FacturaNumero], [ArticuloCodigo], [ArticuloCantidad], [ArticuloPrecio] FROM [FacturaArticulo] WITH (UPDLOCK) WHERE [FacturaNumero] = @FacturaNumero AND [ArticuloCodigo] = @ArticuloCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00022,1,0,true,false )
             ,new CursorDef("T00023", "SELECT [FacturaNumero], [ArticuloCodigo], [ArticuloCantidad], [ArticuloPrecio] FROM [FacturaArticulo] WITH (NOLOCK) WHERE [FacturaNumero] = @FacturaNumero AND [ArticuloCodigo] = @ArticuloCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00023,1,0,true,false )
             ,new CursorDef("T00024", "SELECT [ClienteId], [FacturaNumero], [FacturaFecha] FROM [Cliente] WITH (UPDLOCK) WHERE [ClienteId] = @ClienteId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00024,1,0,true,false )
             ,new CursorDef("T00025", "SELECT [ClienteId], [FacturaNumero], [FacturaFecha] FROM [Cliente] WITH (NOLOCK) WHERE [ClienteId] = @ClienteId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00025,1,0,true,false )
             ,new CursorDef("T00027", "SELECT COALESCE( T1.[FacturaTotal], 0) AS FacturaTotal FROM (SELECT SUM([ArticuloPrecio] * CAST([ArticuloCantidad] AS decimal( 14, 10))) AS FacturaTotal, [FacturaNumero] FROM [FacturaArticulo] WITH (UPDLOCK) GROUP BY [FacturaNumero] ) T1 WHERE T1.[FacturaNumero] = @FacturaNumero ",true, GxErrorMask.GX_NOMASK, false, this,prmT00027,1,0,true,false )
             ,new CursorDef("T00029", "SELECT TM1.[ClienteId], TM1.[FacturaNumero], TM1.[FacturaFecha], COALESCE( T2.[FacturaTotal], 0) AS FacturaTotal FROM ([Cliente] TM1 WITH (NOLOCK) LEFT JOIN (SELECT SUM([ArticuloPrecio] * CAST([ArticuloCantidad] AS decimal( 14, 10))) AS FacturaTotal, [FacturaNumero] FROM [FacturaArticulo] WITH (NOLOCK) GROUP BY [FacturaNumero] ) T2 ON T2.[FacturaNumero] = TM1.[FacturaNumero]) WHERE TM1.[ClienteId] = @ClienteId ORDER BY TM1.[ClienteId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00029,100,0,true,false )
             ,new CursorDef("T000211", "SELECT COALESCE( T1.[FacturaTotal], 0) AS FacturaTotal FROM (SELECT SUM([ArticuloPrecio] * CAST([ArticuloCantidad] AS decimal( 14, 10))) AS FacturaTotal, [FacturaNumero] FROM [FacturaArticulo] WITH (UPDLOCK) GROUP BY [FacturaNumero] ) T1 WHERE T1.[FacturaNumero] = @FacturaNumero ",true, GxErrorMask.GX_NOMASK, false, this,prmT000211,1,0,true,false )
             ,new CursorDef("T000212", "SELECT [ClienteId] FROM [Cliente] WITH (NOLOCK) WHERE [ClienteId] = @ClienteId  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000212,1,0,true,false )
             ,new CursorDef("T000213", "SELECT TOP 1 [ClienteId] FROM [Cliente] WITH (NOLOCK) WHERE ( [ClienteId] > @ClienteId) ORDER BY [ClienteId]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000213,1,0,true,true )
             ,new CursorDef("T000214", "SELECT TOP 1 [ClienteId] FROM [Cliente] WITH (NOLOCK) WHERE ( [ClienteId] < @ClienteId) ORDER BY [ClienteId] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000214,1,0,true,true )
             ,new CursorDef("T000215", "INSERT INTO [Cliente]([FacturaNumero], [FacturaFecha], [ClienteNombre], [ClienteApellido], [ClienteFechaNacimiento]) VALUES(@FacturaNumero, @FacturaFecha, '', '', convert( DATETIME, '17530101', 112 )); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmT000215)
             ,new CursorDef("T000216", "UPDATE [Cliente] SET [FacturaNumero]=@FacturaNumero, [FacturaFecha]=@FacturaFecha  WHERE [ClienteId] = @ClienteId", GxErrorMask.GX_NOMASK,prmT000216)
             ,new CursorDef("T000217", "DELETE FROM [Cliente]  WHERE [ClienteId] = @ClienteId", GxErrorMask.GX_NOMASK,prmT000217)
             ,new CursorDef("T000219", "SELECT COALESCE( T1.[FacturaTotal], 0) AS FacturaTotal FROM (SELECT SUM([ArticuloPrecio] * CAST([ArticuloCantidad] AS decimal( 14, 10))) AS FacturaTotal, [FacturaNumero] FROM [FacturaArticulo] WITH (UPDLOCK) GROUP BY [FacturaNumero] ) T1 WHERE T1.[FacturaNumero] = @FacturaNumero ",true, GxErrorMask.GX_NOMASK, false, this,prmT000219,1,0,true,false )
             ,new CursorDef("T000220", "SELECT [ClienteId] FROM [Cliente] WITH (NOLOCK) ORDER BY [ClienteId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000220,100,0,true,false )
             ,new CursorDef("T000221", "SELECT [FacturaNumero], [ArticuloCodigo], [ArticuloCantidad], [ArticuloPrecio] FROM [FacturaArticulo] WITH (NOLOCK) WHERE [FacturaNumero] = @FacturaNumero and [ArticuloCodigo] = @ArticuloCodigo ORDER BY [FacturaNumero], [ArticuloCodigo] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000221,11,0,true,false )
             ,new CursorDef("T000222", "SELECT [FacturaNumero], [ArticuloCodigo] FROM [FacturaArticulo] WITH (NOLOCK) WHERE [FacturaNumero] = @FacturaNumero AND [ArticuloCodigo] = @ArticuloCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000222,1,0,true,false )
             ,new CursorDef("T000223", "INSERT INTO [FacturaArticulo]([FacturaNumero], [ArticuloCodigo], [ArticuloCantidad], [ArticuloPrecio]) VALUES(@FacturaNumero, @ArticuloCodigo, @ArticuloCantidad, @ArticuloPrecio)", GxErrorMask.GX_NOMASK,prmT000223)
             ,new CursorDef("T000224", "UPDATE [FacturaArticulo] SET [ArticuloCantidad]=@ArticuloCantidad, [ArticuloPrecio]=@ArticuloPrecio  WHERE [FacturaNumero] = @FacturaNumero AND [ArticuloCodigo] = @ArticuloCodigo", GxErrorMask.GX_NOMASK,prmT000224)
             ,new CursorDef("T000225", "DELETE FROM [FacturaArticulo]  WHERE [FacturaNumero] = @FacturaNumero AND [ArticuloCodigo] = @ArticuloCodigo", GxErrorMask.GX_NOMASK,prmT000225)
             ,new CursorDef("T000226", "SELECT [FacturaNumero], [ArticuloCodigo] FROM [FacturaArticulo] WITH (NOLOCK) WHERE [FacturaNumero] = @FacturaNumero ORDER BY [FacturaNumero], [ArticuloCodigo] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000226,11,0,true,false )
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
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                return;
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((DateTime[]) buf[2])[0] = rslt.getGXDate(3) ;
                return;
             case 3 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((DateTime[]) buf[2])[0] = rslt.getGXDate(3) ;
                return;
             case 4 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 5 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((DateTime[]) buf[3])[0] = rslt.getGXDate(3) ;
                ((short[]) buf[4])[0] = rslt.getShort(4) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(4);
                return;
             case 6 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 7 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 8 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 9 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 10 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 13 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 14 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 15 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                return;
             case 16 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
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
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(1, (short)parms[1]);
                }
                stmt.SetParameter(2, (short)parms[2]);
                return;
             case 1 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(1, (short)parms[1]);
                }
                stmt.SetParameter(2, (short)parms[2]);
                return;
             case 2 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 3 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 4 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(1, (short)parms[1]);
                }
                return;
             case 5 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 6 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(1, (short)parms[1]);
                }
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
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(1, (short)parms[1]);
                }
                stmt.SetParameter(2, (DateTime)parms[2]);
                return;
             case 11 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(1, (short)parms[1]);
                }
                stmt.SetParameter(2, (DateTime)parms[2]);
                stmt.SetParameter(3, (short)parms[3]);
                return;
             case 12 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 13 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(1, (short)parms[1]);
                }
                return;
             case 15 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(1, (short)parms[1]);
                }
                stmt.SetParameter(2, (short)parms[2]);
                return;
             case 16 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(1, (short)parms[1]);
                }
                stmt.SetParameter(2, (short)parms[2]);
                return;
             case 17 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(1, (short)parms[1]);
                }
                stmt.SetParameter(2, (short)parms[2]);
                stmt.SetParameter(3, (short)parms[3]);
                stmt.SetParameter(4, (short)parms[4]);
                return;
             case 18 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                if ( (bool)parms[2] )
                {
                   stmt.setNull( 3 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(3, (short)parms[3]);
                }
                stmt.SetParameter(4, (short)parms[4]);
                return;
             case 19 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(1, (short)parms[1]);
                }
                stmt.SetParameter(2, (short)parms[2]);
                return;
             case 20 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(1, (short)parms[1]);
                }
                return;
       }
    }

 }

}
