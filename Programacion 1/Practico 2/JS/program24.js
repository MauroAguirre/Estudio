var dinero=parseInt(prompt("Ingrese el pago"));
var tarjeta=prompt("Tiene tarjeta de credito o debito");
if((tarjeta=="si"||tarjeta=="SI")&&dinero<10000)
	document.write("El costo final sera de: "+(dinero-((dinero*4)/100)));
else
	document.write("El costo final sera de: "+dinero);