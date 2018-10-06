window.onload = PaginaCargada;
function PaginaCargada(){
	document.getElementById("btn1").onclick = Mostrar;
	function Mostrar(){
		if(document.getElementById("num1").value>=10){
			if(document.getElementById("num1").value>30)
				document.getElementById("res").innerHTML="El numero es mayor a 30";
			else
				document.getElementById("res").innerHTML="Entre 10 y 30";
		}
		else
			document.getElementById("res").innerHTML="El numero es menor a 10";
	}
}