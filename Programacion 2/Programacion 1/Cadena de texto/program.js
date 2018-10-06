document.write('<h1>Manejo de cadenas de texto</h1>');




var cadenaDeTexto = "Mi Cadena de Texto";


var cantidadCaracteres = cadenaDeTexto.length;
var cadenaDeTextoEnMayuscula = cadenaDeTexto.toUpperCase();
var cadenaDeTextoEnMinuscula = cadenaDeTexto.toLowerCase();

var caracter = cadenaDeTexto.charAt(1);
var posCaracter = cadenaDeTexto.indexOf("a");

var subString = cadenaDeTexto.substring(0,9);

var colCadenasDeTexto = cadenaDeTexto.split(" ");


document.write(cadenaDeTexto + '<br>');

document.write('<br>');
document.write('<b>Cantidad de caracteres</b><br>');
document.write(cantidadCaracteres + '<br>');

document.write('<br>');
document.write('<b>toUpperCase</b><br>');
document.write(cadenaDeTextoEnMayuscula + '<br>');

document.write('<br>');
document.write('<b>toLowerCase</b><br>');
document.write(cadenaDeTextoEnMinuscula + '<br>');

document.write('<br>');
document.write('<b>charAt</b><br>');
document.write(caracter + '<br>');

document.write('<br>');
document.write('<b>indexOf</b><br>');
document.write(posCaracter + '<br>');

document.write('<br>');
document.write('<b>subString</b><br>');
document.write(subString + '<br>');

document.write('<br>');
document.write('<b>Split</b><br>');
document.write('Parte1 del split: '+ colCadenasDeTexto[0] + '<br>');
document.write('Parte2 del split: '+colCadenasDeTexto[1] + '<br>');
document.write('Parte3 del split: '+colCadenasDeTexto[2] + '<br>');
document.write('Parte4 del split: '+colCadenasDeTexto[3] + '<br>');

document.write('<br>');
document.write('<b>Recorrer una cadena de texto</b><br>');

for(var i=0; i<cadenaDeTexto.length; i++)
{
	document.write(cadenaDeTexto[i] + '<br>');
	
}









//*************************** Resumen ************************

//toUpperCase() – Retorna el String en mayúsculas
//toLowerCase() – Retorna el String en minúsculas
//length -  Retorna la cantidad de caracteres (Es una propiedad no una funcion)
	 
//charAt(indice) – retorna el carácter que se encuentra en la posición indicada
//indexOf(char) – retorna la posición dentro del String del carácter indicado.
//substring(inicial,final) – retorna un sbstring del string original dado por las posiciones inicial y final.
//split(cadena) - returna un array de cadenas de texto en base a la cadaena de entrada a dividir
//*************************************************************