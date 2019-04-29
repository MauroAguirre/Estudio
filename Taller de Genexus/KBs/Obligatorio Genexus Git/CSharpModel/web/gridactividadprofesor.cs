/*
               File: GridActividadProfesor
        Description: Grid Actividad Profesor
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 4/12/2019 19:20:53.95
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
   public class gridactividadprofesor : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gridactividadprofesor( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public gridactividadprofesor( IGxContext context )
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
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Grid2") == 0 )
            {
               nRC_GXsfl_32 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               nGXsfl_32_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
               sGXsfl_32_idx = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxnrGrid2_newrow( ) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Grid2") == 0 )
            {
               A1ActividadId = (short)(NumberUtil.Val( GetNextPar( ), "."));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid2_refresh( A1ActividadId) ;
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               context.GX_webresponse.AddString((String)(context.getJSONResponse( )));
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Grid1") == 0 )
            {
               nRC_GXsfl_9 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               nGXsfl_9_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
               sGXsfl_9_idx = GetNextPar( );
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
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid1_refresh( ) ;
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

      public override short ExecuteStartEvent( )
      {
         PA1G2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START1G2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?201941219205398", false);
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
         FormProcess = ((nGXWrapped==0) ? " data-HasEnter=\"false\" data-Skiponenter=\"false\"" : "");
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
         if ( nGXWrapped != 1 )
         {
            context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("gridactividadprofesor.aspx") +"\">") ;
            GxWebStd.gx_hidden_field( context, "_EventName", "");
            GxWebStd.gx_hidden_field( context, "_EventGridId", "");
            GxWebStd.gx_hidden_field( context, "_EventRowId", "");
            context.WriteHtmlText( "<input type=\"submit\" style=\"display:none\">") ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Class", "form-horizontal Form", true);
         }
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
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_9", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_9), 4, 0, ".", "")));
      }

      public override void RenderHtmlCloseForm( )
      {
         SendCloseFormHiddens( ) ;
         GxWebStd.gx_hidden_field( context, "GX_FocusControl", GX_FocusControl);
         SendAjaxEncryptionKey();
         SendSecurityToken((String)(sPrefix));
         SendComponentObjects();
         SendServerCommands();
         SendState();
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         if ( nGXWrapped != 1 )
         {
            context.WriteHtmlTextNl( "</form>") ;
         }
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
            WE1G2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT1G2( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return false ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("gridactividadprofesor.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "GridActividadProfesor" ;
      }

      public override String GetPgmdesc( )
      {
         return "Grid Actividad Profesor" ;
      }

      protected void WB1G0( )
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
            GxWebStd.gx_div_start( context, divMaintable_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblock1_Internalname, "Actividad", "", "", lblTextblock1_Jsonclick, "'"+""+"'"+",false,"+"'"+"E\\'ACTIVIDAD\\'."+"'", "", "TextBlock", 5, "", 1, 1, 0, "HLP_GridActividadProfesor.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /*  Grid Control  */
            Grid1Container.SetIsFreestyle(true);
            Grid1Container.SetWrapped(nGXWrapped);
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<div id=\""+"Grid1Container"+"DivS\" data-gxgridid=\"9\">") ;
               sStyleString = "";
               GxWebStd.gx_table_start( context, subGrid1_Internalname, subGrid1_Internalname, "", "FreeStyleGrid", 0, "", "", 1, 2, sStyleString, "", "", 0);
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
               Grid1Container.SetIsFreestyle(true);
               Grid1Container.SetWrapped(nGXWrapped);
               Grid1Container.AddObjectProperty("GridName", "Grid1");
               Grid1Container.AddObjectProperty("Header", subGrid1_Header);
               Grid1Container.AddObjectProperty("Class", StringUtil.RTrim( "FreeStyleGrid"));
               Grid1Container.AddObjectProperty("Class", "FreeStyleGrid");
               Grid1Container.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
               Grid1Container.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
               Grid1Container.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Backcolorstyle), 1, 0, ".", "")));
               Grid1Container.AddObjectProperty("CmpContext", "");
               Grid1Container.AddObjectProperty("InMasterPage", "false");
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", lblTextblock3_Caption);
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A1ActividadId), 4, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", lblTextblock4_Caption);
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A13ActividadDescripcion));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", lblTextblock5_Caption);
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A35ActividadCantidadProfesores), 4, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", lblTextblock2_Caption);
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
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
         if ( wbEnd == 9 )
         {
            wbEnd = 0;
            nRC_GXsfl_9 = (short)(nGXsfl_9_idx-1);
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "</table>") ;
               context.WriteHtmlText( "</div>") ;
            }
            else
            {
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
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         if ( wbEnd == 9 )
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
         if ( wbEnd == 32 )
         {
            wbEnd = 0;
            if ( isFullAjaxMode( ) )
            {
               if ( Grid2Container.GetWrapped() == 1 )
               {
                  context.WriteHtmlText( "</table>") ;
                  context.WriteHtmlText( "</div>") ;
               }
               else
               {
                  sStyleString = "";
                  context.WriteHtmlText( "<div id=\""+"Grid2Container"+"Div\" "+sStyleString+">"+"</div>") ;
                  context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Grid2", Grid2Container);
                  if ( ! isAjaxCallMode( ) )
                  {
                     GxWebStd.gx_hidden_field( context, "Grid2ContainerData", Grid2Container.ToJavascriptSource());
                  }
                  if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
                  {
                     GxWebStd.gx_hidden_field( context, "Grid2ContainerData"+"V", Grid2Container.GridValuesHidden());
                  }
                  else
                  {
                     context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Grid2ContainerData"+"V"+"\" value='"+Grid2Container.GridValuesHidden()+"'/>") ;
                  }
               }
            }
         }
         wbLoad = true;
      }

      protected void START1G2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 15_0_12-126726", 0) ;
            Form.Meta.addItem("description", "Grid Actividad Profesor", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP1G0( ) ;
      }

      protected void WS1G2( )
      {
         START1G2( ) ;
         EVT1G2( ) ;
      }

      protected void EVT1G2( )
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
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'ACTIVIDAD'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              dynload_actions( ) ;
                           }
                        }
                        else
                        {
                           sEvtType = StringUtil.Right( sEvt, 4);
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4));
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 10), "GRID1.LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 10), "GRID2.LOAD") == 0 ) )
                           {
                              nGXsfl_9_idx = (short)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_9_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_9_idx), 4, 0)), 4, "0");
                              SubsflControlProps_92( ) ;
                              A1ActividadId = (short)(context.localUtil.CToN( cgiGet( edtActividadId_Internalname), ".", ","));
                              A13ActividadDescripcion = cgiGet( edtActividadDescripcion_Internalname);
                              A35ActividadCantidadProfesores = (short)(context.localUtil.CToN( cgiGet( edtActividadCantidadProfesores_Internalname), ".", ","));
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "GRID1.LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    E111G2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false;
                                       if ( ! Rfr0gs )
                                       {
                                       }
                                       dynload_actions( ) ;
                                    }
                                    /* No code required for Cancel button. It is implemented as the Reset button. */
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                 }
                              }
                              else
                              {
                                 sEvtType = StringUtil.Right( sEvt, 4);
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4));
                                 if ( StringUtil.StrCmp(StringUtil.Left( sEvt, 10), "GRID2.LOAD") == 0 )
                                 {
                                    nGXsfl_32_idx = (short)(NumberUtil.Val( sEvtType, "."));
                                    sGXsfl_32_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_32_idx), 4, 0)), 4, "0") + sGXsfl_9_idx;
                                    SubsflControlProps_323( ) ;
                                    A2ProfesorId = (short)(context.localUtil.CToN( cgiGet( edtProfesorId_Internalname), ".", ","));
                                    A15ProfesorNombre = cgiGet( edtProfesorNombre_Internalname);
                                    A16ProfesorDireccion = cgiGet( edtProfesorDireccion_Internalname);
                                    A17ProfesorFoto = cgiGet( edtProfesorFoto_Internalname);
                                    context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtProfesorFoto_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A17ProfesorFoto)) ? A40000ProfesorFoto_GXI : context.convertURL( context.PathToRelativeUrl( A17ProfesorFoto))), !bGXsfl_32_Refreshing);
                                    context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtProfesorFoto_Internalname, "SrcSet", context.GetImageSrcSet( A17ProfesorFoto), true);
                                    sEvtType = StringUtil.Right( sEvt, 1);
                                    if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                                    {
                                       sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                       if ( StringUtil.StrCmp(sEvt, "GRID2.LOAD") == 0 )
                                       {
                                          context.wbHandled = 1;
                                          dynload_actions( ) ;
                                          E121G3 ();
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
                        }
                     }
                     context.wbHandled = 1;
                  }
               }
            }
         }
      }

      protected void WE1G2( )
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

      protected void PA1G2( )
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

      protected void gxnrGrid1_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         SubsflControlProps_92( ) ;
         while ( nGXsfl_9_idx <= nRC_GXsfl_9 )
         {
            sendrow_92( ) ;
            nGXsfl_9_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_9_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_9_idx+1));
            sGXsfl_9_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_9_idx), 4, 0)), 4, "0");
            SubsflControlProps_92( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( Grid1Container));
         /* End function gxnrGrid1_newrow */
      }

      protected void gxnrGrid2_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         SubsflControlProps_323( ) ;
         while ( nGXsfl_32_idx <= nRC_GXsfl_32 )
         {
            sendrow_323( ) ;
            nGXsfl_32_idx = (short)(((subGrid2_Islastpage==1)&&(nGXsfl_32_idx+1>subGrid2_Recordsperpage( )) ? 1 : nGXsfl_32_idx+1));
            sGXsfl_32_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_32_idx), 4, 0)), 4, "0") + sGXsfl_9_idx;
            SubsflControlProps_323( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( Grid2Container));
         /* End function gxnrGrid2_newrow */
      }

      protected void gxgrGrid2_refresh( short A1ActividadId )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GRID2_nCurrentRecord = 0;
         RF1G3( ) ;
         /* End function gxgrGrid2_refresh */
      }

      protected void gxgrGrid1_refresh( )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GRID1_nCurrentRecord = 0;
         RF1G2( ) ;
         /* End function gxgrGrid1_refresh */
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
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF1G2( ) ;
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

      protected void RF1G2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            Grid1Container.ClearRows();
         }
         wbStart = 9;
         nGXsfl_9_idx = 1;
         sGXsfl_9_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_9_idx), 4, 0)), 4, "0");
         SubsflControlProps_92( ) ;
         bGXsfl_9_Refreshing = true;
         Grid1Container.AddObjectProperty("GridName", "Grid1");
         Grid1Container.AddObjectProperty("CmpContext", "");
         Grid1Container.AddObjectProperty("InMasterPage", "false");
         Grid1Container.AddObjectProperty("Class", StringUtil.RTrim( "FreeStyleGrid"));
         Grid1Container.AddObjectProperty("Class", "FreeStyleGrid");
         Grid1Container.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         Grid1Container.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
         Grid1Container.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Backcolorstyle), 1, 0, ".", "")));
         Grid1Container.PageSize = subGrid1_Recordsperpage( );
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            SubsflControlProps_92( ) ;
            /* Using cursor H001G2 */
            pr_default.execute(0);
            while ( (pr_default.getStatus(0) != 101) )
            {
               A13ActividadDescripcion = H001G2_A13ActividadDescripcion[0];
               A1ActividadId = H001G2_A1ActividadId[0];
               GXt_int1 = A35ActividadCantidadProfesores;
               new cantidaddeprofesenactividad(context ).execute(  A1ActividadId, out  GXt_int1) ;
               A35ActividadCantidadProfesores = GXt_int1;
               E111G2 ();
               pr_default.readNext(0);
            }
            pr_default.close(0);
            wbEnd = 9;
            WB1G0( ) ;
         }
         bGXsfl_9_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes1G2( )
      {
      }

      protected void RF1G3( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            Grid2Container.ClearRows();
         }
         wbStart = 32;
         nGXsfl_32_idx = 1;
         sGXsfl_32_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_32_idx), 4, 0)), 4, "0") + sGXsfl_9_idx;
         SubsflControlProps_323( ) ;
         bGXsfl_32_Refreshing = true;
         Grid2Container.AddObjectProperty("GridName", "Grid2");
         Grid2Container.AddObjectProperty("CmpContext", "");
         Grid2Container.AddObjectProperty("InMasterPage", "false");
         Grid2Container.AddObjectProperty("Class", StringUtil.RTrim( "FreeStyleGrid"));
         Grid2Container.AddObjectProperty("Class", "FreeStyleGrid");
         Grid2Container.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         Grid2Container.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
         Grid2Container.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid2_Backcolorstyle), 1, 0, ".", "")));
         Grid2Container.PageSize = subGrid2_Recordsperpage( );
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            SubsflControlProps_323( ) ;
            /* Using cursor H001G3 */
            pr_default.execute(1, new Object[] {A1ActividadId});
            while ( (pr_default.getStatus(1) != 101) )
            {
               A40000ProfesorFoto_GXI = H001G3_A40000ProfesorFoto_GXI[0];
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtProfesorFoto_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A17ProfesorFoto)) ? A40000ProfesorFoto_GXI : context.convertURL( context.PathToRelativeUrl( A17ProfesorFoto))), !bGXsfl_32_Refreshing);
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtProfesorFoto_Internalname, "SrcSet", context.GetImageSrcSet( A17ProfesorFoto), true);
               A16ProfesorDireccion = H001G3_A16ProfesorDireccion[0];
               A15ProfesorNombre = H001G3_A15ProfesorNombre[0];
               A2ProfesorId = H001G3_A2ProfesorId[0];
               A17ProfesorFoto = H001G3_A17ProfesorFoto[0];
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtProfesorFoto_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A17ProfesorFoto)) ? A40000ProfesorFoto_GXI : context.convertURL( context.PathToRelativeUrl( A17ProfesorFoto))), !bGXsfl_32_Refreshing);
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtProfesorFoto_Internalname, "SrcSet", context.GetImageSrcSet( A17ProfesorFoto), true);
               E121G3 ();
               pr_default.readNext(1);
            }
            pr_default.close(1);
            wbEnd = 32;
            WB1G0( ) ;
         }
         bGXsfl_32_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes1G3( )
      {
      }

      protected int subGrid1_Pagecount( )
      {
         return (int)(-1) ;
      }

      protected int subGrid1_Recordcount( )
      {
         return (int)(-1) ;
      }

      protected int subGrid1_Recordsperpage( )
      {
         return (int)(-1) ;
      }

      protected int subGrid1_Currentpage( )
      {
         return (int)(-1) ;
      }

      protected int subGrid2_Pagecount( )
      {
         return (int)(-1) ;
      }

      protected int subGrid2_Recordcount( )
      {
         return (int)(-1) ;
      }

      protected int subGrid2_Recordsperpage( )
      {
         return (int)(-1) ;
      }

      protected int subGrid2_Currentpage( )
      {
         return (int)(-1) ;
      }

      protected void STRUP1G0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            /* Read saved values. */
            nRC_GXsfl_9 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_9"), ".", ","));
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      private void E111G2( )
      {
         /* Grid1_Load Routine */
         /* Load Method */
         if ( wbStart != -1 )
         {
            wbStart = 9;
         }
         sendrow_92( ) ;
         if ( isFullAjaxMode( ) && ! bGXsfl_9_Refreshing )
         {
            context.DoAjaxLoad(9, Grid1Row);
         }
      }

      private void E121G3( )
      {
         /* Grid2_Load Routine */
         /* Load Method */
         if ( wbStart != -1 )
         {
            wbStart = 32;
         }
         sendrow_323( ) ;
         if ( isFullAjaxMode( ) && ! bGXsfl_32_Refreshing )
         {
            context.DoAjaxLoad(32, Grid2Row);
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
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
         PA1G2( ) ;
         WS1G2( ) ;
         WE1G2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?201941219205420", true);
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
         if ( nGXWrapped != 1 )
         {
            context.AddJavascriptSource("messages.eng.js", "?"+GetCacheInvalidationToken( ), false);
            context.AddJavascriptSource("gridactividadprofesor.js", "?201941219205420", false);
         }
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_323( )
      {
         lblTextblock6_Internalname = "TEXTBLOCK6_"+sGXsfl_32_idx;
         edtProfesorId_Internalname = "PROFESORID_"+sGXsfl_32_idx;
         lblTextblock7_Internalname = "TEXTBLOCK7_"+sGXsfl_32_idx;
         edtProfesorNombre_Internalname = "PROFESORNOMBRE_"+sGXsfl_32_idx;
         lblTextblock8_Internalname = "TEXTBLOCK8_"+sGXsfl_32_idx;
         edtProfesorDireccion_Internalname = "PROFESORDIRECCION_"+sGXsfl_32_idx;
         edtProfesorFoto_Internalname = "PROFESORFOTO_"+sGXsfl_32_idx;
      }

      protected void SubsflControlProps_fel_323( )
      {
         lblTextblock6_Internalname = "TEXTBLOCK6_"+sGXsfl_32_fel_idx;
         edtProfesorId_Internalname = "PROFESORID_"+sGXsfl_32_fel_idx;
         lblTextblock7_Internalname = "TEXTBLOCK7_"+sGXsfl_32_fel_idx;
         edtProfesorNombre_Internalname = "PROFESORNOMBRE_"+sGXsfl_32_fel_idx;
         lblTextblock8_Internalname = "TEXTBLOCK8_"+sGXsfl_32_fel_idx;
         edtProfesorDireccion_Internalname = "PROFESORDIRECCION_"+sGXsfl_32_fel_idx;
         edtProfesorFoto_Internalname = "PROFESORFOTO_"+sGXsfl_32_fel_idx;
      }

      protected void sendrow_323( )
      {
         SubsflControlProps_323( ) ;
         WB1G0( ) ;
         Grid2Row = GXWebRow.GetNew(context,Grid2Container);
         if ( subGrid2_Backcolorstyle == 0 )
         {
            /* None style subfile background logic. */
            subGrid2_Backstyle = 0;
            if ( StringUtil.StrCmp(subGrid2_Class, "") != 0 )
            {
               subGrid2_Linesclass = subGrid2_Class+"Odd";
            }
         }
         else if ( subGrid2_Backcolorstyle == 1 )
         {
            /* Uniform style subfile background logic. */
            subGrid2_Backstyle = 0;
            subGrid2_Backcolor = subGrid2_Allbackcolor;
            if ( StringUtil.StrCmp(subGrid2_Class, "") != 0 )
            {
               subGrid2_Linesclass = subGrid2_Class+"Uniform";
            }
         }
         else if ( subGrid2_Backcolorstyle == 2 )
         {
            /* Header style subfile background logic. */
            subGrid2_Backstyle = 1;
            if ( StringUtil.StrCmp(subGrid2_Class, "") != 0 )
            {
               subGrid2_Linesclass = subGrid2_Class+"Odd";
            }
            subGrid2_Backcolor = (int)(0xFFFFFF);
         }
         else if ( subGrid2_Backcolorstyle == 3 )
         {
            /* Report style subfile background logic. */
            subGrid2_Backstyle = 1;
            if ( ((int)(((nGXsfl_32_idx-1)/ (decimal)(1)) % (2))) == 0 )
            {
               subGrid2_Backcolor = (int)(0xFFFFFF);
               if ( StringUtil.StrCmp(subGrid2_Class, "") != 0 )
               {
                  subGrid2_Linesclass = subGrid2_Class+"Odd";
               }
            }
            else
            {
               subGrid2_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGrid2_Class, "") != 0 )
               {
                  subGrid2_Linesclass = subGrid2_Class+"Even";
               }
            }
         }
         /* Start of Columns property logic. */
         if ( Grid2Container.GetWrapped() == 1 )
         {
            if ( ( 1 == 0 ) && ( nGXsfl_32_idx == 1 ) )
            {
               context.WriteHtmlText( "<tr"+" class=\""+subGrid2_Linesclass+"\" style=\""+""+"\""+" data-gxrow=\""+sGXsfl_32_idx+"\">") ;
            }
            if ( 1 > 0 )
            {
               if ( ( 1 == 1 ) || ( ((int)((nGXsfl_32_idx) % (1))) - 1 == 0 ) )
               {
                  context.WriteHtmlText( "<tr"+" class=\""+subGrid2_Linesclass+"\" style=\""+""+"\""+" data-gxrow=\""+sGXsfl_32_idx+"\">") ;
               }
            }
         }
         /* Div Control */
         Grid2Row.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)divGrid2table_Internalname+"_"+sGXsfl_32_idx,(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"Table",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         /* Div Control */
         Grid2Row.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"row",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         /* Div Control */
         Grid2Row.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"col-xs-12 col-sm-6",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         /* Text block */
         Grid2Row.AddColumnProperties("label", 1, isAjaxCallMode( ), new Object[] {(String)lblTextblock6_Internalname,(String)"Id",(String)"",(String)"",(String)lblTextblock6_Jsonclick,(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"TextBlock",(short)0,(String)"",(short)1,(short)1,(short)0});
         Grid2Row.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         /* Div Control */
         Grid2Row.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"col-xs-12 col-sm-6",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         /* Div Control */
         Grid2Row.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)" gx-attribute",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         /* Attribute/Variable Label */
         Grid2Row.AddColumnProperties("html_label", -1, isAjaxCallMode( ), new Object[] {(String)edtProfesorId_Internalname,(String)"Profesor Id",(String)"col-sm-3 AttributeLabel",(short)0,(bool)true});
         /* Single line edit */
         ROClassString = "Attribute";
         Grid2Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtProfesorId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A2ProfesorId), 4, 0, ".", "")),context.localUtil.Format( (decimal)(A2ProfesorId), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtProfesorId_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)1,(short)0,(short)0,(String)"number",(String)"1",(short)4,(String)"chr",(short)1,(String)"row",(short)4,(short)0,(short)0,(short)32,(short)1,(short)-1,(short)0,(bool)false,(String)"",(String)"right",(bool)false});
         Grid2Row.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         Grid2Row.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         Grid2Row.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         /* Div Control */
         Grid2Row.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"row",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         /* Div Control */
         Grid2Row.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"col-xs-12 col-sm-6",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         /* Text block */
         Grid2Row.AddColumnProperties("label", 1, isAjaxCallMode( ), new Object[] {(String)lblTextblock7_Internalname,(String)"Nombre",(String)"",(String)"",(String)lblTextblock7_Jsonclick,(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"TextBlock",(short)0,(String)"",(short)1,(short)1,(short)0});
         Grid2Row.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         /* Div Control */
         Grid2Row.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"col-xs-12 col-sm-6",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         /* Div Control */
         Grid2Row.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)" gx-attribute",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         /* Attribute/Variable Label */
         Grid2Row.AddColumnProperties("html_label", -1, isAjaxCallMode( ), new Object[] {(String)edtProfesorNombre_Internalname,(String)"Profesor Nombre",(String)"col-sm-3 AttributeLabel",(short)0,(bool)true});
         /* Single line edit */
         ROClassString = "Attribute";
         Grid2Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtProfesorNombre_Internalname,StringUtil.RTrim( A15ProfesorNombre),(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtProfesorNombre_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)1,(short)0,(short)0,(String)"text",(String)"",(short)20,(String)"chr",(short)1,(String)"row",(short)20,(short)0,(short)0,(short)32,(short)1,(short)-1,(short)-1,(bool)false,(String)"",(String)"left",(bool)true});
         Grid2Row.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         Grid2Row.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         Grid2Row.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         /* Div Control */
         Grid2Row.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"row",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         /* Div Control */
         Grid2Row.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"col-xs-12 col-sm-6",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         /* Text block */
         Grid2Row.AddColumnProperties("label", 1, isAjaxCallMode( ), new Object[] {(String)lblTextblock8_Internalname,(String)"Direccion",(String)"",(String)"",(String)lblTextblock8_Jsonclick,(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"TextBlock",(short)0,(String)"",(short)1,(short)1,(short)0});
         Grid2Row.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         /* Div Control */
         Grid2Row.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"col-xs-12 col-sm-6",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         /* Div Control */
         Grid2Row.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)" gx-attribute",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         /* Attribute/Variable Label */
         Grid2Row.AddColumnProperties("html_label", -1, isAjaxCallMode( ), new Object[] {(String)edtProfesorDireccion_Internalname,(String)"Profesor Direccion",(String)"col-sm-3 AttributeLabel",(short)0,(bool)true});
         /* Multiple line edit */
         ClassString = "Attribute";
         StyleString = "";
         ClassString = "Attribute";
         StyleString = "";
         Grid2Row.AddColumnProperties("html_textarea", 1, isAjaxCallMode( ), new Object[] {(String)edtProfesorDireccion_Internalname,(String)A16ProfesorDireccion,"http://maps.google.com/maps?q="+GXUtil.UrlEncode( A16ProfesorDireccion),(String)"",(short)0,(short)1,(short)0,(short)0,(short)80,(String)"chr",(short)10,(String)"row",(String)StyleString,(String)ClassString,(String)"",(String)"",(String)"1024",(short)-1,(short)0,(String)"_blank",(String)"",(short)0,(bool)false,(String)"GeneXus\\Address",(String)"'"+""+"'"+",false,"+"'"+""+"'",(short)0});
         Grid2Row.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         Grid2Row.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         Grid2Row.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         /* Div Control */
         Grid2Row.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"row",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         /* Div Control */
         Grid2Row.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"col-xs-12",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         /* Div Control */
         Grid2Row.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)" gx-attribute",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         /* Attribute/Variable Label */
         Grid2Row.AddColumnProperties("html_label", -1, isAjaxCallMode( ), new Object[] {(String)edtProfesorFoto_Internalname,(String)"Profesor Foto",(String)"col-sm-3 ImageAttributeLabel",(short)0,(bool)true});
         /* Static Bitmap Variable */
         ClassString = "ImageAttribute";
         StyleString = "";
         A17ProfesorFoto_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( A17ProfesorFoto))&&String.IsNullOrEmpty(StringUtil.RTrim( A40000ProfesorFoto_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( A17ProfesorFoto)));
         sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( A17ProfesorFoto)) ? A40000ProfesorFoto_GXI : context.PathToRelativeUrl( A17ProfesorFoto));
         Grid2Row.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtProfesorFoto_Internalname,(String)sImgUrl,(String)"",(String)"",(String)"",context.GetTheme( ),(short)1,(short)0,(String)"",(String)"",(short)1,(short)-1,(short)0,(String)"",(short)0,(String)"",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)A17ProfesorFoto_IsBlob,(bool)true,context.GetImageSrcSet( sImgUrl)});
         Grid2Row.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         Grid2Row.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         Grid2Row.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         Grid2Row.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         send_integrity_lvl_hashes1G3( ) ;
         /* End of Columns property logic. */
         Grid2Container.AddRow(Grid2Row);
         nGXsfl_32_idx = (short)(((subGrid2_Islastpage==1)&&(nGXsfl_32_idx+1>subGrid2_Recordsperpage( )) ? 1 : nGXsfl_32_idx+1));
         sGXsfl_32_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_32_idx), 4, 0)), 4, "0") + sGXsfl_9_idx;
         SubsflControlProps_323( ) ;
         /* End function sendrow_323 */
      }

      protected void SubsflControlProps_92( )
      {
         lblTextblock3_Internalname = "TEXTBLOCK3_"+sGXsfl_9_idx;
         edtActividadId_Internalname = "ACTIVIDADID_"+sGXsfl_9_idx;
         lblTextblock4_Internalname = "TEXTBLOCK4_"+sGXsfl_9_idx;
         edtActividadDescripcion_Internalname = "ACTIVIDADDESCRIPCION_"+sGXsfl_9_idx;
         lblTextblock5_Internalname = "TEXTBLOCK5_"+sGXsfl_9_idx;
         edtActividadCantidadProfesores_Internalname = "ACTIVIDADCANTIDADPROFESORES_"+sGXsfl_9_idx;
         lblTextblock2_Internalname = "TEXTBLOCK2_"+sGXsfl_9_idx;
         subGrid2_Internalname = "GRID2_"+sGXsfl_9_idx;
      }

      protected void SubsflControlProps_fel_92( )
      {
         lblTextblock3_Internalname = "TEXTBLOCK3_"+sGXsfl_9_fel_idx;
         edtActividadId_Internalname = "ACTIVIDADID_"+sGXsfl_9_fel_idx;
         lblTextblock4_Internalname = "TEXTBLOCK4_"+sGXsfl_9_fel_idx;
         edtActividadDescripcion_Internalname = "ACTIVIDADDESCRIPCION_"+sGXsfl_9_fel_idx;
         lblTextblock5_Internalname = "TEXTBLOCK5_"+sGXsfl_9_fel_idx;
         edtActividadCantidadProfesores_Internalname = "ACTIVIDADCANTIDADPROFESORES_"+sGXsfl_9_fel_idx;
         lblTextblock2_Internalname = "TEXTBLOCK2_"+sGXsfl_9_fel_idx;
         subGrid2_Internalname = "GRID2_"+sGXsfl_9_fel_idx;
      }

      protected void sendrow_92( )
      {
         SubsflControlProps_92( ) ;
         WB1G0( ) ;
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
            subGrid1_Backcolor = (int)(0xFFFFFF);
         }
         else if ( subGrid1_Backcolorstyle == 3 )
         {
            /* Report style subfile background logic. */
            subGrid1_Backstyle = 1;
            if ( ((int)(((nGXsfl_9_idx-1)/ (decimal)(1)) % (2))) == 0 )
            {
               subGrid1_Backcolor = (int)(0xFFFFFF);
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
         /* Start of Columns property logic. */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            if ( ( 1 == 0 ) && ( nGXsfl_9_idx == 1 ) )
            {
               context.WriteHtmlText( "<tr"+" class=\""+subGrid1_Linesclass+"\" style=\""+""+"\""+" data-gxrow=\""+sGXsfl_9_idx+"\">") ;
            }
            if ( 1 > 0 )
            {
               if ( ( 1 == 1 ) || ( ((int)((nGXsfl_9_idx) % (1))) - 1 == 0 ) )
               {
                  context.WriteHtmlText( "<tr"+" class=\""+subGrid1_Linesclass+"\" style=\""+""+"\""+" data-gxrow=\""+sGXsfl_9_idx+"\">") ;
               }
            }
         }
         /* Div Control */
         Grid1Row.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)divGrid1table_Internalname+"_"+sGXsfl_9_idx,(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"Table",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         /* Div Control */
         Grid1Row.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"row",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         /* Div Control */
         Grid1Row.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"col-xs-12 col-sm-2",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         /* Text block */
         Grid1Row.AddColumnProperties("label", 1, isAjaxCallMode( ), new Object[] {(String)lblTextblock3_Internalname,(String)"Id",(String)"",(String)"",(String)lblTextblock3_Jsonclick,(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"TextBlock",(short)0,(String)"",(short)1,(short)1,(short)0});
         Grid1Row.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         /* Div Control */
         Grid1Row.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"col-xs-12 col-sm-2",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         /* Div Control */
         Grid1Row.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)" gx-attribute",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         /* Attribute/Variable Label */
         Grid1Row.AddColumnProperties("html_label", -1, isAjaxCallMode( ), new Object[] {(String)edtActividadId_Internalname,(String)"Actividad Id",(String)"col-sm-3 AttributeLabel",(short)0,(bool)true});
         /* Single line edit */
         ROClassString = "Attribute";
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtActividadId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A1ActividadId), 4, 0, ".", "")),context.localUtil.Format( (decimal)(A1ActividadId), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtActividadId_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)1,(short)0,(short)0,(String)"number",(String)"1",(short)4,(String)"chr",(short)1,(String)"row",(short)4,(short)0,(short)0,(short)9,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         Grid1Row.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         Grid1Row.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         /* Div Control */
         Grid1Row.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"col-xs-12 col-sm-2",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         /* Text block */
         Grid1Row.AddColumnProperties("label", 1, isAjaxCallMode( ), new Object[] {(String)lblTextblock4_Internalname,(String)"Descripcion",(String)"",(String)"",(String)lblTextblock4_Jsonclick,(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"TextBlock",(short)0,(String)"",(short)1,(short)1,(short)0});
         Grid1Row.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         /* Div Control */
         Grid1Row.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"col-xs-12 col-sm-2",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         /* Div Control */
         Grid1Row.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)" gx-attribute",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         /* Attribute/Variable Label */
         Grid1Row.AddColumnProperties("html_label", -1, isAjaxCallMode( ), new Object[] {(String)edtActividadDescripcion_Internalname,(String)"Actividad Descripcion",(String)"col-sm-3 AttributeLabel",(short)0,(bool)true});
         /* Single line edit */
         ROClassString = "Attribute";
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtActividadDescripcion_Internalname,StringUtil.RTrim( A13ActividadDescripcion),(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtActividadDescripcion_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)1,(short)0,(short)0,(String)"text",(String)"",(short)20,(String)"chr",(short)1,(String)"row",(short)20,(short)0,(short)0,(short)9,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
         Grid1Row.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         Grid1Row.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         /* Div Control */
         Grid1Row.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"col-xs-12 col-sm-2",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         /* Text block */
         Grid1Row.AddColumnProperties("label", 1, isAjaxCallMode( ), new Object[] {(String)lblTextblock5_Internalname,(String)"Cantidad de profesores",(String)"",(String)"",(String)lblTextblock5_Jsonclick,(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"TextBlock",(short)0,(String)"",(short)1,(short)1,(short)0});
         Grid1Row.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         /* Div Control */
         Grid1Row.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"col-xs-12 col-sm-2",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         /* Div Control */
         Grid1Row.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)" gx-attribute",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         /* Attribute/Variable Label */
         Grid1Row.AddColumnProperties("html_label", -1, isAjaxCallMode( ), new Object[] {(String)edtActividadCantidadProfesores_Internalname,(String)"Actividad Cantidad Profesores",(String)"col-sm-3 AttributeLabel",(short)0,(bool)true});
         /* Single line edit */
         ROClassString = "Attribute";
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtActividadCantidadProfesores_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A35ActividadCantidadProfesores), 4, 0, ".", "")),context.localUtil.Format( (decimal)(A35ActividadCantidadProfesores), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtActividadCantidadProfesores_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)1,(short)0,(short)0,(String)"number",(String)"1",(short)4,(String)"chr",(short)1,(String)"row",(short)4,(short)0,(short)0,(short)9,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         Grid1Row.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         Grid1Row.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         Grid1Row.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         /* Div Control */
         Grid1Row.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"row",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         /* Div Control */
         Grid1Row.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"col-xs-12",(String)"Center",(String)"top",(String)"",(String)"",(String)"div"});
         /* Text block */
         Grid1Row.AddColumnProperties("label", 1, isAjaxCallMode( ), new Object[] {(String)lblTextblock2_Internalname,(String)"Profesores",(String)"",(String)"",(String)lblTextblock2_Jsonclick,(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"TextBlock",(short)0,(String)"",(short)1,(short)1,(short)0});
         Grid1Row.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"Center",(String)"top",(String)"div"});
         Grid1Row.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         /* Div Control */
         Grid1Row.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"row",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         /* Div Control */
         Grid1Row.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"col-xs-12",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         /*  Child Grid Control  */
         Grid1Row.AddColumnProperties("subfile", -1, isAjaxCallMode( ), new Object[] {(String)"Grid2Container"});
         if ( isAjaxCallMode( ) )
         {
            Grid2Container = new GXWebGrid( context);
         }
         else
         {
            Grid2Container.Clear();
         }
         Grid2Container.SetIsFreestyle(true);
         Grid2Container.SetWrapped(nGXWrapped);
         if ( Grid2Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<div id=\""+"Grid2Container"+"DivS\" data-gxgridid=\"32\">") ;
            sStyleString = "";
            GxWebStd.gx_table_start( context, subGrid2_Internalname, subGrid2_Internalname, "", "FreeStyleGrid", 0, "", "", 1, 2, sStyleString, "", "", 0);
            Grid2Container.AddObjectProperty("GridName", "Grid2");
         }
         else
         {
            if ( isAjaxCallMode( ) )
            {
               Grid2Container = new GXWebGrid( context);
            }
            else
            {
               Grid2Container.Clear();
            }
            Grid2Container.SetIsFreestyle(true);
            Grid2Container.SetWrapped(nGXWrapped);
            Grid2Container.AddObjectProperty("GridName", "Grid2");
            Grid2Container.AddObjectProperty("Header", subGrid2_Header);
            Grid2Container.AddObjectProperty("Class", StringUtil.RTrim( "FreeStyleGrid"));
            Grid2Container.AddObjectProperty("Class", "FreeStyleGrid");
            Grid2Container.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
            Grid2Container.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
            Grid2Container.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid2_Backcolorstyle), 1, 0, ".", "")));
            Grid2Container.AddObjectProperty("CmpContext", "");
            Grid2Container.AddObjectProperty("InMasterPage", "false");
            Grid2Column = GXWebColumn.GetNew(isAjaxCallMode( ));
            Grid2Container.AddColumnProperties(Grid2Column);
            Grid2Column = GXWebColumn.GetNew(isAjaxCallMode( ));
            Grid2Container.AddColumnProperties(Grid2Column);
            Grid2Column = GXWebColumn.GetNew(isAjaxCallMode( ));
            Grid2Container.AddColumnProperties(Grid2Column);
            Grid2Column = GXWebColumn.GetNew(isAjaxCallMode( ));
            Grid2Column.AddObjectProperty("Value", lblTextblock3_Caption);
            Grid2Container.AddColumnProperties(Grid2Column);
            Grid2Column = GXWebColumn.GetNew(isAjaxCallMode( ));
            Grid2Container.AddColumnProperties(Grid2Column);
            Grid2Column = GXWebColumn.GetNew(isAjaxCallMode( ));
            Grid2Container.AddColumnProperties(Grid2Column);
            Grid2Column = GXWebColumn.GetNew(isAjaxCallMode( ));
            Grid2Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A2ProfesorId), 4, 0, ".", "")));
            Grid2Container.AddColumnProperties(Grid2Column);
            Grid2Column = GXWebColumn.GetNew(isAjaxCallMode( ));
            Grid2Container.AddColumnProperties(Grid2Column);
            Grid2Column = GXWebColumn.GetNew(isAjaxCallMode( ));
            Grid2Container.AddColumnProperties(Grid2Column);
            Grid2Column = GXWebColumn.GetNew(isAjaxCallMode( ));
            Grid2Column.AddObjectProperty("Value", lblTextblock7_Caption);
            Grid2Container.AddColumnProperties(Grid2Column);
            Grid2Column = GXWebColumn.GetNew(isAjaxCallMode( ));
            Grid2Container.AddColumnProperties(Grid2Column);
            Grid2Column = GXWebColumn.GetNew(isAjaxCallMode( ));
            Grid2Container.AddColumnProperties(Grid2Column);
            Grid2Column = GXWebColumn.GetNew(isAjaxCallMode( ));
            Grid2Column.AddObjectProperty("Value", StringUtil.RTrim( A15ProfesorNombre));
            Grid2Container.AddColumnProperties(Grid2Column);
            Grid2Column = GXWebColumn.GetNew(isAjaxCallMode( ));
            Grid2Container.AddColumnProperties(Grid2Column);
            Grid2Column = GXWebColumn.GetNew(isAjaxCallMode( ));
            Grid2Container.AddColumnProperties(Grid2Column);
            Grid2Column = GXWebColumn.GetNew(isAjaxCallMode( ));
            Grid2Column.AddObjectProperty("Value", lblTextblock8_Caption);
            Grid2Container.AddColumnProperties(Grid2Column);
            Grid2Column = GXWebColumn.GetNew(isAjaxCallMode( ));
            Grid2Container.AddColumnProperties(Grid2Column);
            Grid2Column = GXWebColumn.GetNew(isAjaxCallMode( ));
            Grid2Container.AddColumnProperties(Grid2Column);
            Grid2Column = GXWebColumn.GetNew(isAjaxCallMode( ));
            Grid2Column.AddObjectProperty("Value", A16ProfesorDireccion);
            Grid2Container.AddColumnProperties(Grid2Column);
            Grid2Column = GXWebColumn.GetNew(isAjaxCallMode( ));
            Grid2Container.AddColumnProperties(Grid2Column);
            Grid2Column = GXWebColumn.GetNew(isAjaxCallMode( ));
            Grid2Container.AddColumnProperties(Grid2Column);
            Grid2Column = GXWebColumn.GetNew(isAjaxCallMode( ));
            Grid2Container.AddColumnProperties(Grid2Column);
            Grid2Column = GXWebColumn.GetNew(isAjaxCallMode( ));
            Grid2Column.AddObjectProperty("Value", context.convertURL( A17ProfesorFoto));
            Grid2Container.AddColumnProperties(Grid2Column);
            Grid2Container.AddObjectProperty("Selectedindex", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid2_Selectedindex), 4, 0, ".", "")));
            Grid2Container.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid2_Allowselection), 1, 0, ".", "")));
            Grid2Container.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid2_Selectioncolor), 9, 0, ".", "")));
            Grid2Container.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid2_Allowhovering), 1, 0, ".", "")));
            Grid2Container.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid2_Hoveringcolor), 9, 0, ".", "")));
            Grid2Container.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid2_Allowcollapsing), 1, 0, ".", "")));
            Grid2Container.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid2_Collapsed), 1, 0, ".", "")));
         }
         RF1G3( ) ;
         nRC_GXsfl_32 = (short)(nGXsfl_32_idx-1);
         send_integrity_footer_hashes( ) ;
         GXCCtl = "nRC_GXsfl_32_" + sGXsfl_9_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_32), 4, 0, ".", "")));
         if ( Grid2Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "</table>") ;
         }
         else
         {
            if ( ! isAjaxCallMode( ) )
            {
               GxWebStd.gx_hidden_field( context, "Grid2ContainerData"+"_"+sGXsfl_9_idx, Grid2Container.ToJavascriptSource());
            }
            if ( isAjaxCallMode( ) )
            {
               Grid1Row.AddGrid("Grid2", Grid2Container);
            }
            if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
            {
               GxWebStd.gx_hidden_field( context, "Grid2ContainerData"+"V_"+sGXsfl_9_idx, Grid2Container.GridValuesHidden());
            }
            else
            {
               context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Grid2ContainerData"+"V_"+sGXsfl_9_idx+"\" value='"+Grid2Container.GridValuesHidden()+"'/>") ;
            }
         }
         Grid1Row.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         Grid1Row.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         Grid1Row.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         send_integrity_lvl_hashes1G2( ) ;
         /* End of Columns property logic. */
         Grid1Container.AddRow(Grid1Row);
         nGXsfl_9_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_9_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_9_idx+1));
         sGXsfl_9_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_9_idx), 4, 0)), 4, "0");
         SubsflControlProps_92( ) ;
         /* End function sendrow_92 */
      }

      protected void init_web_controls( )
      {
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         lblTextblock1_Internalname = "TEXTBLOCK1";
         lblTextblock3_Internalname = "TEXTBLOCK3";
         edtActividadId_Internalname = "ACTIVIDADID";
         lblTextblock4_Internalname = "TEXTBLOCK4";
         edtActividadDescripcion_Internalname = "ACTIVIDADDESCRIPCION";
         lblTextblock5_Internalname = "TEXTBLOCK5";
         edtActividadCantidadProfesores_Internalname = "ACTIVIDADCANTIDADPROFESORES";
         lblTextblock2_Internalname = "TEXTBLOCK2";
         lblTextblock6_Internalname = "TEXTBLOCK6";
         edtProfesorId_Internalname = "PROFESORID";
         lblTextblock7_Internalname = "TEXTBLOCK7";
         edtProfesorNombre_Internalname = "PROFESORNOMBRE";
         lblTextblock8_Internalname = "TEXTBLOCK8";
         edtProfesorDireccion_Internalname = "PROFESORDIRECCION";
         edtProfesorFoto_Internalname = "PROFESORFOTO";
         divGrid2table_Internalname = "GRID2TABLE";
         divGrid1table_Internalname = "GRID1TABLE";
         divMaintable_Internalname = "MAINTABLE";
         Form.Internalname = "FORM";
         subGrid2_Internalname = "GRID2";
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
         subGrid2_Allowcollapsing = 0;
         lblTextblock8_Caption = "Direccion";
         lblTextblock7_Caption = "Nombre";
         edtActividadCantidadProfesores_Jsonclick = "";
         edtActividadDescripcion_Jsonclick = "";
         edtActividadId_Jsonclick = "";
         subGrid1_Class = "FreeStyleGrid";
         edtProfesorNombre_Jsonclick = "";
         edtProfesorId_Jsonclick = "";
         subGrid2_Class = "FreeStyleGrid";
         subGrid2_Backcolorstyle = 0;
         subGrid1_Allowcollapsing = 0;
         lblTextblock2_Caption = "Profesores";
         lblTextblock5_Caption = "Cantidad de profesores";
         lblTextblock4_Caption = "Descripcion";
         lblTextblock3_Caption = "Id";
         subGrid1_Backcolorstyle = 0;
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Grid Actividad Profesor";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'GRID2_nFirstRecordOnPage'},{av:'GRID2_nEOF'},{av:'A1ActividadId',fld:'ACTIVIDADID',pic:'ZZZ9'}]");
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
      }

      public override void initialize( )
      {
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         lblTextblock1_Jsonclick = "";
         Grid1Container = new GXWebGrid( context);
         sStyleString = "";
         subGrid1_Header = "";
         Grid1Column = new GXWebColumn();
         A13ActividadDescripcion = "";
         Grid2Container = new GXWebGrid( context);
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         A15ProfesorNombre = "";
         A16ProfesorDireccion = "";
         A17ProfesorFoto = "";
         A40000ProfesorFoto_GXI = "";
         scmdbuf = "";
         H001G2_A13ActividadDescripcion = new String[] {""} ;
         H001G2_A1ActividadId = new short[1] ;
         H001G3_A1ActividadId = new short[1] ;
         H001G3_A40000ProfesorFoto_GXI = new String[] {""} ;
         H001G3_A16ProfesorDireccion = new String[] {""} ;
         H001G3_A15ProfesorNombre = new String[] {""} ;
         H001G3_A2ProfesorId = new short[1] ;
         H001G3_A17ProfesorFoto = new String[] {""} ;
         Grid1Row = new GXWebRow();
         Grid2Row = new GXWebRow();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         subGrid2_Linesclass = "";
         lblTextblock6_Jsonclick = "";
         ROClassString = "";
         lblTextblock7_Jsonclick = "";
         lblTextblock8_Jsonclick = "";
         ClassString = "";
         StyleString = "";
         sImgUrl = "";
         subGrid1_Linesclass = "";
         lblTextblock3_Jsonclick = "";
         lblTextblock4_Jsonclick = "";
         lblTextblock5_Jsonclick = "";
         lblTextblock2_Jsonclick = "";
         subGrid2_Header = "";
         Grid2Column = new GXWebColumn();
         GXCCtl = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gridactividadprofesor__default(),
            new Object[][] {
                new Object[] {
               H001G2_A13ActividadDescripcion, H001G2_A1ActividadId
               }
               , new Object[] {
               H001G3_A1ActividadId, H001G3_A40000ProfesorFoto_GXI, H001G3_A16ProfesorDireccion, H001G3_A15ProfesorNombre, H001G3_A2ProfesorId, H001G3_A17ProfesorFoto
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short nRC_GXsfl_32 ;
      private short nGXsfl_32_idx=1 ;
      private short nGotPars ;
      private short GxWebError ;
      private short nRC_GXsfl_9 ;
      private short A1ActividadId ;
      private short nGXsfl_9_idx=1 ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short nGXWrapped ;
      private short wbEnd ;
      private short wbStart ;
      private short subGrid1_Backcolorstyle ;
      private short A35ActividadCantidadProfesores ;
      private short subGrid1_Allowselection ;
      private short subGrid1_Allowhovering ;
      private short subGrid1_Allowcollapsing ;
      private short subGrid1_Collapsed ;
      private short A2ProfesorId ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short GXt_int1 ;
      private short subGrid2_Backcolorstyle ;
      private short subGrid2_Backstyle ;
      private short subGrid1_Backstyle ;
      private short subGrid2_Allowselection ;
      private short subGrid2_Allowhovering ;
      private short subGrid2_Allowcollapsing ;
      private short subGrid2_Collapsed ;
      private short GRID1_nEOF ;
      private short GRID2_nEOF ;
      private int subGrid1_Selectedindex ;
      private int subGrid1_Selectioncolor ;
      private int subGrid1_Hoveringcolor ;
      private int subGrid1_Islastpage ;
      private int subGrid2_Islastpage ;
      private int idxLst ;
      private int subGrid2_Backcolor ;
      private int subGrid2_Allbackcolor ;
      private int subGrid1_Backcolor ;
      private int subGrid1_Allbackcolor ;
      private int subGrid2_Selectedindex ;
      private int subGrid2_Selectioncolor ;
      private int subGrid2_Hoveringcolor ;
      private long GRID2_nCurrentRecord ;
      private long GRID1_nCurrentRecord ;
      private long GRID1_nFirstRecordOnPage ;
      private long GRID2_nFirstRecordOnPage ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_32_idx="0001" ;
      private String GXKey ;
      private String sGXsfl_9_idx="0001" ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divMaintable_Internalname ;
      private String lblTextblock1_Internalname ;
      private String lblTextblock1_Jsonclick ;
      private String sStyleString ;
      private String subGrid1_Internalname ;
      private String subGrid1_Header ;
      private String lblTextblock3_Caption ;
      private String lblTextblock4_Caption ;
      private String A13ActividadDescripcion ;
      private String lblTextblock5_Caption ;
      private String lblTextblock2_Caption ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtActividadId_Internalname ;
      private String edtActividadDescripcion_Internalname ;
      private String edtActividadCantidadProfesores_Internalname ;
      private String edtProfesorId_Internalname ;
      private String A15ProfesorNombre ;
      private String edtProfesorNombre_Internalname ;
      private String edtProfesorDireccion_Internalname ;
      private String edtProfesorFoto_Internalname ;
      private String scmdbuf ;
      private String lblTextblock6_Internalname ;
      private String lblTextblock7_Internalname ;
      private String lblTextblock8_Internalname ;
      private String sGXsfl_32_fel_idx="0001" ;
      private String subGrid2_Class ;
      private String subGrid2_Linesclass ;
      private String divGrid2table_Internalname ;
      private String lblTextblock6_Jsonclick ;
      private String ROClassString ;
      private String edtProfesorId_Jsonclick ;
      private String lblTextblock7_Jsonclick ;
      private String edtProfesorNombre_Jsonclick ;
      private String lblTextblock8_Jsonclick ;
      private String ClassString ;
      private String StyleString ;
      private String sImgUrl ;
      private String lblTextblock3_Internalname ;
      private String lblTextblock4_Internalname ;
      private String lblTextblock5_Internalname ;
      private String lblTextblock2_Internalname ;
      private String subGrid2_Internalname ;
      private String sGXsfl_9_fel_idx="0001" ;
      private String subGrid1_Class ;
      private String subGrid1_Linesclass ;
      private String divGrid1table_Internalname ;
      private String lblTextblock3_Jsonclick ;
      private String edtActividadId_Jsonclick ;
      private String lblTextblock4_Jsonclick ;
      private String edtActividadDescripcion_Jsonclick ;
      private String lblTextblock5_Jsonclick ;
      private String edtActividadCantidadProfesores_Jsonclick ;
      private String lblTextblock2_Jsonclick ;
      private String subGrid2_Header ;
      private String lblTextblock7_Caption ;
      private String lblTextblock8_Caption ;
      private String GXCCtl ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_32_Refreshing=false ;
      private bool bGXsfl_9_Refreshing=false ;
      private bool gxdyncontrolsrefreshing ;
      private bool A17ProfesorFoto_IsBlob ;
      private String A16ProfesorDireccion ;
      private String A40000ProfesorFoto_GXI ;
      private String A17ProfesorFoto ;
      private GXWebGrid Grid1Container ;
      private GXWebGrid Grid2Container ;
      private GXWebRow Grid1Row ;
      private GXWebRow Grid2Row ;
      private GXWebColumn Grid1Column ;
      private GXWebColumn Grid2Column ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] H001G2_A13ActividadDescripcion ;
      private short[] H001G2_A1ActividadId ;
      private short[] H001G3_A1ActividadId ;
      private String[] H001G3_A40000ProfesorFoto_GXI ;
      private String[] H001G3_A16ProfesorDireccion ;
      private String[] H001G3_A15ProfesorNombre ;
      private short[] H001G3_A2ProfesorId ;
      private String[] H001G3_A17ProfesorFoto ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXWebForm Form ;
   }

   public class gridactividadprofesor__default : DataStoreHelperBase, IDataStoreHelper
   {
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
          Object[] prmH001G2 ;
          prmH001G2 = new Object[] {
          } ;
          Object[] prmH001G3 ;
          prmH001G3 = new Object[] {
          new Object[] {"@ActividadId",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H001G2", "SELECT [ActividadDescripcion], [ActividadId] FROM [Actividad1] WITH (NOLOCK) ORDER BY [ActividadId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001G2,100,0,true,false )
             ,new CursorDef("H001G3", "SELECT [ActividadId], [ProfesorFoto_GXI], [ProfesorDireccion], [ProfesorNombre], [ProfesorId], [ProfesorFoto] FROM [Profesor] WITH (NOLOCK) WHERE [ActividadId] = @ActividadId ORDER BY [ActividadId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001G3,100,0,false,false )
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
                ((String[]) buf[0])[0] = rslt.getString(1, 20) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getMultimediaUri(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 20) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((String[]) buf[5])[0] = rslt.getMultimediaFile(6, rslt.getVarchar(2)) ;
                return;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
       }
    }

 }

}
