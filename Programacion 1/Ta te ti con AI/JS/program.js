var img=[0,0,0,0,0,0,0,0,0];
$(document).ready(function(){
	$("#btn1").click(Empezar);
});
function Empezar(){
	$(".img").attr("src","resources/nada.png");
	for(var i=0;i<img.length;i++)
		img[i]=0;
	var quien=Math.floor((Math.random()*2)+1);
	if(quien==1)
		$("h2").html("Empiezas tu");
	else{
		$("h2").html("Empieza la compu");
		MovimientoAi();
	}
}
function MovimientoAi(){
	var ran;
	var moves=0;
	for(var i=0;i<9;i++){
		if(img[i]==1)
			moves++;
	}
	if(moves==0){
		ran=Math.floor((Math.random()*18)+1);
		switch(ran){
			case 1:
				img[1]=2;
				$(".img").eq(1).attr("src","resources/oni.jpg");
				break;
			case 2:
				img[3]=2;
				$(".img").eq(3).attr("src","resources/oni.jpg");
				break;
			case 3:
				img[5]=2;
				$(".img").eq(5).attr("src","resources/oni.jpg");
				break;
			case 4:
				img[7]=2;
				$(".img").eq(7).attr("src","resources/oni.jpg");
				break;
			case 5:
			case 6:
				img[0]=2;
				$(".img").eq(0).attr("src","resources/oni.jpg");
				break
			case 7:
			case 8:
				img[2]=2;
				$(".img").eq(2).attr("src","resources/oni.jpg");
				break
			case 9:
			case 10:
				img[6]=2;
				$(".img").eq(6).attr("src","resources/oni.jpg");
				break
			case 11:
			case 12:
				img[8]=2;
				$(".img").eq(8).attr("src","resources/oni.jpg");
				break
			case 13:
			case 14:
			case 15:
			case 16:
			case 17:
			case 18:
				img[4]=2;
				$(".img").eq(4).attr("src","resources/oni.jpg");
		}
	}
	if(moves==1){
		
	}
}