using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Cliente
    {
        #region Atributos
        private string cedula;
        private string nombre;
        private string direccion;
        private int telefono;
        private List<Mascota> mascotas;
        #endregion
        #region Propiedades
        public string Nombre
        {
            set { nombre = value; }
            get {return nombre;}
        }
        #endregion
        #region Constructor
        public Cliente(string nuevaCedula, string nuevoNombre, string nuevaDireccion, int nuevoTelefono)
        {
            mascotas = new List<Mascota>();
            cedula = nuevaCedula;
            nombre = nuevoNombre;
            direccion = nuevaDireccion;
            telefono = nuevoTelefono;
        }
        #endregion
        #region Metodos
        public override string ToString()
        {
            return "Cedula: " + cedula + "\nNombre: " + nombre + "\nDireccion: " + direccion + "\nTelefono: " + telefono;
        }
        public void AgregarMascota(Mascota nuevaMascota)
        {
            mascotas.Add(nuevaMascota);
        }
        public List<Mascota> DarMascotas() 
        {
            List<Mascota> auxMascotas = new List<Mascota>();
            foreach (Mascota mascota in mascotas) 
            {
                auxMascotas.Add(mascota);
            }
            return auxMascotas;
        }
        public Mascota DarMascota(int cual) 
        {
            return mascotas[cual];
        }
        public int CantidadMascotas()
        {
            return mascotas.Count();
        }
        #endregion
    }
}
