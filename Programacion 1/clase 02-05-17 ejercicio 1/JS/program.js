var item = "Maria";		//Variable de tipo texto
var nombres = ["Facundo","Pepe","Juan","Hola",item];		//Variable de tipo array
//alert(nombres[0]);
//alert(nombres[2]);
alert(nombres.length);			//los arays tienen propiedades, una de ellas 
for(i=0;i<nombres.length;i++){
	document.write(nombres[i]+'<br>');
}
// primera forma de agregar elementos a una aray
nombres[5]="Pedro";		// tambien se puede poner nombres[nombres.length]="Pedro", esta manera es mejor
alert("El tamaño del aray es de "+nombres.length+" y el ultimo valor es "+nombres[5]);
// segunda forma de agregar elementos a una aray
nombres.push("Romina");
document.write('<br>');
for(i=0;i<nombres.length;i++){
	document.write(nombres[i]+'<br>');
}