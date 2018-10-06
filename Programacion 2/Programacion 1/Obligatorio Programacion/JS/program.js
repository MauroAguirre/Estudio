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
	$("#dteSecDate").attr("min",fech);
	//Botones del menu principal
	$(".btnlista").click(BotonesPrincipaleslista);
	$(".btn.btn-primary").click(BotonesPrincipales); //Si el nombre de la clase lleva espacio tenes que poner punto en vez de espacio
	//Botones de los menus
	$("#btnAddSector").click(AgregarSector);
	$("#btnAddCli").click(AgregarClientes);
	$("#btnAltaPro").click(btnAltaProducto);
	$("#btnMovProducto").click(Transferencia);
	$("#btnConAdd").click(ControlProducto);
	$("#btnPedAdd").click(AgregarPedidos);
	//Aceptar la modificacion o cancelar y asegurar borran tambien en el caso del producto
	$("#btnModSector").click(ModificarSector);
	$("#CanSector").click(NoModificarSector);
	$("#btnModPro2").click(AsegurarEliminarProductoConStock);
	$("#btnCanPro2").click(CancelarEliminarProductoConStock);
	$("#btnModCli").click(ModificarCliente);
	$("#btnBorCli").click(NoModificarCliente);
	$("#btnModPro").click(ModificarProducto);
	$("#btnCanPro").click(NoModificarProducto);
	$("#btnConMod").click(ModificarStock);
	$("#btnConCan").click(NoModificarStock);
	//Cambian los productos segun sector elegido
	$("#sltSec").change(ProductosEnSectorElegidoPedidos);
	$("#sltNumOriSec").change(ProductosEnSectorElegidoTransferencia);
	//Se abilita la fecha si el producto elegido tiene vencimiento
	$("#sltSecCod").change(FechaIngresaProducto);
});
//Si el producto elegido se vence se dejara escribir su fecha de vencimiento, pero si no la poce no se dejara ingresarla
function FechaIngresaProducto(){
	if(colDisponibles.length==0)
		return;
	$("#dteSecDate").attr("readonly","readonly");
	var select = $("#sltSecCod :selected").attr("posArreglo");
	switch(colDisponibles[select].Categoria){
		case "Alimentos":
		case "Cosmeticos":
		case "Perfumeria":
			$("#dteSecDate").removeAttr("readonly");
			break;
	}
}
//Se cancelara la modificacion del stock
function NoModificarStock(){
	$("#numSecCantidad").val("");
	$("#dteSecDate").val("");
	$("#btnConMod").hide();
	$("#btnConCan").hide();
	$("#btnConAdd").show();
}
//Se modificaran los datos del stock
function ModificarStock(){
	if(parseInt($("#numSecCantidad").val())<1){
		$("#ConRes").html("Error en la modificacion");
	}
	else{
		var posicion=$(this).attr("pos");
		var cambio=colProductos[posicion].Cantidad-parseInt($("#numSecCantidad").val());
		if(cambio==0){
		}
		else{
			if(cambio>0)
				colProductos[posicion].Cambio="\u25bc"+cambio;
			else
				colProductos[posicion].Cambio="\u25b2"+(cambio*-1);
		}
		colProductos[posicion].FechaVencimiento=$("#dteSecDate").val();
		colProductos[posicion].Cantidad=parseInt($("#numSecCantidad").val());
		$("#ConRes").html("Stock modificado");
		$("#numSecCantidad").val("");
		$("#dteSecDate").val("");
		AgregarTablas("Control");
		$("#btnModPro").hide();
		$("#btnCanPro").hide();
		$("#btnAltaPro").show();
	}
}
function AsegurarEliminarProductoConStock(){
	var posicion=$("#btnModPro2").attr("pos");
	$("#txtDesCod").val("");
	$("#txtMarCod").val("");
	$("#numCod").val("");
	for(var i=0;i<colProductos.length;i++){
		if(colProductos[i].Codigo==colDisponibles[posicion].Codigo){
			colProductos.splice(i,1);
			i--;
		}
	}
	colDisponibles.splice(posicion,1);
	$("#btnModPro2").hide();
	$("#btnCanPro2").hide();
	$("#btnAltaPro").show();
	$("#numCod").removeAttr("readonly");
	$("#txtDesCod").removeAttr("readonly");
	$("#txtMarCod").removeAttr("readonly");
	$("#codRes").html("Producto y stock borrado");
	AgregarTablas("AltadeProducto");
}
function CancelarEliminarProductoConStock(){
	$("#numCod").removeAttr("readonly");
	$("#txtDesCod").removeAttr("readonly");
	$("#txtMarCod").removeAttr("readonly");
	$("#txtDesCod").val("");
	$("#txtMarCod").val("");
	$("#numCod").val("");
	$("#btnModPro2").hide();
	$("#btnCanPro2").hide();
	$("#btnAltaPro").show();
	$("#codRes").html("Accion cancelada");
}
//Se cancelara la modificacion del producto
function NoModificarProducto(){
	$("#numCod").removeAttr("readonly");
	$("#txtDesCod").val("");
	$("#txtMarCod").val("");
	$("#btnModPro").hide();
	$("#btnCanPro").hide();
	$("#btnAltaPro").show();
	$("#codRes").html("Modificado cancelada");
}
//Se modificaran los datos del producto
function ModificarProducto(){
	if($("#txtDesCod").val()!=""){
		$("#numCod").removeAttr("readonly");
		var posicion=$(this).attr("pos");
		colDisponibles[posicion].Descripcion=$("#txtDesCod").val();
		colDisponibles[posicion].Categoria=$("#sltNumCatCod :selected").text();
		colDisponibles[posicion].Marca=$("#txtMarCod").val();
		$("#codRes").html("Producto modificado");
		$("#txtDesCod").val("");
		$("#txtMarCod").val("");
		AgregarTablas("AltadeProducto");
		$("#btnModPro").hide();
		$("#btnCanPro").hide();
		$("#btnAltaPro").show();
	}
	else
		$("#codRes").html("Error en la modificacion");
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
	if($("#txtCliente").val()!="" && $("#numRUT").val()!=""){
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
	else
		$("#CliRes").html("Error en la modificacion");
}
//Se cancelara la modificacion del sector
function NoModificarSector(){
	$("#numSector").removeAttr("readonly");
	$("#txtDesSector").val("");
	$("#txtObsSector").val("");
	$("#btnAddSector").show();
	$("#btnModSector").hide();
	$("#CanSector").hide();
	$("#SecRes").html("Modificacion cancelada");
}
//Se modificaran los datos del sector
function ModificarSector(){
	if($("#txtDesSector").val()!=""){
		$("#numSector").removeAttr("readonly");
		var posicion=$(this).attr("pos");
		colSectores[posicion].Descripcion=$("#txtDesSector").val();
		colSectores[posicion].Tipo=$("#numTipoSector").val();
		colSectores[posicion].Observacion=$("#txtObsSector").val();
		$("#SecRes").html("Sector modificado");
		$("#txtDesSector").val("");
		$("#txtObsSector").val("");
		AgregarTablas("Sectores");
		$("#btnAddSector").show();
	}
	else
		$("#SecRes").html("Error en la modificacion");
}
//Al tocar modificar apareceran los datos de lo elegido y se podran modificar
//Al tocar borrar se borrara lo elegido
function ModificarDeTodo(){
	var tiposec=$(this).attr("tipo");
	var posicion=$(this).attr("pos");
	switch(tiposec){
		case "ModStock":
			$("#btnConAdd").hide();
			$("#btnConMod").show();
			$("#btnConCan").show();
			$("#btnConMod").attr("pos",posicion);
			$("#btnConCan").attr("pos",posicion);
			$("#numSecCantidad").val(colProductos[posicion].Cantidad);
			$("#dteSecDate").val(colProductos[posicion].FechaVencimiento);
			$("#ConRes").html("Modifique el stock");
			break;
		case "BorStock":
			colProductos.splice(posicion,1);
			$("#btnConAdd").show();
			$("#btnConMod").hide();
			$("#ConBor").hide();
			$("#ConRes").html("Stock borrado");
			AgregarTablas("Control");
			break;
		//En caso que haya 1 o mas stock del producto elegido al momento de borrarlo
		//se preguntara denuevo si quiere eliminarlo y se mostrara cuanto va a eliminar
		case "BorDisponibles":
			var hay=false;
			var cantidad=0;
			for(var i=0;i<colProductos.length;i++){
				if(colProductos[i].Codigo==colDisponibles[posicion].Codigo){
					hay = true;
					cantidad+=parseInt(colProductos[i].Cantidad);
				}
			}
			if(hay){
				$("#codRes").html("Se borraran "+cantidad+" productos del stock total");
				$("#txtDesCod").val(colDisponibles[posicion].Descripcion);
				$("#txtMarCod").val(colDisponibles[posicion].Marca);
				$("#numCod").val(colDisponibles[posicion].Codigo);
				var lugar;
				switch(colDisponibles[posicion].Categoria){
					case "Alimentos":
						lugar=1;
						break;
					case "Jugueteria":
						lugar=2;
						break;
					case "Electronica":
						lugar=3;
						break;
					case "Electrodomesticos":
						lugar=4;
						break;
					case "Bebidas":
						lugar=5;
						break;
					case "Bazar":
						lugar=6;
						break;
					case "Cosmeticos":
						lugar=7;
						break;
					case "Perfumeria":
						lugar=8;
						break;
					case "Vestimenta":
						lugar=9;
						break;
				}
				$("#sltNumCatCod").val(lugar);
				$("#numCod").attr("readonly","readonly");
				$("#txtDesCod").attr("readonly","readonly");
				$("#txtMarCod").attr("readonly","readonly");
				$("#btnAltaPro").hide();
				$("#btnModPro").hide();
				$("#btnCanPro").hide();
				$("#btnModPro2").show();
				$("#btnCanPro2").show();
				$("#btnModPro2").attr("pos",posicion);
			}
			else{
				$("#btnModPro2").hide();
				$("#btnCanPro2").hide();
				$("#numCod").removeAttr("readonly");
				$("#txtDesCod").removeAttr("readonly");
				$("#txtMarCod").removeAttr("readonly");
				$("#numCod").val("");
				colDisponibles.splice(posicion,1);
				AgregarTablas("AltadeProducto");
				$("#btnAltaPro").show();
				$("#btnModPro").hide();
				$("#btnCanPro").hide();
				$("#codRes").html("Producto borrado");
			}	
			break;
		case "ModDisponibles":
			$("#numCod").attr("readonly","reandoly");
			$("#numCod").val("");
			$("#btnAltaPro").hide();
			$("#btnModPro").show();
			$("#btnCanPro").show();
			$("#btnModPro2").hide();
			$("#btnCanPro2").hide();
			var lugar;
			switch(colDisponibles[posicion].Categoria){
				case "Alimentos":
					lugar=1;
					break;
				case "Jugueteria":
					lugar=2;
					break;
				case "Electronica":
					lugar=3;
					break;
				case "Electrodomesticos":
					lugar=4;
					break;
				case "Bebidas":
					lugar=5;
					break;
				case "Bazar":
					lugar=6;
					break;
				case "Cosmeticos":
					lugar=7;
					break;
				case "Perfumeria":
					lugar=8;
					break;
				case "Vestimenta":
					lugar=9;
					break;
			}
			$("#txtDesCod").val(colDisponibles[posicion].Descripcion);
			$("#sltNumCatCod").val(lugar);
			$("#txtMarCod").val(colDisponibles[posicion].Marca);
			$("#btnModPro").attr("pos",posicion);
			$("#btnCanPro").attr("pos",posicion);
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
			var hay = false;
			for(var i=0;i<colProductos.length;i++){
				if(colProductos[i].Sector==colSectores[posicion].Numero){
						hay=true;
						break;
				}
			}
			if(hay)
				$("#SecRes").html("Error, existe stock en el sector");
			else{
				colSectores.splice(posicion,1);
				AgregarTablas("Sectores");
				$("#btnAddSector").show();
				$("#btnModSector").hide();
				$("#CanSector").hide();
				$("#SecRes").html("Sector borrado");
			}
			break;
		case "btnModSectores":
			$("#numSector").attr("readonly","reandoly");
			$("#btnAddSector").hide();
			$("#btnModSector").show();
			$("#CanSector").show();
			$("#numTipoSector").val(colSectores[posicion].Tipo);
			$("#txtDesSector").val(colSectores[posicion].Descripcion);
			$("#txtObsSector").val(colSectores[posicion].Observacion);
			$("#btnModSector").attr("pos",posicion);
			$("#CanSector").attr("pos",posicion);
			$("#SecRes").html("Modifique el sector");
			break;
	}
	
}
//Se agregaran los diferentes pedidos, anotando sus caracteristicas
function AgregarPedidos(){
	var wopa=$("#sltPro :selected").val();
	var wopa2=$("#numCanCli").val();
	var wopa3=$("#numCanCli").val();
	var wopa4=$("#numCanCli").val();
	var wopa5=colProductos[$("#sltPro :selected").val()].Cantidad;
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
		if(colProductos[i].Codigo==colProductos[$("#sltTxtOriPro :selected").val()].Codigo && colProductos[i].FechaVencimiento==colProductos[$("#sltTxtOriPro :selected").val()].FechaVencimiento && colProductos[i].Sector==colSectores[$("#sltNumDesSec :selected").val()].Numero)
			return i;
	}
	return -1;
}
//Transfiere productos de sector a sector, si el producto no existe en el sector elegido lo agrega de contrario solo aumenta su cantidad
//El producto a transferir se quedar sin stock este desaparecera del sector de contrario solo disminuira su cantidad
function Transferencia(){
	if($("#sltTxtOriPro :selected").val()==-1){
		$("#MovProRes").html("Error");
		return;
	}
	if($("#sltNumOriSec :selected").val() == $("#sltNumDesSec :selected").val() || colProductos[$("#sltTxtOriPro :selected").val()].Cantidad < $("#sltNumCanOriPro").val() || $("#sltTxtOriPro :selected").val() == -1 || $("#sltNumCanOriPro").val() == "" || $("#sltNumCanOriPro").val() == 0){
		$("#MovProRes").html("Error");
		return;
	}
	var origen=$("#sltTxtOriPro :selected").val();
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
			Sector:colSectores[$("#sltNumDesSec :selected").val()].Numero,
			Cantidad:parseInt($("#sltNumCanOriPro").val()),
			Fecha:fecha,
			FechaVencimiento:colProductos[origen].FechaVencimiento,
			Cambio:"\u25b2"+parseInt($("#sltNumCanOriPro").val()),
		};
		if(colProductos[origen].Cantidad==$("#sltNumCanOriPro").val())
			colProductos.splice(origen,1);
		else{
			colProductos[origen].Cantidad-=parseInt($("#sltNumCanOriPro").val());
			colProductos[origen].Cambio="\u25bc"+$("#sltNumCanOriPro").val();
		}
		ColocarProductoEnOrden(producto,colSectores[$("#sltNumDesSec :selected").val()].Numero);
	}
	else{
		colProductos[destino].Fecha=fecha;
		if(colProductos[origen].Cantidad==parseInt($("#sltNumCanOriPro").val())){
			colProductos[destino].Cantidad+=parseInt($("#sltNumCanOriPro").val());
			colProductos[destino].Cambio="\u25b2"+$("#sltNumCanOriPro").val();
			colProductos.splice(origen,1);
		}
		else{
			colProductos[destino].Cantidad+=parseInt($("#sltNumCanOriPro").val());
			colProductos[destino].Cambio="\u25b2"+parseInt($("#sltNumCanOriPro").val());
			colProductos[origen].Cantidad-=parseInt($("#sltNumCanOriPro").val());
			colProductos[origen].Cambio="\u25bc"+parseInt($("#sltNumCanOriPro").val());
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
		if(colProductos[l].Sector == $("#sltSecCtrl :selected").attr("Sector") && colProductos[l].Codigo ==$("#sltSecCod :selected").attr("codigo") && colProductos[l].FechaVencimiento == $("#dteSecDate").val())
			return l;
	}
	return -1;
}
//Agrega el producto en el stock, si ya esta el producto en el sector con la fecha correspondiente solo aumenta el sector sino lo agrega
function ControlProducto(){
	if($("#numSecCantidad").val()<1 || $("#numSecCantidad").val()==""){
		$("#ConRes").html("Error en el control");
		return;
	}
	var fecha = new Date().toJSON().slice(0,10).replace(/-/g,'/');
	var check=CheckControl();
	var posicion=$("#sltSecCod :selected").attr("posArreglo");
	if(check!=-1){
		colProductos[check].Cantidad+=parseInt($("#numSecCantidad").val());
		colProductos[check].Fecha=fecha;
		colProductos[check].Cambio="\u25b2"+parseInt($("#numSecCantidad").val());
	}
	else{	
		var producto={
			Codigo:colDisponibles[posicion].Codigo,
			Sector:$("#sltSecCtrl :selected").attr("Sector"),
			Cantidad:parseInt($("#numSecCantidad").val()),
			Fecha:fecha,
			FechaVencimiento:$("#dteSecDate").val(),
			Cambio:0,
		};
		ColocarProductoEnOrden(producto,$("#sltSecCtrl :selected").attr("Sector"));
	}
	$("#numSecCantidad").val("");
	$("#dteSecDate").val("");
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
function btnAltaProducto(){
	if($("#numCod").val()==""||$("#txtDesCod").val()==""){
		$("#codRes").html("Error");
		return;
	}
	if(CheckDisponibles()){
		$("#codRes").html("Producto Ingresado");
		var producto = {
			Codigo:$("#numCod").val(),
			Descripcion:$("#txtDesCod").val(),
			Categoria:$("#sltNumCatCod :selected").text(),
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
	$("#sltTxtOriPro").html("");
	var lugar;
	for(var i=0;i<colProductos.length;i++){
		for(var l=0;l<colDisponibles.length;l++){
			if(colDisponibles[l].Codigo==colProductos[i].Codigo){
				lugar=l;
				break;
			}
		}
		if(colProductos[i].Sector==colSectores[$("#sltNumOriSec :selected").val()].Numero){
			$("#sltTxtOriPro").append('<option value='+i+'>'+colProductos[i].Codigo+":"+colDisponibles[lugar].Descripcion+":"+colProductos[i].FechaVencimiento+'</option>');
			hay=true;
		}
	}
	if(!hay)
		$("#sltTxtOriPro").append('<option value='+-1+'>'+"No hay productos"+'</option>');
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
			$("#tblCliCol").hide();
			$("#btnAddCli").show();
			$("#btnModCli").hide();
			$("#btnBorCli").hide();
			if(colClientes.length>0)
				$("#tblCliCol").show();
			$("#tblBodCliCol").html("");
			for(var i=0;i<colClientes.length;i++)
				$("#tblBodCliCol").append('<tr><td>'+colClientes[i].Id+'</td><td>'+colClientes[i].Nombre+'</td><td>'+colClientes[i].RUT+'</td><td>'+colClientes[i].Telefono+'</td><td>'+colClientes[i].Email+'</td><td><input type="button" value="Modificar" pos="'+i+'" class="btn btn-info" tipo="ModClientes"/></td><td><input type="button" value="Borrar" pos="'+i+'"class="btn btn-info" tipo="BorClientes"/></td></tr>')
			$(".btn.btn-info").click(ModificarDeTodo);
			break;
		case "Sectores":
			$("#numSector").removeAttr("readonly");
			$("#tblSecCol").hide();
			$("#btnAddSector").show();
			$("#btnModSector").hide();
			$("#CanSector").hide();
			if(colSectores.length>0)
				$("#tblSecCol").show();
			$("#tblBodSecCol").html("");
			for(var l=0;l<colSectores.length;l++)
				$("#tblBodSecCol").append('<tr><td>'+colSectores[l].Numero+'</td><td>'+colSectores[l].Tipo+'</td><td>'+colSectores[l].Descripcion+'</td><td>'+colSectores[l].Observacion+'</td><td><input type="button" value="Modificar" pos="'+l+'" class="btn btn-info" tipo="btnModSectores"/></td><td><input type="button" value="Borrar" pos="'+l+'"class="btn btn-info" tipo="BorSectores"/></td></tr>');
			$(".btn.btn-info").click(ModificarDeTodo);
			break;
		case "Pedidos":
			$("#btnPedAdd").show();
			$("#btnPedMod").hide();
			$("#btnPedCan").hide();
			$("#tblPed").hide();
			if(colPedidos.length>0)
				$("#tblPed").show();
			$("#tblBodPed").html("");
			for(var i=0;i<colPedidos.length;i++)
				$("#tblBodPed").append('<tr><td>'+colPedidos[i].Pedido+'</td><td>'+colPedidos[i].Codigo+'</td><td>'+colPedidos[i].Cliente+'</td><td>'+colPedidos[i].Producto+'</td><td>'+colPedidos[i].Cantidad+'</td><td>'+colPedidos[i].Fecha+'</td></tr>');
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
			$("#txtDesCod").removeAttr("readonly");
			$("#txtMarCod").removeAttr("readonly");
			$("#btnAltaPro").show();
			$("#btnModPro").hide();
			$("#btnCanPro").hide();
			$("#btnModPro2").hide();
			$("#btnCanPro2").hide();
			$("#tblDisCol").hide();
			if(colDisponibles.length>0)
				$("#tblDisCol").show();
			$("#tblBodDisCol").html("");
			for(var i=0;i<colDisponibles.length;i++)
				$("#tblBodDisCol").append('<tr><td>'+colDisponibles[i].Codigo+'</td><td>'+colDisponibles[i].Descripcion+'</td><td>'+colDisponibles[i].Categoria+'</td><td>'+colDisponibles[i].Marca+'</td><td><input type="button" value="Modificar" pos="'+i+'" class="btn btn-info" tipo="ModDisponibles"/></td><td><input type="button" value="Borrar" pos="'+i+'" class="btn btn-info" tipo="BorDisponibles"/></td></tr>');
			$(".btn.btn-info").click(ModificarDeTodo);
			break;
		case "Transferencias":
			$("#sltNumOriSec").html("");
			$("#sltTxtOriPro").html("");
			$("#sltNumDesSec").html("");
			for(var i=0;i<colSectores.length;i++){
				$("#sltNumOriSec").append('<option value='+i+'>'+colSectores[i].Numero+":"+colSectores[i].Descripcion+'</option>');
				$("#sltNumDesSec").append('<option value='+i+'>'+colSectores[i].Numero+":"+colSectores[i].Descripcion+'</option>');
			}
			ProductosEnSectorElegidoTransferencia();
			break;
		case "Control":
			$("#btnConAdd").show();
			$("#btnConMod").hide();
			$("#btnConCan").hide();
			$("#tblTbeCon").hide();
			if(colProductos.length>0)
				$("#tblTbeCon").show();
			$("#sltSecCtrl").html("");
			$("#sltSecCod").html("");
			for(var i=0;i<colSectores.length;i++){
				if(colSectores[i].Tipo=="2")
					$("#sltSecCtrl").append('<option Sector='+colSectores[i].Numero+'>'+colSectores[i].Numero+":"+colSectores[i].Descripcion+'</option>');
			}
			for(var i=0;i<colDisponibles.length;i++)
				$("#sltSecCod").append('<option codigo='+colDisponibles[i].Codigo+' posArreglo='+i+'>'+colDisponibles[i].Codigo+":"+colDisponibles[i].Descripcion+'</option>');		
			FechaIngresaProducto();
			$("#tblBodTbeConBod").html("");
			var lugar;
			for(var i=0;i<colProductos.length;i++){
				for(var l=0;l<colDisponibles.length;l++){
					if(colProductos[i].Codigo==colDisponibles[l].Codigo){
						lugar=l;
						break;
					}
				}
				$("#tblBodTbeConBod").append('<tr><td>'+colProductos[i].Sector+'</td><td>'+colProductos[i].Codigo+'</td><td>'+colDisponibles[lugar].Descripcion+'</td><td>'+colProductos[i].Fecha+'</td><td>'+colProductos[i].FechaVencimiento+'</td><td>'+colProductos[i].Cantidad+'</td><td>'+colProductos[i].Cambio+'</td><td><input type="button" value="Modificar" pos="'+i+'" class="btn btn-info" tipo="ModStock"/></td><td><input type="button" value="Borrar" pos="'+i+'" class="btn btn-info" tipo="BorStock"/></td></tr>');
			}
			$(".btn.btn-info").click(ModificarDeTodo);
			break;
		case "PorCategoria":
			MostrarCategorias();
			$("#tblBodTableAli").html("");
			$("#tblBodTableJug").html("");
			$("#tblBodTablenica").html("");
			$("#tblBodTableticos").html("");
			$("#tblBodTableBeb").html("");
			$("#tblBodTableBaz").html("");
			$("#tblBodTableCos").html("");
			$("#tblBodTablePer").html("");
			$("#tblBodTableVes").html("");
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
						$("#tblBodTableAli").append('<tr><td>'+colProductos[l].Codigo+'</td><td>'+colDisponibles[lugar].Descripcion+'</td><td>'+colDisponibles[lugar].Marca+'</td><td>'+colProductos[l].Fecha+'</td><td>'+colProductos[l].FechaVencimiento+'</td><td>'+colProductos[l].Cantidad+'</td><td>'+colProductos[l].Sector+'</td></tr>');
						break;
					case "Jugueteria":
						$("#tblBodTableJug").append('<tr><td>'+colProductos[l].Codigo+'</td><td>'+colDisponibles[lugar].Descripcion+'</td><td>'+colDisponibles[lugar].Marca+'</td><td>'+colProductos[l].Fecha+'</td><td>'+colProductos[l].FechaVencimiento+'</td><td>'+colProductos[l].Cantidad+'</td><td>'+colProductos[l].Sector+'</td></tr>');
						break;
					case "Electronica":
						$("#tblBodTablenica").append('<tr><td>'+colProductos[l].Codigo+'</td><td>'+colDisponibles[lugar].Descripcion+'</td><td>'+colDisponibles[lugar].Marca+'</td><td>'+colProductos[l].Fecha+'</td><td>'+colProductos[l].FechaVencimiento+'</td><td>'+colProductos[l].Cantidad+'</td><td>'+colProductos[l].Sector+'</td></tr>');
						break;
					case "Electrodomesticos":
						$("#tblBodTableticos").append('<tr><td>'+colProductos[l].Codigo+'</td><td>'+colDisponibles[lugar].Descripcion+'</td><td>'+colDisponibles[lugar].Marca+'</td><td>'+colProductos[l].Fecha+'</td><td>'+colProductos[l].FechaVencimiento+'</td><td>'+colProductos[l].Cantidad+'</td><td>'+colProductos[l].Sector+'</td></tr>');
						break;
					case "Bebidas":
						$("#tblBodTableBeb").append('<tr><td>'+colProductos[l].Codigo+'</td><td>'+colDisponibles[lugar].Descripcion+'</td><td>'+colDisponibles[lugar].Marca+'</td><td>'+colProductos[l].Fecha+'</td><td>'+colProductos[l].FechaVencimiento+'</td><td>'+colProductos[l].Cantidad+'</td><td>'+colProductos[l].Sector+'</td></tr>');
						break;
					case "Bazar":
						$("#tblBodTableBaz").append('<tr><td>'+colProductos[l].Codigo+'</td><td>'+colDisponibles[lugar].Descripcion+'</td><td>'+colDisponibles[lugar].Marca+'</td><td>'+colProductos[l].Fecha+'</td><td>'+colProductos[l].FechaVencimiento+'</td><td>'+colProductos[l].Cantidad+'</td><td>'+colProductos[l].Sector+'</td></tr>');
						break;
					case "Cosmeticos":
						$("#tblBodTableCos").append('<tr><td>'+colProductos[l].Codigo+'</td><td>'+colDisponibles[lugar].Descripcion+'</td><td>'+colDisponibles[lugar].Marca+'</td><td>'+colProductos[l].Fecha+'</td><td>'+colProductos[l].FechaVencimiento+'</td><td>'+colProductos[l].Cantidad+'</td><td>'+colProductos[l].Sector+'</td></tr>');
						break;
					case "Perfumeria":
						$("#tblBodTablePer").append('<tr><td>'+colProductos[l].Codigo+'</td><td>'+colDisponibles[lugar].Descripcion+'</td><td>'+colDisponibles[lugar].Marca+'</td><td>'+colProductos[l].Fecha+'</td><td>'+colProductos[l].FechaVencimiento+'</td><td>'+colProductos[l].Cantidad+'</td><td>'+colProductos[l].Sector+'</td></tr>');
						break;
					case "Vestimenta":
						$("#tblBodTableVes").append('<tr><td>'+colProductos[l].Codigo+'</td><td>'+colDisponibles[lugar].Descripcion+'</td><td>'+colDisponibles[lugar].Marca+'</td><td>'+colProductos[l].Fecha+'</td><td>'+colProductos[l].FechaVencimiento+'</td><td>'+colProductos[l].Cantidad+'</td><td>'+colProductos[l].Sector+'</td></tr>');
						break;
				}
			}
			break;
		case "PorSector":
			$("#tblBodSec").html("");
			for(var l=0;l<colProductos.length;l++){
				var lugar;
				for(var i=0;i<colDisponibles.length;i++){
					if(colDisponibles[i].Codigo==colProductos[l].Codigo){
						lugar=i;
						break;
					}
				}
				$("#tblBodSec").append('<tr><td>'+colProductos[l].Codigo+'</td><td>'+colDisponibles[lugar].Descripcion+'</td><td>'+colDisponibles[lugar].Marca+'</td><td>'+colProductos[l].Fecha+'</td><td>'+colProductos[l].FechaVencimiento+'</td><td>'+colProductos[l].Cantidad+'</td><td>'+colDisponibles[lugar].Categoria+'</td><td>'+colProductos[l].Sector+'</td></tr>');			
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
			$("#tblBodFec").html("");
			for(var i=0;i<ordenado.length;i++)
				$("#tblBodFec").append('<tr><td>'+ordenado[i].Codigo+'</td><td>'+ordenado[i].Descripcion+'</td><td>'+ordenado[i].Marca+'</td><td>'+ordenado[i].Cantidad+'</td><td>'+ordenado[i].Categoria+'</td><td>'+ordenado[i].Sector+'</td><td>'+ordenado[i].Fecha+'</td><td>'+ordenado[i].FechaVencimiento+'</td></tr>');
			break;
		case "PorCantidad":
			$("#tblBodMayor").html("");
			$("#tblBodMenor").html("");
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
					$("#tblBodMayor").append('<tr><td>'+mayores[mayor].Codigo+'</td><td>'+mayores[mayor].Descripcion+'</td><td>'+mayores[mayor].Marca+'</td><td>'+mayores[mayor].Cantidad+'</td><td>'+mayores[mayor].Categoria+'</td><td>'+mayores[mayor].Sector+'</td><td>'+mayores[mayor].Fecha+'</td><td>'+mayores[mayor].FechaVencimiento+'</td></tr>');
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
					$("#tblBodMenor").append('<tr><td>'+menores[menor].Codigo+'</td><td>'+menores[menor].Descripcion+'</td><td>'+menores[menor].Marca+'</td><td>'+menores[menor].Cantidad+'</td><td>'+menores[menor].Categoria+'</td><td>'+menores[menor].Sector+'</td><td>'+menores[menor].Fecha+'</td><td>'+menores[menor].FechaVencimiento+'</td></tr>');
					menores.splice(menor,1);
				}
			}
			break;
	}
}
//Muestra las categorias si hay stock con esa categoria
function MostrarCategorias(){
	$("#ali").hide();
	$("#tblTableAli").hide();
	$("#jug").hide();
	$("#tblTableJug").hide();
	$("#nica").hide();
	$("#tblTablenica").hide();
	$("#ticos").hide();
	$("#tblTableticos").hide();
	$("#beb").hide();
	$("#tblTableBeb").hide();
	$("#baz").hide();
	$("#tblTableBaz").hide();
	$("#cos").hide();
	$("#tblTableCos").hide();
	$("#per").hide();
	$("#tblTablePer").hide();
	$("#ves").hide();
	$("#tblTableVes").hide();
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
				$("#tblTableAli").show();
				break;
			case "Jugueteria":
				$("#jug").show();
				$("#tblTableJug").show();
				break;
			case "Electronica":
				$("#nica").show();
				$("#tblTablenica").show();
				break;
			case "Electrodomesticos":
				$("#ticos").show();
				$("#tblTableticos").show();
				break;
			case "Bebidas":
				$("#beb").show();
				$("#tblTableBeb").show();
				break;
			case "Bazar":
				$("#baz").show();
				$("#tblTableBaz").show();
				break;
			case "Cosmeticos":
				$("#cos").show();
				$("#tblTableCos").show();
				break;
			case "Perfumeria":
				$("#per").show();
				$("#tblTablePer").show();
				break;
			case "Vestimenta":
				$("#ves").show();
				$("#tblTableVes").show();
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
			var productosEnSector1 = false;
			for(var i=0;i<colProductos.length;i++){
				for(var l=0;l<colSectores.length;l++){
					if(colSectores[l].Numero==colProductos[i].Sector&&colSectores[l].Tipo=="1"){
						productosEnSector1=true;
						break;
					}
				}	
			}
			if(!hay || colProductos.length==0 || colClientes==0 || !productosEnSector1)
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
		case "SltCatInf":
			mostrar="PorCategoria";
			break;
		case "SltSecInf":
			mostrar="PorSector";
			break;
		case "SltSecFec":
			mostrar="PorFecha";
			break;
		case "SltSecCan":
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
	$("#sltNumCatCod").prop('selectedIndex', 0);
	$("#txtDesCod").val("");
	$("#txtMarCod").val("");
	$("#sltSecCtrl").prop('selectedIndex', 0);
	$("#sltSecCod").prop('selectedIndex', 0);
	$("#numSecCantidad").val("");
	$("#dteSecDate").val("");
	$("#sltNumOriSec").prop('selectedIndex', 0);
	$("#sltTxtOriPro").prop('selectedIndex', 0);
	$("#sltNumCanOriPro").val("");
	$("#sltNumDesSec").prop('selectedIndex', 0);
	$("#sltIdCliente").prop('selectedIndex', 0);
	$("#sltSec").prop('selectedIndex', 0);
	$("#sltPro").prop('selectedIndex', 0);
	$("#numCanCli").val("");
	$("#txtCodPed").val("")
}