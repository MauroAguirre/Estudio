/*!   GeneXus C# 15_0_12-126726 on 4/12/2019 8:54:32.5
*/
gx.evt.autoSkip=!1;gx.define("viewclase",!1,function(){var n,t;this.ServerClass="viewclase";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!1;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV11LoadAllTabs=gx.fn.getControlValue("vLOADALLTABS");this.AV7SelectedTabCode=gx.fn.getControlValue("vSELECTEDTABCODE");this.AV12ClaseId=gx.fn.getIntegerValue("vCLASEID",",");this.AV6TabCode=gx.fn.getControlValue("vTABCODE");this.AV12ClaseId=gx.fn.getIntegerValue("vCLASEID",",");this.AV11LoadAllTabs=gx.fn.getControlValue("vLOADALLTABS");this.AV7SelectedTabCode=gx.fn.getControlValue("vSELECTEDTABCODE")};this.s112_client=function(){(this.AV11LoadAllTabs||this.AV7SelectedTabCode==""||this.AV7SelectedTabCode=="General")&&this.createWebComponent("Generalwc","ClaseGeneral",[this.AV12ClaseId]);(this.AV11LoadAllTabs||this.AV7SelectedTabCode=="Socios")&&this.createWebComponent("Socioswc","ClaseSociosWC",[this.AV12ClaseId])};this.e130k1_client=function(){return this.clearMessages(),this.AV7SelectedTabCode=this.TABContainer.ActivePageControlName,this.AV11LoadAllTabs=!1,this.s112_client(),this.refreshOutputs([{av:"AV7SelectedTabCode",fld:"vSELECTEDTABCODE",pic:""},{av:"AV11LoadAllTabs",fld:"vLOADALLTABS",pic:""},{ctrl:"GENERALWC"},{ctrl:"SOCIOSWC"}]),gx.$.Deferred().resolve()};this.e140k2_client=function(){return this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e150k2_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,24,25,27,28,29,32,33,35,36,37];this.GXLastCtrlId=37;this.TABContainer=gx.uc.getNew(this,22,19,"Tab","TABContainer","Tab","TAB");t=this.TABContainer;t.setProp("Enabled","Enabled",!0,"boolean");t.setProp("ActivePage","Activepage","","int");t.setDynProp("ActivePageControlName","Activepagecontrolname","","char");t.setProp("PageCount","Pagecount",2,"num");t.setProp("Class","Class","WWTab","str");t.setProp("HistoryManagement","Historymanagement",!0,"bool");t.setProp("Visible","Visible",!0,"bool");t.setC2ShowFunction(function(n){n.show()});t.addEventHandler("TabChanged",this.e130k1_client);this.setUserControl(t);n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"MAINTABLE",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"TABLETOP",grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[9]={id:9,fld:"VIEWTITLE",format:0,grid:0};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"VIEWALL",format:0,grid:0};n[12]={id:12,fld:"",grid:0};n[13]={id:13,fld:"",grid:0};n[14]={id:14,fld:"TABTABLE_1",grid:0};n[15]={id:15,fld:"",grid:0};n[16]={id:16,fld:"",grid:0};n[17]={id:17,fld:"",grid:0};n[18]={id:18,fld:"",grid:0};n[19]={id:19,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"CLASEID",gxz:"Z3ClaseId",gxold:"O3ClaseId",gxvar:"A3ClaseId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A3ClaseId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z3ClaseId=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("CLASEID",gx.O.A3ClaseId,0)},c2v:function(){this.val()!==undefined&&(gx.O.A3ClaseId=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("CLASEID",",")},nac:gx.falseFn};n[20]={id:20,fld:"",grid:0};n[21]={id:21,fld:"",grid:0};n[24]={id:24,fld:"GENERAL_TITLE",format:0,grid:0};n[25]={id:25,fld:"",grid:0};n[27]={id:27,fld:"TABLEGENERAL",grid:0};n[28]={id:28,fld:"",grid:0};n[29]={id:29,fld:"",grid:0};n[32]={id:32,fld:"SOCIOS_TITLE",format:0,grid:0};n[33]={id:33,fld:"",grid:0};n[35]={id:35,fld:"TABLESOCIOS",grid:0};n[36]={id:36,fld:"",grid:0};n[37]={id:37,fld:"",grid:0};this.A3ClaseId=0;this.Z3ClaseId=0;this.O3ClaseId=0;this.A3ClaseId=0;this.AV12ClaseId=0;this.AV6TabCode="";this.AV11LoadAllTabs=!1;this.AV7SelectedTabCode="";this.Events={e140k2_client:["ENTER",!0],e150k2_client:["CANCEL",!0],e130k1_client:["TAB.TABCHANGED",!1]};this.EvtParms.REFRESH=[[{av:"AV12ClaseId",fld:"vCLASEID",pic:"ZZZ9",hsh:!0},{av:"AV6TabCode",fld:"vTABCODE",pic:"",hsh:!0},{av:"A3ClaseId",fld:"CLASEID",pic:"ZZZ9"}],[]];this.EvtParms.START=[[{av:"AV15Pgmname",fld:"vPGMNAME",pic:""},{av:"A3ClaseId",fld:"CLASEID",pic:"ZZZ9"},{av:"AV12ClaseId",fld:"vCLASEID",pic:"ZZZ9",hsh:!0},{av:"AV6TabCode",fld:"vTABCODE",pic:"",hsh:!0},{av:"AV11LoadAllTabs",fld:"vLOADALLTABS",pic:""},{av:"AV7SelectedTabCode",fld:"vSELECTEDTABCODE",pic:""}],[{ctrl:"FORM",prop:"Caption"},{av:'gx.fn.getCtrlProperty("VIEWALL","Link")',ctrl:"VIEWALL",prop:"Link"},{av:'gx.fn.getCtrlProperty("VIEWALL","Visible")',ctrl:"VIEWALL",prop:"Visible"},{av:"AV11LoadAllTabs",fld:"vLOADALLTABS",pic:""},{av:"AV7SelectedTabCode",fld:"vSELECTEDTABCODE",pic:""},{av:"this.TABContainer.ActivePageControlName",ctrl:"TAB",prop:"ActivePageControlName"},{ctrl:"GENERALWC"},{ctrl:"SOCIOSWC"}]];this.EvtParms["TAB.TABCHANGED"]=[[{av:"this.TABContainer.ActivePageControlName",ctrl:"TAB",prop:"ActivePageControlName"},{av:"AV11LoadAllTabs",fld:"vLOADALLTABS",pic:""},{av:"AV7SelectedTabCode",fld:"vSELECTEDTABCODE",pic:""},{av:"AV12ClaseId",fld:"vCLASEID",pic:"ZZZ9",hsh:!0}],[{av:"AV7SelectedTabCode",fld:"vSELECTEDTABCODE",pic:""},{av:"AV11LoadAllTabs",fld:"vLOADALLTABS",pic:""},{ctrl:"GENERALWC"},{ctrl:"SOCIOSWC"}]];this.setVCMap("AV11LoadAllTabs","vLOADALLTABS",0,"boolean",4,0);this.setVCMap("AV7SelectedTabCode","vSELECTEDTABCODE",0,"char",50,0);this.setVCMap("AV12ClaseId","vCLASEID",0,"int",4,0);this.setVCMap("AV6TabCode","vTABCODE",0,"char",50,0);this.setVCMap("AV12ClaseId","vCLASEID",0,"int",4,0);this.setVCMap("AV11LoadAllTabs","vLOADALLTABS",0,"boolean",4,0);this.setVCMap("AV7SelectedTabCode","vSELECTEDTABCODE",0,"char",50,0);this.Initialize();this.setComponent({id:"GENERALWC",GXClass:null,Prefix:"W0030",lvl:1});this.setComponent({id:"SOCIOSWC",GXClass:null,Prefix:"W0038",lvl:1})});gx.createParentObj(viewclase)