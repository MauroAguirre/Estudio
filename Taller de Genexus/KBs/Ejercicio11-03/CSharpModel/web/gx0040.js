/*!   GeneXus C# 15_0_12-126726 on 3/11/2019 21:1:20.78
*/
gx.evt.autoSkip=!1;gx.define("gx0040",!1,function(){var n,t;this.ServerClass="gx0040";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV8pProfesorNumero=gx.fn.getIntegerValue("vPPROFESORNUMERO",",")};this.e130b1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")=="AdvancedContainer"?(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer AdvancedContainerVisible"),gx.fn.setCtrlProperty("BTNTOGGLE","Class",gx.fn.getCtrlProperty("BTNTOGGLE","Class")+" BtnToggleActive")):(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer"),gx.fn.setCtrlProperty("BTNTOGGLE","Class","BtnToggle")),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}]),gx.$.Deferred().resolve()};this.e110b1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("PROFESORNUMEROFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("PROFESORNUMEROFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCPROFESORNUMERO","Visible",!0)):(gx.fn.setCtrlProperty("PROFESORNUMEROFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCPROFESORNUMERO","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("PROFESORNUMEROFILTERCONTAINER","Class")',ctrl:"PROFESORNUMEROFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCPROFESORNUMERO","Visible")',ctrl:"vCPROFESORNUMERO",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e120b1_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("PROFESORPERSONAIDFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("PROFESORPERSONAIDFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCPROFESORPERSONAID","Visible",!0)):(gx.fn.setCtrlProperty("PROFESORPERSONAIDFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCPROFESORPERSONAID","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("PROFESORPERSONAIDFILTERCONTAINER","Class")',ctrl:"PROFESORPERSONAIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCPROFESORPERSONAID","Visible")',ctrl:"vCPROFESORPERSONAID",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e160b2_client=function(){return this.executeServerEvent("ENTER",!0,arguments[0],!1,!1)};this.e170b1_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,35,36,37,38,39,40];this.GXLastCtrlId=40;this.Grid1Container=new gx.grid.grid(this,2,"WbpLvl2",34,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"gx0040",[],!1,1,!1,!0,10,!0,!1,!1,"",0,"px",0,"px","New row",!0,!1,!1,null,null,!1,"",!1,[1,1,1,1],!1,0,!0,!1);t=this.Grid1Container;t.addBitmap("&Linkselection","vLINKSELECTION",35,0,"px",17,"px",null,"","","SelectionAttribute","WWActionColumn");t.addSingleLineEdit(14,36,"PROFESORNUMERO","Numero","","ProfesorNumero","int",0,"px",4,4,"right",null,[],14,"ProfesorNumero",!0,0,!1,!1,"Attribute",1,"WWColumn");t.addSingleLineEdit(15,37,"PROFESORPERSONAID","Persona Id","","ProfesorPersonaId","int",0,"px",4,4,"right",null,[],15,"ProfesorPersonaId",!0,0,!1,!1,"Attribute",1,"WWColumn OptionalColumn");this.Grid1Container.emptyText="";this.setGrid(t);n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"MAIN",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"ADVANCEDCONTAINER",grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[9]={id:9,fld:"PROFESORNUMEROFILTERCONTAINER",grid:0};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"",grid:0};n[12]={id:12,fld:"LBLPROFESORNUMEROFILTER",format:1,grid:0,evt:"e110b1_client"};n[13]={id:13,fld:"",grid:0};n[14]={id:14,fld:"",grid:0};n[15]={id:15,fld:"",grid:0};n[16]={id:16,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCPROFESORNUMERO",gxz:"ZV6cProfesorNumero",gxold:"OV6cProfesorNumero",gxvar:"AV6cProfesorNumero",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV6cProfesorNumero=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV6cProfesorNumero=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCPROFESORNUMERO",gx.O.AV6cProfesorNumero,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV6cProfesorNumero=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCPROFESORNUMERO",",")},nac:gx.falseFn};n[17]={id:17,fld:"",grid:0};n[18]={id:18,fld:"",grid:0};n[19]={id:19,fld:"PROFESORPERSONAIDFILTERCONTAINER",grid:0};n[20]={id:20,fld:"",grid:0};n[21]={id:21,fld:"",grid:0};n[22]={id:22,fld:"LBLPROFESORPERSONAIDFILTER",format:1,grid:0,evt:"e120b1_client"};n[23]={id:23,fld:"",grid:0};n[24]={id:24,fld:"",grid:0};n[25]={id:25,fld:"",grid:0};n[26]={id:26,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCPROFESORPERSONAID",gxz:"ZV7cProfesorPersonaId",gxold:"OV7cProfesorPersonaId",gxvar:"AV7cProfesorPersonaId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV7cProfesorPersonaId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV7cProfesorPersonaId=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCPROFESORPERSONAID",gx.O.AV7cProfesorPersonaId,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV7cProfesorPersonaId=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCPROFESORPERSONAID",",")},nac:gx.falseFn};n[27]={id:27,fld:"",grid:0};n[28]={id:28,fld:"GRIDTABLE",grid:0};n[29]={id:29,fld:"",grid:0};n[30]={id:30,fld:"",grid:0};n[31]={id:31,fld:"BTNTOGGLE",grid:0};n[32]={id:32,fld:"",grid:0};n[33]={id:33,fld:"",grid:0};n[35]={id:35,lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:34,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vLINKSELECTION",gxz:"ZV5LinkSelection",gxold:"OV5LinkSelection",gxvar:"AV5LinkSelection",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV5LinkSelection=n)},v2z:function(n){n!==undefined&&(gx.O.ZV5LinkSelection=n)},v2c:function(n){gx.fn.setGridMultimediaValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(34),gx.O.AV5LinkSelection,gx.O.AV12Linkselection_GXI)},c2v:function(){gx.O.AV12Linkselection_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.AV5LinkSelection=this.val())},val:function(n){return gx.fn.getGridControlValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(34))},val_GXI:function(n){return gx.fn.getGridControlValue("vLINKSELECTION_GXI",n||gx.fn.currentGridRowImpl(34))},gxvar_GXI:"AV12Linkselection_GXI",nac:gx.falseFn};n[36]={id:36,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:34,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"PROFESORNUMERO",gxz:"Z14ProfesorNumero",gxold:"O14ProfesorNumero",gxvar:"A14ProfesorNumero",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A14ProfesorNumero=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z14ProfesorNumero=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("PROFESORNUMERO",n||gx.fn.currentGridRowImpl(34),gx.O.A14ProfesorNumero,0)},c2v:function(){this.val()!==undefined&&(gx.O.A14ProfesorNumero=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("PROFESORNUMERO",n||gx.fn.currentGridRowImpl(34),",")},nac:gx.falseFn};n[37]={id:37,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:34,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"PROFESORPERSONAID",gxz:"Z15ProfesorPersonaId",gxold:"O15ProfesorPersonaId",gxvar:"A15ProfesorPersonaId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A15ProfesorPersonaId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z15ProfesorPersonaId=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("PROFESORPERSONAID",n||gx.fn.currentGridRowImpl(34),gx.O.A15ProfesorPersonaId,0)},c2v:function(){this.val()!==undefined&&(gx.O.A15ProfesorPersonaId=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("PROFESORPERSONAID",n||gx.fn.currentGridRowImpl(34),",")},nac:gx.falseFn};n[38]={id:38,fld:"",grid:0};n[39]={id:39,fld:"",grid:0};n[40]={id:40,fld:"BTN_CANCEL",grid:0};this.AV6cProfesorNumero=0;this.ZV6cProfesorNumero=0;this.OV6cProfesorNumero=0;this.AV7cProfesorPersonaId=0;this.ZV7cProfesorPersonaId=0;this.OV7cProfesorPersonaId=0;this.ZV5LinkSelection="";this.OV5LinkSelection="";this.Z14ProfesorNumero=0;this.O14ProfesorNumero=0;this.Z15ProfesorPersonaId=0;this.O15ProfesorPersonaId=0;this.AV6cProfesorNumero=0;this.AV7cProfesorPersonaId=0;this.AV8pProfesorNumero=0;this.AV5LinkSelection="";this.A14ProfesorNumero=0;this.A15ProfesorPersonaId=0;this.Events={e160b2_client:["ENTER",!0],e170b1_client:["CANCEL",!0],e130b1_client:["'TOGGLE'",!1],e110b1_client:["LBLPROFESORNUMEROFILTER.CLICK",!1],e120b1_client:["LBLPROFESORPERSONAIDFILTER.CLICK",!1]};this.EvtParms.REFRESH=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cProfesorNumero",fld:"vCPROFESORNUMERO",pic:"ZZZ9"},{av:"AV7cProfesorPersonaId",fld:"vCPROFESORPERSONAID",pic:"ZZZ9"}],[]];this.EvtParms.START=[[],[{ctrl:"FORM",prop:"Caption"}]];this.EvtParms["'TOGGLE'"]=[[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}]];this.EvtParms["LBLPROFESORNUMEROFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("PROFESORNUMEROFILTERCONTAINER","Class")',ctrl:"PROFESORNUMEROFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("PROFESORNUMEROFILTERCONTAINER","Class")',ctrl:"PROFESORNUMEROFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCPROFESORNUMERO","Visible")',ctrl:"vCPROFESORNUMERO",prop:"Visible"}]];this.EvtParms["LBLPROFESORPERSONAIDFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("PROFESORPERSONAIDFILTERCONTAINER","Class")',ctrl:"PROFESORPERSONAIDFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("PROFESORPERSONAIDFILTERCONTAINER","Class")',ctrl:"PROFESORPERSONAIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCPROFESORPERSONAID","Visible")',ctrl:"vCPROFESORPERSONAID",prop:"Visible"}]];this.EvtParms.LOAD=[[],[{av:"AV5LinkSelection",fld:"vLINKSELECTION",pic:""}]];this.EvtParms.ENTER=[[{av:"A14ProfesorNumero",fld:"PROFESORNUMERO",pic:"ZZZ9",hsh:!0}],[{av:"AV8pProfesorNumero",fld:"vPPROFESORNUMERO",pic:"ZZZ9"}]];this.EvtParms.GRID1_FIRSTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cProfesorNumero",fld:"vCPROFESORNUMERO",pic:"ZZZ9"},{av:"AV7cProfesorPersonaId",fld:"vCPROFESORPERSONAID",pic:"ZZZ9"}],[]];this.EvtParms.GRID1_PREVPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cProfesorNumero",fld:"vCPROFESORNUMERO",pic:"ZZZ9"},{av:"AV7cProfesorPersonaId",fld:"vCPROFESORPERSONAID",pic:"ZZZ9"}],[]];this.EvtParms.GRID1_NEXTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cProfesorNumero",fld:"vCPROFESORNUMERO",pic:"ZZZ9"},{av:"AV7cProfesorPersonaId",fld:"vCPROFESORPERSONAID",pic:"ZZZ9"}],[]];this.EvtParms.GRID1_LASTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cProfesorNumero",fld:"vCPROFESORNUMERO",pic:"ZZZ9"},{av:"AV7cProfesorPersonaId",fld:"vCPROFESORPERSONAID",pic:"ZZZ9"}],[]];this.setVCMap("AV8pProfesorNumero","vPPROFESORNUMERO",0,"int",4,0);t.addRefreshingVar(this.GXValidFnc[16]);t.addRefreshingVar(this.GXValidFnc[26]);this.Initialize()});gx.createParentObj(gx0040)