/*!   GeneXus C# 15_0_12-126726 on 3/8/2019 20:44:49.77
*/
gx.evt.autoSkip=!1;gx.define("gx0061",!1,function(){var n,t;this.ServerClass="gx0061";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV8pClienteCi=gx.fn.getIntegerValue("vPCLIENTECI",",");this.AV9pClienteTelefonoId=gx.fn.getIntegerValue("vPCLIENTETELEFONOID",",");this.AV8pClienteCi=gx.fn.getIntegerValue("vPCLIENTECI",",")};this.e130c1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")=="AdvancedContainer"?(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer AdvancedContainerVisible"),gx.fn.setCtrlProperty("BTNTOGGLE","Class",gx.fn.getCtrlProperty("BTNTOGGLE","Class")+" BtnToggleActive")):(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer"),gx.fn.setCtrlProperty("BTNTOGGLE","Class","BtnToggle")),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}]),gx.$.Deferred().resolve()};this.e110c1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("CLIENTETELEFONOIDFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("CLIENTETELEFONOIDFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCCLIENTETELEFONOID","Visible",!0)):(gx.fn.setCtrlProperty("CLIENTETELEFONOIDFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCCLIENTETELEFONOID","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("CLIENTETELEFONOIDFILTERCONTAINER","Class")',ctrl:"CLIENTETELEFONOIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCCLIENTETELEFONOID","Visible")',ctrl:"vCCLIENTETELEFONOID",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e120c1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("CLIENTETELEFONONUMEROFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("CLIENTETELEFONONUMEROFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCCLIENTETELEFONONUMERO","Visible",!0)):(gx.fn.setCtrlProperty("CLIENTETELEFONONUMEROFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCCLIENTETELEFONONUMERO","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("CLIENTETELEFONONUMEROFILTERCONTAINER","Class")',ctrl:"CLIENTETELEFONONUMEROFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCCLIENTETELEFONONUMERO","Visible")',ctrl:"vCCLIENTETELEFONONUMERO",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e160c2_client=function(){return this.executeServerEvent("ENTER",!0,arguments[0],!1,!1)};this.e170c1_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,35,36,37,38,39,40,41];this.GXLastCtrlId=41;this.Grid1Container=new gx.grid.grid(this,2,"WbpLvl2",34,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"gx0061",[],!1,1,!1,!0,10,!0,!1,!1,"",0,"px",0,"px","New row",!0,!1,!1,null,null,!1,"",!1,[1,1,1,1],!1,0,!0,!1);t=this.Grid1Container;t.addBitmap("&Linkselection","vLINKSELECTION",35,0,"px",17,"px",null,"","","SelectionAttribute","WWActionColumn");t.addSingleLineEdit(17,36,"CLIENTETELEFONOID","Telefono Id","","ClienteTelefonoId","int",0,"px",4,4,"right",null,[],17,"ClienteTelefonoId",!0,0,!1,!1,"Attribute",1,"WWColumn");t.addSingleLineEdit(13,37,"CLIENTETELEFONONUMERO","Telefono Numero","","ClienteTelefonoNumero","char",0,"px",20,20,"left",null,[],13,"ClienteTelefonoNumero",!0,0,!1,!1,"DescriptionAttribute",1,"WWColumn");t.addSingleLineEdit(1,38,"CLIENTECI","Cliente Ci","","ClienteCi","int",0,"px",8,8,"right",null,[],1,"ClienteCi",!1,0,!1,!1,"Attribute",1,"");this.Grid1Container.emptyText="";this.setGrid(t);n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"MAIN",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"ADVANCEDCONTAINER",grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[9]={id:9,fld:"CLIENTETELEFONOIDFILTERCONTAINER",grid:0};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"",grid:0};n[12]={id:12,fld:"LBLCLIENTETELEFONOIDFILTER",format:1,grid:0,evt:"e110c1_client"};n[13]={id:13,fld:"",grid:0};n[14]={id:14,fld:"",grid:0};n[15]={id:15,fld:"",grid:0};n[16]={id:16,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCCLIENTETELEFONOID",gxz:"ZV6cClienteTelefonoId",gxold:"OV6cClienteTelefonoId",gxvar:"AV6cClienteTelefonoId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV6cClienteTelefonoId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV6cClienteTelefonoId=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCCLIENTETELEFONOID",gx.O.AV6cClienteTelefonoId,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV6cClienteTelefonoId=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCCLIENTETELEFONOID",",")},nac:gx.falseFn};n[17]={id:17,fld:"",grid:0};n[18]={id:18,fld:"",grid:0};n[19]={id:19,fld:"CLIENTETELEFONONUMEROFILTERCONTAINER",grid:0};n[20]={id:20,fld:"",grid:0};n[21]={id:21,fld:"",grid:0};n[22]={id:22,fld:"LBLCLIENTETELEFONONUMEROFILTER",format:1,grid:0,evt:"e120c1_client"};n[23]={id:23,fld:"",grid:0};n[24]={id:24,fld:"",grid:0};n[25]={id:25,fld:"",grid:0};n[26]={id:26,lvl:0,type:"char",len:20,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCCLIENTETELEFONONUMERO",gxz:"ZV7cClienteTelefonoNumero",gxold:"OV7cClienteTelefonoNumero",gxvar:"AV7cClienteTelefonoNumero",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV7cClienteTelefonoNumero=n)},v2z:function(n){n!==undefined&&(gx.O.ZV7cClienteTelefonoNumero=n)},v2c:function(){gx.fn.setControlValue("vCCLIENTETELEFONONUMERO",gx.O.AV7cClienteTelefonoNumero,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV7cClienteTelefonoNumero=this.val())},val:function(){return gx.fn.getControlValue("vCCLIENTETELEFONONUMERO")},nac:gx.falseFn};n[27]={id:27,fld:"",grid:0};n[28]={id:28,fld:"GRIDTABLE",grid:0};n[29]={id:29,fld:"",grid:0};n[30]={id:30,fld:"",grid:0};n[31]={id:31,fld:"BTNTOGGLE",grid:0};n[32]={id:32,fld:"",grid:0};n[33]={id:33,fld:"",grid:0};n[35]={id:35,lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:34,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vLINKSELECTION",gxz:"ZV5LinkSelection",gxold:"OV5LinkSelection",gxvar:"AV5LinkSelection",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV5LinkSelection=n)},v2z:function(n){n!==undefined&&(gx.O.ZV5LinkSelection=n)},v2c:function(n){gx.fn.setGridMultimediaValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(34),gx.O.AV5LinkSelection,gx.O.AV13Linkselection_GXI)},c2v:function(){gx.O.AV13Linkselection_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.AV5LinkSelection=this.val())},val:function(n){return gx.fn.getGridControlValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(34))},val_GXI:function(n){return gx.fn.getGridControlValue("vLINKSELECTION_GXI",n||gx.fn.currentGridRowImpl(34))},gxvar_GXI:"AV13Linkselection_GXI",nac:gx.falseFn};n[36]={id:36,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:34,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"CLIENTETELEFONOID",gxz:"Z17ClienteTelefonoId",gxold:"O17ClienteTelefonoId",gxvar:"A17ClienteTelefonoId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A17ClienteTelefonoId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z17ClienteTelefonoId=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("CLIENTETELEFONOID",n||gx.fn.currentGridRowImpl(34),gx.O.A17ClienteTelefonoId,0)},c2v:function(){this.val()!==undefined&&(gx.O.A17ClienteTelefonoId=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("CLIENTETELEFONOID",n||gx.fn.currentGridRowImpl(34),",")},nac:gx.falseFn};n[37]={id:37,lvl:2,type:"char",len:20,dec:0,sign:!1,ro:1,isacc:0,grid:34,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"CLIENTETELEFONONUMERO",gxz:"Z13ClienteTelefonoNumero",gxold:"O13ClienteTelefonoNumero",gxvar:"A13ClienteTelefonoNumero",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"tel",v2v:function(n){n!==undefined&&(gx.O.A13ClienteTelefonoNumero=n)},v2z:function(n){n!==undefined&&(gx.O.Z13ClienteTelefonoNumero=n)},v2c:function(n){gx.fn.setGridControlValue("CLIENTETELEFONONUMERO",n||gx.fn.currentGridRowImpl(34),gx.O.A13ClienteTelefonoNumero,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A13ClienteTelefonoNumero=this.val())},val:function(n){return gx.fn.getGridControlValue("CLIENTETELEFONONUMERO",n||gx.fn.currentGridRowImpl(34))},nac:gx.falseFn};n[38]={id:38,lvl:2,type:"int",len:8,dec:0,sign:!1,pic:"ZZZZZZZ9",ro:1,isacc:0,grid:34,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"CLIENTECI",gxz:"Z1ClienteCi",gxold:"O1ClienteCi",gxvar:"A1ClienteCi",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A1ClienteCi=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z1ClienteCi=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("CLIENTECI",n||gx.fn.currentGridRowImpl(34),gx.O.A1ClienteCi,0)},c2v:function(){this.val()!==undefined&&(gx.O.A1ClienteCi=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("CLIENTECI",n||gx.fn.currentGridRowImpl(34),",")},nac:gx.falseFn};n[39]={id:39,fld:"",grid:0};n[40]={id:40,fld:"",grid:0};n[41]={id:41,fld:"BTN_CANCEL",grid:0};this.AV6cClienteTelefonoId=0;this.ZV6cClienteTelefonoId=0;this.OV6cClienteTelefonoId=0;this.AV7cClienteTelefonoNumero="";this.ZV7cClienteTelefonoNumero="";this.OV7cClienteTelefonoNumero="";this.ZV5LinkSelection="";this.OV5LinkSelection="";this.Z17ClienteTelefonoId=0;this.O17ClienteTelefonoId=0;this.Z13ClienteTelefonoNumero="";this.O13ClienteTelefonoNumero="";this.Z1ClienteCi=0;this.O1ClienteCi=0;this.AV6cClienteTelefonoId=0;this.AV7cClienteTelefonoNumero="";this.AV8pClienteCi=0;this.AV9pClienteTelefonoId=0;this.AV5LinkSelection="";this.A17ClienteTelefonoId=0;this.A13ClienteTelefonoNumero="";this.A1ClienteCi=0;this.Events={e160c2_client:["ENTER",!0],e170c1_client:["CANCEL",!0],e130c1_client:["'TOGGLE'",!1],e110c1_client:["LBLCLIENTETELEFONOIDFILTER.CLICK",!1],e120c1_client:["LBLCLIENTETELEFONONUMEROFILTER.CLICK",!1]};this.EvtParms.REFRESH=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cClienteTelefonoId",fld:"vCCLIENTETELEFONOID",pic:"ZZZ9"},{av:"AV7cClienteTelefonoNumero",fld:"vCCLIENTETELEFONONUMERO",pic:""},{av:"AV8pClienteCi",fld:"vPCLIENTECI",pic:"ZZZZZZZ9"}],[]];this.EvtParms.START=[[],[{ctrl:"FORM",prop:"Caption"}]];this.EvtParms["'TOGGLE'"]=[[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}]];this.EvtParms["LBLCLIENTETELEFONOIDFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("CLIENTETELEFONOIDFILTERCONTAINER","Class")',ctrl:"CLIENTETELEFONOIDFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("CLIENTETELEFONOIDFILTERCONTAINER","Class")',ctrl:"CLIENTETELEFONOIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCCLIENTETELEFONOID","Visible")',ctrl:"vCCLIENTETELEFONOID",prop:"Visible"}]];this.EvtParms["LBLCLIENTETELEFONONUMEROFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("CLIENTETELEFONONUMEROFILTERCONTAINER","Class")',ctrl:"CLIENTETELEFONONUMEROFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("CLIENTETELEFONONUMEROFILTERCONTAINER","Class")',ctrl:"CLIENTETELEFONONUMEROFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCCLIENTETELEFONONUMERO","Visible")',ctrl:"vCCLIENTETELEFONONUMERO",prop:"Visible"}]];this.EvtParms.LOAD=[[],[{av:"AV5LinkSelection",fld:"vLINKSELECTION",pic:""}]];this.EvtParms.ENTER=[[{av:"A17ClienteTelefonoId",fld:"CLIENTETELEFONOID",pic:"ZZZ9",hsh:!0}],[{av:"AV9pClienteTelefonoId",fld:"vPCLIENTETELEFONOID",pic:"ZZZ9"}]];this.EvtParms.GRID1_FIRSTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cClienteTelefonoId",fld:"vCCLIENTETELEFONOID",pic:"ZZZ9"},{av:"AV7cClienteTelefonoNumero",fld:"vCCLIENTETELEFONONUMERO",pic:""},{av:"AV8pClienteCi",fld:"vPCLIENTECI",pic:"ZZZZZZZ9"}],[]];this.EvtParms.GRID1_PREVPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cClienteTelefonoId",fld:"vCCLIENTETELEFONOID",pic:"ZZZ9"},{av:"AV7cClienteTelefonoNumero",fld:"vCCLIENTETELEFONONUMERO",pic:""},{av:"AV8pClienteCi",fld:"vPCLIENTECI",pic:"ZZZZZZZ9"}],[]];this.EvtParms.GRID1_NEXTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cClienteTelefonoId",fld:"vCCLIENTETELEFONOID",pic:"ZZZ9"},{av:"AV7cClienteTelefonoNumero",fld:"vCCLIENTETELEFONONUMERO",pic:""},{av:"AV8pClienteCi",fld:"vPCLIENTECI",pic:"ZZZZZZZ9"}],[]];this.EvtParms.GRID1_LASTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cClienteTelefonoId",fld:"vCCLIENTETELEFONOID",pic:"ZZZ9"},{av:"AV7cClienteTelefonoNumero",fld:"vCCLIENTETELEFONONUMERO",pic:""},{av:"AV8pClienteCi",fld:"vPCLIENTECI",pic:"ZZZZZZZ9"}],[]];this.setVCMap("AV8pClienteCi","vPCLIENTECI",0,"int",8,0);this.setVCMap("AV9pClienteTelefonoId","vPCLIENTETELEFONOID",0,"int",4,0);this.setVCMap("AV8pClienteCi","vPCLIENTECI",0,"int",8,0);this.setVCMap("AV8pClienteCi","vPCLIENTECI",0,"int",8,0);t.addRefreshingVar(this.GXValidFnc[16]);t.addRefreshingVar(this.GXValidFnc[26]);t.addRefreshingVar({rfrVar:"AV8pClienteCi"});this.Initialize()});gx.createParentObj(gx0061)