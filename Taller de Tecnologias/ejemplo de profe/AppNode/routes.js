'use strict'
const express = require("express");
const api = express.Router();
const ctrPersona = require("./controllers/ctrPersona");

api.get("/persona", ctrPersona.getPersonas);
api.get("/persona/:idPersona", ctrPersona.getPersona);
api.post("/persona",ctrPersona.addPersona);
api.put("/persona/:idPersona", ctrPersona.updatePersona);
api.delete("/persona/:idPersona",ctrPersona.deletePersona);



module.exports = api;
