using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Registro_de_Estadia
    {
        private Cliente cliente;
        private DateTime fecha;
        private int cantidadDias;
        private Alojamiento alojamiento;
        private int cantidadPersonas;
        private int codigo;
        private static int ultimoCodigo;

        public Registro_de_Estadia(Cliente cliente, DateTime fecha, int cantidadDias, Alojamiento alojamiento, int cantidadPersonas)
        {
            this.cliente = cliente;
            this.fecha = fecha;
            this.cantidadDias = cantidadDias;
            this.alojamiento = alojamiento;
            this.cantidadPersonas = cantidadPersonas;
            codigo = ++ultimoCodigo;
        }

        public int Costo(int dias)
        {
            int costo = alojamiento.Costo(dias);
            if (cliente.SuPais == Cliente.Pais.Uruguay)
                costo -= costo * 10 / 100;
            return costo;
        }
    }
}
