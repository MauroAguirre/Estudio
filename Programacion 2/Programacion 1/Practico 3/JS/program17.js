var divisor=parseInt(prompt("Ingrese el divisor"));
var dividendo=parseInt(prompt("Ingrese el dividendo"));
var cociente=0;
while(dividendo>=divisor){
		dividendo-=divisor;
		cociente++;
}
document.write("El cociente es "+cociente+" y el resto es "+dividendo);