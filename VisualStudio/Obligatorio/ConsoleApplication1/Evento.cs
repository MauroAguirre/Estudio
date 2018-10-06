using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio
{
    class Evento
    {
        public enum Turno { mañana, tarde, noche };
        #region Atributos
        private Organizador organizador;
        private DateTime fecha;
        private string descripcion;
        private string cliente;
        private bool tipo;
        private int asistentes;
        private int personas;
        private int duracion;
        private int montoFijo;
        private List<Servicio> servicios;
        #endregion
        #region Metodos
        #endregion
    }
}
