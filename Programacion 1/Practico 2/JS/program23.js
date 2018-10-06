var pago=parseInt(prompt("Introdusca los ingresos del comprador"));
var primer;
var resto;
if(pago<20000){
	primer=(pago*15)/100;
	resto=(pago*0.85)/2;
}
else{
	primer=(pago*30)/100;
	resto=(pago*0.70)/7;
}	
document.write("El primer pago sera de: "+primer+'<br>'+"El resto de pagos sera de: "+resto);