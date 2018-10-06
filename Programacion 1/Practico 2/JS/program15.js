window.onload = PaginaCreada;
function PaginaCreada(){
	document.getElementById("btn1").onclick = Ver;
	function Ver(){
		if(parseInt(document.getElementById("num1").value)%parseInt(document.getElementById("num2").value)==0)
			document.getElementById("res").innerHTML="El primer numero es multiplo del segundo";
		else
			document.getElementById("res").innerHTML="El primer numero no es multiplo del segundo";
	}
}