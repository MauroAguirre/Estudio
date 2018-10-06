using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dominio;

namespace Obligatorio_parte_dos
{
    public partial class Administradores : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Administrador"] == null)
                Response.Redirect("Inicio.aspx");
        }

        protected void btnIngresarAdministrador_Click(object sender, EventArgs e)
        {
            Server.Transfer("Ingresar administrador.aspx", true);
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            Server.Transfer("Lista de usuarios.aspx", true);
        }

        protected void Unnamed_Click1(object sender, EventArgs e)
        {
            Server.Transfer("Ingresar organizador.aspx", true);
        }

        protected void btnRegresar_Click(object sender, EventArgs e)
        {
            Session["Administrador"] = null;
            Response.Redirect("Inicio.aspx");
        }
    }
}