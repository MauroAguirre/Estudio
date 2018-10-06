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
            if (!IsPostBack) 
            {
                MenuRegistrar.Visible = false;
            }
        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            Administrador admin = new Administrador(Mail.Text, Contraseña.Text);
            eventos2017.AgregarAdministrador(admin);
            gvw1.DataSource = eventos2017.DarAdministradores();
            gvw1.DataBind();
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            MenuRegistrar.Visible = true;
            MenuPrincipal.Visible = false;
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            MenuRegistrar.Visible = false;
            MenuPrincipal.Visible = true;
        }
    }
}