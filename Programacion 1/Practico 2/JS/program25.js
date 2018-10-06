window.onload = PaginaCargada;
function PaginaCargada(){
	var stock=parseInt(prompt("Ingrese la cantidad de camaras disponibles"));
	var pedidos=0;
	var canMax=0;
	var nombreMax="";
	document.getElementById("btn1").onclick = Agregar;
	function Agregar(){
		if(document.getElementById("numcan").value<=stock){
			stock-=document.getElementById("numcan").value;
			if(canMax<document.getElementById("numcan").value){
				canMax=document.getElementById("numcan").value;
				nombreMax=document.getElementById("txtnom").value;
			}
			pedidos++;
		}
		else{
			document.getElementById("res").innerHTML="El cliente que a comprado mas camaras es: "+nombreMax
			+'<br>'+"La cantidad de pedidos fue de "+pedidos;
		}
		document.getElementById("numcan").value="";
		document.getElementById("txtnom").value="";
	}
}