//los array asociativos en vez de estar asignado las partes con numeros , estan asignados con textos
//se pueden llamar array o objetos
var arr_asociativo =
{
	'clave1':'hola',
	'clave2':'mundo',
	'pepe':24
};
/*
document.write(arr_asociativo['clave1']+'<br>');	
document.write(arr_asociativo.pepe);*/
arr_asociativo.clave3="prueba";		// para agregar valores a un array asociativo
var wopa="nombre";	
arr_asociativo[wopa]="Pepito"		// otra manera de agregar
for(item in arr_asociativo)		// para recorrer un arrey asociativo
{
	document.write(arr_asociativo[item]+'<br>');
}
var persona=
{
	nombre:"Pepe",
	apellido:"Perez",
	cedula:"00000000"
}
persona.Email="noseque@gmail.com";
document.write("Datos de una persona"+'<br>'+"Nombre: "+persona.nombre+'<br>'+"Apellido: "+persona.apellido+'<br>'+"Cedula: "+persona.cedula+'<br>'+"Email: "+persona.Email+'<br>');
for(p in persona){		// esta manera es mejor
	document.write(p+": "+ persona[p]+'<br>');
}