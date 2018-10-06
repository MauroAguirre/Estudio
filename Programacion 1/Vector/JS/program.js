window.onload=Load;
function Load(){
	document.getElementById("btnIngresar").onclick=AddContactos;
}
var ColContactos=[];
var ColCiudades = [{nombre:"Maldonado",codigo:20000},
{nombre:"Piriapolis",codigo:20200,tipo:"Ciudad"},
{nombre:"San Carlos",codigo:20400}];
function AddContactos(){
	var nombre=document.getElementById("txtNombre").value;
	var apellido=document.getElementById("txtApellido").value;
	var tel=document.getElementById("txtEmail").value;
	var email=document.getElementById("txtTelefono").value;
	var	contactoNuevo={
		nombreContacto:nombre,
		apellidoContacto:apellido,
		telefonoContacto:tel,
		emailContacto:email,
	};
	ColContactos.push(contactoNuevo);
	MostrarContactos();
}
function MostrarContactos(){
	var table=document.getElementById("lstContactos");
	for(var j=0;j<ColContactos.length;j++){
		//alert(ColContactos[j].emailContacto);
		var ob=ColContactos[j];
		table.innerHTML +='<tr>'
		+'<td>'
		+ob.nombreContacto
		+'</td>'
		+'<td>'
		+ob.apellidoContacto
		+'</td>'
		+'<td>'
		+ob.telefonoContacto
		+'</td>'
		+'<td>'
		+ob.emailContacto
		+'</td>'
		+'</tr>';
	}
}