/*!   GeneXus C# 15_0_12-126726 on 4/12/2019 17:31:0.98
*/
gx.evt.autoSkip=!1;gx.define("sociogeneral",!0,function(n){this.ServerClass="sociogeneral";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.setCmpContext(n);this.ReadonlyForm=!0;this.hasEnterEvent=!1;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){};this.Valid_Socioid=function(){try{var n=gx.util.balloon.getNew("SOCIOID");this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.Valid_Socioedad=function(){try{var n=gx.util.balloon.getNew("SOCIOEDAD");this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.Valid_Sociotipocuota=function(){try{var n=gx.util.balloon.getNew("SOCIOTIPOCUOTA");this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.e110q1_client=function(){return this.clearMessages(),this.call("socio.aspx",["UPD",this.A5SocioId]),this.refreshOutputs([]),gx.$.Deferred().resolve()};this.e120q1_client=function(){return this.clearMessages(),this.call("socio.aspx",["DLT",this.A5SocioId]),this.refreshOutputs([]),gx.$.Deferred().resolve()};this.e150q2_client=function(){return this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e160q2_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];var t=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54];this.GXLastCtrlId=54;t[2]={id:2,fld:"",grid:0};t[3]={id:3,fld:"MAINTABLE",grid:0};t[4]={id:4,fld:"",grid:0};t[5]={id:5,fld:"",grid:0};t[6]={id:6,fld:"",grid:0};t[7]={id:7,fld:"",grid:0};t[8]={id:8,fld:"BTNUPDATE",grid:0};t[9]={id:9,fld:"",grid:0};t[10]={id:10,fld:"BTNDELETE",grid:0};t[11]={id:11,fld:"",grid:0};t[12]={id:12,fld:"",grid:0};t[13]={id:13,fld:"ATTRIBUTESTABLE",grid:0};t[14]={id:14,fld:"",grid:0};t[15]={id:15,fld:"",grid:0};t[16]={id:16,fld:"",grid:0};t[17]={id:17,fld:"",grid:0};t[18]={id:18,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Socioid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SOCIOID",gxz:"Z5SocioId",gxold:"O5SocioId",gxvar:"A5SocioId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A5SocioId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z5SocioId=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("SOCIOID",gx.O.A5SocioId,0)},c2v:function(){this.val()!==undefined&&(gx.O.A5SocioId=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("SOCIOID",",")},nac:gx.falseFn};t[19]={id:19,fld:"",grid:0};t[20]={id:20,fld:"",grid:0};t[21]={id:21,fld:"",grid:0};t[22]={id:22,fld:"",grid:0};t[23]={id:23,lvl:0,type:"svchar",len:1024,dec:0,sign:!1,ro:1,multiline:!0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SOCIODIRECCION",gxz:"Z18SocioDireccion",gxold:"O18SocioDireccion",gxvar:"A18SocioDireccion",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A18SocioDireccion=n)},v2z:function(n){n!==undefined&&(gx.O.Z18SocioDireccion=n)},v2c:function(){gx.fn.setControlValue("SOCIODIRECCION",gx.O.A18SocioDireccion,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A18SocioDireccion=this.val())},val:function(){return gx.fn.getControlValue("SOCIODIRECCION")},nac:gx.falseFn};this.declareDomainHdlr(23,function(){gx.fn.setCtrlProperty("SOCIODIRECCION","Link",gx.fn.getCtrlProperty("SOCIODIRECCION","Enabled")?"":"http://maps.google.com/maps?q="+encodeURIComponent(this.A18SocioDireccion))});t[24]={id:24,fld:"",grid:0};t[25]={id:25,fld:"",grid:0};t[26]={id:26,fld:"",grid:0};t[27]={id:27,fld:"",grid:0};t[28]={id:28,lvl:0,type:"char",len:20,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SOCIOSEXO",gxz:"Z19SocioSexo",gxold:"O19SocioSexo",gxvar:"A19SocioSexo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",v2v:function(n){n!==undefined&&(gx.O.A19SocioSexo=n)},v2z:function(n){n!==undefined&&(gx.O.Z19SocioSexo=n)},v2c:function(){gx.fn.setComboBoxValue("SOCIOSEXO",gx.O.A19SocioSexo);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A19SocioSexo=this.val())},val:function(){return gx.fn.getControlValue("SOCIOSEXO")},nac:gx.falseFn};this.declareDomainHdlr(28,function(){});t[29]={id:29,fld:"",grid:0};t[30]={id:30,fld:"",grid:0};t[31]={id:31,fld:"",grid:0};t[32]={id:32,fld:"",grid:0};t[33]={id:33,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Socioedad,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SOCIOEDAD",gxz:"Z20SocioEdad",gxold:"O20SocioEdad",gxvar:"A20SocioEdad",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A20SocioEdad=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z20SocioEdad=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("SOCIOEDAD",gx.O.A20SocioEdad,0)},c2v:function(){this.val()!==undefined&&(gx.O.A20SocioEdad=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("SOCIOEDAD",",")},nac:gx.falseFn};t[34]={id:34,fld:"",grid:0};t[35]={id:35,fld:"",grid:0};t[36]={id:36,fld:"",grid:0};t[37]={id:37,fld:"",grid:0};t[38]={id:38,lvl:0,type:"boolean",len:4,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SOCIORECONOCIDO",gxz:"Z24SocioReconocido",gxold:"O24SocioReconocido",gxvar:"A24SocioReconocido",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"checkbox",v2v:function(n){n!==undefined&&(gx.O.A24SocioReconocido=gx.lang.booleanValue(n))},v2z:function(n){n!==undefined&&(gx.O.Z24SocioReconocido=gx.lang.booleanValue(n))},v2c:function(){gx.fn.setCheckBoxValue("SOCIORECONOCIDO",gx.O.A24SocioReconocido,!0)},c2v:function(){this.val()!==undefined&&(gx.O.A24SocioReconocido=gx.lang.booleanValue(this.val()))},val:function(){return gx.fn.getControlValue("SOCIORECONOCIDO")},nac:gx.falseFn,values:["true","false"]};t[39]={id:39,fld:"",grid:0};t[40]={id:40,fld:"",grid:0};t[41]={id:41,fld:"",grid:0};t[42]={id:42,fld:"",grid:0};t[43]={id:43,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SOCIOMONTO",gxz:"Z32SocioMonto",gxold:"O32SocioMonto",gxvar:"A32SocioMonto",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A32SocioMonto=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z32SocioMonto=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("SOCIOMONTO",gx.O.A32SocioMonto,0)},c2v:function(){this.val()!==undefined&&(gx.O.A32SocioMonto=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("SOCIOMONTO",",")},nac:gx.falseFn};t[44]={id:44,fld:"",grid:0};t[45]={id:45,fld:"",grid:0};t[46]={id:46,fld:"",grid:0};t[47]={id:47,fld:"",grid:0};t[48]={id:48,lvl:0,type:"char",len:20,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:this.Valid_Sociotipocuota,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SOCIOTIPOCUOTA",gxz:"Z33SocioTipoCuota",gxold:"O33SocioTipoCuota",gxvar:"A33SocioTipoCuota",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",v2v:function(n){n!==undefined&&(gx.O.A33SocioTipoCuota=n)},v2z:function(n){n!==undefined&&(gx.O.Z33SocioTipoCuota=n)},v2c:function(){gx.fn.setComboBoxValue("SOCIOTIPOCUOTA",gx.O.A33SocioTipoCuota);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A33SocioTipoCuota=this.val())},val:function(){return gx.fn.getControlValue("SOCIOTIPOCUOTA")},nac:gx.falseFn};this.declareDomainHdlr(48,function(){});t[49]={id:49,fld:"",grid:0};t[50]={id:50,fld:"IMAGESTABLE",grid:0};t[51]={id:51,fld:"",grid:0};t[52]={id:52,fld:"",grid:0};t[53]={id:53,fld:"",grid:0};t[54]={id:54,lvl:0,type:"bits",len:1024,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SOCIOFOTO",gxz:"Z21SocioFoto",gxold:"O21SocioFoto",gxvar:"A21SocioFoto",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A21SocioFoto=n)},v2z:function(n){n!==undefined&&(gx.O.Z21SocioFoto=n)},v2c:function(){gx.fn.setMultimediaValue("SOCIOFOTO",gx.O.A21SocioFoto,gx.O.A40000SocioFoto_GXI)},c2v:function(){gx.O.A40000SocioFoto_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.A21SocioFoto=this.val())},val:function(){return gx.fn.getBlobValue("SOCIOFOTO")},val_GXI:function(){return gx.fn.getControlValue("SOCIOFOTO_GXI")},gxvar_GXI:"A40000SocioFoto_GXI",nac:gx.falseFn};this.A5SocioId=0;this.Z5SocioId=0;this.O5SocioId=0;this.A18SocioDireccion="";this.Z18SocioDireccion="";this.O18SocioDireccion="";this.A19SocioSexo="";this.Z19SocioSexo="";this.O19SocioSexo="";this.A20SocioEdad=0;this.Z20SocioEdad=0;this.O20SocioEdad=0;this.A24SocioReconocido=!1;this.Z24SocioReconocido=!1;this.O24SocioReconocido=!1;this.A32SocioMonto=0;this.Z32SocioMonto=0;this.O32SocioMonto=0;this.A33SocioTipoCuota="";this.Z33SocioTipoCuota="";this.O33SocioTipoCuota="";this.A40000SocioFoto_GXI="";this.A21SocioFoto="";this.Z21SocioFoto="";this.O21SocioFoto="";this.A5SocioId=0;this.A18SocioDireccion="";this.A19SocioSexo="";this.A20SocioEdad=0;this.A24SocioReconocido=!1;this.A32SocioMonto=0;this.A33SocioTipoCuota="";this.A21SocioFoto="";this.A40000SocioFoto_GXI="";this.Events={e150q2_client:["ENTER",!0],e160q2_client:["CANCEL",!0],e110q1_client:["'DOUPDATE'",!1],e120q1_client:["'DODELETE'",!1]};this.EvtParms.REFRESH=[[],[]];this.EvtParms.START=[[{av:"AV13Pgmname",fld:"vPGMNAME",pic:""},{av:"AV6SocioId",fld:"vSOCIOID",pic:"ZZZ9"}],[]];this.EvtParms.LOAD=[[],[]];this.EvtParms["'DOUPDATE'"]=[[{av:"A5SocioId",fld:"SOCIOID",pic:"ZZZ9"}],[]];this.EvtParms["'DODELETE'"]=[[{av:"A5SocioId",fld:"SOCIOID",pic:"ZZZ9"}],[]];this.Initialize()})