$(document).ready(function(){
	$("#btn1").click(Verificar);
});
function Verificar(){
	texto=$("#txt1").val();
	lugar=2;
	suma=0;
	for(var l=texto.length-2;l>=0;l--){
		if(lugar==1){
			lugar=2;
			switch(texto.charAt(l)){
				case "1":
					suma+=1;
					break;
				case "2":
					suma+=2;
					break;
				case "3":
					suma+=3;
					break;
				case "4":
					suma+=4;
					break;
				case "5":
					suma+=5;
					break;
				case "6":
					suma+=6;
					break;
				case "7":
					suma+=7;
					break;
				case "8":
					suma+=8;
					break;
				case "9":
					suma+=9;
			}
		}
		else{
			lugar=1;
			switch(texto.charAt(l)){
					case "0":
					case "1":
					case "2":
					case "3":
					case "4":
						suma+=parseInt(texto.charAt(l))*2;
						break;
					case "5":
						suma+=1;
						break;
					case "6":
						suma+=3;
						break;
					case "7":
						suma+=5;
						break;
					case "8":
						suma+=7;
						break;
					case "9":
						suma+=9;
						break;
			}
		}
	}
	suma*=9;
	suma=suma.toString();
	if(suma.charAt(suma.length-1)==texto.charAt(texto.length-1))
		$("#Res").html("El digito es valido");
	else
		$("#Res").html("El digito no es valido");
}