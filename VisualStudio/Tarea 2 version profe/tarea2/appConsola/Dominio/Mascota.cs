using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Mascota
    {

        //servicios
        private static int ultCodigo;
        private int codigo;
        private string nombre;
        private List<ServicioComprado> servicios;
        Cliente dueño;

        public void AgregarServicio(ServicioComprado unSC)
        {
            servicios.Add(unSC);
        }
        public List<ServicioComprado> DarServicios()
        {
            List<ServicioComprado> auxServicios = new List<ServicioComprado>();
            foreach (ServicioComprado servicito in servicios)
            {
                auxServicios.Add(servicito);
            }
            return auxServicios;
        }

        public Mascota(string nombre, Cliente dueño)
        {
            this.codigo = ultCodigo;
            ultCodigo++;
            this.nombre = nombre;
            this.dueño = dueño;
            servicios = new List<ServicioComprado>();
            
        }
        public override string ToString()
        {
            string stringServicios = "";
            foreach (ServicioComprado unaS in servicios)
            {
                stringServicios += "\n\t\t" + unaS;
            }


            return codigo + "--" + nombre + stringServicios;
        }
        

        public int Codigo
        {
            get { return codigo; }           
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public Cliente Dueño
        {
            get { return dueño; }
            set { dueño = value; }
        }
        public bool TieneServicio() 
        {
            if (servicios.Count != 0)
                return true;
            return false;
        }

    }
}
