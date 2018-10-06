using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dominio;
namespace probando.Models
{
    public class Personas
    {
        public List<Cliente> clientes;
        public List<Funcionario> funcionarios;
        public Personas(List<Cliente> clientes,List<Funcionario> funcionarios)
        {
            this.clientes = clientes;
            this.funcionarios = funcionarios;
        }
    }
}