window.onload =	paginaCargada;
function paginaCargada(){
	var suma=0;
	document.getElementById("btnAdd").onclick = Suma;
	document.getElementById("btnRes").onclick = Res;
	function Suma(){
		suma+=parseInt(document.getElementById("numNumero").value);
		document.getElementById("numNumero").value="";
	}
	function Res(){
		alert(suma);
	}
}
