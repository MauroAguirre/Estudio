'use strict'
const Persona = require("../models/persona");


function getPersona(req,res)
{
  let idPersona = req.params.idPersona;

  Persona.findById(idPersona, (err, persona) => {
      if(err) return res.status(500).send({msg:"Error al realziar la petición"});
      if(!persona) return res.status(404).send({msg:"Persona no existe"});

      res.status(200).send({persona});
  })
}

function getPersonas(req,res)
{
  Persona.find({}, (err, colPersonas) => {
      if(err) return res.status(500).send({msg:"Error al realziar la petición"});
      if(!colPersonas) return res.status(404).send({msg:"No hay personas"});

      res.status(200).send({colPersonas});
  })
}

function addPersona(req,res)
{
  console.log(req.body);

  let per = new Persona();
  per.nombre = req.body.nombre;
  per.edad = req.body.edad;
  per.genero = req.body.genero;
  per.telefonos = req.body.telefonos;

  per.save((err, persona) =>{
    if(err) res.status(500).send({msg:"Error al guardar en la base de datos"})
    res.status(200).send({persona:persona})
  })

}

function updatePersona(req,res)
{
  let idPersona = req.params.idPersona;
  let entityUpdate = req.body;

  Persona.findByIdAndUpdate(idPersona,entityUpdate, (err, personaUpdate) => {
      if(err) return res.status(500).send({msg:"Error al realziar la petición"});

      res.status(200).send({msg:"Persona actualizado"});


  })
}

function deletePersona(req,res)
{
  let idPersona = req.params.idPersona;
  Persona.findById(idPersona, (err, persona) => {
      if(err) return res.status(500).send({msg:"Error al realziar la petición"});
      if(!persona) return res.status(404).send({msg:"Persona no existe"});

      persona.remove(err =>{
            if(err) return res.status(500).send({msg:"Error al realziar la petición"});
              res.status(200).send({msg:"Persona borrado"});
      })

  })
}

module.exports = {
  getPersona,
  getPersonas,
  addPersona,
  updatePersona,
  deletePersona
}
