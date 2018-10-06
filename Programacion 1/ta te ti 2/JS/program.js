window.onload =  PaginaCargada;
	var jugador=1;
	var fase=0;
	var playerImg1;
	var playerImg2;
	var img=[0,0,0,0,0,0,0,0,0];
	function PaginaCargada(){
		document.getElementById("img1").onclick = ClickImg1;
		document.getElementById("img2").onclick = ClickImg2;
		document.getElementById("img3").onclick = ClickImg3;
		document.getElementById("img4").onclick = ClickImg4;
		document.getElementById("img5").onclick = ClickImg5;
		document.getElementById("img6").onclick = ClickImg6;
		document.getElementById("img7").onclick = ClickImg7;
		document.getElementById("img8").onclick = ClickImg8;
		document.getElementById("img9").onclick = ClickImg9;
		document.getElementById("but").onclick = ClickReset;
	}
	function ClickReset(){
		for(var i=0;i<9;i++){ 
			img[i]=0;
			document.getElementById("img"+(i+1)).src="resources/nada.png";
			document.getElementById("pa").innerHTML="Ahora juega el jugador "+jugador;
		}
	}
	function Verificar(){
		if((img[0]==1&&img[1]==1&&img[2]==1)||(img[3]==1&&img[4]==1&&img[5]==1)||(img[6]==1&&img[7]==1&&img[8]==1)
			||(img[0]==1&&img[3]==1&&img[6]==1)||(img[1]==1&&img[4]==1&&img[7]==1)||(img[2]==1&&img[5]==1&&img[8]==1)
			||(img[0]==1&&img[4]==1&&img[8]==1)||(img[2]==1&&img[4]==1&&img[6]==1)){
			document.getElementById("pa").innerHTML="Gano el jugador "+1;
			return;
		}
		if((img[0]==2&&img[1]==2&&img[2]==2)||(img[3]==2&&img[4]==2&&img[5]==2)||(img[6]==2&&img[7]==2&&img[8]==2)
			||(img[0]==2&&img[3]==2&&img[6]==2)||(img[1]==2&&img[4]==2&&img[7]==2)||(img[2]==2&&img[5]==2&&img[8]==2)
			||(img[0]==2&&img[4]==2&&img[8]==2)||(img[2]==2&&img[4]==2&&img[6]==2)){
			document.getElementById("pa").innerHTML="Gano el jugador "+2;
			return;
		}	
		if(img[0]!=0&&img[1]!=0&&img[2]!=0&&img[3]!=0&&img[4]!=0&&img[5]!=0&&img[6]!=0&&img[7]!=0&&img[8]!=0){
			document.getElementById("pa").innerHTML="Empate";
			return;
		}
			
	}
	function ClickImagenes(id,imagen){
		switch(fase){
			case 0:
				playerImg1=imagen;
				fase++;
				document.getElementById("pa").innerHTML="Eliga la imagen para el jugador 2";
				break;
			case 1:
				playerImg2=imagen;
				fase++;
				ClickReset();
				break;
			case 2:
				if(img[imagen]==0){
					if(jugador==1){
						switch(playerImg1){
							case 0:
								document.getElementById(id).src="resources/emperor.jpg";
								break;
							case 1:
								document.getElementById(id).src="resources/irelia.jpg";
								break;
							case 2:
								document.getElementById(id).src="resources/lulu.png";
								break;
							case 3:
								document.getElementById(id).src="resources/nau.jpg";
								break;
							case 4:
								document.getElementById(id).src="resources/neko.jpg";
								break;
							case 5:
								document.getElementById(id).src="resources/poppy.jpg";
								break;
							case 6:
								document.getElementById(id).src="resources/yasuo.jpg";
								break;
							case 7:
								document.getElementById(id).src="resources/0.png";
								break;
							case 8:
								document.getElementById(id).src="resources/X.jpg";
								break;
						}
						jugador=2;
						img[imagen]=1;
					}
					else{
						switch(playerImg2){
							case 0:
								document.getElementById(id).src="resources/emperor.jpg";
								break;
							case 1:
								document.getElementById(id).src="resources/irelia.jpg";
								break;
							case 2:
								document.getElementById(id).src="resources/lulu.png";
								break;
							case 3:
								document.getElementById(id).src="resources/nau.jpg";
								break;
							case 4:
								document.getElementById(id).src="resources/neko.jpg";
								break;
							case 5:
								document.getElementById(id).src="resources/poppy.jpg";
								break;
							case 6:
								document.getElementById(id).src="resources/yasuo.jpg";
								break;
							case 7:
								document.getElementById(id).src="resources/0.png";
								break;
							case 8:
								document.getElementById(id).src="resources/X.jpg";
								break;
						}
						jugador=1;
						img[imagen]=2;
					}
					document.getElementById("pa").innerHTML="Ahora juega el jugador "+jugador;
				}
				Verificar();
		}
	}
	
	function ClickImg1(){
		ClickImagenes("img1",0);
	}
	function ClickImg2(){
		ClickImagenes("img2",1);
	}
	function ClickImg3(){
		ClickImagenes("img3",2);
	}
	function ClickImg4(){
		ClickImagenes("img4",3);
	}
	function ClickImg5(){
		ClickImagenes("img5",4);
	}
	function ClickImg6(){
		ClickImagenes("img6",5);
	}
	function ClickImg7(){
		ClickImagenes("img7",6);
	}
	function ClickImg8(){
		ClickImagenes("img8",7);
	}
	function ClickImg9(){
		ClickImagenes("img9",8);
	}

