var dato1=parseInt(prompt("Ingrese un numero"));
var dato2=parseInt(prompt("Ingrese otro numero"));
for(var i=dato1;i<=dato2;i++){
	if(i%4==0 && i%6==0){
		document.write(i);
		break;
	}
}