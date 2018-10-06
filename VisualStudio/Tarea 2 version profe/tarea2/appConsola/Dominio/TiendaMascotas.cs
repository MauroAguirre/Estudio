using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class TiendaMascotas
    {
        #region Atributos privados
        private static TiendaMascotas instancia;
        private string nombre;
        private List<Cliente> clientes;
        private List<Corte> cortes;
        #endregion

        #region Properties        
        public static TiendaMascotas Instancia
        {
            get
            {
                if (instancia == null) instancia = new TiendaMascotas();
                return instancia;
            }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        #endregion

        #region Metodos
        private TiendaMascotas()
        {
            Corte unC1 = new Corte();
            unC1.CorteUñas = true;
            unC1.Descripcion = "rapado";
            unC1.Precio = 30;

            Corte unC2 = new Corte();
            unC2.CorteUñas = false;
            unC2.Descripcion = "pompom";
            unC2.Precio = 60;

            cortes = new List<Corte>();
            cortes.Add(unC1);
            cortes.Add(unC2);

            clientes = new List<Cliente>();
            Cliente unCL1 = new Cliente("juan","av españa",123123);
            Cliente unCL2 = new Cliente("ana","18 de julio",333333);
            clientes.Add(unCL1);
            clientes.Add(unCL2);



        }

        public void ComprarServicio(ServicioComprado unSC)
        {
            Mascota unM;
            unM = unSC.Mascota;
            unM.AgregarServicio(unSC);

           
        }

        public void AltaCliente(Cliente unCliente)
        {
            if (BuscarCliente(unCliente.Cedula) == null)
            {
                clientes.Add(unCliente);
            }
        }

        public List<Cliente> Clientes()
        {
            return clientes;
        }
        public List<Cliente> ClientesCon2Mascotas()
        {
            List<Cliente> clientesCon2Mascotas = new List<Cliente>();
            foreach (Cliente cliente in clientes)
            {
                if (cliente.CantidadMascotas() >= 2)
                    clientesCon2Mascotas.Add(cliente);
            }
            return clientesCon2Mascotas;
        }
        public Cliente BuscarCliente(int cedula)
        {
            Cliente unCliente = null;
            bool esta = false;
            int posicion = 0;

            while (!esta && posicion < clientes.Count())
            {
                if (clientes[posicion].Cedula == cedula)
                {
                    esta = true;
                    unCliente = clientes[posicion];
                }
                else
                {
                    posicion++;
                }
            }
            return unCliente;
        }
        public int ValorRecaudadoEntreFechas(DateTime fecha1, DateTime fecha2)
        {
            int recaudado = 0;
            DateTime max;
            DateTime min;
            if (fecha2 > fecha1)
            {
                max = fecha2;
                min = fecha1;
            }
            else
            {
                max = fecha1;
                min = fecha2;
            }
            foreach (Cliente cliente in clientes)
            {
                foreach (Mascota mascota in cliente.Mascotas())
                {
                    foreach (ServicioComprado servicioComprado in mascota.DarServicios())
                    {
                        if (servicioComprado.Fecha < max && servicioComprado.Fecha > min)
                            recaudado += servicioComprado.Servicio.Precio;
                    } 
                }
            }
            return recaudado;
        }

        public void AgregarMascota(Mascota unaMascota)
        {
            int cedula = unaMascota.Dueño.Cedula;
            Cliente unCliente;
            unCliente = BuscarCliente(cedula);
            if (unCliente != null)
            {
                unCliente.AgregarMascota(unaMascota);
            }
        }

        public List<Corte> Cortes()
        {
            return cortes;
        }

        public List<Mascota> DarMascotasConServicios() 
        {
            List<Mascota> mascotasConServicios = new List<Mascota>();
            foreach (Cliente cliente in clientes) 
            {
                foreach (Mascota mascota in cliente.DarMascotasConServicios()) 
                {
                    mascotasConServicios.Add(mascota);
                }
            }
            return mascotasConServicios;
        }
        public Cliente ClienteConMasMascotas()
        {
            int posicion =-1;
            int contador = 0;
            bool primera = true;
            foreach (Cliente cliente in clientes)
            {
                if (primera)
                {
                    posicion = contador;
                    primera = false;
                }
                else
                {
                    if (clientes[posicion].CantidadMascotas() < cliente.CantidadMascotas())
                    {
                        posicion = contador;
                    }
                        
                }
                contador++;
            }
            return clientes[posicion];
        }
    }


    #endregion
}

