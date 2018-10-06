var alto=parseInt(prompt("Ingrese alto"));
var largo=alto;
for (var i=1;i<=alto;i++){
	for (var l=1;l<=largo;l++){
		document.write("*");
	}
	document.write('<br>');
	largo--;
}