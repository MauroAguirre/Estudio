window.onload = Load;
function Load(){
	document.getElementById("btn2").onclick = Mostrar;
}
function Mostrar(){
	var numero = localStorage.getItem("variable");
	document.getElementById("num2").value=numero[2];
}