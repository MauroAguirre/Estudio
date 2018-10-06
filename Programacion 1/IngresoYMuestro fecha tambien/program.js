window.onload = Load;

var colCli = [];
var nuCliNuevo = 1;

function Load()
{
	mostrarInicio();
	cancelarEdit();
	document.getElementById("btnAdd").onclick = add;
	document.getElementById("btnInicio").onclick = mostrarInicio;
	document.getElementById("btnClientes").onclick = mostrarClientes;
	document.getElementById("btnCancelar").onclick = cancelarEdit;
	document.getElementById("btnConfEditar").onclick = confirmarEditar;
}

function mostrarInicio()
{
	$("#Clientes").hide();
	$("#Inicio").show();
	
}

function mostrarClientes()
{
	$("#Clientes").show();
	$("#Inicio").hide();
	
}


function add()
{
	var nuevoCli = {};
	nuevoCli.nombre = document.getElementById("txtNombre").value;
	nuevoCli.rut = document.getElementById("txtRut").value;
	nuevoCli.num = nuCliNuevo;
	
	
	var fechaDeHoy = new Date(); //Crear una variable de tipo fecha con los valores del momento
	//Ahora la variable fechaDeHoy es de tipo fecha, por lo tanto
	//podemos utilizar las siguientes funciones;	
	var dia = fechaDeHoy.getDay();
	var mes = fechaDeHoy.getMonth()+1; //Enero es 0
	var anio = fechaDeHoy.getFullYear();
	//Las unciones son utilizadas para tener un formato de fecha más
	//legible en vez del formato por defecto del new Date(); 
	
	nuevoCli.fechaIngreso = dia + "/" + mes + "/" +anio;
	

	colCli.push(nuevoCli);
	
	
	
	nuCliNuevo++; // nuCliNuevo = nuCliNuevo+1;
	
	mostrar();
	limpiar();
}

function mostrar()
{
	var cuerpoTabla = document.getElementById("datosCliente");
	cuerpoTabla.innerHTML="";
	for(var x = 0; x<colCli.length; x++)
	{
		cuerpoTabla.innerHTML += "<tr style='border: 1px solid black' ><td style='border: 1px solid black'><input  type='button' class='btnBorrar' value='Borrar' numCliente="+x+" /><input  type='button' class='btnEditar' value='Editar' numCliente="+x+" /></td><td style='border: 1px solid black'>"+colCli[x].num+"</td><td style='border: 1px solid black'>"+colCli[x].nombre+"</td><td style='border: 1px solid black'>"+colCli[x].rut+"</td><td style='border: 1px solid black'>"+colCli[x].fechaIngreso+"</td></tr>"
	}
	
	addEvetClickBtn();
}

function addEvetClickBtn()
{
	var botonesBorrar = document.getElementsByClassName("btnBorrar");
	for(var i = 0; i<botonesBorrar.length; i++)
	{
		botonesBorrar[i].onclick = borrar;
	}
	
	var botonesModificar = document.getElementsByClassName("btnEditar");
	for(var i = 0; i<botonesModificar.length; i++)
	{
		botonesModificar[i].onclick = editar;
	}
}

function editar()
{
	
	var pos = this.getAttribute("numCliente");
	cambiarEdit();
	$("#txtNombre").val(colCli[pos].nombre);
	$("#txtRut").val(colCli[pos].rut);
	$("#nroCliente").val(colCli[pos].num);
}

function cambiarEdit()
{
	$("#editar").show();
	$("#ingreso").hide();
	limpiar();	
}

function cancelarEdit()
{
	$("#ingreso").show();
	$("#editar").hide();
	limpiar();
}

function confirmarEditar()
{
	
	var nuevoNombre = $("#txtNombre").val();
	var nuevoRut = $("#txtRut").val();
	var numCliEditar = $("#nroCliente").val();
	
	for(var i= 0; i<colCli.length; i++)
	{
		if(colCli[i].num == numCliEditar)
		{
			colCli[i].nombre = nuevoNombre;
			colCli[i].rut = nuevoRut;
			
		}		
	}	
	
	mostrar();
	cancelarEdit();
	
}

function limpiar()
{
	document.getElementById("txtNombre").value = "";
	document.getElementById("txtRut").value = "";
	document.getElementById("nroCliente").value = "";
}

function borrar()
{
	var pos = this.getAttribute("numCliente");
	//for(var x = 0; x<colCli.length; x++)
	//{
	//	if(colCli[x].num == numCli)
	//	{
	//		colCli.splice(x,1);
	//	}
	//}
	colCli.splice(pos,1);
	
	mostrar();
}





