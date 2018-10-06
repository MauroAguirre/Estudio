using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using DAL;

namespace BLL
{
    public class FuncionarioController
    {
        FuncionarioService funcionarioService = new FuncionarioService();
        public void Agregar(Funcionario funcionario)
        {
            funcionarioService.Agregar(funcionario);
        }
        public List<Funcionario> DarFuncionarios()
        {
            return funcionarioService.DarFuncionarios();
        }
    }
}
