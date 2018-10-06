using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dominio;

namespace Obligatorio_parte_dos
{
    public partial class Ingresar_administrador : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Administrador"] == null)
                Response.Redirect("Inicio.aspx");
        }

        protected void btnReg_Click(object sender, EventArgs e)
        {
            Eventos2017 eventos2017 = Session["Sistema"] as Eventos2017;
            if (VerificarMail(txtMailReg.Text, eventos2017.DarAdministradores(), eventos2017.DarOrganizadores()))
            {
                lbl1.Text = "";
            }
            else
            {
                lbl1.Text = "Error";
            }
            if (VerificarContraseña(txtContraseñaReg.Text))
            {
                lbl2.Text = "";
            }
            else
            {
                lbl2.Text = "ErrorX2";
            }
            if (VerificarMail(txtMailReg.Text, eventos2017.DarAdministradores(), eventos2017.DarOrganizadores()) && VerificarContraseña(txtContraseñaReg.Text))
            {
                lbl1.Text = "Administrador ingresado";
                Administrador administrador = new Administrador(txtMailReg.Text, txtContraseñaReg.Text);
                eventos2017.AgregarAdministrador(administrador);
                txtContraseñaReg.Text = "";
                txtMailReg.Text = "";
                Session["Sistema"] = eventos2017;
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Server.Transfer("Administradores.aspx", true);
        }
        public static bool VerificarMail(string mail, List<Administrador> administradoresAnteriores, List<Organizador> organizadoresAnteriores)
        {
            bool iguales = false;
            bool primera = false;
            int ubicacionArroba;
            int arrobas = 0;
            string final = ".com";
            foreach (Administrador administrador in administradoresAnteriores)
            {
                if (mail == administrador.Mail)
                    iguales = true;
            }
            foreach (Organizador organizador in organizadoresAnteriores)
            {
                if (mail == organizador.Mail)
                    iguales = true;
            }
            for (int i = 0; i < mail.Length; i++)
            {
                if (mail.Substring(i, 1) == "@")
                    arrobas++;
                if (!primera && mail.Substring(i, 1) == "@")
                {
                    primera = true;
                    ubicacionArroba = i;
                }
            }
            if (arrobas != 1 || final != mail.Substring(mail.Length - 4) || iguales)
            {
                return false;
            }
            return true;
        }
        public static bool VerificarContraseña(string contraseña)
        {
            bool tiene = false; ;
            for (int i = 0; i < contraseña.Length; i++)
            {
                if (contraseña.Substring(i, 1) == "!" || contraseña.Substring(i, 1) == "," || contraseña.Substring(i, 1) == "." || contraseña.Substring(i, 1) == ";")
                    tiene = true;
            }
            if (contraseña.Length > 8 || contraseña == contraseña.ToLower() || !tiene)
                return false;
            return true;
        }
    }
}