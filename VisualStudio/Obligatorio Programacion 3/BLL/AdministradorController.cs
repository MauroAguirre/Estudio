using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Dominio;

namespace BLL
{
    public class AdministradorController
    {
        AdministradorService administradorService = new AdministradorService();
        public Administrador Agregar(Administrador administrador)
        {
            if (administrador.Contra == "" || administrador.Nombre == "" || administrador.Mail == "")
            {
                return null;
            }
            foreach (var adm in administradorService.DarAdministradores())
            {
                if (adm.Mail == administrador.Mail)
                {
                    return null;
                }
            }
            return administradorService.Crear(administrador);
        }
        public List<Administrador> DarAdministradores()
        {
            return administradorService.DarAdministradores();
        }
        public bool EsAdministrador(Usuario usuario)
        {
            foreach (Administrador adm in administradorService.DarAdministradores())
            {
                if (adm.Mail == usuario.Mail && adm.Contra == usuario.Contra)
                {
                    return true;
                }
            }
            return false;
        }
        public void Modificar(Administrador adm)
        {
            administradorService.Modificar(adm);
        }
        public void Borrar(string mail)
        {
            administradorService.Borrar(mail);
        }
    }
}
