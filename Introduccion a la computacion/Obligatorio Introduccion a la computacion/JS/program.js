$(document).ready(function(){
	ListaSigno();
	ListaAlmacenaje();
	$("#tblPuntoFlotante1").hide();
	$("#tblPuntoFlotante2").hide();
	$("#tblPuntoFlotante3").hide();
	$(".btn").click(Cambio);
	$("#select3").change(ListaSigno);
	$("#select3").change(ListaAlmacenaje);
});
function AlmacenamientoPuntoFlotante(){
	var mantisa;
	var ajustar;
	var presicion=$("#select7").val();
	var signo=$("#select6 :selected").val();
	var entero=$("#numEntero").val();
	var fraccion=$("#numFraccion").val();
	var exponente=$("#numElevado").val();
	var pedir;
	var agregado="";
	var mover=0;
	var maximoMantisa;
	var maximoExponente;
	var ultimo;
	var bias;
	$("#tblPuntoFlotante1").hide();
	$("#tblPuntoFlotante2").hide();
	$("#tblPuntoFlotante3").hide();
	switch(presicion){
		case "1":
			bias=127;
			maximoMantisa=9;
			ultimo=6;
			maximoExponente=8;
			break;
		case "2":
			bias=127;
			maximoMantisa=25;
			ultimo=22;
			maximoExponente=8;
			break;
		case "3":
			bias=1023;
			maximoMantisa=54;
			ultimo=51;
			maximoExponente=11;
			break;
	}
	while(entero[0]=="0" && entero.length>1)
		entero=entero.substr(1,(entero.length-1));
	while(exponente[0]=="0" && exponente.length>1)
		exponente=exponente.substr(1,(exponente.length-1));
	while(exponente[0]=="0" && exponente.length>1)
		exponente=exponente.substr(1,(exponente.length-1));
	if(entero=="" || fraccion=="" || exponente=="" )
		return "Falta ingresar datos";
	if((entero=="0" && fraccion=="0") || exponente=="0")
		return "El numero ingresado es 0";
	entero=DecimalABinario(entero);
	var nivel="10";
	for(var i=1;i<fraccion.length;i++)
		nivel+="0";
	fraccion/=parseInt(nivel);
	if(entero.length==1 && entero[0]=="0"){
		do{
			mover++;
			fraccion*=2;
		}while(fraccion<1);
		fraccion-=1;
		for(var i=0;i<maximoMantisa;i++){
			fraccion*=2;
			if(fraccion>1){
				fraccion-=1;
				agregado+="1";
			}
			else{
				agregado+="0";
			}
		}
		mantisa=agregado;
	}
	else{
		if(fraccion==0){
			mantisa=entero;
			while(mantisa.length<maximoMantisa)
				mantisa="0"+mantisa;
		}
		else{
			mover=(entero.length-1)*-1;
			pedir=maximoMantisa-(entero.length-1);
			if(pedir>0){
				for(var i=0;i<pedir;i++){
					fraccion*=2;
					if(fraccion>1){
						fraccion-=1;
						agregado+="1";
					}
					else{
						agregado+="0";
					}
				}
				mantisa=entero.substr(1,entero.length-1)+agregado;
			}
			else{
				mantisa=entero.substr(1,maximoMantisa);
			}
		}
	}
	var lugar=3;
	var acomodar="1";
	if((mantisa[ultimo]=="1"&&mantisa[ultimo+1]=="1"&&mantisa[ultimo+2]=="0")||(mantisa[ultimo]=="0"&&mantisa[ultimo+1]=="1"&&mantisa[ultimo+2]=="1")||(mantisa[ultimo]=="1"&&mantisa[ultimo+1]=="1"&&mantisa[ultimo+2]=="1")){
		for(var i=ultimo;i>=0;i--){
			if(mantisa[i]=="0")
				break;
			lugar++;
		}
		for(var i=0;i<lugar-3;i++)
			acomodar=acomodar+"0";
		mantisa=mantisa.substr(0,(mantisa.length)-lugar)+acomodar;
	}else{
		mantisa=mantisa.substr(0,(mantisa.length-2));
	}
	ajustar=exponente/0.30;
	exponente=parseInt(exponente/0.30);
	var exponenteAbsoluto;
	var ajustarAbsoluto;
	if(ajustar<0){
		exponenteAbsoluto=exponente*-1;
		ajustarAbsoluto=ajustar*-1;
	}
	else{
		exponenteAbsoluto=exponente;
		ajustarAbsoluto=ajustar;
	}
	if((exponenteAbsoluto+0.5)<ajustarAbsoluto){
		if(exponente<0)
			exponente--;
		else
			exponente++
	}
	exponente-=mover;
	exponente+=bias;
	if(exponente>(bias*2)||exponente<1)
		return "Overflow";
	exponente=DecimalABinario(exponente);
	while(exponente.length<maximoExponente)
		exponente="0"+exponente;
	switch(presicion){
		case "1":
			$("#tblPuntoFlotante1").show();
			$("#tblPuntoFlotante2").hide();
			$("#tblPuntoFlotante3").hide();
			if(signo=="1")
				$("#signo").html("0");
			else
				$("#signo").html("1");
			for(var i=0;i<exponente.length;i++)
				$("#exp"+(i+1)).html(exponente[i]);
			for(var i=mantisa.length-1;i>=0;i--)
				$("#man"+(i+1)).html(mantisa[i]);
			break;
		case "2":
			$("#tblPuntoFlotante1").hide();
			$("#tblPuntoFlotante2").show();
			$("#tblPuntoFlotante3").hide();
			if(signo=="1")
				$("#2signo").html("0");
			else
				$("#2signo").html("1");
			for(var i=0;i<exponente.length;i++)
				$("#2exp"+(i+1)).html(exponente[i]);
			for(var i=mantisa.length-1;i>=0;i--)
				$("#2man"+(i+1)).html(mantisa[i]);
			break;
		case "3":
			$("#tblPuntoFlotante1").hide();
			$("#tblPuntoFlotante2").hide();
			$("#tblPuntoFlotante3").show();
			if(signo=="1")
				$("#3signo").html("0");
			else
				$("#3signo").html("1");
			for(var i=0;i<exponente.length;i++)
				$("#3exp"+(i+1)).html(exponente[i]);
			for(var i=mantisa.length-1;i>=0;i--)
				$("#3man"+(i+1)).html(mantisa[i]);
			break;
	}
	return "Valor almacenado";
}
function ListaAlmacenaje(){
	var elegido=$("#select4 :selected").val();
	$("#select5").html("");
	switch(elegido){
		case "0":
			$("#select5").append('<option>No se aplica</option>');
			break;
		default :
			$("#select5").append('<option value="1">Byte</option><option value="2">Palabra</option><option value="4">Palabra doble</option>');
			break;
	}
}
function ListaSigno(){
	var elegido=$("#select3 :selected").val();
	$("#select4").html("");
	switch(elegido){
		case "texto":
			$("#select4").append('<option value="0">No se aplica</option>');
			break;
		default :
			$("#select4").append('<option value="1">Sin signo</option><option value="2">Positivo</option><option value="3">Negativo</option>');
			break;
	}
}
function Cambio(){
	switch(this.getAttribute("id")){
		case "btnCambioBase":
			$("#txt2").val(CambioBase(VerificarBase()));
			break;
		case "btnAlmacenarInternamente":
			$("#txt4").val(AlmacenarValor(VerificarValor()));
			break;
		case "btnPuntoFlotante":
			$("#res2").val(AlmacenamientoPuntoFlotante());
			break;
	}
}
function VerificarValor(){
	var valor = $("#txt3").val();
	switch($("#select3").val()){
		case "2":
			if(valor=="")
				return -2;
			for(var i=0;i<valor.length;i++){
				if(valor.charAt(i)!="0"&&valor.charAt(i)!="1")
					return -1;
			}
			return 2;
		case "8":
			if(valor=="")
				return -2;
			for(var i=0;i<valor.length;i++){
				if(valor.charAt(i)!="0"&&valor.charAt(i)!="1"&&valor.charAt(i)!="2"&&valor.charAt(i)!="3"
				&&valor.charAt(i)!="4"&&valor.charAt(i)!="5"&&valor.charAt(i)!="6"&&valor.charAt(i)!="7")
					return -1;
			}
			return 8;
		case "10":
			if(valor=="")
				return -2;
			for(var i=0;i<valor.length;i++){
				if(valor.charAt(i)!="0"&&valor.charAt(i)!="1"&&valor.charAt(i)!="2"&&valor.charAt(i)!="3"
				&&valor.charAt(i)!="4"&&valor.charAt(i)!="5"&&valor.charAt(i)!="6"&&valor.charAt(i)!="7"
				&&valor.charAt(i)!="8"&&valor.charAt(i)!="9")
					return -1;
			}
			return 10;
		case "16":
			if(valor=="")
				return -2;
			for(var i=0;i<valor.length;i++){
				if(valor.charAt(i)!="0"&&valor.charAt(i)!="1"&&valor.charAt(i)!="2"&&valor.charAt(i)!="3"
				&&valor.charAt(i)!="4"&&valor.charAt(i)!="5"&&valor.charAt(i)!="6"&&valor.charAt(i)!="7"
				&&valor.charAt(i)!="8"&&valor.charAt(i)!="9"&&valor.charAt(i)!="A"&&valor.charAt(i)!="B"
				&&valor.charAt(i)!="C"&&valor.charAt(i)!="D"&&valor.charAt(i)!="E"&&valor.charAt(i)!="F"
				&&valor.charAt(i)!="a"&&valor.charAt(i)!="b"&&valor.charAt(i)!="c"&&valor.charAt(i)!="d"
				&&valor.charAt(i)!="e"&&valor.charAt(i)!="f")
					return -1;
			}
			return 16;
		case "texto":
			return "texto";
	}
}
function Signos(almaceno,cantidad,ingreso,sig){
	switch(almaceno){
		case "1":
			if(cantidad>8)
				return "Overflow";
		case "2":
			if(cantidad>16)
				return "Overflow";
		case "4":
			if(cantidad>32)
				return "Overflow";
	}
	var cantidad=0;
	var col=[];
	var ceritos="00000000";
	var ceros="";
	while(ingreso.length>8){
		col.push(ingreso.substr(ingreso.length-8));
		ingreso=ingreso.substr(0,ingreso.length-8);
	}
	cantidad=8-ingreso.length;
	for(var i=0;i<cantidad;i++)
		ceros+="0";
	ceros+=ingreso;
	col.push(ceros);
	cantidad=parseInt(almaceno)-col.length;
	for(var i=0;i<cantidad;i++)
		col.push(ceritos);
	if(sig!=3){
		if(col[col.length-1].charAt(0)=="1" && sig==2)
			return "Error en el signo";
		for(var i=(col.length-1);i>=0;i--)
			AgregarRespuestaAlmacenaje(i,col[i],i);
		return "Almacenamiento completado";
	}
	var contrario="";
	for(var i=(col.length-1);i>=0;i--){
		for(var l=0;l<8;l++){
			if(col[i][l]=="0")
				contrario+="1";
			else
				contrario+="0";
		}
	}
	var overFlow=true;
	for(var i=0;i<contrario;i++){
		if(contrario[i]=="0"){
			overFlow=false;
			break;
		}
	}
	if(overFlow)
		return "Overflow";
	var buscarCero=0;
	for(var i=(contrario.length-1);i>=0;i--){
		if(contrario[i]=="0")
			break;
		buscarCero++;
	}
	contrario=contrario.substr(0,(contrario.length-1)-buscarCero);
	var agregar="";
	for(var i=0;i<buscarCero;i++)
		agregar+="0";
	contrario=contrario+"1"+agregar;
	var separadito=[];
	var enOcho="";
	var contador=0;
	for(var i=0;i<almaceno;i++){
		for(var l=0;l<8;l++){
			enOcho+=contrario[contador];
			contador++;
		}
		separadito.push(enOcho);
		enOcho="";
	}
	for(var i=0;i<separadito.length;i++)
		AgregarRespuestaAlmacenaje(i,separadito[i],i);
	if(separadito[0][0]=="0")
		return "Overflow";
	$("#tblPuntoFlotante").show();
	return "Almacenamiento completado";
}
function AlmacenarValor(valor){
	$("#res").html("");
	var ingreso=$("#txt3").val();
	if(valor!="texto"){
		while(ingreso.charAt(0)=="0")
			ingreso=ingreso.substr(1);
	}
	var cantidad=ingreso.length;
	var signo;
	var almaceno;
	if($("#select3 :selected").val()!="texto"){
		signo=$("#select4 :selected").val();
		almaceno=$("#select5 :selected").val();
	}
	$("#res").html("");
	$("#res").append('<table id="wopa" class="tablita"><tr id="tr1"></tr><tr id="t1r"></tr></table>');
	switch(valor){
		case -1:
			return "Error en la base";
		case -2:
			return "Escribe un valor";
		case 2:
			switch(signo){
				case "1":
					return Signos(almaceno,cantidad,ingreso,1);
				case "2":
					return Signos(almaceno,cantidad,ingreso,2);
				case "3":
					return Signos(almaceno,cantidad,ingreso,3);
			}
		case 8:
			switch(signo){
				case "1":
					return Signos(almaceno,OctalABinario(ingreso).length,OctalABinario(ingreso),1);
				case "2":
					return Signos(almaceno,OctalABinario(ingreso).length,OctalABinario(ingreso),2);
				case "3":
					return Signos(almaceno,OctalABinario(ingreso).length,OctalABinario(ingreso),3);
			}
		case 10:
			switch(signo){
				case "1":
					return Signos(almaceno,DecimalABinario(ingreso).length,DecimalABinario(ingreso),1);
				case "2":
					return Signos(almaceno,DecimalABinario(ingreso).length,DecimalABinario(ingreso),2);
				case "3":
					return Signos(almaceno,DecimalABinario(ingreso).length,DecimalABinario(ingreso),3);
			}
		case 16:
			switch(signo){
				case "1":
					return Signos(almaceno,HexadecimalABinario(ingreso).length,HexadecimalABinario(ingreso),1);
				case "2":
					return Signos(almaceno,HexadecimalABinario(ingreso).length,HexadecimalABinario(ingreso),2);
				case "3":
					return Signos(almaceno,HexadecimalABinario(ingreso).length,HexadecimalABinario(ingreso),3);
			}
		case "texto":
			for(var i=0;i<cantidad;i++){
				switch(ingreso.charAt(i)){
					case " ":
						AgregarRespuesta(" ","00100000",i);
						break;
					case "!":
						AgregarRespuesta("!","00100001",i);
						break;
					case "\"":
						AgregarRespuesta("\"","00100010",i);
						break;
					case "#":
						AgregarRespuesta("#","00100011",i);
						break;
					case "$":
						AgregarRespuesta("$","00100100",i);
						break;
					case "%":
						AgregarRespuesta("%","00100101",i);
						break;
					case "&":
						AgregarRespuesta("&","00100110",i);
						break;
					case "'":
						AgregarRespuesta("'","00100111",i);
						break;
					case "\(":
						AgregarRespuesta("\(","00101000",i);
						break;
					case "\)":
						AgregarRespuesta("\)","00101001",i);
						break;
					case "*":
						AgregarRespuesta("/","00101010",i);
						break;
					case "+":
						AgregarRespuesta("+","00101011",i);
						break;
					case ",":
						AgregarRespuesta(",","00101100",i);
						break;
					case "-":
						AgregarRespuesta("-","00101101",i);
						break;
					case ".":
						AgregarRespuesta(".","00101110",i);
						break;
					case "/":
						AgregarRespuesta("/","00101111",i);
						break;
					case "0":
						AgregarRespuesta("0","00110000",i);
						break;
					case "1":
						AgregarRespuesta("1","00110001",i);
						break;
					case "2":
						AgregarRespuesta("2","00110010",i);
						break;
					case "3":
						AgregarRespuesta("3","00110011",i);
						break;
					case "4":
						AgregarRespuesta("4","00110100",i);
						break;
					case "5":
						AgregarRespuesta("5","00110101",i);
						break;
					case "6":
						AgregarRespuesta("6","00110110",i);
						break;
					case "7":
						AgregarRespuesta("7","00110111",i);
						break;
					case "8":
						AgregarRespuesta("8","00111000",i);
						break;
					case "9":
						AgregarRespuesta("9","00111001",i);
						break;
					case ":":
						AgregarRespuesta(":","00111010",i);
						break;
					case ";":
						AgregarRespuesta(";","00111011",i);
						break;
					case "<":
						AgregarRespuesta("<","00111100",i);
						break;
					case "=":
						AgregarRespuesta("=","00111101",i);
						break;
					case ">":
						AgregarRespuesta(">","00111110",i);
						break;
					case "?":
						AgregarRespuesta("?","00111111",i);
						break;
					case "@":
						AgregarRespuesta("@","01000000",i);
						break;
					case "A":
						AgregarRespuesta("A","01000001",i);
						break;
					case "B":
						AgregarRespuesta("B","01000010",i);
						break;
					case "D":
						AgregarRespuesta("D","01000100",i);
						break;
					case "E":
						AgregarRespuesta("E","01000101",i);
						break;
					case "F":
						AgregarRespuesta("F","01000110",i);
						break;
					case "G":
						AgregarRespuesta("G","01000111",i);
						break;
					case "H":
						AgregarRespuesta("H","01001000",i);
						break;
					case "I":
						AgregarRespuesta("I","01001001",i);
						break;
					case "J":
						AgregarRespuesta("j","01001010",i);
						break;
					case "K":
						AgregarRespuesta("K","01001011",i);
						break;
					case "L":
						AgregarRespuesta("L","01001100",i);
						break;
					case "M":
						AgregarRespuesta("M","01001101",i);
						break;
					case "N":
						AgregarRespuesta("N","01001110",i);
						break;
					case "O":
						AgregarRespuesta("O","01001111",i);
						break;
					case "P":
						AgregarRespuesta("P","01010000",i);
						break;
					case "Q":
						AgregarRespuesta("Q","01010001",i);
						break;
					case "R":
						AgregarRespuesta("R","01010010",i);
						break;
					case "S":
						AgregarRespuesta("S","01010011",i);
						break;
					case "T":
						AgregarRespuesta("T","01010100",i);
						break;
					case "U":
						AgregarRespuesta("U","01010101",i);
						break;
					case "V":
						AgregarRespuesta("V","01010110",i);
						break;
					case "W":
						AgregarRespuesta("W","01010111",i);
						break;
					case "X":
						AgregarRespuesta("X","01011000",i);
						break;
					case "Y":
						AgregarRespuesta("Y","01011001",i);
						break;
					case "Z":
						AgregarRespuesta("Z","01011010",i);
						break;
					case "[":
						AgregarRespuesta("[","01011011",i);
						break;
					case "\\":
						AgregarRespuesta("\\","01011100",i);
						break;
					case "]":
						AgregarRespuesta("]","01011101",i);
						break;
					case "^":
						AgregarRespuesta("^","01011110",i);
						break;
					case "_":
						AgregarRespuesta("_","01011111",i);
						break;
					case "·":
						AgregarRespuesta("·","01100000",i);
						break;
					case "a":
						AgregarRespuesta("a","01100001",i);
						break;
					case "b":
						AgregarRespuesta("b","01100010",i);
						break;
					case "c":
						AgregarRespuesta("c","01100011",i);
						break;
					case "d":
						AgregarRespuesta("d","01100100",i);
						break;
					case "e":
						AgregarRespuesta("e","01100101",i);
						break;
					case "f":
						AgregarRespuesta("f","01100110",i);
						break;
					case "g":
						AgregarRespuesta("g","01100111",i);
						break;
					case "h":
						AgregarRespuesta("h","01101000",i);
						break;
					case "i":
						AgregarRespuesta("i","01101001",i);
						break;
					case "j":
						AgregarRespuesta("j","01101010",i);
						break;
					case "k":
						AgregarRespuesta("k","01101011",i);
						break;
					case "l":
						AgregarRespuesta("l","01101100",i);
						break;
					case "m":
						AgregarRespuesta("m","01101101",i);
						break;
					case "n":
						AgregarRespuesta("n","01101110",i);
						break;
					case "o":
						AgregarRespuesta("o","01101111",i);
						break;
					case "p":
						AgregarRespuesta("p","01110000",i);
						break;
					case "q":
						AgregarRespuesta("q","01110001",i);
						break;
					case "r":
						AgregarRespuesta("r","01110010",i);
						break;
					case "s":
						AgregarRespuesta("s","01110011",i);
						break;
					case "t":
						AgregarRespuesta("t","01110100",i);
						break;
					case "u":
						AgregarRespuesta("u","01110101",i);
						break;
					case "v":
						AgregarRespuesta("v","01110110",i);
						break;
					case "w":
						AgregarRespuesta("w","01110111",i);
						break;
					case "x":
						AgregarRespuesta("x","01111000",i);
						break;
					case "y":
						AgregarRespuesta("y","01111001",i);
						break;
					case "z":
						AgregarRespuesta("z","01111010",i);
						break;
					case "{":
						AgregarRespuesta("{","01111011",i);
						break;
					case "|":
						AgregarRespuesta("|","01111100",i);
						break;
					case "}":
						AgregarRespuesta("}","01111101",i);
						break;
					case "~":
						AgregarRespuesta("~","11111110",i);
						break;
				}
			}
			if(cantidad==1)
				return "Se almacenara en un byte";
			if(cantidad==2)
				return "Se almacenara en una palabra";
			if(cantidad<=4)
				return "Se almacenara en una palabra doble";
			var palabraDoble=0;
			if(cantidad%4!=0)
				palabraDoble++;
			palabraDoble += parseInt(cantidad/4);
			return "Se almacenara en "+palabraDoble+" Palabra doble";
	}
}
function AgregarRespuestaAlmacenaje(valor,binario){
	var contador=parseInt(valor/12)+1;
	if(valor%12==0 && valor!=0){
		$("#res").append('<table class="tablita"><tr id="tr'+contador+'"></tr><tr id="t'+contador+'r"></tr></table>');
	}
	$("#tr"+contador).append('<td>'+(valor+1)+'</td>');
	$("#t"+contador+"r").append('<td>'+binario+'</td>');
}
function AgregarRespuesta(valor,binario,vez){
	var contador=parseInt(vez/12)+1;
	if(vez%12==0 && vez!=0){
		$("#res").append('<table class="tablita"><tr id="tr'+contador+'"></tr><tr id="t'+contador+'r"></tr></table>');
	}
	$("#tr"+contador).append('<td>'+valor+'</td>');
	$("#t"+contador+"r").append('<td>'+binario+'</td>');
}
function VerificarBase(){
	var numero = $("#txt1").val();
	switch($("#select1").val()){
		case "2":
			if(numero=="")
				return -2;
			for(var i=0;i<numero.length;i++){
				if(numero.charAt(i)!="0"&&numero.charAt(i)!="1")
					return -1;
			}
			return 2;
		case "8":
			if(numero=="")
				return -2;
			for(var i=0;i<numero.length;i++){
				if(numero.charAt(i)!="0"&&numero.charAt(i)!="1"&&numero.charAt(i)!="2"&&numero.charAt(i)!="3"
				&&numero.charAt(i)!="4"&&numero.charAt(i)!="5"&&numero.charAt(i)!="6"&&numero.charAt(i)!="7")
					return -1;
			}
			return 8;
		case "10":
			if(numero=="")
				return -2;
			for(var i=0;i<numero.length;i++){
				if(numero.charAt(i)!="0"&&numero.charAt(i)!="1"&&numero.charAt(i)!="2"&&numero.charAt(i)!="3"
				&&numero.charAt(i)!="4"&&numero.charAt(i)!="5"&&numero.charAt(i)!="6"&&numero.charAt(i)!="7"
				&&numero.charAt(i)!="8"&&numero.charAt(i)!="9")
					return -1;
			}
			return 10;
		case "16":
			if(numero=="")
				return -2;
			for(var i=0;i<numero.length;i++){
				if(numero.charAt(i)!="0"&&numero.charAt(i)!="1"&&numero.charAt(i)!="2"&&numero.charAt(i)!="3"
				&&numero.charAt(i)!="4"&&numero.charAt(i)!="5"&&numero.charAt(i)!="6"&&numero.charAt(i)!="7"
				&&numero.charAt(i)!="8"&&numero.charAt(i)!="9"&&numero.charAt(i)!="A"&&numero.charAt(i)!="B"
				&&numero.charAt(i)!="C"&&numero.charAt(i)!="D"&&numero.charAt(i)!="E"&&numero.charAt(i)!="F"
				&&numero.charAt(i)!="a"&&numero.charAt(i)!="b"&&numero.charAt(i)!="c"&&numero.charAt(i)!="d"
				&&numero.charAt(i)!="e"&&numero.charAt(i)!="f")
					return -1;
			}
			return 16;
	}
}
function CambioBase(base){
	var base2 = $("#select2").val();
	switch(base){
		case -1:
			return "Numero o base erronea";
		case -2:
			return "Escriba un numero";
		case 2:
			switch(base2){
				case "2":
					return $("#txt1").val();
				case "8":
					return BinarioAOctal($("#txt1").val());
				case "10":
					return BinarioADecimal();
				case "16":
					return BinarioAHexadecimal($("#txt1").val());
			}
		case 8:
			switch(base2){
				case "2":
					return OctalABinario($("#txt1").val());
				case "8":
					return $("#txt1").val();
				case "10":
					return Rufini(8); 
				case "16":
					return BinarioAHexadecimal(OctalABinario($("#txt1").val()));
			}
		case 10:
			switch(base2){
				case "2":
					return DecimalABinario($("#txt1").val());
				case "8":
					return DecimalAOctal();
				case "10":
					return $("#txt1").val();
				case "16":
					return DecimalAHexadecimal();
			}
		case 16:
			switch(base2){
				case "2":
					return HexadecimalABinario($("#txt1").val());
				case "8":
					return BinarioAOctal(HexadecimalABinario($("#txt1").val()));
				case "10":
					return Rufini(16);
				case "16":
					return $("#txt1").val();
			}
	}
}
function BinarioADecimal(){
	var nivel=1;
	var resultado=0;
	for(var l=$("#txt1").val().length-1;l>=0;l--){
		if($("#txt1").val().charAt(l)=="1")
			resultado+=nivel;
		nivel*=2;
	}
	return resultado;
}
function DecimalABinario(deci){
	var numero=deci;
	var digitos=[];
	var resultado="";
	while(numero>=2){
		if(numero%2==0)
			digitos.push(0);
		else
			digitos.push(1);
		numero/=2;
		numero=parseInt(numero);
	}
	digitos.push(numero);
	for(var j=digitos.length-1;j>=0;j--)
		resultado+=digitos[j];
	return resultado;
}
function DecimalAOctal(){
	var numero=parseInt($("#txt1").val());
	var digitos=[];
	var resultado="";
	while(numero>=8){
		digitos.push(numero%8);
		numero/=8;
		numero=parseInt(numero);
	}
	digitos.push(numero);
	for(var j=digitos.length-1;j>=0;j--)
		resultado+=digitos[j];
	return resultado;
}
function DecimalAHexadecimal(){
	var numero=parseInt($("#txt1").val());
	var digitos=[];
	var resultado="";
	while(numero>=16){
		digitos.push(numero%16);
		numero/=16;
		numero=parseInt(numero);
	}
	digitos.push(numero);
	for(var j=digitos.length-1;j>=0;j--){
		switch(digitos[j]){
			case 10:
				resultado+="A";
				break;
			case 11:
				resultado+="B";
				break;
			case 12:
				resultado+="C";
				break;
			case 13:
				resultado+="D";
				break;
			case 14:
				resultado+="E";
				break;
			case 15:
				resultado+="F";
				break;
			default:
				resultado+=digitos[j];
		}
	}	
	return resultado;
}
function BinarioAOctal(bina){
	var resultado="";
	var numero=bina;
	var etapa="";
	while(numero.length>2){
		for(var i=numero.length-3;i<numero.length;i++)
			etapa+=numero.charAt(i);
		switch(etapa){
			case "000":
				resultado+=0;
				break;
			case "001":
				resultado+=1;
				break;
			case "010":
				resultado+=2;
				break;
			case "011":
				resultado+=3;
				break;
			case "100":
				resultado+=4;
				break;
			case "101":
				resultado+=5;
				break;
			case "110":
				resultado+=6;
				break;
			case "111":
				resultado+=7;
				break;
		}
		etapa="";
		numero=numero.slice(0,numero.length-3);
	}
	if(numero.length==2){
		for(var i=0;i<numero.length;i++)
			etapa+=numero.charAt(i);
		switch(etapa){
			case "00":
				resultado+=0;
				break;
			case "01":
				resultado+=1;
				break;
			case "10":
				resultado+=2;
				break;
			case "11":
				resultado+=3;
				break;
		}
	}
	if(numero.length==1){
		if(numero=="0")
			resultado+=0;
		else
			resultado+=1;
	}
	var invertir="";
	for(var z=resultado.length-1;z>=0;z--)
		invertir+=resultado.charAt(z);
	while(invertir.charAt(0)==0){
		invertir=invertir.slice(1);
	}
	return invertir;
}
function BinarioAHexadecimal(hexa){
	var resultado="";
	var numero=hexa;
	var etapa="";
	while(numero.length>3){
		for(var i=numero.length-4;i<numero.length;i++)
			etapa+=numero.charAt(i);
		switch(etapa){
			case "0000":
				resultado+=0;
				break;
			case "0001":
				resultado+=1;
				break;
			case "0010":
				resultado+=2;
				break;
			case "0011":
				resultado+=3;
				break;
			case "0100":
				resultado+=4;
				break;
			case "0101":
				resultado+=5;
				break;
			case "0110":
				resultado+=6;
				break;
			case "0111":
				resultado+=7;
				break;
			case "1000":
				resultado+=8;
				break;
			case "1001":
				resultado+=9;
				break;
			case "1010":
				resultado+="A";
				break;
			case "1011":
				resultado+="B";
				break;
			case "1100":
				resultado+="C";
				break;
			case "1101":
				resultado+="D";
				break;
			case "1110":
				resultado+="E";
				break;
			case "1111":
				resultado+="F";
				break;
		}
		etapa="";
		numero=numero.slice(0,numero.length-4);
	}
	if(numero.length==3){
		for(var i=0;i<numero.length;i++)
			etapa+=numero.charAt(i);
		switch(etapa){
			case "000":
				resultado+=0;
				break;
			case "001":
				resultado+=1;
				break;
			case "010":
				resultado+=2;
				break;
			case "011":
				resultado+=3;
				break;
			case "100":
				resultado+=4;
				break;
			case "101":
				resultado+=5;
				break;
			case "110":
				resultado+=6;
				break;
			case "111":
				resultado+=7;
				break;
		}
	}
	if(numero.length==2){
		for(var i=0;i<numero.length;i++)
			etapa+=numero.charAt(i);
		switch(etapa){
			case "00":
				resultado+=0;
				break;
			case "01":
				resultado+=1;
				break;
			case "10":
				resultado+=2;
				break;
			case "11":
				resultado+=3;
				break;
		}
	}
	if(numero.length==1){
		if(numero=="0")
			resultado+=0;
		else
			resultado+=1;
	}
	var invertir="";
	for(var z=resultado.length-1;z>=0;z--)
		invertir+=resultado.charAt(z);
	while(invertir.charAt(0)==0){
		invertir=invertir.slice(1);
	}
	return invertir;
}
function OctalABinario(bina){
	var numero=bina;
	$("#txt2").val("");
	resultado="";
	for(var i=0;i<numero.length;i++){
		switch(numero.charAt(i)){
			case "0":
				resultado+="000";
				break;
			case "1":
				resultado+="001";
				break;
			case "2":
				resultado+="010";
				break;
			case "3":
				resultado+="011";
				break;
			case "4":
				resultado+="100";
				break;
			case "5":
				resultado+="101";
				break;
			case "6":
				resultado+="110";
				break;
			case "7":
				resultado+="111";
				break;
		}
	}
	while(resultado.charAt(0)==0){
		resultado=resultado.slice(1);
	}
	return resultado;
}
function HexadecimalABinario(hexa){
	var numero=hexa;
	$("#txt2").val("");
	resultado="";
	for(var i=0;i<numero.length;i++){
		switch(numero.charAt(i)){
			case "0":
				resultado+="0000";
				break;
			case "1":
				resultado+="0001";
				break;
			case "2":
				resultado+="0010";
				break;
			case "3":
				resultado+="0011";
				break;
			case "4":
				resultado+="0100";
				break;
			case "5":
				resultado+="0101";
				break;
			case "6":
				resultado+="0110";
				break;
			case "7":
				resultado+="0111";
				break;
			case "8":
				resultado+="1000";
				break;
			case "9":
				resultado+="1001";
				break;
			case "A":
			case "a":
				resultado+="1010";
				break;
			case "B":
			case "b":
				resultado+="1011";
				break;
			case "C":
			case "c":
				resultado+="1100";
				break;
			case "D":
			case "d":
				resultado+="1101";
				break;
			case "E":
			case "e":
				resultado+="1110";
				break;
			case "F":
			case "f":
				resultado+="1111";
				break;
		}
	}
	while(resultado.charAt(0)==0){
		resultado=resultado.slice(1);
	}
	return resultado;
}
function Rufini(base){
	var resultado=0;
	var numero=$("#txt1").val();
	for(var i=0;i<numero.length;i++){
		switch(numero.charAt(i)){
			case "0":
				resultado+=0;
				break;
			case "1":
				resultado+=1;
				break;
			case "2":
				resultado+=2;
				break;
			case "3":
				resultado+=3;
				break;
			case "4":
				resultado+=4;
				break;
			case "5":
				resultado+=5;
				break;
			case "6":
				resultado+=6;
				break;
			case "7":
				resultado+=7;
				break;
			case "8":
				resultado+=8;
				break;
			case "9":
				resultado+=9;
				break;
			case "A":
			case "a":
				resultado+=10;
				break;
			case "B":
			case "b":
				resultado+=11;
				break;
			case "C":
			case "c":
				resultado+=12;
				break;
			case "D":
			case "d":
				resultado+=13;
				break;
			case "E":
			case "e":
				resultado+=14;
				break;
			case "F":
			case "f":
				resultado+=15;
				break;
		}
		if(i!=numero.length-1)
			resultado*=base;
	}
	return resultado;
}