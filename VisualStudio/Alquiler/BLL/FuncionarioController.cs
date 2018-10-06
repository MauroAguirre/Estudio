using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace BLL
{
    class FuncionarioController
    {
        public void Agregar(int id, string nombre)
        {
            Funcionario funcionario = new Funcionario();
            funcionario.ID = id;
            funcionario.Nombre = nombre;
        }
    }
}
