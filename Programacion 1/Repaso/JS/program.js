window.onload = Load;

function Load(){
	var btn = document.getElementById("btnIngresar");
	btn.onclick = Pepe;
	btn.value = "Hola";
	CargarValoresPorDefecto("Facundo","00000")
}
function Pepe(){
	document.getElementById("btnIngresar").value = "hola mundo";
	CargarValoresPorDefecto("MARIA","Larailaira");
}
function CargarValoresPorDefecto(nom,tel){
	var inputNombre = document.getElementById("txtNombre");
	var inputTelefono = document.getElementById("txtTelefono");
	inputNombre.value = nom;
	inputTelefono.value = tel; 
}