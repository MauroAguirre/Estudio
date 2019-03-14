/*
               File: GxWebStd
        Description: GeneXus Standard Web Functions
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 3/7/2019 21:18:38.88
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
namespace GeneXus.Programs {
   public class GxWebStd
   {
      static public void gx_hidden_field( IGxContext context ,
                                          String sCtrlName ,
                                          String sValue )
      {
         context.httpAjaxContext.ajax_rsp_assign_hidden(sCtrlName, sValue);
      }

      static public void gx_boolean_hidden_field( IGxContext context ,
                                                  String sCtrlName ,
                                                  bool bValue )
      {
         context.httpAjaxContext.ajax_rsp_assign_boolean_hidden(sCtrlName, bValue);
      }

      static public void gx_single_line_edit1( IGxContext context ,
                                               String sCtrlName ,
                                               String sValue ,
                                               String sFormatedValue ,
                                               String sTags ,
                                               String sEventName ,
                                               String sLinkURL ,
                                               String sLinkTarget ,
                                               String sTooltipText ,
                                               String sPlaceholder ,
                                               String sUserOnClickCode ,
                                               int nJScriptCode ,
                                               String sClassString ,
                                               String sStyleString ,
                                               String sROClassString ,
                                               String sColumnClassString ,
                                               String sColumnHeaderClassString ,
                                               int nVisible ,
                                               int nEnabled ,
                                               int nRTEnabled ,
                                               String sType ,
                                               String sStep ,
                                               int nWidth ,
                                               String nWidthUnit ,
                                               int nHeight ,
                                               String nHeightUnit ,
                                               int nLength ,
                                               short nIsPassword ,
                                               short nFormat ,
                                               int nParentId ,
                                               short bHasTheme ,
                                               short nAutoComplete ,
                                               short nAutoCorrection ,
                                               bool bSendHidden ,
                                               String sDomainType ,
                                               String sCallerPgm )
      {
         gx_single_line_edit( context, sCtrlName, sValue, sFormatedValue, sTags, sEventName, sLinkURL, sLinkTarget, sTooltipText, sPlaceholder, sUserOnClickCode, nJScriptCode, sClassString, sStyleString, sROClassString, sColumnClassString, sColumnHeaderClassString, nVisible, nEnabled, nRTEnabled, sType, sStep, nWidth, nWidthUnit, nHeight, nHeightUnit, nLength, nIsPassword, nFormat, nParentId, bHasTheme, nAutoComplete, nAutoCorrection, bSendHidden, sDomainType, "", false, sCallerPgm) ;
      }

      static public void gx_single_line_edit( IGxContext context ,
                                              String sCtrlName ,
                                              String sValue ,
                                              String sFormatedValue ,
                                              String sTags ,
                                              String sEventName ,
                                              String sLinkURL ,
                                              String sLinkTarget ,
                                              String sTooltipText ,
                                              String sPlaceholder ,
                                              String sUserOnClickCode ,
                                              int nJScriptCode ,
                                              String sClassString ,
                                              String sStyleString ,
                                              String sROClassString ,
                                              String sColumnClassString ,
                                              String sColumnHeaderClassString ,
                                              int nVisible ,
                                              int nEnabled ,
                                              int nRTEnabled ,
                                              String sType ,
                                              String sStep ,
                                              int nWidth ,
                                              String nWidthUnit ,
                                              int nHeight ,
                                              String nHeightUnit ,
                                              int nLength ,
                                              short nIsPassword ,
                                              short nFormat ,
                                              int nParentId ,
                                              short bHasTheme ,
                                              short nAutoComplete ,
                                              short nAutoCorrection ,
                                              bool bSendHidden ,
                                              String sDomainType ,
                                              String sAlign ,
                                              bool bIsTextEdit ,
                                              String sCallerPgm )
      {
         String sOStyle ;
         String sEventJsCode ;
         String ClassHTML ;
         String sSize ;
         if ( context.isSpaRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_prefixed_prop(sCtrlName, "Invitemessage", sPlaceholder);
            context.httpAjaxContext.ajax_rsp_assign_prefixed_prop(sCtrlName, "Tooltiptext", sTooltipText);
         }
         sEventJsCode = "";
         sSize = "";
         if ( context.GetWrapped( ) || ( bIsTextEdit && ( ( nRTEnabled != 0 ) || ( nEnabled != 0 ) ) ) )
         {
            sFormatedValue = sValue;
         }
         if ( nWidth > 0 )
         {
            if ( StringUtil.StrCmp(nWidthUnit, "chr") == 0 )
            {
               sSize = " size=\"" + nWidth + "\"";
            }
            else
            {
               sStyleString = sStyleString + ";width: " + StringUtil.LTrim( StringUtil.Str( (decimal)(nWidth), 10, 0)+nWidthUnit) + ";";
            }
         }
         if ( ( nHeight > 0 ) && ( StringUtil.StrCmp(nHeightUnit, "row") != 0 ) )
         {
            sStyleString = sStyleString + ";height: " + StringUtil.LTrim( StringUtil.Str( (decimal)(nHeight), 10, 0)+nHeightUnit) + ";";
         }
         sOStyle = sStyleString;
         sStyleString = sStyleString + ((nVisible==0)||((nEnabled==0)) ? ";display:none;" : "");
         if ( nVisible == 0 )
         {
            sClassString = sClassString + " gx-invisible";
         }
         if ( ( context.GetWrapped( ) && ( ( nRTEnabled != 0 ) || ( nEnabled != 0 ) ) ) || ! context.GetWrapped( ) )
         {
            /* Control allows input */
            context.WriteHtmlText( "<input type=") ;
            if ( nIsPassword != 0 )
            {
               context.WriteHtmlText( "\"password\"") ;
            }
            else
            {
               context.WriteHtmlText( "\"") ;
               context.SendWebValue( sType) ;
               context.WriteHtmlText( "\"") ;
            }
            context.WriteHtmlText( " id=\"") ;
            context.SendWebValue( StringUtil.Trim( sCtrlName)) ;
            context.WriteHtmlText( "\"") ;
            context.WriteHtmlText( " name=\"") ;
            context.SendWebValue( StringUtil.Trim( sCtrlName)) ;
            context.WriteHtmlText( "\"") ;
            context.WriteHtmlText( " value=\"") ;
            if ( ( nIsPassword == 0 ) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( sStep)) && ( ( StringUtil.StrCmp(sType, "number") == 0 ) || ( StringUtil.StrCmp(sType, "range") == 0 ) ) ) )
            {
               context.SendWebValue( StringUtil.Trim( sFormatedValue)) ;
               context.WriteHtmlText( "\"") ;
               context.WriteHtmlText( " min=\"-") ;
               context.SendWebValue( StringUtil.Trim( StringUtil.Str( Convert.ToDecimal( System.Math.Pow(Convert.ToDouble(10),Convert.ToDouble(nLength)))-1, 10, 0))) ;
               context.WriteHtmlText( "\"") ;
               context.WriteHtmlText( " max=\"") ;
               context.SendWebValue( StringUtil.Trim( StringUtil.Str( Convert.ToDecimal( System.Math.Pow(Convert.ToDouble(10),Convert.ToDouble(nLength)))-1, 10, 0))) ;
               context.WriteHtmlText( "\"") ;
               context.WriteHtmlText( " step=\"") ;
               context.SendWebValue( sStep) ;
               if ( StringUtil.StrCmp(sType, "search") == 0 )
               {
                  sTags = sTags + " onsearch=\"this.onchange();\"";
               }
            }
            else
            {
               context.SendWebValue( sFormatedValue) ;
            }
            context.WriteHtmlText( "\"") ;
            context.WriteHtmlText( sSize) ;
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( sTooltipText)) )
            {
               context.WriteHtmlText( " title=\"") ;
               context.SendWebValue( StringUtil.Trim( sTooltipText)) ;
               context.WriteHtmlText( "\"") ;
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( sPlaceholder)) )
            {
               context.WriteHtmlText( " placeholder=\"") ;
               context.SendWebValue( StringUtil.Trim( sPlaceholder)) ;
               context.WriteHtmlText( "\"") ;
            }
            context.WriteHtmlText( " spellcheck=") ;
            if ( nAutoCorrection == 0 )
            {
               context.WriteHtmlText( "\"false\"") ;
            }
            else
            {
               context.WriteHtmlText( "\"true\"") ;
            }
            if ( ( StringUtil.StrCmp(sType, "date") != 0 ) && ( StringUtil.StrCmp(sType, "datetime") != 0 ) && ( StringUtil.StrCmp(sType, "datetime-local") != 0 ) && ( StringUtil.StrCmp(sType, "number") != 0 ) )
            {
               context.WriteHtmlText( " maxlength=\"") ;
               context.WriteHtmlText( StringUtil.FormatLong( nLength)) ;
               context.WriteHtmlText( "\"") ;
            }
            GxWebStd.ClassAttribute( context, sClassString);
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( sAlign)) )
            {
               GxWebStd.StyleAttribute( context, sStyleString+"text-align:"+sAlign);
            }
            else
            {
               GxWebStd.StyleAttribute( context, sStyleString);
            }
            context.WriteHtmlText( sTags) ;
            context.WriteHtmlText( GXUtil.HtmlEndTag( HTMLElement.INPUT)) ;
            if ( nAutoComplete == 0 )
            {
               GxWebStd.gx_ctrl_attribute( context, sCtrlName, "autocomplete", "off", false);
            }
         }
         if ( nEnabled == 0 )
         {
            /* Control is read only */
            if ( bHasTheme == 0 )
            {
               ClassHTML = sClassString;
            }
            else
            {
               if ( nParentId == 0 )
               {
                  if ( ( StringUtil.Len( sClassString) != 0 ) && ( StringUtil.StringSearch( sClassString, "Readonly", 1) != 1 ) )
                  {
                     ClassHTML = "Readonly" + sClassString;
                  }
                  else
                  {
                     ClassHTML = sClassString;
                  }
               }
               else
               {
                  if ( ( StringUtil.Len( sROClassString) != 0 ) && ( StringUtil.StringSearch( sROClassString, "Readonly", 1) != 1 ) )
                  {
                     ClassHTML = "Readonly" + sROClassString;
                  }
                  else
                  {
                     ClassHTML = sROClassString;
                  }
               }
            }
            if ( nFormat != 2 )
            {
               sOStyle = sOStyle + ((nVisible==0) ? ";display:none;" : "");
               context.WriteHtmlText( "<span") ;
               GxWebStd.ClassAttribute( context, ClassHTML);
               GxWebStd.StyleAttribute( context, sOStyle);
               context.WriteHtmlText( ((StringUtil.Len( sTooltipText)>0) ? " title=\""+sTooltipText+"\"" : "")+" id=\"span_"+sCtrlName+"\""+" data-name=\"span_"+sCtrlName+"\""+" data-gx-enabled-id=\""+sCtrlName+"\"") ;
               context.WriteHtmlText( ">") ;
               /* Initialize internal JScript code according to EventNo */
               if ( nJScriptCode == 1 )
               {
                  sEventJsCode = "gx.fn.closeWindow();";
               }
               else if ( nJScriptCode == 3 )
               {
                  sEventJsCode = "gx.util.help(" + "'" + context.convertURL( "Help/"+"English/"+StringUtil.Lower( sCallerPgm)) + "');";
               }
               else if ( nJScriptCode == 7 )
               {
                  sEventJsCode = "" + "gx.evt.execCliEvt(" + sEventName + ",this);";
               }
               else if ( nJScriptCode == 8 )
               {
                  sEventJsCode = "gx.evt.execEvt(" + sEventName + ",this);";
               }
               else if ( nJScriptCode == 6 )
               {
                  sEventJsCode = "gx.evt.execEvt(" + sEventName + ",this);";
               }
               else if ( nJScriptCode == 5 )
               {
                  sEventJsCode = "gx.evt.execEvt(" + sEventName + ",this);";
               }
               else if ( nJScriptCode == 0 )
               {
                  sEventJsCode = "";
               }
               else
               {
                  sEventJsCode = "";
               }
               GxWebStd.gx_start_js_anchor( context, nJScriptCode, sEventJsCode, sUserOnClickCode, sLinkURL, sLinkTarget, "");
            }
            if ( nIsPassword == 0 )
            {
               if ( nFormat == 0 )
               {
                  /* Text */
                  context.SendWebValue( StringUtil.Trim( sFormatedValue)) ;
               }
               else
               {
                  if ( nFormat == 3 )
                  {
                     /* Text with meaningful spaces */
                     context.SendWebValueSpace( sFormatedValue) ;
                  }
                  else
                  {
                     context.WriteHtmlText( sFormatedValue) ;
                  }
               }
            }
            else
            {
               context.SendWebValue( StringUtil.PadR( "", (short)(nLength), "*")) ;
            }
            if ( nFormat != 2 )
            {
               GxWebStd.gx_end_js_anchor( context, sEventJsCode, sUserOnClickCode, sLinkURL);
               context.WriteHtmlText( "</span>") ;
            }
         }
      }

      static public void gx_link_start( IGxContext context ,
                                        String sLinkURL ,
                                        String sTargetWnd ,
                                        String sClassString )
      {
         if ( StringUtil.StrCmp("", StringUtil.RTrim( sLinkURL)) != 0 )
         {
            context.WriteHtmlText( "<a href=\"") ;
            context.WriteHtmlText( StringUtil.RTrim( sLinkURL)) ;
            context.WriteHtmlText( "\"") ;
            if ( StringUtil.StrCmp("", StringUtil.RTrim( sTargetWnd)) != 0 )
            {
               context.WriteHtmlText( " target=\"") ;
               context.WriteHtmlText( StringUtil.RTrim( sTargetWnd)) ;
               context.WriteHtmlText( "\"") ;
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( sClassString)) )
            {
               context.WriteHtmlText( "class=\"") ;
               context.WriteHtmlText( sClassString) ;
               context.WriteHtmlText( "\"") ;
            }
            context.WriteHtmlText( ">") ;
         }
      }

      static public void gx_link_end( IGxContext context ,
                                      String sLinkURL )
      {
         if ( StringUtil.StrCmp("", StringUtil.RTrim( sLinkURL)) != 0 )
         {
            context.WriteHtmlText( "</a>") ;
         }
      }

      static public void gx_blob_field( IGxContext context ,
                                        String sInternalName ,
                                        String sValue ,
                                        String sURL ,
                                        String sContenttype ,
                                        bool bHasFiletypeatt ,
                                        String sLinktarget ,
                                        String sObjecttagparameters ,
                                        int nDisplay ,
                                        int nEnabled ,
                                        int nVisible ,
                                        String sAlternateText ,
                                        String sTooltipText ,
                                        int nBorderWidth ,
                                        int nAutoresize ,
                                        int nWidth ,
                                        String nWidthUnit ,
                                        int nHeight ,
                                        String nHeightUnit ,
                                        int nVerticalSpace ,
                                        int nHorizontalSpace ,
                                        int nJScriptCode ,
                                        String sUserOnClickCode ,
                                        String sEventName ,
                                        String sStyleString ,
                                        String sClassString ,
                                        String sColumnClassString ,
                                        String sColumnHeaderClassString ,
                                        String sInputTags ,
                                        String sDisplayTags ,
                                        String sJsDynCode ,
                                        String sCallerPgm )
      {
         String sEventJsCode ;
         String ClassHTML ;
         sEventJsCode = "";
         sStyleString = sStyleString + ((nVisible!=0) ? "" : ";display:none;");
         if ( nEnabled != 0 )
         {
            /* Initialize internal JScript code according to EventNo */
            if ( nJScriptCode == 4 )
            {
               sEventJsCode = sJsDynCode;
            }
            else if ( nJScriptCode == 1 )
            {
               sEventJsCode = "gx.fn.closeWindow();" + "return false;";
            }
            else if ( nJScriptCode == 3 )
            {
               sEventJsCode = "gx.util.help(" + "'" + context.convertURL( "Help/"+"English/"+StringUtil.Lower( sCallerPgm)) + "');" + "return false;";
            }
            else if ( nJScriptCode == 7 )
            {
               sEventJsCode = "" + "gx.evt.execCliEvt(" + sEventName + ",this);";
            }
            else if ( nJScriptCode == 8 )
            {
               sEventJsCode = "gx.evt.execEvt(" + sEventName + ",this);" + "return false;";
            }
            else if ( nJScriptCode == 6 )
            {
               sEventJsCode = "gx.evt.execEvt(" + sEventName + ",this);";
            }
            else if ( nJScriptCode == 5 )
            {
               sEventJsCode = "gx.evt.execEvt(" + sEventName + ",this);";
            }
            else if ( nJScriptCode == 0 )
            {
               sEventJsCode = "";
            }
            else
            {
               sEventJsCode = "";
            }
         }
         context.WriteHtmlText( "<div class=\"gx-tbldsp-container\" style=\"") ;
         if ( ! (0==nWidth) && ( ( nAutoresize == 0 ) ) )
         {
            context.WriteHtmlText( " width:") ;
            context.WriteHtmlText( StringUtil.LTrim( StringUtil.Str( (decimal)(nWidth), 10, 0))) ;
            context.WriteHtmlText( nWidthUnit+";") ;
         }
         if ( ! (0==nHeight) && ( ( nAutoresize == 0 ) ) )
         {
            context.WriteHtmlText( " height:") ;
            context.WriteHtmlText( StringUtil.LTrim( StringUtil.Str( (decimal)(nHeight), 10, 0))) ;
            context.WriteHtmlText( nHeightUnit+";") ;
         }
         context.WriteHtmlText( "margin:") ;
         context.WriteHtmlText( StringUtil.LTrim( StringUtil.Str( (decimal)(nVerticalSpace), 10, 0))) ;
         context.WriteHtmlText( "px ") ;
         context.WriteHtmlText( StringUtil.LTrim( StringUtil.Str( (decimal)(nHorizontalSpace), 10, 0))) ;
         context.WriteHtmlText( "px;\"") ;
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( sTooltipText)) )
         {
            context.WriteHtmlText( " title=\"") ;
            context.SendWebValue( StringUtil.Trim( sTooltipText)) ;
            context.WriteHtmlText( "\"") ;
         }
         context.WriteHtmlText( "><div>") ;
         if ( nDisplay == 0 )
         {
            if ( context.CheckContentType( "image", sContenttype, sURL) )
            {
               context.WriteHtmlText( "<img") ;
               context.WriteHtmlText( " alt=\"") ;
               context.SendWebValue( (String.IsNullOrEmpty(StringUtil.RTrim( sAlternateText)) ? sTooltipText : sAlternateText)) ;
               context.WriteHtmlText( "\"") ;
               context.WriteHtmlText( " src=\"") ;
               if ( String.IsNullOrEmpty(StringUtil.RTrim( sURL)) )
               {
                  sURL = context.convertURL( context.GetImagePath( "blank.jpg", "", context.GetTheme( )));
               }
            }
            else
            {
               context.WriteHtmlText( "<object ") ;
               context.WriteHtmlText( "type=\"") ;
               context.WriteHtmlText( context.GetContentType( sContenttype)) ;
               context.WriteHtmlText( "\" data=\"") ;
               if ( String.IsNullOrEmpty(StringUtil.RTrim( sURL)) )
               {
                  sURL = "about:blank";
               }
            }
            context.WriteHtmlText( context.convertURL( sURL)) ;
            context.WriteHtmlText( "\" id=\"Object_") ;
            context.WriteHtmlText( sInternalName) ;
            context.WriteHtmlText( "\" style=\"display:block;") ;
            if ( ! (0==nWidth) && ( ( nAutoresize == 0 ) ) )
            {
               context.WriteHtmlText( " width:") ;
               context.WriteHtmlText( StringUtil.LTrim( StringUtil.Str( (decimal)(nWidth), 10, 0))) ;
               context.WriteHtmlText( nWidthUnit+";") ;
            }
            if ( ! (0==nHeight) && ( ( nAutoresize == 0 ) ) )
            {
               context.WriteHtmlText( " height:") ;
               context.WriteHtmlText( StringUtil.LTrim( StringUtil.Str( (decimal)(nHeight), 10, 0))) ;
               context.WriteHtmlText( nHeightUnit+";") ;
            }
            context.SendWebValue( CSSHelper.Prettify( sStyleString)) ;
            if ( StringUtil.Len( sClassString) != 0 )
            {
               ClassHTML = "BlobContent" + sClassString;
            }
            else
            {
               ClassHTML = sClassString;
            }
            if ( ( nEnabled == 0 ) && ( StringUtil.Len( sClassString) != 0 ) && ( StringUtil.StringSearch( sClassString, "Readonly", 1) != 1 ) )
            {
               ClassHTML = "Readonly" + ClassHTML;
            }
            context.WriteHtmlText( "\" ") ;
            GxWebStd.ClassAttribute( context, ClassHTML);
            context.WriteHtmlText( sDisplayTags) ;
            if ( context.CheckContentType( "image", sContenttype, sURL) )
            {
               context.WriteHtmlText( GXUtil.HtmlEndTag( HTMLElement.IMG)) ;
            }
            else
            {
               context.WriteHtmlText( ">") ;
               context.WriteHtmlText( sObjecttagparameters) ;
               context.WriteHtmlText( "</object>") ;
            }
         }
         else
         {
            if ( nDisplay == 1 )
            {
               context.WriteHtmlText( "<a id=\"Link_") ;
               context.WriteHtmlText( sInternalName) ;
               context.WriteHtmlText( "\"") ;
               if ( StringUtil.StrCmp(sURL, "") != 0 )
               {
                  GxWebStd.StyleAttribute( context, "display:block;"+sStyleString);
               }
               else
               {
                  GxWebStd.StyleAttribute( context, "display:none;"+sStyleString);
               }
               context.WriteHtmlText( "href=\"") ;
               context.WriteHtmlText( context.convertURL( sURL)) ;
               context.WriteHtmlText( "\" type=\"") ;
               context.WriteHtmlText( sContenttype) ;
               context.WriteHtmlText( "\"") ;
               if ( StringUtil.Len( sLinktarget) > 0 )
               {
                  context.WriteHtmlText( " target=\"") ;
                  context.WriteHtmlText( StringUtil.RTrim( sLinktarget)) ;
                  context.WriteHtmlText( "\"") ;
               }
               context.WriteHtmlText( "><img border=\"0\" src=\"") ;
               context.WriteHtmlText( context.convertURL( context.GetImagePath( "download.gif", "", context.GetTheme( )))) ;
               context.WriteHtmlText( "\" alt=\"Download\""+GXUtil.HtmlEndTag( HTMLElement.IMG)) ;
               context.WriteHtmlText( "</a>") ;
            }
         }
         context.WriteHtmlText( "</div><div>") ;
         if ( nEnabled == 1 )
         {
            context.WriteHtmlText( "<script type=\"text/javascript\">document.forms[0].encoding=\"multipart/form-data\";</script>") ;
            context.WriteHtmlText( "<input type=\"file\" ") ;
            context.WriteHtmlText( " id=\"") ;
            context.WriteHtmlText( sInternalName) ;
            context.WriteHtmlText( "\"") ;
            context.WriteHtmlText( " name=\"") ;
            context.WriteHtmlText( sInternalName) ;
            context.WriteHtmlText( "\"") ;
            sStyleString = "";
            if ( nVisible == 0 )
            {
               sStyleString = "display:none;";
            }
            if ( ! (0==nWidth) )
            {
               sStyleString = sStyleString + " width:" + StringUtil.LTrim( StringUtil.Str( (decimal)(nWidth), 10, 0)) + nWidthUnit + ";";
            }
            GxWebStd.StyleAttribute( context, sStyleString);
            context.WriteHtmlText( " value=\"") ;
            context.SendWebValue( sValue) ;
            context.WriteHtmlText( "\" ") ;
            if ( StringUtil.Len( sClassString) != 0 )
            {
               ClassHTML = "BlobInput" + sClassString;
            }
            else
            {
               ClassHTML = sClassString;
            }
            if ( ( nEnabled == 0 ) && ( StringUtil.Len( sClassString) != 0 ) && ( StringUtil.StringSearch( sClassString, "Readonly", 1) != 1 ) )
            {
               ClassHTML = "Readonly" + ClassHTML;
            }
            GxWebStd.ClassAttribute( context, ClassHTML);
            if ( context.CheckContentType( "image", sContenttype, sURL) )
            {
               context.WriteHtmlText( " accept=\"") ;
               context.WriteHtmlText( sContenttype) ;
               context.WriteHtmlText( "\" ") ;
            }
            context.WriteHtmlText( sInputTags) ;
            context.WriteHtmlText( GXUtil.HtmlEndTag( HTMLElement.INPUT)) ;
         }
         context.WriteHtmlText( "</div></div>") ;
      }

      static public void gx_button_ctrl( IGxContext context ,
                                         String sCtrlName ,
                                         String sJsCode ,
                                         String sCaption ,
                                         String sUserOnClickCode ,
                                         int nJScriptCode ,
                                         String sTooltipText ,
                                         String sAccesskey ,
                                         String sStyleString ,
                                         String sClassString ,
                                         int nVisible ,
                                         int nEnabled ,
                                         String sBorderStyle ,
                                         String sEventName ,
                                         String sTags ,
                                         String sJsDynCode ,
                                         int nReset ,
                                         String sCallerPgm )
      {
         String sEventJsCode ;
         String sCapAKey ;
         String sClassRoundedBtn ;
         if ( context.isSpaRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_prefixed_prop(sCtrlName, "Tooltiptext", sTooltipText);
         }
         sStyleString = sStyleString + ((nVisible!=0) ? "" : ";display:none;");
         sClassRoundedBtn = "BaseRBtn " + "R" + sClassString;
         if ( StringUtil.StrCmp(sBorderStyle, "rounded") == 0 )
         {
            sClassString = "BtnText";
            context.WriteHtmlText( "<span onclick=\"gx.evt.doClick(") ;
            context.WriteHtmlText( "'") ;
            context.SendWebValue( StringUtil.Trim( sCtrlName)) ;
            context.WriteHtmlText( "', event") ;
            context.WriteHtmlText( ")\" ") ;
            GxWebStd.StyleAttribute( context, sStyleString);
            GxWebStd.ClassAttribute( context, sClassRoundedBtn);
            context.WriteHtmlText( "><span class=\"BtnLeft\"><span class=\"BtnRight\"><span class=\"BtnBackground\">") ;
         }
         context.WriteHtmlText( "<input type=") ;
         if ( nReset == 1 )
         {
            context.WriteHtmlText( "\"submit\"") ;
         }
         else if ( nReset == 0 )
         {
            context.WriteHtmlText( "\"reset\"") ;
         }
         else
         {
            context.WriteHtmlText( "\"button\"") ;
         }
         sCapAKey = GXUtil.AccessKey( sCaption);
         sCaption = GXUtil.AccessKeyCaption( sCaption);
         if ( String.IsNullOrEmpty(StringUtil.RTrim( sCapAKey)) )
         {
            sCapAKey = GXUtil.AccessKey( sTooltipText);
            sTooltipText = GXUtil.AccessKeyCaption( sTooltipText);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( sCapAKey)) )
         {
            sAccesskey = sCapAKey;
         }
         context.WriteHtmlText( " name=\"") ;
         context.SendWebValue( StringUtil.Trim( sCtrlName)) ;
         context.WriteHtmlText( "\"") ;
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( sCaption)) )
         {
            context.WriteHtmlText( " value=\"") ;
            context.SendWebValue( StringUtil.Trim( sCaption)) ;
            context.WriteHtmlText( "\"") ;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( sTooltipText)) )
         {
            context.WriteHtmlText( " title=\"") ;
            context.SendWebValue( StringUtil.Trim( sTooltipText)) ;
            context.WriteHtmlText( "\"") ;
         }
         if ( StringUtil.Len( sAccesskey) != 0 )
         {
            context.WriteHtmlText( " accesskey=\"") ;
            context.SendWebValue( StringUtil.Trim( sAccesskey)) ;
            context.WriteHtmlText( "\"") ;
         }
         GxWebStd.ClassAttribute( context, sClassString);
         GxWebStd.StyleAttribute( context, sStyleString);
         if ( nEnabled == 0 )
         {
            context.WriteHtmlText( " disabled=\"disabled\"") ;
         }
         /* Initialize internal JScript code according to EventNo */
         if ( nJScriptCode == 4 )
         {
            sEventJsCode = sJsDynCode;
         }
         else if ( nJScriptCode == 1 )
         {
            sEventJsCode = "gx.fn.closeWindow();" + "return false;";
         }
         else if ( nJScriptCode == 3 )
         {
            sEventJsCode = "gx.util.help(" + "'" + context.convertURL( "Help/"+"English/"+StringUtil.Lower( sCallerPgm)) + "');" + "return false;";
         }
         else if ( nJScriptCode == 7 )
         {
            sEventJsCode = "gx.evt.checkCtrlFocus(this);" + "gx.evt.execCliEvt(" + sEventName + ",this);";
         }
         else if ( nJScriptCode == 8 )
         {
            sEventJsCode = "gx.evt.execEvt(" + sEventName + ",this);" + "return false;";
         }
         else if ( nJScriptCode == 6 )
         {
            sEventJsCode = "gx.evt.execEvt(" + sEventName + ",this);";
         }
         else if ( nJScriptCode == 5 )
         {
            sEventJsCode = "gx.evt.execEvt(" + sEventName + ",this);";
         }
         else if ( nJScriptCode == 0 )
         {
            sEventJsCode = "";
         }
         else
         {
            sEventJsCode = "";
         }
         sEventJsCode = sJsCode + sEventJsCode;
         GxWebStd.gx_on_js_event( context, "onclick", sEventJsCode);
         context.WriteHtmlText( " ") ;
         context.WriteHtmlText( sTags) ;
         context.WriteHtmlText( GXUtil.HtmlEndTag( HTMLElement.INPUT)) ;
         GxWebStd.gx_ctrl_attribute( context, sCtrlName, "data-jsevent", sUserOnClickCode, false);
         if ( StringUtil.StrCmp(sBorderStyle, "rounded") == 0 )
         {
            context.WriteHtmlText( "</span></span></span></span>") ;
         }
      }

      static public void gx_on_js_event( IGxContext context ,
                                         String sEventName ,
                                         String sEventJsCode )
      {
         context.WriteHtmlText( " ") ;
         context.SendWebValue( sEventName) ;
         context.WriteHtmlText( "=\"if( ") ;
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( sEventJsCode)) )
         {
            context.WriteHtmlText( "gx.evt.jsEvent(this)") ;
            context.WriteHtmlText( ") {") ;
            context.WriteHtmlText( sEventJsCode) ;
            context.WriteHtmlText( "} else return false;\"") ;
         }
         else
         {
            context.WriteHtmlText( "!(") ;
            context.WriteHtmlText( "gx.evt.jsEvent(this)") ;
            context.WriteHtmlText( ")) return false;\"") ;
         }
      }

      static public void gx_ctrl_attribute( IGxContext context ,
                                            String sControlName ,
                                            String sAttName ,
                                            String sAttValue ,
                                            bool bCustomEvent )
      {
         if ( bCustomEvent )
         {
            context.WriteHtmlText( "<script type=\"text/javascript\">gx.dom.setAttribute(\"") ;
            context.SendWebValue( sControlName) ;
            context.WriteHtmlText( "\",\"") ;
            context.SendWebValue( sAttName) ;
            context.WriteHtmlText( "\",\"if(") ;
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( sAttValue)) )
            {
               context.WriteHtmlText( "gx.evt.jsEvent(this)") ;
               context.WriteHtmlText( ") {") ;
               context.WriteHtmlText( sAttValue) ;
               context.WriteHtmlText( "} else return false;\"") ;
            }
            else
            {
               context.WriteHtmlText( "!(") ;
               context.WriteHtmlText( "gx.evt.jsEvent(this)") ;
               context.WriteHtmlText( ")) return false;\"") ;
            }
            context.WriteHtmlText( ");</script>") ;
         }
         else
         {
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( sAttValue)) )
            {
               context.WriteHtmlText( "<script type=\"text/javascript\">gx.dom.setAttribute(\"") ;
               context.SendWebValue( sControlName) ;
               context.WriteHtmlText( "\",\"") ;
               context.SendWebValue( sAttName) ;
               context.WriteHtmlText( "\",\"") ;
               context.WriteHtmlText( sAttValue) ;
               context.WriteHtmlText( "\");</script>") ;
            }
         }
      }

      static public void gx_msg_list( IGxContext context ,
                                      String sCtrlName ,
                                      int nDisplayMode ,
                                      String sStyleString ,
                                      String sClassString ,
                                      String sCmpCtx ,
                                      String sInMaster )
      {
         int i ;
         context.WriteHtmlText( "<div>") ;
         sClassString = sClassString + " gx_ev";
         if ( nDisplayMode == 1 )
         {
            sClassString = sClassString + " ErrorViewerBullet";
         }
         context.WriteHtmlText( "<span") ;
         GxWebStd.ClassAttribute( context, sClassString);
         GxWebStd.StyleAttribute( context, sStyleString);
         context.WriteHtmlText( " id=\""+sCmpCtx+"gxErrorViewer\"") ;
         context.WriteHtmlText( ">") ;
         if ( ! context.isSpaRequest( ) )
         {
            i = 1;
            while ( i <= context.GX_msglist.ItemCount )
            {
               context.WriteHtmlText( "<div") ;
               GxWebStd.ClassAttribute( context, ((context.GX_msglist.getItemType((short)(i))==1) ? "gx-error-message" : "gx-warning-message"));
               context.WriteHtmlText( ">") ;
               context.WriteHtmlText( GXUtil.ValueEncode( context.GX_msglist.getItemText((short)(i)))) ;
               context.WriteHtmlText( "</div>") ;
               i = (int)(i+1);
            }
         }
         context.WriteHtmlText( "</span>") ;
         context.WriteHtmlText( "</div>") ;
      }

      static public void gx_combobox_ctrl( IGxContext context ,
                                           GXCombobox cmbCObjCtrl ,
                                           String sCtrlName ,
                                           String sValue ,
                                           int nRows ,
                                           String sUserOnClickCode ,
                                           int nJScriptCode ,
                                           String sEventName ,
                                           String sType ,
                                           String sTooltipText ,
                                           int nVisible ,
                                           int nEnabled ,
                                           int nRTEnabled ,
                                           short nFormat ,
                                           int nWidth ,
                                           String nWidthUnit ,
                                           int nHeight ,
                                           String nHeightUnit ,
                                           String sStyleString ,
                                           String sClassString ,
                                           String sColumnClassString ,
                                           String sColumnHeaderClassString ,
                                           String sTags ,
                                           String sFormatedValue ,
                                           String sCallerPgm )
      {
         gx_combobox_ctrl1( context, cmbCObjCtrl, sCtrlName, sValue, nRows, sUserOnClickCode, nJScriptCode, sEventName, sType, sTooltipText, nVisible, nEnabled, nRTEnabled, nFormat, nWidth, nWidthUnit, nHeight, nHeightUnit, sStyleString, sClassString, sColumnClassString, sColumnHeaderClassString, sTags, sFormatedValue, true, sCallerPgm) ;
      }

      static public void gx_combobox_ctrl1( IGxContext context ,
                                            GXCombobox cmbCObjCtrl ,
                                            String sCtrlName ,
                                            String sValue ,
                                            int nRows ,
                                            String sUserOnClickCode ,
                                            int nJScriptCode ,
                                            String sEventName ,
                                            String sType ,
                                            String sTooltipText ,
                                            int nVisible ,
                                            int nEnabled ,
                                            int nRTEnabled ,
                                            short nFormat ,
                                            int nWidth ,
                                            String nWidthUnit ,
                                            int nHeight ,
                                            String nHeightUnit ,
                                            String sStyleString ,
                                            String sClassString ,
                                            String sColumnClassString ,
                                            String sColumnHeaderClassString ,
                                            String sTags ,
                                            String sFormatedValue ,
                                            bool bSendHidden ,
                                            String sCallerPgm )
      {
         String sOStyle ;
         String sEventJsCode ;
         int idxLst ;
         String ClassHTML ;
         idxLst = 1;
         if ( nWidth > 0 )
         {
            sStyleString = sStyleString + ";width: " + StringUtil.LTrim( StringUtil.Str( (decimal)(nWidth), 10, 0)+nWidthUnit);
         }
         if ( nHeight > 0 )
         {
            sStyleString = sStyleString + ";height: " + StringUtil.LTrim( StringUtil.Str( (decimal)(nHeight), 10, 0)+nHeightUnit);
         }
         sOStyle = sStyleString + " ;overflow:hidden;";
         sStyleString = sStyleString + ((nVisible==0)||(nEnabled==0) ? ";display:none;" : "");
         /* Initialize internal JScript code according to EventNo */
         if ( nJScriptCode == 1 )
         {
            sEventJsCode = "gx.fn.closeWindow();" + "return false;";
         }
         else if ( nJScriptCode == 3 )
         {
            sEventJsCode = "gx.util.help(" + "'" + context.convertURL( "Help/"+"English/"+StringUtil.Lower( sCallerPgm)) + "');" + "return false;";
         }
         else if ( nJScriptCode == 7 )
         {
            sEventJsCode = "" + "gx.evt.execCliEvt(" + sEventName + ",this);";
         }
         else if ( nJScriptCode == 8 )
         {
            sEventJsCode = "gx.evt.execEvt(" + sEventName + ",this);" + "return false;";
         }
         else if ( nJScriptCode == 6 )
         {
            sEventJsCode = "gx.evt.execEvt(" + sEventName + ",this);";
         }
         else if ( nJScriptCode == 5 )
         {
            sEventJsCode = "gx.evt.execEvt(" + sEventName + ",this);";
         }
         else if ( nJScriptCode == 0 )
         {
            sEventJsCode = "";
         }
         else
         {
            sEventJsCode = "";
         }
         context.WriteHtmlText( "<select") ;
         if ( nRows > 1 )
         {
            context.WriteHtmlText( " size=") ;
            context.WriteHtmlText( StringUtil.LTrim( StringUtil.FormatLong( nRows))) ;
         }
         context.WriteHtmlText( " id=\"") ;
         context.SendWebValue( StringUtil.Trim( sCtrlName)) ;
         context.WriteHtmlText( "\" name=\"") ;
         context.SendWebValue( StringUtil.Trim( sCtrlName)) ;
         context.WriteHtmlText( "\"") ;
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( sTooltipText)) )
         {
            context.WriteHtmlText( " title=\"") ;
            context.SendWebValue( StringUtil.Trim( sTooltipText)) ;
            context.WriteHtmlText( "\"") ;
         }
         GxWebStd.ClassAttribute( context, sClassString);
         GxWebStd.StyleAttribute( context, sStyleString);
         context.WriteHtmlText( sTags) ;
         context.WriteHtmlTextNl( ">") ;
         while ( idxLst <= cmbCObjCtrl.ItemCount )
         {
            if ( StringUtil.StrCmp(sType, "int") == 0 )
            {
               context.WriteHtmlText( "<option value=\"") ;
               context.SendWebValue( StringUtil.Trim( cmbCObjCtrl.getItemValue((short)(idxLst)))) ;
            }
            else
            {
               context.WriteHtmlText( "<option value=\"") ;
               context.SendWebValue( StringUtil.RTrim( cmbCObjCtrl.getItemValue((short)(idxLst)))) ;
            }
            if ( StringUtil.StrCmp(StringUtil.LTrim( cmbCObjCtrl.getItemValue((short)(idxLst))), StringUtil.LTrim( sValue)) == 0 )
            {
               context.WriteHtmlText( "\" selected=\"selected\" >") ;
            }
            else
            {
               context.WriteHtmlText( "\">") ;
            }
            if ( nFormat == 0 )
            {
               context.SendWebValue( cmbCObjCtrl.getItemText((short)(idxLst))) ;
            }
            else
            {
               if ( nFormat == 3 )
               {
                  context.SendWebValueSpace( cmbCObjCtrl.getItemText((short)(idxLst))) ;
               }
               else
               {
                  context.WriteHtmlText( cmbCObjCtrl.getItemText((short)(idxLst))) ;
               }
            }
            context.WriteHtmlText( GXUtil.HtmlEndTag( HTMLElement.OPTION)) ;
            idxLst = (int)(idxLst+1);
         }
         context.WriteHtmlTextNl( "</select>") ;
         GxWebStd.gx_ctrl_attribute( context, sCtrlName, "data-jsevent", sUserOnClickCode, false);
         GxWebStd.gx_ctrl_attribute( context, sCtrlName, "data-gxoch0", sEventJsCode, true);
         if ( nEnabled == 0 )
         {
            if ( ( StringUtil.Len( sClassString) != 0 ) && ( StringUtil.StringSearch( sClassString, "Readonly", 1) != 1 ) )
            {
               ClassHTML = "Readonly" + sClassString;
            }
            else
            {
               ClassHTML = sClassString;
            }
            sOStyle = sOStyle + ((nVisible==0) ? ";display:none;" : "");
            idxLst = 1;
            context.WriteHtmlText( "<span") ;
            GxWebStd.ClassAttribute( context, ClassHTML);
            GxWebStd.StyleAttribute( context, sOStyle);
            context.WriteHtmlText( ((StringUtil.Len( sTooltipText)>0) ? " title=\""+sTooltipText+"\"" : "")+" id=\"span_"+sCtrlName+"\"") ;
            context.WriteHtmlText( ">") ;
            while ( idxLst <= cmbCObjCtrl.ItemCount )
            {
               if ( StringUtil.StrCmp(StringUtil.LTrim( cmbCObjCtrl.getItemValue((short)(idxLst))), StringUtil.LTrim( sValue)) == 0 )
               {
                  if ( nFormat == 0 )
                  {
                     context.SendWebValue( cmbCObjCtrl.getItemText((short)(idxLst))) ;
                  }
                  else
                  {
                     if ( nFormat == 3 )
                     {
                        context.SendWebValueSpace( cmbCObjCtrl.getItemText((short)(idxLst))) ;
                     }
                     else
                     {
                        context.WriteHtmlText( cmbCObjCtrl.getItemText((short)(idxLst))) ;
                     }
                  }
                  if (true) break;
               }
               idxLst = (int)(idxLst+1);
            }
            context.WriteHtmlText( "</span>") ;
            if ( nEnabled == 0 )
            {
               context.WriteHtmlText( "<script type=\"text/javascript\">gx.fn.disableCtrl(\""+sCtrlName+"\");</script>") ;
            }
         }
      }

      static public void gx_listbox_ctrl( IGxContext context ,
                                          GXListbox lstLObjCtrl ,
                                          String sCtrlName ,
                                          String sValue ,
                                          int nRows ,
                                          String sUserOnClickCode ,
                                          int nJScriptCode ,
                                          String sEventName ,
                                          String sType ,
                                          String sTooltipText ,
                                          int nVisible ,
                                          int nEnabled ,
                                          int nRTEnabled ,
                                          short nFormat ,
                                          int nWidth ,
                                          String nWidthUnit ,
                                          int nHeight ,
                                          String nHeightUnit ,
                                          String sStyleString ,
                                          String sClassString ,
                                          String sColumnClassString ,
                                          String sColumnHeaderClassString ,
                                          String sTags ,
                                          String sFormatedValue ,
                                          String sCallerPgm )
      {
         gx_listbox_ctrl1( context, lstLObjCtrl, sCtrlName, sValue, nRows, sUserOnClickCode, nJScriptCode, sEventName, sType, sTooltipText, nVisible, nEnabled, nRTEnabled, nFormat, nWidth, nWidthUnit, nHeight, nHeightUnit, sStyleString, sClassString, sColumnClassString, sColumnHeaderClassString, sTags, sFormatedValue, true, sCallerPgm) ;
      }

      static public void gx_listbox_ctrl1( IGxContext context ,
                                           GXListbox lstLObjCtrl ,
                                           String sCtrlName ,
                                           String sValue ,
                                           int nRows ,
                                           String sUserOnClickCode ,
                                           int nJScriptCode ,
                                           String sEventName ,
                                           String sType ,
                                           String sTooltipText ,
                                           int nVisible ,
                                           int nEnabled ,
                                           int nRTEnabled ,
                                           short nFormat ,
                                           int nWidth ,
                                           String nWidthUnit ,
                                           int nHeight ,
                                           String nHeightUnit ,
                                           String sStyleString ,
                                           String sClassString ,
                                           String sColumnClassString ,
                                           String sColumnHeaderClassString ,
                                           String sTags ,
                                           String sFormatedValue ,
                                           bool bSendHidden ,
                                           String sCallerPgm )
      {
         String sOStyle ;
         String sEventJsCode ;
         int idxLst ;
         String ClassHTML ;
         idxLst = 1;
         if ( nWidth > 0 )
         {
            sStyleString = sStyleString + ";width: " + StringUtil.LTrim( StringUtil.Str( (decimal)(nWidth), 10, 0)+nWidthUnit);
         }
         if ( nHeight > 0 )
         {
            sStyleString = sStyleString + ";height: " + StringUtil.LTrim( StringUtil.Str( (decimal)(nHeight), 10, 0)+nHeightUnit);
         }
         sOStyle = sStyleString + " ;overflow:hidden;";
         sStyleString = sStyleString + ((nVisible==0)||(nEnabled==0) ? ";display:none;" : "");
         /* Initialize internal JScript code according to EventNo */
         if ( nJScriptCode == 1 )
         {
            sEventJsCode = "gx.fn.closeWindow();" + "return false;";
         }
         else if ( nJScriptCode == 3 )
         {
            sEventJsCode = "gx.util.help(" + "'" + context.convertURL( "Help/"+"English/"+StringUtil.Lower( sCallerPgm)) + "');" + "return false;";
         }
         else if ( nJScriptCode == 7 )
         {
            sEventJsCode = "" + "gx.evt.execCliEvt(" + sEventName + ",this);";
         }
         else if ( nJScriptCode == 8 )
         {
            sEventJsCode = "gx.evt.execEvt(" + sEventName + ",this);" + "return false;";
         }
         else if ( nJScriptCode == 6 )
         {
            sEventJsCode = "gx.evt.execEvt(" + sEventName + ",this);";
         }
         else if ( nJScriptCode == 5 )
         {
            sEventJsCode = "gx.evt.execEvt(" + sEventName + ",this);";
         }
         else if ( nJScriptCode == 0 )
         {
            sEventJsCode = "";
         }
         else
         {
            sEventJsCode = "";
         }
         context.WriteHtmlText( "<select") ;
         if ( nRows > 1 )
         {
            context.WriteHtmlText( " size=") ;
            context.WriteHtmlText( StringUtil.LTrim( StringUtil.FormatLong( nRows))) ;
         }
         context.WriteHtmlText( " id=\"") ;
         context.SendWebValue( StringUtil.Trim( sCtrlName)) ;
         context.WriteHtmlText( "\" name=\"") ;
         context.SendWebValue( StringUtil.Trim( sCtrlName)) ;
         context.WriteHtmlText( "\"") ;
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( sTooltipText)) )
         {
            context.WriteHtmlText( " title=\"") ;
            context.SendWebValue( StringUtil.Trim( sTooltipText)) ;
            context.WriteHtmlText( "\"") ;
         }
         GxWebStd.ClassAttribute( context, sClassString);
         GxWebStd.StyleAttribute( context, sStyleString);
         context.WriteHtmlText( sTags) ;
         context.WriteHtmlTextNl( ">") ;
         while ( idxLst <= lstLObjCtrl.ItemCount )
         {
            if ( StringUtil.StrCmp(sType, "int") == 0 )
            {
               context.WriteHtmlText( "<option value=\"") ;
               context.SendWebValue( StringUtil.Trim( lstLObjCtrl.getItemValue((short)(idxLst)))) ;
            }
            else
            {
               context.WriteHtmlText( "<option value=\"") ;
               context.SendWebValue( StringUtil.RTrim( lstLObjCtrl.getItemValue((short)(idxLst)))) ;
            }
            if ( StringUtil.StrCmp(StringUtil.LTrim( lstLObjCtrl.getItemValue((short)(idxLst))), StringUtil.LTrim( sValue)) == 0 )
            {
               context.WriteHtmlText( "\" selected=\"selected\" >") ;
            }
            else
            {
               context.WriteHtmlText( "\">") ;
            }
            if ( nFormat == 0 )
            {
               context.SendWebValue( lstLObjCtrl.getItemText((short)(idxLst))) ;
            }
            else
            {
               if ( nFormat == 3 )
               {
                  context.SendWebValueSpace( lstLObjCtrl.getItemText((short)(idxLst))) ;
               }
               else
               {
                  context.WriteHtmlText( lstLObjCtrl.getItemText((short)(idxLst))) ;
               }
            }
            context.WriteHtmlText( GXUtil.HtmlEndTag( HTMLElement.OPTION)) ;
            idxLst = (int)(idxLst+1);
         }
         context.WriteHtmlTextNl( "</select>") ;
         GxWebStd.gx_ctrl_attribute( context, sCtrlName, "data-jsevent", sUserOnClickCode, false);
         GxWebStd.gx_ctrl_attribute( context, sCtrlName, "data-gxoch0", sEventJsCode, true);
         if ( nEnabled == 0 )
         {
            if ( ( StringUtil.Len( sClassString) != 0 ) && ( StringUtil.StringSearch( sClassString, "Readonly", 1) != 1 ) )
            {
               ClassHTML = "Readonly" + sClassString;
            }
            else
            {
               ClassHTML = sClassString;
            }
            sOStyle = sOStyle + ((nVisible==0) ? ";display:none;" : "");
            idxLst = 1;
            context.WriteHtmlText( "<span") ;
            GxWebStd.ClassAttribute( context, ClassHTML);
            GxWebStd.StyleAttribute( context, sOStyle);
            context.WriteHtmlText( ((StringUtil.Len( sTooltipText)>0) ? " title=\""+sTooltipText+"\"" : "")+" id=\"span_"+sCtrlName+"\"") ;
            context.WriteHtmlText( ">") ;
            while ( idxLst <= lstLObjCtrl.ItemCount )
            {
               if ( StringUtil.StrCmp(StringUtil.LTrim( lstLObjCtrl.getItemValue((short)(idxLst))), StringUtil.LTrim( sValue)) == 0 )
               {
                  if ( nFormat == 0 )
                  {
                     context.SendWebValue( lstLObjCtrl.getItemText((short)(idxLst))) ;
                  }
                  else
                  {
                     if ( nFormat == 3 )
                     {
                        context.SendWebValueSpace( lstLObjCtrl.getItemText((short)(idxLst))) ;
                     }
                     else
                     {
                        context.WriteHtmlText( lstLObjCtrl.getItemText((short)(idxLst))) ;
                     }
                  }
                  if (true) break;
               }
               idxLst = (int)(idxLst+1);
            }
            context.WriteHtmlText( "</span>") ;
            if ( nEnabled == 0 )
            {
               context.WriteHtmlText( "<script type=\"text/javascript\">gx.fn.disableCtrl(\""+sCtrlName+"\");</script>") ;
            }
         }
      }

      static public void gx_radio_ctrl( IGxContext context ,
                                        GXRadio radRObjCtrl ,
                                        String sCtrlName ,
                                        String sValue ,
                                        String sTooltipText ,
                                        int nVisible ,
                                        int nEnabled ,
                                        int nRadioColumns ,
                                        int nOrientation ,
                                        String sStyleString ,
                                        String sClassString ,
                                        String sColumnClassString ,
                                        String sColumnHeaderClassString ,
                                        int nJScriptCode ,
                                        String sUserOnClickCode ,
                                        String sEventName ,
                                        String sTags ,
                                        String sCallerPgm )
      {
         String sEventJsCode ;
         int idxLst ;
         int idxCol ;
         String ClassHTML ;
         String sCtrlId ;
         ClassHTML = "gx-radio-button ";
         if ( nOrientation == 1 )
         {
            ClassHTML = ClassHTML + "gx-radio-button-vertical ";
         }
         if ( ( nEnabled == 0 ) && ( StringUtil.Len( sClassString) != 0 ) && ( StringUtil.StringSearch( sClassString, "Readonly", 1) != 1 ) )
         {
            ClassHTML = ClassHTML + "Readonly" + sClassString;
         }
         else
         {
            ClassHTML = ClassHTML + sClassString;
         }
         /* Initialize internal JScript code according to EventNo */
         if ( nJScriptCode == 1 )
         {
            sEventJsCode = "gx.fn.closeWindow();" + "return false;";
         }
         else if ( nJScriptCode == 3 )
         {
            sEventJsCode = "gx.util.help(" + "'" + context.convertURL( "Help/"+"English/"+StringUtil.Lower( sCallerPgm)) + "');" + "return false;";
         }
         else if ( nJScriptCode == 7 )
         {
            sEventJsCode = "" + "gx.evt.execCliEvt(" + sEventName + ",this);";
         }
         else if ( nJScriptCode == 8 )
         {
            sEventJsCode = "gx.evt.execEvt(" + sEventName + ",this);" + "return false;";
         }
         else if ( nJScriptCode == 6 )
         {
            sEventJsCode = "gx.evt.execEvt(" + sEventName + ",this);";
         }
         else if ( nJScriptCode == 5 )
         {
            sEventJsCode = "gx.evt.execEvt(" + sEventName + ",this);";
         }
         else if ( nJScriptCode == 0 )
         {
            sEventJsCode = "";
         }
         else
         {
            sEventJsCode = "";
         }
         idxLst = 1;
         idxCol = 0;
         sStyleString = sStyleString + ((nVisible!=0) ? "" : ";display:none;");
         context.WriteHtmlText( "<span") ;
         GxWebStd.ClassAttribute( context, ClassHTML);
         GxWebStd.StyleAttribute( context, sStyleString);
         context.WriteHtmlText( ">") ;
         while ( idxLst <= radRObjCtrl.ItemCount )
         {
            sCtrlId = sCtrlName + idxLst;
            context.WriteHtmlText( "<label for=\"") ;
            context.SendWebValue( sCtrlId) ;
            context.WriteHtmlText( "\">") ;
            context.skipLines(1);
            context.WriteHtmlText( "<input type=\"radio\"") ;
            context.WriteHtmlText( " name=\"") ;
            context.SendWebValue( sCtrlName) ;
            context.WriteHtmlText( "\" id=\"") ;
            context.SendWebValue( sCtrlId) ;
            context.WriteHtmlText( "\" value=\"") ;
            context.WriteHtmlText( radRObjCtrl.getItemValue((short)(idxLst))) ;
            context.WriteHtmlText( "\"") ;
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( sTooltipText)) )
            {
               context.WriteHtmlText( " title=\"") ;
               context.SendWebValue( sTooltipText) ;
               context.WriteHtmlText( "\"") ;
            }
            if ( StringUtil.StrCmp(StringUtil.LTrim( sValue), radRObjCtrl.getItemValue((short)(idxLst))) == 0 )
            {
               context.WriteHtmlText( " checked=\"checked\"") ;
            }
            context.WriteHtmlText( sTags) ;
            context.WriteHtmlText( GXUtil.HtmlEndTag( HTMLElement.INPUT)) ;
            GxWebStd.gx_ctrl_attribute( context, sCtrlName, "data-gxoch0", sEventJsCode, true);
            GxWebStd.gx_ctrl_attribute( context, sCtrlName, "data-jsevent", sUserOnClickCode, false);
            if ( nEnabled == 0 )
            {
               context.WriteHtmlText( "<script type=\"text/javascript\">gx.fn.disableCtrl(\""+sCtrlName+"\");</script>") ;
            }
            context.SendWebValue( radRObjCtrl.getItemText((short)(idxLst))) ;
            context.WriteHtmlText( "</label>") ;
            idxLst = (int)(idxLst+1);
         }
         context.WriteHtmlText( "</span>") ;
      }

      static public void gx_checkbox_ctrl( IGxContext context ,
                                           String sCtrlName ,
                                           String sValue ,
                                           String sTooltipText ,
                                           String sLabelCaption ,
                                           int nVisible ,
                                           int nEnabled ,
                                           String sCheked ,
                                           String sCaption ,
                                           String sStyleString ,
                                           String sClassString ,
                                           String sColumnClassString ,
                                           String sColumnHeaderClassString ,
                                           String sTags )
      {
         String ClassHTML ;
         ClassHTML = sClassString;
         sValue = StringUtil.LTrim( sValue);
         sCheked = StringUtil.LTrim( sCheked);
         if ( nEnabled == 0 )
         {
            if ( ( StringUtil.Len( sClassString) != 0 ) && ( StringUtil.StringSearch( sClassString, "Readonly", 1) != 1 ) )
            {
               ClassHTML = "Readonly" + sClassString;
            }
         }
         sStyleString = sStyleString + ((nVisible!=0) ? "" : ";display:none;");
         context.WriteHtmlText( "<label for=\"") ;
         context.SendWebValue( sCtrlName) ;
         context.WriteHtmlText( "\""+" class=\""+ClassHTML+"\" style=\""+CSSHelper.Prettify( sStyleString)+"\">") ;
         context.WriteHtmlText( "<input type=\"checkbox\" "+((StringUtil.StrCmp(sValue, sCheked)==0) ? "checked=\"checked\"" : "")) ;
         context.WriteHtmlText( " id=\"") ;
         context.SendWebValue( StringUtil.Trim( sCtrlName)) ;
         context.WriteHtmlText( "\" name=\"") ;
         context.SendWebValue( StringUtil.Trim( sCtrlName)) ;
         context.WriteHtmlText( "\"") ;
         context.WriteHtmlText( " value=\""+((StringUtil.StrCmp(sValue, sCheked)==0) ? sCheked : "")+"\"") ;
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( sTooltipText)) )
         {
            context.WriteHtmlText( " title=\"") ;
            context.SendWebValue( StringUtil.Trim( sTooltipText)) ;
            context.WriteHtmlText( "\"") ;
         }
         context.WriteHtmlText( sTags+GXUtil.HtmlEndTag( HTMLElement.INPUT)) ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( sCaption)) )
         {
            context.WriteHtmlText( "<span style=\"display:none;\">"+sLabelCaption+"</span>") ;
         }
         else
         {
            context.WriteHtmlText( sCaption) ;
         }
         context.WriteHtmlText( "</label>") ;
         if ( nEnabled == 0 )
         {
            context.WriteHtmlText( "<script type=\"text/javascript\">gx.fn.disableCtrl(\""+sCtrlName+"\");</script>") ;
         }
      }

      static public void gx_bitmap( IGxContext context ,
                                    String sInternalName ,
                                    String sImageURL ,
                                    String sLinkURL ,
                                    String sLinkTarget ,
                                    String sAccesskey ,
                                    String sThemeName ,
                                    int nVisible ,
                                    int nEnabled ,
                                    String sAlternateText ,
                                    String sTooltipText ,
                                    int nBorderWidth ,
                                    int nAutoresize ,
                                    int nWidth ,
                                    String nWidthUnit ,
                                    int nHeight ,
                                    String nHeightUnit ,
                                    int nVerticalSpace ,
                                    int nHorizontalSpace ,
                                    int nJScriptCode ,
                                    String sUserOnClickCode ,
                                    String sEventName ,
                                    String sStyleString ,
                                    String sClassString ,
                                    String sColumnClassString ,
                                    String sColumnHeaderClassString ,
                                    String sAlign ,
                                    String sInputTags ,
                                    String sImageTags ,
                                    String sUseMap ,
                                    String sJsDynCode ,
                                    int nReadOnly ,
                                    bool bIsBlob ,
                                    bool bIsAttribute ,
                                    String sImgSrcSet ,
                                    String sCallerPgm )
      {
         String ClassHTML ;
         ClassHTML = sClassString;
         if ( bIsAttribute && ( StringUtil.Len( sClassString) != 0 ) && ( StringUtil.StringSearch( sClassString, "Readonly", 1) != 1 ) )
         {
            ClassHTML = "Readonly" + sClassString;
         }
         if ( ( nReadOnly == 1 ) || ( nEnabled == 0 ) )
         {
            GxWebStd.gx_bitmap_readonly( context, sInternalName, sImageURL, sLinkURL, sLinkTarget, sAccesskey, sThemeName, nVisible, nEnabled, sAlternateText, sTooltipText, nBorderWidth, nAutoresize, nWidth, nWidthUnit, nHeight, nHeightUnit, nVerticalSpace, nHorizontalSpace, nJScriptCode, sUserOnClickCode, sEventName, sStyleString, ClassHTML, sColumnClassString, sColumnHeaderClassString, sAlign, sImageTags, sUseMap, sJsDynCode, sCallerPgm, sImgSrcSet);
         }
         else
         {
            GxWebStd.gx_multimedia_upload_start( context, sInternalName, nVisible, nWidth, sStyleString);
            context.WriteHtmlText( "<a class=\"action change-action\" gxfocusable=\"1\" href=\"\"") ;
            context.WriteHtmlText( sInputTags) ;
            context.WriteHtmlText( ">") ;
            context.WriteHtmlText( context.GetMessage( "GXM_multimediachange", "")) ;
            context.WriteHtmlText( "</a>") ;
            context.WriteHtmlText( "<a gxfocusable=\"1\" href=\"\" class=\"action clear-action\"></a>") ;
            context.WriteHtmlText( "<a target=\"_blank\">") ;
            context.WriteHtmlText( "<img id=\"Object_") ;
            context.SendWebValue( sInternalName) ;
            context.WriteHtmlText( "\"") ;
            context.WriteHtmlText( " class=\"") ;
            context.SendWebValue( StringUtil.Trim( ClassHTML)) ;
            context.WriteHtmlText( "\"") ;
            context.WriteHtmlText( " alt=\"") ;
            context.SendWebValue( StringUtil.Trim( (String.IsNullOrEmpty(StringUtil.RTrim( sAlternateText)) ? sTooltipText : sAlternateText))) ;
            context.WriteHtmlText( "\"") ;
            context.WriteHtmlText( " src=\"") ;
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( sImageURL)) )
            {
               context.WriteHtmlText( context.convertURL( sImageURL)) ;
            }
            context.WriteHtmlText( "\"") ;
            context.WriteHtmlText( GXUtil.HtmlEndTag( HTMLElement.IMG)) ;
            context.WriteHtmlText( "<span class=\"") ;
            context.WriteHtmlText( "gx-image-placeholder") ;
            context.WriteHtmlText( "\">") ;
            context.WriteHtmlText( "</span>") ;
            context.WriteHtmlText( "</a>") ;
            GxWebStd.gx_multimedia_upload_end( context, sInternalName, sImageURL, sTooltipText, nWidth, nWidthUnit, nHeight, nHeightUnit, sUserOnClickCode, sEventName, sStyleString, sClassString, "", "", sAlign, sInputTags, nReadOnly, bIsBlob, "image/*", sCallerPgm);
         }
      }

      static public void gx_bitmap_readonly( IGxContext context ,
                                             String sInternalName ,
                                             String sImageURL ,
                                             String sLinkURL ,
                                             String sLinkTarget ,
                                             String sAccesskey ,
                                             String sThemeName ,
                                             int nVisible ,
                                             int nEnabled ,
                                             String sAlternateText ,
                                             String sTooltipText ,
                                             int nBorderWidth ,
                                             int nAutoresize ,
                                             int nWidth ,
                                             String nWidthUnit ,
                                             int nHeight ,
                                             String nHeightUnit ,
                                             int nVerticalSpace ,
                                             int nHorizontalSpace ,
                                             int nJScriptCode ,
                                             String sUserOnClickCode ,
                                             String sEventName ,
                                             String sStyleString ,
                                             String sClassString ,
                                             String sColumnClassString ,
                                             String sColumnHeaderClassString ,
                                             String sAlign ,
                                             String sTags ,
                                             String sUseMap ,
                                             String sJsDynCode ,
                                             String sCallerPgm ,
                                             String sImgSrcSet )
      {
         String sEventJsCode ;
         String sCapAKey ;
         sEventJsCode = "";
         sCapAKey = GXUtil.AccessKey( sTooltipText);
         sTooltipText = GXUtil.AccessKeyCaption( sTooltipText);
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( sCapAKey)) )
         {
            sAccesskey = sCapAKey;
         }
         sStyleString = sStyleString + ((nVisible!=0) ? "" : ";display:none;");
         /* Initialize internal JScript code according to EventNo */
         if ( nJScriptCode == 4 )
         {
            sEventJsCode = sJsDynCode;
         }
         else if ( nJScriptCode == 1 )
         {
            sEventJsCode = "gx.fn.closeWindow();" + "return false;";
         }
         else if ( nJScriptCode == 3 )
         {
            sEventJsCode = "gx.util.help(" + "'" + context.convertURL( "Help/"+"English/"+StringUtil.Lower( sCallerPgm)) + "');" + "return false;";
         }
         else if ( nJScriptCode == 7 )
         {
            sEventJsCode = "" + "gx.evt.execCliEvt(" + sEventName + ",this);";
         }
         else if ( nJScriptCode == 8 )
         {
            sEventJsCode = "gx.evt.execEvt(" + sEventName + ",this);" + "return false;";
         }
         else if ( nJScriptCode == 6 )
         {
            sEventJsCode = "gx.evt.execEvt(" + sEventName + ",this);";
         }
         else if ( nJScriptCode == 5 )
         {
            sEventJsCode = "gx.evt.execEvt(" + sEventName + ",this);";
         }
         else if ( nJScriptCode == 0 )
         {
            sEventJsCode = "";
         }
         else
         {
            sEventJsCode = "";
         }
         if ( ( nEnabled != 0 ) && ( StringUtil.StrCmp(sLinkURL, "") != 0 ) )
         {
            GxWebStd.gx_start_js_anchor( context, nJScriptCode, sEventJsCode, sUserOnClickCode, sLinkURL, sLinkTarget, "gx-image-link");
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( sImageURL)) )
         {
            context.WriteHtmlText( "<img src=\""+context.convertURL( sImageURL)+"\"") ;
         }
         else
         {
            context.WriteHtmlText( "<img ") ;
         }
         if ( nEnabled == 0 )
         {
            sClassString = sClassString + " gx-disabled";
         }
         if ( ! (0==nJScriptCode) )
         {
            context.WriteHtmlText( " data-gx-evt=\"") ;
            context.WriteHtmlText( StringUtil.Trim( StringUtil.Str( (decimal)(nJScriptCode), 10, 0))) ;
            context.WriteHtmlText( "\"") ;
         }
         if ( ( nJScriptCode == 4 ) || ( nJScriptCode == 3 ) )
         {
            context.WriteHtmlText( " data-gx-evt-code=\"") ;
            context.WriteHtmlText( sEventJsCode) ;
            context.WriteHtmlText( "\"") ;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( sUserOnClickCode)) )
         {
            context.WriteHtmlText( " data-gx-evt-condition=\"") ;
            context.WriteHtmlText( sUserOnClickCode) ;
            context.WriteHtmlText( "\"") ;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( sImgSrcSet)) )
         {
            context.WriteHtmlText( " srcset=\"") ;
            context.WriteHtmlText( sImgSrcSet) ;
            context.WriteHtmlText( "\"") ;
         }
         if ( StringUtil.Len( sAccesskey) != 0 )
         {
            context.WriteHtmlText( " accesskey=\"") ;
            context.SendWebValue( StringUtil.Trim( sAccesskey)) ;
            context.WriteHtmlText( "\"") ;
         }
         context.WriteHtmlText( " id=\"") ;
         context.SendWebValue( sInternalName) ;
         context.WriteHtmlText( "\"") ;
         if ( ! (0==nVerticalSpace) )
         {
            context.WriteHtmlText( " vspace=\"") ;
            context.WriteHtmlText( StringUtil.LTrim( StringUtil.Str( (decimal)(nVerticalSpace), 10, 0))) ;
            context.WriteHtmlText( "\"") ;
         }
         if ( ! (0==nHorizontalSpace) )
         {
            context.WriteHtmlText( " hspace=\"") ;
            context.WriteHtmlText( StringUtil.LTrim( StringUtil.Str( (decimal)(nHorizontalSpace), 10, 0))) ;
            context.WriteHtmlText( "\"") ;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( sAlign)) )
         {
            context.WriteHtmlText( " align=\"") ;
            context.WriteHtmlText( StringUtil.LTrim( sAlign)) ;
            context.WriteHtmlText( "\"") ;
         }
         if ( nBorderWidth > 0 )
         {
            sStyleString = sStyleString + ";border-width: " + StringUtil.Str( (decimal)(nBorderWidth), 3, 0);
         }
         context.WriteHtmlText( " alt=\"") ;
         context.SendWebValue( (String.IsNullOrEmpty(StringUtil.RTrim( sAlternateText)) ? sTooltipText : sAlternateText)) ;
         context.WriteHtmlText( "\"") ;
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( sTooltipText)) )
         {
            context.WriteHtmlText( " title=\"") ;
            context.SendWebValue( StringUtil.Trim( sTooltipText)) ;
            context.WriteHtmlText( "\"") ;
         }
         if ( nWidth > 0 )
         {
            sStyleString = sStyleString + ";width: " + StringUtil.LTrim( StringUtil.Str( (decimal)(nWidth), 10, 0)) + nWidthUnit;
         }
         if ( nHeight > 0 )
         {
            sStyleString = sStyleString + ";height: " + StringUtil.LTrim( StringUtil.Str( (decimal)(nHeight), 10, 0)) + nHeightUnit;
         }
         GxWebStd.ClassAttribute( context, sClassString);
         GxWebStd.StyleAttribute( context, sStyleString);
         context.WriteHtmlText( sTags) ;
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( sUseMap)) )
         {
            context.WriteHtmlText( " usemap=\"") ;
            context.SendWebValue( StringUtil.Trim( sUseMap)) ;
            context.WriteHtmlText( "\"") ;
         }
         context.WriteHtmlText( GXUtil.HtmlEndTag( HTMLElement.INPUT)) ;
         if ( ( nEnabled != 0 ) && ( StringUtil.StrCmp(sLinkURL, "") != 0 ) && ( StringUtil.StrCmp(sEventJsCode, "") == 0 ) )
         {
            GxWebStd.gx_end_js_anchor( context, sEventJsCode, sUserOnClickCode, sLinkURL);
         }
      }

      static public void gx_multimedia_upload_start( IGxContext context ,
                                                     String sInternalName ,
                                                     int nVisible ,
                                                     int nWidth ,
                                                     String sStyleString )
      {
         context.WriteHtmlText( "<div class=\"gx-multimedia-upload\"") ;
         context.WriteHtmlText( " id =\"") ;
         context.SendWebValue( sInternalName) ;
         context.WriteHtmlText( "_ct\"") ;
         sStyleString = "";
         if ( nVisible == 0 )
         {
            sStyleString = "display:none;";
         }
         if ( nWidth > 0 )
         {
            sStyleString = sStyleString + " width:" + StringUtil.LTrim( StringUtil.Str( (decimal)(nWidth), 10, 0)) + ";";
         }
         GxWebStd.StyleAttribute( context, sStyleString);
         context.WriteHtmlText( ">") ;
      }

      static public void gx_multimedia_upload_end( IGxContext context ,
                                                   String sInternalName ,
                                                   String sMultimediaURL ,
                                                   String sTooltipText ,
                                                   int nWidth ,
                                                   String nWidthUnit ,
                                                   int nHeight ,
                                                   String nHeightUnit ,
                                                   String sUserOnClickCode ,
                                                   String sEventName ,
                                                   String sStyleString ,
                                                   String sClassString ,
                                                   String sColumnClassString ,
                                                   String sColumnHeaderClassString ,
                                                   String sAlign ,
                                                   String sInputTags ,
                                                   int nReadOnly ,
                                                   bool bIsBlob ,
                                                   String sAccept ,
                                                   String sCallerPgm )
      {
         String sURL ;
         context.WriteHtmlText( "<div id=\"") ;
         context.SendWebValue( sInternalName) ;
         context.WriteHtmlText( "_ct_fields\" class=\"fields-ct \">") ;
         context.WriteHtmlText( "<label class=\"option\">") ;
         context.WriteHtmlText( "<input type=\"radio\" value=\"file\" name=\"") ;
         context.SendWebValue( sInternalName) ;
         context.WriteHtmlText( "Option\"") ;
         if ( bIsBlob )
         {
            context.WriteHtmlText( " checked") ;
         }
         context.WriteHtmlText( GXUtil.HtmlEndTag( HTMLElement.INPUT)) ;
         context.WriteHtmlText( context.GetMessage( "GXM_uploadfileoption", "")) ;
         context.WriteHtmlText( "</label>") ;
         context.WriteHtmlText( "<label class=\"option\">") ;
         context.WriteHtmlText( "<input type=\"radio\" value=\"uri\" name=\"") ;
         context.SendWebValue( sInternalName) ;
         context.WriteHtmlText( "Option\"") ;
         if ( ! bIsBlob )
         {
            context.WriteHtmlText( " checked") ;
         }
         context.WriteHtmlText( GXUtil.HtmlEndTag( HTMLElement.INPUT)) ;
         context.WriteHtmlText( context.GetMessage( "GXM_uploadurioption", "")) ;
         context.WriteHtmlText( "</label>") ;
         sURL = "";
         if ( ! bIsBlob )
         {
            sURL = sMultimediaURL;
         }
         GxWebStd.gx_single_line_edit( context, sInternalName+"_GXI", sURL, sURL, sInputTags, sEventName, "", "", sTooltipText, "", sUserOnClickCode, 0, "field "+sClassString, sStyleString, "", "", "", 1, 1, 1, "text", "", nWidth, nWidthUnit, nHeight, nHeightUnit, 254, 0, 2, 0, 1, 1, 0, true, "", sAlign, false, sCallerPgm);
         context.WriteHtmlText( "<input type=\"file\" class=\"field ") ;
         context.SendWebValue( sClassString) ;
         context.WriteHtmlText( "\"") ;
         context.WriteHtmlText( " id=\"") ;
         context.SendWebValue( sInternalName) ;
         context.WriteHtmlText( "\"") ;
         context.WriteHtmlText( " name=\"") ;
         context.SendWebValue( sInternalName) ;
         context.WriteHtmlText( "\"") ;
         context.WriteHtmlText( " accept=\"") ;
         context.WriteHtmlText( sAccept) ;
         context.WriteHtmlText( "\" ") ;
         context.WriteHtmlText( sInputTags) ;
         context.WriteHtmlText( GXUtil.HtmlEndTag( HTMLElement.INPUT)) ;
         context.WriteHtmlText( "</div>") ;
         context.WriteHtmlText( "</div>") ;
      }

      static public void gx_video( IGxContext context ,
                                   String sInternalName ,
                                   String sMultimediaURL ,
                                   String sText ,
                                   int nDisplay ,
                                   int nVisible ,
                                   int nEnabled ,
                                   int nAutoresize ,
                                   int nWidth ,
                                   String nWidthUnit ,
                                   int nHeight ,
                                   String nHeightUnit ,
                                   int nJScriptCode ,
                                   String sUserOnClickCode ,
                                   String sEventName ,
                                   String sStyleString ,
                                   String sClassString ,
                                   String sColumnClassString ,
                                   String sColumnHeaderClassString ,
                                   String sInputTags ,
                                   String sMultimediaTags ,
                                   String sJsDynCode ,
                                   int nReadOnly ,
                                   bool bIsBlob ,
                                   String sCallerPgm )
      {
         String ClassHTML ;
         ClassHTML = sClassString;
         if ( ( StringUtil.Len( sClassString) != 0 ) && ( StringUtil.StringSearch( sClassString, "Readonly", 1) != 1 ) )
         {
            ClassHTML = "Readonly" + sClassString;
         }
         if ( ( nReadOnly == 0 ) && ( nEnabled == 1 ) )
         {
            GxWebStd.gx_multimedia_upload_start( context, sInternalName, nVisible, nWidth, sStyleString);
            context.WriteHtmlText( "<a class=\"action change-action\" gxfocusable=\"1\" href=\"\"") ;
            context.WriteHtmlText( sInputTags) ;
            context.WriteHtmlText( ">") ;
            context.WriteHtmlText( context.GetMessage( "GXM_multimediachange", "")) ;
            context.WriteHtmlText( "</a>") ;
            context.WriteHtmlText( "<a gxfocusable=\"1\" href=\"\" class=\"action clear-action\"></a>") ;
         }
         context.WriteHtmlText( "<a class=\"gx-multimedia-ro\" target=\"_blank\"") ;
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( sMultimediaURL)) )
         {
            context.WriteHtmlText( " href=\"") ;
            context.SendWebValue( sMultimediaURL) ;
            context.WriteHtmlText( "\"") ;
         }
         context.WriteHtmlText( ">") ;
         if ( context.CheckContentType( "image", "", sMultimediaURL) || String.IsNullOrEmpty(StringUtil.RTrim( sMultimediaURL)) )
         {
            context.WriteHtmlText( "<img id=\"Object_") ;
            context.SendWebValue( sInternalName) ;
            context.WriteHtmlText( "\"") ;
            context.WriteHtmlText( " class=\"") ;
            context.SendWebValue( StringUtil.Trim( ClassHTML)) ;
            context.WriteHtmlText( "\"") ;
            context.WriteHtmlText( " src=\"") ;
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( sMultimediaURL)) )
            {
               context.WriteHtmlText( context.convertURL( sMultimediaURL)) ;
            }
            context.WriteHtmlText( "\"") ;
            context.WriteHtmlText( GXUtil.HtmlEndTag( HTMLElement.IMG)) ;
         }
         context.WriteHtmlText( "<span") ;
         if ( ( nReadOnly == 1 ) || ( nEnabled == 0 ) )
         {
            context.WriteHtmlText( " id =\"") ;
            context.SendWebValue( sInternalName) ;
            context.WriteHtmlText( "\"") ;
         }
         context.WriteHtmlText( " class=\"") ;
         context.SendWebValue( ClassHTML) ;
         context.WriteHtmlText( " ") ;
         context.WriteHtmlText( "gx-video-placeholder") ;
         context.WriteHtmlText( "\" title=\"") ;
         context.WriteHtmlText( context.GetMessage( "GXM_multimediaalttext", "")) ;
         context.WriteHtmlText( "\">") ;
         context.SendWebValue( sText) ;
         context.WriteHtmlText( "</span>") ;
         context.WriteHtmlText( "</a>") ;
         if ( ( nReadOnly == 0 ) && ( nEnabled == 1 ) )
         {
            GxWebStd.gx_multimedia_upload_end( context, sInternalName, sMultimediaURL, "", nWidth, nWidthUnit, nHeight, nHeightUnit, sUserOnClickCode, sEventName, sStyleString, sClassString, "", "", "", sInputTags, nReadOnly, bIsBlob, "video/*", sCallerPgm);
         }
      }

      static public void gx_audio( IGxContext context ,
                                   String sInternalName ,
                                   String sMultimediaURL ,
                                   String sText ,
                                   int nDisplay ,
                                   int nVisible ,
                                   int nEnabled ,
                                   int nAutoresize ,
                                   int nWidth ,
                                   String nWidthUnit ,
                                   int nHeight ,
                                   String nHeightUnit ,
                                   int nJScriptCode ,
                                   String sUserOnClickCode ,
                                   String sEventName ,
                                   String sStyleString ,
                                   String sClassString ,
                                   String sColumnClassString ,
                                   String sColumnHeaderClassString ,
                                   String sInputTags ,
                                   String sMultimediaTags ,
                                   String sJsDynCode ,
                                   int nReadOnly ,
                                   bool bIsBlob ,
                                   String sCallerPgm )
      {
         String ClassHTML ;
         ClassHTML = sClassString;
         if ( ( StringUtil.Len( sClassString) != 0 ) && ( StringUtil.StringSearch( sClassString, "Readonly", 1) != 1 ) )
         {
            ClassHTML = "Readonly" + sClassString;
         }
         if ( ( nReadOnly == 0 ) && ( nEnabled == 1 ) )
         {
            GxWebStd.gx_multimedia_upload_start( context, sInternalName, nVisible, nWidth, sStyleString);
            context.WriteHtmlText( "<a class=\"action change-action\" gxfocusable=\"1\" href=\"\"") ;
            context.WriteHtmlText( sInputTags) ;
            context.WriteHtmlText( ">") ;
            context.WriteHtmlText( context.GetMessage( "GXM_multimediachange", "")) ;
            context.WriteHtmlText( "</a>") ;
            context.WriteHtmlText( "<a gxfocusable=\"1\" href=\"\" class=\"action clear-action\"></a>") ;
         }
         context.WriteHtmlText( "<a class=\"gx-multimedia-ro\" target=\"_blank\"") ;
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( sMultimediaURL)) )
         {
            context.WriteHtmlText( " href=\"") ;
            context.SendWebValue( sMultimediaURL) ;
            context.WriteHtmlText( "\"") ;
         }
         context.WriteHtmlText( ">") ;
         if ( context.CheckContentType( "image", "", sMultimediaURL) || String.IsNullOrEmpty(StringUtil.RTrim( sMultimediaURL)) )
         {
            context.WriteHtmlText( "<img id=\"Object_") ;
            context.SendWebValue( sInternalName) ;
            context.WriteHtmlText( "\"") ;
            context.WriteHtmlText( " class=\"") ;
            context.SendWebValue( StringUtil.Trim( ClassHTML)) ;
            context.WriteHtmlText( "\"") ;
            context.WriteHtmlText( " src=\"") ;
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( sMultimediaURL)) )
            {
               context.WriteHtmlText( context.convertURL( sMultimediaURL)) ;
            }
            context.WriteHtmlText( "\"") ;
            context.WriteHtmlText( GXUtil.HtmlEndTag( HTMLElement.IMG)) ;
         }
         context.WriteHtmlText( "<span") ;
         if ( ( nReadOnly == 1 ) || ( nEnabled == 0 ) )
         {
            context.WriteHtmlText( " id =\"") ;
            context.SendWebValue( sInternalName) ;
            context.WriteHtmlText( "\"") ;
         }
         context.WriteHtmlText( " class=\"") ;
         context.SendWebValue( ClassHTML) ;
         context.WriteHtmlText( " ") ;
         context.WriteHtmlText( "gx-audio-placeholder") ;
         context.WriteHtmlText( "\" title=\"") ;
         context.WriteHtmlText( context.GetMessage( "GXM_multimediaalttext", "")) ;
         context.WriteHtmlText( "\">") ;
         context.SendWebValue( sText) ;
         context.WriteHtmlText( "</span>") ;
         context.WriteHtmlText( "</a>") ;
         if ( ( nReadOnly == 0 ) && ( nEnabled == 1 ) )
         {
            GxWebStd.gx_multimedia_upload_end( context, sInternalName, sMultimediaURL, "", nWidth, nWidthUnit, nHeight, nHeightUnit, sUserOnClickCode, sEventName, sStyleString, sClassString, "", "", "", sInputTags, nReadOnly, bIsBlob, "audio/*", sCallerPgm);
         }
      }

      static public void gx_file( IGxContext context ,
                                  String sInternalName ,
                                  String sMultimediaURL ,
                                  String sText ,
                                  int nDisplay ,
                                  int nVisible ,
                                  int nEnabled ,
                                  int nAutoresize ,
                                  int nWidth ,
                                  String nWidthUnit ,
                                  int nHeight ,
                                  String nHeightUnit ,
                                  int nJScriptCode ,
                                  String sUserOnClickCode ,
                                  String sEventName ,
                                  String sStyleString ,
                                  String sClassString ,
                                  String sColumnClassString ,
                                  String sColumnHeaderClassString ,
                                  String sInputTags ,
                                  String sMultimediaTags ,
                                  String sJsDynCode ,
                                  int nReadOnly ,
                                  bool bIsBlob ,
                                  String sCallerPgm )
      {
         String ClassHTML ;
         ClassHTML = sClassString;
         if ( ( StringUtil.Len( sClassString) != 0 ) && ( StringUtil.StringSearch( sClassString, "Readonly", 1) != 1 ) )
         {
            ClassHTML = "Readonly" + sClassString;
         }
         if ( ( nReadOnly == 0 ) && ( nEnabled == 1 ) )
         {
            GxWebStd.gx_multimedia_upload_start( context, sInternalName, nVisible, nWidth, sStyleString);
            context.WriteHtmlText( "<a class=\"action change-action\" gxfocusable=\"1\" href=\"\"") ;
            context.WriteHtmlText( sInputTags) ;
            context.WriteHtmlText( ">") ;
            context.WriteHtmlText( context.GetMessage( "GXM_multimediachange", "")) ;
            context.WriteHtmlText( "</a>") ;
            context.WriteHtmlText( "<a gxfocusable=\"1\" href=\"\" class=\"action clear-action\"></a>") ;
         }
         context.WriteHtmlText( "<a class=\"gx-multimedia-ro\" target=\"_blank\"") ;
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( sMultimediaURL)) )
         {
            context.WriteHtmlText( " href=\"") ;
            context.SendWebValue( sMultimediaURL) ;
            context.WriteHtmlText( "\"") ;
         }
         context.WriteHtmlText( ">") ;
         if ( context.CheckContentType( "image", "", sMultimediaURL) || String.IsNullOrEmpty(StringUtil.RTrim( sMultimediaURL)) )
         {
            context.WriteHtmlText( "<img id=\"Object_") ;
            context.SendWebValue( sInternalName) ;
            context.WriteHtmlText( "\"") ;
            context.WriteHtmlText( " class=\"") ;
            context.SendWebValue( StringUtil.Trim( ClassHTML)) ;
            context.WriteHtmlText( "\"") ;
            context.WriteHtmlText( " src=\"") ;
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( sMultimediaURL)) )
            {
               context.WriteHtmlText( context.convertURL( sMultimediaURL)) ;
            }
            context.WriteHtmlText( "\"") ;
            context.WriteHtmlText( GXUtil.HtmlEndTag( HTMLElement.IMG)) ;
         }
         context.WriteHtmlText( "<span") ;
         if ( ( nReadOnly == 1 ) || ( nEnabled == 0 ) )
         {
            context.WriteHtmlText( " id =\"") ;
            context.SendWebValue( sInternalName) ;
            context.WriteHtmlText( "\"") ;
         }
         context.WriteHtmlText( " class=\"") ;
         context.SendWebValue( ClassHTML) ;
         context.WriteHtmlText( " ") ;
         context.WriteHtmlText( "gx-download-placeholder") ;
         context.WriteHtmlText( "\" title=\"") ;
         context.WriteHtmlText( context.GetMessage( "GXM_multimediaalttext", "")) ;
         context.WriteHtmlText( "\">") ;
         context.SendWebValue( sText) ;
         context.WriteHtmlText( "</span>") ;
         context.WriteHtmlText( "</a>") ;
         if ( ( nReadOnly == 0 ) && ( nEnabled == 1 ) )
         {
            GxWebStd.gx_multimedia_upload_end( context, sInternalName, sMultimediaURL, "", nWidth, nWidthUnit, nHeight, nHeightUnit, sUserOnClickCode, sEventName, sStyleString, sClassString, "", "", "", sInputTags, nReadOnly, bIsBlob, "*", sCallerPgm);
         }
      }

      static public void gx_label_ctrl( IGxContext context ,
                                        String sInternalName ,
                                        String sCaption ,
                                        String sLinkURL ,
                                        String sLinkTarget ,
                                        String sUserOnClickCode ,
                                        String sEventName ,
                                        String sTags ,
                                        String sClassString ,
                                        int nJScriptCode ,
                                        String sTooltipText ,
                                        int nVisible ,
                                        int nEnabled ,
                                        short nFormat ,
                                        String sCallerPgm )
      {
         String sEventJsCode ;
         String sStyle ;
         if ( context.isSpaRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_prefixed_prop(sInternalName, "Caption", sCaption);
            context.httpAjaxContext.ajax_rsp_assign_prefixed_prop(sInternalName, "Tooltiptext", sTooltipText);
         }
         sTooltipText = ((StringUtil.StrCmp(sTooltipText, "")==0) ? "" : " title=\""+GXUtil.ValueEncode( sTooltipText)+"\"");
         if ( nFormat == 1 )
         {
            /* HTML Format */
            sStyle = ((nVisible!=0) ? ";display:inline;" : ";display:none;") + sTags;
            context.WriteHtmlText( "<div") ;
            GxWebStd.ClassAttribute( context, sClassString);
            GxWebStd.StyleAttribute( context, sStyle);
            context.WriteHtmlText( " id=\""+sInternalName+"\" "+sTooltipText) ;
            context.WriteHtmlText( ">") ;
         }
         else if ( nFormat != 2 )
         {
            sStyle = ((nVisible!=0) ? "" : ";display:none;") + sTags;
            context.WriteHtmlText( "<span") ;
            GxWebStd.ClassAttribute( context, sClassString);
            GxWebStd.StyleAttribute( context, sStyle);
            context.WriteHtmlText( " id=\""+sInternalName+"\" "+sTooltipText) ;
            context.WriteHtmlText( ">") ;
         }
         if ( nEnabled != 0 )
         {
            /* Initialize internal JScript code according to EventNo */
            if ( nJScriptCode == 1 )
            {
               sEventJsCode = "gx.fn.closeWindow();";
            }
            else if ( nJScriptCode == 3 )
            {
               sEventJsCode = "gx.util.help(" + "'" + context.convertURL( "Help/"+"English/"+StringUtil.Lower( sCallerPgm)) + "');";
            }
            else if ( nJScriptCode == 7 )
            {
               sEventJsCode = "" + "gx.evt.execCliEvt(" + sEventName + ",this);";
            }
            else if ( nJScriptCode == 8 )
            {
               sEventJsCode = "gx.evt.execEvt(" + sEventName + ",this);";
            }
            else if ( nJScriptCode == 6 )
            {
               sEventJsCode = "gx.evt.execEvt(" + sEventName + ",this);";
            }
            else if ( nJScriptCode == 5 )
            {
               sEventJsCode = "gx.evt.execEvt(" + sEventName + ",this);";
            }
            else if ( nJScriptCode == 0 )
            {
               sEventJsCode = "";
            }
            else
            {
               sEventJsCode = "";
            }
            GxWebStd.gx_start_js_anchor( context, nJScriptCode, sEventJsCode, sUserOnClickCode, sLinkURL, sLinkTarget, "");
         }
         else
         {
            sEventJsCode = "";
         }
         if ( nFormat == 0 )
         {
            /* Text Format */
            context.SendWebValueEnter( sCaption) ;
         }
         else
         {
            if ( nFormat == 3 )
            {
               /* Text with meaningful spaces */
               context.SendWebValueSpace( sCaption) ;
            }
            else if ( ( nFormat != 2 ) || ( nVisible != 0 ) )
            {
               context.WriteHtmlText( sCaption) ;
            }
         }
         if ( nEnabled != 0 )
         {
            GxWebStd.gx_end_js_anchor( context, sEventJsCode, sUserOnClickCode, sLinkURL);
         }
         if ( nFormat == 1 )
         {
            context.WriteHtmlText( "</div>") ;
         }
         else if ( nFormat != 2 )
         {
            context.WriteHtmlText( "</span>") ;
         }
         if ( ( nFormat != 0 ) && ( nFormat != 2 ) )
         {
            GxWebStd.gx_ctrl_attribute( context, sInternalName, "data-gxformat", StringUtil.Str( (decimal)(nFormat), 1, 0), false);
         }
         if ( ( nFormat == 1 ) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( sEventJsCode)) || ! String.IsNullOrEmpty(StringUtil.RTrim( sUserOnClickCode)) || ! String.IsNullOrEmpty(StringUtil.RTrim( sLinkURL)) ) )
         {
            GxWebStd.gx_ctrl_attribute( context, sInternalName, "gxlink", "1", false);
         }
      }

      static public void gx_start_js_anchor( IGxContext context ,
                                             int nJScriptCode ,
                                             String sGXOnClickCode ,
                                             String sUserOnClickCode ,
                                             String sLinkURL ,
                                             String sLinkTarget ,
                                             String sClassString )
      {
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( sUserOnClickCode)) )
         {
            if ( ! (0==nJScriptCode) )
            {
               context.WriteHtmlText( "<a href=\"#\" data-gx-evt=\"") ;
               context.WriteHtmlText( StringUtil.Trim( StringUtil.Str( (decimal)(nJScriptCode), 10, 0))) ;
               context.WriteHtmlText( "\"") ;
               context.WriteHtmlText( " data-gx-evt-condition=\"") ;
               context.WriteHtmlText( sUserOnClickCode) ;
               context.WriteHtmlText( "\"") ;
            }
            else
            {
               context.WriteHtmlText( "<a href=\"#\" data-gx-evt=\"") ;
               context.WriteHtmlText( StringUtil.Trim( StringUtil.Str( (decimal)(nJScriptCode), 10, 0))) ;
               context.WriteHtmlText( "\"") ;
            }
            if ( ( nJScriptCode == 4 ) || ( nJScriptCode == 3 ) )
            {
               context.WriteHtmlText( " data-gx-evt-code=\"") ;
               context.WriteHtmlText( sGXOnClickCode) ;
               context.WriteHtmlText( "\"") ;
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( sClassString)) )
            {
               context.WriteHtmlText( " class=\"") ;
               context.WriteHtmlText( sClassString) ;
               context.WriteHtmlText( "\"") ;
            }
            context.WriteHtmlText( ">") ;
         }
         else
         {
            if ( ! (0==nJScriptCode) )
            {
               context.WriteHtmlText( "<a href=\"#\" data-gx-evt=\"") ;
               context.WriteHtmlText( StringUtil.Trim( StringUtil.Str( (decimal)(nJScriptCode), 10, 0))) ;
               context.WriteHtmlText( "\"") ;
               if ( ( nJScriptCode == 4 ) || ( nJScriptCode == 3 ) )
               {
                  context.WriteHtmlText( " data-gx-evt-code=\"") ;
                  context.WriteHtmlText( sGXOnClickCode) ;
                  context.WriteHtmlText( "\"") ;
               }
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( sClassString)) )
               {
                  context.WriteHtmlText( " class=\"") ;
                  context.WriteHtmlText( sClassString) ;
                  context.WriteHtmlText( "\"") ;
               }
               context.WriteHtmlText( ">") ;
            }
            else
            {
               GxWebStd.gx_link_start( context, sLinkURL, sLinkTarget, sClassString);
            }
         }
      }

      static public void gx_end_js_anchor( IGxContext context ,
                                           String sGXOnClickCode ,
                                           String sUserOnClickCode ,
                                           String sLinkURL )
      {
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( sGXOnClickCode)) && String.IsNullOrEmpty(StringUtil.RTrim( sUserOnClickCode)) ) )
         {
            context.WriteHtmlText( "</a>") ;
         }
         else
         {
            GxWebStd.gx_link_end( context, sLinkURL);
         }
      }

      static public void gx_label_element( IGxContext context ,
                                           String sReferencedControl ,
                                           String sLabelCaption ,
                                           String sLabelClass ,
                                           int nLabelPosition ,
                                           bool bDataAttSupported )
      {
         context.WriteHtmlText( "<label class=\"gx-label ") ;
         context.WriteHtmlText( sLabelClass) ;
         context.WriteHtmlText( " control-label") ;
         if ( ( nLabelPosition == 0 ) && ! bDataAttSupported )
         {
            context.WriteHtmlText( " gx-sr-only ") ;
         }
         context.WriteHtmlText( "\" for=\"") ;
         context.WriteHtmlText( sReferencedControl) ;
         context.WriteHtmlText( "\"") ;
         if ( ( nLabelPosition == 0 ) && bDataAttSupported )
         {
            context.WriteHtmlTextNl( " data-gx-sr-only ") ;
         }
         context.WriteHtmlText( ">") ;
         context.WriteHtmlText( sLabelCaption) ;
         context.WriteHtmlText( "</label>") ;
      }

      static public bool gx_redirect( IGxContext context )
      {
         if ( context.WillRedirect( ) )
         {
            context.Redirect( context.wjLoc );
            context.DispatchAjaxCommands();
            return true ;
         }
         else if ( context.nUserReturn == 1 )
         {
            if ( context.isAjaxRequest( ) )
            {
               context.ajax_rsp_command_close();
               context.DispatchAjaxCommands();
            }
            else
            {
               if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetReferer( ))) || context.IsLocalStorageSupported( ) )
               {
                  if ( context.isSpaRequest( true) )
                  {
                     context.SetHeader("X-SPA-RETURN", (String)(context.getWebReturnParmsJS( )));
                     context.SetHeader("X-SPA-RETURN-MD", (String)(context.getWebReturnParmsMetadataJS( )));
                  }
                  else
                  {
                     context.WriteHtmlText( GXUtil.HtmlDocType( )) ;
                     context.WriteHtmlText( "<html><head><meta http-equiv=\"content-type\" content=\"text/html; charset=UTF-8\"><title>Close window</title>") ;
                     context.AddJavascriptSource("jquery.js", "?"+context.GetBuildNumber( 126726), false);
                     context.AddJavascriptSource("gxgral.js", "?"+context.GetBuildNumber( 126726), false);
                     context.WriteHtmlText( "</head><body><script type=\"text/javascript\">") ;
                     context.WriteHtmlText( "gx.fn.closeWindowServerScript(") ;
                     context.WriteHtmlText( context.getWebReturnParmsJS( )) ;
                     context.WriteHtmlText( ", ") ;
                     context.WriteHtmlText( context.getWebReturnParmsMetadataJS( )) ;
                     if ( context.IsLocalStorageSupported( ) )
                     {
                        context.WriteHtmlText( ", true") ;
                     }
                     else
                     {
                        context.WriteHtmlText( ", false") ;
                     }
                     context.WriteHtmlText( ");</script></body></html>") ;
                  }
               }
               else
               {
                  context.Redirect( context.GetReferer( ) );
                  context.WindowClosed();
               }
            }
            return true ;
         }
         else
         {
            return false ;
         }
      }

      static public void gx_table_start( IGxContext context ,
                                         String sCtrlName ,
                                         String sHTMLid ,
                                         String sHTMLTags ,
                                         String sClassString ,
                                         int nBorder ,
                                         String sAlign ,
                                         String sTooltiptext ,
                                         int nCellpadding ,
                                         int nCellspacing ,
                                         String sStyleString ,
                                         String sRules ,
                                         String sCaption ,
                                         int nParentIsFreeStyle )
      {
         if ( context.isSpaRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_prefixed_prop(sCtrlName, "Tooltiptext", sTooltiptext);
         }
         context.WriteHtmlText( "<table") ;
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( sCtrlName)) )
         {
            context.WriteHtmlText( " id=\""+sHTMLid+"\"") ;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( sHTMLTags)) )
         {
            context.WriteHtmlText( sHTMLTags) ;
         }
         if ( StringUtil.StrCmp(sAlign, "") != 0 )
         {
            if ( StringUtil.StrCmp(sAlign, "left") == 0 )
            {
               sStyleString = "margin-right:auto;" + sStyleString;
            }
            else
            {
               if ( StringUtil.StrCmp(sAlign, "center") == 0 )
               {
                  sStyleString = "margin-left:auto; margin-right: auto;" + sStyleString;
               }
               else
               {
                  if ( StringUtil.StrCmp(sAlign, "right") == 0 )
                  {
                     sStyleString = "margin-left:auto;" + sStyleString;
                  }
               }
            }
         }
         GxWebStd.ClassAttribute( context, sClassString);
         if ( ! (0==nBorder) )
         {
            context.WriteHtmlText( " border=\"") ;
            context.WriteHtmlText( StringUtil.Str( (decimal)(nBorder), 3, 0)) ;
            context.WriteHtmlText( "\"") ;
         }
         context.WriteHtmlText( " data-cellpadding=\"") ;
         context.WriteHtmlText( StringUtil.LTrim( StringUtil.Str( (decimal)(nCellpadding), 10, 0))) ;
         context.WriteHtmlText( "\"") ;
         context.WriteHtmlText( " data-cellspacing=\"") ;
         context.WriteHtmlText( StringUtil.LTrim( StringUtil.Str( (decimal)(nCellspacing), 10, 0))) ;
         context.WriteHtmlText( "\"") ;
         if ( ( StringUtil.StrCmp(sRules, "") != 0 ) && ( StringUtil.StrCmp(sRules, "none") != 0 ) )
         {
            context.WriteHtmlText( " rules=\"") ;
            context.WriteHtmlText( sRules) ;
            context.WriteHtmlText( "\"") ;
         }
         if ( StringUtil.StrCmp(sTooltiptext, "") != 0 )
         {
            context.WriteHtmlText( " title=\"") ;
            context.SendWebValue( StringUtil.Trim( sTooltiptext)) ;
            context.WriteHtmlText( "\"") ;
         }
         if ( nParentIsFreeStyle == 0 )
         {
            GxWebStd.StyleAttribute( context, sStyleString);
         }
         context.WriteHtmlText( ">") ;
         if ( StringUtil.StrCmp(sCaption, "") != 0 )
         {
            context.WriteHtmlText( "<caption>"+sCaption+"</caption>") ;
         }
      }

      static public void gx_html_headers( IGxContext context ,
                                          int nContentType ,
                                          String sCacheCtrl ,
                                          String sCacheExp ,
                                          GXRadio radrMeta ,
                                          GXRadio radrMetaequiv ,
                                          bool bIsRwd )
      {
         short wbTemp ;
         short idxLst ;
         bool addContentType ;
         GxWebStd.set_html_headers( context, nContentType, sCacheCtrl, sCacheExp);
         if ( nContentType == 0 )
         {
            context.WriteHtmlTextNl( GXUtil.HtmlDocType( )) ;
            context.WriteHtmlTextNl( "<html lang=\"en\""+">") ;
            context.WriteHtmlTextNl( "<head>") ;
            if ( bIsRwd )
            {
               GXWebForm.AddResponsiveMetaHeaders(radrMeta);
            }
            idxLst = 1;
            while ( idxLst <= radrMeta.ItemCount )
            {
               context.WriteHtmlText( "<meta name=\""+StringUtil.RTrim( radrMeta.getItemValue(idxLst))+"\" content=\"") ;
               context.SendWebAttribute( StringUtil.RTrim( radrMeta.getItemText(idxLst))) ;
               context.WriteHtmlTextNl( "\""+GXUtil.HtmlEndTag( HTMLElement.META)) ;
               idxLst = (short)(idxLst+1);
            }
            context.WriteHtmlTextNl( "<!--[if IE]><meta http-equiv=\"page-enter\" content=\"blendTrans(Duration=0.1)\""+GXUtil.HtmlEndTag( HTMLElement.META)+"<![endif]-->") ;
            context.WriteHtmlTextNl( "<meta name=\"fragment\" content=\"!\""+GXUtil.HtmlEndTag( HTMLElement.META)) ;
            idxLst = 1;
            addContentType = true;
            while ( idxLst <= radrMetaequiv.ItemCount )
            {
               if ( StringUtil.StrCmp(StringUtil.Lower( radrMetaequiv.getItemValue(idxLst)), "content-type") == 0 )
               {
                  addContentType = false;
                  wbTemp = context.ResponseContentType( radrMetaequiv.getItemText(idxLst));
               }
               idxLst = (short)(idxLst+1);
            }
            if ( addContentType )
            {
               context.WriteHtmlTextNl( "<meta http-equiv=\"content-type\" content=\"text/html; charset=UTF-8\""+GXUtil.HtmlEndTag( HTMLElement.META)) ;
            }
            idxLst = 1;
            while ( idxLst <= radrMetaequiv.ItemCount )
            {
               context.WriteHtmlText( "<meta http-equiv=\""+StringUtil.RTrim( radrMetaequiv.getItemValue(idxLst))+"\" content=\"") ;
               context.SendWebAttribute( StringUtil.RTrim( radrMetaequiv.getItemText(idxLst))) ;
               context.WriteHtmlTextNl( "\""+GXUtil.HtmlEndTag( HTMLElement.META)) ;
               idxLst = (short)(idxLst+1);
            }
         }
      }

      static public void set_html_headers( IGxContext context ,
                                           int nContentType ,
                                           String sCacheCtrl ,
                                           String sCacheExp )
      {
         short wbTemp ;
         if ( nContentType != 1 )
         {
            if ( context.isAjaxRequest( ) && ! context.isMultipartRequest( ) )
            {
               wbTemp = context.ResponseContentType( "application/json");
            }
            else
            {
               wbTemp = context.ResponseContentType( "text/html");
            }
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( sCacheCtrl)) )
         {
            wbTemp = context.SetHeader( "pragma", "no-cache");
            wbTemp = context.SetHeader( "Cache-Control", "no-store");
         }
         else
         {
            wbTemp = context.SetHeader( "Cache-Control", sCacheCtrl);
            wbTemp = context.SetHeader( "Cache-Control", sCacheExp);
         }
      }

      static public void gx_html_textarea( IGxContext context ,
                                           String sCtrlName ,
                                           String sValue ,
                                           String sLinkURL ,
                                           String sTags ,
                                           short nFormat ,
                                           int nVisible ,
                                           int nEnabled ,
                                           int nRTEnabled ,
                                           int nWidth ,
                                           String sWidthUnit ,
                                           int nHeight ,
                                           String sHeightUnit ,
                                           String sStyleString ,
                                           String sClassString ,
                                           String sColumnClassString ,
                                           String sColumnHeaderClassString ,
                                           String sLength ,
                                           int nAutoResize ,
                                           int nMaxNumberLines ,
                                           String sLinkTarget ,
                                           String sPlaceholder ,
                                           short nAutoCorrection ,
                                           bool bSendHidden ,
                                           String sDomainType ,
                                           String sEventName ,
                                           int nJScriptCode ,
                                           String sCallerPgm )
      {
         String sEventJsCode ;
         String sTextAreaStyleString ;
         if ( context.isSpaRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_prefixed_prop(sCtrlName, "Invitemessage", sPlaceholder);
         }
         sEventJsCode = "";
         sTextAreaStyleString = sStyleString + ((nVisible==0)||((nEnabled==0)) ? ";display:none;" : "");
         context.WriteHtmlText( "<textarea ") ;
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( sPlaceholder)) )
         {
            context.WriteHtmlText( " placeholder=\"") ;
            context.SendWebValue( StringUtil.Trim( sPlaceholder)) ;
            context.WriteHtmlText( "\"") ;
         }
         context.WriteHtmlText( " spellcheck=") ;
         if ( nAutoCorrection == 0 )
         {
            context.WriteHtmlText( "\"false\"") ;
         }
         else
         {
            context.WriteHtmlText( "\"true\"") ;
         }
         if ( StringUtil.StrCmp(sWidthUnit, "chr") == 0 )
         {
            context.WriteHtmlText( " cols=\""+nWidth+"\" ") ;
         }
         else
         {
            sTextAreaStyleString = sTextAreaStyleString + ";width:" + nWidth + sWidthUnit;
         }
         if ( StringUtil.StrCmp(sHeightUnit, "row") == 0 )
         {
            context.WriteHtmlText( " rows=\""+nHeight+"\" ") ;
         }
         else
         {
            sTextAreaStyleString = sTextAreaStyleString + ";height:" + nHeight + sHeightUnit;
         }
         context.WriteHtmlText( " name=\""+sCtrlName+"\""+" id=\""+sCtrlName+"\" "+sTags) ;
         if ( ( nMaxNumberLines > 1 ) && ( nEnabled != 0 ) )
         {
            context.WriteHtmlText( " data-gx-text-maxlines=\""+nMaxNumberLines+"\" ") ;
         }
         GxWebStd.ClassAttribute( context, sClassString);
         GxWebStd.StyleAttribute( context, sTextAreaStyleString);
         context.WriteHtmlText( " onKeyDown=\"return gx.evt.checkMaxLength(this,"+sLength+",event);\" ") ;
         context.WriteHtmlText( " onKeyUp=\"return gx.evt.checkMaxLength(this,"+sLength+",event);\" ") ;
         context.WriteHtmlTextNl( ">") ;
         context.SendWebValue( StringUtil.Trim( sValue)) ;
         context.WriteHtmlTextNl( "</textarea>") ;
         GxWebStd.gx_ctrl_attribute( context, sCtrlName, "maxlength", sLength, false);
         if ( nEnabled == 0 )
         {
            sStyleString = sStyleString + ((nAutoResize==0) ? ";overflow:hidden;" : "") + ((nVisible==0) ? ";display:none;" : "");
            if ( ( StringUtil.Len( sClassString) != 0 ) && ( StringUtil.StringSearch( sClassString, "Readonly", 1) != 1 ) )
            {
               sClassString = "Readonly" + sClassString;
            }
            context.WriteHtmlText( "<span") ;
            GxWebStd.ClassAttribute( context, sClassString);
            GxWebStd.StyleAttribute( context, sStyleString);
            context.WriteHtmlText( " id=\"span_"+sCtrlName+"\"") ;
            context.WriteHtmlText( ">") ;
            /* Initialize internal JScript code according to EventNo */
            if ( nJScriptCode == 1 )
            {
               sEventJsCode = "gx.fn.closeWindow();";
            }
            else if ( nJScriptCode == 3 )
            {
               sEventJsCode = "gx.util.help(" + "'" + context.convertURL( "Help/"+"English/"+StringUtil.Lower( sCallerPgm)) + "');";
            }
            else if ( nJScriptCode == 7 )
            {
               sEventJsCode = "" + "gx.evt.execCliEvt(" + sEventName + ",this);";
            }
            else if ( nJScriptCode == 8 )
            {
               sEventJsCode = "gx.evt.execEvt(" + sEventName + ",this);";
            }
            else if ( nJScriptCode == 6 )
            {
               sEventJsCode = "gx.evt.execEvt(" + sEventName + ",this);";
            }
            else if ( nJScriptCode == 5 )
            {
               sEventJsCode = "gx.evt.execEvt(" + sEventName + ",this);";
            }
            else if ( nJScriptCode == 0 )
            {
               sEventJsCode = "";
            }
            else
            {
               sEventJsCode = "";
            }
            GxWebStd.gx_start_js_anchor( context, nJScriptCode, sEventJsCode, "", sLinkURL, sLinkTarget, "");
            if ( nFormat == 0 )
            {
               context.SendWebValueEnter( sValue) ;
            }
            else
            {
               if ( nFormat == 3 )
               {
                  context.SendWebValueComplete( sValue) ;
               }
               else
               {
                  context.WriteHtmlText( sValue) ;
               }
            }
            GxWebStd.gx_end_js_anchor( context, sEventJsCode, "", sLinkURL);
            context.WriteHtmlText( "</span>") ;
         }
      }

      static public void gx_geolocation( IGxContext context ,
                                         String sCtrlName ,
                                         String sValue ,
                                         String sFormatedValue ,
                                         String sTags ,
                                         String sEventName ,
                                         String sLinkURL ,
                                         String sLinkTarget ,
                                         String sTooltipText ,
                                         String sPlaceholder ,
                                         String sUserOnClickCode ,
                                         int nJScriptCode ,
                                         String sClassString ,
                                         String sStyleString ,
                                         String sROClassString ,
                                         String sColumnClassString ,
                                         String sColumnHeaderClassString ,
                                         int nVisible ,
                                         int nEnabled ,
                                         int nRTEnabled ,
                                         String sType ,
                                         String sStep ,
                                         int nWidth ,
                                         String nWidthUnit ,
                                         int nHeight ,
                                         String nHeightUnit ,
                                         int nLength ,
                                         short nIsPassword ,
                                         short nFormat ,
                                         int nParentId ,
                                         short bHasTheme ,
                                         short nAutoComplete ,
                                         short nAutoCorrection ,
                                         bool bSendHidden ,
                                         String sDomainType ,
                                         String sAlign ,
                                         bool bIsTextEdit )
      {
         sTags = " data-gx-geolocation";
         GxWebStd.gx_single_line_edit( context, sCtrlName, sValue, sFormatedValue, sTags, sEventName, sLinkURL, sLinkTarget, sTooltipText, sPlaceholder, sUserOnClickCode, nJScriptCode, sClassString, sStyleString, sROClassString, sColumnClassString, sColumnHeaderClassString, nVisible, nEnabled, nRTEnabled, sType, sStep, nWidth, nWidthUnit, nHeight, nHeightUnit, nLength, nIsPassword, nFormat, nParentId, bHasTheme, nAutoComplete, nAutoCorrection, bSendHidden, sDomainType, "", false, "");
         if ( ( nRTEnabled != 0 ) || ( nEnabled != 0 ) )
         {
            GxWebStd.gx_bitmap_readonly( context, sCtrlName+"_geoLocMe", context.convertURL( "locateMe"), "", "", "", "", nVisible, 1, context.GetMessage( "GXM_locatemeoption", ""), context.GetMessage( "GXM_locatemeoption", ""), 0, 0, 0, nWidthUnit, 0, nHeightUnit, 0, 0, 4, sUserOnClickCode, sEventName, sStyleString, "GeoLocOption", "", "", "", "", "", "gx.geolocation.getMyPosition(this);", "", "");
         }
      }

      static public void gx_group_start( IGxContext context ,
                                         String sInternalName ,
                                         String sCaption ,
                                         int nVisible ,
                                         int nWidth ,
                                         String sWidthUnit ,
                                         int nHeight ,
                                         String sHeightUnit ,
                                         String sClassString ,
                                         String sTags ,
                                         String sCallerPgm )
      {
         context.WriteHtmlText( "<fieldset ") ;
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( sInternalName)) )
         {
            context.WriteHtmlText( "id=\""+sInternalName+"\" ") ;
         }
         GxWebStd.ClassAttribute( context, sClassString);
         context.WriteHtmlText( " style=\"") ;
         if ( nVisible == 0 )
         {
            context.WriteHtmlText( "display:none;") ;
         }
         if ( ! (0==nWidth) )
         {
            context.WriteHtmlText( " width:") ;
            context.WriteHtmlText( StringUtil.LTrim( StringUtil.Str( (decimal)(nWidth), 10, 0))) ;
            context.WriteHtmlText( sWidthUnit+";") ;
         }
         if ( ! (0==nHeight) )
         {
            context.WriteHtmlText( " height:") ;
            context.WriteHtmlText( StringUtil.LTrim( StringUtil.Str( (decimal)(nHeight), 10, 0))) ;
            context.WriteHtmlText( sHeightUnit+";") ;
         }
         context.WriteHtmlText( "\"") ;
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( sTags)) )
         {
            context.WriteHtmlText( sTags) ;
         }
         context.WriteHtmlText( ">") ;
         context.WriteHtmlText( "<legend ") ;
         GxWebStd.ClassAttribute( context, sClassString+"Title");
         context.WriteHtmlText( ">") ;
         context.WriteHtmlText( sCaption) ;
         context.WriteHtmlText( "</legend>") ;
      }

      static public void gx_div_start( IGxContext context ,
                                       String sInternalName ,
                                       int nVisible ,
                                       int nWidth ,
                                       String sWidthUnit ,
                                       int nHeight ,
                                       String sHeightUnit ,
                                       String sClassString ,
                                       String sAlign ,
                                       String sVAlign ,
                                       String sTags ,
                                       String sExtraStyle ,
                                       String sHtmlTag )
      {
         String sOStyle ;
         bool bHAlignedVar ;
         bool bVAlignedVar ;
         bHAlignedVar = (bool)(!String.IsNullOrEmpty(StringUtil.RTrim( sAlign))&&(StringUtil.StrCmp(StringUtil.Lower( sAlign), "left")!=0));
         bVAlignedVar = (bool)(!String.IsNullOrEmpty(StringUtil.RTrim( sVAlign))&&(StringUtil.StrCmp(StringUtil.Lower( sVAlign), "top")!=0));
         context.WriteHtmlText( "<"+sHtmlTag+" ") ;
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( sInternalName)) )
         {
            context.WriteHtmlText( "id=\""+sInternalName+"\" ") ;
         }
         GxWebStd.ClassAttribute( context, sClassString);
         sOStyle = "";
         if ( nVisible == 0 )
         {
            sOStyle = "display:none;";
         }
         if ( ! (0==nWidth) )
         {
            sOStyle = sOStyle + " width:" + StringUtil.LTrim( StringUtil.Str( (decimal)(nWidth), 10, 0)) + sWidthUnit + ";";
         }
         if ( ! (0==nHeight) )
         {
            sOStyle = sOStyle + " height:" + StringUtil.LTrim( StringUtil.Str( (decimal)(nHeight), 10, 0)) + sHeightUnit + ";";
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( sExtraStyle)) )
         {
            sOStyle = sOStyle + CSSHelper.Prettify( sExtraStyle+";");
         }
         GxWebStd.StyleAttribute( context, sOStyle);
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( sTags)) )
         {
            context.WriteHtmlText( sTags) ;
         }
         if ( bHAlignedVar )
         {
            context.WriteHtmlText( " data-align=\"") ;
            context.WriteHtmlText( StringUtil.Lower( sAlign)) ;
            context.WriteHtmlText( "\"") ;
         }
         if ( bVAlignedVar )
         {
            context.WriteHtmlText( " data-valign=\"") ;
            context.WriteHtmlText( StringUtil.Lower( sVAlign)) ;
            context.WriteHtmlText( "\"") ;
         }
         context.WriteHtmlText( ">") ;
         if ( bHAlignedVar || bVAlignedVar )
         {
            context.WriteHtmlText( "<div data-align-outer=\"\"><div data-align-inner=\"\">") ;
         }
      }

      static public void gx_div_end( IGxContext context ,
                                     String sAlign ,
                                     String sVAlign ,
                                     String sHtmlTag )
      {
         bool bHAlignedVar ;
         bool bVAlignedVar ;
         bHAlignedVar = (bool)(!String.IsNullOrEmpty(StringUtil.RTrim( sAlign))&&(StringUtil.StrCmp(StringUtil.Lower( sAlign), "left")!=0));
         bVAlignedVar = (bool)(!String.IsNullOrEmpty(StringUtil.RTrim( sVAlign))&&(StringUtil.StrCmp(StringUtil.Lower( sVAlign), "top")!=0));
         if ( bHAlignedVar || bVAlignedVar )
         {
            context.WriteHtmlText( "</div></div>") ;
         }
         context.WriteHtmlText( "</"+sHtmlTag+">") ;
      }

      static public void gx_embedded_page( IGxContext context ,
                                           String sInternalName ,
                                           String sSrc ,
                                           int nVisible ,
                                           int nWidth ,
                                           String sWidthUnit ,
                                           int nHeight ,
                                           String sHeightUnit ,
                                           int nBorderStyle ,
                                           String sAlign ,
                                           String sTooltipText ,
                                           String sScroll )
      {
         String sStyleString ;
         if ( context.isSpaRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_prefixed_prop(sInternalName, "Tooltiptext", sTooltipText);
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( sSrc)) )
         {
            sSrc = "about:blank";
         }
         sStyleString = ((nVisible!=0) ? "" : ";display:none;");
         context.WriteHtmlText( "<IFRAME src=\""+sSrc+"\"") ;
         context.WriteHtmlText( " name=\""+sInternalName+"\"") ;
         if ( nWidth > 0 )
         {
            sStyleString = sStyleString + "width:" + StringUtil.LTrim( StringUtil.Str( (decimal)(nWidth), 10, 0)) + sWidthUnit + ";";
         }
         if ( nHeight > 0 )
         {
            sStyleString = sStyleString + "height:" + StringUtil.LTrim( StringUtil.Str( (decimal)(nHeight), 10, 0)) + sHeightUnit + ";";
         }
         if ( StringUtil.StrCmp(sScroll, "yes") == 0 )
         {
            sStyleString = sStyleString + "overflow-x:scroll;overflow-y:scroll;";
         }
         else
         {
            if ( StringUtil.StrCmp(sScroll, "no") == 0 )
            {
               sStyleString = sStyleString + "overflow-x:hidden;overflow-y:hidden;";
            }
            else
            {
               if ( StringUtil.StrCmp(sScroll, "auto") == 0 )
               {
                  sStyleString = sStyleString + "overflow-x:auto;overflow-y:auto;";
               }
            }
         }
         if ( StringUtil.StrCmp(sAlign, "right") == 0 )
         {
            sStyleString = sStyleString + "float:right;";
         }
         else
         {
            if ( StringUtil.StrCmp(sAlign, "left") == 0 )
            {
               sStyleString = sStyleString + "float:left;";
            }
            else
            {
               if ( StringUtil.StrCmp(sAlign, "center") == 0 )
               {
                  sStyleString = sStyleString + "display:block;margin:0 auto;";
               }
            }
         }
         if ( nBorderStyle == 0 )
         {
            sStyleString = sStyleString + "border:none;";
         }
         context.WriteHtmlText( " title=\""+sTooltipText+"\""+" style=\""+sStyleString+"\""+"></IFRAME>") ;
      }

      static public void gx_form_group_start( IGxContext context ,
                                              int nLabelPosition )
      {
         if ( nLabelPosition != 0 )
         {
            context.WriteHtmlText( "<div class=\"form-group gx-form-group\">") ;
         }
      }

      static public void gx_form_group_end( IGxContext context ,
                                            int nLabelPosition )
      {
         if ( nLabelPosition != 0 )
         {
            context.WriteHtmlText( "</div>") ;
         }
      }

      static public void StyleAttribute( IGxContext context ,
                                         String sStyle )
      {
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( sStyle)) )
         {
            context.WriteHtmlText( " style=\"") ;
            context.SendWebValue( StringUtil.LTrim( CSSHelper.Prettify( sStyle))) ;
            context.WriteHtmlText( "\" ") ;
         }
      }

      static public void ClassAttribute( IGxContext context ,
                                         String sClass )
      {
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( sClass)) )
         {
            context.WriteHtmlText( " class=\"") ;
            context.SendWebValue( StringUtil.LTrim( sClass)) ;
            context.WriteHtmlText( "\" ") ;
         }
      }

   }

}
