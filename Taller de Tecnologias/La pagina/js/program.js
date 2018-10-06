$( document ).ready(function() {
  $("#pRes").html("primera");
  $.ajax({
    type:"GET",
    data:null,
    contentType:'application/json',
    url:"http://localhost:8060/api/wsClientes",
    success:function(data){
      data.forEach(function(e) {
        $("#tbyP").append('<tr><td>'+e.nombre+'</td><td>'+e.edad+'</td><td>'+e.genero+'</td></tr>');
      });
      $("#lblRes").html("bien");
    },
    error:function(data){
      $("#lblRes").html("mal");
    }
  });
});
function Probando()
{
  document.getElementById("pRes").innerHTML ="re bien";
  $("#pRes").html("fantastic");
}
function AgregarPersonas()
{
  var nombre = $("#txtNom").val();
  var edad = $("#numNum").val();
  if(document.getElementById("rdoM").checked)
    genero="M"
  else
  {
    if(document.getElementById("rdoF").checked)
      genero="F"
    else
      genero="O"
  }
  var persona={nombre:nombre,edad:edad,genero:genero};
  $.ajax({
    type:"POST",
    data:JSON.stringify(persona),
    contentType:'application/json',
    url:"http://localhost:8060/api/wsAddCliente",
    success:function(data){
      $("#lblRes").html("Persona agregada");
    },
    error:function(data){
      $("#lblRes").html("Terrible error");
    }
  });
}
