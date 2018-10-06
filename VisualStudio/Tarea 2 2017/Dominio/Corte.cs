using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Corte : Servicio
    {
        #region Atributos
        private bool tipo;
        private bool corteUñas;
        #endregion
        #region Constructor
        public Corte(string nuevaDescripcion, int nuevoPrecio, bool nuevoTipo, bool nuevoCorteUñas) :base(nuevaDescripcion, nuevoPrecio)
        {
            tipo = nuevoTipo;
            corteUñas = nuevoCorteUñas;
        }
        public override string ToString()
        {
            string respuesta;
            string cualtipo;
            if (corteUñas)
                respuesta = "si";
            else
                respuesta = "no";
            if (tipo)
                cualtipo = "estandar";
            else
                cualtipo = "concurso";
            return "Descripcion: " + this.Descripcion + "\nPrecio: "+Precio+"\nSe cortan las uñas? "+respuesta+"\nEl corte es de tipo "+cualtipo;
        }
        #endregion
    }
}
