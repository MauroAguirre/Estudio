/*!   GeneXus C# 15_0_12-126726 on 4/12/2019 21:1:36.4
*/
gx.evt.autoSkip=!1;gx.define("clasegeneral",!0,function(n){this.ServerClass="clasegeneral";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.setCmpContext(n);this.ReadonlyForm=!0;this.hasEnterEvent=!1;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){};this.Valid_Claseid=function(){try{var n=gx.util.balloon.getNew("CLASEID");this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.Valid_Actividadid=function(){try{var n=gx.util.balloon.getNew("ACTIVIDADID");this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.Valid_Profesorid=function(){try{var n=gx.util.balloon.getNew("PROFESORID");this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.e110j1_client=function(){return this.clearMessages(),this.call("clase.aspx",["UPD",this.A3ClaseId]),this.refreshOutputs([]),gx.$.Deferred().resolve()};this.e120j1_client=function(){return this.clearMessages(),this.call("clase.aspx",["DLT",this.A3ClaseId]),this.refreshOutputs([]),gx.$.Deferred().resolve()};this.e150j2_client=function(){return this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e160j2_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];var t=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38];this.GXLastCtrlId=38;t[2]={id:2,fld:"",grid:0};t[3]={id:3,fld:"MAINTABLE",grid:0};t[4]={id:4,fld:"",grid:0};t[5]={id:5,fld:"",grid:0};t[6]={id:6,fld:"",grid:0};t[7]={id:7,fld:"",grid:0};t[8]={id:8,fld:"BTNUPDATE",grid:0};t[9]={id:9,fld:"",grid:0};t[10]={id:10,fld:"BTNDELETE",grid:0};t[11]={id:11,fld:"",grid:0};t[12]={id:12,fld:"",grid:0};t[13]={id:13,fld:"ATTRIBUTESTABLE",grid:0};t[14]={id:14,fld:"",grid:0};t[15]={id:15,fld:"",grid:0};t[16]={id:16,fld:"",grid:0};t[17]={id:17,fld:"",grid:0};t[18]={id:18,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Claseid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"CLASEID",gxz:"Z3ClaseId",gxold:"O3ClaseId",gxvar:"A3ClaseId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A3ClaseId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z3ClaseId=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("CLASEID",gx.O.A3ClaseId,0)},c2v:function(){this.val()!==undefined&&(gx.O.A3ClaseId=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("CLASEID",",")},nac:gx.falseFn};t[19]={id:19,fld:"",grid:0};t[20]={id:20,fld:"",grid:0};t[21]={id:21,fld:"",grid:0};t[22]={id:22,fld:"",grid:0};t[23]={id:23,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Actividadid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"ACTIVIDADID",gxz:"Z1ActividadId",gxold:"O1ActividadId",gxvar:"A1ActividadId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A1ActividadId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z1ActividadId=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("ACTIVIDADID",gx.O.A1ActividadId,0)},c2v:function(){this.val()!==undefined&&(gx.O.A1ActividadId=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("ACTIVIDADID",",")},nac:gx.falseFn};t[24]={id:24,fld:"",grid:0};t[25]={id:25,fld:"",grid:0};t[26]={id:26,fld:"",grid:0};t[27]={id:27,fld:"",grid:0};t[28]={id:28,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Profesorid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"PROFESORID",gxz:"Z2ProfesorId",gxold:"O2ProfesorId",gxvar:"A2ProfesorId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A2ProfesorId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z2ProfesorId=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("PROFESORID",gx.O.A2ProfesorId,0)},c2v:function(){this.val()!==undefined&&(gx.O.A2ProfesorId=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("PROFESORID",",")},nac:gx.falseFn};t[29]={id:29,fld:"",grid:0};t[30]={id:30,fld:"",grid:0};t[31]={id:31,fld:"",grid:0};t[32]={id:32,fld:"",grid:0};t[33]={id:33,lvl:0,type:"char",len:20,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"PROFESORNOMBRE",gxz:"Z15ProfesorNombre",gxold:"O15ProfesorNombre",gxvar:"A15ProfesorNombre",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A15ProfesorNombre=n)},v2z:function(n){n!==undefined&&(gx.O.Z15ProfesorNombre=n)},v2c:function(){gx.fn.setControlValue("PROFESORNOMBRE",gx.O.A15ProfesorNombre,0)},c2v:function(){this.val()!==undefined&&(gx.O.A15ProfesorNombre=this.val())},val:function(){return gx.fn.getControlValue("PROFESORNOMBRE")},nac:gx.falseFn};t[34]={id:34,fld:"",grid:0};t[35]={id:35,fld:"",grid:0};t[36]={id:36,fld:"",grid:0};t[37]={id:37,fld:"",grid:0};t[38]={id:38,lvl:0,type:"char",len:20,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"ACTIVIDADDESCRIPCION",gxz:"Z13ActividadDescripcion",gxold:"O13ActividadDescripcion",gxvar:"A13ActividadDescripcion",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A13ActividadDescripcion=n)},v2z:function(n){n!==undefined&&(gx.O.Z13ActividadDescripcion=n)},v2c:function(){gx.fn.setControlValue("ACTIVIDADDESCRIPCION",gx.O.A13ActividadDescripcion,0)},c2v:function(){this.val()!==undefined&&(gx.O.A13ActividadDescripcion=this.val())},val:function(){return gx.fn.getControlValue("ACTIVIDADDESCRIPCION")},nac:gx.falseFn};this.A3ClaseId=0;this.Z3ClaseId=0;this.O3ClaseId=0;this.A1ActividadId=0;this.Z1ActividadId=0;this.O1ActividadId=0;this.A2ProfesorId=0;this.Z2ProfesorId=0;this.O2ProfesorId=0;this.A15ProfesorNombre="";this.Z15ProfesorNombre="";this.O15ProfesorNombre="";this.A13ActividadDescripcion="";this.Z13ActividadDescripcion="";this.O13ActividadDescripcion="";this.A3ClaseId=0;this.A1ActividadId=0;this.A2ProfesorId=0;this.A15ProfesorNombre="";this.A13ActividadDescripcion="";this.Events={e150j2_client:["ENTER",!0],e160j2_client:["CANCEL",!0],e110j1_client:["'DOUPDATE'",!1],e120j1_client:["'DODELETE'",!1]};this.EvtParms.REFRESH=[[{av:"A2ProfesorId",fld:"PROFESORID",pic:"ZZZ9"}],[]];this.EvtParms.START=[[{av:"AV13Pgmname",fld:"vPGMNAME",pic:""},{av:"AV6ClaseId",fld:"vCLASEID",pic:"ZZZ9"}],[]];this.EvtParms.LOAD=[[{av:"A2ProfesorId",fld:"PROFESORID",pic:"ZZZ9"},{av:"A1ActividadId",fld:"ACTIVIDADID",pic:"ZZZ9"}],[{av:'gx.fn.getCtrlProperty("PROFESORNOMBRE","Link")',ctrl:"PROFESORNOMBRE",prop:"Link"},{av:'gx.fn.getCtrlProperty("ACTIVIDADDESCRIPCION","Link")',ctrl:"ACTIVIDADDESCRIPCION",prop:"Link"}]];this.EvtParms["'DOUPDATE'"]=[[{av:"A3ClaseId",fld:"CLASEID",pic:"ZZZ9"}],[]];this.EvtParms["'DODELETE'"]=[[{av:"A3ClaseId",fld:"CLASEID",pic:"ZZZ9"}],[]];this.Initialize()})