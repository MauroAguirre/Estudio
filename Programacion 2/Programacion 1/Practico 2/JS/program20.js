var dato;
var suma=0;
for(var i=0;i<6;i++){
	dato=parseInt(prompt("Ingrese un numero"));
	if(dato<0)
		dato*=-1;
	suma+=dato;
}

document.write("La suma de los numeros es: "+suma);