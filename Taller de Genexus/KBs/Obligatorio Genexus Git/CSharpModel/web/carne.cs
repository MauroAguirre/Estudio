/*
               File: Carne
        Description: Carne
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 4/12/2019 5:22:31.8
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
   public class carne : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_11") == 0 )
         {
            A5SocioId = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5SocioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A5SocioId), 4, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_11( A5SocioId) ;
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
               AV7CarneId = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7CarneId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7CarneId), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vCARNEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7CarneId), "ZZZ9"), context));
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
            Form.Meta.addItem("description", "Carne", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtCarneFechaIngreso_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("Carmine");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public carne( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public carne( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( String aP0_Gx_mode ,
                           short aP1_CarneId )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV7CarneId = aP1_CarneId;
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
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "Carne", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_Carne.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "", bttBtn_first_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_first_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Carne.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "", bttBtn_previous_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_previous_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_Carne.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", "", bttBtn_next_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_next_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_Carne.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", "", bttBtn_last_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_last_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Carne.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Select", bttBtn_select_Jsonclick, 5, "Select", "", StyleString, ClassString, bttBtn_select_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "", 2, "HLP_Carne.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtCarneId_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtCarneId_Internalname, "Id", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtCarneId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A4CarneId), 4, 0, ".", "")), ((edtCarneId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A4CarneId), "ZZZ9")) : context.localUtil.Format( (decimal)(A4CarneId), "ZZZ9")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtCarneId_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtCarneId_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "AutoNumero", "right", false, "HLP_Carne.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtCarneFechaIngreso_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtCarneFechaIngreso_Internalname, "Fecha Ingreso", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtCarneFechaIngreso_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtCarneFechaIngreso_Internalname, context.localUtil.Format(A22CarneFechaIngreso, "99/99/99"), context.localUtil.Format( A22CarneFechaIngreso, "99/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 8,'MDY',0,12,'eng',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,39);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtCarneFechaIngreso_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtCarneFechaIngreso_Enabled, 0, "text", "", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Carne.htm");
            GxWebStd.gx_bitmap( context, edtCarneFechaIngreso_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtCarneFechaIngreso_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_Carne.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtSocioId_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtSocioId_Internalname, "Socio Id", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtSocioId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A5SocioId), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A5SocioId), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,44);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtSocioId_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtSocioId_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Carne.htm");
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgprompt_5_Internalname, sImgUrl, imgprompt_5_Link, "", "", context.GetTheme( ), imgprompt_5_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_Carne.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirm", bttBtn_enter_Jsonclick, 5, "Confirm", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_Carne.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 51,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancel", bttBtn_cancel_Jsonclick, 1, "Cancel", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Carne.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Delete", bttBtn_delete_Jsonclick, 5, "Delete", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_Carne.htm");
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
               A4CarneId = (short)(context.localUtil.CToN( cgiGet( edtCarneId_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4CarneId", StringUtil.LTrim( StringUtil.Str( (decimal)(A4CarneId), 4, 0)));
               if ( context.localUtil.VCDate( cgiGet( edtCarneFechaIngreso_Internalname), 1) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Carne Fecha Ingreso"}), 1, "CARNEFECHAINGRESO");
                  AnyError = 1;
                  GX_FocusControl = edtCarneFechaIngreso_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A22CarneFechaIngreso = DateTime.MinValue;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22CarneFechaIngreso", context.localUtil.Format(A22CarneFechaIngreso, "99/99/99"));
               }
               else
               {
                  A22CarneFechaIngreso = context.localUtil.CToD( cgiGet( edtCarneFechaIngreso_Internalname), 1);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22CarneFechaIngreso", context.localUtil.Format(A22CarneFechaIngreso, "99/99/99"));
               }
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
               /* Read saved values. */
               Z4CarneId = (short)(context.localUtil.CToN( cgiGet( "Z4CarneId"), ".", ","));
               Z22CarneFechaIngreso = context.localUtil.CToD( cgiGet( "Z22CarneFechaIngreso"), 0);
               Z5SocioId = (short)(context.localUtil.CToN( cgiGet( "Z5SocioId"), ".", ","));
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ","));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ".", ","));
               Gx_mode = cgiGet( "Mode");
               N5SocioId = (short)(context.localUtil.CToN( cgiGet( "N5SocioId"), ".", ","));
               AV7CarneId = (short)(context.localUtil.CToN( cgiGet( "vCARNEID"), ".", ","));
               AV11Insert_SocioId = (short)(context.localUtil.CToN( cgiGet( "vINSERT_SOCIOID"), ".", ","));
               AV13Pgmname = cgiGet( "vPGMNAME");
               Gx_mode = cgiGet( "vMODE");
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               forbiddenHiddens = "hsh" + "Carne";
               A4CarneId = (short)(context.localUtil.CToN( cgiGet( edtCarneId_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4CarneId", StringUtil.LTrim( StringUtil.Str( (decimal)(A4CarneId), 4, 0)));
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A4CarneId), "ZZZ9");
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV11Insert_SocioId), "ZZZ9");
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( A4CarneId != Z4CarneId ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
               {
                  GXUtil.WriteLog("carne:[SecurityCheckFailed value for]"+"CarneId:"+context.localUtil.Format( (decimal)(A4CarneId), "ZZZ9"));
                  GXUtil.WriteLog("carne:[SecurityCheckFailed value for]"+"Insert_SocioId:"+context.localUtil.Format( (decimal)(AV11Insert_SocioId), "ZZZ9"));
                  GXUtil.WriteLog("carne:[SecurityCheckFailed value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
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
                  A4CarneId = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4CarneId", StringUtil.LTrim( StringUtil.Str( (decimal)(A4CarneId), 4, 0)));
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
                     sMode5 = Gx_mode;
                     Gx_mode = "UPD";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     Gx_mode = sMode5;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound5 == 1 )
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
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert", ""), 1, "CARNEID");
                        AnyError = 1;
                        GX_FocusControl = edtCarneId_Internalname;
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
               InitAll035( ) ;
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
            DisableAttributes035( ) ;
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
         BeforeValidate035( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls035( ) ;
            }
            else
            {
               CheckExtendedTable035( ) ;
               CloseExtendedTableCursors035( ) ;
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
         AV9TrnContext.FromXml(AV10WebSession.Get("TrnContext"), null, "TransactionContext", "ObligatorioGenexusGit");
         AV11Insert_SocioId = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11Insert_SocioId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11Insert_SocioId), 4, 0)));
         if ( ( StringUtil.StrCmp(AV9TrnContext.gxTpr_Transactionname, AV13Pgmname) == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) )
         {
            AV14GXV1 = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14GXV1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14GXV1), 8, 0)));
            while ( AV14GXV1 <= AV9TrnContext.gxTpr_Attributes.Count )
            {
               AV12TrnContextAtt = ((SdtTransactionContext_Attribute)AV9TrnContext.gxTpr_Attributes.Item(AV14GXV1));
               if ( StringUtil.StrCmp(AV12TrnContextAtt.gxTpr_Attributename, "SocioId") == 0 )
               {
                  AV11Insert_SocioId = (short)(NumberUtil.Val( AV12TrnContextAtt.gxTpr_Attributevalue, "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11Insert_SocioId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11Insert_SocioId), 4, 0)));
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
            CallWebObject(formatLink("wwcarne.aspx") );
            context.wjLocDisableFrm = 1;
         }
         context.setWebReturnParms(new Object[] {});
         context.setWebReturnParmsMetadata(new Object[] {});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      protected void ZM035( short GX_JID )
      {
         if ( ( GX_JID == 9 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z22CarneFechaIngreso = T00033_A22CarneFechaIngreso[0];
               Z5SocioId = T00033_A5SocioId[0];
            }
            else
            {
               Z22CarneFechaIngreso = A22CarneFechaIngreso;
               Z5SocioId = A5SocioId;
            }
         }
         if ( GX_JID == -9 )
         {
            Z4CarneId = A4CarneId;
            Z22CarneFechaIngreso = A22CarneFechaIngreso;
            Z5SocioId = A5SocioId;
         }
      }

      protected void standaloneNotModal( )
      {
         edtCarneId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCarneId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCarneId_Enabled), 5, 0)), true);
         imgprompt_5_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0040.aspx"+"',["+"{Ctrl:gx.dom.el('"+"SOCIOID"+"'), id:'"+"SOCIOID"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"false"+");");
         edtCarneId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCarneId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCarneId_Enabled), 5, 0)), true);
         bttBtn_delete_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Enabled), 5, 0)), true);
         if ( ! (0==AV7CarneId) )
         {
            A4CarneId = AV7CarneId;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4CarneId", StringUtil.LTrim( StringUtil.Str( (decimal)(A4CarneId), 4, 0)));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV11Insert_SocioId) )
         {
            edtSocioId_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSocioId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSocioId_Enabled), 5, 0)), true);
         }
         else
         {
            edtSocioId_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSocioId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSocioId_Enabled), 5, 0)), true);
         }
      }

      protected void standaloneModal( )
      {
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV11Insert_SocioId) )
         {
            A5SocioId = AV11Insert_SocioId;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5SocioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A5SocioId), 4, 0)));
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
            AV13Pgmname = "Carne";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13Pgmname", AV13Pgmname);
         }
      }

      protected void Load035( )
      {
         /* Using cursor T00035 */
         pr_default.execute(3, new Object[] {A4CarneId});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound5 = 1;
            A22CarneFechaIngreso = T00035_A22CarneFechaIngreso[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22CarneFechaIngreso", context.localUtil.Format(A22CarneFechaIngreso, "99/99/99"));
            A5SocioId = T00035_A5SocioId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5SocioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A5SocioId), 4, 0)));
            ZM035( -9) ;
         }
         pr_default.close(3);
         OnLoadActions035( ) ;
      }

      protected void OnLoadActions035( )
      {
         AV13Pgmname = "Carne";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13Pgmname", AV13Pgmname);
      }

      protected void CheckExtendedTable035( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
         AV13Pgmname = "Carne";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13Pgmname", AV13Pgmname);
         /* Using cursor T00036 */
         pr_default.execute(4, new Object[] {A5SocioId, A4CarneId});
         if ( (pr_default.getStatus(4) != 101) )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_1004", new   object[]  {"Socio Id"}), 1, "SOCIOID");
            AnyError = 1;
            GX_FocusControl = edtSocioId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         pr_default.close(4);
         if ( ! ( (DateTime.MinValue==A22CarneFechaIngreso) || ( A22CarneFechaIngreso >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("Field Carne Fecha Ingreso is out of range", "OutOfRange", 1, "CARNEFECHAINGRESO");
            AnyError = 1;
            GX_FocusControl = edtCarneFechaIngreso_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         /* Using cursor T00034 */
         pr_default.execute(2, new Object[] {A5SocioId});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("No matching 'Socio'.", "ForeignKeyNotFound", 1, "SOCIOID");
            AnyError = 1;
            GX_FocusControl = edtSocioId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         pr_default.close(2);
      }

      protected void CloseExtendedTableCursors035( )
      {
         pr_default.close(2);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_11( short A5SocioId )
      {
         /* Using cursor T00037 */
         pr_default.execute(5, new Object[] {A5SocioId});
         if ( (pr_default.getStatus(5) == 101) )
         {
            GX_msglist.addItem("No matching 'Socio'.", "ForeignKeyNotFound", 1, "SOCIOID");
            AnyError = 1;
            GX_FocusControl = edtSocioId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(5) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(5);
      }

      protected void GetKey035( )
      {
         /* Using cursor T00038 */
         pr_default.execute(6, new Object[] {A4CarneId});
         if ( (pr_default.getStatus(6) != 101) )
         {
            RcdFound5 = 1;
         }
         else
         {
            RcdFound5 = 0;
         }
         pr_default.close(6);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00033 */
         pr_default.execute(1, new Object[] {A4CarneId});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM035( 9) ;
            RcdFound5 = 1;
            A4CarneId = T00033_A4CarneId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4CarneId", StringUtil.LTrim( StringUtil.Str( (decimal)(A4CarneId), 4, 0)));
            A22CarneFechaIngreso = T00033_A22CarneFechaIngreso[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22CarneFechaIngreso", context.localUtil.Format(A22CarneFechaIngreso, "99/99/99"));
            A5SocioId = T00033_A5SocioId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5SocioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A5SocioId), 4, 0)));
            Z4CarneId = A4CarneId;
            sMode5 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load035( ) ;
            if ( AnyError == 1 )
            {
               RcdFound5 = 0;
               InitializeNonKey035( ) ;
            }
            Gx_mode = sMode5;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound5 = 0;
            InitializeNonKey035( ) ;
            sMode5 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal( ) ;
            Gx_mode = sMode5;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey035( ) ;
         if ( RcdFound5 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound5 = 0;
         /* Using cursor T00039 */
         pr_default.execute(7, new Object[] {A4CarneId});
         if ( (pr_default.getStatus(7) != 101) )
         {
            while ( (pr_default.getStatus(7) != 101) && ( ( T00039_A4CarneId[0] < A4CarneId ) ) )
            {
               pr_default.readNext(7);
            }
            if ( (pr_default.getStatus(7) != 101) && ( ( T00039_A4CarneId[0] > A4CarneId ) ) )
            {
               A4CarneId = T00039_A4CarneId[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4CarneId", StringUtil.LTrim( StringUtil.Str( (decimal)(A4CarneId), 4, 0)));
               RcdFound5 = 1;
            }
         }
         pr_default.close(7);
      }

      protected void move_previous( )
      {
         RcdFound5 = 0;
         /* Using cursor T000310 */
         pr_default.execute(8, new Object[] {A4CarneId});
         if ( (pr_default.getStatus(8) != 101) )
         {
            while ( (pr_default.getStatus(8) != 101) && ( ( T000310_A4CarneId[0] > A4CarneId ) ) )
            {
               pr_default.readNext(8);
            }
            if ( (pr_default.getStatus(8) != 101) && ( ( T000310_A4CarneId[0] < A4CarneId ) ) )
            {
               A4CarneId = T000310_A4CarneId[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4CarneId", StringUtil.LTrim( StringUtil.Str( (decimal)(A4CarneId), 4, 0)));
               RcdFound5 = 1;
            }
         }
         pr_default.close(8);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey035( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtCarneFechaIngreso_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert035( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound5 == 1 )
            {
               if ( A4CarneId != Z4CarneId )
               {
                  A4CarneId = Z4CarneId;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4CarneId", StringUtil.LTrim( StringUtil.Str( (decimal)(A4CarneId), 4, 0)));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "CARNEID");
                  AnyError = 1;
                  GX_FocusControl = edtCarneId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtCarneFechaIngreso_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Update record */
                  Update035( ) ;
                  GX_FocusControl = edtCarneFechaIngreso_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A4CarneId != Z4CarneId )
               {
                  /* Insert record */
                  GX_FocusControl = edtCarneFechaIngreso_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert035( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "CARNEID");
                     AnyError = 1;
                     GX_FocusControl = edtCarneId_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     /* Insert record */
                     GX_FocusControl = edtCarneFechaIngreso_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert035( ) ;
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
         if ( A4CarneId != Z4CarneId )
         {
            A4CarneId = Z4CarneId;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4CarneId", StringUtil.LTrim( StringUtil.Str( (decimal)(A4CarneId), 4, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "CARNEID");
            AnyError = 1;
            GX_FocusControl = edtCarneId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtCarneFechaIngreso_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency035( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00032 */
            pr_default.execute(0, new Object[] {A4CarneId});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Carne"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( Z22CarneFechaIngreso != T00032_A22CarneFechaIngreso[0] ) || ( Z5SocioId != T00032_A5SocioId[0] ) )
            {
               if ( Z22CarneFechaIngreso != T00032_A22CarneFechaIngreso[0] )
               {
                  GXUtil.WriteLog("carne:[seudo value changed for attri]"+"CarneFechaIngreso");
                  GXUtil.WriteLogRaw("Old: ",Z22CarneFechaIngreso);
                  GXUtil.WriteLogRaw("Current: ",T00032_A22CarneFechaIngreso[0]);
               }
               if ( Z5SocioId != T00032_A5SocioId[0] )
               {
                  GXUtil.WriteLog("carne:[seudo value changed for attri]"+"SocioId");
                  GXUtil.WriteLogRaw("Old: ",Z5SocioId);
                  GXUtil.WriteLogRaw("Current: ",T00032_A5SocioId[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Carne"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert035( )
      {
         BeforeValidate035( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable035( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM035( 0) ;
            CheckOptimisticConcurrency035( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm035( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert035( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000311 */
                     pr_default.execute(9, new Object[] {A22CarneFechaIngreso, A5SocioId});
                     A4CarneId = T000311_A4CarneId[0];
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4CarneId", StringUtil.LTrim( StringUtil.Str( (decimal)(A4CarneId), 4, 0)));
                     pr_default.close(9);
                     dsDefault.SmartCacheProvider.SetUpdated("Carne") ;
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
               Load035( ) ;
            }
            EndLevel035( ) ;
         }
         CloseExtendedTableCursors035( ) ;
      }

      protected void Update035( )
      {
         BeforeValidate035( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable035( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency035( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm035( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate035( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000312 */
                     pr_default.execute(10, new Object[] {A22CarneFechaIngreso, A5SocioId, A4CarneId});
                     pr_default.close(10);
                     dsDefault.SmartCacheProvider.SetUpdated("Carne") ;
                     if ( (pr_default.getStatus(10) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Carne"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate035( ) ;
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
            EndLevel035( ) ;
         }
         CloseExtendedTableCursors035( ) ;
      }

      protected void DeferredUpdate035( )
      {
      }

      protected void delete( )
      {
         BeforeValidate035( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency035( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls035( ) ;
            AfterConfirm035( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete035( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000313 */
                  pr_default.execute(11, new Object[] {A4CarneId});
                  pr_default.close(11);
                  dsDefault.SmartCacheProvider.SetUpdated("Carne") ;
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
         sMode5 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel035( ) ;
         Gx_mode = sMode5;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls035( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV13Pgmname = "Carne";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13Pgmname", AV13Pgmname);
         }
      }

      protected void EndLevel035( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete035( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(1);
            context.CommitDataStores("carne",pr_default);
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
            context.RollbackDataStores("carne",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart035( )
      {
         /* Scan By routine */
         /* Using cursor T000314 */
         pr_default.execute(12);
         RcdFound5 = 0;
         if ( (pr_default.getStatus(12) != 101) )
         {
            RcdFound5 = 1;
            A4CarneId = T000314_A4CarneId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4CarneId", StringUtil.LTrim( StringUtil.Str( (decimal)(A4CarneId), 4, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext035( )
      {
         /* Scan next routine */
         pr_default.readNext(12);
         RcdFound5 = 0;
         if ( (pr_default.getStatus(12) != 101) )
         {
            RcdFound5 = 1;
            A4CarneId = T000314_A4CarneId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4CarneId", StringUtil.LTrim( StringUtil.Str( (decimal)(A4CarneId), 4, 0)));
         }
      }

      protected void ScanEnd035( )
      {
         pr_default.close(12);
      }

      protected void AfterConfirm035( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert035( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate035( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete035( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete035( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate035( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes035( )
      {
         edtCarneId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCarneId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCarneId_Enabled), 5, 0)), true);
         edtCarneFechaIngreso_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCarneFechaIngreso_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCarneFechaIngreso_Enabled), 5, 0)), true);
         edtSocioId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSocioId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSocioId_Enabled), 5, 0)), true);
      }

      protected void send_integrity_lvl_hashes035( )
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
         context.AddJavascriptSource("gxcfg.js", "?2019412522327", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("carne.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7CarneId)+"\">") ;
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
         forbiddenHiddens = "hsh" + "Carne";
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A4CarneId), "ZZZ9");
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV11Insert_SocioId), "ZZZ9");
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("carne:[SendSecurityCheck value for]"+"CarneId:"+context.localUtil.Format( (decimal)(A4CarneId), "ZZZ9"));
         GXUtil.WriteLog("carne:[SendSecurityCheck value for]"+"Insert_SocioId:"+context.localUtil.Format( (decimal)(AV11Insert_SocioId), "ZZZ9"));
         GXUtil.WriteLog("carne:[SendSecurityCheck value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z4CarneId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z4CarneId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z22CarneFechaIngreso", context.localUtil.DToC( Z22CarneFechaIngreso, 0, "/"));
         GxWebStd.gx_hidden_field( context, "Z5SocioId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z5SocioId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_Mode", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GxWebStd.gx_hidden_field( context, "N5SocioId", StringUtil.LTrim( StringUtil.NToC( (decimal)(A5SocioId), 4, 0, ".", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vTRNCONTEXT", AV9TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vTRNCONTEXT", AV9TrnContext);
         }
         GxWebStd.gx_hidden_field( context, "vCARNEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7CarneId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vCARNEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7CarneId), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vINSERT_SOCIOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11Insert_SocioId), 4, 0, ".", "")));
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
         return formatLink("carne.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7CarneId) ;
      }

      public override String GetPgmname( )
      {
         return "Carne" ;
      }

      public override String GetPgmdesc( )
      {
         return "Carne" ;
      }

      protected void InitializeNonKey035( )
      {
         A5SocioId = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5SocioId", StringUtil.LTrim( StringUtil.Str( (decimal)(A5SocioId), 4, 0)));
         A22CarneFechaIngreso = DateTime.MinValue;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22CarneFechaIngreso", context.localUtil.Format(A22CarneFechaIngreso, "99/99/99"));
         Z22CarneFechaIngreso = DateTime.MinValue;
         Z5SocioId = 0;
      }

      protected void InitAll035( )
      {
         A4CarneId = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4CarneId", StringUtil.LTrim( StringUtil.Str( (decimal)(A4CarneId), 4, 0)));
         InitializeNonKey035( ) ;
      }

      protected void StandaloneModalInsert( )
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20194125223213", true);
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
         context.AddJavascriptSource("carne.js", "?20194125223214", false);
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
         edtCarneId_Internalname = "CARNEID";
         edtCarneFechaIngreso_Internalname = "CARNEFECHAINGRESO";
         edtSocioId_Internalname = "SOCIOID";
         divFormcontainer_Internalname = "FORMCONTAINER";
         bttBtn_enter_Internalname = "BTN_ENTER";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         bttBtn_delete_Internalname = "BTN_DELETE";
         divMaintable_Internalname = "MAINTABLE";
         Form.Internalname = "FORM";
         imgprompt_5_Internalname = "PROMPT_5";
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
         Form.Caption = "Carne";
         bttBtn_delete_Enabled = 0;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         imgprompt_5_Visible = 1;
         imgprompt_5_Link = "";
         edtSocioId_Jsonclick = "";
         edtSocioId_Enabled = 1;
         edtCarneFechaIngreso_Jsonclick = "";
         edtCarneFechaIngreso_Enabled = 1;
         edtCarneId_Jsonclick = "";
         edtCarneId_Enabled = 0;
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

      public void Valid_Socioid( short GX_Parm1 ,
                                 short GX_Parm2 )
      {
         A5SocioId = GX_Parm1;
         A4CarneId = GX_Parm2;
         /* Using cursor T000315 */
         pr_default.execute(13, new Object[] {A5SocioId});
         if ( (pr_default.getStatus(13) == 101) )
         {
            GX_msglist.addItem("No matching 'Socio'.", "ForeignKeyNotFound", 1, "SOCIOID");
            AnyError = 1;
            GX_FocusControl = edtSocioId_Internalname;
         }
         pr_default.close(13);
         /* Using cursor T000316 */
         pr_default.execute(14, new Object[] {A5SocioId, A4CarneId});
         if ( (pr_default.getStatus(14) != 101) )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_1004", new   object[]  {"Socio Id"}), 1, "SOCIOID");
            AnyError = 1;
            GX_FocusControl = edtSocioId_Internalname;
         }
         pr_default.close(14);
         dynload_actions( ) ;
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
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7CarneId',fld:'vCARNEID',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7CarneId',fld:'vCARNEID',pic:'ZZZ9',hsh:true},{av:'A4CarneId',fld:'CARNEID',pic:'ZZZ9'},{av:'AV11Insert_SocioId',fld:'vINSERT_SOCIOID',pic:'ZZZ9'}]");
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
         pr_default.close(13);
      }

      public override void initialize( )
      {
         sPrefix = "";
         wcpOGx_mode = "";
         Z22CarneFechaIngreso = DateTime.MinValue;
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
         A22CarneFechaIngreso = DateTime.MinValue;
         sImgUrl = "";
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         AV13Pgmname = "";
         forbiddenHiddens = "";
         hsh = "";
         sMode5 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV9TrnContext = new SdtTransactionContext(context);
         AV10WebSession = context.GetSession();
         AV12TrnContextAtt = new SdtTransactionContext_Attribute(context);
         T00035_A4CarneId = new short[1] ;
         T00035_A22CarneFechaIngreso = new DateTime[] {DateTime.MinValue} ;
         T00035_A5SocioId = new short[1] ;
         T00036_A5SocioId = new short[1] ;
         T00034_A5SocioId = new short[1] ;
         T00037_A5SocioId = new short[1] ;
         T00038_A4CarneId = new short[1] ;
         T00033_A4CarneId = new short[1] ;
         T00033_A22CarneFechaIngreso = new DateTime[] {DateTime.MinValue} ;
         T00033_A5SocioId = new short[1] ;
         T00039_A4CarneId = new short[1] ;
         T000310_A4CarneId = new short[1] ;
         T00032_A4CarneId = new short[1] ;
         T00032_A22CarneFechaIngreso = new DateTime[] {DateTime.MinValue} ;
         T00032_A5SocioId = new short[1] ;
         T000311_A4CarneId = new short[1] ;
         T000314_A4CarneId = new short[1] ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         T000315_A5SocioId = new short[1] ;
         T000316_A5SocioId = new short[1] ;
         isValidOutput = new GxUnknownObjectCollection();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.carne__default(),
            new Object[][] {
                new Object[] {
               T00032_A4CarneId, T00032_A22CarneFechaIngreso, T00032_A5SocioId
               }
               , new Object[] {
               T00033_A4CarneId, T00033_A22CarneFechaIngreso, T00033_A5SocioId
               }
               , new Object[] {
               T00034_A5SocioId
               }
               , new Object[] {
               T00035_A4CarneId, T00035_A22CarneFechaIngreso, T00035_A5SocioId
               }
               , new Object[] {
               T00036_A5SocioId
               }
               , new Object[] {
               T00037_A5SocioId
               }
               , new Object[] {
               T00038_A4CarneId
               }
               , new Object[] {
               T00039_A4CarneId
               }
               , new Object[] {
               T000310_A4CarneId
               }
               , new Object[] {
               T000311_A4CarneId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000314_A4CarneId
               }
               , new Object[] {
               T000315_A5SocioId
               }
               , new Object[] {
               T000316_A5SocioId
               }
            }
         );
         AV13Pgmname = "Carne";
      }

      private short wcpOAV7CarneId ;
      private short Z4CarneId ;
      private short Z5SocioId ;
      private short N5SocioId ;
      private short GxWebError ;
      private short A5SocioId ;
      private short AV7CarneId ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short A4CarneId ;
      private short AV11Insert_SocioId ;
      private short RcdFound5 ;
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
      private int edtCarneId_Enabled ;
      private int edtCarneFechaIngreso_Enabled ;
      private int edtSocioId_Enabled ;
      private int imgprompt_5_Visible ;
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
      private String edtCarneFechaIngreso_Internalname ;
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
      private String edtCarneId_Internalname ;
      private String edtCarneId_Jsonclick ;
      private String edtCarneFechaIngreso_Jsonclick ;
      private String edtSocioId_Internalname ;
      private String edtSocioId_Jsonclick ;
      private String sImgUrl ;
      private String imgprompt_5_Internalname ;
      private String imgprompt_5_Link ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String AV13Pgmname ;
      private String forbiddenHiddens ;
      private String hsh ;
      private String sMode5 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private DateTime Z22CarneFechaIngreso ;
      private DateTime A22CarneFechaIngreso ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool returnInSub ;
      private IGxSession AV10WebSession ;
      private GxUnknownObjectCollection isValidOutput ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] T00035_A4CarneId ;
      private DateTime[] T00035_A22CarneFechaIngreso ;
      private short[] T00035_A5SocioId ;
      private short[] T00036_A5SocioId ;
      private short[] T00034_A5SocioId ;
      private short[] T00037_A5SocioId ;
      private short[] T00038_A4CarneId ;
      private short[] T00033_A4CarneId ;
      private DateTime[] T00033_A22CarneFechaIngreso ;
      private short[] T00033_A5SocioId ;
      private short[] T00039_A4CarneId ;
      private short[] T000310_A4CarneId ;
      private short[] T00032_A4CarneId ;
      private DateTime[] T00032_A22CarneFechaIngreso ;
      private short[] T00032_A5SocioId ;
      private short[] T000311_A4CarneId ;
      private short[] T000314_A4CarneId ;
      private short[] T000315_A5SocioId ;
      private short[] T000316_A5SocioId ;
      private GXWebForm Form ;
      private SdtTransactionContext AV9TrnContext ;
      private SdtTransactionContext_Attribute AV12TrnContextAtt ;
   }

   public class carne__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmT00035 ;
          prmT00035 = new Object[] {
          new Object[] {"@CarneId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00036 ;
          prmT00036 = new Object[] {
          new Object[] {"@SocioId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CarneId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00034 ;
          prmT00034 = new Object[] {
          new Object[] {"@SocioId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00037 ;
          prmT00037 = new Object[] {
          new Object[] {"@SocioId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00038 ;
          prmT00038 = new Object[] {
          new Object[] {"@CarneId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00033 ;
          prmT00033 = new Object[] {
          new Object[] {"@CarneId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00039 ;
          prmT00039 = new Object[] {
          new Object[] {"@CarneId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000310 ;
          prmT000310 = new Object[] {
          new Object[] {"@CarneId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00032 ;
          prmT00032 = new Object[] {
          new Object[] {"@CarneId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000311 ;
          prmT000311 = new Object[] {
          new Object[] {"@CarneFechaIngreso",SqlDbType.DateTime,8,0} ,
          new Object[] {"@SocioId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000312 ;
          prmT000312 = new Object[] {
          new Object[] {"@CarneFechaIngreso",SqlDbType.DateTime,8,0} ,
          new Object[] {"@SocioId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CarneId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000313 ;
          prmT000313 = new Object[] {
          new Object[] {"@CarneId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000314 ;
          prmT000314 = new Object[] {
          } ;
          Object[] prmT000315 ;
          prmT000315 = new Object[] {
          new Object[] {"@SocioId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000316 ;
          prmT000316 = new Object[] {
          new Object[] {"@SocioId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CarneId",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T00032", "SELECT [CarneId], [CarneFechaIngreso], [SocioId] FROM [Carne] WITH (UPDLOCK) WHERE [CarneId] = @CarneId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00032,1,0,true,false )
             ,new CursorDef("T00033", "SELECT [CarneId], [CarneFechaIngreso], [SocioId] FROM [Carne] WITH (NOLOCK) WHERE [CarneId] = @CarneId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00033,1,0,true,false )
             ,new CursorDef("T00034", "SELECT [SocioId] FROM [Socio] WITH (NOLOCK) WHERE [SocioId] = @SocioId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00034,1,0,true,false )
             ,new CursorDef("T00035", "SELECT TM1.[CarneId], TM1.[CarneFechaIngreso], TM1.[SocioId] FROM [Carne] TM1 WITH (NOLOCK) WHERE TM1.[CarneId] = @CarneId ORDER BY TM1.[CarneId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00035,100,0,true,false )
             ,new CursorDef("T00036", "SELECT [SocioId] FROM [Carne] WITH (NOLOCK) WHERE ([SocioId] = @SocioId) AND (Not ( [CarneId] = @CarneId)) ",true, GxErrorMask.GX_NOMASK, false, this,prmT00036,1,0,true,false )
             ,new CursorDef("T00037", "SELECT [SocioId] FROM [Socio] WITH (NOLOCK) WHERE [SocioId] = @SocioId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00037,1,0,true,false )
             ,new CursorDef("T00038", "SELECT [CarneId] FROM [Carne] WITH (NOLOCK) WHERE [CarneId] = @CarneId  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00038,1,0,true,false )
             ,new CursorDef("T00039", "SELECT TOP 1 [CarneId] FROM [Carne] WITH (NOLOCK) WHERE ( [CarneId] > @CarneId) ORDER BY [CarneId]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00039,1,0,true,true )
             ,new CursorDef("T000310", "SELECT TOP 1 [CarneId] FROM [Carne] WITH (NOLOCK) WHERE ( [CarneId] < @CarneId) ORDER BY [CarneId] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000310,1,0,true,true )
             ,new CursorDef("T000311", "INSERT INTO [Carne]([CarneFechaIngreso], [SocioId]) VALUES(@CarneFechaIngreso, @SocioId); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmT000311)
             ,new CursorDef("T000312", "UPDATE [Carne] SET [CarneFechaIngreso]=@CarneFechaIngreso, [SocioId]=@SocioId  WHERE [CarneId] = @CarneId", GxErrorMask.GX_NOMASK,prmT000312)
             ,new CursorDef("T000313", "DELETE FROM [Carne]  WHERE [CarneId] = @CarneId", GxErrorMask.GX_NOMASK,prmT000313)
             ,new CursorDef("T000314", "SELECT [CarneId] FROM [Carne] WITH (NOLOCK) ORDER BY [CarneId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000314,100,0,true,false )
             ,new CursorDef("T000315", "SELECT [SocioId] FROM [Socio] WITH (NOLOCK) WHERE [SocioId] = @SocioId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000315,1,0,true,false )
             ,new CursorDef("T000316", "SELECT [SocioId] FROM [Carne] WITH (NOLOCK) WHERE ([SocioId] = @SocioId) AND (Not ( [CarneId] = @CarneId)) ",true, GxErrorMask.GX_NOMASK, false, this,prmT000316,1,0,true,false )
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
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                return;
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 3 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                return;
             case 4 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
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
             case 8 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 9 :
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
                stmt.SetParameter(2, (short)parms[1]);
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
                stmt.SetParameter(1, (DateTime)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 10 :
                stmt.SetParameter(1, (DateTime)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 11 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 13 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 14 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
       }
    }

 }

}
