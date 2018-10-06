using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;

namespace Obligatorio
{
    public partial class Ranking_pasajeros : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Agencia agencia = Session["Agencia"] as Agencia;
                if (agencia.DarClientesConMayorRanking().Count == 0)
                {
                    ddlPasajeros.Visible = false;
                    lblRespuesta.Visible = true;
                }
                else
                {
                    ddlPasajeros.Visible = true;
                    lblRespuesta.Visible = false;
                    ddlPasajeros.DataSource = agencia.DarClientesConMayorRanking();
                    ddlPasajeros.DataBind();
                }
            }
        }

        protected void btnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Inicio.aspx");
        }
    }
}