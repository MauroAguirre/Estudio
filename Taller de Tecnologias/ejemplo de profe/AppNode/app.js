
const mongoose = require("mongoose");
const services = require("./services");
const config = require("./config");

mongoose.connect(config.db,config.configConnection, (err,res) =>{
  if(err) throw err
  console.log("conect ok");

  services.listen(config.port, prueba);
})

function prueba()
{
  console.log("Api REST corriendo");
}
