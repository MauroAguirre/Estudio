function esMayor(edad,tope){
	if(edad>tope)
		return true;
	return false;
}
var edad = parseInt(prompt("Ingrese la edad"));
var tope = parseInt(prompt("Ingrese el tope"));
if(esMayor(edad,tope))
	document.write("es mayor");
else
	document.write("no es mayor");