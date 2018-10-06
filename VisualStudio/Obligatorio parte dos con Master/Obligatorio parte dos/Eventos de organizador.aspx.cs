using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dominio;

namespace Obligatorio_parte_dos
{
    public partial class Eventos_de_organizador : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Organizador"] == null)
                Response.Redirect("Inicio.aspx");
            Organizador organizador = Session["Organizador"] as Organizador;
            List<Evento> eventos = organizador.DarEventos();
            List<Evento> eventosNormales = new List<Evento>();
            List<Evento> eventosPremium = new List<Evento>();
            foreach (Evento evento in eventos) 
            {
                if (evento.GetType() == typeof(Premium))
                    eventosPremium.Add(evento);
                else
                    eventosNormales.Add(evento);
            }
            if (eventosPremium.Count > 0)
            {
                tblPremium.Visible = true;
                hpremium.Visible = true;
                for (int i = 0; i < eventosPremium.Count; i++)
                {
                    TableRow row = new TableRow();
                    TableCell[] cell = new TableCell[10];
                    cell[0] = new TableCell();
                    cell[1] = new TableCell();
                    cell[2] = new TableCell();
                    cell[3] = new TableCell();
                    cell[4] = new TableCell();
                    cell[5] = new TableCell();
                    cell[6] = new TableCell();
                    cell[7] = new TableCell();
                    cell[8] = new TableCell();
                    cell[9] = new TableCell();
                    cell[0].Text = eventosPremium[i].Fecha.ToString();
                    cell[1].Text = eventosPremium[i].Descripcion;
                    cell[2].Text = eventosPremium[i].Cliente;
                    cell[3].Text = eventosPremium[i].Asistentes.ToString();
                    cell[4].Text = eventosPremium[i].Personas.ToString();
                    cell[5].Text = eventosPremium[i].Codigo.ToString();
                    cell[6].Text = eventosPremium[i].turno.ToString();
                    cell[7].Text = eventosPremium[i].Unico.ToString();
                    cell[8].Text = eventosPremium[i].Servicios.ToString();
                    cell[9].Text = eventosPremium[i].CostoTotalDelEvento.ToString();
                    row.Cells.Add(cell[0]);
                    row.Cells.Add(cell[1]);
                    row.Cells.Add(cell[2]);
                    row.Cells.Add(cell[3]);
                    row.Cells.Add(cell[4]);
                    row.Cells.Add(cell[5]);
                    row.Cells.Add(cell[6]);
                    row.Cells.Add(cell[7]);
                    row.Cells.Add(cell[8]);
                    row.Cells.Add(cell[9]);
                    tblPremium.Rows.Add(row);
                }
            }
            else 
            {
                tblPremium.Visible = false;
                hpremium.Visible = false;
            }
            if (eventosNormales.Count > 0)
            {
                tblNormal.Visible = true;
                hNormal.Visible = true;
                for (int i = 0; i < eventosNormales.Count; i++)
                {
                    TableRow row = new TableRow();
                    TableCell[] cell = new TableCell[10];
                    cell[0] = new TableCell();
                    cell[1] = new TableCell();
                    cell[2] = new TableCell();
                    cell[3] = new TableCell();
                    cell[4] = new TableCell();
                    cell[5] = new TableCell();
                    cell[6] = new TableCell();
                    cell[7] = new TableCell();
                    cell[8] = new TableCell();
                    cell[9] = new TableCell();
                    cell[0].Text = eventosNormales[i].Fecha.ToString();
                    cell[1].Text = eventosNormales[i].Descripcion;
                    cell[2].Text = eventosNormales[i].Cliente;
                    cell[3].Text = eventosNormales[i].Asistentes.ToString();
                    cell[4].Text = eventosNormales[i].Personas.ToString();
                    cell[5].Text = eventosNormales[i].Codigo.ToString();
                    cell[6].Text = eventosNormales[i].turno.ToString();
                    cell[7].Text = eventosNormales[i].Unico.ToString();
                    cell[8].Text = eventosNormales[i].Servicios.ToString();
                    cell[9].Text = eventosNormales[i].CostoTotalDelEvento.ToString();
                    row.Cells.Add(cell[0]);
                    row.Cells.Add(cell[1]);
                    row.Cells.Add(cell[2]);
                    row.Cells.Add(cell[3]);
                    row.Cells.Add(cell[4]);
                    row.Cells.Add(cell[5]);
                    row.Cells.Add(cell[6]);
                    row.Cells.Add(cell[7]);
                    row.Cells.Add(cell[8]);
                    row.Cells.Add(cell[9]);
                    tblNormal.Rows.Add(row);
                }
            }
            else
            {
                tblNormal.Visible = false;
                hNormal.Visible = false;
            }
        }

        protected void btnAtras_Click(object sender, EventArgs e)
        {
            Response.Redirect("Organizadores.aspx");
        }
    }
}