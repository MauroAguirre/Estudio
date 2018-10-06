window.onload = load;

function load()
{
    getPersonas();
    var btnAgregar = document.getElementById("btnAgregar");
    btnAgregar.onclick = AgregarPersona;

}

function AgregarPersona()
{
   var nombre = document.getElementById("txtNombre").value;
   var edad = document.getElementById("txtEdad").value;

   var persona = {};
   persona.nombre = nombre;
   persona.edad = edad;

   $.ajax({
      type: "POST",
      dataType: "json",
      data: JSON.stringify(persona),
      contentType: 'application/json',
      url: "http://localhost:8060/api/persona",
      success: function(data){
          getPersonas();
      },
      error: function(data)
      {

      }
    })


}

function getPersonas()
{
  $.ajax({
     type: "GET",
     url: "http://localhost:8060/api/persona",
     success: function(data){
        var colPersonas = data.colPersonas;

        var cuerpoTabla = document.getElementById("cuerpoTabla");
        cuerpoTabla.innerHTML = "";
        for(var i = 0; i<colPersonas.length; i++)
        {
            cuerpoTabla.innerHTML += "<tr><td>"+colPersonas[i].nombre+"</td><td>"+colPersonas[i].edad+"</td><td>"+colPersonas[i].genero+"</td></tr>";
        }
     },
     error: function(data)
     {

     }
   })
}
