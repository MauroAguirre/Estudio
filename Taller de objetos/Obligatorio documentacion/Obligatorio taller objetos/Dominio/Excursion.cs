using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Excursion
    {
        #region atributos
        private string codigo;
        private string descripcion;
        private DateTime fechaComienzo;
        private int diaTraslado;
        private int stock;
        private List<DestinoEstadia> destinoEstadias;
        private List<Cliente> clientes;
        private int costoTraslado;
        #endregion

        #region propiedades
        public DateTime FechaComienzo
        {
            get { return fechaComienzo; }
            set { fechaComienzo = value; }
        }
        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        public int DiaTraslado
        {
            get { return diaTraslado; }
            set { diaTraslado = value; }
        }
        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }
        public int CostoTraslado
        {
            get { return costoTraslado; }
            set { costoTraslado = value; }
        }
        public List<DestinoEstadia> DestinoEstadia
        {
            get { return destinoEstadias; }
            set { destinoEstadias = value; }
        }
        #endregion

        #region metodos
        public Excursion(string codigo, string descripcion, DateTime fechaComienzo, int diaTraslado, List<DestinoEstadia> destinoEstadias, int stock, int costoTraslado)
        {
            this.codigo = codigo;
            this.descripcion = descripcion;
            this.fechaComienzo = fechaComienzo;
            this.diaTraslado = diaTraslado;
            this.destinoEstadias = destinoEstadias;
            this.stock = stock;
            this.costoTraslado = costoTraslado;
            destinoEstadias = new List<DestinoEstadia>();
            clientes = new List<Cliente>();

        }
        public virtual int Costo()
        {
            return 0;
        }
        public bool Disponible() 
        {
            if (stock == clientes.Count)
                return false;
            return true;
        }
        public override string ToString()
        {
            return codigo + " - " + descripcion + " - " + Costo();
        }
        public List<Cliente> DarClientes()
        {
            List<Cliente> auxCliente = new List<Cliente>();
            foreach (Cliente c in clientes)
            {
                auxCliente.Add(c);
            }
            return auxCliente;
        }
        public void AgregarCliente(Cliente c)
        {
            clientes.Add(c);
        }
        #endregion

    }
}
