using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Tienda
    {
        #region Atributos
        private static Tienda instancia;
        private List<Cliente> clientes;
        private List<Lavado> lavados;
        private List<Corte> cortes;
        private List<ServicioComprado> serviciosComprados;
        #endregion
        #region Constructor
        private Tienda()
        {
            serviciosComprados = new List<ServicioComprado>();
            clientes = new List<Cliente>();
            lavados = new List<Lavado>();
            cortes = new List<Corte>();
        }
        #endregion
        #region Propiedades
        public static Tienda Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new Tienda();
                }
                return instancia;
            }
        }
        #endregion
        #region Metodos
        public List<Cliente> DarClientes()
        {
            List<Cliente> auxClientes = new List<Cliente>();
            foreach (Cliente elCliente in clientes)
            {
                auxClientes.Add(elCliente);
            }
            return auxClientes;
        }
        public List<Lavado> DarLavados()
        {
            List<Lavado> auxLavados = new List<Lavado>();
            foreach (Lavado elLavado in lavados)
            {
                auxLavados.Add(elLavado);
            }
            return auxLavados;
        }
        public List<Corte> DarCortes()
        {
            List<Corte> auxCortes = new List<Corte>();
            foreach (Corte elCorte in cortes)
            {
                auxCortes.Add(elCorte);
            }
            return auxCortes;
        }
        public List<ServicioComprado> DarServiciosComprados()
        {
            List<ServicioComprado> auxServiciosComprados = new List<ServicioComprado>();
            foreach (ServicioComprado elServiciosComprados in serviciosComprados)
            {
                auxServiciosComprados.Add(elServiciosComprados);
            }
            return auxServiciosComprados;
        }
        public Cliente DarCliente(int cual) 
        {
            return clientes[cual-1];
        }
        public void AgregarCliente(Cliente nuevoCliente)
        {
            clientes.Add(nuevoCliente);
        }
        public void AgregarLavado(Lavado nuevoLavado)
        {
            lavados.Add(nuevoLavado);
        }
        public void AgregarCorte(Corte nuevoCorte)
        {
            cortes.Add(nuevoCorte);
        }
        public void AgregarMascotaAUnCliente(int cual, Mascota mascota)
        {
            clientes[cual-1].AgregarMascota(mascota);
        }
        public void AgregarServicioComprado(ServicioComprado nuevoServicioComprado) 
        {
            serviciosComprados.Add(nuevoServicioComprado);
        }
        public int CantidadClientes() 
        {
            return clientes.Count;
        }
        public int CantidadServicios()
        {
            return cortes.Count + lavados.Count;
        }
        #endregion
    }
}
