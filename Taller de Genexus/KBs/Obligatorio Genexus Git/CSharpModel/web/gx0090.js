/*!   GeneXus C# 15_0_12-126726 on 4/12/2019 7:30:4.5
*/
gx.evt.autoSkip=!1;gx.define("gx0090",!1,function(){var n,t;this.ServerClass="gx0090";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV9pProfesorId=gx.fn.getIntegerValue("vPPROFESORID",",");this.AV10pActividadId=gx.fn.getIntegerValue("vPACTIVIDADID",",")};this.e14131_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")=="AdvancedContainer"?(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer AdvancedContainerVisible"),gx.fn.setCtrlProperty("BTNTOGGLE","Class",gx.fn.getCtrlProperty("BTNTOGGLE","Class")+" BtnToggleActive")):(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer"),gx.fn.setCtrlProperty("BTNTOGGLE","Class","BtnToggle")),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}]),gx.$.Deferred().resolve()};this.e11131_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("PROFESORIDFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("PROFESORIDFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCPROFESORID","Visible",!0)):(gx.fn.setCtrlProperty("PROFESORIDFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCPROFESORID","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("PROFESORIDFILTERCONTAINER","Class")',ctrl:"PROFESORIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCPROFESORID","Visible")',ctrl:"vCPROFESORID",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e12131_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("ACTIVIDADIDFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("ACTIVIDADIDFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCACTIVIDADID","Visible",!0)):(gx.fn.setCtrlProperty("ACTIVIDADIDFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCACTIVIDADID","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ACTIVIDADIDFILTERCONTAINER","Class")',ctrl:"ACTIVIDADIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCACTIVIDADID","Visible")',ctrl:"vCACTIVIDADID",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e13131_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("PROFESORNOMBREFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("PROFESORNOMBREFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCPROFESORNOMBRE","Visible",!0)):(gx.fn.setCtrlProperty("PROFESORNOMBREFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCPROFESORNOMBRE","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("PROFESORNOMBREFILTERCONTAINER","Class")',ctrl:"PROFESORNOMBREFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCPROFESORNOMBRE","Visible")',ctrl:"vCPROFESORNOMBRE",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e17132_client=function(){return this.executeServerEvent("ENTER",!0,arguments[0],!1,!1)};this.e18131_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,45,46,47,48,49,50,51,52];this.GXLastCtrlId=52;this.Grid1Container=new gx.grid.grid(this,2,"WbpLvl2",44,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"gx0090",[],!1,1,!1,!0,10,!0,!1,!1,"",0,"px",0,"px","New row",!0,!1,!1,null,null,!1,"",!1,[1,1,1,1],!1,0,!0,!1);t=this.Grid1Container;t.addBitmap("&Linkselection","vLINKSELECTION",45,0,"px",17,"px",null,"","","SelectionAttribute","WWActionColumn");t.addSingleLineEdit(2,46,"PROFESORID","Id","","ProfesorId","int",0,"px",4,4,"right",null,[],2,"ProfesorId",!0,0,!1,!1,"Attribute",1,"WWColumn");t.addSingleLineEdit(1,47,"ACTIVIDADID","Actividad Id","","ActividadId","int",0,"px",4,4,"right",null,[],1,"ActividadId",!0,0,!1,!1,"Attribute",1,"WWColumn OptionalColumn");t.addSingleLineEdit(15,48,"PROFESORNOMBRE","Nombre","","ProfesorNombre","char",0,"px",20,20,"left",null,[],15,"ProfesorNombre",!0,0,!1,!1,"DescriptionAttribute",1,"WWColumn");t.addBitmap(17,"PROFESORFOTO",49,0,"px",17,"px",null,"","Foto","ImageAttribute","WWColumn OptionalColumn");this.Grid1Container.emptyText="";this.setGrid(t);n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"MAIN",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"ADVANCEDCONTAINER",grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[9]={id:9,fld:"PROFESORIDFILTERCONTAINER",grid:0};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"",grid:0};n[12]={id:12,fld:"LBLPROFESORIDFILTER",format:1,grid:0,evt:"e11131_client"};n[13]={id:13,fld:"",grid:0};n[14]={id:14,fld:"",grid:0};n[15]={id:15,fld:"",grid:0};n[16]={id:16,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCPROFESORID",gxz:"ZV6cProfesorId",gxold:"OV6cProfesorId",gxvar:"AV6cProfesorId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV6cProfesorId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV6cProfesorId=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCPROFESORID",gx.O.AV6cProfesorId,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV6cProfesorId=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCPROFESORID",",")},nac:gx.falseFn};n[17]={id:17,fld:"",grid:0};n[18]={id:18,fld:"",grid:0};n[19]={id:19,fld:"ACTIVIDADIDFILTERCONTAINER",grid:0};n[20]={id:20,fld:"",grid:0};n[21]={id:21,fld:"",grid:0};n[22]={id:22,fld:"LBLACTIVIDADIDFILTER",format:1,grid:0,evt:"e12131_client"};n[23]={id:23,fld:"",grid:0};n[24]={id:24,fld:"",grid:0};n[25]={id:25,fld:"",grid:0};n[26]={id:26,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCACTIVIDADID",gxz:"ZV7cActividadId",gxold:"OV7cActividadId",gxvar:"AV7cActividadId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV7cActividadId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV7cActividadId=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCACTIVIDADID",gx.O.AV7cActividadId,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV7cActividadId=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCACTIVIDADID",",")},nac:gx.falseFn};n[27]={id:27,fld:"",grid:0};n[28]={id:28,fld:"",grid:0};n[29]={id:29,fld:"PROFESORNOMBREFILTERCONTAINER",grid:0};n[30]={id:30,fld:"",grid:0};n[31]={id:31,fld:"",grid:0};n[32]={id:32,fld:"LBLPROFESORNOMBREFILTER",format:1,grid:0,evt:"e13131_client"};n[33]={id:33,fld:"",grid:0};n[34]={id:34,fld:"",grid:0};n[35]={id:35,fld:"",grid:0};n[36]={id:36,lvl:0,type:"char",len:20,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCPROFESORNOMBRE",gxz:"ZV8cProfesorNombre",gxold:"OV8cProfesorNombre",gxvar:"AV8cProfesorNombre",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV8cProfesorNombre=n)},v2z:function(n){n!==undefined&&(gx.O.ZV8cProfesorNombre=n)},v2c:function(){gx.fn.setControlValue("vCPROFESORNOMBRE",gx.O.AV8cProfesorNombre,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV8cProfesorNombre=this.val())},val:function(){return gx.fn.getControlValue("vCPROFESORNOMBRE")},nac:gx.falseFn};n[37]={id:37,fld:"",grid:0};n[38]={id:38,fld:"GRIDTABLE",grid:0};n[39]={id:39,fld:"",grid:0};n[40]={id:40,fld:"",grid:0};n[41]={id:41,fld:"BTNTOGGLE",grid:0};n[42]={id:42,fld:"",grid:0};n[43]={id:43,fld:"",grid:0};n[45]={id:45,lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:44,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vLINKSELECTION",gxz:"ZV5LinkSelection",gxold:"OV5LinkSelection",gxvar:"AV5LinkSelection",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV5LinkSelection=n)},v2z:function(n){n!==undefined&&(gx.O.ZV5LinkSelection=n)},v2c:function(n){gx.fn.setGridMultimediaValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(44),gx.O.AV5LinkSelection,gx.O.AV14Linkselection_GXI)},c2v:function(){gx.O.AV14Linkselection_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.AV5LinkSelection=this.val())},val:function(n){return gx.fn.getGridControlValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(44))},val_GXI:function(n){return gx.fn.getGridControlValue("vLINKSELECTION_GXI",n||gx.fn.currentGridRowImpl(44))},gxvar_GXI:"AV14Linkselection_GXI",nac:gx.falseFn};n[46]={id:46,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:44,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"PROFESORID",gxz:"Z2ProfesorId",gxold:"O2ProfesorId",gxvar:"A2ProfesorId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A2ProfesorId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z2ProfesorId=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("PROFESORID",n||gx.fn.currentGridRowImpl(44),gx.O.A2ProfesorId,0)},c2v:function(){this.val()!==undefined&&(gx.O.A2ProfesorId=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("PROFESORID",n||gx.fn.currentGridRowImpl(44),",")},nac:gx.falseFn};n[47]={id:47,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:44,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"ACTIVIDADID",gxz:"Z1ActividadId",gxold:"O1ActividadId",gxvar:"A1ActividadId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A1ActividadId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z1ActividadId=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("ACTIVIDADID",n||gx.fn.currentGridRowImpl(44),gx.O.A1ActividadId,0)},c2v:function(){this.val()!==undefined&&(gx.O.A1ActividadId=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("ACTIVIDADID",n||gx.fn.currentGridRowImpl(44),",")},nac:gx.falseFn};n[48]={id:48,lvl:2,type:"char",len:20,dec:0,sign:!1,ro:1,isacc:0,grid:44,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"PROFESORNOMBRE",gxz:"Z15ProfesorNombre",gxold:"O15ProfesorNombre",gxvar:"A15ProfesorNombre",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A15ProfesorNombre=n)},v2z:function(n){n!==undefined&&(gx.O.Z15ProfesorNombre=n)},v2c:function(n){gx.fn.setGridControlValue("PROFESORNOMBRE",n||gx.fn.currentGridRowImpl(44),gx.O.A15ProfesorNombre,0)},c2v:function(){this.val()!==undefined&&(gx.O.A15ProfesorNombre=this.val())},val:function(n){return gx.fn.getGridControlValue("PROFESORNOMBRE",n||gx.fn.currentGridRowImpl(44))},nac:gx.falseFn};n[49]={id:49,lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:44,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"PROFESORFOTO",gxz:"Z17ProfesorFoto",gxold:"O17ProfesorFoto",gxvar:"A17ProfesorFoto",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A17ProfesorFoto=n)},v2z:function(n){n!==undefined&&(gx.O.Z17ProfesorFoto=n)},v2c:function(n){gx.fn.setGridMultimediaValue("PROFESORFOTO",n||gx.fn.currentGridRowImpl(44),gx.O.A17ProfesorFoto,gx.O.A40000ProfesorFoto_GXI)},c2v:function(){gx.O.A40000ProfesorFoto_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.A17ProfesorFoto=this.val())},val:function(n){return gx.fn.getGridControlValue("PROFESORFOTO",n||gx.fn.currentGridRowImpl(44))},val_GXI:function(n){return gx.fn.getGridControlValue("PROFESORFOTO_GXI",n||gx.fn.currentGridRowImpl(44))},gxvar_GXI:"A40000ProfesorFoto_GXI",nac:gx.falseFn};n[50]={id:50,fld:"",grid:0};n[51]={id:51,fld:"",grid:0};n[52]={id:52,fld:"BTN_CANCEL",grid:0};this.AV6cProfesorId=0;this.ZV6cProfesorId=0;this.OV6cProfesorId=0;this.AV7cActividadId=0;this.ZV7cActividadId=0;this.OV7cActividadId=0;this.AV8cProfesorNombre="";this.ZV8cProfesorNombre="";this.OV8cProfesorNombre="";this.ZV5LinkSelection="";this.OV5LinkSelection="";this.Z2ProfesorId=0;this.O2ProfesorId=0;this.Z1ActividadId=0;this.O1ActividadId=0;this.Z15ProfesorNombre="";this.O15ProfesorNombre="";this.Z17ProfesorFoto="";this.O17ProfesorFoto="";this.AV6cProfesorId=0;this.AV7cActividadId=0;this.AV8cProfesorNombre="";this.A40000ProfesorFoto_GXI="";this.AV9pProfesorId=0;this.AV10pActividadId=0;this.AV5LinkSelection="";this.A2ProfesorId=0;this.A1ActividadId=0;this.A15ProfesorNombre="";this.A17ProfesorFoto="";this.Events={e17132_client:["ENTER",!0],e18131_client:["CANCEL",!0],e14131_client:["'TOGGLE'",!1],e11131_client:["LBLPROFESORIDFILTER.CLICK",!1],e12131_client:["LBLACTIVIDADIDFILTER.CLICK",!1],e13131_client:["LBLPROFESORNOMBREFILTER.CLICK",!1]};this.EvtParms.REFRESH=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cProfesorId",fld:"vCPROFESORID",pic:"ZZZ9"},{av:"AV7cActividadId",fld:"vCACTIVIDADID",pic:"ZZZ9"},{av:"AV8cProfesorNombre",fld:"vCPROFESORNOMBRE",pic:""}],[]];this.EvtParms.START=[[],[{ctrl:"FORM",prop:"Caption"}]];this.EvtParms["'TOGGLE'"]=[[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}]];this.EvtParms["LBLPROFESORIDFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("PROFESORIDFILTERCONTAINER","Class")',ctrl:"PROFESORIDFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("PROFESORIDFILTERCONTAINER","Class")',ctrl:"PROFESORIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCPROFESORID","Visible")',ctrl:"vCPROFESORID",prop:"Visible"}]];this.EvtParms["LBLACTIVIDADIDFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("ACTIVIDADIDFILTERCONTAINER","Class")',ctrl:"ACTIVIDADIDFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ACTIVIDADIDFILTERCONTAINER","Class")',ctrl:"ACTIVIDADIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCACTIVIDADID","Visible")',ctrl:"vCACTIVIDADID",prop:"Visible"}]];this.EvtParms["LBLPROFESORNOMBREFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("PROFESORNOMBREFILTERCONTAINER","Class")',ctrl:"PROFESORNOMBREFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("PROFESORNOMBREFILTERCONTAINER","Class")',ctrl:"PROFESORNOMBREFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCPROFESORNOMBRE","Visible")',ctrl:"vCPROFESORNOMBRE",prop:"Visible"}]];this.EvtParms.LOAD=[[],[{av:"AV5LinkSelection",fld:"vLINKSELECTION",pic:""}]];this.EvtParms.ENTER=[[{av:"A2ProfesorId",fld:"PROFESORID",pic:"ZZZ9",hsh:!0},{av:"A1ActividadId",fld:"ACTIVIDADID",pic:"ZZZ9",hsh:!0}],[{av:"AV9pProfesorId",fld:"vPPROFESORID",pic:"ZZZ9"},{av:"AV10pActividadId",fld:"vPACTIVIDADID",pic:"ZZZ9"}]];this.EvtParms.GRID1_FIRSTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cProfesorId",fld:"vCPROFESORID",pic:"ZZZ9"},{av:"AV7cActividadId",fld:"vCACTIVIDADID",pic:"ZZZ9"},{av:"AV8cProfesorNombre",fld:"vCPROFESORNOMBRE",pic:""}],[]];this.EvtParms.GRID1_PREVPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cProfesorId",fld:"vCPROFESORID",pic:"ZZZ9"},{av:"AV7cActividadId",fld:"vCACTIVIDADID",pic:"ZZZ9"},{av:"AV8cProfesorNombre",fld:"vCPROFESORNOMBRE",pic:""}],[]];this.EvtParms.GRID1_NEXTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cProfesorId",fld:"vCPROFESORID",pic:"ZZZ9"},{av:"AV7cActividadId",fld:"vCACTIVIDADID",pic:"ZZZ9"},{av:"AV8cProfesorNombre",fld:"vCPROFESORNOMBRE",pic:""}],[]];this.EvtParms.GRID1_LASTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cProfesorId",fld:"vCPROFESORID",pic:"ZZZ9"},{av:"AV7cActividadId",fld:"vCACTIVIDADID",pic:"ZZZ9"},{av:"AV8cProfesorNombre",fld:"vCPROFESORNOMBRE",pic:""}],[]];this.setVCMap("AV9pProfesorId","vPPROFESORID",0,"int",4,0);this.setVCMap("AV10pActividadId","vPACTIVIDADID",0,"int",4,0);t.addRefreshingVar(this.GXValidFnc[16]);t.addRefreshingVar(this.GXValidFnc[26]);t.addRefreshingVar(this.GXValidFnc[36]);this.Initialize()});gx.createParentObj(gx0090)