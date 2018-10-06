using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MegaAgenda.dal;
using MegaAgenda.common;

namespace MegaAgenda.bll
{
    public class AgendaController
    {

        public void crear(String nombre, DateTime fechaCreacion)
        {
            Agenda agenda = new Agenda();
            agenda.Nombre = nombre;
            agenda.FechaCreacion = fechaCreacion;
            this.crear(agenda);
        }

        public void crear(Agenda agenda)
        {
            AgendaService agendaService = new AgendaService();
            agendaService.guardar(agenda);
        }
    }
}
