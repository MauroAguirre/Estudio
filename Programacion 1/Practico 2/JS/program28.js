window.onload = PaginaCargada;
function PaginaCargada(){
	var equipo1=0;
	var equipo2=0;
	document.getElementById("btn1").onclick = Agregar;
	function Agregar(){
			equipo1+=parseInt(document.getElementById("num1").value);
			equipo2+=parseInt(document.getElementById("num2").value);
		if(equipo1<30&&equipo2<30)
			document.getElementById("res").innerHTML ="El equipo 1 tiene "+equipo1+" puntos y el equipo 2 tiene "+equipo2+" puntos";
		else{
			document.getElementById("num1").remove();
			document.getElementById("num2").remove();
			document.getElementById("btn1").remove();
			document.getElementById("br").remove();
			if(equipo1>=30)
				document.getElementById("res").innerHTML ="El equipo 1 gana con "+equipo1+" puntos y el equipo 2 pierde con "+equipo2+" puntos";
			else
				document.getElementById("res").innerHTML ="El equipo 2 gana con "+equipo2+" puntos y el equipo 1 pierde con "+equipo1+" puntos";
		}
			
	}
}