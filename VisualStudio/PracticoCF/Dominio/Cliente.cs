using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Dominio
{
    public class Cliente
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public virtual int Id { get; set; }
        [Required(ErrorMessage = "La cédula es un dato requerido.")]
        public virtual string Ci { get; set; }
        [Required(ErrorMessage = "El nombre es un dato requerido.")]
        [StringLength(50)]
        public virtual string Mail { get; set; }
        public virtual string Nombre { get; set; }
        public virtual List<Direccion> Direcciones { get; set; }
        public virtual string Apellido { get; set; }
        [NotMapped]
        public virtual bool Seleccionado { get; set; }
        public Cliente()
        {
            Direcciones = new List<Direccion>();
        }
    }
}
