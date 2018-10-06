window.onload = PaginaCargada;
function PaginaCargada(){
	document.getElementById("btn1").onclick = Verificar;
	function Verificar(){
		var num1=parseInt(document.getElementById("num1").value);
		var num2=parseInt(document.getElementById("num2").value);
		var chico;
		var grande;
		if(num1>num2){
			chico=num2;
			grande=num1;
		}
		else{
			chico=num1;
			grande=num2;
		}
		document.getElementById("res").innerHTML="";
		for(var i=chico+1;i<grande;i++)
			document.getElementById("res").append(i+" ");
	}
}