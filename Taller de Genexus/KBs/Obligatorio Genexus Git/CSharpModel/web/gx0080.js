/*!   GeneXus C# 15_0_12-126726 on 4/12/2019 7:30:5.9
*/
gx.evt.autoSkip=!1;gx.define("gx0080",!1,function(){var n,t;this.ServerClass="gx0080";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV9pClaseId=gx.fn.getIntegerValue("vPCLASEID",",");this.AV10pActividadId=gx.fn.getIntegerValue("vPACTIVIDADID",",");this.AV11pProfesorId=gx.fn.getIntegerValue("vPPROFESORID",",")};this.e14121_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")=="AdvancedContainer"?(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer AdvancedContainerVisible"),gx.fn.setCtrlProperty("BTNTOGGLE","Class",gx.fn.getCtrlProperty("BTNTOGGLE","Class")+" BtnToggleActive")):(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer"),gx.fn.setCtrlProperty("BTNTOGGLE","Class","BtnToggle")),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}]),gx.$.Deferred().resolve()};this.e11121_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("CLASEIDFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("CLASEIDFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCCLASEID","Visible",!0)):(gx.fn.setCtrlProperty("CLASEIDFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCCLASEID","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("CLASEIDFILTERCONTAINER","Class")',ctrl:"CLASEIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCCLASEID","Visible")',ctrl:"vCCLASEID",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e12121_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("ACTIVIDADIDFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("ACTIVIDADIDFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCACTIVIDADID","Visible",!0)):(gx.fn.setCtrlProperty("ACTIVIDADIDFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCACTIVIDADID","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ACTIVIDADIDFILTERCONTAINER","Class")',ctrl:"ACTIVIDADIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCACTIVIDADID","Visible")',ctrl:"vCACTIVIDADID",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e13121_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("PROFESORIDFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("PROFESORIDFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCPROFESORID","Visible",!0)):(gx.fn.setCtrlProperty("PROFESORIDFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCPROFESORID","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("PROFESORIDFILTERCONTAINER","Class")',ctrl:"PROFESORIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCPROFESORID","Visible")',ctrl:"vCPROFESORID",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e17122_client=function(){return this.executeServerEvent("ENTER",!0,arguments[0],!1,!1)};this.e18121_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,45,46,47,48,49,50,51];this.GXLastCtrlId=51;this.Grid1Container=new gx.grid.grid(this,2,"WbpLvl2",44,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"gx0080",[],!1,1,!1,!0,10,!0,!1,!1,"",0,"px",0,"px","New row",!0,!1,!1,null,null,!1,"",!1,[1,1,1,1],!1,0,!0,!1);t=this.Grid1Container;t.addBitmap("&Linkselection","vLINKSELECTION",45,0,"px",17,"px",null,"","","SelectionAttribute","WWActionColumn");t.addSingleLineEdit(3,46,"CLASEID","Id","","ClaseId","int",0,"px",4,4,"right",null,[],3,"ClaseId",!0,0,!1,!1,"DescriptionAttribute",1,"WWColumn");t.addSingleLineEdit(1,47,"ACTIVIDADID","Actividad Id","","ActividadId","int",0,"px",4,4,"right",null,[],1,"ActividadId",!0,0,!1,!1,"Attribute",1,"WWColumn OptionalColumn");t.addSingleLineEdit(2,48,"PROFESORID","Profesor Id","","ProfesorId","int",0,"px",4,4,"right",null,[],2,"ProfesorId",!0,0,!1,!1,"Attribute",1,"WWColumn OptionalColumn");this.Grid1Container.emptyText="";this.setGrid(t);n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"MAIN",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"ADVANCEDCONTAINER",grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[9]={id:9,fld:"CLASEIDFILTERCONTAINER",grid:0};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"",grid:0};n[12]={id:12,fld:"LBLCLASEIDFILTER",format:1,grid:0,evt:"e11121_client"};n[13]={id:13,fld:"",grid:0};n[14]={id:14,fld:"",grid:0};n[15]={id:15,fld:"",grid:0};n[16]={id:16,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCCLASEID",gxz:"ZV6cClaseId",gxold:"OV6cClaseId",gxvar:"AV6cClaseId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV6cClaseId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV6cClaseId=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCCLASEID",gx.O.AV6cClaseId,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV6cClaseId=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCCLASEID",",")},nac:gx.falseFn};n[17]={id:17,fld:"",grid:0};n[18]={id:18,fld:"",grid:0};n[19]={id:19,fld:"ACTIVIDADIDFILTERCONTAINER",grid:0};n[20]={id:20,fld:"",grid:0};n[21]={id:21,fld:"",grid:0};n[22]={id:22,fld:"LBLACTIVIDADIDFILTER",format:1,grid:0,evt:"e12121_client"};n[23]={id:23,fld:"",grid:0};n[24]={id:24,fld:"",grid:0};n[25]={id:25,fld:"",grid:0};n[26]={id:26,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCACTIVIDADID",gxz:"ZV7cActividadId",gxold:"OV7cActividadId",gxvar:"AV7cActividadId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV7cActividadId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV7cActividadId=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCACTIVIDADID",gx.O.AV7cActividadId,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV7cActividadId=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCACTIVIDADID",",")},nac:gx.falseFn};n[27]={id:27,fld:"",grid:0};n[28]={id:28,fld:"",grid:0};n[29]={id:29,fld:"PROFESORIDFILTERCONTAINER",grid:0};n[30]={id:30,fld:"",grid:0};n[31]={id:31,fld:"",grid:0};n[32]={id:32,fld:"LBLPROFESORIDFILTER",format:1,grid:0,evt:"e13121_client"};n[33]={id:33,fld:"",grid:0};n[34]={id:34,fld:"",grid:0};n[35]={id:35,fld:"",grid:0};n[36]={id:36,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCPROFESORID",gxz:"ZV8cProfesorId",gxold:"OV8cProfesorId",gxvar:"AV8cProfesorId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV8cProfesorId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV8cProfesorId=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCPROFESORID",gx.O.AV8cProfesorId,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV8cProfesorId=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCPROFESORID",",")},nac:gx.falseFn};n[37]={id:37,fld:"",grid:0};n[38]={id:38,fld:"GRIDTABLE",grid:0};n[39]={id:39,fld:"",grid:0};n[40]={id:40,fld:"",grid:0};n[41]={id:41,fld:"BTNTOGGLE",grid:0};n[42]={id:42,fld:"",grid:0};n[43]={id:43,fld:"",grid:0};n[45]={id:45,lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:44,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vLINKSELECTION",gxz:"ZV5LinkSelection",gxold:"OV5LinkSelection",gxvar:"AV5LinkSelection",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV5LinkSelection=n)},v2z:function(n){n!==undefined&&(gx.O.ZV5LinkSelection=n)},v2c:function(n){gx.fn.setGridMultimediaValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(44),gx.O.AV5LinkSelection,gx.O.AV15Linkselection_GXI)},c2v:function(){gx.O.AV15Linkselection_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.AV5LinkSelection=this.val())},val:function(n){return gx.fn.getGridControlValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(44))},val_GXI:function(n){return gx.fn.getGridControlValue("vLINKSELECTION_GXI",n||gx.fn.currentGridRowImpl(44))},gxvar_GXI:"AV15Linkselection_GXI",nac:gx.falseFn};n[46]={id:46,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:44,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"CLASEID",gxz:"Z3ClaseId",gxold:"O3ClaseId",gxvar:"A3ClaseId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A3ClaseId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z3ClaseId=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("CLASEID",n||gx.fn.currentGridRowImpl(44),gx.O.A3ClaseId,0)},c2v:function(){this.val()!==undefined&&(gx.O.A3ClaseId=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("CLASEID",n||gx.fn.currentGridRowImpl(44),",")},nac:gx.falseFn};n[47]={id:47,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:44,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"ACTIVIDADID",gxz:"Z1ActividadId",gxold:"O1ActividadId",gxvar:"A1ActividadId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A1ActividadId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z1ActividadId=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("ACTIVIDADID",n||gx.fn.currentGridRowImpl(44),gx.O.A1ActividadId,0)},c2v:function(){this.val()!==undefined&&(gx.O.A1ActividadId=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("ACTIVIDADID",n||gx.fn.currentGridRowImpl(44),",")},nac:gx.falseFn};n[48]={id:48,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:44,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"PROFESORID",gxz:"Z2ProfesorId",gxold:"O2ProfesorId",gxvar:"A2ProfesorId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A2ProfesorId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z2ProfesorId=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("PROFESORID",n||gx.fn.currentGridRowImpl(44),gx.O.A2ProfesorId,0)},c2v:function(){this.val()!==undefined&&(gx.O.A2ProfesorId=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("PROFESORID",n||gx.fn.currentGridRowImpl(44),",")},nac:gx.falseFn};n[49]={id:49,fld:"",grid:0};n[50]={id:50,fld:"",grid:0};n[51]={id:51,fld:"BTN_CANCEL",grid:0};this.AV6cClaseId=0;this.ZV6cClaseId=0;this.OV6cClaseId=0;this.AV7cActividadId=0;this.ZV7cActividadId=0;this.OV7cActividadId=0;this.AV8cProfesorId=0;this.ZV8cProfesorId=0;this.OV8cProfesorId=0;this.ZV5LinkSelection="";this.OV5LinkSelection="";this.Z3ClaseId=0;this.O3ClaseId=0;this.Z1ActividadId=0;this.O1ActividadId=0;this.Z2ProfesorId=0;this.O2ProfesorId=0;this.AV6cClaseId=0;this.AV7cActividadId=0;this.AV8cProfesorId=0;this.AV9pClaseId=0;this.AV10pActividadId=0;this.AV11pProfesorId=0;this.AV5LinkSelection="";this.A3ClaseId=0;this.A1ActividadId=0;this.A2ProfesorId=0;this.Events={e17122_client:["ENTER",!0],e18121_client:["CANCEL",!0],e14121_client:["'TOGGLE'",!1],e11121_client:["LBLCLASEIDFILTER.CLICK",!1],e12121_client:["LBLACTIVIDADIDFILTER.CLICK",!1],e13121_client:["LBLPROFESORIDFILTER.CLICK",!1]};this.EvtParms.REFRESH=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cClaseId",fld:"vCCLASEID",pic:"ZZZ9"},{av:"AV7cActividadId",fld:"vCACTIVIDADID",pic:"ZZZ9"},{av:"AV8cProfesorId",fld:"vCPROFESORID",pic:"ZZZ9"}],[]];this.EvtParms.START=[[],[{ctrl:"FORM",prop:"Caption"}]];this.EvtParms["'TOGGLE'"]=[[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}]];this.EvtParms["LBLCLASEIDFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("CLASEIDFILTERCONTAINER","Class")',ctrl:"CLASEIDFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("CLASEIDFILTERCONTAINER","Class")',ctrl:"CLASEIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCCLASEID","Visible")',ctrl:"vCCLASEID",prop:"Visible"}]];this.EvtParms["LBLACTIVIDADIDFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("ACTIVIDADIDFILTERCONTAINER","Class")',ctrl:"ACTIVIDADIDFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ACTIVIDADIDFILTERCONTAINER","Class")',ctrl:"ACTIVIDADIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCACTIVIDADID","Visible")',ctrl:"vCACTIVIDADID",prop:"Visible"}]];this.EvtParms["LBLPROFESORIDFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("PROFESORIDFILTERCONTAINER","Class")',ctrl:"PROFESORIDFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("PROFESORIDFILTERCONTAINER","Class")',ctrl:"PROFESORIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCPROFESORID","Visible")',ctrl:"vCPROFESORID",prop:"Visible"}]];this.EvtParms.LOAD=[[],[{av:"AV5LinkSelection",fld:"vLINKSELECTION",pic:""}]];this.EvtParms.ENTER=[[{av:"A3ClaseId",fld:"CLASEID",pic:"ZZZ9",hsh:!0},{av:"A1ActividadId",fld:"ACTIVIDADID",pic:"ZZZ9",hsh:!0},{av:"A2ProfesorId",fld:"PROFESORID",pic:"ZZZ9",hsh:!0}],[{av:"AV9pClaseId",fld:"vPCLASEID",pic:"ZZZ9"},{av:"AV10pActividadId",fld:"vPACTIVIDADID",pic:"ZZZ9"},{av:"AV11pProfesorId",fld:"vPPROFESORID",pic:"ZZZ9"}]];this.EvtParms.GRID1_FIRSTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cClaseId",fld:"vCCLASEID",pic:"ZZZ9"},{av:"AV7cActividadId",fld:"vCACTIVIDADID",pic:"ZZZ9"},{av:"AV8cProfesorId",fld:"vCPROFESORID",pic:"ZZZ9"}],[]];this.EvtParms.GRID1_PREVPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cClaseId",fld:"vCCLASEID",pic:"ZZZ9"},{av:"AV7cActividadId",fld:"vCACTIVIDADID",pic:"ZZZ9"},{av:"AV8cProfesorId",fld:"vCPROFESORID",pic:"ZZZ9"}],[]];this.EvtParms.GRID1_NEXTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cClaseId",fld:"vCCLASEID",pic:"ZZZ9"},{av:"AV7cActividadId",fld:"vCACTIVIDADID",pic:"ZZZ9"},{av:"AV8cProfesorId",fld:"vCPROFESORID",pic:"ZZZ9"}],[]];this.EvtParms.GRID1_LASTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cClaseId",fld:"vCCLASEID",pic:"ZZZ9"},{av:"AV7cActividadId",fld:"vCACTIVIDADID",pic:"ZZZ9"},{av:"AV8cProfesorId",fld:"vCPROFESORID",pic:"ZZZ9"}],[]];this.setVCMap("AV9pClaseId","vPCLASEID",0,"int",4,0);this.setVCMap("AV10pActividadId","vPACTIVIDADID",0,"int",4,0);this.setVCMap("AV11pProfesorId","vPPROFESORID",0,"int",4,0);t.addRefreshingVar(this.GXValidFnc[16]);t.addRefreshingVar(this.GXValidFnc[26]);t.addRefreshingVar(this.GXValidFnc[36]);this.Initialize()});gx.createParentObj(gx0080)