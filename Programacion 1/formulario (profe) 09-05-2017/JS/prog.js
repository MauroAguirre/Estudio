window.onload = Load; 

var colNombres = [];
var colClaves = [];

function Load()
{
	document.getElementById('txtNombre').onblur = validarNombre;
	document.getElementById('txtClave').onblur = validarClave;
	document.getElementById('btnRegistrar').onclick = guardarUsuario;
}

function guardarUsuario()
{
	var nombre = document.getElementById('txtNombre').value;
	var clave = document.getElementById('txtClave').value;
	
	if(validarNombreClave(nombre,clave) == true)
	{
		colNombres.push(nombre);
		colClaves.push(	clave);	
		cleanAllInputs();
	}
}

function validarNombreClave(nombre, clave)
{
	var elNombreEsValido = validarNombre(nombre);
	var laClaveEsValida = validarClave(clave,nombre);	
	
	return elNombreEsValido && laClaveEsValida;
}

function validarNombre(nombre)
{	
	var rest = true;
	if(nombre.length > 15)
	{
		rest = false;
		setError('lblErrorNombre', 'No puede superar los 15 caracteres');
	}
	else
	{
		if(existNombreInCol(nombre) == true)
		{
			rest = false;
			setError('lblErrorNombre', 'El nombre ya fue ingresado');
		}
		else
		{
			setError('lblErrorNombre', '');
		}
	}	
	return rest;
}

function validarClave(clave, nombre)
{		
	var rest = true;
	if(clave.length < 4)
	{
		rest = false;
		setError('lblErrorClave', 'Debe ser mayor a 4');
	}
	else
	{
		if(clave == nombre)
		{
			rest = false;
			setError('lblErrorClave', 'Debe ser distinta al nombre');
		}
		else
		{
			setError('lblErrorClave', '');
		}
	}	
	return rest;
	
}


function setError(id, msg)
{
	document.getElementById(id).textContent = msg;
}


function existNombreInCol(nombre)
{
	var respuesta = false;
	for(var i = 0; i<colNombres.length; i++)
	{
		if(colNombres[i] == nombre)
		{
			respuesta = true;
		}		
	}
	return respuesta;
}

function cleanAllInputs()
{
	document.getElementById('txtNombre').value = '';
	document.getElementById('txtClave').value = '';	
}






