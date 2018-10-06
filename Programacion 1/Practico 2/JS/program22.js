var azucar=parseInt(prompt("Ingrese la cantidad de tazas de azucar disponible"));
var harina=parseInt(prompt("Ingrese la cantidad de gramos de harina disponible"));
var aceite=parseInt(prompt("Ingrese la cantidad de cucharadas de aceite disponible"));
var agua=parseInt(prompt("Ingrese la cantidad de tazas de agua disponible"));
var cantidad=azucar;
harina/=100;
if(aceite<cantidad)
	cantidad=aceite;
if(agua<cantidad)
	cantidad=agua;
if(harina<cantidad)
	cantidad=harina;
document.write("Se pueden elaborar "+cantidad+" la receta de galletas");
