var millas=parseInt(prompt("Ingrese las millas"));
var plan=prompt("Tiene el plan plus?");
if(plan=="si" || plan=="SI")
	millas*=2;
if(millas>=15000){
	if(millas>=30000){
		if(millas>=60000)
			document.write("Usted puede viajar gratis a Europa como destino lejano");
		else
			document.write("Usted puede viajar gratis a America del norte como destino intermedio");
	}
	else
		document.write("Usted puede viajar gratis a America del sur como destino cercano");
}
else
	document.write("Usted no dispone de millas suficientes para el viaje gratis");