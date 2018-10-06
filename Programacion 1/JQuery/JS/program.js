$(document).ready(function(){ 
	$("#txtPrueba").val("Prueba");	// poner valor en algo
	var prueba = $("#txtPrueba").val();	// para cargar una variable
	alert(prueba);
	$("#txtPrueba").after('<br>'+prueba);	//pone cosas despues o puedes usar before para poner antes
	$("#tblPrueba").append('<tr><td>'+"Wopa"+'</td></tr>');	//pone cosas adentro
	$("#txtPrueba").click(darClick);
	$("#btnRegistrarIng").click(Registrar);
	$("#btnRegistrarDon").click(Done);
	$("#div1").hide();
	$("#div2").hide();
});
function darClick(){
	alert("dsadasdasd");
}
function Registrar(){
	$("#div2").hide();
	$("#div1").show();
}
function Done(){
	$("#div1").hide();
	$("#div2").show();
}