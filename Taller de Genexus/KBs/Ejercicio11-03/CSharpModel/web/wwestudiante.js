/*!   GeneXus C# 15_0_12-126726 on 3/14/2019 20:7:4.56
*/
gx.evt.autoSkip=!1;gx.define("wwestudiante",!1,function(){var n,t;this.ServerClass="wwestudiante";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!1;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV19Pgmname=gx.fn.getControlValue("vPGMNAME");this.AV19Pgmname=gx.fn.getControlValue("vPGMNAME")};this.Valid_Estudiantepersonaid=function(){try{if(gx.fn.currentGridRowImpl(25)===0)return!0;var n=gx.util.balloon.getNew("ESTUDIANTEPERSONAID",gx.fn.currentGridRowImpl(25));this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.e110g2_client=function(){return this.executeServerEvent("'DOINSERT'",!1,null,!1,!1)};this.e150g2_client=function(){return this.executeServerEvent("ENTER",!0,arguments[0],!1,!1)};this.e160g2_client=function(){return this.executeServerEvent("CANCEL",!0,arguments[0],!1,!1)};this.GXValidFnc=[];n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,23,24,26,27,28,29,30];this.GXLastCtrlId=30;this.GridContainer=new gx.grid.grid(this,2,"WbpLvl2",25,"Grid","Grid","GridContainer",this.CmpContext,this.IsMasterPage,"wwestudiante",[],!1,1,!1,!0,0,!0,!1,!1,"",0,"px",0,"px","New row",!0,!1,!1,null,null,!1,"",!1,[1,1,1,1],!1,0,!0,!1);t=this.GridContainer;t.addSingleLineEdit(11,26,"ESTUDIANTENUMERO","Numero","","EstudianteNumero","int",0,"px",4,4,"right",null,[],11,"EstudianteNumero",!0,0,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");t.addSingleLineEdit(20,27,"ESTUDIANTEPERSONAID","Persona Id","","EstudiantePersonaId","int",0,"px",4,4,"right",null,[],20,"EstudiantePersonaId",!0,0,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");t.addSingleLineEdit(21,28,"ESTUDIANTEPERSONANOMBRE","Persona Nombre","","EstudiantePersonaNombre","char",0,"px",20,20,"left",null,[],21,"EstudiantePersonaNombre",!0,0,!1,!1,"DescriptionAttribute",1,"WWColumn");t.addSingleLineEdit("Update",29,"vUPDATE","","","Update","char",0,"px",20,20,"left",null,[],"Update","Update",!0,0,!1,!1,"TextActionAttribute",1,"WWTextActionColumn");t.addSingleLineEdit("Delete",30,"vDELETE","","","Delete","char",0,"px",20,20,"left",null,[],"Delete","Delete",!0,0,!1,!1,"TextActionAttribute",1,"WWTextActionColumn");this.GridContainer.emptyText="";this.setGrid(t);n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"MAINTABLE",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"TABLETOP",grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[9]={id:9,fld:"TITLETEXT",format:0,grid:0};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"",grid:0};n[12]={id:12,fld:"",grid:0};n[13]={id:13,fld:"BTNINSERT",grid:0};n[14]={id:14,fld:"",grid:0};n[15]={id:15,fld:"",grid:0};n[16]={id:16,lvl:0,type:"char",len:20,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vESTUDIANTEPERSONANOMBRE",gxz:"ZV13EstudiantePersonaNombre",gxold:"OV13EstudiantePersonaNombre",gxvar:"AV13EstudiantePersonaNombre",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV13EstudiantePersonaNombre=n)},v2z:function(n){n!==undefined&&(gx.O.ZV13EstudiantePersonaNombre=n)},v2c:function(){gx.fn.setControlValue("vESTUDIANTEPERSONANOMBRE",gx.O.AV13EstudiantePersonaNombre,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV13EstudiantePersonaNombre=this.val())},val:function(){return gx.fn.getControlValue("vESTUDIANTEPERSONANOMBRE")},nac:gx.falseFn};n[17]={id:17,fld:"",grid:0};n[18]={id:18,fld:"GRIDCELL",grid:0};n[19]={id:19,fld:"GRIDTABLE",grid:0};n[20]={id:20,fld:"",grid:0};n[21]={id:21,fld:"",grid:0};n[23]={id:23,fld:"",grid:0};n[24]={id:24,fld:"",grid:0};n[26]={id:26,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"ESTUDIANTENUMERO",gxz:"Z11EstudianteNumero",gxold:"O11EstudianteNumero",gxvar:"A11EstudianteNumero",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A11EstudianteNumero=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z11EstudianteNumero=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("ESTUDIANTENUMERO",n||gx.fn.currentGridRowImpl(25),gx.O.A11EstudianteNumero,0)},c2v:function(){this.val()!==undefined&&(gx.O.A11EstudianteNumero=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("ESTUDIANTENUMERO",n||gx.fn.currentGridRowImpl(25),",")},nac:gx.falseFn};n[27]={id:27,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:this.Valid_Estudiantepersonaid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"ESTUDIANTEPERSONAID",gxz:"Z20EstudiantePersonaId",gxold:"O20EstudiantePersonaId",gxvar:"A20EstudiantePersonaId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A20EstudiantePersonaId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z20EstudiantePersonaId=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("ESTUDIANTEPERSONAID",n||gx.fn.currentGridRowImpl(25),gx.O.A20EstudiantePersonaId,0)},c2v:function(){this.val()!==undefined&&(gx.O.A20EstudiantePersonaId=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("ESTUDIANTEPERSONAID",n||gx.fn.currentGridRowImpl(25),",")},nac:gx.falseFn};n[28]={id:28,lvl:2,type:"char",len:20,dec:0,sign:!1,ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"ESTUDIANTEPERSONANOMBRE",gxz:"Z21EstudiantePersonaNombre",gxold:"O21EstudiantePersonaNombre",gxvar:"A21EstudiantePersonaNombre",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A21EstudiantePersonaNombre=n)},v2z:function(n){n!==undefined&&(gx.O.Z21EstudiantePersonaNombre=n)},v2c:function(n){gx.fn.setGridControlValue("ESTUDIANTEPERSONANOMBRE",n||gx.fn.currentGridRowImpl(25),gx.O.A21EstudiantePersonaNombre,0)},c2v:function(){this.val()!==undefined&&(gx.O.A21EstudiantePersonaNombre=this.val())},val:function(n){return gx.fn.getGridControlValue("ESTUDIANTEPERSONANOMBRE",n||gx.fn.currentGridRowImpl(25))},nac:gx.falseFn};n[29]={id:29,lvl:2,type:"char",len:20,dec:0,sign:!1,ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vUPDATE",gxz:"ZV14Update",gxold:"OV14Update",gxvar:"AV14Update",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.AV14Update=n)},v2z:function(n){n!==undefined&&(gx.O.ZV14Update=n)},v2c:function(n){gx.fn.setGridControlValue("vUPDATE",n||gx.fn.currentGridRowImpl(25),gx.O.AV14Update,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV14Update=this.val())},val:function(n){return gx.fn.getGridControlValue("vUPDATE",n||gx.fn.currentGridRowImpl(25))},nac:gx.falseFn};n[30]={id:30,lvl:2,type:"char",len:20,dec:0,sign:!1,ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDELETE",gxz:"ZV15Delete",gxold:"OV15Delete",gxvar:"AV15Delete",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.AV15Delete=n)},v2z:function(n){n!==undefined&&(gx.O.ZV15Delete=n)},v2c:function(n){gx.fn.setGridControlValue("vDELETE",n||gx.fn.currentGridRowImpl(25),gx.O.AV15Delete,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV15Delete=this.val())},val:function(n){return gx.fn.getGridControlValue("vDELETE",n||gx.fn.currentGridRowImpl(25))},nac:gx.falseFn};this.AV13EstudiantePersonaNombre="";this.ZV13EstudiantePersonaNombre="";this.OV13EstudiantePersonaNombre="";this.Z11EstudianteNumero=0;this.O11EstudianteNumero=0;this.Z20EstudiantePersonaId=0;this.O20EstudiantePersonaId=0;this.Z21EstudiantePersonaNombre="";this.O21EstudiantePersonaNombre="";this.ZV14Update="";this.OV14Update="";this.ZV15Delete="";this.OV15Delete="";this.AV13EstudiantePersonaNombre="";this.A11EstudianteNumero=0;this.A20EstudiantePersonaId=0;this.A21EstudiantePersonaNombre="";this.AV14Update="";this.AV15Delete="";this.AV19Pgmname="";this.Events={e110g2_client:["'DOINSERT'",!0],e150g2_client:["ENTER",!0],e160g2_client:["CANCEL",!0]};this.EvtParms.REFRESH=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV14Update",fld:"vUPDATE",pic:""},{av:"AV15Delete",fld:"vDELETE",pic:""},{av:"AV19Pgmname",fld:"vPGMNAME",pic:""},{av:"AV13EstudiantePersonaNombre",fld:"vESTUDIANTEPERSONANOMBRE",pic:""}],[]];this.EvtParms.START=[[{av:"AV19Pgmname",fld:"vPGMNAME",pic:""}],[{ctrl:"GRID",prop:"Rows"},{av:"AV14Update",fld:"vUPDATE",pic:""},{av:"AV15Delete",fld:"vDELETE",pic:""},{ctrl:"FORM",prop:"Caption"},{av:"AV13EstudiantePersonaNombre",fld:"vESTUDIANTEPERSONANOMBRE",pic:""}]];this.EvtParms["GRID.LOAD"]=[[{av:"A11EstudianteNumero",fld:"ESTUDIANTENUMERO",pic:"ZZZ9",hsh:!0}],[{av:'gx.fn.getCtrlProperty("vUPDATE","Link")',ctrl:"vUPDATE",prop:"Link"},{av:'gx.fn.getCtrlProperty("vDELETE","Link")',ctrl:"vDELETE",prop:"Link"},{av:'gx.fn.getCtrlProperty("ESTUDIANTEPERSONANOMBRE","Link")',ctrl:"ESTUDIANTEPERSONANOMBRE",prop:"Link"}]];this.EvtParms["'DOINSERT'"]=[[{av:"A11EstudianteNumero",fld:"ESTUDIANTENUMERO",pic:"ZZZ9",hsh:!0}],[]];this.EvtParms.GRID_FIRSTPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV14Update",fld:"vUPDATE",pic:""},{av:"AV15Delete",fld:"vDELETE",pic:""},{av:"AV19Pgmname",fld:"vPGMNAME",pic:""},{av:"AV13EstudiantePersonaNombre",fld:"vESTUDIANTEPERSONANOMBRE",pic:""}],[]];this.EvtParms.GRID_PREVPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV14Update",fld:"vUPDATE",pic:""},{av:"AV15Delete",fld:"vDELETE",pic:""},{av:"AV19Pgmname",fld:"vPGMNAME",pic:""},{av:"AV13EstudiantePersonaNombre",fld:"vESTUDIANTEPERSONANOMBRE",pic:""}],[]];this.EvtParms.GRID_NEXTPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV14Update",fld:"vUPDATE",pic:""},{av:"AV15Delete",fld:"vDELETE",pic:""},{av:"AV19Pgmname",fld:"vPGMNAME",pic:""},{av:"AV13EstudiantePersonaNombre",fld:"vESTUDIANTEPERSONANOMBRE",pic:""}],[]];this.EvtParms.GRID_LASTPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV14Update",fld:"vUPDATE",pic:""},{av:"AV15Delete",fld:"vDELETE",pic:""},{av:"AV19Pgmname",fld:"vPGMNAME",pic:""},{av:"AV13EstudiantePersonaNombre",fld:"vESTUDIANTEPERSONANOMBRE",pic:""}],[]];this.setVCMap("AV19Pgmname","vPGMNAME",0,"char",129,0);this.setVCMap("AV19Pgmname","vPGMNAME",0,"char",129,0);this.setVCMap("AV19Pgmname","vPGMNAME",0,"char",129,0);t.addRefreshingVar(this.GXValidFnc[16]);t.addRefreshingVar({rfrVar:"AV19Pgmname"});t.addRefreshingVar({rfrVar:"AV14Update",rfrProp:"Value",gxAttId:"Update"});t.addRefreshingVar({rfrVar:"AV15Delete",rfrProp:"Value",gxAttId:"Delete"});this.Initialize()});gx.createParentObj(wwestudiante)