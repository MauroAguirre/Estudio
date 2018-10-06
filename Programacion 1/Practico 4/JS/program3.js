function esBisiesto(año){
	if(año%4==0){
		if(año%400==0)
			return true;
		if(año%100!=0)
			return true;
	}
	return false;
}
var año = parseInt(prompt("Ingrese un año"));
if(esBisiesto(año))
	document.write("Es bisiesto");
else
	document.write("No es bisiesto");