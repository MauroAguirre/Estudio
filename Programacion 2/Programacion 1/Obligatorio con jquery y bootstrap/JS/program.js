var colSectores=[];
var colClientes = [];
var colProductos = [];
var colDisponibles=[];
var colPedidos=[];
var ides=1;
var pedid=1;
var fech = new Date();
var day=new Date().getDate();
var month=new Date().getMonth()+1;
if(day<10)
	day="0"+day;
if(month<10)
	month="0"+month;
fech = new Date().getFullYear()+"-"+ month + "-" + day;
$(document).ready(function(){
	OcultarYMostrar("Inicio");
	//Ajustar fecha	
	$("#SecDate").attr("min",fech);
	//Botones del menu principal
	$(".btnlista").click(BotonesPrincipaleslista);
	$(".btn.btn-primary").click(BotonesPrincipales); //Si el nombre de la clase lleva espacio tenes que poner punto en vez de espacio
	//Botones de los menus
	$("#AddSector").click(AgregarSector);
	$("#btnAddCli").click(AgregarClientes);
	$("#AltaPro").click(AltaProducto);
	$("#MovProducto").click(Transferencia);
	$("#ConAdd").click(ControlProducto);
	$("#btnPedAdd").click(AgregarPedidos);
	//Aceptar la modificacion o cancelar
	$("#ModSector").click(ModificarSector);
	$("#CanSector").click(NoModificarSector);
	$("#btnModCli").click(ModificarCliente);
	$("#btnBorCli").click(NoModificarCliente);
	$("#ModPro").click(ModificarProducto);
	$("#CanPro").click(NoModificarProducto);
	$("#ConMod").click(ModificarStock);
	$("#ConCan").click(NoModificarStock);
	//Cambian los productos segun sector elegido
	$("#sltSec").change(ProductosEnSectorElegidoPedidos);
	$("#numOriSec").change(ProductosEnSectorElegidoTransferencia);
	//Se abilita la fecha si el producto elegido tiene vencimiento
	$("#SecCod").change(FechaIngresaProducto);
});
//Si el producto elegido se vence se dejara escribir su fecha de vencimiento, pero si no la poce no se dejara ingresarla
function FechaIngresaProducto(){
	if(colDisponibles.length==0)
		return;
	$("#SecDate").attr("readonly","readonly");
	var select = $("#SecCod :selected").attr("posArreglo");
	switch(colDisponibles[select].Categoria){
		case "Alimentos":
		case "Cosmeticos":
		case "Perfumeria":
			$("#SecDate").removeAttr("readonly");
			break;
	}
}
//Se cancelara la modificacion del stock
function NoModificarStock(){
	$("#SecCantidad").val("");
	$("#SecDate").val("");
	$("#ConMod").hide();
	$("#ConCan").hide();
	$("#ConAdd").show();
}
//Se modificaran los datos del stock
function ModificarStock(){
	var posicion=$(this).attr("pos");
	var cambio=colProductos[posicion].Cantidad-parseInt($("#SecCantidad").val());
	if(cambio==0){
	}
	else{
		if(cambio>0)
			colProductos[posicion].Cambio="\u25bc"+cambio;
		else
			colProductos[posicion].Cambio="\u25b2"+(cambio*-1);
	}
	colProductos[posicion].FechaVencimiento=$("#SecDate").val();
	colProductos[posicion].Cantidad=parseInt($("#SecCantidad").val());
	$("#ConRes").html("Stock modificado");
	$("#SecCantidad").val("");
	$("#SecDate").val("");
	AgregarTablas("Control");
	$("#ModPro").hide();
	$("#CanPro").hide();
	$("#AltaPro").show();
}
//Se cancelara la modificacion del producto
function NoModificarProducto(){
	$("#numCod").removeAttr("readonly");
	$("#txtDesCod").val("");
	$("#txtMarCod").val("");
	$("#ModPro").hide();
	$("#CanPro").hide();
	$("#AltaPro").show();
}
//Se modificaran los datos del producto
function ModificarProducto(){
	$("#numCod").removeAttr("readonly");
	var posicion=$(this).attr("pos");
	colDisponibles[posicion].Descripcion=$("#txtDesCod").val();
	colDisponibles[posicion].Categoria=$("#numCatCod :selected").text();
	colDisponibles[posicion].Marca=$("#txtMarCod").val();
	$("#codRes").html("Producto modificado");
	$("#txtDesCod").val("");
	$("#txtMarCod").val("");
	AgregarTablas("AltadeProducto");
	$("#ModPro").hide();
	$("#CanPro").hide();
	$("#AltaPro").show();
}
//Se cancelara la modificacion del cliente
function NoModificarCliente(){
	$("#txtCliente").val("");
	$("#numRUT").val("");
	$("#numTelefono").val("");
	$("#txtEmail").val("");
	$("#btnAddCli").show();
	$("#btnModCli").hide();
	$("#btnBorCli").hide();
	$("#CliRes").html("Modificacion cancelada");
}
//Se modificaran los datos del cliente
function ModificarCliente(){
	var posicion=$(this).attr("pos");
	colClientes[posicion].Nombre=$("#txtCliente").val();
	colClientes[posicion].RUT=$("#numRUT").val();
	colClientes[posicion].Telefono=$("#numTelefono").val();
	colClientes[posicion].Email=$("#txtEmail").val();
	$("#CliRes").html("Cliente modificado");
	$("#txtCliente").val("");
	$("#numRUT").val("");
	$("#numTelefono").val("");
	$("#txtEmail").val("");
	AgregarTablas("Clientes");
	$("#btnAddCli").show();
}
//Se cancelara la modificacion del sector
function NoModificarSector(){
	$("#numSector").removeAttr("readonly");
	$("#txtDesSector").val("");
	$("#txtObsSector").val("");
	$("#AddSector").show();
	$("#ModSector").hide();
	$("#CanSector").hide();
	$("#SecRes").html("Modificacion cancelada");
}
//Se modificaran los datos del sector
function ModificarSector(){
	$("#numSector").removeAttr("readonly");
	var posicion=$(this).attr("pos");
	colSectores[posicion].Descripcion=$("#txtDesSector").val();
	colSectores[posicion].Tipo=$("#numTipoSector").val();
	colSectores[posicion].Observacion=$("#txtObsSector").val();
	$("#SecRes").html("Sector modificado");
	$("#txtDesSector").val("");
	$("#txtObsSector").val("");
	AgregarTablas("Sectores");
	$("#AddSector").show();
}
//Al tocar modificar apareceran los datos de lo elegido y se podran modificar
//Al tocar borrar se borrara lo elegido
function ModificarDeTodo(){
	var tiposec=$(this).attr("tipo");
	var posicion=$(this).attr("pos");
	switch(tiposec){
		case "ModStock":
			$("#ConAdd").hide();
			$("#ConMod").show();
			$("#ConCan").show();
			$("#ConMod").attr("pos",posicion);
			$("#ConCan").attr("pos",posicion);
			$("#SecCantidad").val(colProductos[posicion].Cantidad);
			$("#SecDate").val(colProductos[posicion].FechaVencimiento);
			$("#ConRes").html("Modifique el stock");
			break;
		case "BorStock":
			colProductos.splice(posicion,1);
			$("#ConAdd").show();
			$("#ConMod").hide();
			$("#ConBor").hide();
			$("#ConRes").html("Stock borrado");
			AgregarTablas("Control");
			break;
		case "BorDisponibles":
			$("#numCod").val("");
			colDisponibles.splice(posicion,1);
			AgregarTablas("AltadeProducto");
			$("#AltaPro").show();
			$("#ModPro").hide();
			$("#CanPro").hide();
			$("#codRes").html("Producto borrado");
			break;
		case "ModDisponibles":
			$("#numCod").attr("readonly","reandoly");
			$("#numCod").val("");
			$("#AltaPro").hide();
			$("#ModPro").show();
			$("#CanPro").show();
			$("#txtDesCod").val(colDisponibles[posicion].Descripcion);
			$("#numCatCod").val(colDisponibles[posicion].Categoria);
			$("#txtMarCod").val(colDisponibles[posicion].Marca);
			$("#ModPro").attr("pos",posicion);
			$("#CanPro").attr("pos",posicion);
			$("#codRes").html("Modifique el producto");
			break;	
		case "BorClientes":
			colClientes.splice(posicion,1);
			AgregarTablas("Clientes");
			$("#btnAddCli").show();
			$("#btnModCli").hide();
			$("#btnBorCli").hide();
			$("#CliRes").html("Cliente borrado");
			break;
		case "ModClientes":
			$("#btnAddCli").hide();
			$("#btnModCli").show();
			$("#btnBorCli").show();
			$("#txtCliente").val(colClientes[posicion].Nombre);
			$("#numRUT").val(colClientes[posicion].RUT);
			$("#numTelefono").val(colClientes[posicion].Telefono);
			$("#txtEmail").val(colClientes[posicion].Email);
			$("#btnModCli").attr("pos",posicion);
			$("#btnBorCli").attr("pos",posicion);
			$("#CliRes").html("Modifique el cliente");
			break;
		case "BorSectores":
			colSectores.splice(posicion,1);
			AgregarTablas("Sectores");
			$("#AddSector").show();
			$("#ModSector").hide();
			$("#CanSector").hide();
			$("#SecRes").html("Sector borrado");
			break;
		case "ModSectores":
			$("#numSector").attr("readonly","reandoly");
			$("#AddSector").hide();
			$("#ModSector").show();
			$("#CanSector").show();
			$("#numTipoSector").val(colSectores[posicion].Tipo);
			$("#txtDesSector").val(colSectores[posicion].Descripcion);
			$("#txtObsSector").val(colSectores[posicion].Observacion);
			$("#ModSector").attr("pos",posicion);
			$("#CanSector").attr("pos",posicion);
			$("#SecRes").html("Modifique el sector");
			break;
	}
	
}
//Se agregaran los diferentes pedidos, anotando sus caracteristicas
function AgregarPedidos(){
	if($("#sltPro :selected").val()==-1||$("#numCanCli").val()<1||$("#numCanCli").val()==""||$("#numCanCli").val()>colProductos[$("#sltPro :selected").val()].Cantidad)
		$("#resPed").html("Error en el pedido");
	else{
		var fecha = new Date().toJSON().slice(0,10).replace(/-/g,'/');
		var ingresoPedido={
			Pedido:pedid,
			Codigo:$("#txtCodPed").val(),
			Cliente:colClientes[$("#sltIdCliente :selected").attr("Clipos")].Id,
			Producto:colProductos[$("#sltPro :selected").val()].Codigo,
			Cantidad:parseInt($("#numCanCli").val()),
			Fecha:fecha,
		}
		if(parseInt(colProductos[$("#sltPro :selected").val()].Cantidad)==parseInt($("#numCanCli").val()))
			colProductos.splice($("#sltPro :selected").val(),1);
		else{
			colProductos[$("#sltPro :selected").val()].Cantidad-=parseInt($("#numCanCli").val());
			colProductos[$("#sltPro :selected").val()].Fecha=fecha;
			colProductos[$("#sltPro :selected").val()].Cambio="\u25bc"+parseInt($("#numCanCli").val());
		}
		colPedidos.push(ingresoPedido);
		$("#txtCodPed").val("");
		$("#numCanCli").val("");
		pedid++;
		$("#resPed").html("Pedido ingresado");
		AgregarTablas("Pedidos");
	}
}
//Verificara si existe el producto a transferir en el sector destino
function CheckTransferencia(){
	for(var i=0;i<colProductos.length;i++){
		if(colProductos[i].Codigo==colProductos[$("#txtOriPro :selected").val()].Codigo && colProductos[i].FechaVencimiento==colProductos[$("#txtOriPro :selected").val()].FechaVencimiento && colProductos[i].Sector==colSectores[$("#numDesSec :selected").val()].Numero)
			return i;
	}
	return -1;
}
//Transfiere productos de sector a sector, si el producto no existe en el sector elegido lo agrega de contrario solo aumenta su cantidad
//El producto a transferir se quedar sin stock este desaparecera del sector de contrario solo disminuira su cantidad
function Transferencia(){
	if($("#txtOriPro :selected").val()==-1){
		$("#MovProRes").html("Error");
		return;
	}
	if($("#numOriSec :selected").val() == $("#numDesSec :selected").val() || colProductos[$("#txtOriPro :selected").val()].Cantidad < $("#numCanOriPro").val() || $("#txtOriPro :selected").val() == -1 || $("#numCanOriPro").val() == "" || $("#numCanOriPro").val() == 0){
		$("#MovProRes").html("Error");
		return;
	}
	var origen=$("#txtOriPro :selected").val();
	var destino=CheckTransferencia();
	var fecha = new Date().toJSON().slice(0,10).replace(/-/g,'/');
	var lugar;
	for(var i=0;i<colDisponibles.length;i++){
		if(colDisponibles[i].Codigo==colProductos[origen].Codigo){
			lugar=i;
			break;
		}
	}
	if(destino==-1){		
		var producto={
			Codigo:colProductos[origen].Codigo,
			Sector:colSectores[$("#numDesSec :selected").val()].Numero,
			Cantidad:parseInt($("#numCanOriPro").val()),
			Fecha:fecha,
			FechaVencimiento:colProductos[origen].FechaVencimiento,
			Cambio:"\u25b2"+parseInt($("#numCanOriPro").val()),
		};
		if(colProductos[origen].Cantidad==$("#numCanOriPro").val())
			colProductos.splice(origen,1);
		else{
			colProductos[origen].Cantidad-=parseInt($("#numCanOriPro").val());
			colProductos[origen].Cambio="\u25bc"+$("#numCanOriPro").val();
		}
		ColocarProductoEnOrden(producto,colSectores[$("#numDesSec :selected").val()].Numero);
	}
	else{
		colProductos[destino].Fecha=fecha;
		if(colProductos[origen].Cantidad==parseInt($("#numCanOriPro").val())){
			colProductos[destino].Cantidad+=parseInt($("#numCanOriPro").val());
			colProductos[destino].Cambio="\u25b2"+$("#numCanOriPro").val();
			colProductos.splice(origen,1);
		}
		else{
			colProductos[destino].Cantidad+=parseInt($("#numCanOriPro").val());
			colProductos[destino].Cambio="\u25b2"+parseInt($("#numCanOriPro").val());
			colProductos[origen].Cantidad-=parseInt($("#numCanOriPro").val());
			colProductos[origen].Cambio="\u25bc"+parseInt($("#numCanOriPro").val());
		}
	}
	ProductosEnSectorElegidoTransferencia();
	$("#MovProRes").html("Producto transferido");
}
//Coloca los productos en orden dependiendo de su sector
function ColocarProductoEnOrden(producto,check){
	for(var i=0;i<colProductos.length;i++){
			if(parseInt(check)<parseInt(colProductos[i].Sector)){
				colProductos.splice(i,0,producto);
				return;
			}
		}
	colProductos.push(producto);
}
function CheckControl(){
	for(var l=0;l<colProductos.length;l++){
		if(colProductos[l].Sector == $("#SecCtrl :selected").attr("Sector") && colProductos[l].Codigo ==$ ("#SecCod :selected").attr("codigo") && colProductos[l].FechaVencimiento == $("#SecDate").val())
			return l;
	}
	return -1;
}
//Agrega el producto en el stock, si ya esta el producto en el sector con la fecha correspondiente solo aumenta el sector sino lo agrega
function ControlProducto(){
	if($("#SecCantidad").val()==0 || $("#SecCantidad").val()==""){
		$("#ConRes").html("Error en el control");
		return;
	}
	var fecha = new Date().toJSON().slice(0,10).replace(/-/g,'/');
	var check=CheckControl();
	var posicion=$("#SecCod :selected").attr("posArreglo");
	if(check!=-1){
		colProductos[check].Cantidad+=parseInt($("#SecCantidad").val());
		colProductos[check].Fecha=fecha;
		colProductos[check].Cambio="\u25b2"+parseInt($("#SecCantidad").val());
	}
	else{	
		var producto={
			Codigo:colDisponibles[posicion].Codigo,
			Sector:$("#SecCtrl :selected").attr("Sector"),
			Cantidad:parseInt($("#SecCantidad").val()),
			Fecha:fecha,
			FechaVencimiento:$("#SecDate").val(),
			Cambio:0,
		};
		ColocarProductoEnOrden(producto,$("#SecCtrl :selected").attr("Sector"));
	}
	$("#SecCantidad").val("");
	$("#SecDate").val("");
	$("#ConRes").html("Control terminado");
	AgregarTablas("Control");
}
//Da de alta los productos en orden de su codigo
function ColocarDisponibleEnOrden(producto){
	for(var i=0;i<colDisponibles.length;i++){
		if(parseInt($("#numCod").val())<parseInt(colDisponibles[i].Codigo)){
			colDisponibles.splice(i,0,producto);
			return;
		}
	}
	colDisponibles.push(producto);
}
//Verifica si el producto ya esta ingresado
function CheckDisponibles(){
	for(var i=0;i<colDisponibles.length;i++){
		if(colDisponibles[i].Codigo==$("#numCod").val())
			return false;
	}
	return true;
}
//Da de alta los productos
function AltaProducto(){
	if($("#numCod").val()==""||$("#txtDesCod").val()==""){
		$("#codRes").html("Error");
		return;
	}
	if(CheckDisponibles()){
		$("#codRes").html("Producto Ingresado");
		var producto = {
			Codigo:$("#numCod").val(),
			Descripcion:$("#txtDesCod").val(),
			Categoria:$("#numCatCod :selected").text(),
			Marca:$("#txtMarCod").val(),
		};
		ColocarDisponibleEnOrden(producto)
		$("#numCod").val("");
		$("#txtDesCod").val("");
		$("#txtMarCod").val("");
	}
	else{
		$("#codRes").html("Ya esta agregado");
	}
	AgregarTablas("AltadeProducto");
}
//Agrega nuevos clientes
function AgregarClientes(){
	if($("#txtCliente").val()==""||$("#numRUT").val()==""){
		$("#CliRes").html("Error");
		return;
	}	
	var cliente={
		Id:ides,
		Nombre:$("#txtCliente").val(),
		RUT:$("#numRUT").val(),
		Telefono:$("#numTelefono").val(),
		Email:$("#txtEmail").val(),
	};
	$("#txtCliente").val("");
	$("#numRUT").val("");
	$("#numTelefono").val("");
	$("#txtEmail").val("");
	colClientes.push(cliente);
	$("#CliRes").html("Id del cliente: "+ides);
	ides++;
	AgregarTablas("Clientes");
}
//Agrega el sector en orden de su numero
function AgregarSectorEnOrden(sector){
	for(var i=0;i<colSectores.length;i++){
		if(parseInt(colSectores[i].Numero)>parseInt($("#numSector").val())){
			colSectores.splice(i,0,sector);
			return;
		}
	}
	colSectores.push(sector);
}
//Verifica si el sector ya esta ingresado y los datos
function CheckSectores(){
	var checkiar = true;
	if($("#numSector").val()<0||$("#numSector").val()>99||$("#numSector").val()==""||$("#txtDesSector").val()==""){
		checkiar = false;
	}
	for(var l=0;l<colSectores.length;l++){
		if(colSectores[l].Numero == $("#numSector").val()){
			checkiar=false;
		}
	}
	return checkiar;
}
//Agrega sectores
function AgregarSector(){
	$("#numTipoSecRes").html("");
	$("#numSecRes").html("");
	var check = CheckSectores();
	if(check){
		var sector = {
			Numero:$("#numSector").val(),
			Tipo:$("#numTipoSector").val(),
			Descripcion:$("#txtDesSector").val(),
			Observacion:$("#txtObsSector").val(),
		};
		AgregarSectorEnOrden(sector);
		$("#numSector").val("");
		$("#txtDesSector").val("");
		$("#txtObsSector").val("");
		$("#SecRes").html("Sector agregado");
	}
	else{
		$("#SecRes").html("Error en el procedimiento");
	}
	AgregarTablas("Sectores");
}
//Muestra los productos en el sector elegido en las transferencias
function ProductosEnSectorElegidoTransferencia(){
	var hay=false;
	$("#txtOriPro").html("");
	var lugar;
	for(var i=0;i<colProductos.length;i++){
		for(var l=0;l<colDisponibles.length;l++){
			if(colDisponibles[l].Codigo==colProductos[i].Codigo){
				lugar=l;
				break;
			}
		}
		if(colProductos[i].Sector==colSectores[$("#numOriSec :selected").val()].Numero){
			$("#txtOriPro").append('<option value='+i+'>'+colProductos[i].Codigo+":"+colDisponibles[lugar].Descripcion+":"+colProductos[i].FechaVencimiento+'</option>');
			hay=true;
		}
	}
	if(!hay)
		$("#txtOriPro").append('<option value='+-1+'>'+"No hay productos"+'</option>');
}
//Muestra los productos en el sector elegido en los pedidos
function ProductosEnSectorElegidoPedidos(){
	var hay=false;
	$("#sltPro").html("");
	var lugar;
	for(var i=0;i<colProductos.length;i++){
		for(var l=0;l<colDisponibles.length;l++){
			if(colDisponibles[l].Codigo==colProductos[l].Codigo){
				lugar=l;
				break;
			}
		}
		if(colProductos[i].Sector==$("#sltSec :selected").attr("Sector")){
			$("#sltPro").append('<option value='+i+'>'+colProductos[i].Codigo+":"+colDisponibles[lugar].Descripcion+":"+colProductos[i].FechaVencimiento+'</option>');
			hay=true;
		}
	}
	if(!hay)
		$("#sltPro").append('<option value='+-1+'>'+"No hay productos"+'</option>');
}
//Agrega las tablas en los menus correspondientes
function AgregarTablas(tabla){
	switch(tabla){
		case "Clientes":
			$("#CliCol").hide();
			$("#btnAddCli").show();
			$("#btnModCli").hide();
			$("#btnBorCli").hide();
			if(colClientes.length>0)
				$("#CliCol").show();
			$("#tblCliCol").html("");
			for(var i=0;i<colClientes.length;i++)
				$("#tblCliCol").append('<tr><td>'+colClientes[i].Id+'</td><td>'+colClientes[i].Nombre+'</td><td>'+colClientes[i].RUT+'</td><td>'+colClientes[i].Telefono+'</td><td>'+colClientes[i].Email+'</td><td><input type="button" value="Modificar" pos="'+i+'" class="btn btn-info" tipo="ModClientes"/></td><td><input type="button" value="Borrar" pos="'+i+'"class="btn btn-info" tipo="BorClientes"/></td></tr>')
			$(".btn.btn-info").click(ModificarDeTodo);
			break;
		case "Sectores":
			$("#numSector").removeAttr("readonly");
			$("#SecCol").hide();
			$("#AddSector").show();
			$("#ModSector").hide();
			$("#CanSector").hide();
			if(colSectores.length>0)
				$("#SecCol").show();
			$("#tblSecCol").html("");
			for(var l=0;l<colSectores.length;l++)
				$("#tblSecCol").append('<tr><td>'+colSectores[l].Numero+'</td><td>'+colSectores[l].Tipo+'</td><td>'+colSectores[l].Descripcion+'</td><td>'+colSectores[l].Observacion+'</td><td><input type="button" value="Modificar" pos="'+l+'" class="btn btn-info" tipo="ModSectores"/></td><td><input type="button" value="Borrar" pos="'+l+'"class="btn btn-info" tipo="BorSectores"/></td></tr>');
			$(".btn.btn-info").click(ModificarDeTodo);
			break;
		case "Pedidos":
			$("#btnPedAdd").show();
			$("#btnPedMod").hide();
			$("#btnPedCan").hide();
			$("#tbePed").hide();
			if(colPedidos.length>0)
				$("#tbePed").show();
			$("#tbePedBod").html("");
			for(var i=0;i<colPedidos.length;i++)
				$("#tbePedBod").append('<tr><td>'+colPedidos[i].Pedido+'</td><td>'+colPedidos[i].Codigo+'</td><td>'+colPedidos[i].Cliente+'</td><td>'+colPedidos[i].Producto+'</td><td>'+colPedidos[i].Cantidad+'</td><td>'+colPedidos[i].Fecha+'</td></tr>');
			$("#sltSec").html("");
			$("#sltIdCliente").html("");
			for(var i=0;i<colSectores.length;i++){
				if(colSectores[i].Tipo=="1")
					$("#sltSec").append('<option pos="'+i+'" Sector='+colSectores[i].Numero+'>'+colSectores[i].Numero+":"+colSectores[i].Descripcion+'</option>');	
			}
			for(var i=0;i<colClientes.length;i++)
				$("#sltIdCliente").append('<option Clipos="'+i+'">'+colClientes[i].Id+":"+colClientes[i].Nombre+'</option>');
			ProductosEnSectorElegidoPedidos();
			break;
		case "AltadeProducto":
			$("#numCod").removeAttr("readonly");
			$("#AltaPro").show();
			$("#ModPro").hide();
			$("#CanPro").hide();
			$("#DisCol").hide();
			if(colDisponibles.length>0)
				$("#DisCol").show();
			$("#tblDisCol").html("");
			for(var i=0;i<colDisponibles.length;i++)
				$("#tblDisCol").append('<tr><td>'+colDisponibles[i].Codigo+'</td><td>'+colDisponibles[i].Descripcion+'</td><td>'+colDisponibles[i].Categoria+'</td><td>'+colDisponibles[i].Marca+'</td><td><input type="button" value="Modificar" pos="'+i+'" class="btn btn-info" tipo="ModDisponibles"/></td><td><input type="button" value="Borrar" pos="'+i+'" class="btn btn-info" tipo="BorDisponibles"/></td></tr>');
			$(".btn.btn-info").click(ModificarDeTodo);
			break;
		case "Transferencias":
			$("#numOriSec").html("");
			$("#txtOriPro").html("");
			$("#numDesSec").html("");
			for(var i=0;i<colSectores.length;i++){
				$("#numOriSec").append('<option value='+i+'>'+colSectores[i].Numero+":"+colSectores[i].Descripcion+'</option>');
				$("#numDesSec").append('<option value='+i+'>'+colSectores[i].Numero+":"+colSectores[i].Descripcion+'</option>');
			}
			ProductosEnSectorElegidoTransferencia();
			break;
		case "Control":
			$("#ConAdd").show();
			$("#ConMod").hide();
			$("#ConCan").hide();
			$("#tbeCon").hide();
			if(colProductos.length>0)
				$("#tbeCon").show();
			$("#SecCtrl").html("");
			$("#SecCod").html("");
			for(var i=0;i<colSectores.length;i++){
				if(colSectores[i].Tipo=="2")
					$("#SecCtrl").append('<option Sector='+colSectores[i].Numero+'>'+colSectores[i].Numero+":"+colSectores[i].Descripcion+'</option>');
			}
			for(var i=0;i<colDisponibles.length;i++)
				$("#SecCod").append('<option codigo='+colDisponibles[i].Codigo+' posArreglo='+i+'>'+colDisponibles[i].Codigo+":"+colDisponibles[i].Descripcion+'</option>');		
			FechaIngresaProducto();
			$("#tbeConBod").html("");
			var lugar;
			for(var i=0;i<colProductos.length;i++){
				for(var l=0;l<colDisponibles.length;l++){
					if(colProductos[i].Codigo==colDisponibles[l].Codigo){
						lugar=l;
						break;
					}
				}
				$("#tbeConBod").append('<tr><td>'+colProductos[i].Sector+'</td><td>'+colProductos[i].Codigo+'</td><td>'+colDisponibles[lugar].Descripcion+'</td><td>'+colProductos[i].Fecha+'</td><td>'+colProductos[i].FechaVencimiento+'</td><td>'+colProductos[i].Cantidad+'</td><td>'+colProductos[i].Cambio+'</td><td><input type="button" value="Modificar" pos="'+i+'" class="btn btn-info" tipo="ModStock"/></td><td><input type="button" value="Borrar" pos="'+i+'" class="btn btn-info" tipo="BorStock"/></td></tr>');
			}
			$(".btn.btn-info").click(ModificarDeTodo);
			break;
		case "PorCategoria":
			MostrarCategorias();
			$("#tableAliBod").html("");
			$("#tableJugBod").html("");
			$("#tablenicaBod").html("");
			$("#tableticosBod").html("");
			$("#tableBebBod").html("");
			$("#tableBazBod").html("");
			$("#tableCosBod").html("");
			$("#tablePerBod").html("");
			$("#tableVesBod").html("");
			for(var l=0;l<colProductos.length;l++){
				var Cat;
				var lugar;
				for(var i=0;i<colDisponibles.length;i++){
					if(colDisponibles[i].Codigo==colProductos[l].Codigo){
						Cat=colDisponibles[i].Categoria;
						lugar=i;
						break;
					}
				}
				switch(Cat){
					case "Alimentos":
						$("#tableAliBod").append('<tr><td>'+colProductos[l].Codigo+'</td><td>'+colDisponibles[lugar].Descripcion+'</td><td>'+colDisponibles[lugar].Marca+'</td><td>'+colProductos[l].Fecha+'</td><td>'+colProductos[l].FechaVencimiento+'</td><td>'+colProductos[l].Cantidad+'</td><td>'+colProductos[l].Sector+'</td></tr>');
						break;
					case "Jugueteria":
						$("#tableJugBod").append('<tr><td>'+colProductos[l].Codigo+'</td><td>'+colDisponibles[lugar].Descripcion+'</td><td>'+colDisponibles[lugar].Marca+'</td><td>'+colProductos[l].Fecha+'</td><td>'+colProductos[l].FechaVencimiento+'</td><td>'+colProductos[l].Cantidad+'</td><td>'+colProductos[l].Sector+'</td></tr>');
						break;
					case "Electronica":
						$("#tablenicaBod").append('<tr><td>'+colProductos[l].Codigo+'</td><td>'+colDisponibles[lugar].Descripcion+'</td><td>'+colDisponibles[lugar].Marca+'</td><td>'+colProductos[l].Fecha+'</td><td>'+colProductos[l].FechaVencimiento+'</td><td>'+colProductos[l].Cantidad+'</td><td>'+colProductos[l].Sector+'</td></tr>');
						break;
					case "Electrodomesticos":
						$("#tableticosBod").append('<tr><td>'+colProductos[l].Codigo+'</td><td>'+colDisponibles[lugar].Descripcion+'</td><td>'+colDisponibles[lugar].Marca+'</td><td>'+colProductos[l].Fecha+'</td><td>'+colProductos[l].FechaVencimiento+'</td><td>'+colProductos[l].Cantidad+'</td><td>'+colProductos[l].Sector+'</td></tr>');
						break;
					case "Bebidas":
						$("#tableBebBod").append('<tr><td>'+colProductos[l].Codigo+'</td><td>'+colDisponibles[lugar].Descripcion+'</td><td>'+colDisponibles[lugar].Marca+'</td><td>'+colProductos[l].Fecha+'</td><td>'+colProductos[l].FechaVencimiento+'</td><td>'+colProductos[l].Cantidad+'</td><td>'+colProductos[l].Sector+'</td></tr>');
						break;
					case "Bazar":
						$("#tableBazBod").append('<tr><td>'+colProductos[l].Codigo+'</td><td>'+colDisponibles[lugar].Descripcion+'</td><td>'+colDisponibles[lugar].Marca+'</td><td>'+colProductos[l].Fecha+'</td><td>'+colProductos[l].FechaVencimiento+'</td><td>'+colProductos[l].Cantidad+'</td><td>'+colProductos[l].Sector+'</td></tr>');
						break;
					case "Cosmeticos":
						$("#tableCosBod").append('<tr><td>'+colProductos[l].Codigo+'</td><td>'+colDisponibles[lugar].Descripcion+'</td><td>'+colDisponibles[lugar].Marca+'</td><td>'+colProductos[l].Fecha+'</td><td>'+colProductos[l].FechaVencimiento+'</td><td>'+colProductos[l].Cantidad+'</td><td>'+colProductos[l].Sector+'</td></tr>');
						break;
					case "Perfumeria":
						$("#tablePerBod").append('<tr><td>'+colProductos[l].Codigo+'</td><td>'+colDisponibles[lugar].Descripcion+'</td><td>'+colDisponibles[lugar].Marca+'</td><td>'+colProductos[l].Fecha+'</td><td>'+colProductos[l].FechaVencimiento+'</td><td>'+colProductos[l].Cantidad+'</td><td>'+colProductos[l].Sector+'</td></tr>');
						break;
					case "Vestimenta":
						$("#tableVesBod").append('<tr><td>'+colProductos[l].Codigo+'</td><td>'+colDisponibles[lugar].Descripcion+'</td><td>'+colDisponibles[lugar].Marca+'</td><td>'+colProductos[l].Fecha+'</td><td>'+colProductos[l].FechaVencimiento+'</td><td>'+colProductos[l].Cantidad+'</td><td>'+colProductos[l].Sector+'</td></tr>');
						break;
				}
			}
			break;
		case "PorSector":
			$("#tblSecBody").html("");
			for(var l=0;l<colProductos.length;l++){
				var lugar;
				for(var i=0;i<colDisponibles.length;i++){
					if(colDisponibles[i].Codigo==colProductos[l].Codigo){
						lugar=i;
						break;
					}
				}
				$("#tblSecBody").append('<tr><td>'+colProductos[l].Codigo+'</td><td>'+colDisponibles[lugar].Descripcion+'</td><td>'+colDisponibles[lugar].Marca+'</td><td>'+colProductos[l].Fecha+'</td><td>'+colProductos[l].FechaVencimiento+'</td><td>'+colProductos[l].Cantidad+'</td><td>'+colDisponibles[lugar].Categoria+'</td><td>'+colProductos[l].Sector+'</td></tr>');			
			}
			break;
		case "PorFecha":
			var ordenado = [];
			var posicion;
			for(var i=0;i<colProductos.length;i++){
				for(var l=0;l<colDisponibles.length;l++){
					if(colProductos[i].Codigo==colDisponibles[l].Codigo){
						posicion=l;
						break;
					}
				}
				var producto ={
					Codigo:colProductos[i].Codigo,
					Descripcion:colDisponibles[posicion].Descripcion,
					Marca:colDisponibles[posicion].Marca,
					Cantidad:colProductos[i].Cantidad,
					Categoria:colDisponibles[posicion].Categoria,
					Sector:colProductos[i].Sector,
					Fecha:colProductos[i].Fecha,
					FechaVencimiento:colProductos[i].FechaVencimiento,
				}
				ordenado.push(producto);
			}
			Array.prototype.orderByDate=function(p,so){
				if(so!=-1&&so!=1)so=1;
				this.sort(function(a,b){
					var da=new Date(a[p]),db=new Date(b[p]);
					return(da-db)*so;
				})
			}
			ordenado.orderByDate('Fecha',-1);
			$("#tblFecBody").html("");
			for(var i=0;i<ordenado.length;i++)
				$("#tblFecBody").append('<tr><td>'+ordenado[i].Codigo+'</td><td>'+ordenado[i].Descripcion+'</td><td>'+ordenado[i].Marca+'</td><td>'+ordenado[i].Cantidad+'</td><td>'+ordenado[i].Categoria+'</td><td>'+ordenado[i].Sector+'</td><td>'+ordenado[i].Fecha+'</td><td>'+ordenado[i].FechaVencimiento+'</td></tr>');
			break;
		case "PorCantidad":
			$("#tblMayor").html("");
			$("#tblMenor").html("");
			if(colProductos.length>0){
				var mayores=[];
				for(var i=0;i<colProductos.length;i++){
					var lugar;
					for(var n=0;n<colDisponibles.length;n++){
						if(colDisponibles[n].Codigo==colProductos[i].Codigo){
							lugar = n;
							break;
						}
					}
					var producto ={
						Codigo:colProductos[i].Codigo,
						Descripcion:colDisponibles[lugar].Descripcion,
						Marca:colDisponibles[lugar].Marca,
						Cantidad:colProductos[i].Cantidad,
						Categoria:colDisponibles[lugar].Categoria,
						Sector:colProductos[i].Sector,
						Fecha:colProductos[i].Fecha,
						FechaVencimiento:colProductos[i].FechaVencimiento,
					}
					mayores.push(producto);
				}
				var mayor;
				for(var l=0;l<5&&mayores.length>0;l++){
					for(var i=0;i<mayores.length;i++){
						if(i==0)
							mayor=i;
						else{
							if(mayores[i].Cantidad>mayores[mayor].Cantidad)
								mayor=i;
						}
					}
					$("#tblMayor").append('<tr><td>'+mayores[mayor].Codigo+'</td><td>'+mayores[mayor].Descripcion+'</td><td>'+mayores[mayor].Marca+'</td><td>'+mayores[mayor].Cantidad+'</td><td>'+mayores[mayor].Categoria+'</td><td>'+mayores[mayor].Sector+'</td><td>'+mayores[mayor].Fecha+'</td><td>'+mayores[mayor].FechaVencimiento+'</td></tr>');
					mayores.splice(mayor,1);
				}
				var menores=[];
				for(var i=0;i<colProductos.length;i++){
					var lugar;
					for(var n=0;n<colDisponibles.length;n++){
						if(colDisponibles[n].Codigo==colProductos[i].Codigo){
							lugar = n;
							break;
						}
					}
					var producto ={
						Codigo:colProductos[i].Codigo,
						Descripcion:colDisponibles[lugar].Descripcion,
						Marca:colDisponibles[lugar].Marca,
						Cantidad:colProductos[i].Cantidad,
						Categoria:colDisponibles[lugar].Categoria,
						Sector:colProductos[i].Sector,
						Fecha:colProductos[i].Fecha,
						FechaVencimiento:colProductos[i].FechaVencimiento,
					}
					menores.push(producto);
				}
				var menor;
				for(var l=0;l<5&&menores.length>0;l++){
					for(var i=0;i<menores.length;i++){
						if(i==0)
							menor=i;
						else{
							if(menores[i].Cantidad<menores[menor].Cantidad)
								menor=i;
						}
					}
					$("#tblMenor").append('<tr><td>'+menores[menor].Codigo+'</td><td>'+menores[menor].Descripcion+'</td><td>'+menores[menor].Marca+'</td><td>'+menores[menor].Cantidad+'</td><td>'+menores[menor].Categoria+'</td><td>'+menores[menor].Sector+'</td><td>'+menores[menor].Fecha+'</td><td>'+menores[menor].FechaVencimiento+'</td></tr>');
					menores.splice(menor,1);
				}
			}
			break;
	}
}
//Muestra las categorias si hay stock con esa categoria
function MostrarCategorias(){
	$("#ali").hide();
	$("#tableAli").hide();
	$("#jug").hide();
	$("#tableJug").hide();
	$("#nica").hide();
	$("#tablenica").hide();
	$("#ticos").hide();
	$("#tableticos").hide();
	$("#beb").hide();
	$("#tableBeb").hide();
	$("#baz").hide();
	$("#tableBaz").hide();
	$("#cos").hide();
	$("#tableCos").hide();
	$("#per").hide();
	$("#tablePer").hide();
	$("#ves").hide();
	$("#tableVes").hide();
	for(var i=0;i<colProductos.length;i++){
		var cate;
		for(var l=0;l<colDisponibles.length;l++){
			if(colProductos[i].Codigo==colDisponibles[l].Codigo){
				cate=colDisponibles[l].Categoria;
				break;
			}
		}
		switch(cate){
			case "Alimentos":
				$("#ali").show();
				$("#tableAli").show();
				break;
			case "Jugueteria":
				$("#jug").show();
				$("#tableJug").show();
				break;
			case "Electronica":
				$("#nica").show();
				$("#tablenica").show();
				break;
			case "Electrodomesticos":
				$("#ticos").show();
				$("#tableticos").show();
				break;
			case "Bebidas":
				$("#beb").show();
				$("#tableBeb").show();
				break;
			case "Bazar":
				$("#baz").show();
				$("#tableBaz").show();
				break;
			case "Cosmeticos":
				$("#cos").show();
				$("#tableCos").show();
				break;
			case "Perfumeria":
				$("#per").show();
				$("#tablePer").show();
				break;
			case "Vestimenta":
				$("#ves").show();
				$("#tableVes").show();
				break;
		}
	}
}
//Aparecera el
function FaltanDatos(menu){
	switch(menu){
		case "Pedidos":
			var hay=false;
			for(var i=0;i<colSectores.length;i++){
				if(colSectores[i].Tipo=="1")
					hay=true;
			}
			if(!hay || colProductos.length==0 || colClientes==0)
				return "FaltanDatosPedidos";
			break;
		case "Control":
			var hay=false;
			for(var l=0;l<colSectores.length;l++){
				if(colSectores[l].Tipo==2){
					hay=true;
					break;
				}
			}
			if(!hay || colDisponibles.length==0)
				return "FaltanDatos";
			break;
		case "Transferencias":
			if(colSectores.length<2 || colProductos.length==0)
				return "FaltanDatos";
			break;
		case "PorCategoria":	
			if(colSectores.length==0 || colProductos.length==0)
				return "FaltanDatos";
			break;
		case "PorSector":	
			if(colSectores.length==0 || colProductos.length==0)
				return "FaltanDatos";
			break;
		case "PorFecha":	
			if(colSectores.length==0 || colProductos.length==0)
				return "FaltanDatos";
			break;
		case "PorCantidad":	
			if(colSectores.length==0 || colProductos.length==0)
				return "FaltanDatos";
			break;
	}
	return menu;
}
function OcultarYMostrar(mostrar){
	var menus = $(".container-fluid");
	for(var i=1;i<menus.length;i++)
		menus.eq(i).hide();
	AgregarTablas(mostrar)
	mostrar=FaltanDatos(mostrar);
	$("#"+mostrar).show();
}
function BotonesPrincipales(){
	BorradaMasterDeluxeFinalVersionFantasticEdition();
	OcultarYMostrar($(this).val());
}
function BotonesPrincipaleslista(){
	var mostrar;
	switch($(this).attr("id")){
		case "CatInf":
			mostrar="PorCategoria";
			break;
		case "SecInf":
			mostrar="PorSector";
			break;
		case "SecFec":
			mostrar="PorFecha";
			break;
		case "SecCan":
			mostrar="PorCantidad";
			break;
	}
	OcultarYMostrar(mostrar);
}
function BorradaMasterDeluxeFinalVersionFantasticEdition(){
	$("#SecRes").html("");
	$("#CliRes").html("");
	$("#codRes").html("");
	$("#ConRes").html("");
	$("#MovProRes").html("");
	$("#resPed").html("");
	$("#numSector").val("");
	$("#txtDesSector").val("");
	$("#txtObsSector").val("");
	$("#numTipoSector ").val(1);
	$("#txtCliente").val("");
	$("#numRUT").val("");
	$("#numTelefono").val("");
	$("#txtEmail").val("");
	$("#numCod").val("");
	$("#txtDesCod").val("");
	$("#numCatCod").prop('selectedIndex', 0);
	$("#txtDesCod").val("");
	$("#txtMarCod").val("");
	$("#SecCtrl").prop('selectedIndex', 0);
	$("#SecCod").prop('selectedIndex', 0);
	$("#SecCantidad").val("");
	$("#SecDate").val("");
	$("#numOriSec").prop('selectedIndex', 0);
	$("#txtOriPro").prop('selectedIndex', 0);
	$("#numCanOriPro").val("");
	$("#numDesSec").prop('selectedIndex', 0);
	$("#sltIdCliente").prop('selectedIndex', 0);
	$("#sltSec").prop('selectedIndex', 0);
	$("#sltPro").prop('selectedIndex', 0);
	$("#numCanCli").val("");
	$("#txtCodPed").val("")
}