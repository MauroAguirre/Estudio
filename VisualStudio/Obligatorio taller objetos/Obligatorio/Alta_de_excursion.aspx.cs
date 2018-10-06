using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;

namespace Obligatorio
{
    public partial class Alta_de_excursion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                List<DestinoEstadia> destinosElegidos = new List<DestinoEstadia>();
                Session["destinosElegidos"] = destinosElegidos;
            }
        }

        protected void btnAgregarExcursion_Click(object sender, EventArgs e)
        {
            bool datos = false;
            bool yaEsta = false;
            bool internacional = false;
            Agencia agencia = Session["Agencia"] as Agencia;
            List<DestinoEstadia> destinosElegidos = Session["destinosElegidos"] as List<DestinoEstadia>;
            foreach (DestinoEstadia des in destinosElegidos)
            {
                if (des.Destino == agencia.DarDestinos()[1] || des.Destino == agencia.DarDestinos()[2] || des.Destino == agencia.DarDestinos()[3]
                    || des.Destino == agencia.DarDestinos()[4])
                    internacional = true;
            }
            foreach (Excursion exc in agencia.DarExcursiones())
            {
                if (exc.Codigo == txtCodigo.Text)
                    yaEsta = true;
            }
            if (txtCodigo.Text != "" && txtDescripcion.Text != "" && numCostoDiasTraslado.Text != "" && numCostoDiasTraslado.Text != "0" &&
                numDiasTraslado.Text != "" && numDiasTraslado.Text != "0" && numMaximoPasajeros.Text != "" && numMaximoPasajeros.Text != "0" && dteFecha.Text != "" && DateTime.Parse(dteFecha.Text) > DateTime.Now )
                datos = true;
            //Introdujo los datos? la cantidad de destinos de la excursion es mayor a 0? la excursion no esta agregada ya? hay seleccionados destinos internacionales y eligio excursion nacional?
            if (!datos || destinosElegidos.Count == 0 || yaEsta || (ddlTipoExcursion.SelectedIndex.ToString() == "0" && internacional) || (ddlTipoExcursion.SelectedIndex.ToString() == "0" && (numDescuento.Text == "" || numDescuento.Text == "0" )))
                lblRespuesta.Text = "Error en los datos";
            else
            {
                if (ddlTipoExcursion.SelectedIndex == 0)
                {
                    Nacional na = new Nacional(txtCodigo.Text, txtDescripcion.Text, DateTime.Parse(dteFecha.Text), int.Parse(numDiasTraslado.Text), destinosElegidos, int.Parse(numMaximoPasajeros.Text), int.Parse(numCostoDiasTraslado.Text), 60);
                    agencia.AgregarExcursion(na);
                    Session["Agencia"] = agencia;
                }
                else
                {
                    Internacional inter = new Internacional(txtCodigo.Text, txtDescripcion.Text, DateTime.Parse(dteFecha.Text), int.Parse(numDiasTraslado.Text), destinosElegidos, int.Parse(numMaximoPasajeros.Text), int.Parse(numCostoDiasTraslado.Text));
                    agencia.AgregarExcursion(inter);
                    Session["Agencia"] = agencia;
                }
                lblRespuesta.Text = "Excursion agregada";
            }
        }

        protected void btnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Inicio.aspx");
        }

        protected void btnAgregarCanelones_Click(object sender, EventArgs e)
        {
            Agencia agencia = Session["Agencia"] as Agencia;
            List<DestinoEstadia> destinosElegidos = Session["destinosElegidos"] as List<DestinoEstadia>;
            bool esta = false;
            int contador = 0;
            int lugar = 0;
            foreach (DestinoEstadia d in destinosElegidos) 
            {
                if (d.Destino == agencia.DarDestinos()[0])
                {
                    esta = true;
                    lugar = contador;
                }
                contador++;
            }
            if (numCanelonesDias.Text == "" || numCanelonesDias.Text == "0")
                lblRespuesta.Text = "Falta expecificar cantidad de dias";
            else
            {
                if (esta)
                    destinosElegidos[lugar].DiasEstadia = int.Parse(numCanelonesDias.Text);
                else
                {
                    DestinoEstadia destinoElegido = new DestinoEstadia(agencia.DarDestinos()[0], int.Parse(numCanelonesDias.Text));
                    destinosElegidos.Add(destinoElegido);
                }
                lblRespuesta.Text = "Destino agregado a la excursion";
                gvwDestinosElegidos.DataSource = destinosElegidos;
                gvwDestinosElegidos.DataBind();
                Session["destinosElegidos"] = destinosElegidos;
            }
        }

        protected void btnAgregarCancun_Click(object sender, EventArgs e)
        {
            Agencia agencia = Session["Agencia"] as Agencia;
            List<DestinoEstadia> destinosElegidos = Session["destinosElegidos"] as List<DestinoEstadia>;
            bool esta = false;
            int contador = 0;
            int lugar = 0;
            foreach (DestinoEstadia d in destinosElegidos)
            {
                if (d.Destino == agencia.DarDestinos()[1])
                {
                    esta = true;
                    lugar = contador;
                }
                contador++;
            }
            if (numCancunDias.Text == "" || numCancunDias.Text == "0")
                lblRespuesta.Text = "Falta expecificar cantidad de dias";
            else
            {
                if (esta)
                    destinosElegidos[lugar].DiasEstadia = int.Parse(numCancunDias.Text);
                else
                {
                    DestinoEstadia destinoElegido = new DestinoEstadia(agencia.DarDestinos()[1], int.Parse(numCancunDias.Text));
                    destinosElegidos.Add(destinoElegido);
                }
                lblRespuesta.Text = "Destino agregado a la excursion";
                gvwDestinosElegidos.DataSource = destinosElegidos;
                gvwDestinosElegidos.DataBind();
                Session["destinosElegidos"] = destinosElegidos;
            }
        }

        protected void btnAgregarBaticano_Click(object sender, EventArgs e)
        {
            Agencia agencia = Session["Agencia"] as Agencia;
            List<DestinoEstadia> destinosElegidos = Session["destinosElegidos"] as List<DestinoEstadia>;
            bool esta = false;
            int contador = 0;
            int lugar = 0;
            foreach (DestinoEstadia d in destinosElegidos)
            {
                if (d.Destino == agencia.DarDestinos()[2])
                {
                    esta = true;
                    lugar = contador;
                }
                contador++;
            }
            if (numBaticanoDias.Text == "" || numBaticanoDias.Text == "0")
                lblRespuesta.Text = "Falta expecificar cantidad de dias";
            else
            {
                if (esta)
                    destinosElegidos[lugar].DiasEstadia = int.Parse(numBaticanoDias.Text);
                else
                {
                    DestinoEstadia destinoElegido = new DestinoEstadia(agencia.DarDestinos()[2], int.Parse(numBaticanoDias.Text));
                    destinosElegidos.Add(destinoElegido);
                }
                lblRespuesta.Text = "Destino agregado a la excursion";
                gvwDestinosElegidos.DataSource = destinosElegidos;
                gvwDestinosElegidos.DataBind();
                Session["destinosElegidos"] = destinosElegidos;
            }
        }

        protected void btnAgregarBsAs_Click(object sender, EventArgs e)
        {
            Agencia agencia = Session["Agencia"] as Agencia;
            List<DestinoEstadia> destinosElegidos = Session["destinosElegidos"] as List<DestinoEstadia>;
            bool esta = false;
            int contador = 0;
            int lugar = 0;
            foreach (DestinoEstadia d in destinosElegidos)
            {
                if (d.Destino == agencia.DarDestinos()[3])
                {
                    esta = true;
                    lugar = contador;
                }
                contador++;
            }
            if (numBsAsDias.Text == "" || numBsAsDias.Text == "0")
                lblRespuesta.Text = "Falta expecificar cantidad de dias";
            else
            {
                if (esta)
                    destinosElegidos[lugar].DiasEstadia = int.Parse(numBsAsDias.Text);
                else
                {
                    DestinoEstadia destinoElegido = new DestinoEstadia(agencia.DarDestinos()[3], int.Parse(numBsAsDias.Text));
                    destinosElegidos.Add(destinoElegido);
                }
                lblRespuesta.Text = "Destino agregado a la excursion";
                gvwDestinosElegidos.DataSource = destinosElegidos;
                gvwDestinosElegidos.DataBind();
                Session["destinosElegidos"] = destinosElegidos;
            }
        }

        protected void btnAgregarBahia_Click(object sender, EventArgs e)
        {
            Agencia agencia = Session["Agencia"] as Agencia;
            List<DestinoEstadia> destinosElegidos = Session["destinosElegidos"] as List<DestinoEstadia>;
            bool esta = false;
            int contador = 0;
            int lugar = 0;
            foreach (DestinoEstadia d in destinosElegidos)
            {
                if (d.Destino == agencia.DarDestinos()[4])
                {
                    esta = true;
                    lugar = contador;
                }
                contador++;
            }
            if (numBahiaDias.Text == "" || numBahiaDias.Text == "0")
                lblRespuesta.Text = "Falta expecificar cantidad de dias";
            else
            {
                if (esta)
                    destinosElegidos[lugar].DiasEstadia = int.Parse(numBahiaDias.Text);
                else
                {
                    DestinoEstadia destinoElegido = new DestinoEstadia(agencia.DarDestinos()[4], int.Parse(numBahiaDias.Text));
                    destinosElegidos.Add(destinoElegido);
                }
                lblRespuesta.Text = "Destino agregado a la excursion";
                gvwDestinosElegidos.DataSource = destinosElegidos;
                gvwDestinosElegidos.DataBind();
                Session["destinosElegidos"] = destinosElegidos;
            }
        }

        protected void btnAgregarSanCarlos_Click(object sender, EventArgs e)
        {
            Agencia agencia = Session["Agencia"] as Agencia;
            List<DestinoEstadia> destinosElegidos = Session["destinosElegidos"] as List<DestinoEstadia>;
            bool esta = false;
            int contador = 0;
            int lugar = 0;
            foreach (DestinoEstadia d in destinosElegidos)
            {
                if (d.Destino == agencia.DarDestinos()[5])
                {
                    esta = true;
                    lugar = contador;
                }
                contador++;
            }
            if (numSanCarlosDias.Text == "" || numSanCarlosDias.Text == "0")
                lblRespuesta.Text = "Falta expecificar cantidad de dias";
            else
            {
                if (esta)
                    destinosElegidos[lugar].DiasEstadia = int.Parse(numSanCarlosDias.Text);
                else
                {
                    DestinoEstadia destinoElegido = new DestinoEstadia(agencia.DarDestinos()[5], int.Parse(numSanCarlosDias.Text));
                    destinosElegidos.Add(destinoElegido);
                }
                lblRespuesta.Text = "Destino agregado a la excursion";
                gvwDestinosElegidos.DataSource = destinosElegidos;
                gvwDestinosElegidos.DataBind();
                Session["destinosElegidos"] = destinosElegidos;
            }
        }

        protected void btnEliminarCanelones_Click(object sender, EventArgs e)
        {
            Agencia agencia = Session["Agencia"] as Agencia;
            List<DestinoEstadia> destinosElegidos = Session["destinosElegidos"] as List<DestinoEstadia>;
            bool esta = false;
            int conteo = 0;
            int lugar = 0;
            foreach (DestinoEstadia d in destinosElegidos)
            {
                if (d.Destino == agencia.DarDestinos()[0])
                {
                    esta = true;
                    lugar = conteo;
                }
                conteo++;
            }
            if (esta)
            {
                destinosElegidos.RemoveAt(lugar);
                lblRespuesta.Text = "Destino borrado de la excursion";
                gvwDestinosElegidos.DataSource = destinosElegidos;
                gvwDestinosElegidos.DataBind();
                Session["destinosElegidos"] = destinosElegidos;
            }
            else
                lblRespuesta.Text = "El destino no esta agregado a la excursion";
        }

        protected void btnEliminarCancun_Click(object sender, EventArgs e)
        {
            Agencia agencia = Session["Agencia"] as Agencia;
            List<DestinoEstadia> destinosElegidos = Session["destinosElegidos"] as List<DestinoEstadia>;
            bool esta = false;
            int conteo = 0;
            int lugar = 0;
            foreach (DestinoEstadia d in destinosElegidos)
            {
                if (d.Destino == agencia.DarDestinos()[1])
                {
                    esta = true;
                    lugar = conteo;
                }
                conteo++;
            }
            if (esta)
            {
                destinosElegidos.RemoveAt(lugar);
                lblRespuesta.Text = "Destino borrado de la excursion";
                gvwDestinosElegidos.DataSource = destinosElegidos;
                gvwDestinosElegidos.DataBind();
                Session["destinosElegidos"] = destinosElegidos;
            }
            else
                lblRespuesta.Text = "El destino no esta agregado a la excursion";
        }

        protected void btnEliminarBaticano_Click(object sender, EventArgs e)
        {
            Agencia agencia = Session["Agencia"] as Agencia;
            List<DestinoEstadia> destinosElegidos = Session["destinosElegidos"] as List<DestinoEstadia>;
            bool esta = false;
            int conteo = 0;
            int lugar = 0;
            foreach (DestinoEstadia d in destinosElegidos)
            {
                if (d.Destino == agencia.DarDestinos()[2])
                {
                    esta = true;
                    lugar = conteo;
                }
                conteo++;
            }
            if (esta)
            {
                destinosElegidos.RemoveAt(lugar);
                lblRespuesta.Text = "Destino borrado de la excursion";
                gvwDestinosElegidos.DataSource = destinosElegidos;
                gvwDestinosElegidos.DataBind();
                Session["destinosElegidos"] = destinosElegidos;
            }
            else
                lblRespuesta.Text = "El destino no esta agregado a la excursion";
        }

        protected void btnEliminarBsAs_Click(object sender, EventArgs e)
        {
            Agencia agencia = Session["Agencia"] as Agencia;
            List<DestinoEstadia> destinosElegidos = Session["destinosElegidos"] as List<DestinoEstadia>;
            bool esta = false;
            int conteo = 0;
            int lugar = 0;
            foreach (DestinoEstadia d in destinosElegidos)
            {
                if (d.Destino == agencia.DarDestinos()[3])
                {
                    esta = true;
                    lugar = conteo;
                }
                conteo++;
            }
            if (esta)
            {
                destinosElegidos.RemoveAt(lugar);
                lblRespuesta.Text = "Destino borrado de la excursion";
                gvwDestinosElegidos.DataSource = destinosElegidos;
                gvwDestinosElegidos.DataBind();
                Session["destinosElegidos"] = destinosElegidos;
            }
            else
                lblRespuesta.Text = "El destino no esta agregado a la excursion";
        }

        protected void btnEliminarBahia_Click(object sender, EventArgs e)
        {
            Agencia agencia = Session["Agencia"] as Agencia;
            List<DestinoEstadia> destinosElegidos = Session["destinosElegidos"] as List<DestinoEstadia>;
            bool esta = false;
            int conteo = 0;
            int lugar = 0;
            foreach (DestinoEstadia d in destinosElegidos)
            {
                if (d.Destino == agencia.DarDestinos()[4])
                {
                    esta = true;
                    lugar = conteo;
                }
                conteo++;
            }
            if (esta)
            {
                destinosElegidos.RemoveAt(lugar);
                lblRespuesta.Text = "Destino borrado de la excursion";
                gvwDestinosElegidos.DataSource = destinosElegidos;
                gvwDestinosElegidos.DataBind();
                Session["destinosElegidos"] = destinosElegidos;
            }
            else
                lblRespuesta.Text = "El destino no esta agregado a la excursion";
        }

        protected void btnEliminarSanCarlos_Click(object sender, EventArgs e)
        {
            Agencia agencia = Session["Agencia"] as Agencia;
            List<DestinoEstadia> destinosElegidos = Session["destinosElegidos"] as List<DestinoEstadia>;
            bool esta = false;
            int conteo = 0;
            int lugar = 0;
            foreach (DestinoEstadia d in destinosElegidos)
            {
                if (d.Destino == agencia.DarDestinos()[5])
                {
                    esta = true;
                    lugar = conteo;
                }
                conteo++;
            }
            if (esta)
            {
                destinosElegidos.RemoveAt(lugar);
                lblRespuesta.Text = "Destino borrado de la excursion";
                gvwDestinosElegidos.DataSource = destinosElegidos;
                gvwDestinosElegidos.DataBind();
                Session["destinosElegidos"] = destinosElegidos;
            }
            else
                lblRespuesta.Text = "El destino no esta agregado a la excursion";
        }

        protected void ddlTipoExcursion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlTipoExcursion.SelectedIndex == 0)
                trwDescuento.Visible = true;
            else
                trwDescuento.Visible = false;
        }
    }
}