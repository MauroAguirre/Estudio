//partiendo de un array numerico que contiene los valores 1 y 1 en las primeras dos posiciones, completar el array hasta la posicion 20 con los
//numeros de la susecion Fibiomacci
var arreglo=[1,1];
function Fibiomacci(arreglo){
	arreglo.push(arreglo[arreglo.length-1]+arreglo[arreglo.length-2]);
	return arreglo;
}
for(var i=0;i<18;i++)
	arreglo=Fibiomacci(arreglo);
for(var i=0;i<arreglo.length;i++)
	document.write(arreglo[i]+" ");