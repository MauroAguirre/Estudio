var ingreso;
var total=0;
var chico=-3;
var empleados=0;
do{
	ingreso=parseInt(prompt("Ingrese el sueldo de un empleado"));
	if(ingreso!=""){
		empleados++;
		if(chico==-3)
			chico=ingreso;
		total+=ingreso;
		if(ingreso<chico)
			chico=ingreso;
	}
}while(ingreso!="");
document.write("El total de sueldos a pagar es de: "+total+'<br>');
document.write("Van a cobrar: "+empleados+" empleados"+'<br>');
document.write("El sueldo mas bajo es de: "+chico);