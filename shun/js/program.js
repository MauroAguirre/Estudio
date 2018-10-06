//window.onload es cuando se inicia la pagina, queremos que haga la funcion Load;
window.onload = Load;
//esta funcion le da al boton con la id Logear una funcion al hacerle click
function Load(){
  document.getElementById("Logear").onclick = Logear;
}
//esta funcion verifica el formulario, si los datos son correctos cambia de
//pagina si no envie un mensaje de error
function Logear(){
  var mail = document.getElementById("mail").value;
  var contra = document.getElementById("contra").value;
  if( mail  ==  "jun@gmail.com" && contra == "123"){
    location.href="file:///E:/Estudio/shun/tabla.html";
  }
  else{
    document.getElementById("respuesta").innerHTML="Error en los datos";
  }
}
