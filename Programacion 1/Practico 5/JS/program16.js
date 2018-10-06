$(document).ready(function(){
	$("#btn1").click(Verificar);
});
function Verificar(){
	var texto=$("#txt1").val();
	var num=[];
	var resultado;
	var mayor;
	for(var i=0;i<9;i++){
		if(texto.charAt(i)!=".")
			num.push(texto.charAt(i))
	}
	resultado=num[0]*2+num[1]*9+num[2]*8+num[3]*7+num[4]*6+num[5]*3+num[6]*4;
	mayor=resultado;
	while(mayor%10!=0){
		mayor++;
	}
	mayor-=resultado;
	if(mayor==texto.charAt(10))
		$("#Res").html("La cedula es valida");
	else
		$("#Res").html("La cedula no es valida");
}