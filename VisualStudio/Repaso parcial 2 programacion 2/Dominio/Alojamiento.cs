using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Alojamiento:IComparable<Alojamiento>
    {
        private string codigo;
        private string ubicacion;
        private int canMaxHuespedes;

        public string Codigo
        {
            get { return codigo; }
        }
        public string Unicacion
        {
            get { return ubicacion; }
        }
        public int CanMaxHuespedes
        {
            get { return canMaxHuespedes; }
        }
        public Alojamiento(string codigo,string ubicacion,int canMaxHuespedes)
        {
            this.codigo = codigo;
            this.ubicacion = ubicacion;
            this.canMaxHuespedes = canMaxHuespedes;
        }

        public virtual int Costo(int dias)
        {
            return 0;
        }
        public int CompareTo(Alojamiento a)
        {
            return a.canMaxHuespedes - canMaxHuespedes;
        }
    }
}
