/*!   GeneXus C# 15_0_12-126726 on 3/7/2019 22:7:13.14
*/
gx.evt.autoSkip=!1;gx.define("gx0030",!1,function(){var n,t;this.ServerClass="gx0030";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV8pCategoriaCodigo=gx.fn.getIntegerValue("vPCATEGORIACODIGO",",")};this.e13091_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")=="AdvancedContainer"?(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer AdvancedContainerVisible"),gx.fn.setCtrlProperty("BTNTOGGLE","Class",gx.fn.getCtrlProperty("BTNTOGGLE","Class")+" BtnToggleActive")):(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer"),gx.fn.setCtrlProperty("BTNTOGGLE","Class","BtnToggle")),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}]),gx.$.Deferred().resolve()};this.e11091_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("CATEGORIACODIGOFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("CATEGORIACODIGOFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCCATEGORIACODIGO","Visible",!0)):(gx.fn.setCtrlProperty("CATEGORIACODIGOFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCCATEGORIACODIGO","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("CATEGORIACODIGOFILTERCONTAINER","Class")',ctrl:"CATEGORIACODIGOFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCCATEGORIACODIGO","Visible")',ctrl:"vCCATEGORIACODIGO",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e12091_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("CATEGORIANOMBREFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("CATEGORIANOMBREFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCCATEGORIANOMBRE","Visible",!0)):(gx.fn.setCtrlProperty("CATEGORIANOMBREFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCCATEGORIANOMBRE","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("CATEGORIANOMBREFILTERCONTAINER","Class")',ctrl:"CATEGORIANOMBREFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCCATEGORIANOMBRE","Visible")',ctrl:"vCCATEGORIANOMBRE",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e16092_client=function(){return this.executeServerEvent("ENTER",!0,arguments[0],!1,!1)};this.e17091_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,35,36,37,38,39,40];this.GXLastCtrlId=40;this.Grid1Container=new gx.grid.grid(this,2,"WbpLvl2",34,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"gx0030",[],!1,1,!1,!0,10,!0,!1,!1,"",0,"px",0,"px","New row",!0,!1,!1,null,null,!1,"",!1,[1,1,1,1],!1,0,!0,!1);t=this.Grid1Container;t.addBitmap("&Linkselection","vLINKSELECTION",35,0,"px",17,"px",null,"","","SelectionAttribute","WWActionColumn");t.addSingleLineEdit(10,36,"CATEGORIACODIGO","Codigo","","CategoriaCodigo","int",0,"px",4,4,"right",null,[],10,"CategoriaCodigo",!0,0,!1,!1,"Attribute",1,"WWColumn");t.addSingleLineEdit(9,37,"CATEGORIANOMBRE","Nombre","","CategoriaNombre","char",0,"px",20,20,"left",null,[],9,"CategoriaNombre",!0,0,!1,!1,"DescriptionAttribute",1,"WWColumn");this.Grid1Container.emptyText="";this.setGrid(t);n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"MAIN",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"ADVANCEDCONTAINER",grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[9]={id:9,fld:"CATEGORIACODIGOFILTERCONTAINER",grid:0};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"",grid:0};n[12]={id:12,fld:"LBLCATEGORIACODIGOFILTER",format:1,grid:0,evt:"e11091_client"};n[13]={id:13,fld:"",grid:0};n[14]={id:14,fld:"",grid:0};n[15]={id:15,fld:"",grid:0};n[16]={id:16,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCCATEGORIACODIGO",gxz:"ZV6cCategoriaCodigo",gxold:"OV6cCategoriaCodigo",gxvar:"AV6cCategoriaCodigo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV6cCategoriaCodigo=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV6cCategoriaCodigo=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCCATEGORIACODIGO",gx.O.AV6cCategoriaCodigo,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV6cCategoriaCodigo=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCCATEGORIACODIGO",",")},nac:gx.falseFn};n[17]={id:17,fld:"",grid:0};n[18]={id:18,fld:"",grid:0};n[19]={id:19,fld:"CATEGORIANOMBREFILTERCONTAINER",grid:0};n[20]={id:20,fld:"",grid:0};n[21]={id:21,fld:"",grid:0};n[22]={id:22,fld:"LBLCATEGORIANOMBREFILTER",format:1,grid:0,evt:"e12091_client"};n[23]={id:23,fld:"",grid:0};n[24]={id:24,fld:"",grid:0};n[25]={id:25,fld:"",grid:0};n[26]={id:26,lvl:0,type:"char",len:20,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCCATEGORIANOMBRE",gxz:"ZV7cCategoriaNombre",gxold:"OV7cCategoriaNombre",gxvar:"AV7cCategoriaNombre",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV7cCategoriaNombre=n)},v2z:function(n){n!==undefined&&(gx.O.ZV7cCategoriaNombre=n)},v2c:function(){gx.fn.setControlValue("vCCATEGORIANOMBRE",gx.O.AV7cCategoriaNombre,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV7cCategoriaNombre=this.val())},val:function(){return gx.fn.getControlValue("vCCATEGORIANOMBRE")},nac:gx.falseFn};n[27]={id:27,fld:"",grid:0};n[28]={id:28,fld:"GRIDTABLE",grid:0};n[29]={id:29,fld:"",grid:0};n[30]={id:30,fld:"",grid:0};n[31]={id:31,fld:"BTNTOGGLE",grid:0};n[32]={id:32,fld:"",grid:0};n[33]={id:33,fld:"",grid:0};n[35]={id:35,lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:34,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vLINKSELECTION",gxz:"ZV5LinkSelection",gxold:"OV5LinkSelection",gxvar:"AV5LinkSelection",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV5LinkSelection=n)},v2z:function(n){n!==undefined&&(gx.O.ZV5LinkSelection=n)},v2c:function(n){gx.fn.setGridMultimediaValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(34),gx.O.AV5LinkSelection,gx.O.AV12Linkselection_GXI)},c2v:function(){gx.O.AV12Linkselection_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.AV5LinkSelection=this.val())},val:function(n){return gx.fn.getGridControlValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(34))},val_GXI:function(n){return gx.fn.getGridControlValue("vLINKSELECTION_GXI",n||gx.fn.currentGridRowImpl(34))},gxvar_GXI:"AV12Linkselection_GXI",nac:gx.falseFn};n[36]={id:36,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:34,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"CATEGORIACODIGO",gxz:"Z10CategoriaCodigo",gxold:"O10CategoriaCodigo",gxvar:"A10CategoriaCodigo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A10CategoriaCodigo=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z10CategoriaCodigo=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("CATEGORIACODIGO",n||gx.fn.currentGridRowImpl(34),gx.O.A10CategoriaCodigo,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A10CategoriaCodigo=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("CATEGORIACODIGO",n||gx.fn.currentGridRowImpl(34),",")},nac:gx.falseFn};n[37]={id:37,lvl:2,type:"char",len:20,dec:0,sign:!1,ro:1,isacc:0,grid:34,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"CATEGORIANOMBRE",gxz:"Z9CategoriaNombre",gxold:"O9CategoriaNombre",gxvar:"A9CategoriaNombre",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A9CategoriaNombre=n)},v2z:function(n){n!==undefined&&(gx.O.Z9CategoriaNombre=n)},v2c:function(n){gx.fn.setGridControlValue("CATEGORIANOMBRE",n||gx.fn.currentGridRowImpl(34),gx.O.A9CategoriaNombre,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A9CategoriaNombre=this.val())},val:function(n){return gx.fn.getGridControlValue("CATEGORIANOMBRE",n||gx.fn.currentGridRowImpl(34))},nac:gx.falseFn};n[38]={id:38,fld:"",grid:0};n[39]={id:39,fld:"",grid:0};n[40]={id:40,fld:"BTN_CANCEL",grid:0};this.AV6cCategoriaCodigo=0;this.ZV6cCategoriaCodigo=0;this.OV6cCategoriaCodigo=0;this.AV7cCategoriaNombre="";this.ZV7cCategoriaNombre="";this.OV7cCategoriaNombre="";this.ZV5LinkSelection="";this.OV5LinkSelection="";this.Z10CategoriaCodigo=0;this.O10CategoriaCodigo=0;this.Z9CategoriaNombre="";this.O9CategoriaNombre="";this.AV6cCategoriaCodigo=0;this.AV7cCategoriaNombre="";this.AV8pCategoriaCodigo=0;this.AV5LinkSelection="";this.A10CategoriaCodigo=0;this.A9CategoriaNombre="";this.Events={e16092_client:["ENTER",!0],e17091_client:["CANCEL",!0],e13091_client:["'TOGGLE'",!1],e11091_client:["LBLCATEGORIACODIGOFILTER.CLICK",!1],e12091_client:["LBLCATEGORIANOMBREFILTER.CLICK",!1]};this.EvtParms.REFRESH=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cCategoriaCodigo",fld:"vCCATEGORIACODIGO",pic:"ZZZ9"},{av:"AV7cCategoriaNombre",fld:"vCCATEGORIANOMBRE",pic:""}],[]];this.EvtParms.START=[[],[{ctrl:"FORM",prop:"Caption"}]];this.EvtParms["'TOGGLE'"]=[[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}]];this.EvtParms["LBLCATEGORIACODIGOFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("CATEGORIACODIGOFILTERCONTAINER","Class")',ctrl:"CATEGORIACODIGOFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("CATEGORIACODIGOFILTERCONTAINER","Class")',ctrl:"CATEGORIACODIGOFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCCATEGORIACODIGO","Visible")',ctrl:"vCCATEGORIACODIGO",prop:"Visible"}]];this.EvtParms["LBLCATEGORIANOMBREFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("CATEGORIANOMBREFILTERCONTAINER","Class")',ctrl:"CATEGORIANOMBREFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("CATEGORIANOMBREFILTERCONTAINER","Class")',ctrl:"CATEGORIANOMBREFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCCATEGORIANOMBRE","Visible")',ctrl:"vCCATEGORIANOMBRE",prop:"Visible"}]];this.EvtParms.LOAD=[[],[{av:"AV5LinkSelection",fld:"vLINKSELECTION",pic:""}]];this.EvtParms.ENTER=[[{av:"A10CategoriaCodigo",fld:"CATEGORIACODIGO",pic:"ZZZ9",hsh:!0}],[{av:"AV8pCategoriaCodigo",fld:"vPCATEGORIACODIGO",pic:"ZZZ9"}]];this.EvtParms.GRID1_FIRSTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cCategoriaCodigo",fld:"vCCATEGORIACODIGO",pic:"ZZZ9"},{av:"AV7cCategoriaNombre",fld:"vCCATEGORIANOMBRE",pic:""}],[]];this.EvtParms.GRID1_PREVPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cCategoriaCodigo",fld:"vCCATEGORIACODIGO",pic:"ZZZ9"},{av:"AV7cCategoriaNombre",fld:"vCCATEGORIANOMBRE",pic:""}],[]];this.EvtParms.GRID1_NEXTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cCategoriaCodigo",fld:"vCCATEGORIACODIGO",pic:"ZZZ9"},{av:"AV7cCategoriaNombre",fld:"vCCATEGORIANOMBRE",pic:""}],[]];this.EvtParms.GRID1_LASTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cCategoriaCodigo",fld:"vCCATEGORIACODIGO",pic:"ZZZ9"},{av:"AV7cCategoriaNombre",fld:"vCCATEGORIANOMBRE",pic:""}],[]];this.setVCMap("AV8pCategoriaCodigo","vPCATEGORIACODIGO",0,"int",4,0);t.addRefreshingVar(this.GXValidFnc[16]);t.addRefreshingVar(this.GXValidFnc[26]);this.Initialize()});gx.createParentObj(gx0030)