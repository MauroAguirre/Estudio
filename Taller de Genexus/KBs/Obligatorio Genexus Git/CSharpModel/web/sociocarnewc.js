/*!   GeneXus C# 15_0_12-126726 on 3/22/2019 19:1:3.92
*/
gx.evt.autoSkip=!1;gx.define("sociocarnewc",!0,function(n){var t,i;this.ServerClass="sociocarnewc";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.setCmpContext(n);this.ReadonlyForm=!0;this.hasEnterEvent=!1;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV6SocioId=gx.fn.getIntegerValue("vSOCIOID",",");this.AV6SocioId=gx.fn.getIntegerValue("vSOCIOID",",")};this.e110s2_client=function(){return this.executeServerEvent("'DOINSERT'",!1,null,!1,!1)};this.e140s2_client=function(){return this.executeServerEvent("ENTER",!0,arguments[0],!1,!1)};this.e150s2_client=function(){return this.executeServerEvent("CANCEL",!0,arguments[0],!1,!1)};this.GXValidFnc=[];t=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,18,19,21,22,23,24,25,26,27,28];this.GXLastCtrlId=28;this.GridContainer=new gx.grid.grid(this,2,"WbpLvl2",20,"Grid","Grid","GridContainer",this.CmpContext,this.IsMasterPage,"sociocarnewc",[],!1,1,!1,!0,0,!0,!1,!1,"",0,"px",0,"px","New row",!0,!1,!1,null,null,!1,"",!1,[1,1,1,1],!1,0,!0,!1);i=this.GridContainer;i.addSingleLineEdit(4,21,"CARNEID","Id","","CarneId","int",0,"px",4,4,"right",null,[],4,"CarneId",!0,0,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");i.addSingleLineEdit(22,22,"CARNEFECHAINGRESO","Fecha Ingreso","","CarneFechaIngreso","date",0,"px",8,8,"right",null,[],22,"CarneFechaIngreso",!0,0,!1,!1,"DescriptionAttribute",1,"WWColumn");i.addSingleLineEdit("Update",23,"vUPDATE","","","Update","char",0,"px",20,20,"left",null,[],"Update","Update",!0,0,!1,!1,"TextActionAttribute",1,"WWTextActionColumn");i.addSingleLineEdit("Delete",24,"vDELETE","","","Delete","char",0,"px",20,20,"left",null,[],"Delete","Delete",!0,0,!1,!1,"TextActionAttribute",1,"WWTextActionColumn");this.GridContainer.emptyText="";this.setGrid(i);t[2]={id:2,fld:"",grid:0};t[3]={id:3,fld:"MAINTABLE",grid:0};t[4]={id:4,fld:"",grid:0};t[5]={id:5,fld:"",grid:0};t[6]={id:6,fld:"TABLETOP",grid:0};t[7]={id:7,fld:"",grid:0};t[8]={id:8,fld:"",grid:0};t[9]={id:9,fld:"",grid:0};t[10]={id:10,fld:"",grid:0};t[11]={id:11,fld:"BTNINSERT",grid:0};t[12]={id:12,fld:"",grid:0};t[13]={id:13,fld:"GRIDCELL",grid:0};t[14]={id:14,fld:"GRIDTABLE",grid:0};t[15]={id:15,fld:"",grid:0};t[16]={id:16,fld:"",grid:0};t[18]={id:18,fld:"",grid:0};t[19]={id:19,fld:"",grid:0};t[21]={id:21,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:20,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"CARNEID",gxz:"Z4CarneId",gxold:"O4CarneId",gxvar:"A4CarneId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A4CarneId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z4CarneId=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("CARNEID",n||gx.fn.currentGridRowImpl(20),gx.O.A4CarneId,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A4CarneId=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("CARNEID",n||gx.fn.currentGridRowImpl(20),",")},nac:gx.falseFn};t[22]={id:22,lvl:2,type:"date",len:8,dec:0,sign:!1,ro:1,isacc:0,grid:20,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"CARNEFECHAINGRESO",gxz:"Z22CarneFechaIngreso",gxold:"O22CarneFechaIngreso",gxvar:"A22CarneFechaIngreso",dp:{f:0,st:!1,wn:!1,mf:!1,pic:"99/99/99",dec:0},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A22CarneFechaIngreso=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.Z22CarneFechaIngreso=gx.fn.toDatetimeValue(n))},v2c:function(n){gx.fn.setGridControlValue("CARNEFECHAINGRESO",n||gx.fn.currentGridRowImpl(20),gx.O.A22CarneFechaIngreso,0)},c2v:function(){this.val()!==undefined&&(gx.O.A22CarneFechaIngreso=gx.fn.toDatetimeValue(this.val()))},val:function(n){return gx.fn.getGridDateTimeValue("CARNEFECHAINGRESO",n||gx.fn.currentGridRowImpl(20))},nac:gx.falseFn};t[23]={id:23,lvl:2,type:"char",len:20,dec:0,sign:!1,ro:1,isacc:0,grid:20,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vUPDATE",gxz:"ZV11Update",gxold:"OV11Update",gxvar:"AV11Update",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.AV11Update=n)},v2z:function(n){n!==undefined&&(gx.O.ZV11Update=n)},v2c:function(n){gx.fn.setGridControlValue("vUPDATE",n||gx.fn.currentGridRowImpl(20),gx.O.AV11Update,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV11Update=this.val())},val:function(n){return gx.fn.getGridControlValue("vUPDATE",n||gx.fn.currentGridRowImpl(20))},nac:gx.falseFn};t[24]={id:24,lvl:2,type:"char",len:20,dec:0,sign:!1,ro:1,isacc:0,grid:20,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDELETE",gxz:"ZV12Delete",gxold:"OV12Delete",gxvar:"AV12Delete",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.AV12Delete=n)},v2z:function(n){n!==undefined&&(gx.O.ZV12Delete=n)},v2c:function(n){gx.fn.setGridControlValue("vDELETE",n||gx.fn.currentGridRowImpl(20),gx.O.AV12Delete,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV12Delete=this.val())},val:function(n){return gx.fn.getGridControlValue("vDELETE",n||gx.fn.currentGridRowImpl(20))},nac:gx.falseFn};t[25]={id:25,fld:"",grid:0};t[26]={id:26,fld:"",grid:0};t[27]={id:27,fld:"",grid:0};t[28]={id:28,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SOCIOID",gxz:"Z5SocioId",gxold:"O5SocioId",gxvar:"A5SocioId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A5SocioId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z5SocioId=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("SOCIOID",gx.O.A5SocioId,0)},c2v:function(){this.val()!==undefined&&(gx.O.A5SocioId=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("SOCIOID",",")},nac:gx.falseFn};this.Z4CarneId=0;this.O4CarneId=0;this.Z22CarneFechaIngreso=gx.date.nullDate();this.O22CarneFechaIngreso=gx.date.nullDate();this.ZV11Update="";this.OV11Update="";this.ZV12Delete="";this.OV12Delete="";this.A5SocioId=0;this.Z5SocioId=0;this.O5SocioId=0;this.A5SocioId=0;this.AV6SocioId=0;this.A4CarneId=0;this.A22CarneFechaIngreso=gx.date.nullDate();this.AV11Update="";this.AV12Delete="";this.Events={e110s2_client:["'DOINSERT'",!0],e140s2_client:["ENTER",!0],e150s2_client:["CANCEL",!0]};this.EvtParms.REFRESH=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV6SocioId",fld:"vSOCIOID",pic:"ZZZ9"},{av:"AV11Update",fld:"vUPDATE",pic:""},{av:"AV12Delete",fld:"vDELETE",pic:""},{av:"sPrefix"}],[]];this.EvtParms.START=[[{av:"AV16Pgmname",fld:"vPGMNAME",pic:""},{av:"AV6SocioId",fld:"vSOCIOID",pic:"ZZZ9"}],[{ctrl:"GRID",prop:"Rows"},{av:"AV11Update",fld:"vUPDATE",pic:""},{av:"AV12Delete",fld:"vDELETE",pic:""},{av:'gx.fn.getCtrlProperty("SOCIOID","Visible")',ctrl:"SOCIOID",prop:"Visible"}]];this.EvtParms["GRID.LOAD"]=[[{av:"A4CarneId",fld:"CARNEID",pic:"ZZZ9",hsh:!0}],[{av:'gx.fn.getCtrlProperty("vUPDATE","Link")',ctrl:"vUPDATE",prop:"Link"},{av:'gx.fn.getCtrlProperty("vDELETE","Link")',ctrl:"vDELETE",prop:"Link"},{av:'gx.fn.getCtrlProperty("CARNEFECHAINGRESO","Link")',ctrl:"CARNEFECHAINGRESO",prop:"Link"}]];this.EvtParms["'DOINSERT'"]=[[{av:"A4CarneId",fld:"CARNEID",pic:"ZZZ9",hsh:!0}],[]];this.EvtParms.GRID_FIRSTPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV6SocioId",fld:"vSOCIOID",pic:"ZZZ9"},{av:"AV11Update",fld:"vUPDATE",pic:""},{av:"AV12Delete",fld:"vDELETE",pic:""},{av:"sPrefix"}],[]];this.EvtParms.GRID_PREVPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV6SocioId",fld:"vSOCIOID",pic:"ZZZ9"},{av:"AV11Update",fld:"vUPDATE",pic:""},{av:"AV12Delete",fld:"vDELETE",pic:""},{av:"sPrefix"}],[]];this.EvtParms.GRID_NEXTPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV6SocioId",fld:"vSOCIOID",pic:"ZZZ9"},{av:"AV11Update",fld:"vUPDATE",pic:""},{av:"AV12Delete",fld:"vDELETE",pic:""},{av:"sPrefix"}],[]];this.EvtParms.GRID_LASTPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV6SocioId",fld:"vSOCIOID",pic:"ZZZ9"},{av:"AV11Update",fld:"vUPDATE",pic:""},{av:"AV12Delete",fld:"vDELETE",pic:""},{av:"sPrefix"}],[]];this.setVCMap("AV6SocioId","vSOCIOID",0,"int",4,0);this.setVCMap("AV6SocioId","vSOCIOID",0,"int",4,0);this.setVCMap("AV6SocioId","vSOCIOID",0,"int",4,0);i.addRefreshingVar({rfrVar:"AV6SocioId"});i.addRefreshingVar({rfrVar:"AV11Update",rfrProp:"Value",gxAttId:"Update"});i.addRefreshingVar({rfrVar:"AV12Delete",rfrProp:"Value",gxAttId:"Delete"});this.Initialize()})