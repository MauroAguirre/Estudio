using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Cliente
    {
        #region atributos
        private int cedula;
        private List<Mascota> mascotas;
        private string nombre;
        private string direccion;
        #endregion

        #region Propierties
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        public int Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }
        #endregion
        #region metodos
        public Cliente(string nombre, string direccion, int cedula)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.cedula = cedula;
            mascotas = new List<Mascota>();
            Mascota unaM1 = new Mascota("negrito",this);
            mascotas.Add(unaM1);
            Mascota unaM2 = new Mascota("blanquito", this);
            mascotas.Add(unaM2);



        }
        public List<Mascota> Mascotas()
        {
            return mascotas;
        }
        public void AgregarMascota(Mascota unaMascota)
        {
            mascotas.Add(unaMascota);
        }

        public override string ToString()
        {
            string stringMascotas="";
            foreach (Mascota unaM in mascotas)
            {
                stringMascotas += "\n\t" + unaM ;
            }

            return  cedula + "  " + 
                    nombre + 
                    stringMascotas;
            
        }
        public List<Mascota> DarMascotasConServicios() 
        {
            List<Mascota> mascotasConServicios = new List<Mascota>();
            foreach (Mascota mascota in mascotas) 
            {
                if (mascota.TieneServicio())
                    mascotasConServicios.Add(mascota);
            }
            return mascotasConServicios;
        }
        public int CantidadMascotas()
        {
            return mascotas.Count;
        }
        #endregion

    }
}
