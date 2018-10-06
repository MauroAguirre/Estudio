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
function Grande(aray1,aray2){
	if(aray1.length==aray2.length)
		return aray1.length;
	else{
		if(aray1.length>aray2.length)
			return aray1.length;
		else
			return aray2.length;
	}
}
var hombres=[];
var mujeres=[];
hombres=agregarHombres(hombres);
mujeres=agregarMujeres(mujeres);

document.write('<table><thead><tr><th>Hombres</th><th>Mujeres</th></thead><tbody>');
for(i=0;i<Grande(hombres,mujeres);i++){
	document.write('<tr>');
	if(i>=hombres.length)
		document.write('<th></th>');
	else
		document.write('<th>'+hombres[i]+'</th>');
	if(i>=mujeres.length)
		document.write('<th></th>');
	else
		document.write('<th>'+mujeres[i]+'</th>');
	document.write('</tr>');
}
document.write('</tbody></table>');