using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dominio;

namespace Obligatorio_parte_dos
{
    public partial class Organizadores : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Organizador"] == null)
                Response.Redirect("Inicio.aspx");
        }

        protected void btnIngresarEventoPremium_Click(object sender, EventArgs e)
        {
            Session["serviciosElegidos"] = null;
            /////////////
            Response.Redirect("Ingresar evento premium.aspx");
        }

        protected void btnIngresarEventoNormal_Click(object sender, EventArgs e)
        {
            Session["serviciosElegidos"] = null;
            /////////
            Response.Redirect("Ingresar evento normal.aspx");
        }

        protected void btnListaEventos_Click(object sender, EventArgs e)
        {
            Response.Redirect("Eventos de organizador.aspx");
        }

        protected void btnRegresar_Click(object sender, EventArgs e)
        {
            Session["Organizador"] = null;
            Response.Redirect("Inicio.aspx");
        }
    }
}