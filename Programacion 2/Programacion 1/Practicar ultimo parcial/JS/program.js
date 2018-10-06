var arreglo=[];
$(document).ready(function(){
	$("#btn1").click(Ver);
	$("#btn2").click(Ver2);
	$("#btn3").click(Mayuscula);
	$("#btn4").click(Agregar);
	$("#btn5").click(Mostrar);
});
function Mostrar(){
	$("#res").html("");
	for(item in arreglo){
		$("#res").append(arreglo[item].texto1+'<br>');
		$("#res").append(arreglo[item].texto2+'<br>');
	}
}
function Agregar(){
	var agrego={
		texto1:$("#txt1").val(),
		texto2:$("#txt2").val(),
	};
	arreglo.push(agrego);
}
function Ver(){
	if(document.getElementById("rdo1").checked)
		alert("1");
	else{
		if(document.getElementById("rdo2").checked)
			alert("2");
		else
			alert("3");
	}
}
function Ver2(){
	if(document.getElementById("box1").checked)
		alert("Esta clickeado");
	else
		alert("No esta clickeado");
}
function Mayuscula(){
	var letra=$("#txt1").val().toUpperCase();
	$("#res").html(letra);
}