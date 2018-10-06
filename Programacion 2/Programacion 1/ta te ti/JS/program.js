window.onload =  PaginaCargada;
	var jugador=1;
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
			document.getElementById("img"+(i+1)).src="resources/emperor.jpg";
			document.getElementById("pa").innerHTML="Ahora juega el jugador "+jugador;
		}
	}
	function Verificar(){
		if((img[0]==1&&img[1]==1&&img[2]==1)||(img[3]==1&&img[4]==1&&img[5]==1)||(img[6]==1&&img[7]==1&&img[8]==1)
			||(img[0]==1&&img[3]==1&&img[6]==1)||(img[1]==1&&img[4]==1&&img[7]==1)||(img[2]==1&&img[5]==1&&img[8]==1)
			||(img[0]==1&&img[4]==1&&img[8]==1)||(img[2]==1&&img[4]==1&&img[6]==1)){
			document.getElementById("pa").innerHTML="Gano el jugador "+1;
		}
		if((img[0]==2&&img[1]==2&&img[2]==2)||(img[3]==2&&img[4]==2&&img[5]==2)||(img[6]==2&&img[7]==2&&img[8]==2)
			||(img[0]==2&&img[3]==2&&img[6]==2)||(img[1]==2&&img[4]==2&&img[7]==2)||(img[2]==2&&img[5]==2&&img[8]==2)
			||(img[0]==2&&img[4]==2&&img[8]==2)||(img[2]==2&&img[4]==2&&img[6]==2)){
			document.getElementById("pa").innerHTML="Gano el jugador "+2;
		}	
	}
	function ClickImg1(){
		if(img[0]==0){
			if(jugador==1){
				document.getElementById("img1").src="resources/X.jpg";
				jugador=2;
				img[0]=1;
			}
			else{
				document.getElementById("img1").src="resources/0.png";
				jugador=1;
				img[0]=2;
			}
			document.getElementById("pa").innerHTML="Ahora juega el jugador "+jugador;
		}
		Verificar();
	}
	function ClickImg2(){
		if(img[1]==0){
			if(jugador==1){
				document.getElementById("img2").src="resources/X.jpg";
				jugador=2;
				img[1]=1;
			}
			else{
				document.getElementById("img2").src="resources/0.png";
				jugador=1;
				img[1]=2;
			}
			document.getElementById("pa").innerHTML="Ahora juega el jugador "+jugador;
		}
		Verificar();
	}
	function ClickImg3(){
		if(img[2]==0){
			if(jugador==1){
				document.getElementById("img3").src="resources/X.jpg";
				jugador=2;
				img[2]=1;
			}
			else{
				document.getElementById("img3").src="resources/0.png";
				jugador=1;
				img[2]=2;
			}
			document.getElementById("pa").innerHTML="Ahora juega el jugador "+jugador;
		}
		Verificar();
	}
	function ClickImg4(){
		if(img[3]==0){
			if(jugador==1){
				document.getElementById("img4").src="resources/X.jpg";
				jugador=2;
				img[3]=1;
			}
			else{
				document.getElementById("img4").src="resources/0.png";
				jugador=1;
				img[3]=2;
			}
			document.getElementById("pa").innerHTML="Ahora juega el jugador "+jugador;
		}
		Verificar();
	}
	function ClickImg5(){
		if(img[4]==0){
			if(jugador==1){
				document.getElementById("img5").src="resources/X.jpg";
				jugador=2;
				img[4]=1;
			}
			else{
				document.getElementById("img5").src="resources/0.png";
				jugador=1;
				img[4]=2;
			}
			document.getElementById("pa").innerHTML="Ahora juega el jugador "+jugador;
		}
		Verificar();
	}
	function ClickImg6(){
		if(img[5]==0){
			if(jugador==1){
				document.getElementById("img6").src="resources/X.jpg";
				jugador=2;
				img[5]=1;
			}
			else{
				document.getElementById("img6").src="resources/0.png";
				jugador=1;
				img[5]=2;
			}
			document.getElementById("pa").innerHTML="Ahora juega el jugador "+jugador;
		}
		Verificar();
	}
	function ClickImg7(){
		if(img[6]==0){
			if(jugador==1){
				document.getElementById("img7").src="resources/X.jpg";
				jugador=2;
				img[6]=1;
			}
			else{
				document.getElementById("img7").src="resources/0.png";
				jugador=1;
				img[6]=2;
			}
			document.getElementById("pa").innerHTML="Ahora juega el jugador "+jugador;
		}
		Verificar();
	}
	function ClickImg8(){
		if(img[7]==0){
			if(jugador==1){
				document.getElementById("img8").src="resources/X.jpg";
				jugador=2;
				img[7]=1;
			}
			else{
				document.getElementById("img8").src="resources/0.png";
				jugador=1;
				img[7]=2;
			}
			document.getElementById("pa").innerHTML="Ahora juega el jugador "+jugador;
		}
		Verificar();
	}
	function ClickImg9(){
		if(img[8]==0){
			if(jugador==1){
				document.getElementById("img9").src="resources/X.jpg";
				jugador=2;
				img[8]=1;
			}
			else{
				document.getElementById("img9").src="resources/0.png";
				jugador=1;
				img[8]=2;
			}
			document.getElementById("pa").innerHTML="Ahora juega el jugador "+jugador;
		}
		Verificar();
	}
