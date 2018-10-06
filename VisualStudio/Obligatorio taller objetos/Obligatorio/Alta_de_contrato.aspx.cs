using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;

namespace Obligatorio
{
    public partial class Alta_de_contrato : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) 
            {
                Agencia agencia = Session["Agencia"] as Agencia;
                ddlClientes.DataSource = agencia.DarClientes();
                ddlClientes.DataBind();
                List<Excursion> excursiones = new List<Excursion>();
                foreach (Excursion exc in agencia.DarExcursiones())
                {
                    if (exc.Disponible())
                        excursiones.Add(exc);
                }
                ddlExcursiones.DataSource = excursiones;
                ddlExcursiones.DataBind();
                if (excursiones.Count==0)
                {
                    ddlExcursiones.Visible = false;
                }
                else
                {
                    lblDisponible.Visible = false;
                    ddlExcursiones.DataSource = excursiones;
                    ddlExcursiones.DataBind();
                }
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            bool yaEsta = false;
            Agencia agencia = Session["Agencia"] as Agencia;
            List<Excursion> excursiones = new List<Excursion>();
            foreach (Excursion exc in agencia.DarExcursiones())
            {
                if (exc.Disponible())
                    excursiones.Add(exc);
            }
            if (!ddlExcursiones.Visible)
                lblRespuesta.Text = "Error";
            else 
            {
                foreach (Cliente c in excursiones[ddlExcursiones.SelectedIndex].DarClientes())
                {
                    if (c == agencia.DarClientes()[ddlClientes.SelectedIndex])
                        yaEsta = true;
                }
                if (yaEsta)
                    lblRespuesta.Text = "El cliente ya esta en la excursion";
                else 
                {
                    agencia.AgregarPuntosCliente(agencia.DarClientes()[ddlClientes.SelectedIndex]);
                    agencia.AgregarClienteExcursion(excursiones[ddlExcursiones.SelectedIndex], agencia.DarClientes()[ddlClientes.SelectedIndex]);
                    excursiones.Clear();
                    foreach (Excursion exc in agencia.DarExcursiones())
                    {
                        if (exc.Disponible())
                            excursiones.Add(exc);
                    }
                    ddlExcursiones.DataSource = excursiones;
                    ddlExcursiones.DataBind();
                    if (excursiones.Count == 0)
                    {
                        ddlExcursiones.Visible = false;
                        lblDisponible.Visible = true;
                    }
                        
                    else
                    {
                        ddlExcursiones.Visible = true;
                        lblDisponible.Visible = false;
                    } 
                    Session["Agencia"] = agencia;
                    lblRespuesta.Text = "Cliente agregado a la excursion";
                }
            }
        }

        protected void btnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Inicio.aspx");
        }
    }
}