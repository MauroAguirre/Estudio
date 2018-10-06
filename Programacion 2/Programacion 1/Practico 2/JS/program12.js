window.onload = PaginaCargada;
function PaginaCargada(){
	document.getElementById("btn1").onclick = Resta;
	function Resta(){
		if(parseInt(document.getElementById("num1").value) > parseInt(document.getElementById("num2").value))
			document.getElementById("res1").innerHTML=document.getElementById("num1").value-document.getElementById("num2").value;
		else
			document.getElementById("res1").innerHTML=document.getElementById("num2").value-document.getElementById("num1").value;
	}
}