//para activar el servidor ir a E:\Estudio\Taller de Tecnologias\AppNode
//luego poner node app.js, deberia decir algun mensaje por la consola
//para resetiar el server poner control+c
"user strict"
//al ponder user strict decimos que vamos a usar javascript que tiene
//a -> b parecido al linq
const express = require("express");
const bodyParser = require("body-parser");
const mongoose = require("mongoose")
const personas = require("./models/personas");
//cargamos en las variables los paquetes que bajamos
const app = express();
app.use(function (req, res, next) {

    // Website you wish to allow to connect
    res.setHeader('Access-Control-Allow-Origin', '*');

    // Request methods you wish to allow
    res.setHeader('Access-Control-Allow-Methods', 'GET, POST, OPTIONS, PUT, PATCH, DELETE');

    // Request headers you wish to allow
    res.setHeader('Access-Control-Allow-Headers', 'X-Requested-With,content-type');

    // Set to true if you need the website to include cookies in the requests sent
    // to the API (e.g. in case you use sessions)
    res.setHeader('Access-Control-Allow-Credentials', true);

    // Pass to next layer of middleware
    next();
});
app.use(bodyParser.urlencoded({extended:false}));
app.use(bodyParser.json());

var colClientes = [{
  nombre:"Pepe",edad:18
},
{
  nombre:"Raul",edad:22
}];
//con esto parciamos las peticiones
/* la manera antigua
app.get("/api/wsClientes",GetClientes);
function GetClientes(req,res)
{
  res.status(200).send(colClientes);
}

*/
//manera mas chiquita y efectiva
app.get("/api/wsClientes",(req,res)=>{
  res.status(200).send(personas());
});
app.get("/api/wsClientes/:nombreCliente",(req,res)=>{
  var nombreCliente = req.params.nombreCliente;
  for (var i = 0; i < colClientes.length; i++) {
    if(colClientes[i].nombre==nombreCliente)
    {
        return res.status(200).send(colClientes[i]);
    }
  }
  res.status(404).send({msg:"Error no se encontro el cliente"});
});
//http://localhost:8060/api/wsAddCliente
app.post("/api/wsAddCliente",(req,res)=>{
  /*
  console.log(req.body);
  var cliente = {};
  cliente.nombre = req.body.nombre;
  cliente.edad = req.body.edad;
  colClientes.push(cliente);
  //res.send({msg:"Anduvo?"});
  res.status(200).send(colClientes);
  */
  var per = personas();
  per.nombre = req.body.nombre;;
  per.edad = req.body.edad;
  per.genero = req.body.genero;
  per.save((err,personaIngresada)=>{
    if(err)
    {
      res.status(500).send({msg:"Error al guarda"});
    }
    res.status(200).send({personaIngresada});
  });
});
app.put("/api/wsModCliente/:nombreCliente",(req,res)=>{
  console.log(req.body);
  var cliente = {};
  var encontro = false;
  var nombreCliente = req.params.nombreCliente;
  cliente.nombre = req.body.nombre;
  cliente.edad = req.body.edad;
  for (var i = 0; i < colClientes.length; i++) {
    if(colClientes[i].nombre==nombreCliente)
    {
        encontro = true;
        colClientes[i].nombre = cliente.nombre;
        colClientes[i].edad = cliente.edad;
    }
  }
  if(encontro)
  {
    res.status(200).send(colClientes);
  }
  else
  {
    res.status(404).send({msg:"No se encontro"});
  }

});
//http://localhost:8060/api/wsDelCliente/Raul
app.delete("/api/wsDelCliente/:nombreCliente",(req,res)=>{
  console.log(req.body);
  var encontro = false;
  var nombreCliente = req.params.nombreCliente;
  for (var i = 0; i < colClientes.length; i++) {
    if(colClientes[i].nombre==nombreCliente)
    {
        encontro = true;
        colClientes.splice(i,1);
    }
  }
  if(encontro)
  {
    res.status(200).send(colClientes);
  }
  else
  {
    res.status(404).send({msg:"No se encontro"});
  }

});
var config ={
  autoIndex:false,
  useNewUrlParser:true,
};
//el nombre de la base de datos es test, si no encuentra la base de datos la crea
mongoose.connect("mongodb://localhost:27017/test",config,(err,res)=>{
  if(err) throw err;
  console.log("Connect,OK!");

  app.listen("8060",Iniciar);

});
//para entrar aca ir al navegador y poner http://localhost:8060/api/wsClientes
//app.listen("8060",Iniciar);
//require y responce

function Iniciar()
{
  console.log("app Rest anda!!");
}
