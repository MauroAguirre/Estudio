using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;

namespace Obligatorio
{
    public partial class Inicio : System.Web.UI.Page
    {
        Agencia agencia = Agencia.Instancia;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void AltaExcursion(object sender, EventArgs e)
        {
            Session["Agencia"] = agencia;
            Response.Redirect("Alta_de_excursion.aspx");
        }

        protected void AltaContrato(object sender, EventArgs e)
        {
            Session["Agencia"] = agencia;
            Response.Redirect("Alta_de_contrato.aspx");
        }

        protected void ExcursionesDeDestino(object sender, EventArgs e)
        {
            Session["Agencia"] = agencia;
            Response.Redirect("Excursiones_de_un_destino.aspx");
        }

        protected void ExcursionesPorFecha(object sender, EventArgs e)
        {
            Session["Agencia"] = agencia;
            Response.Redirect("Excursiones_por_fecha.aspx");
        }

        protected void Ranking(object sender, EventArgs e)
        {
            Session["Agencia"] = agencia;
            Response.Redirect("Ranking_pasajeros.aspx");
        }
    }
}