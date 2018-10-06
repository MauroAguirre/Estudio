var dato;
do{
	dato=parseInt(prompt("Ingrese un numero mayor a 2000"));
}while(dato<=2000);
do{
	dato/=20;
}while(dato>99);
document.write(dato);