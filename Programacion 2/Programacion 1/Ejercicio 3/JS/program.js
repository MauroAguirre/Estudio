/*function SumarDosMasDos(num1,num2){
	var resultado = num1+num2;
	return resultado;
}
var dato1 = parseInt(prompt("Ingrese un numero"));
var dato2 = parseInt(prompt("Ingrese otro numero"));
var dato = SumarDosMasDos(dato1,dato2);
alert(dato);*/
function MultiplicarYTexto(texto,num1,num2){
	return texto+(num1*num2);
}
function Mostrar(textito){
	alert(textito);
}
var dato1=parseInt(prompt("Ingrese un numero"));
var dato2=parseInt(prompt("Ingrese un numero"));
var frase=prompt("Ingrese un texto");
Mostrar(MultiplicarYTexto(frase,dato1,dato2));