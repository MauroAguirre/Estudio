using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;

namespace Obligatorio
{
    public partial class Excursiones_de_un_destino : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) 
            {
                Agencia agencia = Session["Agencia"] as Agencia;
                ddlDestinos.DataSource = agencia.DarDestinos();
                ddlDestinos.DataBind();
                if (agencia.DarExcursionesDeUnDestino(agencia.DarDestinos()[0]).Count == 0)
                {
                    lblExcursiones.Visible = true;
                    ddlExcursiones.Visible = false;
                }
                else
                {
                    lblExcursiones.Visible = false;
                    ddlExcursiones.Visible = true;
                    ddlExcursiones.DataSource = agencia.DarExcursionesDeUnDestino(agencia.DarDestinos()[0]);
                    ddlExcursiones.DataBind();
                }
            }
        }

        protected void ddlDestinos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Agencia agencia = Session["Agencia"] as Agencia;
            if (agencia.DarExcursionesDeUnDestino(agencia.DarDestinos()[ddlDestinos.SelectedIndex]).Count == 0)
            {
                lblExcursiones.Visible = true;
                ddlExcursiones.Visible = false;
            }
            else
            {
                lblExcursiones.Visible = false;
                ddlExcursiones.Visible = true;
                ddlExcursiones.DataSource = agencia.DarExcursionesDeUnDestino(agencia.DarDestinos()[ddlDestinos.SelectedIndex]);
                ddlExcursiones.DataBind();
            }
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Inicio.aspx");
        }
    }
}