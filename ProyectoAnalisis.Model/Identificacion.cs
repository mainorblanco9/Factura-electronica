using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProyectoAnalisis.Model
{
   public class Identificacion
    {
        public int Id { get; set; }
        [Display(Name = "Tioo de identificación ")]
        public TipoIdentificacion Tipo { get; set; }
        [Required]
        [Display(Name = "Número de identificación ")]
        public int Numero { get; set; }
    }
}
