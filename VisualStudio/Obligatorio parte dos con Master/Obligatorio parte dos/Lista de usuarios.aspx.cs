using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dominio;

namespace Obligatorio_parte_dos
{
    public partial class Lista_de_usuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) 
            {
                if (Session["Administrador"] == null)
                    Response.Redirect("Inicio.aspx");
                Eventos2017 eventos2017 = Session["Sistema"] as Eventos2017;
                ddlAdministradores.DataSource = eventos2017.DarOrganizadores();
                ddlOrganizadores.DataSource = eventos2017.DarAdministradores();
                ddlAdministradores.DataBind();
                ddlOrganizadores.DataBind();
            }   
        }

        protected void btnListaRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Administradores.aspx");
            //Server.Transfer("Administradores.aspx", true);
        }
    }
}