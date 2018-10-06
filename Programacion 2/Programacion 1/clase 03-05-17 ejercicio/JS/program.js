var atributo;
var valor;
var arreglo={};
do{
	atributo=prompt("Ingrese un atributo");
	if(atributo!=""){
		valor=prompt("Ingrese un valor");
		arreglo[atributo]=valor;
	}
}while(atributo!="");
for(i in arreglo){
	document.write(i+": "+arreglo[i]+'<br>');
}