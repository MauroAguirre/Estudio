function Retorna(a,b){
	var chico;
	var grande;
	if(a>b){
		chico=b;
		grande=a;
	}
	else{
		grande=b;
		chico=a;
	}
	for(var i=chico;i<=grande;i++){
		if(i%2==0)
			document.write(i+'<br>');
	}
}
var num1 = Number(prompt("Ingrese un numero"));
var num2 = Number(prompt("Ingrese otro numero"));
Retorna(num1,num2);
