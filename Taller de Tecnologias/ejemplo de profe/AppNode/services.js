'use strict'

const express = require("express");
const bodyParser = require("body-parser");
const app = express();
const api = require("./routes");


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
app.use("/api", api);

module.exports = app;

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
