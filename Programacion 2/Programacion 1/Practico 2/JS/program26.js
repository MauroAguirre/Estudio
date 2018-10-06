var noches=parseInt(prompt("Ingrese las noches que se va a quedar"));
var tarjeta=prompt("Con que va a pagar?");
var gratis=0;
if(noches>3)
	gratis++;
if(noches>7){
	gratis++;
	if(tarjeta=="t")
		gratis++;
}
document.write("hay "+gratis+" noches de relago, se quedara "+parseInt(gratis+noches)+" y costara: "+noches*40);
