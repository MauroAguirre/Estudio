window.onload = Load;
var valores=[];
function Load(){
	document.getElementById("btn1").onclick = Agregar;
	document.getElementById("btn2").onclick = Promedio;
	document.getElementById("btn3").onclick = MayorYMenor;
}
function Agregar(){
	valores.push(Number(document.getElementById("num1").value));
	document.getElementById("num1").value="";
}
function Promedio(){
	var total=0;
	for (var i=0;i<valores.length;i++)
		total+=valores[i];
	document.getElementById("Resultado").innerHTML = total/valores.length;
}
function MayorYMenor(){
	var mayor=0;
	var menor=0;
	for (var j=0;j<valores.length;j++){
		if(j==0){
			mayor=valores[j];
			menor=valores[j];
		}
		if(valores[j]>mayor)
			mayor=valores[j];
		if(valores[j]<menor)
			menor=valores[j];
	}
	document.getElementById("Resultado").innerHTML ="El mayor es: "+mayor+'<br>'+"El menor es: "+menor;
}