$(document).ready(function(){
	$("#btn1").click(Ejercicio_8);
	$("#btn2").click(Ejercicio_9);
});
function Ejercicio_8(){
	var num1=[1,1];
	while(num1.length<21){
		num1.push(num1[num1.length-1]+num1[num1.length-2]);
	}
	$("#res").html("");
	for(var i=0;i<num1.length;i++)
		$("#res").append(num1[i]+" ");
}
function Ejercicio_9(){
	var num2=[1,1];
	while((num2[num2.length-1]+num2[num2.length-2])<1000){
		num2.push(num2[num2.length-1]+num2[num2.length-2]);
	}
	$("#res").html("");
	for(var i=0;i<num2.length;i++)
		$("#res").append(num2[i]+" ");
}