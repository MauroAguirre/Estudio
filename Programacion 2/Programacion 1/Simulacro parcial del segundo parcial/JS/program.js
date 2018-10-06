//una tienda de ropa desea una pantalla que le permita registrar sus productos
//cada producto maneja un codigo unico, talle, color y descripcion
//debe controlarse: que el codigo del producto no haya sido registrado y que no contenga asteriscos - $ y +
//el talle debe ser ingresado con un select que contenga los siguientes valores: xl l m s.
//de todas formas debe validarse que ingreso corresponda a uno de estos valores 
//la descripcion no puede superrar 200 caracteres

////En base a lo realizado en el ejercicio anterior crear una funcion que muestre los productos ordenados de forma decendente segun el codigo
var productos=[];
$(document).ready(function(){
	$("#btnIngresar").click(Agregar);
	$("#btnMostrar").click(MostrarOrdenado);
});
function Verificar(){
	var codigo=$("#txtCodigo").val();
	var descripcion=$("#txtDescripcion").val();
	for(var i=0;i<codigo.length;i++){
		if(codigo[i]=="*"||codigo[i]=="-"||codigo[i]=="$"||codigo[i]=="+")
			return false;
	}
	for(var i=0;i<productos.length;i++){
		if(productos[i].Codigo==$("#txtCodigo").val())
			return false;
	}
	if(descripcion.length>200)
		return false;
	return true;
}
function Agregar(){
	if(Verificar()){
		var talle;
		switch($("#sltTalle :selected").val()){
			case "1":
				talle="XL";
				break;
			case "2":
				talle="L";
				break;
			case "3":
				talle="M";
				break;
			case "4":
				talle="S";
				break;
		}
		var producto={
			Codigo:$("#txtCodigo").val(),
			Talle:talle,
			Color:$("#txtColor").val(),
			Descripcion:$("#txtDescripcion").val(),
		}
		productos.push(producto);
		$("#lblRespuesta").html("Producto ingresado");
		$("#txtCodigo").val("");
		$("#txtColor").val("");
		$("#txtDescripcion").val("");
	}
	else{
		$("#lblRespuesta").html("Error");
	}
}
function Ordenar(a,b){
	if(a.Codigo>b.Codigo)
		return 1;
	else{
		if(a.Codigo<b.Codigo)
			return -1;
		else
			return 0;
	}
}
function MostrarOrdenado(){
	var ordenados=productos;
	ordenados.sort(Ordenar);
	$("#lbl2").html("");
	for(var i=0;i<ordenados.length;i++){
		$("#lbl2").append("Codigo: "+ordenados[i].Codigo+'<br>');
		$("#lbl2").append("Talle: "+ordenados[i].Talle+'<br>');
		$("#lbl2").append("Color: "+ordenados[i].Color+'<br>');
		$("#lbl2").append("Descripcion: "+ordenados[i].Descripcion+'<br>');
	}
}