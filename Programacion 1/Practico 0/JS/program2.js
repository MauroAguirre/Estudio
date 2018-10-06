window.onload = Load;
function Load(){
	document.getElementById("btnSuma").onclick = Suma;
}
function Suma(){
	document.getElementById("Resultado").innerHTML = Number(document.getElementById("txtNum1").value)+Number(document.getElementById("txtNum2").value);
}