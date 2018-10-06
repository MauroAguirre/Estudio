window.onload = PaginaCargada;
function PaginaCargada(){
	document.getElementById("btn1").onclick = Verificar;
	function Verificar(){
		var chico;
		var grande;
		if(parseInt(document.getElementById("num1").value)>parseInt(document.getElementById("num2").value)){
			grande=parseInt(document.getElementById("num1").value);
			chico=parseInt(document.getElementById("num2").value);
		}
		else{
			chico=parseInt(document.getElementById("num1").value);
			grande=parseInt(document.getElementById("num2").value);
		}
		for(var i=chico+1;i<grande;i++){
			if(i%parseInt(document.getElementById("num3").value)==0)
				document.getElementById("res").append(i+" ");
		}
	}
}