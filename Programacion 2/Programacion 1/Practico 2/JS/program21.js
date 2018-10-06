var dato;
var cinco=0;
var mayores=0;
var todo=0;
for(var i=0;i<5;i++){
	dato=parseInt(prompt("Ingrese un numero"));
	if(dato>20&&dato%5==0){
		mayores++;
		cinco++;
		todo++;
	}else{
		if(dato>20)
			mayores++;
		if(dato%5==0)
			cinco++
	}
}
document.write("La cantidad de numeros mayores a 20 es: "+mayores+'<br>');
document.write("La cantidad de numeros multiplos de 5 es: "+cinco+'<br>');
document.write("La cantidad de numeros mayores a 20 y multiplos de 5 es: "+todo);