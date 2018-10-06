var dato=parseInt(prompt("Ingrese un numero"));
for(var i=30;i<200;i++){
	if(i%dato==0 && i%2==0)
		document.write(i+" ");
}