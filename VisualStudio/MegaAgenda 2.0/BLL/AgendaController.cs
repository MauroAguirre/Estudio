using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using DAL;

namespace BLL
{
    public class AgendaController
    {
        private static AgendaController instance = null;
        public static AgendaController Instance()
        {
            if (AgendaController.instance == null)
            {
                AgendaController.instance = new AgendaController();
            }
            return AgendaController.instance;
        }
        public void Crear(String nombre)
        {
            Agenda agenda = new Agenda();
            agenda.Nombre = nombre;
            agenda.FechaCreacion = DateTime.Now;
            Crear(agenda);
        }
        public void Crear(Agenda agenda)
        {
            AgendaService agendaService = new AgendaService();
            agendaService.Crear(agenda);
        }
        public Agenda Obtener()
        {
            return null;
        }
        public void Mostrar()
        {
            AgendaService agendaService = new AgendaService();
            agendaService.Mostrar();
        }
        public String Nombre_agenda(int cual)
        {
            AgendaService agendaService = new AgendaService();
            return agendaService.Nombre_agenda(cual);
        }
        public void Borrar(string nombre)
        {
            AgendaService agendaService = new AgendaService();
            agendaService.Borrar(nombre);
        }
        public void Modificar(string lugar,string nuevo)
        {
            AgendaService agendaService = new AgendaService();
            agendaService.Modificar(lugar,nuevo);
        }
    }
}
