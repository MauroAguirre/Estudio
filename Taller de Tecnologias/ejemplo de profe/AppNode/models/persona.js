'use strict'

const mongoose = require("mongoose");
const Schema = mongoose.Schema;

const Telefono = Schema({
    numero: Number
})

const Persona = Schema({
    nombre: String,
    edad: { type:Number,default:1},
    genero: {type:String, enum:['M', 'F']},
    telefonos: [{type:Telefono}]


})

module.exports = mongoose.model("Persona", Persona);
