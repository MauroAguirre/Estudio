window.onload = Load;

var colnotas=[];

function Load(){
	document.getElementById("btnAdd").onclick = IngresarNota;
}
function IngresarNota(){
	if(document.getElementById("numNumero").value!=""){
		var nota = document.getElementById("numNumero");
		colnotas.push(nota.value);
		document.getElementById("numNumero").value="";
	}
	else
		DarResultados();
}
function DarResultados(){
	var perdio=0;
	var normal=0;
	var bien=0;
	var grande=0;
    var chico=0;
	var promedio=0;
	for(var i=0;i<colnotas.length;i++){
		if(i==0){
			grande=colnotas[i];
			chico=colnotas[i];
		}
		if(colnotas[i]>grande)
			grande=colnotas[i];
		if(colnotas[i]<chico)
			chico=colnotas[i];
		promedio+=parseInt(colnotas[i]);
		if(colnotas[i]<70){
			perdio++;
			}
		else{
			if(colnotas[i]>90)
				bien++;
			else
				normal++;
		}
	}
	document.write("Los reprobados son: "+perdio+'<br>');
	document.write("Los que pasaron fueron: "+normal+'<br>');
	document.write("Los que sacaron una muy buena nota fueron: "+bien+'<br>');
	document.write("El promedio de la clase fue de "+(promedio/colnotas.length)+'<br>');
	document.write("La nota mas grande fue: "+grande+'<br>'+"La nota mas chica fue: "+chico);
}

/*
var estudiantes=[];
var muyBuena=0;
var normal=0;
var perdio=0;
var agregar;
var promedio=0;
var grande=0;
var chico=0;
do{
	agregar=parseInt(prompt("Ingrese un estudiante"));
	if(agregar!="")
		estudiantes[estudiantes.length]=agregar;
}while(agregar!="");
for(var i=0;i<estudiantes.length;i++){
	if(i==0){
		grande=estudiantes[i];
		chico=estudiantes[i];
	}
	if(estudiantes[i]>grande)
		grande=estudiantes[i];
	if(estudiantes[i]<chico)
		chico=estudiantes[i];
	promedio+=estudiantes[i];
	if(estudiantes[i]>70){
		if(estudiantes[i]>90)
			muyBuena++;
		else
			normal++;
	}
	else
		perdio++;
}
document.write(muyBuena+" alumnos sacaron muy buena nota"+'<br>'+normal+" alumnos pasaron el examen"+'<br>'+perdio+" alumnos perdieron el examen"+'<br>');
document.write("El promedio de la clase fue de "+(promedio/estudiantes.length)+'<br>');
document.write("La nota mas grande fue: "+grande+'<br>'+"La nota mas chica fue: "+chico);
*/