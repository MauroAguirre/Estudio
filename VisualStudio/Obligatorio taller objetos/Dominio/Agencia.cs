using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Agencia
    {
        private static Agencia instancia;
        private List<Cliente> clientes;
        private List<Excursion> excursiones;
        private List<Destino> destinos;
        public static Agencia Instancia 
        {
            get 
            {
                if (instancia == null)
                    instancia = new Agencia();
                return instancia;
            }
        }

        public Agencia() 
        {
            clientes = new List<Cliente>();
            excursiones = new List<Excursion>();
            destinos = new List<Destino>();
            Destino des1 = new Destino("Canelones", "Montevideo", "Uruguay", 2500);
            Destino des2 = new Destino("Cancun", "Mexico DF", "Mexico", 5000);
            Destino des3 = new Destino("Baticano","Roma","Grecia", 9000);
            Destino des4 = new Destino("Bs. As", "Bs. As.", "Argentina", 500);
            Destino des5 = new Destino("Bahia", "Sao Pablo","Brasil", 3500);
            Destino des6 = new Destino("San Carlos", "Maldonado", "Uruguay", 100);
            destinos.Add(des1);
            destinos.Add(des2);
            destinos.Add(des3);
            destinos.Add(des4);
            destinos.Add(des5);
            destinos.Add(des6);
            Cliente c1 = new Cliente("Ruben","Rada",83933892);
            Cliente c2 = new Cliente("Jaime", "Roos", 21832879);
            Cliente c3 = new Cliente("Mauricio","Ubal", 18988730);
            Cliente c4 = new Cliente("Tabare", "Cardozo", 79874631);
            clientes.Add(c1);
            clientes.Add(c2);
            clientes.Add(c3);
            clientes.Add(c4);
        }
        public List<Destino> DarDestinos() 
        {
            List<Destino> auxDestinos = new List<Destino>();
            foreach (Destino d in destinos) 
            {
                auxDestinos.Add(d);
            }
            return auxDestinos;
        }
        public List<Excursion> DarExcursiones()
        {
            List<Excursion> auxExcursion = new List<Excursion>();
            foreach (Excursion e in excursiones)
            {
                auxExcursion.Add(e);
            }
            return auxExcursion;
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
        public void AgregarExcursion(Excursion e)
        {
            excursiones.Add(e);
        }
        public void AgregarClienteExcursion(Excursion exc, Cliente c) 
        {
            int conteo = 0;
            foreach (Excursion excursionsita in excursiones) 
            {
                if (excursionsita.Codigo == exc.Codigo) 
                    excursiones[conteo].AgregarCliente(c);
                conteo++;
            }
        }
        public void AgregarPuntosCliente(Cliente c) 
        {
            int conteo=0;
            foreach (Cliente clientito in clientes) 
            {
                if (clientito.Codigo == c.Codigo)
                    clientes[conteo].Puntos += 1;
                conteo++;
            }
        }
        public List<Excursion> DarExcursionesDeUnDestino(Destino d) 
        {
            List<Excursion> auxExcursiones = new List<Excursion>();
            foreach (Excursion excursionsita in excursiones) 
            {
                foreach (DestinoEstadia des in excursionsita.DestinoEstadia) 
                {
                    if (des.Destino == d)
                        auxExcursiones.Add(excursionsita);
                }
            }
            return auxExcursiones;
        }
        public List<Excursion> DarExcursionesPorFechas(DateTime fec1, DateTime fec2)
        {
            List<Excursion> auxExcursion = new List<Excursion>();
            foreach (Excursion e in excursiones)
            {
                if (e.FechaComienzo < fec1 && e.FechaComienzo > fec2)
                    auxExcursion.Add(e);
            }
            return auxExcursion;
        }
        public List<Cliente> DarClientesConMayorRanking()
        {
            List<Cliente> auxCliente = new List<Cliente>();
            foreach (Cliente c in clientes)
            {
                foreach(Excursion exc in excursiones)
                {
                    if (exc.FechaComienzo >= DateTime.Now.AddYears(-1))
                    {
                        foreach (Cliente cli in exc.DarClientes())
                        {
                            if (c == cli && !auxCliente.Contains(c))
                                auxCliente.Add(c);
                        }
                    }
                }
            }
            auxCliente.Sort();
            if (auxCliente.Count > 10)
                auxCliente.RemoveRange(10, auxCliente.Count - 10);
            return auxCliente;
        }
    }
}
