window.onload = PaginaCargada;
	var numeros=[];
	function PaginaCargada(){
		document.getElementById("btnSum").onclick = Suma;
		document.getElementById("btnRes").onclick = Resta;
		document.getElementById("btnDiv").onclick = Division;
		document.getElementById("btnMul").onclick = Multiplicacion;
		document.getElementById("btnGua").onclick = Guardar;
		document.getElementById("btnMay").onclick = Mayor;
		document.getElementById("btnLim").onclick = Limpiar;
	}
	function Suma(){
		document.getElementById("num3").value = Number(document.getElementById("num1").value)+Number(document.getElementById("num2").value);
	}
	function Resta(){
		document.getElementById("num3").value = Number(document.getElementById("num1").value)-Number(document.getElementById("num2").value)
	}
	function Division(){
		document.getElementById("num3").value = Number(document.getElementById("num1").value)/Number(document.getElementById("num2").value);
	}
	function Multiplicacion(){
		document.getElementById("num3").value = Number(document.getElementById("num1").value)*Number(document.getElementById("num2").value);
	}
	function Guardar(){
		numeros.push(Number(document.getElementById("num3").value));
		Limpiar();
	}
	function Mayor(){
		Limpiar();
		var grande;
		for(var i=0;i<numeros.length;i++){
			if(i==0)
				grande=numeros[i];
			if(numeros[i]>grande)
				grande=numeros[i];
		}
		document.getElementById("num3").value=grande;
	}
	function Limpiar(){
		document.getElementById("num1").value="";
		document.getElementById("num2").value="";
		document.getElementById("num3").value="";
	}