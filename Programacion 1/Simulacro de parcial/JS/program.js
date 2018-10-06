window.onload = Load;
var viajero=[];
function Load(){
	document.getElementById("btn1").onclick = Agregar;
	document.getElementById("btn2").onclick = Resultado;
}
function Agregar(){
	var yaesta=1;
	var persona={
		nacionalidad:document.getElementById("txt1").value,
		documento:document.getElementById("txt2").value,
	}
	for(var n=0;n<viajero.length;n++){
		if(viajero[n].documento==document.getElementById("txt2").value)
			yaesta=0;	
	}
	if(yaesta==1){
		viajero.push(persona);
		document.getElementById("txt1").value="";
		document.getElementById("txt2").value="";
	}
}
function Resultado(){
	document.getElementById("a").innerHTML = "La cantidad de viajeros es: "+viajero.length;
	var Brasil=0;
	var Uruguay=0;
	var Argentina=0
	var otra=0;
	for(var i=0;i<viajero.length;i++){
		switch(viajero[i].nacionalidad){
			case "Brasilero":
				Brasil++;
				break;
			case "Argentino":
				Argentina++;
				break;
			case "Uruguayo":
				Uruguay++;
				break;
			default:
				otra++;
		}
	}
	document.getElementById("b").innerHTML = "La cantidad de Argentinos es: "+Argentina+'<br>'+"La cantidad de Uruguayos es: "+Uruguay+'<br>'+"La cantidad de Brasileros es :"+Brasil+'<br>'+"Y la cantidad de otros es de :"+otra;
	document.getElementById("c").innerHTML = "El porcentaje de brasileros es de : "+(Brasil*100/(Brasil+Argentina+Uruguay+otra))+'<br>'+
	"El porcentaje de argentinos es de: "+(Argentina+100/(Brasil+Argentina+Uruguay+otra))+'<br>'+"La cantidad de Uruguayos es de: "+(Uruguay*100/(Brasil+Argentina+Uruguay+otra))+'<br>'+
	"Y el porcentaje de otros es de: "+(otra*100/(Brasil+Argentina+Uruguay+otra));
}