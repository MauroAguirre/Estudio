using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace DAL
{
    public class FuncionarioService
    {
        public void Agregar(Funcionario funcionario)
        {
            using (var db = new AlquilerContext())
            {
                db.Funcionarios.Add(funcionario);
                db.SaveChanges();
            }
        }
        public List<Funcionario> DarFuncionarios()
        {
            List<Funcionario> funcionarios = new List<Funcionario>();
            using (var db = new AlquilerContext())
            {
                foreach (var fun in db.Funcionarios)
                {
                    Funcionario funcionario = new Funcionario() { Documento = fun.Documento, Nombre = fun.Nombre ,ID=fun.ID};
                    funcionarios.Add(funcionario);
                }
            }
            return funcionarios;
        }
    }
}
