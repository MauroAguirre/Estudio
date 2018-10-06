window.onload = Load;
var global=[];
function Load(){
	document.getElementById("btn1").onclick = Igualar;
	document.getElementById("btn2").onclick = Agregar;
}
function Igualar(){
	localStorage.setItem("variable",document.getElementById("num1").value);
}
function Agregar(){
	var wopa = Number(document.getElementById("num1").value);
	global.push(wopa);
	localStorage.setItem("variable",global);
}