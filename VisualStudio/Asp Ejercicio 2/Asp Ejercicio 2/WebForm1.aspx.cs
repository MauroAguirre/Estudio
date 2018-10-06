using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;

namespace Asp_Ejercicio_2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        Sistema sistema = Sistema.Instancia;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona(int.Parse(txtCedula.Text),txtNombre.Text,txtMail.Text);
            sistema.AgregarPersona(persona);
            List<Persona> per = sistema.DarLista();
            ddl1.DataSource = per;
            ddl1.DataBind();
        }
    }
}