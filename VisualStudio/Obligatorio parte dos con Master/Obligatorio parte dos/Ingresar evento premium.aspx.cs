using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dominio;

namespace Obligatorio_parte_dos
{
    public partial class Ingresar_evento_premium : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) 
            {
                if (Session["Organizador"] == null)
                    Response.Redirect("Inicio.aspx");
                List<ServiciosComprados> serviciosElegidos = new List<ServiciosComprados>();
                Session["serviciosElegidos"] = serviciosElegidos;
                gvwServiciosElegidos.DataSource = serviciosElegidos;
                gvwServiciosElegidos.DataBind();
                Eventos2017 eventos2017 = Session["Sistema"] as Eventos2017;
                //gvwServiciosDisponibles.DataSource = eventos2017.DarServicios();
                //gvwServiciosDisponibles.DataBind();
                //List<Servicio> serviciosElegidos = new List<Servicio>();
                //Session["serviciosElegidos"] = serviciosElegidos;
                string[] turno = {"mañana","tarde","noche"};
                ddlTurno.DataSource = turno;
                ddlTurno.DataBind();
            }   
        }

        protected void Regresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Organizadores.aspx");
        }

        protected void Agregar_Click(object sender, EventArgs e)
        {
            List<ServiciosComprados> serviciosComprados = Session["serviciosElegidos"] as List<ServiciosComprados>;
            List<ServiciosComprados> newServiciosComprados = new List<ServiciosComprados>();
            foreach (ServiciosComprados servi in serviciosComprados)
            {
                newServiciosComprados.Add(servi);
            }
            bool[] check = new bool[3];
            check[0] = true;
            check[1] = false;
            check[2] = false;
            if (txtCliente.Text == "" || txtDescripcion.Text == "" || (int.Parse(numAsistentes.Text)) < 1 || (int.Parse(numAsistentes.Text)) > 100 || (int.Parse(numAumento.Text)) < 1 || (int.Parse(numAumento.Text)) >100 || dteFecha.Text == "")
                check[0] = false;
            if (check[0] == true)
            {
                if ((int.Parse(numPersonas.Text)) <= (int.Parse(numAsistentes.Text)) && (int.Parse(numPersonas.Text)) > 0)
                    check[1] = true;
            }
            if (check[0]) 
            {
                if (dteFecha.Text.Length < 11)
                    check[2] = true;
            }
            if (check[1] && check[2])
            {
                string turno = "Pepito";
                switch (ddlTurno.SelectedIndex)
                {
                    case 1:
                        turno = "mañana";
                        break;
                    case 2:
                        turno = "tarde";
                        break;
                    case 3:
                        turno = "noche";
                        break;
                }
                Organizador organizador = Session["Organizador"] as Organizador;
                Premium nuevoEvento = new Premium(turno, int.Parse(numAumento.Text), DateTime.Parse(dteFecha.Text), txtDescripcion.Text, txtCliente.Text, int.Parse(numAsistentes.Text), int.Parse(numPersonas.Text), organizador, newServiciosComprados);
                Eventos2017 eventos2017 = Session["Sistema"] as Eventos2017;
                eventos2017.AgregarEvento(nuevoEvento);
                Session["Sistema"] = eventos2017;
                lblRespuesta.Text = "Eventos ingresado correctamente";
            }
            else
                lblRespuesta.Text = "Error";
        }

     /*   protected void gvwServiciosDisponibles_RowCommand(object sender, GridViewCommandEventArgs e)
        {


            
            Eventos2017 eventos2017 = Session["Sistema"] as Eventos2017;
            int pos = int.Parse(e.CommandArgument as string);
            List<Servicio> servicios = eventos2017.DarServicios();
            if (gvwServiciosElegidos.Rows.Count == 0)
            {
                List<Servicio> serviciosAux = new List<Servicio>();
                serviciosAux.Add(servicios[pos]);
                gvwServiciosElegidos.DataSource = serviciosAux; ;
                gvwServiciosElegidos.DataBind();
            }
            else
            {
                
                List<Servicio> serviciosAnteriores = (List<Servicio>)gvwServiciosElegidos.DataSource;
                //erviciosAnteriores.Add(servicios[pos]);
                gvwServiciosElegidos.DataSource = serviciosAnteriores; 
                gvwServiciosElegidos.DataBind();   
            }
            
            //No pude sacar la lista del dropdownlist asi que guarde la lista en
            //una variable de session y de ahi la saco
            bool yaTa = false;
            Eventos2017 eventos2017 = Session["Sistema"] as Eventos2017;
            int pos = int.Parse(e.CommandArgument as string);
            List<Servicio> servicios = eventos2017.DarServicios();
            List<Servicio> serviciosElegidos = Session["serviciosElegidos"] as List<Servicio>;
            foreach (Servicio servicito in serviciosElegidos)
            {
                if (servicito.Nombre == servicios[pos].Nombre)
                {
                    yaTa = true;
                    break;
                }
            }
            if (!yaTa)
            {
                serviciosElegidos.Add(servicios[pos]);
                gvwServiciosElegidos.DataSource = serviciosElegidos;
                gvwServiciosElegidos.DataBind();
                Session["serviciosElegidos"] = serviciosElegidos;
            }
        }*/

        protected void gvwServiciosElegidos_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //ScriptManager.RegisterStartupScript(this, this.GetType(), "alertIns", "alert("+e.RowIndex+");", true);
            //Lo que hace la linea anterior es hacer un alert()
            /*List<Servicio> serviciosElegidos = Session["serviciosElegidos"] as List<Servicio>;
            serviciosElegidos.RemoveAt(e.RowIndex);
            gvwServiciosElegidos.DataSource = serviciosElegidos;
            gvwServiciosElegidos.DataBind();*/
            List<ServiciosComprados> serviciosElegidos = Session["serviciosElegidos"] as List<ServiciosComprados>;
            serviciosElegidos.RemoveAt(e.RowIndex);
            gvwServiciosElegidos.DataSource = serviciosElegidos;
            gvwServiciosElegidos.DataBind();
        }

        protected void btnAgregarBebidas_Click(object sender, EventArgs e)
        {
            bool esNumero = true;
            bool correcto = false;
            if (numBebidas.Text == "")
                esNumero = false;
            if (esNumero && numPersonas.Text != "")
            {
                if (int.Parse(numBebidas.Text) > 0 && int.Parse(numBebidas.Text) <= int.Parse(numPersonas.Text) && int.Parse(numBebidas.Text) < 101)
                    correcto = true;
            }
            if (correcto)
            {
                bool yaTa = false;
                Eventos2017 eventos2017 = Session["Sistema"] as Eventos2017;
                List<Servicio> servicios = eventos2017.DarServicios();
                List<ServiciosComprados> serviciosElegidos = Session["serviciosElegidos"] as List<ServiciosComprados>;
                foreach (ServiciosComprados servicito in serviciosElegidos)
                {
                    if (servicito.darNombreServicio() == servicios[0].Nombre)
                    {
                        yaTa = true;
                        break;
                    }
                }
                if (!yaTa)
                {
                    ServiciosComprados nuevo = new ServiciosComprados(int.Parse(numBebidas.Text), servicios[0]);
                    serviciosElegidos.Add(nuevo);
                    gvwServiciosElegidos.DataSource = serviciosElegidos;
                    gvwServiciosElegidos.DataBind();
                    Session["serviciosElegidos"] = serviciosElegidos;
                }
                lblRespuesta.Text = "";
            }
            else
                lblRespuesta.Text = "Error";
            
        }

        protected void btnAgregarComidas_Click(object sender, EventArgs e)
        {
            bool esNumero = true;
            bool correcto = false;
            if (numComidas.Text == "")
                esNumero = false;
            if (esNumero && numPersonas.Text != "")
            {
                if (int.Parse(numComidas.Text) > 0 && int.Parse(numComidas.Text) <= int.Parse(numPersonas.Text) && int.Parse(numComidas.Text) < 101)
                    correcto = true;
            }
            if (correcto)
            {
                bool yaTa = false;
                Eventos2017 eventos2017 = Session["Sistema"] as Eventos2017;
                List<Servicio> servicios = eventos2017.DarServicios();
                List<ServiciosComprados> serviciosElegidos = Session["serviciosElegidos"] as List<ServiciosComprados>;
                foreach (ServiciosComprados servicito in serviciosElegidos)
                {
                    if (servicito.darNombreServicio() == servicios[1].Nombre)
                    {
                        yaTa = true;
                        break;
                    }
                }
                if (!yaTa)
                {
                    ServiciosComprados nuevo = new ServiciosComprados(int.Parse(numComidas.Text), servicios[1]);
                    serviciosElegidos.Add(nuevo);
                    gvwServiciosElegidos.DataSource = serviciosElegidos;
                    gvwServiciosElegidos.DataBind();
                    Session["serviciosElegidos"] = serviciosElegidos;
                }
                lblRespuesta.Text = "";
            }
            else
                lblRespuesta.Text = "Error";
        }

        protected void btnAgregarSonido_Click(object sender, EventArgs e)
        {
            bool esNumero = true;
            bool correcto = false;
            if (numSonido.Text == "")
                esNumero = false;
            if (esNumero && numPersonas.Text != "")
            {
                if (int.Parse(numSonido.Text) > 0 && int.Parse(numSonido.Text) <= int.Parse(numPersonas.Text) && int.Parse(numSonido.Text) < 101 )
                    correcto = true;
            }
            if (correcto)
            {
                bool yaTa = false;
                Eventos2017 eventos2017 = Session["Sistema"] as Eventos2017;
                List<Servicio> servicios = eventos2017.DarServicios();
                List<ServiciosComprados> serviciosElegidos = Session["serviciosElegidos"] as List<ServiciosComprados>;
                foreach (ServiciosComprados servicito in serviciosElegidos)
                {
                    if (servicito.darNombreServicio() == servicios[2].Nombre)
                    {
                        yaTa = true;
                        break;
                    }
                }
                if (!yaTa)
                {
                    ServiciosComprados nuevo = new ServiciosComprados(int.Parse(numSonido.Text), servicios[2]);
                    serviciosElegidos.Add(nuevo);
                    gvwServiciosElegidos.DataSource = serviciosElegidos;
                    gvwServiciosElegidos.DataBind();
                    Session["serviciosElegidos"] = serviciosElegidos;
                }
                lblRespuesta.Text = "";
            }
            else
                lblRespuesta.Text = "Error";
        }

    }
}