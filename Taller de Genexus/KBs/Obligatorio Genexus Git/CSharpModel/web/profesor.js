/*!   GeneXus C# 15_0_12-126726 on 3/22/2019 19:1:2.89
*/
gx.evt.autoSkip=!1;gx.define("profesor",!1,function(){this.ServerClass="profesor";this.PackageName="GeneXus.Programs";this.setObjectType("trn");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV7ProfesorId=gx.fn.getIntegerValue("vPROFESORID",",");this.AV11Insert_ActividadId=gx.fn.getIntegerValue("vINSERT_ACTIVIDADID",",");this.A40000ProfesorFoto_GXI=gx.fn.getControlValue("PROFESORFOTO_GXI");this.AV13Pgmname=gx.fn.getControlValue("vPGMNAME");this.Gx_mode=gx.fn.getControlValue("vMODE");this.AV9TrnContext=gx.fn.getControlValue("vTRNCONTEXT")};this.Valid_Profesorid=function(){try{var n=gx.util.balloon.getNew("PROFESORID");this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.Valid_Actividadid=function(){return gx.ajax.validSrvEvt("dyncall","Valid_Actividadid",["gx.O.A1ActividadId","gx.O.A13ActividadDescripcion","gx.O.A14ActividadTipo"],["A13ActividadDescripcion","A14ActividadTipo"]),!0};this.e12022_client=function(){return this.executeServerEvent("AFTER TRN",!0,null,!1,!1)};this.e13023_client=function(){return this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e14023_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];var n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74];this.GXLastCtrlId=74;n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"MAINTABLE",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"TITLECONTAINER",grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[9]={id:9,fld:"TITLE",format:0,grid:0};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"",grid:0};n[13]={id:13,fld:"",grid:0};n[14]={id:14,fld:"",grid:0};n[15]={id:15,fld:"FORMCONTAINER",grid:0};n[16]={id:16,fld:"",grid:0};n[17]={id:17,fld:"TOOLBARCELL",grid:0};n[18]={id:18,fld:"",grid:0};n[19]={id:19,fld:"",grid:0};n[20]={id:20,fld:"",grid:0};n[21]={id:21,fld:"BTN_FIRST",grid:0};n[22]={id:22,fld:"",grid:0};n[23]={id:23,fld:"BTN_PREVIOUS",grid:0};n[24]={id:24,fld:"",grid:0};n[25]={id:25,fld:"BTN_NEXT",grid:0};n[26]={id:26,fld:"",grid:0};n[27]={id:27,fld:"BTN_LAST",grid:0};n[28]={id:28,fld:"",grid:0};n[29]={id:29,fld:"BTN_SELECT",grid:0};n[30]={id:30,fld:"",grid:0};n[31]={id:31,fld:"",grid:0};n[32]={id:32,fld:"",grid:0};n[33]={id:33,fld:"",grid:0};n[34]={id:34,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Profesorid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"PROFESORID",gxz:"Z2ProfesorId",gxold:"O2ProfesorId",gxvar:"A2ProfesorId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A2ProfesorId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z2ProfesorId=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("PROFESORID",gx.O.A2ProfesorId,0)},c2v:function(){this.val()!==undefined&&(gx.O.A2ProfesorId=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("PROFESORID",",")},nac:function(){return!(0==this.AV7ProfesorId)}};n[35]={id:35,fld:"",grid:0};n[36]={id:36,fld:"",grid:0};n[37]={id:37,fld:"",grid:0};n[38]={id:38,fld:"",grid:0};n[39]={id:39,lvl:0,type:"char",len:20,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"PROFESORNOMBRE",gxz:"Z15ProfesorNombre",gxold:"O15ProfesorNombre",gxvar:"A15ProfesorNombre",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A15ProfesorNombre=n)},v2z:function(n){n!==undefined&&(gx.O.Z15ProfesorNombre=n)},v2c:function(){gx.fn.setControlValue("PROFESORNOMBRE",gx.O.A15ProfesorNombre,0)},c2v:function(){this.val()!==undefined&&(gx.O.A15ProfesorNombre=this.val())},val:function(){return gx.fn.getControlValue("PROFESORNOMBRE")},nac:gx.falseFn};n[40]={id:40,fld:"",grid:0};n[41]={id:41,fld:"",grid:0};n[42]={id:42,fld:"",grid:0};n[43]={id:43,fld:"",grid:0};n[44]={id:44,lvl:0,type:"svchar",len:1024,dec:0,sign:!1,ro:0,multiline:!0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"PROFESORDIRECCION",gxz:"Z16ProfesorDireccion",gxold:"O16ProfesorDireccion",gxvar:"A16ProfesorDireccion",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A16ProfesorDireccion=n)},v2z:function(n){n!==undefined&&(gx.O.Z16ProfesorDireccion=n)},v2c:function(){gx.fn.setControlValue("PROFESORDIRECCION",gx.O.A16ProfesorDireccion,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A16ProfesorDireccion=this.val())},val:function(){return gx.fn.getControlValue("PROFESORDIRECCION")},nac:gx.falseFn};this.declareDomainHdlr(44,function(){gx.fn.setCtrlProperty("PROFESORDIRECCION","Link",gx.fn.getCtrlProperty("PROFESORDIRECCION","Enabled")?"":"http://maps.google.com/maps?q="+encodeURIComponent(this.A16ProfesorDireccion))});n[45]={id:45,fld:"",grid:0};n[46]={id:46,fld:"",grid:0};n[47]={id:47,fld:"",grid:0};n[48]={id:48,fld:"",grid:0};n[49]={id:49,lvl:0,type:"bits",len:1024,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"PROFESORFOTO",gxz:"Z17ProfesorFoto",gxold:"O17ProfesorFoto",gxvar:"A17ProfesorFoto",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A17ProfesorFoto=n)},v2z:function(n){n!==undefined&&(gx.O.Z17ProfesorFoto=n)},v2c:function(){gx.fn.setMultimediaValue("PROFESORFOTO",gx.O.A17ProfesorFoto,gx.O.A40000ProfesorFoto_GXI)},c2v:function(){gx.O.A40000ProfesorFoto_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.A17ProfesorFoto=this.val())},val:function(){return gx.fn.getBlobValue("PROFESORFOTO")},val_GXI:function(){return gx.fn.getControlValue("PROFESORFOTO_GXI")},gxvar_GXI:"A40000ProfesorFoto_GXI",nac:gx.falseFn};n[50]={id:50,fld:"",grid:0};n[51]={id:51,fld:"",grid:0};n[52]={id:52,fld:"",grid:0};n[53]={id:53,fld:"",grid:0};n[54]={id:54,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Actividadid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"ACTIVIDADID",gxz:"Z1ActividadId",gxold:"O1ActividadId",gxvar:"A1ActividadId",ucs:[],op:[64,59],ip:[64,59,54],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A1ActividadId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z1ActividadId=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("ACTIVIDADID",gx.O.A1ActividadId,0)},c2v:function(){this.val()!==undefined&&(gx.O.A1ActividadId=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("ACTIVIDADID",",")},nac:function(){return this.Gx_mode=="INS"&&!(0==this.AV11Insert_ActividadId)}};n[55]={id:55,fld:"",grid:0};n[56]={id:56,fld:"",grid:0};n[57]={id:57,fld:"",grid:0};n[58]={id:58,fld:"",grid:0};n[59]={id:59,lvl:0,type:"char",len:20,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"ACTIVIDADDESCRIPCION",gxz:"Z13ActividadDescripcion",gxold:"O13ActividadDescripcion",gxvar:"A13ActividadDescripcion",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A13ActividadDescripcion=n)},v2z:function(n){n!==undefined&&(gx.O.Z13ActividadDescripcion=n)},v2c:function(){gx.fn.setControlValue("ACTIVIDADDESCRIPCION",gx.O.A13ActividadDescripcion,0)},c2v:function(){this.val()!==undefined&&(gx.O.A13ActividadDescripcion=this.val())},val:function(){return gx.fn.getControlValue("ACTIVIDADDESCRIPCION")},nac:gx.falseFn};n[60]={id:60,fld:"",grid:0};n[61]={id:61,fld:"",grid:0};n[62]={id:62,fld:"",grid:0};n[63]={id:63,fld:"",grid:0};n[64]={id:64,lvl:0,type:"char",len:20,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"ACTIVIDADTIPO",gxz:"Z14ActividadTipo",gxold:"O14ActividadTipo",gxvar:"A14ActividadTipo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A14ActividadTipo=n)},v2z:function(n){n!==undefined&&(gx.O.Z14ActividadTipo=n)},v2c:function(){gx.fn.setControlValue("ACTIVIDADTIPO",gx.O.A14ActividadTipo,0)},c2v:function(){this.val()!==undefined&&(gx.O.A14ActividadTipo=this.val())},val:function(){return gx.fn.getControlValue("ACTIVIDADTIPO")},nac:gx.falseFn};n[65]={id:65,fld:"",grid:0};n[66]={id:66,fld:"",grid:0};n[67]={id:67,fld:"",grid:0};n[68]={id:68,fld:"",grid:0};n[69]={id:69,fld:"BTN_ENTER",grid:0};n[70]={id:70,fld:"",grid:0};n[71]={id:71,fld:"BTN_CANCEL",grid:0};n[72]={id:72,fld:"",grid:0};n[73]={id:73,fld:"BTN_DELETE",grid:0};n[74]={id:74,fld:"PROMPT_1",grid:3};this.A2ProfesorId=0;this.Z2ProfesorId=0;this.O2ProfesorId=0;this.A15ProfesorNombre="";this.Z15ProfesorNombre="";this.O15ProfesorNombre="";this.A16ProfesorDireccion="";this.Z16ProfesorDireccion="";this.O16ProfesorDireccion="";this.A40000ProfesorFoto_GXI="";this.A17ProfesorFoto="";this.Z17ProfesorFoto="";this.O17ProfesorFoto="";this.A1ActividadId=0;this.Z1ActividadId=0;this.O1ActividadId=0;this.A13ActividadDescripcion="";this.Z13ActividadDescripcion="";this.O13ActividadDescripcion="";this.A14ActividadTipo="";this.Z14ActividadTipo="";this.O14ActividadTipo="";this.A40000ProfesorFoto_GXI="";this.AV13Pgmname="";this.AV9TrnContext={CallerObject:"",CallerOnDelete:!1,CallerURL:"",TransactionName:"",Attributes:[]};this.AV11Insert_ActividadId=0;this.AV14GXV1=0;this.AV12TrnContextAtt={AttributeName:"",AttributeValue:""};this.AV7ProfesorId=0;this.AV10WebSession={};this.A2ProfesorId=0;this.A1ActividadId=0;this.A15ProfesorNombre="";this.A16ProfesorDireccion="";this.A17ProfesorFoto="";this.A13ActividadDescripcion="";this.A14ActividadTipo="";this.Gx_mode="";this.Events={e12022_client:["AFTER TRN",!0],e13023_client:["ENTER",!0],e14023_client:["CANCEL",!0]};this.EvtParms.ENTER=[[{postForm:!0},{av:"Gx_mode",fld:"vMODE",pic:"@!",hsh:!0},{av:"AV7ProfesorId",fld:"vPROFESORID",pic:"ZZZ9",hsh:!0}],[]];this.EvtParms.REFRESH=[[{av:"Gx_mode",fld:"vMODE",pic:"@!",hsh:!0},{av:"AV7ProfesorId",fld:"vPROFESORID",pic:"ZZZ9",hsh:!0},{av:"AV11Insert_ActividadId",fld:"vINSERT_ACTIVIDADID",pic:"ZZZ9"}],[]];this.EvtParms.START=[[{av:"AV13Pgmname",fld:"vPGMNAME",pic:""},{av:"Gx_mode",fld:"vMODE",pic:"@!",hsh:!0}],[{av:"AV9TrnContext",fld:"vTRNCONTEXT",pic:""},{av:"AV11Insert_ActividadId",fld:"vINSERT_ACTIVIDADID",pic:"ZZZ9"},{av:"AV14GXV1",fld:"vGXV1",pic:"99999999"},{av:"AV12TrnContextAtt",fld:"vTRNCONTEXTATT",pic:""}]];this.EvtParms["AFTER TRN"]=[[{av:"Gx_mode",fld:"vMODE",pic:"@!",hsh:!0},{av:"AV9TrnContext",fld:"vTRNCONTEXT",pic:""}],[]];this.setPrompt("PROMPT_1",[54]);this.EnterCtrl=["BTN_ENTER"];this.setVCMap("AV7ProfesorId","vPROFESORID",0,"int",4,0);this.setVCMap("AV11Insert_ActividadId","vINSERT_ACTIVIDADID",0,"int",4,0);this.setVCMap("A40000ProfesorFoto_GXI","PROFESORFOTO_GXI",0,"svchar",2048,0);this.setVCMap("AV13Pgmname","vPGMNAME",0,"char",129,0);this.setVCMap("Gx_mode","vMODE",0,"char",3,0);this.setVCMap("AV9TrnContext","vTRNCONTEXT",0,"TransactionContext",0,0);this.Initialize()});gx.createParentObj(profesor)