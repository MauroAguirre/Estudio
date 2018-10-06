var numero=parseInt(prompt("Ingrese un numero para adivinar"));
var intentos=1;
var distancia;
var pregunta=parseInt(prompt("Intente adivinar el numero"));
while(pregunta!=numero){
	intentos++;
	if(numero>pregunta)
		distancia=numero-pregunta;
	else
		distancia=pregunta-numero;
	if(distancia>15)
		pregunta=parseInt(prompt("Estas lejos, ingrese otro numero"));
	else{
		if(distancia>9)
			pregunta=parseInt(prompt("Te estas acercando, ingrese otro numero"));
		else{
			if(distancia>4)
				pregunta=parseInt(prompt("Cada vez mas cerca, ingrese otro numero"));
			else
				pregunta=parseInt(prompt("Muy pero muy cerca, ingrese otro numero"));
		}
	}
}
document.write("Numero Correcto, la cantidad de intentos fue de: "+intentos);