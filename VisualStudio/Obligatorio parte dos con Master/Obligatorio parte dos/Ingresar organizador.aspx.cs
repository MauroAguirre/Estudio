using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dominio;

namespace Obligatorio_parte_dos
{
    public partial class Ingresar_organizador : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Administrador"] == null)
                Response.Redirect("Inicio.aspx");
        }

        protected void btnRegresar_Click(object sender, EventArgs e)
        {
            Server.Transfer("Administradores.aspx", true);
        }

        protected void btnReg_Click(object sender, EventArgs e)
        {
            Eventos2017 eventos2017 = Session["Sistema"] as Eventos2017;
            lblRespuesta.Text = "";
            bool correcto = false;
            bool correcto2 = true;
            if (Ingresar_administrador.VerificarMail(txtMail.Text, eventos2017.DarAdministradores(), eventos2017.DarOrganizadores()))
            {
                lbl1.Text = "";
            }
            else
            {
                lbl1.Text = "Error";
            }
            if (Ingresar_administrador.VerificarContraseña(txtContraseña.Text))
            {
                lbl2.Text = "";
            }
            else
            {
                lbl2.Text = "Errorx2";
            }
            if (dteFecha.Text != "")
            {
                if (dteFecha.Text.Length < 11)
                {
                    correcto = true;
                    lblFecha.Text = "";
                }
                else
                    lblFecha.Text = "Errorx3";
            }
            else
                lblFecha.Text = "Errorx3";
            if (txtDireccion.Text == "" || txtNombre.Text == "" || txtTelefono.Text == "")
            {
                correcto2 = false;
                lblRespuesta.Text = "Faltan datos";
            }
            if (correcto && correcto2 && Ingresar_administrador.VerificarMail(txtMail.Text, eventos2017.DarAdministradores(), eventos2017.DarOrganizadores()) && Ingresar_administrador.VerificarContraseña(txtContraseña.Text))
            {
                lbl1.Text = "";
                Organizador organizador = new Organizador(txtNombre.Text, int.Parse(txtTelefono.Text), txtDireccion.Text, DateTime.Parse(dteFecha.Text), txtMail.Text, txtContraseña.Text);
                eventos2017.AgregarOrganizador(organizador);
                txtContraseña.Text = "";
                txtDireccion.Text = "";
                txtMail.Text = "";
                txtNombre.Text = "";
                txtTelefono.Text = "";
                lblFecha.Text = "";
                lblRespuesta.Text = "Organizador ingresado";
            }
        }
    }
}