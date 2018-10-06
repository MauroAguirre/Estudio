$(document).ready(function(){
	$("#btn1").click(Verificar);
});
function Verificar(){
	var txt1 = $("#txt1").val();
	var txt2 = $("#txt2").val();
	for(var n=0;n<txt1.length;n++){
		var iguales=true;
		var z=0;
		for (var i=n;i<n+txt2.length;i++){
			if(txt1.charAt(i)!=txt2.charAt(z))
				iguales=false;
			z++;
		}
		if(iguales){
			$("#res").html("El texto 2 esta en el texto 1");
			return;
		}	
	}
	$("#res").html("El texto 2 no esta en el texto 1");
}