using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dominio;

namespace Obligatorio_parte_dos
{
    public partial class Inicio : System.Web.UI.Page
    {
        Eventos2017 eventos2017 = Eventos2017.Instancia;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                Session["Organizador"] = null;
                Session["Administrador"] = null;
            }
        }
        protected void btnLog_Click(object sender, EventArgs e)
        {
            foreach (Administrador administrador in eventos2017.DarAdministradores())
            {
                if (txtMailLog.Text == administrador.Mail && txtContraseñaLog.Text == administrador.DarContraseña())
                {
                    //Response.Redirect("Administradores.aspx");
                    Session["Sistema"] = eventos2017;
                    Session["Administrador"] = administrador;
                    Server.Transfer("Administradores.aspx", true);
                }
            }
            foreach (Organizador organizador in eventos2017.DarOrganizadores())
            {
                if (txtMailLog.Text == organizador.Mail && txtContraseñaLog.Text == organizador.DarContraseña())
                {
                    Session["Sistema"] = eventos2017;
                    Session["Organizador"] = organizador;
                    Server.Transfer("Organizadores.aspx", true);
                }
            }
            lblRespuesta.Text = "Error";
        }
    }

}