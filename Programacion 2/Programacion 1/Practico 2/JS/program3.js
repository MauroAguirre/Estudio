window.onload = PaginaCargada;
function PaginaCargada(){
	document.getElementById("btnVer").onclick = VerificarClick;
	function VerificarClick(){
		if(document.getElementById("numNumero").value>=20){
			if(document.getElementById("numNumero").value==20)
				document.getElementById("resVer").innerHTML="El numero es igual a 20";
			else
				document.getElementById("resVer").innerHTML="El numero es mayor a 20";
		}
		else
			document.getElementById("resVer").innerHTML="El numero es menor a 20";
	}
}