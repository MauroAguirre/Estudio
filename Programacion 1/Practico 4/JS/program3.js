function esBisiesto(a�o){
	if(a�o%4==0){
		if(a�o%400==0)
			return true;
		if(a�o%100!=0)
			return true;
	}
	return false;
}
var a�o = parseInt(prompt("Ingrese un a�o"));
if(esBisiesto(a�o))
	document.write("Es bisiesto");
else
	document.write("No es bisiesto");