using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;

namespace Obligatorio
{
    public partial class Excursiones_por_fecha : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ddlExcursiones.Visible = false;
            }
        }

        protected void btnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Inicio.aspx");
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            Agencia agencia = Session["Agencia"] as Agencia;
            if (dte1.Text == "" || dte2.Text == "")
            {
                lblRespuesta.Text = "Error en los datos";
                ddlExcursiones.Visible = false;
                lblExcursiones.Visible = false;
            }
            else
            {
                lblRespuesta.Text = "";
                if (DateTime.Parse(dte1.Text) > DateTime.Parse(dte2.Text))
                {
                    if (agencia.DarExcursionesPorFechas(DateTime.Parse(dte1.Text), DateTime.Parse(dte2.Text)).Count == 0)
                    {
                        ddlExcursiones.Visible = false;
                        lblExcursiones.Visible = true;
                    }
                    else
                    {
                        ddlExcursiones.DataSource = agencia.DarExcursionesPorFechas(DateTime.Parse(dte1.Text), DateTime.Parse(dte2.Text));
                        ddlExcursiones.DataBind();
                        ddlExcursiones.Visible = true;
                        lblExcursiones.Visible = false;
                    }
                }
                else
                {
                    if (agencia.DarExcursionesPorFechas(DateTime.Parse(dte2.Text), DateTime.Parse(dte1.Text)).Count == 0)
                    {
                        ddlExcursiones.Visible = false;
                        lblExcursiones.Visible = true;
                    }
                    else
                    {
                        ddlExcursiones.DataSource = agencia.DarExcursionesPorFechas(DateTime.Parse(dte2.Text), DateTime.Parse(dte1.Text));
                        ddlExcursiones.DataBind();
                        ddlExcursiones.Visible = true;
                        lblExcursiones.Visible = false;
                    }
                }
            }
        }
    }
}