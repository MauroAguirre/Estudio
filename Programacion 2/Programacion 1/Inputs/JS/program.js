window.onload=Load;
function Load(){
	document.getElementById("rdoOp3").checked=true;
	document.getElementById("btnAdd").onclick=Clickeado;
}
function Clickeado(){
	var radios=document.getElementsByName("rdo");
	for(var i=0;i<radios.length;i++){
		if(radios[i].checked)
			alert(radios[i].value);
	}
}