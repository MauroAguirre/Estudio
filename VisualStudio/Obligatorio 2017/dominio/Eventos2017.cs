using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Eventos2017
    {
        #region Atributos
        private List<Administrador> administradores;
        private List<Organizador> organizadores;
        private List<Servicio> servicios;
        private static Eventos2017 instancia;
        #endregion
        #region Metodos
        public Eventos2017() 
        {
            administradores = new List<Administrador>();
            organizadores = new List<Organizador>();
            servicios = new List<Servicio>();
            Servicio ser1 = new Servicio("Bebidas",40);
            Servicio ser2 = new Servicio("Comida",100);
            Servicio ser3 = new Servicio("Musica",70);
            servicios.Add(ser1);
            servicios.Add(ser2);
            servicios.Add(ser3);
            DateTime fecha = new DateTime(12/12/1212);
            Organizador org = new Organizador("Mauro", 097414776, "piedras", fecha, "mauro@gmail.com", "Wopa1.");
            AgregarOrganizador(org);
        }
        public Eventos2017 Instancia()
        {
            if (instancia == null)
                instancia = new Eventos2017();   
            return instancia;
        }
        public void AgregarAdministrador(Administrador nuevoAdministrador)
        {
            administradores.Add(nuevoAdministrador);
        }
        public void AgregarOrganizador(Organizador nuevoOrganizador)
        {
            organizadores.Add(nuevoOrganizador);
        }
        public void AgregarEvento(Evento nuevoEvento)
        {
            if (nuevoEvento != null)
            {
                foreach (Organizador organizador in organizadores)
                {
                    if (organizador.Mail == nuevoEvento.MailEvento())
                    {
                        organizador.AgregarEvento(nuevoEvento);
                        break;
                    }
                }
            }
        }
        public List<Administrador> DarAdministradores()
        {
            List<Administrador> auxAdministradores = new List<Administrador>();
            foreach (Administrador losUsuarios in administradores)
            {
                auxAdministradores.Add(losUsuarios);
            }
            return auxAdministradores;
        }
        public List<Organizador> DarOrganizadores()
        {
            List<Organizador> auxOrganizadores = new List<Organizador>();
            foreach (Organizador organizador in organizadores)
            {
                auxOrganizadores.Add(organizador);
            }
            return auxOrganizadores;
        }
        public List<Servicio> DarServicios()
        {
            List<Servicio> axuServicios = new List<Servicio>();
            foreach (Servicio servicio in servicios)
            {
                axuServicios.Add(servicio);
            }
            return axuServicios;
        }
        #endregion
    }
}
