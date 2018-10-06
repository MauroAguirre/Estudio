using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repaso_parcial_1
{
    class Portatebien
    {
        private List<Cliente> clientes;
        private List<Empleado> empleados;
        private List<Servicio> servicios;
        public void AltaServicio()
        {
        
        }
        public int RetornarPorcentajeServicioCliente(Cliente cliente) 
        {
            return cliente.PorcentajeServiciosRelizados();
        }
        public int SueldoEmpleadoEn6Meses(Empleado empleado) 
        {
            return empleado.RetornarSueldo6Meses();
        }
    }
}
