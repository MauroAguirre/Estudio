window.onload =	paginaCargada;	 //para hacer cosas despues que se cargo la pagina, si no ponemos esto no anda la funcion siguiente
	var nombres=[];
	var codigo=[];
	function paginaCargada()		
	{	
		var inputbtn = document.getElementById("btnAdd");			//se puede hacer asi
		inputbtn.onclick = DarClick;								// usando dos lineas
		document.getElementById("txtNombre").onblur = OnBlurNombre;	// o asi mas chiquito
		document.getElementById("txtClave").onblur = OnBlurClave;
		document.getElementById("btnRes").onclick = Lista;
	}
	// podemos usar solo esta parte poniendo onclick="DarClick()
		function Lista(){
			document.getElementById("Res").innerHTML="";
			for(var l=0;l<nombres.length;l++)
				document.getElementById("Res").append('<br>'+"Nombre: "+nombres[l]+" Clave: "+codigo[l]);
		}
		function Ingresar(nombre,clave){/*
			if(nombre=="pepe" && clave=="1234")
				alert("Usuario y contraseña correctos");
			else
				alert("Error, usuario y/o clave incorrectos");*/
			OnBlurNombre();
			OnBlurClave();
		}
		function SuperVerificada(){
			var verdad=true;
			for(var i=0;i<nombres.length;i++){
						if(nombres[i]==document.getElementById("txtNombre").value){
							verdad=false;
							document.getElementById("lblNombre").innerHTML="El usuario ya esta agregado";
							document.getElementById("lblClave").innerHTML="";
						}
					}
			if(document.getElementById("txtNombre").value.length<12&&document.getElementById("txtClave").value.length<=4&&document.getElementById("txtClave").value!=document.getElementById("txtNombre").value&&verdad){
				nombres[nombres.length]=document.getElementById("txtNombre").value;
				codigo[codigo.length]=document.getElementById("txtClave").value;
			}			
			document.getElementById("txtNombre").value="";
			document.getElementById("txtClave").value="";
		}
		function DarClick(){
			var name = document.getElementById("txtNombre").value;	
			var pass = document.getElementById("txtClave").value;
			Ingresar(name,pass);
			SuperVerificada();
		}
		function OnBlurNombre(){
			if(document.getElementById("txtNombre").value.length>12)
				document.getElementById("lblNombre").innerHTML="Incorrecto";
			else
				document.getElementById("lblNombre").innerHTML="";
		}
		function OnBlurClave(){
			if(document.getElementById("txtClave").value.length>4||document.getElementById("txtClave").value==document.getElementById("txtNombre").value)
				document.getElementById("lblClave").textContent="Incorrecto";
			else
				document.getElementById("lblClave").textContent="";
		}