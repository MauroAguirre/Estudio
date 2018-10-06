var dato=parseInt(prompt("Ingrese un numero"));
digitos=0;
do{
	dato/=10;
	digitos++
}while(dato>=1);
document.write("El numero tiene "+digitos+" digitos");