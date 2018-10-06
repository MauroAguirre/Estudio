"user strict"
const mongoose = require("mongoose");
const Schema = mongoose.Schema;
const personas = Schema({
  nombre:String,
  edad:{type:Number,default:1},
  genero:{type:String,enum:['M','F','O']}
});
module.exports = mongoose.model("personas",personas);
