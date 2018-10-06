using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Cabaña :Alojamiento,IComparable<Cabaña>
    {
        private int canHabitaciones;
        private bool aireCondicionado;
        private bool parrilleroIndividual;
        private int costoBase;  //es igual siempre

        public Cabaña(int canHabitaciones, bool aireCondicionado, bool parrilleroIndividual,string codigo,string ubicacion,int canMaxHuespedes) : base(codigo, ubicacion, canMaxHuespedes)
        {
            this.canHabitaciones = canHabitaciones;
            this.aireCondicionado = aireCondicionado;
            this.parrilleroIndividual = parrilleroIndividual;
            costoBase = 60;
        }

        public override int Costo(int dias)
        {
            int costo = dias * costoBase + (300*canHabitaciones);
            if (aireCondicionado == true)
                costo += canHabitaciones * 150;
            if (parrilleroIndividual == false)
                costo -= costo * 10 / 100;
            return costo;
        }
        public override string ToString()
        {
            string aire="no";
            string parrilla = "no";
            if (parrilleroIndividual)
                parrilla = "si";
            if (aireCondicionado)
                aire = "si";
            return "Codigo: " + Codigo + "\nUnicacion: " + Unicacion + "\nCantidad maxima de huespedes: " + CanMaxHuespedes + "\nCantidad de habitaciones: " + canHabitaciones + "\nTiene aire acondicionado?: " + aire + "\nTiene parrillero individual:? " + parrilla;
        }
        public int CompareTo(Cabaña c)
        {
            return canHabitaciones - c.canHabitaciones;
        }
    }
}
