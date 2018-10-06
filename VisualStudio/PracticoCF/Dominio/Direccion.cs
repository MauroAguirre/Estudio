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
    public class Direccion
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public virtual int Id { get; set; }
        [Required(ErrorMessage = "El nombre de la calle es un dato requerido.")]
        [StringLength(50)]
        public virtual string Calle { get; set; }
        [Required(ErrorMessage = "El número de puerta es un dato requerido.")]
        public virtual int Numero { get; set; }
        public virtual Cliente ElCliente { get; set; }
    }
}
