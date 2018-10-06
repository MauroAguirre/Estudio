var colNums=[9,10,0,1,99,6,22];
var colNombres=["Pepe","Ximena","Ana","Maria"];
var colPer=[{nombre:"Pepe",edad:98},{nombre:"Laura",edad:30},{nombre:"Ana",edad:15},{nombre:"Figary",edad:60}];
for(var i=0;i<colPer.length;i++)
	alert(colPer[i].nombre+" - "+colPer[i].edad);
var colPerOrdenadas = colPer.sort(CompararObjetos);
$(document).ready(function(){

});
function CompararObjetos(a,b){
	if(a.nombre>b.nombre)
		return 1;
	else{
		if(a.nombre<b.nombre)
			return -1;
		else
			return 0;
	}
}
function Comparar(a,b){
	return a-b;		//Negativo = a > b
					//0  a = b
					//Positivo = a < b
}
function Comparar2(a,b){
	return b-a;
}
function CompararLetrasDesendente(a,b){
	if(a>b)
		return -1;
	else{
		if(a<b)
			return 1;
		else
			return 0;
	}
}
for(var i=0;i<colPerOrdenadas.length;i++)
	alert(colPerOrdenadas[i].nombre+" - "+colPerOrdenadas[i].edad);
var colNumsOrdenados=colNums.sort(Comparar);
alert("Acendente " + colNumsOrdenados);
alert("Desendente " + colNums.sort(Comparar2))
alert("Acendente " + colNombres.sort());
alert("Desendente " + colNombres.sort(CompararLetrasDesendente));
