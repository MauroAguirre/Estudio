/*!   GeneXus C# 15_0_12-126726 on 3/22/2019 19:0:41.2
*/
gx.evt.autoSkip=!1;gx.define("rwdrecentlinks",!0,function(n){var i,t;this.ServerClass="rwdrecentlinks";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.setCmpContext(n);this.ReadonlyForm=!0;this.hasEnterEvent=!1;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV6FormCaption=gx.fn.getControlValue("vFORMCAPTION");this.AV7FormPgmName=gx.fn.getControlValue("vFORMPGMNAME");this.AV6FormCaption=gx.fn.getControlValue("vFORMCAPTION")};this.e11051_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("MAINTABLE","Class")=="RecentLinksMainTable"?gx.fn.setCtrlProperty("MAINTABLE","Class","RecentLinksMainTable RecentLinksMainTableExpanded"):gx.fn.setCtrlProperty("MAINTABLE","Class","RecentLinksMainTable"),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("MAINTABLE","Class")',ctrl:"MAINTABLE",prop:"Class"}]),gx.$.Deferred().resolve()};this.e13052_client=function(){return this.executeServerEvent("ENTER",!0,arguments[0],!1,!1)};this.e14052_client=function(){return this.executeServerEvent("CANCEL",!0,arguments[0],!1,!1)};this.GXValidFnc=[];i=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,11,14];this.GXLastCtrlId=14;this.LinksContainer=new gx.grid.grid(this,2,"WbpLvl2",8,"Links","Links","LinksContainer",this.CmpContext,this.IsMasterPage,"rwdrecentlinks",[],!0,0,!0,!0,0,!1,!1,!1,"",0,"px",0,"px","New row",!1,!1,!1,null,null,!1,"",!1,[1,1,1,1],!1,0,!1,!1);t=this.LinksContainer;t.startRow("","","","","","");t.startCell("","","","","","","","","","");t.startTable("Linkstable",11,"0px");t.startRow("","","","","","");t.startCell("","","","","","","","","","");t.addTextBlock("PLACE",null,14);t.endCell();t.endRow();t.endTable();t.endCell();t.endRow();this.LinksContainer.emptyText="";this.setGrid(t);i[2]={id:2,fld:"",grid:0};i[3]={id:3,fld:"MAINTABLE",grid:0};i[4]={id:4,fld:"",grid:0};i[5]={id:5,fld:"",grid:0};i[6]={id:6,fld:"RECENTTEXT",format:0,grid:0,evt:"e11051_client"};i[7]={id:7,fld:"",grid:0};i[11]={id:11,fld:"LINKSTABLE",grid:8};i[14]={id:14,fld:"PLACE",format:0,grid:8};this.AV6FormCaption="";this.AV7FormPgmName="";this.Events={e13052_client:["ENTER",!0],e14052_client:["CANCEL",!0],e11051_client:["RECENTTEXT.CLICK",!1]};this.EvtParms.REFRESH=[[{av:"LINKS_nFirstRecordOnPage"},{av:"LINKS_nEOF"},{av:"AV6FormCaption",fld:"vFORMCAPTION",pic:""},{av:"sPrefix"}],[]];this.EvtParms["RECENTTEXT.CLICK"]=[[{av:'gx.fn.getCtrlProperty("MAINTABLE","Class")',ctrl:"MAINTABLE",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("MAINTABLE","Class")',ctrl:"MAINTABLE",prop:"Class"}]];this.EvtParms["LINKS.LOAD"]=[[{av:"AV6FormCaption",fld:"vFORMCAPTION",pic:""}],[{av:'gx.fn.getCtrlProperty("PLACE","Caption")',ctrl:"PLACE",prop:"Caption"},{av:'gx.fn.getCtrlProperty("PLACE","Link")',ctrl:"PLACE",prop:"Link"}]];this.setVCMap("AV6FormCaption","vFORMCAPTION",0,"char",100,0);this.setVCMap("AV7FormPgmName","vFORMPGMNAME",0,"svchar",256,0);this.setVCMap("AV6FormCaption","vFORMCAPTION",0,"char",100,0);this.setVCMap("AV6FormCaption","vFORMCAPTION",0,"char",100,0);t.addRefreshingVar({rfrVar:"AV6FormCaption"});this.Initialize()})