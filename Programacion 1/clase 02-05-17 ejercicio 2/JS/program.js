function agregarElemento(aray){
	var agregar;
	do{
		agregar=prompt("Decime una fruta");
		if(agregar!="0")
			aray.push(agregar);
	}while(agregar!="0");
	return aray;
}
function mostrarAray(aray){
	for(var i=0;i<aray.length;i++)
		document.write(aray[i]+'<br>');
}
var frutas=[];
frutas = agregarElemento(frutas);
mostrarAray(frutas);
frutas=[];
frutas = agregarElemento(frutas);
mostrarAray(frutas);