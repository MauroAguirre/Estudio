using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class ServiciosComprados
    {
        private int personas;
        private Servicio servicio;
        public int Personas 
        {
            get { return personas; }
        }
        public string NombreServicio
        {
            get { return servicio.Nombre; }
        }
        public ServiciosComprados(int personas, Servicio servicio)
        {
            this.personas = personas;
            this.servicio = servicio;
        }
        //Devuelve el precio del servicio
        public int DarPrecio()
        {
            return personas * servicio.CostoPorPersona;
        }
        public override string ToString()
        {
            return "\nNombre: " + servicio.Nombre + "\nCantidad de personas: "+personas+"\nCosto por persona: " + servicio.CostoPorPersona;
        }
        public string darNombreServicio() 
        {
            return servicio.Nombre;
        }
    }
}
