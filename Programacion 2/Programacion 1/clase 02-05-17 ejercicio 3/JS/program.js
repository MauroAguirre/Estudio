function agregarHombres(aray){
	var agregar;
	do{
		agregar=prompt("Agrege un hombre");
		if(agregar!="")
			aray.push(agregar);
	}while(agregar!="");
	return aray;
}
function agregarMujeres(aray){
	var agregar;
	do{
		agregar=prompt("Agrege una mujer");
		if(agregar!="")
			aray.push(agregar);
	}while(agregar!="");
	return aray;
}
function quienEsMasGrande(aray1,aray2){
	if(aray1.length==aray2.length)
		document.write("Hay igual cantidad de mujeres y hombres");
	else{
		if(aray1.length>aray2.length)
			document.write("Hay mas hombres que mujeres");
		else
			document.write("Hay mas mujeres que hombres");
	}
}
var hombres=[];
var mujeres=[];
hombres=agregarHombres(hombres);
mujeres=agregarMujeres(mujeres);
quienEsMasGrande(hombres,mujeres);