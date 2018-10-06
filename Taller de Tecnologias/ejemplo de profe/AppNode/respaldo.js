'use strict'

const express = require("express");
const bodyParser = require("body-parser");
const mongoose = require("mongoose");
const ctrProducto = require("./controllers/ctrProducto")

const app = express();

app.use(bodyParser.urlencoded({extended:false}));
app.use(bodyParser.json());


/*
app.get('/hola/:name', (req,res) =>{
  res.send({mensaje:"Hola Mundo " + req.params.name});
});
*/
//Api rest full es ABML (GET, POST, DELETE, PUT)

//Codigos de respuesta:
//200 OK,
//300 REDIRECT,
//404 NO EXISTE RECURSO,
//403 ACESO RESTRINGIDO
//500 ERROR EN EL SERVIDOR NO CONTROLADO

app.get("/api/product", (req,res) => {


})

app.get("/api/product/:idProd", (req,res) => {
  let idProducto = req.params.idProd;

  Prod.findById(idProducto, (err, producto) => {
      if(err) return res.status(500).send({msg:"Error al realziar la petición"});
      if(!producto) return res.status(404).send({msg:"Producto no existe"});

      res.status(200).send({producto});
  })
})

app.post("/api/product", (req,res) => {
    console.log(req.body);

    let prod = new Prod();
    prod.nombre = req.body.nombre;
    prod.precio = req.body.precio;
    prod.cate = req.body.cate;

    prod.save((err, product) =>{
      if(err) res.status(500).send({msg:"Error al guardar en la base de datos"})
      res.status(200).send({Producto:product})
    })

})

app.put("/api/product/:idProd", (req,res) => {
  let idProducto = req.params.idProd;
  let entityUpdate = req.body;

  Prod.findByIdAndUpdate(idProducto,entityUpdate, (err, productoupdate) => {
      if(err) return res.status(500).send({msg:"Error al realziar la petición"});

      res.status(200).send({msg:"Producto actualizado"});


  })
})

app.delete("/api/product/:idProd", (req,res) => {
  let idProducto = req.params.idProd;
  Prod.findById(idProducto, (err, producto) => {
      if(err) return res.status(500).send({msg:"Error al realziar la petición"});
      if(!producto) return res.status(404).send({msg:"Producto no existe"});

      producto.remove(err =>{
            if(err) return res.status(500).send({msg:"Error al realziar la petición"});
              res.status(200).send({msg:"Producto borrado"});
      })

  })

})

const config = {
  autoIndex: false,
  useNewUrlParser: true,
};

mongoose.connect('mongodb://localhost:27017/tienda',config, (err,res) =>{
  if(err) throw err
  console.log("conect ok");

  app.listen("8060", prueba);
})

function prueba()
{
  console.log("Api REST corriendo");
}
