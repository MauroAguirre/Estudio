window.onload = PaginaCargada;
function PaginaCargada(){
	document.getElementById("btn1").onclick = Resultado;
	function Resultado(){
		switch(document.getElementById("txt1").value){
			case "s":
			case "S":
				document.getElementById("res").innerHTML=parseInt(document.getElementById("num1").value)+parseInt(document.getElementById("num2").value);
				break;
			case "r":		
			case "R":
				document.getElementById("res").innerHTML=parseInt(document.getElementById("num1").value)-parseInt(document.getElementById("num2").value);
				break;
			case "m":
			case "M":
				document.getElementById("res").innerHTML=parseInt(document.getElementById("num1").value)*parseInt(document.getElementById("num2").value);
				break;
			case "d":
			case "D":
				document.getElementById("res").innerHTML=parseInt(document.getElementById("num1").value)/parseInt(document.getElementById("num2").value);
				break;
			default:
				document.getElementById("res").innerHTML="No Comprendo";
		}
	}
}