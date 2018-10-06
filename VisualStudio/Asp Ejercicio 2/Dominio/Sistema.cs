using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Sistema
    {
        public static Sistema instancia;
        private List<Persona> personas;
        public static Sistema Instancia
        { 
            get
            {
                if (instancia == null)
                    instancia = new Sistema();
                return instancia;
            }
        }
        public Sistema() 
        {
            personas = new List<Persona>();
        }
        public void AgregarPersona(Persona persona)
        {
            personas.Add(persona);
        }
        public List<Persona> DarLista() 
        {
            return personas;
        }
    }
}
